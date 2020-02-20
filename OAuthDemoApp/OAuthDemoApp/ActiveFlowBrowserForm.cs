namespace OAuthDemoApp
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Web;
    using System.Windows.Forms;

    public partial class ActiveFlowBrowserForm : Form
    {
        private WebBrowser _browser = null;  // Used to get user consent
        private readonly string _uri = null;
        private readonly string redirectPath = "/";
        private readonly Uri redirectUri = null;
        private bool _completed = false;
        private string _accessToken = null;
        private string _idToken = null;
        private string _error = null;
        private string _code = null;

        public ActiveFlowBrowserForm(string authEndpoint, string content)
        {
            var parameters = HttpUtility.ParseQueryString(content);
            this.redirectUri = new Uri(parameters["redirect_uri"]);
            this.redirectPath = this.redirectUri.AbsolutePath;
            this._uri = $"{authEndpoint}?{content}";
        }

        private void InitializeForm()
        {
            this.Size = new Size(568, 760);
            this.Text = "Sign in";
            this.ShowIcon = false;
            this._browser = new System.Windows.Forms.WebBrowser
            {
                Dock = DockStyle.Fill
            };
            this._browser.Navigated += new WebBrowserNavigatedEventHandler(AfterNavigate);

            this.Controls.AddRange(new Control[] { this._browser });
        }

        public AuthorizationResult ProcessRequest()
        {
            Thread oauthThread = new Thread(new ThreadStart(ShowAuthorizationForm));
            oauthThread.SetApartmentState(ApartmentState.STA);
            oauthThread.Start();
            oauthThread.Join();

            var result = new AuthorizationResult()
            {
                AccessToken = this._accessToken,
                IDToken = this._idToken,
                Code = this._code,
                Error = this._error,
            };

            if (!this._completed)
                result.Error = "User cancelled.";

            return result;
        }

        private void ShowAuthorizationForm()
        {
            InitializeForm();
            this._browser.Navigate(this._uri);
            var browser = (SHDocVw.WebBrowser)this._browser.ActiveXInstance;
            browser.BeforeNavigate2 += BeforeNavigate;
            Application.EnableVisualStyles();
            Application.Run(this);
        }

        private void ProcessDataAndQuit(string data)
        {
            data = data.TrimStart('#').TrimStart('?');
            var parameters = HttpUtility.ParseQueryString(data);

            if (parameters.AllKeys.Contains("error_description"))
                this._error = HttpUtility.UrlDecode(parameters["error_description"]);

            this._accessToken = parameters["access_token"];
            this._idToken = parameters["id_token"];
            this._code = parameters["code"];
            this._completed = true;
            
            this.Close();
            // Other potential data in could be: expires_in, token_type, session_state, scope
        }

        private void BeforeNavigate(object pDisp, ref object URL, ref object Flags, ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel)
        {
            if ((string)URL == this.redirectUri.ToString() && PostData != null)
            {
                var postDataStr = Encoding.ASCII.GetString((Byte[])PostData);
                ProcessDataAndQuit(postDataStr);
            }
        }

        private void AfterNavigate(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.AbsolutePath.Equals(this.redirectPath))
            {
                ProcessDataAndQuit(e.Url.Fragment + e.Url.Query);
            }
        }
    }
}
