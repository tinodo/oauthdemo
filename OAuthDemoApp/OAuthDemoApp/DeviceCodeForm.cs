namespace OAuthDemoApp
{
    using Newtonsoft.Json;
    using System;
    using System.Net;
    using System.Windows.Forms;
    
    public partial class DeviceCodeForm : Form
    {
        private readonly string clientId;
        private readonly dynamic authorizationServerResponseMessage;
        private readonly string tokenEndpoint;
        private readonly string genericContent;
        private readonly DateTime startTime;
        private readonly NetworkCredential networkCredential;
        private DateTime lastPoll = DateTime.Now;

        public AuthorizationResult Result
        {
            get
            {
                return this.result;
            }
        }

        private AuthorizationResult result;

        public DeviceCodeForm(string clientId, string genericContent, string tokenEndpoint, string AuthorizationServerResponseMessage, NetworkCredential networkCredential = null)
        {
            InitializeComponent();
            this.startTime = DateTime.Now;
            this.networkCredential = networkCredential;
            this.genericContent = genericContent;
            this.tokenEndpoint = tokenEndpoint;
            this.clientId = clientId;
            this.authorizationServerResponseMessage = JsonConvert.DeserializeObject(AuthorizationServerResponseMessage);

            // was verification_uri and it worked; https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-oauth2-device-code
            // now, it appears to be verification_url (?)
            // v1 uses verification_url, v2 uses verification_uri?
            string url = this.authorizationServerResponseMessage.verification_url;
            if (string.IsNullOrEmpty(url))
            {
                url = this.authorizationServerResponseMessage.verification_uri;
            }

            this.llVerificationUri.Links.Clear();
            this.llVerificationUri.Links.Add(0, url.Length, url);
            this.label1.Text = (string)this.authorizationServerResponseMessage.message;
            this.tbInitialRequest.Text = JsonConvert.SerializeObject(this.authorizationServerResponseMessage, Formatting.Indented);

            this.pbTimeLeft.Maximum = this.authorizationServerResponseMessage.expires_in;
            this.pbPoll.Maximum = this.authorizationServerResponseMessage.interval * 1000;

            Clipboard.SetText((string)this.authorizationServerResponseMessage.user_code);

            this.authenticationTimeoutTimer.Interval = this.authorizationServerResponseMessage.expires_in * 1000;
            this.authenticationTimeoutTimer.Start();

            this.authenticationCallbackTimer.Interval = this.authorizationServerResponseMessage.interval * 1000;
            this.authenticationCallbackTimer.Start();

            this.formRefreshTimer.Start();
        }

        private void AuthenticationTimedOut(object sender, EventArgs e)
        {
            this.authenticationCallbackTimer.Stop();
            this.authenticationTimeoutTimer.Stop();
            this.formRefreshTimer.Stop();
            this.DialogResult = DialogResult.No;
            MessageBox.Show("Authentication has expired.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private async void AuthenticationCallback(object sender, EventArgs e)
        {
            // should resource be part of the content? docs say no; https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-oauth2-device-code
            // device_code for AADv2 and code for AADv1
            var deviceCode = "device_code";
            if (string.IsNullOrEmpty((string)this.authorizationServerResponseMessage.verification_uri))
            {
                deviceCode = "code";
            }

            var content = $"grant_type=urn:ietf:params:oauth:grant-type:device_code" +
                $"&client_id={this.clientId}" +
                $"&{deviceCode}={this.authorizationServerResponseMessage.device_code}";
            var result = await OAuthHelper.DoHttpPostAsync(this.tokenEndpoint, content, this.networkCredential);

            this.tbPollingResult.Text = OAuthHelper.FormatJson(result.Error);
            this.lastPoll = DateTime.Now;

            if (!string.IsNullOrEmpty(result.Raw))
            {
                this.result = result;
                this.authenticationCallbackTimer.Enabled = false;
                this.authenticationTimeoutTimer.Enabled = false;
                this.formRefreshTimer.Enabled = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.authenticationCallbackTimer.Stop();
            this.authenticationTimeoutTimer.Stop();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RefreshForm(object sender, EventArgs e)
        {
            var totalTime = this.authorizationServerResponseMessage.expires_in;
            var timeLeft = totalTime - Convert.ToInt32((DateTime.Now - this.startTime).TotalSeconds);
            this.lblTimeleft.Text = $"{timeLeft} sec.";
            this.pbTimeLeft.Value = timeLeft;
            this.pbTimeLeft.ProgressBar.Refresh();

            totalTime = this.authorizationServerResponseMessage.interval;
            timeLeft = Convert.ToInt32((DateTime.Now - this.lastPoll).TotalMilliseconds);
            this.pbPoll.Value = Math.Min(timeLeft, this.pbPoll.Maximum);
            this.pbPoll.ProgressBar.Refresh();

            timeLeft = totalTime - Convert.ToInt32((DateTime.Now - this.lastPoll).TotalSeconds);
            this.lblPoll.Text = $"{timeLeft} sec.";
        }

        private void LlVerificationUri_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)this.llVerificationUri.Links[0].LinkData);
        }
    }
}
