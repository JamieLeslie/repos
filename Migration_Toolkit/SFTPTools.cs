using Renci.SshNet.Sftp;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;

namespace Migration_Toolkit
{
    public partial class SFTPTools : Form
    {
        public StreamWriter fileSummary;
        public long fileSize = 0;
        public int fileCount = 0;

        public SFTPTools()
        {
            InitializeComponent();
        }

        private void BrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                logPathBox.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text != "" && passwordBox.Text != "" && folderBox.Text != "" && logPathBox.Text != "")
            {
                scanSFTP(usernameBox.Text, passwordBox.Text, URLBox.Text, folderBox.Text, logPathBox.Text);
            }
            else
            {
                MessageBox.Show("Please populate all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void scanSFTP(String username, String password, String URL, String folder, String output)
        {
            statusLabel.ResetText();
            statusLabel.Text = "Scanning";
            logTextbox.Clear();
            fileSize = 0;
            fileCount = 0;
            using (SftpClient client = new SftpClient(URL, username, password))
            {
                try
                {
                    ((BaseClient)client).Connect();
                    logTextbox.AppendText("Connected to SFTP");
                    fileSummary = new StreamWriter(output + "/output_summary.csv", true);
                    if (summarizeCheckBox.Checked)
                    {
                        ListDirectorySummary(client, folder);
                    }
                    else
                    {
                        ListDirectory(client, folder);
                    }
                    fileSummary.Close();
                    ((BaseClient)client).Disconnect();
                }
                catch (Exception ex)
                {
                    statusLabel.ResetText();
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Failed";
                    logTextbox.AppendText("An exception has been caught: " + ex.ToString());
                    if (fileSummary != null)
                    {
                        fileSummary.Close();
                    }
                }
            }
            if (statusLabel.Text != "Failed")
            {
                statusLabel.ResetText();
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Complete";
            }
        }

        private void ListDirectorySummary(SftpClient client, string dirName)
        {

        }

        private void ListDirectory(SftpClient client, string dirName)
        {
            logTextbox.Clear();
//test
            logTextbox.AppendText("Scanning " + dirName.ToString());
            string str = "output_NoName.csv";
            if (dirName == "/")
                str = "output_NoName.csv";
            else if (dirName.Contains("/"))
                str = "output_" + dirName.Substring(dirName.LastIndexOf("/") + 1, dirName.Length - (dirName.LastIndexOf("/") + 1)) + ".csv";
            if (dirName.Contains("/."))
                str = "output_NoName.csv";
            try
            {
                IEnumerable<SftpFile> source = client.ListDirectory(dirName, (Action<int>)null);
                logTextbox.AppendText(source.Count<SftpFile>().ToString() + " files/folders");
                fileCount = 0;
                fileSize = 0L;
                foreach (SftpFile sftpFile in source)
                {
                    if (sftpFile.Name != "." && sftpFile.Name != "..")
                    {
                        if (sftpFile.IsDirectory)
                        {
                            ListDirectory(client, sftpFile.FullName);
                        }
                        else
                        {
                            ++fileCount;
                            fileSize += (long)(int)sftpFile.Length;
                        }
                    }
                }
                fileSummary.WriteLine(dirName.ToString() + "*" + fileCount.ToString() + "*" + fileSize.ToString());
                statusLabel.Text = "Scanned";
            }
            catch (Exception e)
            {
                logTextbox.AppendText("An exception has been caught: " + e.ToString());
            }
        }
    }
}