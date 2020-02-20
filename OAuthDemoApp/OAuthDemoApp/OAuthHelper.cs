namespace OAuthDemoApp
{
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    public static class OAuthHelper
    {
        public static async Task<AuthorizationResult> DoHttpPostAsync(string endpoint, string content, NetworkCredential credential = null)
        {
            var (ResponseData, AuthorizationError, Error) = await OAuthHelper.DoHttpPost2Async(endpoint, content, credential);
            var result = OAuthHelper.ParseAuthorizationResult(ResponseData, AuthorizationError, Error);
            return result;
        }

        private static async Task<(string ResponseData, string AuthorizationError, Exception Error)> DoHttpPost2Async(string endpoint, string content, NetworkCredential credential = null)
        {
            var postBytes = Encoding.UTF8.GetBytes(content);
            var requestId = Guid.NewGuid().ToString();

            var request = HttpWebRequest.Create(endpoint);
            request.Headers.Add("client-request-id", requestId);

            if (credential == null)
                request.UseDefaultCredentials = true;
            else
                request.Credentials = credential;

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postBytes.Length;

            var result = string.Empty;
            var authorizationError = string.Empty;
            Exception error = null;

            try
            {
                using (var dataStream = await request.GetRequestStreamAsync())
                {
                    await dataStream.WriteAsync(postBytes, 0, postBytes.Length);
                    dataStream.Close();
                }

                var resp = await request.GetResponseAsync();
                using (var reader = new StreamReader(resp.GetResponseStream()))
                {
                    result = (await reader.ReadToEndAsync()).Trim();
                }
            }
            catch (WebException e)
            {
                error = e;
                if (e.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)e.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            //var err = await reader.ReadToEndAsync();
                            //authorizationError = JsonConvert.DeserializeObject(err);
                            authorizationError = await reader.ReadToEndAsync();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                error = e;
            }

            return (result, authorizationError, error);
        }

        public static AuthorizationResult ParseAuthorizationResult(string response, string authorizationError, Exception error)
        {
            var result = new AuthorizationResult();
            result.Exception = error;
            result.Error = authorizationError;
            result.Raw = response;
            try
            {
                dynamic token = JsonConvert.DeserializeObject(response);
                result.AccessToken = token.access_token;
                result.IDToken = token.id_token;
                result.RefreshToken = token.refresh_token;
            }
            catch
            {
            }

            return result;
        }

        private static X509Certificate2 GetCertificate(string thumbprint)
        {
            var store = new X509Store(StoreLocation.CurrentUser);
            try
            {
                store.Open(OpenFlags.ReadOnly);
                var certificate = store.Certificates.Find(X509FindType.FindByThumbprint, thumbprint, false).Cast<X509Certificate2>().FirstOrDefault();
                if (certificate == null)
                {
                    throw new Exception();
                }
                return certificate;
            }
            finally
            {
                store.Close();
            }
        }

        public static string GetCertificateCredentials(string thumbnail, string tokenEndpoint, string clientId)
        {
            var certificate = GetCertificate(thumbnail);

            // Create Header
            var x5t = Base64UrlEncode(certificate.GetCertHash());
            var alg = "RS256";
            // ADFS: var tokenHeader = Base64UrlEncode($"{{\"alg\":\"{alg}\",\"x5t\":\"{x5t}\"}}"); Azure AD needs typ: JWT
            var tokenHeader = Base64UrlEncode($"{{\"alg\":\"{alg}\",\"typ\":\"JWT\",\"x5t\":\"{x5t}\"}}");

            // Create Payload
            var nbf = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            var exp = nbf + (60 * 10);
            var jti = Guid.NewGuid().ToString();
            var tokenContent = Base64UrlEncode($"{{\"aud\":\"{tokenEndpoint}\",\"exp\":{exp},\"iss\":\"{clientId}\",\"jti\":\"{jti}\",\"nbf\":{nbf},\"sub\":\"{clientId}\"}}");

            // Create Signature
            // Create Payload Hash
            var bytesToSign = Encoding.UTF8.GetBytes($"{tokenHeader}.{tokenContent}");
            var sha256 = SHA256.Create();
            var hash = sha256.ComputeHash(bytesToSign);
            // Create Signature
            var cryptoProvider = (RSACryptoServiceProvider)certificate.PrivateKey;
            var cryptoDescription = new ManagedSHA256SignatureDescription();
            var formatter = cryptoDescription.CreateFormatter(certificate.PrivateKey);
            formatter.SetHashAlgorithm("SHA256");
            var signature = formatter.CreateSignature(hash);
            var tokenSignature = Base64UrlEncode(signature);

            // Create JWT
            var clientCred = $"{tokenHeader}.{tokenContent}.{tokenSignature}";
            return clientCred;
        }

        public static string Base64UrlEncode(byte[] inputBytes)
        {
            return Convert.ToBase64String(inputBytes).TrimEnd('=').Replace('+', '-').Replace('/', '_');
        }

        public static byte[] Base64UrlDecode(string input)
        {
            var output = input;
            output = output.Replace('+', '-').Replace('/', '_');
            int mod4 = output.Length % 4;
            if (mod4 > 0)
            {
                output += new string('=', 4 - mod4);
            }
            var converted = Convert.FromBase64String(output);
            return converted;
        }

        public static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Base64UrlEncode(inputBytes);
        }

        public static string FormatJson(dynamic json)
        {
            var result = string.Empty;
            if (json == null)
            {
                return result;
            }

            try
            {
                result = JsonConvert.SerializeObject(json, Formatting.Indented);
            }
            catch
            {
                result = json;
            }

            return result;
        }

        public static string FormatJson(string json)
        {
            var result = string.Empty;

            if (string.IsNullOrEmpty(json))
            {
                return result;
            }

            try
            {
                dynamic parsedJson = JsonConvert.DeserializeObject(json);
                result = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            catch
            {
                result = json;
            }

            return result;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            int mod4 = base64EncodedData.Length % 4;
            if (mod4 > 0)
            {
                base64EncodedData += new string('=', 4 - mod4);
            }

            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string DecodeToken(string jwt)
        {
            if (string.IsNullOrEmpty(jwt))
            {
                return string.Empty;
            }

            var parts = jwt.Split(new char[] { '.' });

            if (parts.Count() != 3)
            {
                return jwt;
            }

            try
            {
                var header = FormatJson(Base64Decode(parts[0]));
                var token = FormatJson(Base64Decode(parts[1]));
                var signature = parts[2];
                return header + Environment.NewLine + "." + Environment.NewLine + token + Environment.NewLine + "." + Environment.NewLine + signature;
            }
            catch
            {
                return jwt;
            }
        }

        private static byte[] Base64Dec(string input)
        {
            var output = input.Replace('-', '+').Replace('_', '/');
            int mod4 = output.Length % 4;
            if (mod4 > 0)
            {
                output += new string('=', 4 - mod4);
            }

            return Convert.FromBase64String(output);
        }

        public static DateTime UnixTimestampToUTC(int unixTimeStamp)
        {
            var result = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            result = result.AddSeconds(unixTimeStamp).ToUniversalTime();
            return result;
        }

        public static bool TryValidateToken(string jwt, dynamic keys, out string errorMessage)
        {
            if (string.IsNullOrEmpty(jwt))
            {
                errorMessage = "Token is null or empty.";
                return false;
            }

            var parts = jwt.Split(new char[] { '.' });

            if (parts.Count() != 3)
            {
                errorMessage = "Token does not contain 3 parts.";
                return false;
            }

            string header;
            string payload;
            byte[] crypto;

            try
            {
                header = parts[0];
                payload = parts[1];
                crypto = Base64Dec(parts[2]);
            }
            catch
            {
                errorMessage = "Invalid token.";
                return false;
            }

            var bytesToSign = Encoding.UTF8.GetBytes($"{header}.{payload}");

            dynamic desHeader = JsonConvert.DeserializeObject(Base64Decode(header));
            dynamic desPayload = JsonConvert.DeserializeObject(Base64Decode(payload));

            // check iss: issuer

            if (UnixTimestampToUTC((int)desPayload.nbf) > DateTime.UtcNow)
            {
                errorMessage = "Token is not yet valid.";
                return false;
            }

            if (UnixTimestampToUTC((int)desPayload.exp) < DateTime.UtcNow)
            {
                errorMessage = "Token has expired.";
                return false;
            }

            var algorithm = (string)desHeader.alg;

            var key = string.Empty;
            var exponent = string.Empty;
            var issuer = string.Empty;

            foreach (dynamic k in keys.keys)
            {
                if ((((string)k.kid == (string)desHeader.kid) || ((string)k.x5t == (string)desHeader.x5t)) && (string)k.use == "sig")
                {
                    //key = (string)k.x5c[0];
                    key = (string)k.n;
                    exponent = (string)k.e;
                    issuer = (string)k.issuer;
                    break;
                }
            }

            if (string.IsNullOrEmpty(key))
            {
                errorMessage = "Could not find encryption key. (Not using x5c, using n.)";
                return false;
            }

            if (issuer != (string)desPayload.iss)
            {
                errorMessage = $"Issuer {desPayload.iss} does not match expected issuer {issuer}.";
                return false;
            }

            var rsa = new RSACryptoServiceProvider();
            rsa.ImportParameters(
              new RSAParameters()
              {
                  Modulus = Base64Dec(key),
                  Exponent = Base64Dec(exponent)
              });

            RSAPKCS1SignatureDeformatter rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
            HashAlgorithm sha;
            switch (algorithm.ToUpper())
            {
                case "RS256":
                    sha = SHA256.Create();
                    rsaDeformatter.SetHashAlgorithm("SHA256");
                    break;
                case "HS384":
                    sha = SHA384.Create();
                    rsaDeformatter.SetHashAlgorithm("SHA348");
                    break;
                case "HS512":
                    sha = SHA512.Create();
                    rsaDeformatter.SetHashAlgorithm("SHA512");
                    break;
                default:
                    errorMessage = $"Unsupported encryption type '{algorithm}'.";
                    return false;
            }

            byte[] signature = sha.ComputeHash(bytesToSign);

            if (!rsaDeformatter.VerifySignature(signature, crypto))
            {
                errorMessage = "Invalid signature.";
                return false;
            }

            errorMessage = "";
            return true;
        }
    }
}
