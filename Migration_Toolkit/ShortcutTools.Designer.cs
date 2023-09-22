namespace Migration_Toolkit
{
    partial class ShortcutTools
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
            radioButtonUser = new RadioButton();
            radioButtonList = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userBox = new TextBox();
            inputListBox = new TextBox();
            browseButton = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            EWSBox = new TextBox();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            pageSizeBox = new TextBox();
            messageClassBox = new TextBox();
            outputLocationBox = new TextBox();
            delimiterBox = new TextBox();
            revertPendingBox = new ComboBox();
            exchangeVersionBox = new ComboBox();
            scanLocationBox = new ComboBox();
            EWSRetriesBox = new ComboBox();
            itemDetailsBox = new ComboBox();
            browseButton2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            runButton = new Button();
            statusLabel = new Label();
            outputLogBox = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // radioButtonUser
            // 
            radioButtonUser.AutoSize = true;
            radioButtonUser.Checked = true;
            radioButtonUser.Location = new Point(15, 419);
            radioButtonUser.Name = "radioButtonUser";
            radioButtonUser.Size = new Size(14, 13);
            radioButtonUser.TabIndex = 0;
            radioButtonUser.TabStop = true;
            radioButtonUser.UseVisualStyleBackColor = true;
            radioButtonUser.CheckedChanged += radioButtonUser_CheckedChanged;
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(15, 450);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(14, 13);
            radioButtonList.TabIndex = 1;
            radioButtonList.UseVisualStyleBackColor = true;
            radioButtonList.CheckedChanged += radioButtonList_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 417);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 448);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 3;
            label2.Text = "List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 382);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 4;
            label3.Text = "Input Type";
            // 
            // userBox
            // 
            userBox.Location = new Point(71, 414);
            userBox.Name = "userBox";
            userBox.Size = new Size(356, 23);
            userBox.TabIndex = 5;
            // 
            // inputListBox
            // 
            inputListBox.Enabled = false;
            inputListBox.Location = new Point(71, 443);
            inputListBox.Name = "inputListBox";
            inputListBox.Size = new Size(288, 23);
            inputListBox.TabIndex = 6;
            // 
            // browseButton
            // 
            browseButton.Enabled = false;
            browseButton.Location = new Point(365, 442);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(62, 23);
            browseButton.TabIndex = 7;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 34);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 9);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 9;
            label5.Text = "EWS URL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 63);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 92);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 11;
            label7.Text = "Scan Location";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 124);
            label8.Name = "label8";
            label8.Size = new Size(99, 15);
            label8.TabIndex = 12;
            label8.Text = "Exchange Version";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 153);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 13;
            label9.Text = "Page Size";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 184);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 14;
            label10.Text = "EWS Retries";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 216);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 15;
            label11.Text = "Message Class";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 249);
            label12.Name = "label12";
            label12.Size = new Size(119, 15);
            label12.TabIndex = 16;
            label12.Text = "Revert Pending Items";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 279);
            label13.Name = "label13";
            label13.Size = new Size(94, 15);
            label13.TabIndex = 17;
            label13.Text = "Output Location";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 311);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 18;
            label14.Text = "Item Details";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 341);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 19;
            label15.Text = "Delimiter";
            // 
            // EWSBox
            // 
            EWSBox.Location = new Point(136, 6);
            EWSBox.Name = "EWSBox";
            EWSBox.Size = new Size(291, 23);
            EWSBox.TabIndex = 20;
            EWSBox.Text = "https://outlook.office365.com/EWS/Exchange.asmx";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(136, 31);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(291, 23);
            usernameBox.TabIndex = 21;
            usernameBox.TextChanged += textBox4_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(136, 60);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(291, 23);
            passwordBox.TabIndex = 22;
            // 
            // pageSizeBox
            // 
            pageSizeBox.Location = new Point(136, 150);
            pageSizeBox.Name = "pageSizeBox";
            pageSizeBox.Size = new Size(48, 23);
            pageSizeBox.TabIndex = 23;
            pageSizeBox.Text = "1000";
            // 
            // messageClassBox
            // 
            messageClassBox.Location = new Point(136, 213);
            messageClassBox.Name = "messageClassBox";
            messageClassBox.Size = new Size(291, 23);
            messageClassBox.TabIndex = 24;
            messageClassBox.Text = "IPM.Note.EnterpriseVault.Shortcut";
            // 
            // outputLocationBox
            // 
            outputLocationBox.Location = new Point(136, 275);
            outputLocationBox.Name = "outputLocationBox";
            outputLocationBox.Size = new Size(223, 23);
            outputLocationBox.TabIndex = 25;
            // 
            // delimiterBox
            // 
            delimiterBox.Location = new Point(136, 337);
            delimiterBox.Name = "delimiterBox";
            delimiterBox.Size = new Size(19, 23);
            delimiterBox.TabIndex = 26;
            delimiterBox.Text = "*";
            // 
            // revertPendingBox
            // 
            revertPendingBox.FormattingEnabled = true;
            revertPendingBox.Items.AddRange(new object[] { "No", "Yes" });
            revertPendingBox.Location = new Point(136, 246);
            revertPendingBox.Name = "revertPendingBox";
            revertPendingBox.Size = new Size(48, 23);
            revertPendingBox.TabIndex = 27;
            revertPendingBox.Text = "No";
            // 
            // exchangeVersionBox
            // 
            exchangeVersionBox.FormattingEnabled = true;
            exchangeVersionBox.Items.AddRange(new object[] { "2013", "2010" });
            exchangeVersionBox.Location = new Point(136, 121);
            exchangeVersionBox.Name = "exchangeVersionBox";
            exchangeVersionBox.Size = new Size(71, 23);
            exchangeVersionBox.TabIndex = 28;
            exchangeVersionBox.Text = "2013";
            // 
            // scanLocationBox
            // 
            scanLocationBox.FormattingEnabled = true;
            scanLocationBox.Items.AddRange(new object[] { "Mailbox", "Archive" });
            scanLocationBox.Location = new Point(136, 89);
            scanLocationBox.Name = "scanLocationBox";
            scanLocationBox.Size = new Size(71, 23);
            scanLocationBox.TabIndex = 29;
            scanLocationBox.Text = "Mailbox";
            // 
            // EWSRetriesBox
            // 
            EWSRetriesBox.FormattingEnabled = true;
            EWSRetriesBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            EWSRetriesBox.Location = new Point(136, 181);
            EWSRetriesBox.Name = "EWSRetriesBox";
            EWSRetriesBox.Size = new Size(48, 23);
            EWSRetriesBox.TabIndex = 30;
            EWSRetriesBox.Text = "3";
            // 
            // itemDetailsBox
            // 
            itemDetailsBox.FormattingEnabled = true;
            itemDetailsBox.Items.AddRange(new object[] { "No", "Yes" });
            itemDetailsBox.Location = new Point(136, 307);
            itemDetailsBox.Name = "itemDetailsBox";
            itemDetailsBox.Size = new Size(48, 23);
            itemDetailsBox.TabIndex = 31;
            itemDetailsBox.Text = "No";
            // 
            // browseButton2
            // 
            browseButton2.Location = new Point(365, 274);
            browseButton2.Name = "browseButton2";
            browseButton2.Size = new Size(62, 23);
            browseButton2.TabIndex = 32;
            browseButton2.Text = "Browse";
            browseButton2.UseVisualStyleBackColor = true;
            browseButton2.Click += browseButton2_Click;
            // 
            // runButton
            // 
            runButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            runButton.Location = new Point(10, 491);
            runButton.Name = "runButton";
            runButton.Size = new Size(120, 35);
            runButton.TabIndex = 33;
            runButton.Text = "Start Scan";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusLabel.ForeColor = Color.Orange;
            statusLabel.Location = new Point(146, 499);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 21);
            statusLabel.TabIndex = 34;
            // 
            // outputLogBox
            // 
            outputLogBox.Location = new Point(480, 12);
            outputLogBox.Name = "outputLogBox";
            outputLogBox.Size = new Size(459, 514);
            outputLogBox.TabIndex = 35;
            outputLogBox.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ShortcutTools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 538);
            Controls.Add(outputLogBox);
            Controls.Add(statusLabel);
            Controls.Add(runButton);
            Controls.Add(browseButton2);
            Controls.Add(itemDetailsBox);
            Controls.Add(EWSRetriesBox);
            Controls.Add(scanLocationBox);
            Controls.Add(exchangeVersionBox);
            Controls.Add(revertPendingBox);
            Controls.Add(delimiterBox);
            Controls.Add(outputLocationBox);
            Controls.Add(messageClassBox);
            Controls.Add(pageSizeBox);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Controls.Add(EWSBox);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(browseButton);
            Controls.Add(inputListBox);
            Controls.Add(userBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButtonList);
            Controls.Add(radioButtonUser);
            Name = "ShortcutTools";
            Text = "Shortcut Tools";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonUser;
        private RadioButton radioButtonList;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userBox;
        private TextBox inputListBox;
        private Button browseButton;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox EWSBox;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private TextBox pageSizeBox;
        private TextBox messageClassBox;
        private TextBox outputLocationBox;
        private TextBox delimiterBox;
        private ComboBox revertPendingBox;
        private ComboBox exchangeVersionBox;
        private ComboBox scanLocationBox;
        private ComboBox EWSRetriesBox;
        private ComboBox itemDetailsBox;
        private Button browseButton2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button runButton;
        private Label statusLabel;
        private RichTextBox outputLogBox;
        private OpenFileDialog openFileDialog1;
    }
}