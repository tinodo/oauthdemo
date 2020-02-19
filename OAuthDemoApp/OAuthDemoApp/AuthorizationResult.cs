using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuthDemoApp
{
    public class AuthorizationResult
    {
        public string AccessToken;
        public string IDToken;
        public string RefreshToken;
        public string Code;
        public string Error;
        public string Raw;
        public Exception Exception;
    }
}
