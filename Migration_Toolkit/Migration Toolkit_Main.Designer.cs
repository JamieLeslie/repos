namespace Migration_Toolkit
{
    partial class Migration_Toolkit_Main
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
            shortcutTools = new Button();
            sftpTools = new Button();
            SuspendLayout();
            // 
            // shortcutTools
            // 
            shortcutTools.Location = new Point(12, 12);
            shortcutTools.Name = "shortcutTools";
            shortcutTools.Size = new Size(429, 29);
            shortcutTools.TabIndex = 0;
            shortcutTools.Text = "Shortcut Tools";
            shortcutTools.UseVisualStyleBackColor = true;
            shortcutTools.Click += shortcutTools_Click;
            // 
            // sftpTools
            // 
            sftpTools.Location = new Point(12, 47);
            sftpTools.Name = "sftpTools";
            sftpTools.Size = new Size(429, 29);
            sftpTools.TabIndex = 1;
            sftpTools.Text = "SFTP Tools";
            sftpTools.UseVisualStyleBackColor = true;
            sftpTools.Click += sftpTools_Click_1;
            // 
            // Migration_Toolkit_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 259);
            Controls.Add(sftpTools);
            Controls.Add(shortcutTools);
            Name = "Migration_Toolkit_Main";
            Text = "Migration Toolkit";
            ResumeLayout(false);
        }

        #endregion

        private Button shortcutTools;
        private Button sftpTools;
    }
}