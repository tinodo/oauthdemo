namespace OAuthDemoApp
{
    partial class DeviceCodeForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.authenticationTimeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.authenticationCallbackTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbTimeLeft = new System.Windows.Forms.ToolStripProgressBar();
            this.lblTimeleft = new System.Windows.Forms.ToolStripStatusLabel();
            this.formRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.llVerificationUri = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInitialRequest = new System.Windows.Forms.TextBox();
            this.tbPollingResult = new System.Windows.Forms.TextBox();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbPoll = new System.Windows.Forms.ToolStripProgressBar();
            this.lblPoll = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // authenticationTimeoutTimer
            // 
            this.authenticationTimeoutTimer.Tick += new System.EventHandler(this.AuthenticationTimedOut);
            // 
            // authenticationCallbackTimer
            // 
            this.authenticationCallbackTimer.Tick += new System.EventHandler(this.AuthenticationCallback);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pbTimeLeft,
            this.lblTimeleft,
            this.toolStripStatusLabel2,
            this.pbPoll,
            this.lblPoll});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabel1.Text = "Time left to authenticate:";
            // 
            // pbTimeLeft
            // 
            this.pbTimeLeft.Name = "pbTimeLeft";
            this.pbTimeLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbTimeLeft.RightToLeftLayout = true;
            this.pbTimeLeft.Size = new System.Drawing.Size(100, 16);
            this.pbTimeLeft.Step = 1;
            this.pbTimeLeft.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lblTimeleft
            // 
            this.lblTimeleft.Name = "lblTimeleft";
            this.lblTimeleft.Size = new System.Drawing.Size(36, 17);
            this.lblTimeleft.Text = "0 sec.";
            // 
            // formRefreshTimer
            // 
            this.formRefreshTimer.Interval = 250;
            this.formRefreshTimer.Tick += new System.EventHandler(this.RefreshForm);
            // 
            // llVerificationUri
            // 
            this.llVerificationUri.AutoSize = true;
            this.llVerificationUri.Location = new System.Drawing.Point(683, 372);
            this.llVerificationUri.Name = "llVerificationUri";
            this.llVerificationUri.Size = new System.Drawing.Size(105, 13);
            this.llVerificationUri.TabIndex = 2;
            this.llVerificationUri.TabStop = true;
            this.llVerificationUri.Text = "Click to Authenticate";
            this.llVerificationUri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlVerificationUri_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbInitialRequest
            // 
            this.tbInitialRequest.Location = new System.Drawing.Point(12, 12);
            this.tbInitialRequest.Multiline = true;
            this.tbInitialRequest.Name = "tbInitialRequest";
            this.tbInitialRequest.Size = new System.Drawing.Size(776, 186);
            this.tbInitialRequest.TabIndex = 4;
            // 
            // tbPollingResult
            // 
            this.tbPollingResult.Location = new System.Drawing.Point(12, 252);
            this.tbPollingResult.Multiline = true;
            this.tbPollingResult.Name = "tbPollingResult";
            this.tbPollingResult.Size = new System.Drawing.Size(776, 106);
            this.tbPollingResult.TabIndex = 5;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(149, 17);
            this.toolStripStatusLabel2.Text = "Next authentication check:";
            // 
            // pbPoll
            // 
            this.pbPoll.Name = "pbPoll";
            this.pbPoll.Size = new System.Drawing.Size(100, 16);
            // 
            // lblPoll
            // 
            this.lblPoll.Name = "lblPoll";
            this.lblPoll.Size = new System.Drawing.Size(36, 17);
            this.lblPoll.Text = "0 sec.";
            // 
            // DeviceCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPollingResult);
            this.Controls.Add(this.tbInitialRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llVerificationUri);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceCodeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Code Form";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Timer authenticationTimeoutTimer;
        private System.Windows.Forms.Timer authenticationCallbackTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pbTimeLeft;
        private System.Windows.Forms.ToolStripStatusLabel lblTimeleft;
        private System.Windows.Forms.Timer formRefreshTimer;
        private System.Windows.Forms.LinkLabel llVerificationUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInitialRequest;
        private System.Windows.Forms.TextBox tbPollingResult;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar pbPoll;
        private System.Windows.Forms.ToolStripStatusLabel lblPoll;
    }
}