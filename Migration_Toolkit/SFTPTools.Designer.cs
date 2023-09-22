namespace Migration_Toolkit
{
    partial class SFTPTools
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
            username = new Label();
            SFTPUrl = new Label();
            password = new Label();
            folderPath = new Label();
            URLBox = new TextBox();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            folderBox = new TextBox();
            logTextbox = new RichTextBox();
            label1 = new Label();
            logPathBox = new TextBox();
            BrowseFolder = new Button();
            scanButton = new Button();
            statusLabel = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            summarizeCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(12, 54);
            username.Name = "username";
            username.Size = new Size(81, 21);
            username.TabIndex = 0;
            username.Text = "Username";
            // 
            // SFTPUrl
            // 
            SFTPUrl.AutoSize = true;
            SFTPUrl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SFTPUrl.Location = new Point(16, 24);
            SFTPUrl.Name = "SFTPUrl";
            SFTPUrl.Size = new Size(77, 21);
            SFTPUrl.TabIndex = 1;
            SFTPUrl.Text = "SFTP URL";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(15, 85);
            password.Name = "password";
            password.Size = new Size(76, 21);
            password.TabIndex = 2;
            password.Text = "Password";
            // 
            // folderPath
            // 
            folderPath.AutoSize = true;
            folderPath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            folderPath.Location = new Point(5, 115);
            folderPath.Name = "folderPath";
            folderPath.Size = new Size(88, 21);
            folderPath.TabIndex = 3;
            folderPath.Text = "Folder Path";
            // 
            // URLBox
            // 
            URLBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            URLBox.Location = new Point(99, 21);
            URLBox.Name = "URLBox";
            URLBox.Size = new Size(431, 29);
            URLBox.TabIndex = 4;
            URLBox.Text = "sftp.ca.euw01.archivecloud.net";
            // 
            // usernameBox
            // 
            usernameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameBox.Location = new Point(99, 51);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(431, 29);
            usernameBox.TabIndex = 5;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordBox.Location = new Point(99, 82);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(431, 29);
            passwordBox.TabIndex = 6;
            // 
            // folderBox
            // 
            folderBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            folderBox.Location = new Point(99, 113);
            folderBox.Name = "folderBox";
            folderBox.Size = new Size(431, 29);
            folderBox.TabIndex = 7;
            folderBox.Text = "/000000-000000/";
            // 
            // logTextbox
            // 
            logTextbox.Location = new Point(12, 212);
            logTextbox.Name = "logTextbox";
            logTextbox.Size = new Size(776, 226);
            logTextbox.TabIndex = 8;
            logTextbox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 147);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 9;
            label1.Text = "Log Output";
            // 
            // logPathBox
            // 
            logPathBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logPathBox.Location = new Point(99, 144);
            logPathBox.Name = "logPathBox";
            logPathBox.Size = new Size(332, 29);
            logPathBox.TabIndex = 10;
            logPathBox.Text = "C:\\Temp";
            // 
            // BrowseFolder
            // 
            BrowseFolder.Location = new Point(437, 144);
            BrowseFolder.Name = "BrowseFolder";
            BrowseFolder.Size = new Size(93, 29);
            BrowseFolder.TabIndex = 11;
            BrowseFolder.Text = "Browse";
            BrowseFolder.UseVisualStyleBackColor = true;
            BrowseFolder.Click += BrowseFolder_Click;
            // 
            // scanButton
            // 
            scanButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            scanButton.Location = new Point(577, 54);
            scanButton.Name = "scanButton";
            scanButton.Size = new Size(193, 69);
            scanButton.TabIndex = 12;
            scanButton.Text = "Scan";
            scanButton.UseVisualStyleBackColor = true;
            scanButton.Click += scanButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.ForeColor = Color.Orange;
            statusLabel.Location = new Point(581, 129);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 21);
            statusLabel.TabIndex = 13;
            // 
            // summarizeCheckBox
            // 
            summarizeCheckBox.AutoSize = true;
            summarizeCheckBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            summarizeCheckBox.Location = new Point(12, 179);
            summarizeCheckBox.Name = "summarizeCheckBox";
            summarizeCheckBox.Size = new Size(221, 24);
            summarizeCheckBox.TabIndex = 14;
            summarizeCheckBox.Text = "Summarize Top Level Folders";
            summarizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SFTPTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(summarizeCheckBox);
            Controls.Add(statusLabel);
            Controls.Add(scanButton);
            Controls.Add(BrowseFolder);
            Controls.Add(logPathBox);
            Controls.Add(label1);
            Controls.Add(logTextbox);
            Controls.Add(folderBox);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(URLBox);
            Controls.Add(folderPath);
            Controls.Add(password);
            Controls.Add(SFTPUrl);
            Controls.Add(username);
            Name = "SFTPTools";
            Text = "SFTP Tools";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label SFTPUrl;
        private Label password;
        private Label folderPath;
        private TextBox URLBox;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private TextBox folderBox;
        private RichTextBox logTextbox;
        private Label label1;
        private TextBox logPathBox;
        private Button BrowseFolder;
        private Button scanButton;
        private Label statusLabel;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox summarizeCheckBox;
    }
}