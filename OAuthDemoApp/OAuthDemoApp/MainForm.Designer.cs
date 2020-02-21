namespace OAuthDemoApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label8 = new System.Windows.Forms.Label();
            this.tbAadTenant = new System.Windows.Forms.TextBox();
            this.tbAdfsFarmName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStsType = new System.Windows.Forms.ComboBox();
            this.tbTokenEndpoint = new System.Windows.Forms.TextBox();
            this.tbAuthEndpoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGrantFlow = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbClientType = new System.Windows.Forms.ComboBox();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbClientSecret = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbClientCredential_Cert = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbClientCredentials_Cert_CertSN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClientCredentials_Cert_SelectCert = new System.Windows.Forms.Button();
            this.gbClientCredential_WIA = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbClientCredential_WIA_Credentials_Other_Password = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rbClientCredential_WIA_Credentials_Other = new System.Windows.Forms.RadioButton();
            this.tbClientCredential_WIA_Credentials_Other_UserName = new System.Windows.Forms.TextBox();
            this.rbClientCredential_WIA_Credentials_Current = new System.Windows.Forms.RadioButton();
            this.rbResource = new System.Windows.Forms.RadioButton();
            this.rbScope = new System.Windows.Forms.RadioButton();
            this.tbScope = new System.Windows.Forms.TextBox();
            this.tbResource = new System.Windows.Forms.TextBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSTS = new System.Windows.Forms.TabPage();
            this.btnGetMetadata = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.tbMetadataEndpoint = new System.Windows.Forms.TextBox();
            this.gbADFS = new System.Windows.Forms.GroupBox();
            this.gbAzureAD = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbAzureAdEndpoint_Tenant = new System.Windows.Forms.RadioButton();
            this.rbAzureAdEndpoint_Organizations = new System.Windows.Forms.RadioButton();
            this.rbAzureAdEndpoint_Consumers = new System.Windows.Forms.RadioButton();
            this.rbAzureAdEndpoint_Common = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAzureADv2 = new System.Windows.Forms.RadioButton();
            this.rbAzureADv1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDeviceCodeEndpoint = new System.Windows.Forms.TextBox();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.tpClient = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tbClientRedirectUri = new System.Windows.Forms.TextBox();
            this.gbClientCredential_Secret = new System.Windows.Forms.GroupBox();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.tpResource = new System.Windows.Forms.TabPage();
            this.btnNext3 = new System.Windows.Forms.Button();
            this.tpGrant = new System.Windows.Forms.TabPage();
            this.gbDeviceCodeFlow = new System.Windows.Forms.GroupBox();
            this.cbCultures = new System.Windows.Forms.ComboBox();
            this.cbDeviceCodeFlowMessageLanguage = new System.Windows.Forms.CheckBox();
            this.btnNext4 = new System.Windows.Forms.Button();
            this.gbHybridFlow = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.cbHybridFlow_Implicit_RequestCode = new System.Windows.Forms.CheckBox();
            this.cbHybridFlow_Implicit_RequestAccessToken = new System.Windows.Forms.CheckBox();
            this.cbHybridFlow_Implicit_RequestIdToken = new System.Windows.Forms.CheckBox();
            this.gbOnBehalfOf = new System.Windows.Forms.GroupBox();
            this.rbOBO_UseResource = new System.Windows.Forms.RadioButton();
            this.rbOBO_UseScope = new System.Windows.Forms.RadioButton();
            this.tbOBO_ScopeOrResource = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbOBO_ClientId = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbOBO_ClientSecret = new System.Windows.Forms.TextBox();
            this.gbROPCFlow = new System.Windows.Forms.GroupBox();
            this.tb_ClientCredentials_UseROP_Username = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_ClientCredentials_UseROP_Password = new System.Windows.Forms.TextBox();
            this.tbOptions = new System.Windows.Forms.TabPage();
            this.cbAddClientRequestId = new System.Windows.Forms.CheckBox();
            this.gbMiscOptions = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbCodeFlow_LoginHint = new System.Windows.Forms.TextBox();
            this.lbCodeFlow_DomainHint = new System.Windows.Forms.ComboBox();
            this.cbCodeFlow_ResponseMode = new System.Windows.Forms.ComboBox();
            this.cbCodeFlow_Prompt = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbOptions_State = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gbCodeFlow_PKCE = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbCodeFlow_PKCE_Verifier = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbCodeFlow_PKCE_Method = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.rbPreferMSAL = new System.Windows.Forms.RadioButton();
            this.rbPreferHttp = new System.Windows.Forms.RadioButton();
            this.rbPreferADAL = new System.Windows.Forms.RadioButton();
            this.tbResult = new System.Windows.Forms.TabPage();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnUseRefreshToken = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpErrors = new System.Windows.Forms.TabPage();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.tpCode = new System.Windows.Forms.TabPage();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.tpAccessToken = new System.Windows.Forms.TabPage();
            this.btnValidateAccessToken = new System.Windows.Forms.Button();
            this.tbAccessToken = new System.Windows.Forms.TextBox();
            this.tpAccessTokenDecoded = new System.Windows.Forms.TabPage();
            this.tbAccessTokenDecoded = new System.Windows.Forms.TextBox();
            this.tpRefreshToken = new System.Windows.Forms.TabPage();
            this.tbRefreshToken = new System.Windows.Forms.TextBox();
            this.tpIdToken = new System.Windows.Forms.TabPage();
            this.btnValidateIdToken = new System.Windows.Forms.Button();
            this.tbIdToken = new System.Windows.Forms.TextBox();
            this.tpIdTokenDecoded = new System.Windows.Forms.TabPage();
            this.tbIdTokenDecoded = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ttHint = new System.Windows.Forms.ToolTip(this.components);
            this.gbClientCredential_Cert.SuspendLayout();
            this.gbClientCredential_WIA.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpSTS.SuspendLayout();
            this.gbADFS.SuspendLayout();
            this.gbAzureAD.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpClient.SuspendLayout();
            this.gbClientCredential_Secret.SuspendLayout();
            this.tpResource.SuspendLayout();
            this.tpGrant.SuspendLayout();
            this.gbDeviceCodeFlow.SuspendLayout();
            this.gbHybridFlow.SuspendLayout();
            this.gbOnBehalfOf.SuspendLayout();
            this.gbROPCFlow.SuspendLayout();
            this.tbOptions.SuspendLayout();
            this.gbMiscOptions.SuspendLayout();
            this.gbCodeFlow_PKCE.SuspendLayout();
            this.tbResult.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpErrors.SuspendLayout();
            this.tpCode.SuspendLayout();
            this.tpAccessToken.SuspendLayout();
            this.tpAccessTokenDecoded.SuspendLayout();
            this.tpRefreshToken.SuspendLayout();
            this.tpIdToken.SuspendLayout();
            this.tpIdTokenDecoded.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = ".onmicrosoft.com";
            // 
            // tbAadTenant
            // 
            this.tbAadTenant.Location = new System.Drawing.Point(160, 81);
            this.tbAadTenant.Name = "tbAadTenant";
            this.tbAadTenant.Size = new System.Drawing.Size(64, 20);
            this.tbAadTenant.TabIndex = 11;
            this.tbAadTenant.Text = "contoso";
            this.ttHint.SetToolTip(this.tbAadTenant, "The friendlyname (e.g. \'contoso\') or the GUID (e.g. \'7247f7a4-a54f-495e-883d-bd4e" +
        "3b0bcf1e\')\r\nof your Azure AD tenant.");
            this.tbAadTenant.TextChanged += new System.EventHandler(this.GenerateStsEndpoints);
            // 
            // tbAdfsFarmName
            // 
            this.tbAdfsFarmName.Enabled = false;
            this.tbAdfsFarmName.Location = new System.Drawing.Point(125, 19);
            this.tbAdfsFarmName.Name = "tbAdfsFarmName";
            this.tbAdfsFarmName.Size = new System.Drawing.Size(215, 20);
            this.tbAdfsFarmName.TabIndex = 9;
            this.tbAdfsFarmName.Text = "sts.contoso.com";
            this.ttHint.SetToolTip(this.tbAdfsFarmName, "The fully qualified name (e.g. \'server.domain.com\') for your AD FS Farm.");
            this.tbAdfsFarmName.TextChanged += new System.EventHandler(this.GenerateStsEndpoints);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Farm Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "STS Type:";
            // 
            // cbStsType
            // 
            this.cbStsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStsType.FormattingEnabled = true;
            this.cbStsType.Items.AddRange(new object[] {
            "Active Directory Federation Services",
            "Azure Active Directory",
            "Azure Active Directory B2C",
            "Custom"});
            this.cbStsType.Location = new System.Drawing.Point(138, 20);
            this.cbStsType.Name = "cbStsType";
            this.cbStsType.Size = new System.Drawing.Size(381, 21);
            this.cbStsType.TabIndex = 4;
            this.ttHint.SetToolTip(this.cbStsType, "Select the type of the Secure Token Service (STS) you want to connect to.");
            this.cbStsType.SelectedIndexChanged += new System.EventHandler(this.CbStsType_SelectedIndexChanged);
            // 
            // tbTokenEndpoint
            // 
            this.tbTokenEndpoint.Enabled = false;
            this.tbTokenEndpoint.Location = new System.Drawing.Point(138, 326);
            this.tbTokenEndpoint.Name = "tbTokenEndpoint";
            this.tbTokenEndpoint.Size = new System.Drawing.Size(381, 20);
            this.tbTokenEndpoint.TabIndex = 3;
            // 
            // tbAuthEndpoint
            // 
            this.tbAuthEndpoint.Enabled = false;
            this.tbAuthEndpoint.Location = new System.Drawing.Point(138, 300);
            this.tbAuthEndpoint.Name = "tbAuthEndpoint";
            this.tbAuthEndpoint.Size = new System.Drawing.Size(381, 20);
            this.tbAuthEndpoint.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Authorization Endpoint:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Token Endpoint:";
            // 
            // cbGrantFlow
            // 
            this.cbGrantFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrantFlow.FormattingEnabled = true;
            this.cbGrantFlow.Items.AddRange(new object[] {
            "Client Credentials",
            "Resource Owner Password Credentials",
            "Authorization Code",
            "Implicit Grant",
            "On-Behalf-Of",
            "Device Code",
            "Hybrid"});
            this.cbGrantFlow.Location = new System.Drawing.Point(132, 12);
            this.cbGrantFlow.Name = "cbGrantFlow";
            this.cbGrantFlow.Size = new System.Drawing.Size(381, 21);
            this.cbGrantFlow.TabIndex = 5;
            this.ttHint.SetToolTip(this.cbGrantFlow, resources.GetString("cbGrantFlow.ToolTip"));
            this.cbGrantFlow.SelectedIndexChanged += new System.EventHandler(this.CbGrantFlow_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Authorization Grant:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Client Type:";
            // 
            // cbClientType
            // 
            this.cbClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientType.FormattingEnabled = true;
            this.cbClientType.Items.AddRange(new object[] {
            "Public Client",
            "Confidential Client - Client Credentials",
            "Confidential Client - Windows Integrated Authentication",
            "Confidential Client - Certificate-Based Authentication"});
            this.cbClientType.Location = new System.Drawing.Point(146, 20);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(381, 21);
            this.cbClientType.TabIndex = 8;
            this.ttHint.SetToolTip(this.cbClientType, resources.GetString("cbClientType.ToolTip"));
            this.cbClientType.SelectedIndexChanged += new System.EventHandler(this.CbClientType_SelectedIndexChanged);
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(146, 47);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(381, 20);
            this.tbClientId.TabIndex = 11;
            this.tbClientId.Text = "1950a258-227b-4e31-a9cf-717495945fc2";
            this.ttHint.SetToolTip(this.tbClientId, resources.GetString("tbClientId.ToolTip"));
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Client Identifier:";
            // 
            // tbClientSecret
            // 
            this.tbClientSecret.Location = new System.Drawing.Point(118, 19);
            this.tbClientSecret.Name = "tbClientSecret";
            this.tbClientSecret.Size = new System.Drawing.Size(375, 20);
            this.tbClientSecret.TabIndex = 13;
            this.ttHint.SetToolTip(this.tbClientSecret, "The shared key known by the STS, allowing the client to authenticate.");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Client Secret:";
            // 
            // gbClientCredential_Cert
            // 
            this.gbClientCredential_Cert.Controls.Add(this.label27);
            this.gbClientCredential_Cert.Controls.Add(this.tbClientCredentials_Cert_CertSN);
            this.gbClientCredential_Cert.Controls.Add(this.label11);
            this.gbClientCredential_Cert.Controls.Add(this.btnClientCredentials_Cert_SelectCert);
            this.gbClientCredential_Cert.Enabled = false;
            this.gbClientCredential_Cert.Location = new System.Drawing.Point(28, 204);
            this.gbClientCredential_Cert.Name = "gbClientCredential_Cert";
            this.gbClientCredential_Cert.Size = new System.Drawing.Size(499, 84);
            this.gbClientCredential_Cert.TabIndex = 19;
            this.gbClientCredential_Cert.TabStop = false;
            this.gbClientCredential_Cert.Text = "Certificate-Based Authentication";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 53);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 13);
            this.label27.TabIndex = 16;
            this.label27.Text = "Cert. Thumbprint:";
            // 
            // tbClientCredentials_Cert_CertSN
            // 
            this.tbClientCredentials_Cert_CertSN.Enabled = false;
            this.tbClientCredentials_Cert_CertSN.Location = new System.Drawing.Point(118, 50);
            this.tbClientCredentials_Cert_CertSN.Name = "tbClientCredentials_Cert_CertSN";
            this.tbClientCredentials_Cert_CertSN.Size = new System.Drawing.Size(375, 20);
            this.tbClientCredentials_Cert_CertSN.TabIndex = 15;
            this.tbClientCredentials_Cert_CertSN.Text = "01b76f2d2dba33e01832a11a2be3ae88bf9bfb7d";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Client Certificate:";
            // 
            // btnClientCredentials_Cert_SelectCert
            // 
            this.btnClientCredentials_Cert_SelectCert.Location = new System.Drawing.Point(118, 21);
            this.btnClientCredentials_Cert_SelectCert.Name = "btnClientCredentials_Cert_SelectCert";
            this.btnClientCredentials_Cert_SelectCert.Size = new System.Drawing.Size(133, 23);
            this.btnClientCredentials_Cert_SelectCert.TabIndex = 14;
            this.btnClientCredentials_Cert_SelectCert.Text = "Select Certificate";
            this.btnClientCredentials_Cert_SelectCert.UseVisualStyleBackColor = true;
            this.btnClientCredentials_Cert_SelectCert.Click += new System.EventHandler(this.BtnClientCredentials_Cert_SelectCert_Click);
            // 
            // gbClientCredential_WIA
            // 
            this.gbClientCredential_WIA.Controls.Add(this.label12);
            this.gbClientCredential_WIA.Controls.Add(this.tbClientCredential_WIA_Credentials_Other_Password);
            this.gbClientCredential_WIA.Controls.Add(this.label13);
            this.gbClientCredential_WIA.Controls.Add(this.rbClientCredential_WIA_Credentials_Other);
            this.gbClientCredential_WIA.Controls.Add(this.tbClientCredential_WIA_Credentials_Other_UserName);
            this.gbClientCredential_WIA.Controls.Add(this.rbClientCredential_WIA_Credentials_Current);
            this.gbClientCredential_WIA.Enabled = false;
            this.gbClientCredential_WIA.Location = new System.Drawing.Point(28, 294);
            this.gbClientCredential_WIA.Name = "gbClientCredential_WIA";
            this.gbClientCredential_WIA.Size = new System.Drawing.Size(500, 108);
            this.gbClientCredential_WIA.TabIndex = 20;
            this.gbClientCredential_WIA.TabStop = false;
            this.gbClientCredential_WIA.Text = "Windows Integrated Authentication";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(116, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Password:";
            // 
            // tbClientCredential_WIA_Credentials_Other_Password
            // 
            this.tbClientCredential_WIA_Credentials_Other_Password.Location = new System.Drawing.Point(183, 69);
            this.tbClientCredential_WIA_Credentials_Other_Password.Name = "tbClientCredential_WIA_Credentials_Other_Password";
            this.tbClientCredential_WIA_Credentials_Other_Password.Size = new System.Drawing.Size(311, 20);
            this.tbClientCredential_WIA_Credentials_Other_Password.TabIndex = 8;
            this.tbClientCredential_WIA_Credentials_Other_Password.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "User name:";
            // 
            // rbClientCredential_WIA_Credentials_Other
            // 
            this.rbClientCredential_WIA_Credentials_Other.AutoSize = true;
            this.rbClientCredential_WIA_Credentials_Other.Location = new System.Drawing.Point(6, 42);
            this.rbClientCredential_WIA_Credentials_Other.Name = "rbClientCredential_WIA_Credentials_Other";
            this.rbClientCredential_WIA_Credentials_Other.Size = new System.Drawing.Size(76, 17);
            this.rbClientCredential_WIA_Credentials_Other.TabIndex = 1;
            this.rbClientCredential_WIA_Credentials_Other.Text = "Other User";
            this.rbClientCredential_WIA_Credentials_Other.UseVisualStyleBackColor = true;
            // 
            // tbClientCredential_WIA_Credentials_Other_UserName
            // 
            this.tbClientCredential_WIA_Credentials_Other_UserName.Location = new System.Drawing.Point(183, 43);
            this.tbClientCredential_WIA_Credentials_Other_UserName.Name = "tbClientCredential_WIA_Credentials_Other_UserName";
            this.tbClientCredential_WIA_Credentials_Other_UserName.Size = new System.Drawing.Size(311, 20);
            this.tbClientCredential_WIA_Credentials_Other_UserName.TabIndex = 6;
            this.tbClientCredential_WIA_Credentials_Other_UserName.Text = "user@contoso.com";
            // 
            // rbClientCredential_WIA_Credentials_Current
            // 
            this.rbClientCredential_WIA_Credentials_Current.AutoSize = true;
            this.rbClientCredential_WIA_Credentials_Current.Checked = true;
            this.rbClientCredential_WIA_Credentials_Current.Location = new System.Drawing.Point(6, 19);
            this.rbClientCredential_WIA_Credentials_Current.Name = "rbClientCredential_WIA_Credentials_Current";
            this.rbClientCredential_WIA_Credentials_Current.Size = new System.Drawing.Size(84, 17);
            this.rbClientCredential_WIA_Credentials_Current.TabIndex = 0;
            this.rbClientCredential_WIA_Credentials_Current.TabStop = true;
            this.rbClientCredential_WIA_Credentials_Current.Text = "Current User";
            this.rbClientCredential_WIA_Credentials_Current.UseVisualStyleBackColor = true;
            // 
            // rbResource
            // 
            this.rbResource.AutoSize = true;
            this.rbResource.Location = new System.Drawing.Point(10, 12);
            this.rbResource.Name = "rbResource";
            this.rbResource.Size = new System.Drawing.Size(96, 17);
            this.rbResource.TabIndex = 0;
            this.rbResource.Text = "Use Resource:";
            this.rbResource.UseVisualStyleBackColor = true;
            this.rbResource.CheckedChanged += new System.EventHandler(this.RbResource_CheckedChanged);
            // 
            // rbScope
            // 
            this.rbScope.AutoSize = true;
            this.rbScope.Checked = true;
            this.rbScope.Location = new System.Drawing.Point(10, 38);
            this.rbScope.Name = "rbScope";
            this.rbScope.Size = new System.Drawing.Size(92, 17);
            this.rbScope.TabIndex = 1;
            this.rbScope.TabStop = true;
            this.rbScope.Text = "Use Scope(s):";
            this.rbScope.UseVisualStyleBackColor = true;
            this.rbScope.CheckedChanged += new System.EventHandler(this.RbScope_CheckedChanged);
            // 
            // tbScope
            // 
            this.tbScope.Location = new System.Drawing.Point(132, 37);
            this.tbScope.Multiline = true;
            this.tbScope.Name = "tbScope";
            this.tbScope.Size = new System.Drawing.Size(381, 96);
            this.tbScope.TabIndex = 24;
            this.tbScope.Text = "openid\r\nemail\r\nprofile\r\noffline_access";
            // 
            // tbResource
            // 
            this.tbResource.Enabled = false;
            this.tbResource.Location = new System.Drawing.Point(132, 11);
            this.tbResource.Name = "tbResource";
            this.tbResource.Size = new System.Drawing.Size(381, 20);
            this.tbResource.TabIndex = 22;
            this.tbResource.Text = "https://api.contoso.com";
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpSTS);
            this.tcMain.Controls.Add(this.tpClient);
            this.tcMain.Controls.Add(this.tpResource);
            this.tcMain.Controls.Add(this.tpGrant);
            this.tcMain.Controls.Add(this.tbOptions);
            this.tcMain.Controls.Add(this.tbResult);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(708, 560);
            this.tcMain.TabIndex = 11;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.TcMain_SelectedIndexChanged);
            // 
            // tpSTS
            // 
            this.tpSTS.Controls.Add(this.btnGetMetadata);
            this.tpSTS.Controls.Add(this.label28);
            this.tpSTS.Controls.Add(this.tbMetadataEndpoint);
            this.tpSTS.Controls.Add(this.gbADFS);
            this.tpSTS.Controls.Add(this.gbAzureAD);
            this.tpSTS.Controls.Add(this.label14);
            this.tpSTS.Controls.Add(this.tbDeviceCodeEndpoint);
            this.tpSTS.Controls.Add(this.btnNext1);
            this.tpSTS.Controls.Add(this.cbStsType);
            this.tpSTS.Controls.Add(this.label1);
            this.tpSTS.Controls.Add(this.label2);
            this.tpSTS.Controls.Add(this.tbAuthEndpoint);
            this.tpSTS.Controls.Add(this.tbTokenEndpoint);
            this.tpSTS.Controls.Add(this.label3);
            this.tpSTS.Location = new System.Drawing.Point(4, 22);
            this.tpSTS.Name = "tpSTS";
            this.tpSTS.Padding = new System.Windows.Forms.Padding(3);
            this.tpSTS.Size = new System.Drawing.Size(700, 534);
            this.tpSTS.TabIndex = 0;
            this.tpSTS.Text = "Authorization Server / STS";
            this.tpSTS.UseVisualStyleBackColor = true;
            // 
            // btnGetMetadata
            // 
            this.btnGetMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetMetadata.Location = new System.Drawing.Point(415, 404);
            this.btnGetMetadata.Name = "btnGetMetadata";
            this.btnGetMetadata.Size = new System.Drawing.Size(104, 23);
            this.btnGetMetadata.TabIndex = 20;
            this.btnGetMetadata.Text = "Get Metadata";
            this.btnGetMetadata.UseVisualStyleBackColor = true;
            this.btnGetMetadata.Click += new System.EventHandler(this.BtnGetMetadata_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 381);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(100, 13);
            this.label28.TabIndex = 18;
            this.label28.Text = "Metadata Endpoint:";
            // 
            // tbMetadataEndpoint
            // 
            this.tbMetadataEndpoint.Enabled = false;
            this.tbMetadataEndpoint.Location = new System.Drawing.Point(138, 378);
            this.tbMetadataEndpoint.Name = "tbMetadataEndpoint";
            this.tbMetadataEndpoint.Size = new System.Drawing.Size(381, 20);
            this.tbMetadataEndpoint.TabIndex = 19;
            // 
            // gbADFS
            // 
            this.gbADFS.Controls.Add(this.tbAdfsFarmName);
            this.gbADFS.Controls.Add(this.label6);
            this.gbADFS.Location = new System.Drawing.Point(19, 47);
            this.gbADFS.Name = "gbADFS";
            this.gbADFS.Size = new System.Drawing.Size(500, 55);
            this.gbADFS.TabIndex = 17;
            this.gbADFS.TabStop = false;
            this.gbADFS.Text = "Active Directory Federation Services";
            // 
            // gbAzureAD
            // 
            this.gbAzureAD.Controls.Add(this.panel2);
            this.gbAzureAD.Controls.Add(this.panel1);
            this.gbAzureAD.Enabled = false;
            this.gbAzureAD.Location = new System.Drawing.Point(19, 108);
            this.gbAzureAD.Name = "gbAzureAD";
            this.gbAzureAD.Size = new System.Drawing.Size(500, 186);
            this.gbAzureAD.TabIndex = 16;
            this.gbAzureAD.TabStop = false;
            this.gbAzureAD.Text = "Azure Active Directory";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbAzureAdEndpoint_Tenant);
            this.panel2.Controls.Add(this.rbAzureAdEndpoint_Organizations);
            this.panel2.Controls.Add(this.rbAzureAdEndpoint_Consumers);
            this.panel2.Controls.Add(this.rbAzureAdEndpoint_Common);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbAadTenant);
            this.panel2.Location = new System.Drawing.Point(6, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 109);
            this.panel2.TabIndex = 3;
            // 
            // rbAzureAdEndpoint_Tenant
            // 
            this.rbAzureAdEndpoint_Tenant.AutoSize = true;
            this.rbAzureAdEndpoint_Tenant.Checked = true;
            this.rbAzureAdEndpoint_Tenant.Location = new System.Drawing.Point(9, 82);
            this.rbAzureAdEndpoint_Tenant.Name = "rbAzureAdEndpoint_Tenant";
            this.rbAzureAdEndpoint_Tenant.Size = new System.Drawing.Size(148, 17);
            this.rbAzureAdEndpoint_Tenant.TabIndex = 5;
            this.rbAzureAdEndpoint_Tenant.TabStop = true;
            this.rbAzureAdEndpoint_Tenant.Text = "Tenant Specific Endpoint:";
            this.ttHint.SetToolTip(this.rbAzureAdEndpoint_Tenant, resources.GetString("rbAzureAdEndpoint_Tenant.ToolTip"));
            this.rbAzureAdEndpoint_Tenant.UseVisualStyleBackColor = true;
            this.rbAzureAdEndpoint_Tenant.CheckedChanged += new System.EventHandler(this.GenerateStsEndpoints);
            // 
            // rbAzureAdEndpoint_Organizations
            // 
            this.rbAzureAdEndpoint_Organizations.AutoSize = true;
            this.rbAzureAdEndpoint_Organizations.Location = new System.Drawing.Point(9, 59);
            this.rbAzureAdEndpoint_Organizations.Name = "rbAzureAdEndpoint_Organizations";
            this.rbAzureAdEndpoint_Organizations.Size = new System.Drawing.Size(134, 17);
            this.rbAzureAdEndpoint_Organizations.TabIndex = 4;
            this.rbAzureAdEndpoint_Organizations.Text = "Organizations Endpoint";
            this.ttHint.SetToolTip(this.rbAzureAdEndpoint_Organizations, "Only users with work or school accounts from Azure AD can sign in to the applicat" +
        "ion.");
            this.rbAzureAdEndpoint_Organizations.UseVisualStyleBackColor = true;
            this.rbAzureAdEndpoint_Organizations.CheckedChanged += new System.EventHandler(this.GenerateStsEndpoints);
            // 
            // rbAzureAdEndpoint_Consumers
            // 
            this.rbAzureAdEndpoint_Consumers.AutoSize = true;
            this.rbAzureAdEndpoint_Consumers.Location = new System.Drawing.Point(9, 36);
            this.rbAzureAdEndpoint_Consumers.Name = "rbAzureAdEndpoint_Consumers";
            this.rbAzureAdEndpoint_Consumers.Size = new System.Drawing.Size(122, 17);
            this.rbAzureAdEndpoint_Consumers.TabIndex = 3;
            this.rbAzureAdEndpoint_Consumers.Text = "Consumers Endpoint";
            this.ttHint.SetToolTip(this.rbAzureAdEndpoint_Consumers, "Only users with a personal Microsoft account can sign in to the application.");
            this.rbAzureAdEndpoint_Consumers.UseVisualStyleBackColor = true;
            this.rbAzureAdEndpoint_Consumers.CheckedChanged += new System.EventHandler(this.GenerateStsEndpoints);
            // 
            // rbAzureAdEndpoint_Common
            // 
            this.rbAzureAdEndpoint_Common.AutoSize = true;
            this.rbAzureAdEndpoint_Common.Location = new System.Drawing.Point(9, 13);
            this.rbAzureAdEndpoint_Common.Name = "rbAzureAdEndpoint_Common";
            this.rbAzureAdEndpoint_Common.Size = new System.Drawing.Size(201, 17);
            this.rbAzureAdEndpoint_Common.TabIndex = 2;
            this.rbAzureAdEndpoint_Common.Text = "Common Endpoint (Multi-Tenant App)";
            this.ttHint.SetToolTip(this.rbAzureAdEndpoint_Common, "Users with both a personal Microsoft account and a work or school account from Az" +
        "ure AD can sign in to the application.");
            this.rbAzureAdEndpoint_Common.UseVisualStyleBackColor = true;
            this.rbAzureAdEndpoint_Common.CheckedChanged += new System.EventHandler(this.GenerateStsEndpoints);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAzureADv2);
            this.panel1.Controls.Add(this.rbAzureADv1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 43);
            this.panel1.TabIndex = 2;
            // 
            // rbAzureADv2
            // 
            this.rbAzureADv2.AutoSize = true;
            this.rbAzureADv2.Checked = true;
            this.rbAzureADv2.Location = new System.Drawing.Point(119, 14);
            this.rbAzureADv2.Name = "rbAzureADv2";
            this.rbAzureADv2.Size = new System.Drawing.Size(105, 17);
            this.rbAzureADv2.TabIndex = 1;
            this.rbAzureADv2.TabStop = true;
            this.rbAzureADv2.Text = "Use V2 Endpoint";
            this.ttHint.SetToolTip(this.rbAzureADv2, resources.GetString("rbAzureADv2.ToolTip"));
            this.rbAzureADv2.UseVisualStyleBackColor = true;
            this.rbAzureADv2.CheckedChanged += new System.EventHandler(this.ChangeAzureAdVersion);
            // 
            // rbAzureADv1
            // 
            this.rbAzureADv1.AutoSize = true;
            this.rbAzureADv1.Location = new System.Drawing.Point(9, 14);
            this.rbAzureADv1.Name = "rbAzureADv1";
            this.rbAzureADv1.Size = new System.Drawing.Size(105, 17);
            this.rbAzureADv1.TabIndex = 0;
            this.rbAzureADv1.Text = "Use V1 Endpoint";
            this.ttHint.SetToolTip(this.rbAzureADv1, resources.GetString("rbAzureADv1.ToolTip"));
            this.rbAzureADv1.UseVisualStyleBackColor = true;
            this.rbAzureADv1.CheckedChanged += new System.EventHandler(this.ChangeAzureAdVersion);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Device Code Endpoint:";
            // 
            // tbDeviceCodeEndpoint
            // 
            this.tbDeviceCodeEndpoint.Enabled = false;
            this.tbDeviceCodeEndpoint.Location = new System.Drawing.Point(138, 352);
            this.tbDeviceCodeEndpoint.Name = "tbDeviceCodeEndpoint";
            this.tbDeviceCodeEndpoint.Size = new System.Drawing.Size(381, 20);
            this.tbDeviceCodeEndpoint.TabIndex = 15;
            // 
            // btnNext1
            // 
            this.btnNext1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext1.Location = new System.Drawing.Point(619, 505);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(75, 23);
            this.btnNext1.TabIndex = 13;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.ValidateAuthorizationServerTab);
            // 
            // tpClient
            // 
            this.tpClient.Controls.Add(this.label30);
            this.tpClient.Controls.Add(this.label29);
            this.tpClient.Controls.Add(this.tbClientRedirectUri);
            this.tpClient.Controls.Add(this.gbClientCredential_Secret);
            this.tpClient.Controls.Add(this.btnNext2);
            this.tpClient.Controls.Add(this.gbClientCredential_WIA);
            this.tpClient.Controls.Add(this.cbClientType);
            this.tpClient.Controls.Add(this.label5);
            this.tpClient.Controls.Add(this.label9);
            this.tpClient.Controls.Add(this.tbClientId);
            this.tpClient.Controls.Add(this.gbClientCredential_Cert);
            this.tpClient.Location = new System.Drawing.Point(4, 22);
            this.tpClient.Name = "tpClient";
            this.tpClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpClient.Size = new System.Drawing.Size(700, 534);
            this.tpClient.TabIndex = 1;
            this.tpClient.Text = "Client";
            this.tpClient.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(144, 96);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(416, 13);
            this.label30.TabIndex = 24;
            this.label30.Text = "Required for interactive flows like Authorization Code Flow, Hybrid Flow or Impli" +
    "cit Flow.";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(24, 76);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 13);
            this.label29.TabIndex = 22;
            this.label29.Text = "Redirect URI:";
            // 
            // tbClientRedirectUri
            // 
            this.tbClientRedirectUri.Location = new System.Drawing.Point(146, 73);
            this.tbClientRedirectUri.Name = "tbClientRedirectUri";
            this.tbClientRedirectUri.Size = new System.Drawing.Size(381, 20);
            this.tbClientRedirectUri.TabIndex = 23;
            this.tbClientRedirectUri.Text = "urn:ietf:wg:oauth:2.0:oob";
            this.ttHint.SetToolTip(this.tbClientRedirectUri, "Enter the redirection URI of your client.\r\nThis URI has been provided during the " +
        "registration\r\nof the client with the Secure Token Service.\r\n");
            // 
            // gbClientCredential_Secret
            // 
            this.gbClientCredential_Secret.Controls.Add(this.tbClientSecret);
            this.gbClientCredential_Secret.Controls.Add(this.label10);
            this.gbClientCredential_Secret.Enabled = false;
            this.gbClientCredential_Secret.Location = new System.Drawing.Point(28, 138);
            this.gbClientCredential_Secret.Name = "gbClientCredential_Secret";
            this.gbClientCredential_Secret.Size = new System.Drawing.Size(499, 60);
            this.gbClientCredential_Secret.TabIndex = 20;
            this.gbClientCredential_Secret.TabStop = false;
            this.gbClientCredential_Secret.Text = "Client Secret";
            // 
            // btnNext2
            // 
            this.btnNext2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext2.Location = new System.Drawing.Point(619, 505);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 21;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.ValidateClientTab);
            // 
            // tpResource
            // 
            this.tpResource.Controls.Add(this.btnNext3);
            this.tpResource.Controls.Add(this.tbScope);
            this.tpResource.Controls.Add(this.rbScope);
            this.tpResource.Controls.Add(this.rbResource);
            this.tpResource.Controls.Add(this.tbResource);
            this.tpResource.Location = new System.Drawing.Point(4, 22);
            this.tpResource.Name = "tpResource";
            this.tpResource.Size = new System.Drawing.Size(700, 534);
            this.tpResource.TabIndex = 2;
            this.tpResource.Text = "Resource / Scope";
            this.tpResource.UseVisualStyleBackColor = true;
            // 
            // btnNext3
            // 
            this.btnNext3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext3.Location = new System.Drawing.Point(622, 508);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.Size = new System.Drawing.Size(75, 23);
            this.btnNext3.TabIndex = 25;
            this.btnNext3.Text = "Next";
            this.btnNext3.UseVisualStyleBackColor = true;
            this.btnNext3.Click += new System.EventHandler(this.ValidateResourceTab);
            // 
            // tpGrant
            // 
            this.tpGrant.Controls.Add(this.gbDeviceCodeFlow);
            this.tpGrant.Controls.Add(this.btnNext4);
            this.tpGrant.Controls.Add(this.gbHybridFlow);
            this.tpGrant.Controls.Add(this.gbOnBehalfOf);
            this.tpGrant.Controls.Add(this.gbROPCFlow);
            this.tpGrant.Controls.Add(this.cbGrantFlow);
            this.tpGrant.Controls.Add(this.label4);
            this.tpGrant.Location = new System.Drawing.Point(4, 22);
            this.tpGrant.Name = "tpGrant";
            this.tpGrant.Size = new System.Drawing.Size(700, 534);
            this.tpGrant.TabIndex = 3;
            this.tpGrant.Text = "Authorization Grant";
            this.tpGrant.UseVisualStyleBackColor = true;
            // 
            // gbDeviceCodeFlow
            // 
            this.gbDeviceCodeFlow.Controls.Add(this.cbCultures);
            this.gbDeviceCodeFlow.Controls.Add(this.cbDeviceCodeFlowMessageLanguage);
            this.gbDeviceCodeFlow.Enabled = false;
            this.gbDeviceCodeFlow.Location = new System.Drawing.Point(14, 425);
            this.gbDeviceCodeFlow.Name = "gbDeviceCodeFlow";
            this.gbDeviceCodeFlow.Size = new System.Drawing.Size(415, 46);
            this.gbDeviceCodeFlow.TabIndex = 41;
            this.gbDeviceCodeFlow.TabStop = false;
            this.gbDeviceCodeFlow.Text = "Device Code Flow";
            // 
            // cbCultures
            // 
            this.cbCultures.FormattingEnabled = true;
            this.cbCultures.Location = new System.Drawing.Point(189, 17);
            this.cbCultures.Name = "cbCultures";
            this.cbCultures.Size = new System.Drawing.Size(215, 21);
            this.cbCultures.TabIndex = 42;
            // 
            // cbDeviceCodeFlowMessageLanguage
            // 
            this.cbDeviceCodeFlowMessageLanguage.AutoSize = true;
            this.cbDeviceCodeFlowMessageLanguage.Location = new System.Drawing.Point(6, 19);
            this.cbDeviceCodeFlowMessageLanguage.Name = "cbDeviceCodeFlowMessageLanguage";
            this.cbDeviceCodeFlowMessageLanguage.Size = new System.Drawing.Size(177, 17);
            this.cbDeviceCodeFlowMessageLanguage.TabIndex = 33;
            this.cbDeviceCodeFlowMessageLanguage.Text = "Culture for user facing message:";
            this.cbDeviceCodeFlowMessageLanguage.UseVisualStyleBackColor = true;
            // 
            // btnNext4
            // 
            this.btnNext4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext4.Location = new System.Drawing.Point(622, 508);
            this.btnNext4.Name = "btnNext4";
            this.btnNext4.Size = new System.Drawing.Size(75, 23);
            this.btnNext4.TabIndex = 41;
            this.btnNext4.Text = "Next";
            this.btnNext4.UseVisualStyleBackColor = true;
            this.btnNext4.Click += new System.EventHandler(this.ValidateGrantTab);
            // 
            // gbHybridFlow
            // 
            this.gbHybridFlow.Controls.Add(this.label34);
            this.gbHybridFlow.Controls.Add(this.cbHybridFlow_Implicit_RequestCode);
            this.gbHybridFlow.Controls.Add(this.cbHybridFlow_Implicit_RequestAccessToken);
            this.gbHybridFlow.Controls.Add(this.cbHybridFlow_Implicit_RequestIdToken);
            this.gbHybridFlow.Enabled = false;
            this.gbHybridFlow.Location = new System.Drawing.Point(14, 357);
            this.gbHybridFlow.Name = "gbHybridFlow";
            this.gbHybridFlow.Size = new System.Drawing.Size(415, 62);
            this.gbHybridFlow.TabIndex = 40;
            this.gbHybridFlow.TabStop = false;
            this.gbHybridFlow.Text = "Hybrid / Implicit Flow";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(68, 39);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(341, 13);
            this.label34.TabIndex = 34;
            this.label34.Text = "In order to get a Refresh Token with OpenID Connect, request a code.";
            // 
            // cbHybridFlow_Implicit_RequestCode
            // 
            this.cbHybridFlow_Implicit_RequestCode.AutoSize = true;
            this.cbHybridFlow_Implicit_RequestCode.Checked = true;
            this.cbHybridFlow_Implicit_RequestCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHybridFlow_Implicit_RequestCode.Location = new System.Drawing.Point(283, 19);
            this.cbHybridFlow_Implicit_RequestCode.Name = "cbHybridFlow_Implicit_RequestCode";
            this.cbHybridFlow_Implicit_RequestCode.Size = new System.Drawing.Size(94, 17);
            this.cbHybridFlow_Implicit_RequestCode.TabIndex = 35;
            this.cbHybridFlow_Implicit_RequestCode.Text = "Request Code";
            this.cbHybridFlow_Implicit_RequestCode.UseVisualStyleBackColor = true;
            // 
            // cbHybridFlow_Implicit_RequestAccessToken
            // 
            this.cbHybridFlow_Implicit_RequestAccessToken.AutoSize = true;
            this.cbHybridFlow_Implicit_RequestAccessToken.Location = new System.Drawing.Point(126, 19);
            this.cbHybridFlow_Implicit_RequestAccessToken.Name = "cbHybridFlow_Implicit_RequestAccessToken";
            this.cbHybridFlow_Implicit_RequestAccessToken.Size = new System.Drawing.Size(138, 17);
            this.cbHybridFlow_Implicit_RequestAccessToken.TabIndex = 34;
            this.cbHybridFlow_Implicit_RequestAccessToken.Text = "Request Access Token";
            this.cbHybridFlow_Implicit_RequestAccessToken.UseVisualStyleBackColor = true;
            // 
            // cbHybridFlow_Implicit_RequestIdToken
            // 
            this.cbHybridFlow_Implicit_RequestIdToken.AutoSize = true;
            this.cbHybridFlow_Implicit_RequestIdToken.Checked = true;
            this.cbHybridFlow_Implicit_RequestIdToken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHybridFlow_Implicit_RequestIdToken.Location = new System.Drawing.Point(6, 19);
            this.cbHybridFlow_Implicit_RequestIdToken.Name = "cbHybridFlow_Implicit_RequestIdToken";
            this.cbHybridFlow_Implicit_RequestIdToken.Size = new System.Drawing.Size(114, 17);
            this.cbHybridFlow_Implicit_RequestIdToken.TabIndex = 33;
            this.cbHybridFlow_Implicit_RequestIdToken.Text = "Request ID Token";
            this.cbHybridFlow_Implicit_RequestIdToken.UseVisualStyleBackColor = true;
            // 
            // gbOnBehalfOf
            // 
            this.gbOnBehalfOf.Controls.Add(this.rbOBO_UseResource);
            this.gbOnBehalfOf.Controls.Add(this.rbOBO_UseScope);
            this.gbOnBehalfOf.Controls.Add(this.tbOBO_ScopeOrResource);
            this.gbOnBehalfOf.Controls.Add(this.label32);
            this.gbOnBehalfOf.Controls.Add(this.label16);
            this.gbOnBehalfOf.Controls.Add(this.label33);
            this.gbOnBehalfOf.Controls.Add(this.label17);
            this.gbOnBehalfOf.Controls.Add(this.tbOBO_ClientId);
            this.gbOnBehalfOf.Controls.Add(this.label31);
            this.gbOnBehalfOf.Controls.Add(this.tbOBO_ClientSecret);
            this.gbOnBehalfOf.Enabled = false;
            this.gbOnBehalfOf.Location = new System.Drawing.Point(14, 188);
            this.gbOnBehalfOf.Name = "gbOnBehalfOf";
            this.gbOnBehalfOf.Size = new System.Drawing.Size(415, 163);
            this.gbOnBehalfOf.TabIndex = 39;
            this.gbOnBehalfOf.TabStop = false;
            this.gbOnBehalfOf.Text = "On-Behalf-Of";
            // 
            // rbOBO_UseResource
            // 
            this.rbOBO_UseResource.AutoSize = true;
            this.rbOBO_UseResource.Location = new System.Drawing.Point(64, 131);
            this.rbOBO_UseResource.Name = "rbOBO_UseResource";
            this.rbOBO_UseResource.Size = new System.Drawing.Size(71, 17);
            this.rbOBO_UseResource.TabIndex = 34;
            this.rbOBO_UseResource.Text = "Resource";
            this.rbOBO_UseResource.UseVisualStyleBackColor = true;
            // 
            // rbOBO_UseScope
            // 
            this.rbOBO_UseScope.AutoSize = true;
            this.rbOBO_UseScope.Checked = true;
            this.rbOBO_UseScope.Location = new System.Drawing.Point(11, 130);
            this.rbOBO_UseScope.Name = "rbOBO_UseScope";
            this.rbOBO_UseScope.Size = new System.Drawing.Size(56, 17);
            this.rbOBO_UseScope.TabIndex = 33;
            this.rbOBO_UseScope.TabStop = true;
            this.rbOBO_UseScope.Text = "Scope";
            this.rbOBO_UseScope.UseVisualStyleBackColor = true;
            // 
            // tbOBO_ScopeOrResource
            // 
            this.tbOBO_ScopeOrResource.Location = new System.Drawing.Point(141, 130);
            this.tbOBO_ScopeOrResource.Name = "tbOBO_ScopeOrResource";
            this.tbOBO_ScopeOrResource.Size = new System.Drawing.Size(263, 20);
            this.tbOBO_ScopeOrResource.TabIndex = 32;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(8, 35);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(332, 13);
            this.label32.TabIndex = 30;
            this.label32.Text = "Then, using the credentials for that Backend API, request a token for";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Client Secret:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(8, 53);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(250, 13);
            this.label33.TabIndex = 31;
            this.label33.Text = "the dummy API. This MUST be a confidential client.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Client Id:";
            // 
            // tbOBO_ClientId
            // 
            this.tbOBO_ClientId.Location = new System.Drawing.Point(141, 78);
            this.tbOBO_ClientId.Name = "tbOBO_ClientId";
            this.tbOBO_ClientId.Size = new System.Drawing.Size(263, 20);
            this.tbOBO_ClientId.TabIndex = 18;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(8, 17);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(334, 13);
            this.label31.TabIndex = 29;
            this.label31.Text = "On-Behalf-Of will request a token from the Client to the Back-end API,";
            // 
            // tbOBO_ClientSecret
            // 
            this.tbOBO_ClientSecret.Location = new System.Drawing.Point(141, 104);
            this.tbOBO_ClientSecret.Name = "tbOBO_ClientSecret";
            this.tbOBO_ClientSecret.Size = new System.Drawing.Size(263, 20);
            this.tbOBO_ClientSecret.TabIndex = 27;
            // 
            // gbROPCFlow
            // 
            this.gbROPCFlow.Controls.Add(this.tb_ClientCredentials_UseROP_Username);
            this.gbROPCFlow.Controls.Add(this.label18);
            this.gbROPCFlow.Controls.Add(this.label19);
            this.gbROPCFlow.Controls.Add(this.tb_ClientCredentials_UseROP_Password);
            this.gbROPCFlow.Enabled = false;
            this.gbROPCFlow.Location = new System.Drawing.Point(14, 106);
            this.gbROPCFlow.Name = "gbROPCFlow";
            this.gbROPCFlow.Size = new System.Drawing.Size(415, 76);
            this.gbROPCFlow.TabIndex = 37;
            this.gbROPCFlow.TabStop = false;
            this.gbROPCFlow.Text = "Resource Owner Password Credentials Flow";
            // 
            // tb_ClientCredentials_UseROP_Username
            // 
            this.tb_ClientCredentials_UseROP_Username.Location = new System.Drawing.Point(75, 19);
            this.tb_ClientCredentials_UseROP_Username.Name = "tb_ClientCredentials_UseROP_Username";
            this.tb_ClientCredentials_UseROP_Username.Size = new System.Drawing.Size(176, 20);
            this.tb_ClientCredentials_UseROP_Username.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Password:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "User name:";
            // 
            // tb_ClientCredentials_UseROP_Password
            // 
            this.tb_ClientCredentials_UseROP_Password.Location = new System.Drawing.Point(75, 44);
            this.tb_ClientCredentials_UseROP_Password.Name = "tb_ClientCredentials_UseROP_Password";
            this.tb_ClientCredentials_UseROP_Password.Size = new System.Drawing.Size(176, 20);
            this.tb_ClientCredentials_UseROP_Password.TabIndex = 8;
            this.tb_ClientCredentials_UseROP_Password.UseSystemPasswordChar = true;
            // 
            // tbOptions
            // 
            this.tbOptions.Controls.Add(this.cbAddClientRequestId);
            this.tbOptions.Controls.Add(this.gbMiscOptions);
            this.tbOptions.Controls.Add(this.gbCodeFlow_PKCE);
            this.tbOptions.Controls.Add(this.btnExecute);
            this.tbOptions.Controls.Add(this.rbPreferMSAL);
            this.tbOptions.Controls.Add(this.rbPreferHttp);
            this.tbOptions.Controls.Add(this.rbPreferADAL);
            this.tbOptions.Location = new System.Drawing.Point(4, 22);
            this.tbOptions.Name = "tbOptions";
            this.tbOptions.Size = new System.Drawing.Size(700, 534);
            this.tbOptions.TabIndex = 4;
            this.tbOptions.Text = "Options";
            this.tbOptions.UseVisualStyleBackColor = true;
            // 
            // cbAddClientRequestId
            // 
            this.cbAddClientRequestId.AutoSize = true;
            this.cbAddClientRequestId.Location = new System.Drawing.Point(15, 365);
            this.cbAddClientRequestId.Name = "cbAddClientRequestId";
            this.cbAddClientRequestId.Size = new System.Drawing.Size(247, 17);
            this.cbAddClientRequestId.TabIndex = 55;
            this.cbAddClientRequestId.Text = "Add a \'client-request-id\' to requests to the STS.";
            this.cbAddClientRequestId.UseVisualStyleBackColor = true;
            // 
            // gbMiscOptions
            // 
            this.gbMiscOptions.Controls.Add(this.label15);
            this.gbMiscOptions.Controls.Add(this.label21);
            this.gbMiscOptions.Controls.Add(this.tbCodeFlow_LoginHint);
            this.gbMiscOptions.Controls.Add(this.lbCodeFlow_DomainHint);
            this.gbMiscOptions.Controls.Add(this.cbCodeFlow_ResponseMode);
            this.gbMiscOptions.Controls.Add(this.cbCodeFlow_Prompt);
            this.gbMiscOptions.Controls.Add(this.label22);
            this.gbMiscOptions.Controls.Add(this.tbOptions_State);
            this.gbMiscOptions.Controls.Add(this.label7);
            this.gbMiscOptions.Controls.Add(this.label23);
            this.gbMiscOptions.Location = new System.Drawing.Point(15, 52);
            this.gbMiscOptions.Name = "gbMiscOptions";
            this.gbMiscOptions.Size = new System.Drawing.Size(516, 170);
            this.gbMiscOptions.TabIndex = 54;
            this.gbMiscOptions.TabStop = false;
            this.gbMiscOptions.Text = "Misc. Options";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "State:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 43;
            this.label21.Text = "Prompt:";
            // 
            // tbCodeFlow_LoginHint
            // 
            this.tbCodeFlow_LoginHint.Location = new System.Drawing.Point(134, 108);
            this.tbCodeFlow_LoginHint.Name = "tbCodeFlow_LoginHint";
            this.tbCodeFlow_LoginHint.Size = new System.Drawing.Size(331, 20);
            this.tbCodeFlow_LoginHint.TabIndex = 46;
            // 
            // lbCodeFlow_DomainHint
            // 
            this.lbCodeFlow_DomainHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbCodeFlow_DomainHint.FormattingEnabled = true;
            this.lbCodeFlow_DomainHint.Items.AddRange(new object[] {
            "consumers",
            "organizations"});
            this.lbCodeFlow_DomainHint.Location = new System.Drawing.Point(134, 134);
            this.lbCodeFlow_DomainHint.Name = "lbCodeFlow_DomainHint";
            this.lbCodeFlow_DomainHint.Size = new System.Drawing.Size(121, 21);
            this.lbCodeFlow_DomainHint.TabIndex = 48;
            // 
            // cbCodeFlow_ResponseMode
            // 
            this.cbCodeFlow_ResponseMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodeFlow_ResponseMode.FormattingEnabled = true;
            this.cbCodeFlow_ResponseMode.Items.AddRange(new object[] {
            "query",
            "fragment",
            "form_post"});
            this.cbCodeFlow_ResponseMode.Location = new System.Drawing.Point(134, 51);
            this.cbCodeFlow_ResponseMode.Name = "cbCodeFlow_ResponseMode";
            this.cbCodeFlow_ResponseMode.Size = new System.Drawing.Size(121, 21);
            this.cbCodeFlow_ResponseMode.TabIndex = 50;
            // 
            // cbCodeFlow_Prompt
            // 
            this.cbCodeFlow_Prompt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodeFlow_Prompt.FormattingEnabled = true;
            this.cbCodeFlow_Prompt.Items.AddRange(new object[] {
            "login",
            "consent",
            "admin_consent"});
            this.cbCodeFlow_Prompt.Location = new System.Drawing.Point(134, 78);
            this.cbCodeFlow_Prompt.Name = "cbCodeFlow_Prompt";
            this.cbCodeFlow_Prompt.Size = new System.Drawing.Size(121, 21);
            this.cbCodeFlow_Prompt.TabIndex = 44;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "Login Hint:";
            // 
            // tbOptions_State
            // 
            this.tbOptions_State.Location = new System.Drawing.Point(134, 25);
            this.tbOptions_State.Name = "tbOptions_State";
            this.tbOptions_State.Size = new System.Drawing.Size(331, 20);
            this.tbOptions_State.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Response Mode:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 134);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Domain Hint:";
            // 
            // gbCodeFlow_PKCE
            // 
            this.gbCodeFlow_PKCE.Controls.Add(this.label20);
            this.gbCodeFlow_PKCE.Controls.Add(this.tbCodeFlow_PKCE_Verifier);
            this.gbCodeFlow_PKCE.Controls.Add(this.label26);
            this.gbCodeFlow_PKCE.Controls.Add(this.label25);
            this.gbCodeFlow_PKCE.Controls.Add(this.cbCodeFlow_PKCE_Method);
            this.gbCodeFlow_PKCE.Location = new System.Drawing.Point(15, 228);
            this.gbCodeFlow_PKCE.Name = "gbCodeFlow_PKCE";
            this.gbCodeFlow_PKCE.Size = new System.Drawing.Size(516, 131);
            this.gbCodeFlow_PKCE.TabIndex = 53;
            this.gbCodeFlow_PKCE.TabStop = false;
            this.gbCodeFlow_PKCE.Text = " Proof Key for Code Exchange (PKCE)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(470, 13);
            this.label20.TabIndex = 56;
            this.label20.Text = "PKCE Can be used when the client obtains a Code, like in Authorization Code Flow " +
    "or Hyrbid Flow.";
            // 
            // tbCodeFlow_PKCE_Verifier
            // 
            this.tbCodeFlow_PKCE_Verifier.Location = new System.Drawing.Point(191, 93);
            this.tbCodeFlow_PKCE_Verifier.MaxLength = 128;
            this.tbCodeFlow_PKCE_Verifier.Name = "tbCodeFlow_PKCE_Verifier";
            this.tbCodeFlow_PKCE_Verifier.Size = new System.Drawing.Size(240, 20);
            this.tbCodeFlow_PKCE_Verifier.TabIndex = 55;
            this.tbCodeFlow_PKCE_Verifier.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyx0123456789";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 96);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 13);
            this.label26.TabIndex = 54;
            this.label26.Text = "Code Verifier:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 69);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(124, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "Code Challenge Method:";
            // 
            // cbCodeFlow_PKCE_Method
            // 
            this.cbCodeFlow_PKCE_Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodeFlow_PKCE_Method.FormattingEnabled = true;
            this.cbCodeFlow_PKCE_Method.Items.AddRange(new object[] {
            "plain",
            "S256"});
            this.cbCodeFlow_PKCE_Method.Location = new System.Drawing.Point(191, 66);
            this.cbCodeFlow_PKCE_Method.Name = "cbCodeFlow_PKCE_Method";
            this.cbCodeFlow_PKCE_Method.Size = new System.Drawing.Size(121, 21);
            this.cbCodeFlow_PKCE_Method.TabIndex = 55;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(622, 508);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 49;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.ValidateOptionsTab);
            // 
            // rbPreferMSAL
            // 
            this.rbPreferMSAL.AutoSize = true;
            this.rbPreferMSAL.Location = new System.Drawing.Point(117, 15);
            this.rbPreferMSAL.Name = "rbPreferMSAL";
            this.rbPreferMSAL.Size = new System.Drawing.Size(85, 17);
            this.rbPreferMSAL.TabIndex = 40;
            this.rbPreferMSAL.Text = "Prefer MSAL";
            this.rbPreferMSAL.UseVisualStyleBackColor = true;
            // 
            // rbPreferHttp
            // 
            this.rbPreferHttp.AutoSize = true;
            this.rbPreferHttp.Checked = true;
            this.rbPreferHttp.Location = new System.Drawing.Point(221, 15);
            this.rbPreferHttp.Name = "rbPreferHttp";
            this.rbPreferHttp.Size = new System.Drawing.Size(159, 17);
            this.rbPreferHttp.TabIndex = 39;
            this.rbPreferHttp.TabStop = true;
            this.rbPreferHttp.Text = "Prefer HTTP Web Requests";
            this.rbPreferHttp.UseVisualStyleBackColor = true;
            // 
            // rbPreferADAL
            // 
            this.rbPreferADAL.AutoSize = true;
            this.rbPreferADAL.Location = new System.Drawing.Point(15, 15);
            this.rbPreferADAL.Name = "rbPreferADAL";
            this.rbPreferADAL.Size = new System.Drawing.Size(84, 17);
            this.rbPreferADAL.TabIndex = 38;
            this.rbPreferADAL.Text = "Prefer ADAL";
            this.rbPreferADAL.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Controls.Add(this.btnTest);
            this.tbResult.Controls.Add(this.tabControl2);
            this.tbResult.Location = new System.Drawing.Point(4, 22);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(700, 534);
            this.tbResult.TabIndex = 5;
            this.tbResult.Text = "Result";
            this.tbResult.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(561, 508);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(132, 23);
            this.btnTest.TabIndex = 43;
            this.btnTest.Text = "Test Graph UserInfo";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // btnUseRefreshToken
            // 
            this.btnUseRefreshToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseRefreshToken.Location = new System.Drawing.Point(566, 444);
            this.btnUseRefreshToken.Name = "btnUseRefreshToken";
            this.btnUseRefreshToken.Size = new System.Drawing.Size(110, 23);
            this.btnUseRefreshToken.TabIndex = 40;
            this.btnUseRefreshToken.Text = "Use &Refresh Token";
            this.btnUseRefreshToken.UseVisualStyleBackColor = true;
            this.btnUseRefreshToken.Click += new System.EventHandler(this.btnUseRefreshToken_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tpErrors);
            this.tabControl2.Controls.Add(this.tpCode);
            this.tabControl2.Controls.Add(this.tpAccessToken);
            this.tabControl2.Controls.Add(this.tpAccessTokenDecoded);
            this.tabControl2.Controls.Add(this.tpRefreshToken);
            this.tabControl2.Controls.Add(this.tpIdToken);
            this.tabControl2.Controls.Add(this.tpIdTokenDecoded);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(690, 499);
            this.tabControl2.TabIndex = 18;
            // 
            // tpErrors
            // 
            this.tpErrors.Controls.Add(this.tbErrors);
            this.tpErrors.Location = new System.Drawing.Point(4, 22);
            this.tpErrors.Name = "tpErrors";
            this.tpErrors.Size = new System.Drawing.Size(682, 473);
            this.tpErrors.TabIndex = 4;
            this.tpErrors.Text = "Error(s)";
            this.tpErrors.UseVisualStyleBackColor = true;
            // 
            // tbErrors
            // 
            this.tbErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbErrors.Location = new System.Drawing.Point(0, 0);
            this.tbErrors.Multiline = true;
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.Size = new System.Drawing.Size(682, 473);
            this.tbErrors.TabIndex = 9;
            // 
            // tpCode
            // 
            this.tpCode.Controls.Add(this.tbCode);
            this.tpCode.Location = new System.Drawing.Point(4, 22);
            this.tpCode.Name = "tpCode";
            this.tpCode.Size = new System.Drawing.Size(682, 473);
            this.tpCode.TabIndex = 3;
            this.tpCode.Text = "Code";
            this.tpCode.UseVisualStyleBackColor = true;
            // 
            // tbCode
            // 
            this.tbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCode.Location = new System.Drawing.Point(0, 0);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(682, 473);
            this.tbCode.TabIndex = 8;
            // 
            // tpAccessToken
            // 
            this.tpAccessToken.Controls.Add(this.btnValidateAccessToken);
            this.tpAccessToken.Controls.Add(this.tbAccessToken);
            this.tpAccessToken.Location = new System.Drawing.Point(4, 22);
            this.tpAccessToken.Name = "tpAccessToken";
            this.tpAccessToken.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccessToken.Size = new System.Drawing.Size(682, 473);
            this.tpAccessToken.TabIndex = 0;
            this.tpAccessToken.Text = "Access Token";
            this.tpAccessToken.UseVisualStyleBackColor = true;
            // 
            // btnValidateAccessToken
            // 
            this.btnValidateAccessToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidateAccessToken.Location = new System.Drawing.Point(508, 444);
            this.btnValidateAccessToken.Name = "btnValidateAccessToken";
            this.btnValidateAccessToken.Size = new System.Drawing.Size(168, 23);
            this.btnValidateAccessToken.TabIndex = 44;
            this.btnValidateAccessToken.Text = "Validate Access Token (BETA)";
            this.btnValidateAccessToken.UseVisualStyleBackColor = true;
            this.btnValidateAccessToken.Click += new System.EventHandler(this.BtnAccessValidateToken_Click);
            // 
            // tbAccessToken
            // 
            this.tbAccessToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAccessToken.Location = new System.Drawing.Point(3, 3);
            this.tbAccessToken.Multiline = true;
            this.tbAccessToken.Name = "tbAccessToken";
            this.tbAccessToken.Size = new System.Drawing.Size(676, 435);
            this.tbAccessToken.TabIndex = 6;
            // 
            // tpAccessTokenDecoded
            // 
            this.tpAccessTokenDecoded.Controls.Add(this.tbAccessTokenDecoded);
            this.tpAccessTokenDecoded.Location = new System.Drawing.Point(4, 22);
            this.tpAccessTokenDecoded.Name = "tpAccessTokenDecoded";
            this.tpAccessTokenDecoded.Size = new System.Drawing.Size(682, 473);
            this.tpAccessTokenDecoded.TabIndex = 5;
            this.tpAccessTokenDecoded.Text = "Access Token (Decoded)";
            this.tpAccessTokenDecoded.UseVisualStyleBackColor = true;
            // 
            // tbAccessTokenDecoded
            // 
            this.tbAccessTokenDecoded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAccessTokenDecoded.Location = new System.Drawing.Point(0, 0);
            this.tbAccessTokenDecoded.Multiline = true;
            this.tbAccessTokenDecoded.Name = "tbAccessTokenDecoded";
            this.tbAccessTokenDecoded.Size = new System.Drawing.Size(682, 473);
            this.tbAccessTokenDecoded.TabIndex = 10;
            // 
            // tpRefreshToken
            // 
            this.tpRefreshToken.Controls.Add(this.tbRefreshToken);
            this.tpRefreshToken.Controls.Add(this.btnUseRefreshToken);
            this.tpRefreshToken.Location = new System.Drawing.Point(4, 22);
            this.tpRefreshToken.Name = "tpRefreshToken";
            this.tpRefreshToken.Padding = new System.Windows.Forms.Padding(3);
            this.tpRefreshToken.Size = new System.Drawing.Size(682, 473);
            this.tpRefreshToken.TabIndex = 1;
            this.tpRefreshToken.Text = "Refresh Token";
            this.tpRefreshToken.UseVisualStyleBackColor = true;
            // 
            // tbRefreshToken
            // 
            this.tbRefreshToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRefreshToken.Location = new System.Drawing.Point(3, 3);
            this.tbRefreshToken.Multiline = true;
            this.tbRefreshToken.Name = "tbRefreshToken";
            this.tbRefreshToken.Size = new System.Drawing.Size(676, 435);
            this.tbRefreshToken.TabIndex = 7;
            // 
            // tpIdToken
            // 
            this.tpIdToken.Controls.Add(this.btnValidateIdToken);
            this.tpIdToken.Controls.Add(this.tbIdToken);
            this.tpIdToken.Location = new System.Drawing.Point(4, 22);
            this.tpIdToken.Name = "tpIdToken";
            this.tpIdToken.Size = new System.Drawing.Size(682, 473);
            this.tpIdToken.TabIndex = 2;
            this.tpIdToken.Text = "ID Token";
            this.tpIdToken.UseVisualStyleBackColor = true;
            // 
            // btnValidateIdToken
            // 
            this.btnValidateIdToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidateIdToken.Location = new System.Drawing.Point(546, 447);
            this.btnValidateIdToken.Name = "btnValidateIdToken";
            this.btnValidateIdToken.Size = new System.Drawing.Size(133, 23);
            this.btnValidateIdToken.TabIndex = 45;
            this.btnValidateIdToken.Text = "Validate ID Token";
            this.btnValidateIdToken.UseVisualStyleBackColor = true;
            this.btnValidateIdToken.Click += new System.EventHandler(this.BtnValidateIdToken_Click);
            // 
            // tbIdToken
            // 
            this.tbIdToken.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdToken.Location = new System.Drawing.Point(0, 0);
            this.tbIdToken.Multiline = true;
            this.tbIdToken.Name = "tbIdToken";
            this.tbIdToken.Size = new System.Drawing.Size(682, 441);
            this.tbIdToken.TabIndex = 8;
            // 
            // tpIdTokenDecoded
            // 
            this.tpIdTokenDecoded.Controls.Add(this.tbIdTokenDecoded);
            this.tpIdTokenDecoded.Location = new System.Drawing.Point(4, 22);
            this.tpIdTokenDecoded.Name = "tpIdTokenDecoded";
            this.tpIdTokenDecoded.Size = new System.Drawing.Size(682, 473);
            this.tpIdTokenDecoded.TabIndex = 7;
            this.tpIdTokenDecoded.Text = "ID Token (Decoded)";
            this.tpIdTokenDecoded.UseVisualStyleBackColor = true;
            // 
            // tbIdTokenDecoded
            // 
            this.tbIdTokenDecoded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIdTokenDecoded.Location = new System.Drawing.Point(0, 0);
            this.tbIdTokenDecoded.Multiline = true;
            this.tbIdTokenDecoded.Name = "tbIdTokenDecoded";
            this.tbIdTokenDecoded.Size = new System.Drawing.Size(682, 473);
            this.tbIdTokenDecoded.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(641, 578);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 50;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ttHint
            // 
            this.ttHint.IsBalloon = true;
            this.ttHint.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttHint.ToolTipTitle = "Hint";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnNext1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 610);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(748, 649);
            this.Name = "MainForm";
            this.Text = "OAuth 2.0 & OpenID Connect Demo App v2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbClientCredential_Cert.ResumeLayout(false);
            this.gbClientCredential_Cert.PerformLayout();
            this.gbClientCredential_WIA.ResumeLayout(false);
            this.gbClientCredential_WIA.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpSTS.ResumeLayout(false);
            this.tpSTS.PerformLayout();
            this.gbADFS.ResumeLayout(false);
            this.gbADFS.PerformLayout();
            this.gbAzureAD.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpClient.ResumeLayout(false);
            this.tpClient.PerformLayout();
            this.gbClientCredential_Secret.ResumeLayout(false);
            this.gbClientCredential_Secret.PerformLayout();
            this.tpResource.ResumeLayout(false);
            this.tpResource.PerformLayout();
            this.tpGrant.ResumeLayout(false);
            this.tpGrant.PerformLayout();
            this.gbDeviceCodeFlow.ResumeLayout(false);
            this.gbDeviceCodeFlow.PerformLayout();
            this.gbHybridFlow.ResumeLayout(false);
            this.gbHybridFlow.PerformLayout();
            this.gbOnBehalfOf.ResumeLayout(false);
            this.gbOnBehalfOf.PerformLayout();
            this.gbROPCFlow.ResumeLayout(false);
            this.gbROPCFlow.PerformLayout();
            this.tbOptions.ResumeLayout(false);
            this.tbOptions.PerformLayout();
            this.gbMiscOptions.ResumeLayout(false);
            this.gbMiscOptions.PerformLayout();
            this.gbCodeFlow_PKCE.ResumeLayout(false);
            this.gbCodeFlow_PKCE.PerformLayout();
            this.tbResult.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpErrors.ResumeLayout(false);
            this.tpErrors.PerformLayout();
            this.tpCode.ResumeLayout(false);
            this.tpCode.PerformLayout();
            this.tpAccessToken.ResumeLayout(false);
            this.tpAccessToken.PerformLayout();
            this.tpAccessTokenDecoded.ResumeLayout(false);
            this.tpAccessTokenDecoded.PerformLayout();
            this.tpRefreshToken.ResumeLayout(false);
            this.tpRefreshToken.PerformLayout();
            this.tpIdToken.ResumeLayout(false);
            this.tpIdToken.PerformLayout();
            this.tpIdTokenDecoded.ResumeLayout(false);
            this.tpIdTokenDecoded.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbAuthEndpoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStsType;
        private System.Windows.Forms.TextBox tbTokenEndpoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGrantFlow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdfsFarmName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAadTenant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbClientType;
        private System.Windows.Forms.TextBox tbClientSecret;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbClientCredential_WIA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbClientCredential_WIA_Credentials_Other_Password;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbClientCredential_WIA_Credentials_Other;
        private System.Windows.Forms.TextBox tbClientCredential_WIA_Credentials_Other_UserName;
        private System.Windows.Forms.RadioButton rbClientCredential_WIA_Credentials_Current;
        private System.Windows.Forms.GroupBox gbClientCredential_Cert;
        private System.Windows.Forms.TextBox tbClientCredentials_Cert_CertSN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClientCredentials_Cert_SelectCert;
        private System.Windows.Forms.RadioButton rbScope;
        private System.Windows.Forms.RadioButton rbResource;
        private System.Windows.Forms.TextBox tbScope;
        private System.Windows.Forms.TextBox tbResource;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpSTS;
        private System.Windows.Forms.TabPage tpClient;
        private System.Windows.Forms.TabPage tpResource;
        private System.Windows.Forms.TabPage tpGrant;
        private System.Windows.Forms.GroupBox gbHybridFlow;
        private System.Windows.Forms.CheckBox cbHybridFlow_Implicit_RequestCode;
        private System.Windows.Forms.CheckBox cbHybridFlow_Implicit_RequestAccessToken;
        private System.Windows.Forms.CheckBox cbHybridFlow_Implicit_RequestIdToken;
        private System.Windows.Forms.GroupBox gbOnBehalfOf;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbOBO_ClientId;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbOBO_ClientSecret;
        private System.Windows.Forms.GroupBox gbROPCFlow;
        private System.Windows.Forms.TextBox tb_ClientCredentials_UseROP_Username;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_ClientCredentials_UseROP_Password;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.Button btnNext3;
        private System.Windows.Forms.Button btnNext4;
        private System.Windows.Forms.TabPage tbOptions;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox lbCodeFlow_DomainHint;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbCodeFlow_Prompt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbCodeFlow_LoginHint;
        private System.Windows.Forms.RadioButton rbPreferMSAL;
        private System.Windows.Forms.RadioButton rbPreferHttp;
        private System.Windows.Forms.RadioButton rbPreferADAL;
        private System.Windows.Forms.TabPage tbResult;
        private System.Windows.Forms.Button btnUseRefreshToken;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpAccessToken;
        private System.Windows.Forms.TextBox tbAccessToken;
        private System.Windows.Forms.TabPage tpCode;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.TabPage tpRefreshToken;
        private System.Windows.Forms.TextBox tbRefreshToken;
        private System.Windows.Forms.TabPage tpIdToken;
        private System.Windows.Forms.TextBox tbIdToken;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbClientCredential_Secret;
        private System.Windows.Forms.TabPage tpErrors;
        private System.Windows.Forms.TextBox tbErrors;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbDeviceCodeEndpoint;
        private System.Windows.Forms.GroupBox gbDeviceCodeFlow;
        private System.Windows.Forms.CheckBox cbDeviceCodeFlowMessageLanguage;
        private System.Windows.Forms.GroupBox gbAzureAD;
        private System.Windows.Forms.RadioButton rbAzureADv1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAzureAdEndpoint_Common;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAzureADv2;
        private System.Windows.Forms.RadioButton rbAzureAdEndpoint_Tenant;
        private System.Windows.Forms.RadioButton rbAzureAdEndpoint_Organizations;
        private System.Windows.Forms.RadioButton rbAzureAdEndpoint_Consumers;
        private System.Windows.Forms.GroupBox gbADFS;
        private System.Windows.Forms.ComboBox cbCodeFlow_ResponseMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOptions_State;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox gbCodeFlow_PKCE;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbCodeFlow_PKCE_Method;
        private System.Windows.Forms.TextBox tbCodeFlow_PKCE_Verifier;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnGetMetadata;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbMetadataEndpoint;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbClientRedirectUri;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbOBO_ScopeOrResource;
        private System.Windows.Forms.TabPage tpAccessTokenDecoded;
        private System.Windows.Forms.TabPage tpIdTokenDecoded;
        private System.Windows.Forms.TextBox tbAccessTokenDecoded;
        private System.Windows.Forms.TextBox tbIdTokenDecoded;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnValidateAccessToken;
        private System.Windows.Forms.Button btnValidateIdToken;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.RadioButton rbOBO_UseResource;
        private System.Windows.Forms.RadioButton rbOBO_UseScope;
        private System.Windows.Forms.GroupBox gbMiscOptions;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbCultures;
        private System.Windows.Forms.ToolTip ttHint;
        private System.Windows.Forms.CheckBox cbAddClientRequestId;
    }
}

