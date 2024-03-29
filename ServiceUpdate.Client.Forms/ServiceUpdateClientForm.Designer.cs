namespace ServiceUpdate.Client.Forms
{
    partial class ServiceUpdateClientForm
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
            txtServiceName = new TextBox();
            txtErrorInfo = new TextBox();
            lblServicename = new Label();
            lblErrorInfo = new Label();
            btnInstall = new Button();
            btnHide = new Button();
            lblUpdateFileLocation = new Label();
            txtUpdateFileLocation = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(127, 6);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(453, 21);
            txtServiceName.TabIndex = 2;
            // 
            // txtErrorInfo
            // 
            txtErrorInfo.Location = new Point(127, 61);
            txtErrorInfo.Name = "txtErrorInfo";
            txtErrorInfo.Size = new Size(210, 21);
            txtErrorInfo.TabIndex = 3;
            txtErrorInfo.Visible = false;
            // 
            // lblServicename
            // 
            lblServicename.AutoSize = true;
            lblServicename.Location = new Point(41, 6);
            lblServicename.Name = "lblServicename";
            lblServicename.Size = new Size(80, 15);
            lblServicename.TabIndex = 4;
            lblServicename.Text = "Service Name";
            // 
            // lblErrorInfo
            // 
            lblErrorInfo.AutoSize = true;
            lblErrorInfo.Location = new Point(62, 64);
            lblErrorInfo.Name = "lblErrorInfo";
            lblErrorInfo.Size = new Size(59, 15);
            lblErrorInfo.TabIndex = 5;
            lblErrorInfo.Text = "Error Info";
            lblErrorInfo.Visible = false;
            // 
            // btnInstall
            // 
            btnInstall.Location = new Point(343, 60);
            btnInstall.Name = "btnInstall";
            btnInstall.Size = new Size(75, 23);
            btnInstall.TabIndex = 6;
            btnInstall.Text = "&Install";
            btnInstall.UseVisualStyleBackColor = true;
            btnInstall.Click += btnInstall_Click;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(424, 60);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(75, 23);
            btnHide.TabIndex = 7;
            btnHide.Text = "&Hide";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // lblUpdateFileLocation
            // 
            lblUpdateFileLocation.AutoSize = true;
            lblUpdateFileLocation.Location = new Point(6, 36);
            lblUpdateFileLocation.Name = "lblUpdateFileLocation";
            lblUpdateFileLocation.Size = new Size(115, 15);
            lblUpdateFileLocation.TabIndex = 9;
            lblUpdateFileLocation.Text = "Update File Location";
            // 
            // txtUpdateFileLocation
            // 
            txtUpdateFileLocation.Location = new Point(127, 33);
            txtUpdateFileLocation.Name = "txtUpdateFileLocation";
            txtUpdateFileLocation.Size = new Size(453, 21);
            txtUpdateFileLocation.TabIndex = 8;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(505, 60);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ServiceUpdateClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(586, 87);
            ControlBox = false;
            Controls.Add(btnExit);
            Controls.Add(lblUpdateFileLocation);
            Controls.Add(txtUpdateFileLocation);
            Controls.Add(btnHide);
            Controls.Add(btnInstall);
            Controls.Add(lblErrorInfo);
            Controls.Add(lblServicename);
            Controls.Add(txtErrorInfo);
            Controls.Add(txtServiceName);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ServiceUpdateClientForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service Update Form";
            Load += ServiceUpdateClientForm_Load;
            Shown += ServiceUpdateClientForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtServiceName;
        private TextBox txtErrorInfo;
        private Label lblServicename;
        private Label lblErrorInfo;
        private Button btnInstall;
        private Button btnHide;
        private Label lblUpdateFileLocation;
        private TextBox txtUpdateFileLocation;
        private Button btnExit;
    }
}
