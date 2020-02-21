/*
 * Client ID's:
 * Tutorial Sample App: 6731de76-14a6-49ae-97bc-6eba6914391e
 * Microsoft Azure PowerShell: 1950a258-227b-4e31-a9cf-717495945fc2
 * 
 * 
 * 
 * 
 * 
 * 
 */

namespace OAuthDemoApp
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices.WindowsRuntime;
    using System.Security;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CbStsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbStsType.SelectedItem)
            {
                case "Active Directory Federation Services":
                    tbAdfsFarmName.Enabled = true;
                    tbAuthEndpoint.Enabled = false;
                    tbTokenEndpoint.Enabled = false;
                    tbDeviceCodeEndpoint.Enabled = false;
                    tbMetadataEndpoint.Enabled = false;
                    gbAzureAD.Enabled = false;
                    break;
                case "Azure Active Directory B2C":
                    tbAdfsFarmName.Enabled = false;
                    tbAuthEndpoint.Enabled = false;
                    tbTokenEndpoint.Enabled = false;
                    tbDeviceCodeEndpoint.Enabled = false;
                    tbMetadataEndpoint.Enabled = false;
                    gbAzureAD.Enabled = true;
                    break;
                case "Azure Active Directory":
                    tbAdfsFarmName.Enabled = false;
                    tbAuthEndpoint.Enabled = false;
                    tbTokenEndpoint.Enabled = false;
                    tbDeviceCodeEndpoint.Enabled = false;
                    tbMetadataEndpoint.Enabled = false;
                    gbAzureAD.Enabled = true;
                    break;
                case "Custom":
                    tbAdfsFarmName.Enabled = false;
                    tbAuthEndpoint.Enabled = true;
                    tbTokenEndpoint.Enabled = true;
                    tbDeviceCodeEndpoint.Enabled = true;
                    tbMetadataEndpoint.Enabled = true;
                    gbAzureAD.Enabled = false;
                    break;
            }

            this.tbAuthEndpoint.Text = GetAuthorizationEndpoint();
            this.tbTokenEndpoint.Text = GetTokenEndpoint();
            this.tbDeviceCodeEndpoint.Text = GetDeviceCodeEndpoint();
            this.tbMetadataEndpoint.Text = GetMetadataEndpoint();
        }
        
        private string GetTokenEndpoint()
        {
            // On V2.0, endpoints can be: /common/, /organizations/, /consumers/, /[tenantid]/ or /tenant.onmicrosoft.com/
            // On v1.0, endpoints can be: /common/,  /[tenantid]/ or /tenant.onmicrosoft.com/
            var result = string.Empty;
            switch (cbStsType.SelectedItem)
            {
                case "Active Directory Federation Services":
                    result = $"https://{this.tbAdfsFarmName.Text}/adfs/oauth2/token";
                    break;
                case "Azure Active Directory":
                    var endpoint = string.Empty;
                    if (rbAzureAdEndpoint_Common.Checked)
                    {
                        endpoint = "common";
                    }
                    else if (rbAzureAdEndpoint_Consumers.Checked)
                    {
                        endpoint = "consumers";
                    }
                    else if (rbAzureAdEndpoint_Organizations.Checked)
                    {
                        endpoint = "organizations";
                    }
                    else if (rbAzureAdEndpoint_Tenant.Checked)
                    {
                        endpoint = tbAadTenant.Text + ".onmicrosoft.com";
                    }

                    if (rbAzureADv1.Checked)
                    {
                        result = $"https://login.microsoftonline.com/{endpoint}/oauth2/token";
                    }
                    else if (rbAzureADv2.Checked)
                    {
                        result = $"https://login.microsoftonline.com/{endpoint}/oauth2/v2.0/token";
                    }
                    break;
                case "Azure Active Directory B2C":
                    result = $"https://{this.tbAadTenant.Text}.b2clogin.com/{this.tbAadTenant.Text}.onmicrosoft.com/oauth2/v2.0/token";
                    break;
                case "Custom":
                    result = this.tbTokenEndpoint.Text;
                    break;
            }

            return result;
        }
        
        private string GetAuthorizationEndpoint()
        {
            // On V2.0, endpoints can be: /common/, /organizations/, /consumers/, /[tenantid]/ or /tenant.onmicrosoft.com/
            // On v1.0, endpoints can be: /common/,  /[tenantid]/ or /tenant.onmicrosoft.com/
            var result = string.Empty;
            switch (cbStsType.SelectedItem)
            {
                case "Active Directory Federation Services":
                    result = $"https://{this.tbAdfsFarmName.Text}/adfs/oauth2/authorize";
                    break;
                case "Azure Active Directory":
                    var endpoint = string.Empty;
                    if (rbAzureAdEndpoint_Common.Checked)
                    {
                        endpoint = "common";
                    }
                    else if (rbAzureAdEndpoint_Consumers.Checked)
                    {
                        endpoint = "consumers";
                    }
                    else if (rbAzureAdEndpoint_Organizations.Checked)
                    {
                        endpoint = "organizations";
                    }
                    else if (rbAzureAdEndpoint_Tenant.Checked)
                    {
                        endpoint = tbAadTenant.Text + ".onmicrosoft.com";
                    }

                    if (rbAzureADv1.Checked)
                    {
                        result = $"https://login.microsoftonline.com/{endpoint}/oauth2/authorize";
                    }
                    else if (rbAzureADv2.Checked)
                    {
                        result = $"https://login.microsoftonline.com/{endpoint}/oauth2/v2.0/authorize";
                    }
                    break;
                case "Azure Active Directory B2C":
                    result = $"https://{this.tbAadTenant.Text}.b2clogin.com/{this.tbAadTenant.Text}.onmicrosoft.com/oauth2/v2.0/authorize";
                    break;
                case "Custom":
                    result = this.tbAuthEndpoint.Text;
                    break;
            }

            return result;
        }

        private string GetMetadataEndpoint()
        {
            // On V2.0, endpoints can be: /common/, /organizations/, /consumers/, /[tenantid]/ or /tenant.onmicrosoft.com/
            // On v1.0, endpoints can be: /common/,  /[tenantid]/ or /tenant.onmicrosoft.com/
            var result = string.Empty;
            switch (cbStsType.SelectedItem)
            {
                case "Active Directory Federation Services":
                    result = $"https://{this.tbAdfsFarmName.Text}/adfs/.well-known/openid-configuration";
                    break;
                case "Azure Active Directory":
                    var endpoint = string.Empty;
                    if (rbAzureAdEndpoint_Common.Checked)
                    {
                        endpoint = "common";
                    }
                    else if (rbAzureAdEndpoint_Consumers.Checked)
                    {
                        endpoint = "consumers";
                    }
                    else if (rbAzureAdEndpoint_Organizations.Checked)
                    {
                        endpoint = "organizations";
                    }
                    else if (rbAzureAdEndpoint_Tenant.Checked)
                    {
                        endpoint = tbAadTenant.Text + ".onmicrosoft.com";
                    }

                    if (rbAzureADv1.Checked)
                    {
                        result = $"https://login.microsoftonline.com/{endpoint}/.well-known/openid-configuration";
                    }
                    else if (rbAzureADv2.Checked)
                    {
                        result = $"https://login.microsoftonline.com/{endpoint}/v2.0/.well-known/openid-configuration";
                    }
                    break;
                case "Azure Active Directory B2C":
                    result = $"https://{this.tbAadTenant.Text}.b2clogin.com/{this.tbAadTenant.Text}.onmicrosoft.com/v2.0/.well-known/openid-configuration";
                    break;
                case "Custom":
                    result = this.tbMetadataEndpoint.Text;
                    break;
            }

            return result;
        }

        private string GetDeviceCodeEndpoint()
        {
            // On V2.0, endpoints can be: /common/, /organizations/, /consumers/, /[tenantid]/ or /tenant.onmicrosoft.com/
            // On v1.0, endpoints can be: /common/,  /[tenantid]/ or /tenant.onmicrosoft.com/
            var result = string.Empty;
            switch (cbStsType.SelectedItem)
            {
                case "Active Directory Federation Services":
                    result = $"https://{this.tbAdfsFarmName.Text}/adfs/oauth2/devicecode";
                    break;
                case "Azure Active Directory":
                    var endpoint = string.Empty;
                    if (rbAzureAdEndpoint_Common.Checked)
                    {
                        endpoint = "common";
                    }
                    else if (rbAzureAdEndpoint_Consumers.Checked)
                    {
                        endpoint = "consumers";
                    }
                    else if (rbAzureAdEndpoint_Organizations.Checked)
                    {
                        endpoint = "organizations";
                    }
                    else if (rbAzureAdEndpoint_Tenant.Checked)
                    {
                        endpoint = tbAadTenant.Text + ".onmicrosoft.com";
                    }

                    if (rbAzureADv1.Checked)
                    {
                        result = $"https://login.microsoftonline.com/{endpoint}/oauth2/devicecode";
                    }
                    else if (rbAzureADv2.Checked)
                    {
                        result = $"https://login.microsoftonline.com/{endpoint}/oauth2/v2.0/devicecode";
                    }
                    break;
                case "Azure Active Directory B2C":
                    result = $"https://{this.tbAadTenant.Text}.b2clogin.com/{this.tbAadTenant.Text}.onmicrosoft.com/oauth2/v2.0/devicecode";
                    break;
                case "Custom":
                    result = this.tbDeviceCodeEndpoint.Text;
                    break;
            }

            return result;
        }

        private void GenerateStsEndpoints(object sender, EventArgs e)
        {
            // On V2.0, endpoints can be: /common/, /organizations/, /consumers/, /[tenantid]/ or /tenant.onmicrosoft.com/
            // On v1.0, endpoints can be: /common/,  /[tenantid]/ or /tenant.onmicrosoft.com/
            this.tbAuthEndpoint.Text = GetAuthorizationEndpoint();
            this.tbTokenEndpoint.Text = GetTokenEndpoint();
            this.tbDeviceCodeEndpoint.Text = GetDeviceCodeEndpoint();
            this.tbMetadataEndpoint.Text = GetMetadataEndpoint();
        }

        private void ChangeAzureAdVersion(object sender, EventArgs e)
        {
            if (rbAzureADv1.Checked)
            {
                rbAzureAdEndpoint_Organizations.Enabled = false;
                rbAzureAdEndpoint_Consumers.Enabled = false;
                if (rbAzureAdEndpoint_Organizations.Checked || rbAzureAdEndpoint_Consumers.Checked)
                {
                    rbAzureAdEndpoint_Tenant.Checked = true;
                }
            }

            if (rbAzureADv2.Checked)
            {
                rbAzureAdEndpoint_Organizations.Enabled = true;
                rbAzureAdEndpoint_Consumers.Enabled = true;
            }

            GenerateStsEndpoints(sender, e);
        }

        private void CbClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbClientType.SelectedItem)
            {
                case "Public Client":
                    gbClientCredential_Cert.Enabled = false;
                    gbClientCredential_WIA.Enabled = false;
                    gbClientCredential_Secret.Enabled = false;
                    break;
                case "Confidential Client - Client Credentials":
                    gbClientCredential_Cert.Enabled = false;
                    gbClientCredential_WIA.Enabled = false;
                    gbClientCredential_Secret.Enabled = true;
                    break;
                case "Confidential Client - Windows Integrated Authentication":
                    gbClientCredential_Cert.Enabled = false;
                    gbClientCredential_WIA.Enabled = true;
                    gbClientCredential_Secret.Enabled = false;
                    break;
                case "Confidential Client - Certificate-Based Authentication":
                    gbClientCredential_Cert.Enabled = true;
                    gbClientCredential_WIA.Enabled = false;
                    gbClientCredential_Secret.Enabled = false;
                    break;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RbResource_CheckedChanged(object sender, EventArgs e)
        {
            if (rbResource.Checked)
            {
                this.tbScope.Enabled = false;
                this.tbResource.Enabled = true;
            }
        }

        private void RbScope_CheckedChanged(object sender, EventArgs e)
        {
            if (rbScope.Checked)
            {
                this.tbScope.Enabled = true;
                this.tbResource.Enabled = false;
            }
        }

        private void ValidateAuthorizationServerTab(object sender, EventArgs e)
        {
            if (cbStsType.SelectedItem == null)
            {
                MessageBox.Show("Select an STS type first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbStsType.SelectedItem.ToString() == "Azure Active Directory B2C")
            {
                MessageBox.Show("This STS is currently not supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (ValidateUrl(tbTokenEndpoint.Text) && ValidateUrl(tbAuthEndpoint.Text) && ValidateUrl(tbDeviceCodeEndpoint.Text))
            //{
            tcMain.SelectedIndex++;
            //}
            //else
            //{
            //    MessageBox.Show("At least one of your endpoints is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void ValidateClientTab(object sender, EventArgs e)
        {
            if (cbStsType.SelectedItem == null)
            {
                MessageBox.Show("Select an STS type first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbClientType.SelectedItem == null)
            {
                MessageBox.Show("Select a Client type first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbStsType.SelectedItem.ToString() != "Active Directory Federation Services" && cbClientType.SelectedItem.ToString() == "Confidential Client - Windows Integrated Authentication")
            {
                MessageBox.Show("Windows Integrated Authentication is only supported on Active Directory Federation Services.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (cbClientType.SelectedItem)
            {
                case "Confidential Client - Client Credentials":
                    if (string.IsNullOrEmpty(tbClientSecret.Text))
                    {
                        MessageBox.Show("You need to enter a client secret for this client type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    break;
                case "Confidential Client - Certificate-Based Authentication":
                    if (string.IsNullOrEmpty(tbClientCredentials_Cert_CertSN.Text))
                    {
                        MessageBox.Show("You need to select a certificate for this client type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    break;
                case "Confidential Client - Windows Integrated Authentication":
                    if (rbClientCredential_WIA_Credentials_Other.Checked)
                    {
                        if (string.IsNullOrEmpty(tbClientCredential_WIA_Credentials_Other_UserName.Text))
                        {
                            MessageBox.Show("You need to enter a username for this client type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (string.IsNullOrEmpty(tbClientCredential_WIA_Credentials_Other_Password.Text))
                        {
                            MessageBox.Show("You need to enter a password for this client type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    break;
            }

            tcMain.SelectedIndex++;
        }

        private void ValidateResourceTab(object sender, EventArgs e)
        {
            // Empty resource can be used with Azure AD v1 endpoints.
            //if (rbResource.Checked && string.IsNullOrEmpty(tbResource.Text))
            //{
            //    MessageBox.Show("You need to enter the a resource value when using the resource parameter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            if (rbScope.Checked && tbScope.Lines.All(l => string.IsNullOrEmpty(l)))
            {
                MessageBox.Show("You need to enter at least 1 scope when using scopes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbScope.Checked && cbStsType.SelectedItem.ToString() == "Azure Active Directory")
            {
                if (rbAzureADv1.Checked)
                {
                    MessageBox.Show("Azure Active Directory v1 endpoints use the Resource paramter, not Scopes. The scope parameter is ignored.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (rbAzureADv2.Checked)
                {
                    if (tbScope.Lines.All(l => string.IsNullOrWhiteSpace(l)))
                    {
                        MessageBox.Show("You need to define at least 1 scope.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (rbResource.Checked && cbStsType.SelectedItem.ToString() == "Azure Active Directory" && rbAzureADv2.Checked)
            {
                MessageBox.Show("Azure Active Directory v2 endpoints use Scopes, not the Resource parameter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tcMain.SelectedIndex++;
        }

        private void ValidateGrantTab(object sender, EventArgs e)
        {
            if (cbClientType.SelectedItem == null)
            {
                MessageBox.Show("Select a Client type first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbGrantFlow.SelectedItem == null)
            {
                MessageBox.Show("Select a grant/flow first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (cbGrantFlow.SelectedItem)
            {
                case "Client Credentials":
                    if (cbClientType.SelectedItem.ToString() == "Public Client")
                    {
                        MessageBox.Show("You cannot use Client Credentials Grant with a Public Client", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (cbStsType.SelectedItem.ToString() == "Azure Active Directory" && !rbAzureAdEndpoint_Tenant.Checked)
                    {
                        MessageBox.Show("Client Credentials flow on an Azure Active Directory endpoint is only supported on a tenant identifying endpoint.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    break;
                case "Resource Owner Password Credentials":
                    if (string.IsNullOrEmpty(tb_ClientCredentials_UseROP_Username.Text))
                    {
                        MessageBox.Show("Resource Owner Password Credentials requires you to enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrEmpty(tb_ClientCredentials_UseROP_Password.Text))
                    {
                        MessageBox.Show("Resource Owner Password Credentials requires you to enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (cbStsType.SelectedItem.ToString() == "Azure Active Directory" && rbAzureADv2.Checked && (rbAzureAdEndpoint_Consumers.Checked || rbAzureAdEndpoint_Common.Checked))
                    {
                        // Azure AD v2 ROP cannot use /consumers/ or /common/ but can use /organizations/  or /tenant/ https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-oauth-ropc
                        MessageBox.Show("Resource Owner Password Credentials flow on an Azure Active Directory V2 endpoint does not support the consumers or common endpoints.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    break;
                case "Device Code":
                    if (cbClientType.SelectedItem.ToString() != "Public Client")
                    {
                        //https://github.com/AzureAD/microsoft-authentication-library-for-dotnet/wiki/Device-Code-Flow
                        MessageBox.Show("Device Code Flow is only available for Public Clients", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case "Authorization Code":
                    // TODO :CHECKS HERE
                    break;
                case "Implicit Grant":
                    // TODO :CHECKS HERE
                    break;
                case "On-Behalf-Of":
                    // TODO : MORE CHECKS HERE
                    if (string.IsNullOrEmpty(tbAccessToken.Text))
                    {
                        MessageBox.Show("Obtain an Access Token first, using one of the other flows, then try the On-Behalf-Of flow.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    break;
                case "Hybrid":
                    // TODO :CHECKS HERE
                    break;
            }

            tcMain.SelectedIndex++;
        }

        private void ValidateOptionsTab(object sender, EventArgs e)
        {
            ExecuteMainAsync();
            tcMain.SelectedIndex++;
        }

        private async void ExecuteMainAsync()
        {
            var useAdal = rbPreferADAL.Checked;
            var useMsal = rbPreferMSAL.Checked;
            var useHttp = rbPreferHttp.Checked;
            var flow = (string)cbGrantFlow.SelectedItem;

            if (useAdal)
            {
                MessageBox.Show("Currently not supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (useMsal)
            {
                MessageBox.Show("Currently not supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //(dynamic Result, dynamic AuthorizationError, Exception Error) result = (null, null, null);
            AuthorizationResult result = null;

            if (useHttp)
            {
                switch (flow)
                {
                    case "Client Credentials":
                        result = await ExecuteClientCredentialsFlow_Http();
                        break;
                    case "Resource Owner Password Credentials":
                        result = await ExecuteResourceOwnerPasswordCredentialsFlow_Http();
                        break;
                    case "Device Code":
                        result = await ExecuteDeviceCodeFlow_Http();
                        break;
                    case "Authorization Code":
                        result = await ExecuteAuthorizationCodeFlow_Http();
                        break;
                    case "Implicit Grant":
                        result = ExecuteImplicitFlow_Http();
                        break;
                    case "On-Behalf-Of":
                        result = await ExecuteOnBehalfOfFlow_Http();
                        break;
                    case "Hybrid":
                        result = await ExecuteHybridFlow_Http();
                        break;
                }
            }

            DisplayResults(result);
        }

        private bool ValidateUrl(string url)
        {
            try
            {
                var request = WebRequest.Create(url) as HttpWebRequest;
                request.Timeout = 2500;
                request.Method = "GET";
                var response = request.GetResponse() as HttpWebResponse;
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
        }

        private void BtnClientCredentials_Cert_SelectCert_Click(object sender, EventArgs e)
        {
            var store = new X509Store("MY", StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            var collection = (X509Certificate2Collection)store.Certificates;
            collection = (X509Certificate2Collection)collection.Find(X509FindType.FindByTimeValid, DateTime.Now, true);
            collection = X509Certificate2UI.SelectFromCollection(collection, "Select authentication certificate.", "Select a certificate from the following list use during client authentication.", X509SelectionFlag.SingleSelection);
            if (collection.Count == 1)
            {
                if (!collection[0].HasPrivateKey)
                {
                    MessageBox.Show("This certificate does not have a private key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tbClientCredentials_Cert_CertSN.Text = collection[0].Thumbprint;
                }
            }

            store.Close();
        }

        private async void BtnGetMetadata_Click(object sender, EventArgs e)
        {
            var endpoint = tbMetadataEndpoint.Text;
            var request = HttpWebRequest.Create(endpoint);

            try
            {
                var resp = await request.GetResponseAsync();
                using (var reader = new StreamReader(resp.GetResponseStream()))
                {
                    var response = (await reader.ReadToEndAsync()).Trim();
                    MessageBox.Show(response);
                }
            }
            catch (WebException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void CbGrantFlow_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbGrantFlow.SelectedItem)
            {
                case "Client Credentials":
                case "Authorization Code":
                    gbROPCFlow.Enabled = false;
                    gbOnBehalfOf.Enabled = false;
                    gbHybridFlow.Enabled = false;
                    gbDeviceCodeFlow.Enabled = false;
                    break;
                case "Device Code":
                    gbROPCFlow.Enabled = false;
                    gbOnBehalfOf.Enabled = false;
                    gbHybridFlow.Enabled = false;
                    gbDeviceCodeFlow.Enabled = true;
                    break;
                case "Resource Owner Password Credentials":
                    gbROPCFlow.Enabled = true;
                    gbOnBehalfOf.Enabled = false;
                    gbHybridFlow.Enabled = false;
                    gbDeviceCodeFlow.Enabled = false;
                    break;
                case "Implicit Grant":
                    gbROPCFlow.Enabled = false;
                    gbOnBehalfOf.Enabled = false;
                    gbHybridFlow.Enabled = true;
                    gbDeviceCodeFlow.Enabled = false;
                    cbHybridFlow_Implicit_RequestCode.Enabled = false;
                    cbHybridFlow_Implicit_RequestCode.Visible = false;
                    break;
                case "On-Behalf-Of":
                    gbROPCFlow.Enabled = false;
                    gbOnBehalfOf.Enabled = true;
                    gbHybridFlow.Enabled = false;
                    gbDeviceCodeFlow.Enabled = false;
                    break;
                case "Hybrid":
                    gbROPCFlow.Enabled = false;
                    gbOnBehalfOf.Enabled = false;
                    gbHybridFlow.Enabled = true;
                    gbDeviceCodeFlow.Enabled = false;
                    cbHybridFlow_Implicit_RequestCode.Enabled = true;
                    cbHybridFlow_Implicit_RequestCode.Visible = true;
                    break;
            }
        }

        /*
        private string GenerateClientAuthenticationContent(out NetworkCredential networkCredential)
        {
            var clientId = tbClientId.Text;
            var clientType = (string)cbClientType.SelectedItem;
            var clientSecret = tbClientSecret.Text;
            var certThumbprint = tbClientCredentials_Cert_CertSN.Text;
            var tokenEndpoint = tbTokenEndpoint.Text;
            var username = tbClientCredential_WIA_Credentials_Other_UserName.Text;
            var password = tbClientCredential_WIA_Credentials_Other_Password.Text;

            var result = $"client_id={clientId}";
            networkCredential = null;

            switch (clientType)
            {
                case "Confidential Client - Client Credentials":
                    result += $"&client_secret={clientSecret}";
                    break;
                case "Confidential Client - Certificate-Based Authentication":
                    var clientCertificateCredentials = OAuthHelper.GetCertificateCredentials(certThumbprint, tokenEndpoint, clientId);
                    result += $"&client_assertion_type=urn:ietf:params:oauth:client-assertion-type:jwt-bearer" +
                        $"&client_assertion={clientCertificateCredentials}";
                    break;
                case "Confidential Client - Windows Integrated Authentication":
                    networkCredential = new NetworkCredential(username, password);
                    result += "&use_windows_client_authentication=true";
                    break;
            }

            return result;
        }
        */

        private string GenerateResourceOrScopeContent(bool includeAnd = true)
        {
            var result = string.Empty;
            var useResource = rbResource.Checked;
            var resource = tbResource.Text;
            var useScope = rbScope.Checked;
            var scopes = tbScope.Lines;

            if (useResource && !string.IsNullOrEmpty(resource))
                result += $"resource={resource}";

            if (useScope)
                result += "scope=" + string.Join(" ", scopes.Where(l => !string.IsNullOrEmpty(l)));

            if (!string.IsNullOrEmpty(result) && includeAnd)
                result = $"&{result}";

            return result;
        }

        private string GenerateGenericContent(out NetworkCredential networkCredential)
        {
            var clientId = tbClientId.Text;
            var clientType = (string)cbClientType.SelectedItem;
            var clientSecret = tbClientSecret.Text;
            var certThumbprint = tbClientCredentials_Cert_CertSN.Text;
            var tokenEndpoint = tbTokenEndpoint.Text;
            var username = tbClientCredential_WIA_Credentials_Other_UserName.Text;
            var password = tbClientCredential_WIA_Credentials_Other_Password.Text;

            var result = $"client_id={clientId}";
            networkCredential = null;

            switch (clientType)
            {
                case "Confidential Client - Client Credentials":
                    result += $"&client_secret={clientSecret}";
                    break;
                case "Confidential Client - Certificate-Based Authentication":
                    var clientCertificateCredentials = OAuthHelper.GetCertificateCredentials(certThumbprint, tokenEndpoint, clientId);
                    result += $"&client_assertion_type=urn:ietf:params:oauth:client-assertion-type:jwt-bearer" +
                        $"&client_assertion={clientCertificateCredentials}";
                    break;
                case "Confidential Client - Windows Integrated Authentication":
                    networkCredential = new NetworkCredential(username, password);
                    result += "&use_windows_client_authentication=true";
                    break;
            }

            var scope = GenerateResourceOrScopeContent(true);

            result += scope;
            return result;

            /*
            var clientAuth = GenerateClientAuthenticationContent(out networkCredential);
            var result = GenerateResourceOrScopeContent(true);
            result = clientAuth + result;

            return result;
            */
        }

        /// <summary>
        /// Executes a Resource Owner Password Credentials Flow.
        /// See also: https://tools.ietf.org/html/rfc6749#section-1.3.3
        /// </summary>
        /// <returns>An <see cref="AuthorizationResult"/> instance with the results of the authorization.</returns>
        private async Task<AuthorizationResult> ExecuteResourceOwnerPasswordCredentialsFlow_Http()
        {
            /* https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-oauth-ropc

The Microsoft identity platform endpoint only supports ROPC for Azure AD tenants, not personal accounts. This means that you must use a tenant-specific endpoint (https://login.microsoftonline.com/{TenantId_or_Name}) or the organizations endpoint.
Personal accounts that are invited to an Azure AD tenant can't use ROPC.
Accounts that don't have passwords can't sign in through ROPC. For this scenario, we recommend that you use a different flow for your app instead.
If users need to use multi-factor authentication (MFA) to log in to the application, they will be blocked instead.
            
             */

            var tokenEndpoint = tbTokenEndpoint.Text;
            var username = tb_ClientCredentials_UseROP_Username.Text;
            var password = tb_ClientCredentials_UseROP_Password.Text;
            var content = "grant_type=password" +
                $"&username={username}" +
                $"&password={password}&" + 
                GenerateGenericContent(out var networkCredential);
            var result = await OAuthHelper.DoHttpPostAsync(tokenEndpoint, content, networkCredential);
            
            return result;
        }

        /// <summary>
        /// Executes a Client Credentials Flow.
        /// See also: https://tools.ietf.org/html/rfc6749#section-1.3.4
        /// </summary>
        /// <returns>An <see cref="AuthorizationResult"/> instance with the results of the authorization.</returns>
        private async Task<AuthorizationResult> ExecuteClientCredentialsFlow_Http()
        {
            var tokenEndpoint = tbTokenEndpoint.Text;
            var state = tbOptions_State.Text;

            var content = $"grant_type=client_credentials&" + GenerateGenericContent(out var networkCredential);

            if (!string.IsNullOrEmpty(state))
                content += $"&state={state}";
            
            var result = await OAuthHelper.DoHttpPostAsync(tokenEndpoint, content, networkCredential);
            return result;
        }

        /// <summary>
        /// Executes a Device Code Flow.
        /// See also: https://tools.ietf.org/html/draft-ietf-oauth-device-flow-15
        /// </summary>
        /// <returns>An <see cref="AuthorizationResult"/> instance with the results of the authorization.</returns>
        private async Task<AuthorizationResult> ExecuteDeviceCodeFlow_Http()
        {
            var tokenEndpoint = tbTokenEndpoint.Text;
            var deviceCodeEndpoint = tbDeviceCodeEndpoint.Text;
            var clientId = tbClientId.Text;
            var useCustomLanguage = cbDeviceCodeFlowMessageLanguage.Checked;
            var customLanguage = (string)cbCultures.SelectedValue;
            var content = GenerateGenericContent(out var networkCredential);

            if (useCustomLanguage)
                deviceCodeEndpoint += $"?mkt={customLanguage}";

            var result = await OAuthHelper.DoHttpPostAsync(deviceCodeEndpoint, content, networkCredential);
            var code = result.Raw;

            if (string.IsNullOrEmpty(result.Error) && result.Exception == null)
            {
                using (var deviceCodeForm = new DeviceCodeForm(clientId, content, tokenEndpoint, code, networkCredential))
                {
                    var dialogResult = deviceCodeForm.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        result = deviceCodeForm.Result;
                        result.Code = code;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Executes an Authorization Code Flow.
        /// See also: https://tools.ietf.org/html/rfc6749#section-1.3.1
        /// </summary>
        /// <returns>An <see cref="AuthorizationResult"/> instance with the results of the authorization.</returns>
        private async Task<AuthorizationResult> ExecuteAuthorizationCodeFlow_Http()
        {
            //var result = new AuthorizationResult();
            
            var tokenEndpoint = tbTokenEndpoint.Text;
            var authEndpoint = tbAuthEndpoint.Text;
            var clientId = tbClientId.Text;
            var redirectUri = tbClientRedirectUri.Text;
            var state = tbOptions_State.Text;
            var responseMode = (string)cbCodeFlow_ResponseMode.SelectedItem;
            var loginHint = tbCodeFlow_LoginHint.Text;
            var domainHint = (string)lbCodeFlow_DomainHint.SelectedItem;
            var prompt = (string)cbCodeFlow_Prompt.SelectedItem;
            var pkceMethod = (string)cbCodeFlow_PKCE_Method.SelectedItem;
            var pkceVerifier = tbCodeFlow_PKCE_Verifier.Text;
            var requestId = Guid.NewGuid().ToString();

            var content = $"client_id={clientId}" + 
                "&response_type=code" +
                $"&redirect_uri={redirectUri}" + 
                GenerateResourceOrScopeContent(true) + 
                $"&client-request-id={requestId}";

            //response_mode = query, fragment, form_post
            //prompt = login, none, consent
            //login_hint = username
            //domain_hint = consumers, organizations
            // code_challange_method: plain, S256
            // code_challange = PKCE
            // https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-oauth2-auth-code-flow

            if (!string.IsNullOrEmpty(state))
                content += $"&state={state}";

            if (!string.IsNullOrEmpty(responseMode))
                content += $"&response_mode={responseMode}";

            if (!string.IsNullOrEmpty(loginHint))
                content += $"&login_hint={loginHint}";

            if (!string.IsNullOrEmpty(domainHint))
                content += $"&domain_hint={domainHint}";

            if (!string.IsNullOrEmpty(prompt))
                content += $"&prompt={prompt}";

            if (!string.IsNullOrEmpty(pkceMethod))
            {
                if (pkceVerifier.Length < 43 || pkceVerifier.Length > 128) // CodeVerifier needs to be 43 to 128 chars. https://tools.ietf.org/html/rfc7636#section-4.1
                {
                    MessageBox.Show("Code verifier should be between 43 and 128 characters.", "Error");
                    return new AuthorizationResult();
                }

                content += $"&code_challenge_method={pkceMethod}";

                string codeChallenge;
                if (pkceMethod == "plain")
                {
                    codeChallenge = pkceVerifier;
                }
                else //S256
                {
                    var bytes = Encoding.UTF8.GetBytes(pkceVerifier);
                    var sha256 = SHA256Managed.Create();
                    var hash = sha256.ComputeHash(bytes);
                    codeChallenge = Convert.ToBase64String(hash).Replace('+', '-').Replace('/', '_').Replace("=", "");
                }

                content += $"&code_challenge={codeChallenge}";
            }

            var codeGrant = new ActiveFlowBrowserForm(authEndpoint, content);
            var codeGrantAuthorizationResult = codeGrant.ProcessRequest();

            if (!string.IsNullOrEmpty(codeGrantAuthorizationResult.Error))
                return codeGrantAuthorizationResult;

            var code = codeGrantAuthorizationResult.Code;
            content = GenerateGenericContent(out var networkCredential) +
                $"&grant_type=authorization_code" +
                $"&redirect_uri={redirectUri}"+
                $"&code={code}";

            if (!string.IsNullOrEmpty(pkceMethod))
                content += $"&code_verifier={pkceVerifier}";

            var result = await OAuthHelper.DoHttpPostAsync(tokenEndpoint, content, networkCredential);
            result.Code = code;
            return result;
        }

        /// <summary>
        /// Executes an Implicit Flow.
        /// See also: https://tools.ietf.org/html/rfc6749#section-1.3.2
        /// </summary>
        /// <returns>An <see cref="AuthorizationResult"/> instance with the results of the authorization.</returns>
        private AuthorizationResult ExecuteImplicitFlow_Http()
        {
            var authEndpoint = tbAuthEndpoint.Text;
            var redirectUri = tbClientRedirectUri.Text;
            var clientId = tbClientId.Text;
            var requestIdToken = cbHybridFlow_Implicit_RequestIdToken.Checked;
            var requestAccessToken = cbHybridFlow_Implicit_RequestAccessToken.Checked;
            var state = tbOptions_State.Text;
            var responseMode = (string)cbCodeFlow_ResponseMode.SelectedItem;
            var loginHint = tbCodeFlow_LoginHint.Text;
            var domainHint = (string)lbCodeFlow_DomainHint.SelectedItem;
            var prompt = (string)cbCodeFlow_Prompt.SelectedItem;
            var nonce = Guid.NewGuid().ToString(); // nonce: A value included in the request, generated by the app, that will be included in the resulting id_token as a claim. The app can then verify this value to mitigate token replay attacks. The value is typically a randomized, unique string that can be used to identify the origin of the request. Only required when an id_token is requested. nonce is only required when requesting an ID token.

            var responseTypes = new List<string>();
            
            if (requestIdToken)
                responseTypes.Add("id_token");

            if (requestAccessToken)
                responseTypes.Add("token");

            var responseType = string.Join("+", responseTypes.ToArray());

            var content = $"client_id={clientId}" +
                $"&response_type={responseType}" +
                $"&redirect_uri={redirectUri}" + 
                GenerateResourceOrScopeContent();

            content += $"&nonce={nonce}";

            //response_mode = query, fragment, form_post
            //prompt = login, none, consent
            //login_hint = username
            //domain_hint = consumers, organizations
            // https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-oauth2-implicit-grant-flow

            if (!string.IsNullOrEmpty(state))
                content += $"&state={state}";

            if (!string.IsNullOrEmpty(responseMode))
            {
                //response_mode: Specifies the method that should be used to send the resulting token back to your app. Defaults to query for an access token, but fragment if the request includes an id_token.
                // AADSTS70007: 'query' is not a supported value of 'response_mode' when requesting a token.

                if (responseMode == "fragment" && responseTypes.Count() > 1)
                {
                    if (MessageBox.Show($"Using 'response_mode=fragment' with 'response_type={responseType}' might cause issues, since our code only supports 2083 character URLs." + Environment.NewLine + Environment.NewLine + "Use form_post instead?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        responseMode = "form_post";
                }

                content += $"&response_mode={responseMode}";
            }

            if (!string.IsNullOrEmpty(loginHint))
                content += $"&login_hint={loginHint}";

            if (!string.IsNullOrEmpty(domainHint))
                content += $"&domain_hint={domainHint}";

            if (!string.IsNullOrEmpty(prompt))
                content += $"&prompt={prompt}";

            var implicitGrant = new ActiveFlowBrowserForm(authEndpoint, content);
            var result = implicitGrant.ProcessRequest();
            return result;
        }

        /// <summary>
        /// Executes a Hybrid Flow.
        /// See also: https://openid.net/specs/openid-connect-core-1_0.html#HybridFlowAuth
        /// </summary>
        /// <returns>An <see cref="AuthorizationResult"/> instance with the results of the authorization.</returns>
        private async Task<AuthorizationResult> ExecuteHybridFlow_Http()
        {
            var result = new AuthorizationResult();

            var tokenEndpoint = tbTokenEndpoint.Text;
            var authEndpoint = tbAuthEndpoint.Text;
            var clientId = tbClientId.Text;
            var redirectUri = tbClientRedirectUri.Text;
            var requestIdToken = cbHybridFlow_Implicit_RequestIdToken.Checked;
            var requestAccessToken = cbHybridFlow_Implicit_RequestAccessToken.Checked;
            var requestCode = cbHybridFlow_Implicit_RequestCode.Checked;
            var state = tbOptions_State.Text;
            var responseMode = (string)cbCodeFlow_ResponseMode.SelectedItem;
            var loginHint = tbCodeFlow_LoginHint.Text;
            var domainHint = (string)lbCodeFlow_DomainHint.SelectedItem;
            var prompt = (string)cbCodeFlow_Prompt.SelectedItem;
            var pkceMethod = (string)cbCodeFlow_PKCE_Method.SelectedItem;
            var pkceVerifier = tbCodeFlow_PKCE_Verifier.Text;
            var nonce = Guid.NewGuid().ToString(); // nonce: A value included in the request, generated by the app, that will be included in the resulting id_token as a claim. The app can then verify this value to mitigate token replay attacks. The value is typically a randomized, unique string that can be used to identify the origin of the request. Only required when an id_token is requested. nonce is only required when requesting an ID token.

            if (requestAccessToken && requestCode)
            {
                MessageBox.Show("You cannot request both an Access Token and a Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }

            var responseTypes = new List<string>();
            
            if (requestIdToken)
                responseTypes.Add("id_token");

            if (requestAccessToken)
                responseTypes.Add("token");

            if (requestCode)
                responseTypes.Add("code");
            
            var responseType = string.Join("+", responseTypes.ToArray());
            var content = $"client_id={clientId}" +
                $"&response_type={responseType}" +
                $"&redirect_uri={redirectUri}" + 
                GenerateResourceOrScopeContent();

            if (!string.IsNullOrEmpty(pkceMethod))
            {
                content += $"&code_challenge_method={pkceMethod}";
                string codeChallenge;
                if (pkceMethod == "plain")
                {
                    codeChallenge = tbCodeFlow_PKCE_Verifier.Text;
                }
                else //S256
                {
                    var bytes = Encoding.UTF8.GetBytes(pkceVerifier);
                    var sha256 = SHA256Managed.Create();
                    var hash = sha256.ComputeHash(bytes);
                    codeChallenge = Convert.ToBase64String(hash).Replace('+', '-').Replace('/', '_').Replace("=", "");
                }

                content += $"&code_challenge={codeChallenge}";
            }

            content += $"&nonce={nonce}";

            //response_mode = query, fragment, form_post
            //prompt = login, none, consent
            //login_hint = username
            //domain_hint = consumers, organizations
            // https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-oauth2-implicit-grant-flow

            if (!string.IsNullOrEmpty(state))
                content += $"&state={state}";

            if (!string.IsNullOrEmpty(responseMode))
            {
                //response_mode: Specifies the method that should be used to send the resulting token back to your app. Defaults to query for an access token, but fragment if the request includes an id_token.
                // AADSTS70007: 'query' is not a supported value of 'response_mode' when requesting a token.

                if (responseMode == "fragment" && responseTypes.Count() > 1)
                {
                    if (MessageBox.Show($"Using 'response_mode=fragment' with 'response_type={responseType}' might cause issues, since our code only supports 2083 character URLs." + Environment.NewLine + Environment.NewLine + "Use form_post instead?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        content += "&response_mode=form_post";
                    else
                        content += $"&response_mode={responseMode}";
                }
                else
                {
                    content += $"&response_mode={responseMode}";
                }
            }

            if (!string.IsNullOrEmpty(loginHint))
                content += $"&login_hint={loginHint}";

            if (!string.IsNullOrEmpty(domainHint))
                content += $"&domain_hint={domainHint}";

            if (!string.IsNullOrEmpty(prompt))
                content += $"&prompt={prompt}";

            var implicitGrant = new ActiveFlowBrowserForm(authEndpoint, content);
            var implicitGrantResult = implicitGrant.ProcessRequest();

            var idToken = implicitGrantResult.IDToken;
            var accessToken = implicitGrantResult.AccessToken;
            var code = implicitGrantResult.Code;
            var error = implicitGrantResult.Error;

            if (!string.IsNullOrEmpty(code) && string.IsNullOrEmpty(error))
            {
                content = GenerateGenericContent(out var networkCredential);
                content += $"&grant_type=authorization_code" +
                    $"&redirect_uri={redirectUri}" +
                    $"&code={code}";
                if (!string.IsNullOrEmpty(pkceMethod))
                    content += $"&code_verifier={pkceVerifier}";

                result = await OAuthHelper.DoHttpPostAsync(tokenEndpoint, content, networkCredential);
            }

            result.Code = code;
            if (string.IsNullOrEmpty(result.Error))
                result.Error = error;
            if (string.IsNullOrEmpty(result.IDToken))
                result.IDToken = idToken;
            if (string.IsNullOrEmpty(result.AccessToken))
                result.AccessToken = accessToken;

            return result;
        }

        /// <summary>
        /// Executes an On-Behalf-Of Flow.
        /// See also: https://tools.ietf.org/html/rfc7521
        /// </summary>
        /// <returns>An <see cref="AuthorizationResult"/> instance with the results of the authorization.</returns>
        private async Task<AuthorizationResult> ExecuteOnBehalfOfFlow_Http()
        {
            var tokenEndpoint = tbTokenEndpoint.Text;
            var clientId = tbOBO_ClientId.Text;
            var clientSecret = tbOBO_ClientSecret.Text;
            var resourceOrScope = tbOBO_ScopeOrResource.Text;
            var accessToken = tbAccessToken.Text;
            var useScope = rbOBO_UseScope.Checked;
            var useResource = rbOBO_UseResource.Checked;

            var resourceOrScopeTag = string.Empty;
            if (useScope)
                resourceOrScopeTag = "scope";

            if (useResource)
                resourceOrScopeTag = "resource";

            var content = $"client_id={clientId}" +
                $"&client_secret={clientSecret}" +
                $"&{resourceOrScopeTag}={resourceOrScope}" +
                $"&grant_type=urn:ietf:params:oauth:grant-type:jwt-bearer" +
                $"&requested_token_use=on_behalf_of" +
                $"&assertion={accessToken}";
            var result = await OAuthHelper.DoHttpPostAsync(tokenEndpoint, content);
            return result;
        }

        private void DisplayResults(AuthorizationResult auth)
        {
            if (auth == null)
            {
                auth = new AuthorizationResult();
            }

            tbAccessToken.Text = auth.AccessToken;
            tbRefreshToken.Text = auth.RefreshToken;
            tbIdToken.Text = auth.IDToken;
            tbCode.Text = auth.Code;
            tbAccessTokenDecoded.Text = OAuthHelper.DecodeToken(auth.AccessToken);
            tbIdTokenDecoded.Text = OAuthHelper.DecodeToken(auth.IDToken);
            
            if (!string.IsNullOrEmpty(auth.Error))
            {
                tbErrors.Text = OAuthHelper.FormatJson(auth.Error);
            }
            else if (auth.Exception != null)
            {
                tbErrors.Text = auth.Exception.Message;
            }
            else
            {
                tbErrors.Text = string.Empty;
            }
        }

        private async void BtnTest_Click(object sender, EventArgs e)
        {
            //test userinfo
            var token = tbAccessToken.Text;
            //var endpoint = "https://login.microsoftonline.com/microsoft.onmicrosoft.com/openid/userinfo";
            var endpoint = "https://graph.microsoft.com/oidc/userinfo";
            var request = WebRequest.Create(endpoint) as HttpWebRequest;
            request.Timeout = 2500;
            request.Method = "GET";
            request.Headers.Add(HttpRequestHeader.Authorization, $"Bearer {token}");
            try
            {
                var resp = await request.GetResponseAsync();
                using (var reader = new StreamReader(resp.GetResponseStream()))
                {
                    var response = (await reader.ReadToEndAsync()).Trim();
                    MessageBox.Show(response);
                }
            }
            catch (WebException err)
            {
                if (err.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)err.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            var errStr = await reader.ReadToEndAsync();
                            MessageBox.Show(errStr);
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BtnAccessValidateToken_Click(object sender, EventArgs e)
        {
            ValidateToken(tbAccessToken.Text);
        }

        private void BtnValidateIdToken_Click(object sender, EventArgs e)
        {
            ValidateToken(tbIdToken.Text);
        }

        private async void ValidateToken(string token)
        {
            // get keys endpoint from metadata.

            var endpoint = tbMetadataEndpoint.Text;
            var request = HttpWebRequest.Create(endpoint);

            try
            {
                var resp1 = await request.GetResponseAsync();
                using (var reader = new StreamReader(resp1.GetResponseStream()))
                {
                    var response = (await reader.ReadToEndAsync()).Trim();
                    var metadata = (dynamic)JsonConvert.DeserializeObject(response);
                    endpoint = metadata.jwks_uri;
                }
            }
            catch (WebException err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            // get keys and validate token.

            dynamic keys;

            //endpoint = "https://login.microsoftonline.com/72f988bf-86f1-41af-91ab-2d7cd011db47/discovery/v2.0/keys";
            request = WebRequest.Create(endpoint) as HttpWebRequest;
            request.Timeout = 2500;
            request.Method = "GET";
            var resp = await request.GetResponseAsync();
            using (var reader = new StreamReader(resp.GetResponseStream()))
            {
                var response = (await reader.ReadToEndAsync()).Trim();
                keys = JsonConvert.DeserializeObject(response);
            }

            if (OAuthHelper.TryValidateToken(token, keys, out string errorMessage))
            {
                MessageBox.Show("The token is valid!", "Token Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMessage, "Token Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tcMain.SelectedIndex)
            {
                case 0:
                    this.AcceptButton = this.btnNext1;
                    break;
                case 1:
                    this.AcceptButton = this.btnNext2;
                    break;
                case 2:
                    this.AcceptButton = this.btnNext3;
                    break;
                case 3:
                    this.AcceptButton = this.btnNext4;
                    break;
                case 4:
                    this.AcceptButton = this.btnExecute;
                    break;
                case 5:
                    this.AcceptButton = null;
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.cbStsType.SelectedIndex = 1;
            this.cbClientType.SelectedIndex = 0;
            this.cbGrantFlow.SelectedIndex = 2;

            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures)
                .Except(CultureInfo.GetCultures(CultureTypes.NeutralCultures));

            this.cbCultures.DisplayMember = "DisplayName";
            this.cbCultures.ValueMember = "Name";
            this.cbCultures.Sorted = true;
            this.cbCultures.DataSource = new BindingSource(cultures, null);
        }
    }
}
