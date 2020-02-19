using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using SHDocVw;

namespace OAuthDemoApp
{
    public partial class ActiveFlowBrowserForm : Form
    {
        private System.Windows.Forms.WebBrowser _browser = null;  // Used to get user consent
        private readonly string _uri = null;
        private readonly string redirectPath = "/";
        private readonly Uri redirectUri = null;
        private Uri _responseUri = null;

        private string _accessToken = null;
        private string _idToken = null;
        private int _expiration;
        private string _error = null;
        private string _tokenType = null;
        private string _authorizationCode = null;
        private string _scope = null;
        private string _session_state = null;

        private bool _completed = false;

        public string AccessToken { get { return this._accessToken; } }
        public string IdToken { get { return this._idToken; } }
        public int Expiration { get { return this._expiration; } }
        public string Error { get { return this._error; } }
        public string AuthorizationCode { get { return this._authorizationCode; } }
        public string Scope { get { return this._scope; } }
        public string SessionState { get { return this._session_state; } }

        public string TokenType { get { return this._tokenType; } }
        public Uri ResponseUri { get { return this._responseUri; } }


        public ActiveFlowBrowserForm(string authEndpoint, string content)
        {
            var parameters = HttpUtility.ParseQueryString(content);
            this.redirectUri = new Uri(parameters["redirect_uri"]);
            this.redirectPath = this.redirectUri.AbsolutePath;
            this._uri = $"{authEndpoint}?{content}";

            //InitializeComponent();
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
            this._browser.Navigated += new WebBrowserNavigatedEventHandler(Browser_Navigated);


            this.Controls.AddRange(new Control[] { this._browser });
        }

        public bool ProcessRequest()
        {
            Thread oauthThread = new Thread(new ThreadStart(ShowAuthorizationForm));
            oauthThread.SetApartmentState(ApartmentState.STA);
            oauthThread.Start();
            oauthThread.Join();

            return this._completed;
        }

        private void ShowAuthorizationForm()
        {
            InitializeForm();
            this._browser.Navigate(this._uri);
            ((SHDocVw.WebBrowser)this._browser.ActiveXInstance).BeforeNavigate2 += Wb_BeforeNavigate2;
            Application.EnableVisualStyles();
            Application.Run(this);
        }

        private void Wb_BeforeNavigate2(object pDisp, ref object URL, ref object Flags, ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel)
        {
            // This is used, for now, only when using Code flow and choose form_post to get the data in. 
            if ((string)URL == this.redirectUri.ToString() && PostData != null)
            {
                var parameters = new NameValueCollection();
                var postDataStr = Encoding.ASCII.GetString((Byte[])PostData);
                parameters.Add(HttpUtility.ParseQueryString(postDataStr));


                if (parameters.AllKeys.Contains("error_description"))
                {
                    this._error = HttpUtility.UrlDecode(parameters["error_description"]);
                }

                this._expiration = Convert.ToInt32(parameters["expires_in"]);
                this._tokenType = parameters["token_type"];
                this._accessToken = parameters["access_token"];
                this._idToken = parameters["id_token"];
                this._authorizationCode = parameters["code"];
                this._session_state = parameters["session_state"];
                this._scope = parameters["scope"];

                this._completed = true;

                this.Close();
            }
        }

        private void Browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // Are we done? Final redirect to redirect_uri?
            if (e.Url.AbsolutePath.Equals(this.redirectPath))
            {
                var parameters = new NameValueCollection();
                //var url = this._browser.Document.Url;
                var url = e.Url;
                this._responseUri = url;
                if (!string.IsNullOrEmpty(url.Fragment)) // Implicit Flow & Hybrid Flow
                {
                    parameters.Add(HttpUtility.ParseQueryString(url.Fragment.TrimStart('#')));
                }
                if (!string.IsNullOrEmpty(url.Query)) // Code Flow
                {
                    parameters.Add(HttpUtility.ParseQueryString(url.Query.TrimStart('?')));
                }

                if (parameters.AllKeys.Contains("error_description"))
                {
                    this._error = HttpUtility.UrlDecode(parameters["error_description"]);
                }
                //else
                //{
                this._expiration = Convert.ToInt32(parameters["expires_in"]);
                this._tokenType = parameters["token_type"];
                this._accessToken = parameters["access_token"];
                this._idToken = parameters["id_token"];
                this._authorizationCode = parameters["code"];
                this._session_state = parameters["session_state"];
                //}

                this._completed = true;

                this.Close();
            }
        }
    }
}
