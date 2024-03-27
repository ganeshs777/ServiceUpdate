namespace ServiceUpdate.Server
{
    partial class ServiceUpdateServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSendServiceUpdateMessage = new Button();
            LabelServiceUpdateMessage = new Label();
            LabelSetupFilePath = new Label();
            LabelServiceName = new Label();
            TextBoxSetupFilePath = new TextBox();
            TextBoxServiceName = new TextBox();
            lblError = new Label();
            SuspendLayout();
            // 
            // btnSendServiceUpdateMessage
            // 
            btnSendServiceUpdateMessage.Location = new Point(563, 67);
            btnSendServiceUpdateMessage.Name = "btnSendServiceUpdateMessage";
            btnSendServiceUpdateMessage.Size = new Size(75, 23);
            btnSendServiceUpdateMessage.TabIndex = 17;
            btnSendServiceUpdateMessage.Text = "Send";
            btnSendServiceUpdateMessage.UseVisualStyleBackColor = true;
            btnSendServiceUpdateMessage.Click += btnSendServiceUpdateMessage_Click;
            // 
            // LabelServiceUpdateMessage
            // 
            LabelServiceUpdateMessage.ForeColor = Color.Navy;
            LabelServiceUpdateMessage.Location = new Point(5, 71);
            LabelServiceUpdateMessage.Name = "LabelServiceUpdateMessage";
            LabelServiceUpdateMessage.Size = new Size(542, 23);
            LabelServiceUpdateMessage.TabIndex = 16;
            LabelServiceUpdateMessage.Text = "Service Update Meesage";
            LabelServiceUpdateMessage.Visible = false;
            // 
            // LabelSetupFilePath
            // 
            LabelSetupFilePath.AutoSize = true;
            LabelSetupFilePath.Location = new Point(5, 41);
            LabelSetupFilePath.Name = "LabelSetupFilePath";
            LabelSetupFilePath.Size = new Size(85, 15);
            LabelSetupFilePath.TabIndex = 14;
            LabelSetupFilePath.Text = "Setup File Path";
            // 
            // LabelServiceName
            // 
            LabelServiceName.AutoSize = true;
            LabelServiceName.Location = new Point(11, 15);
            LabelServiceName.Name = "LabelServiceName";
            LabelServiceName.Size = new Size(79, 15);
            LabelServiceName.TabIndex = 13;
            LabelServiceName.Text = "Service Name";
            // 
            // TextBoxSetupFilePath
            // 
            TextBoxSetupFilePath.Location = new Point(96, 38);
            TextBoxSetupFilePath.Name = "TextBoxSetupFilePath";
            TextBoxSetupFilePath.Size = new Size(542, 23);
            TextBoxSetupFilePath.TabIndex = 12;
            TextBoxSetupFilePath.Text = "C:\\Service Update\\ServiceUpdateInstaller.exe";
            // 
            // TextBoxServiceName
            // 
            TextBoxServiceName.Location = new Point(96, 12);
            TextBoxServiceName.Name = "TextBoxServiceName";
            TextBoxServiceName.Size = new Size(542, 23);
            TextBoxServiceName.TabIndex = 11;
            TextBoxServiceName.Text = "Service1";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(5, 71);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 18;
            lblError.Visible = false;
            // 
            // ServiceUpdateServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 96);
            Controls.Add(lblError);
            Controls.Add(btnSendServiceUpdateMessage);
            Controls.Add(LabelServiceUpdateMessage);
            Controls.Add(LabelSetupFilePath);
            Controls.Add(LabelServiceName);
            Controls.Add(TextBoxSetupFilePath);
            Controls.Add(TextBoxServiceName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "ServiceUpdateServer";
            Text = "Service Update Server";
            Load += ServiceUpdateServer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSendServiceUpdateMessage;
        private Label LabelServiceUpdateMessage;
        private Label LabelSetupFilePath;
        private Label LabelServiceName;
        private TextBox TextBoxSetupFilePath;
        private TextBox TextBoxServiceName;
        private Label lblError;
    }
}
