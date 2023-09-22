using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Exchange.WebServices.Auth.Validation;
using Microsoft.Identity.Client;
using System.Configuration;
using Microsoft.Identity.Client.NativeInterop;
using Renci.SshNet;

namespace Migration_Toolkit
{
    public partial class ShortcutTools : Form
    {
        List<String> inputList = new List<String>();
        public ShortcutTools()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonList_CheckedChanged(object sender, EventArgs e)
        {
            userBox.Enabled = false;
            inputListBox.Enabled = true;
            browseButton.Enabled = true;
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            userBox.Enabled = true;
            inputListBox.Enabled = false;
            browseButton.Enabled = false;
        }

        private void browseButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputLocationBox.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List of SMTP addresses, no header, CSV format");
            OpenFileDialog fileDlg = new OpenFileDialog();
            DialogResult result = fileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                inputListBox.Text = fileDlg.FileName;
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            //START SCAN
            outputLogBox.Clear();
            if (usernameBox.Text != "" && passwordBox.Text != "" && outputLocationBox.Text != "" && (inputListBox.Text != "" || userBox.Text != ""))
            {
                outputLogBox.AppendText("Getting Users...\r");
                statusLabel.ResetText();
                statusLabel.ForeColor = Color.Orange;
                statusLabel.Text = "Running...";
                if (radioButtonList.Checked)
                {
                    using (StreamReader streamReader = new StreamReader(inputListBox.Text))
                    {
                        string id;
                        while ((id = streamReader.ReadLine()) != null)
                        {
                            inputList.Add(id.ToString());
                        }
                    }
                }
                else
                {
                    inputList.Add(userBox.Text);
                }
                scanShortcuts(usernameBox.Text, passwordBox.Text, outputLocationBox.Text, scanLocationBox.Text, exchangeVersionBox.Text, delimiterBox.Text, Convert.ToInt32(pageSizeBox.Text), Convert.ToInt32(EWSRetriesBox.Text), EWSBox.Text, messageClassBox.Text, Convert.ToBoolean(itemDetailsBox.SelectedValue), Convert.ToBoolean(revertPendingBox.SelectedValue));
            }
            else
            {
                statusLabel.ResetText();
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Failed";
                MessageBox.Show("Please populate all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

                private void scanShortcuts(String username, String password, String logLocation, String scanLocation, String exchangeVersion, String delimiter, int pageSize, int EWSRetries, String EWSURL, String messageClass, bool itemDetails, bool revertPendingItems)
        {
            ExchangeVersion requestedServerVersion = ExchangeVersion.Exchange2013;
            if (exchangeVersion == "2010")
            {
                requestedServerVersion = ExchangeVersion.Exchange2010;
            }



            //
            var pcaOptions = new PublicClientApplicationOptions
            {
                ClientId = ConfigurationManager.AppSettings["0a8c0a77-27e0-4f32-8011-5b9e5d7e0492"],
                TenantId = ConfigurationManager.AppSettings["6f588c01-2000-4a32-8bd7-7141c5b9d896"],
            };
            var pca = PublicClientApplicationBuilder.CreateWithApplicationOptions(pcaOptions).Build();
            var ewsScopes = new string[] {"https://outlook.office365.com/EWS.AccessAsUser.All" };

            // Make the interactive token request

            //var authResult = await cca.AcquireTokenForClient(ewsScopes).ExecuteAsync();

            ExchangeService exchangeService = new ExchangeService(requestedServerVersion);
//            exchangeService.Credentials = (ExchangeCredentials)new WebCredentials(username, password);
            //exchangeService.Credentials = new OAuthCredentials(authResult.AccessToken);
            ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)((sender, certificate, chain, sslPolicyErrors) => true);
            exchangeService.Url = new Uri(EWSURL);
            exchangeService.UseDefaultCredentials = false;

            foreach (String id in inputList)
            {
                try
                {
                    using (new StreamWriter(logLocation + "\\" + id + "_SimpleLog.txt"))
                        ;
                    using (new StreamWriter(logLocation + "\\" + id + "_ExtendedLog.txt"))
                        ;
                    using (new StreamWriter(logLocation + "\\" + id + "_Output.csv"))
                        ;
                    exchangeService.ImpersonatedUserId = new ImpersonatedUserId(ConnectingIdType.SmtpAddress, id);
                    outputLogBox.AppendText("Connecting to mailbox: "+id.ToString()+"\r");
                    int num2 = 0;
                    int num3 = 0;
                    int num4 = 0;
                    ItemView itemView = new ItemView(pageSize, 0, OffsetBasePoint.Beginning);
                    bool flag1 = true;
                    FolderView view1 = new FolderView(pageSize, 0, OffsetBasePoint.Beginning);
                    view1.Traversal = FolderTraversal.Deep;
                    while (flag1)
                    {
                        WellKnownFolderName parentFolderName = WellKnownFolderName.MsgFolderRoot;
                        if (scanLocation == "Archive")
                            parentFolderName = WellKnownFolderName.ArchiveMsgFolderRoot;
                        FindFoldersResults folders = exchangeService.FindFolders(parentFolderName, view1);
                        foreach (Folder folder in folders.Folders)
                        {
                            int num5 = 0;
                            int num6 = 0;
                            int num7 = 0;
                            outputLogBox.AppendText("Folder: " + folder.DisplayName.ToString()+"\r");
                            bool flag2 = true;
                            ItemView view2 = new ItemView(pageSize, 0, OffsetBasePoint.Beginning);
                            while (flag2)
                            {
                                if (num5 <= EWSRetries)
                                {
                                    try
                                    {
                                        FindItemsResults<Item> items = exchangeService.FindItems(folder.Id, (ViewBase)view2);
                                        foreach (Item obj in items.Items)
                                        {
                                            ++num3;
                                            ++num6;
                                            if (obj.ItemClass.Contains(messageClass))
                                            {
                                                ++num2;
                                                ++num7;
                                                if (itemDetails == true)
                                                {
                                                    using (StreamWriter streamWriter = System.IO.File.AppendText(logLocation + "\\" + id + "_ItemDetails.txt"))
                                                        streamWriter.WriteLine(obj.ItemClass.ToString());
                                                }
                                            }
                                            if (revertPendingItems == true && obj.ItemClass == "IPM.Note.EnterpriseVault.PendingArchive")
                                            {
                                                obj.ItemClass = "IPM.Note";
                                                obj.Update(ConflictResolutionMode.AlwaysOverwrite);
                                                using (StreamWriter streamWriter = System.IO.File.AppendText(logLocation + "\\" + id + "_SimpleLog.txt"))
                                                    streamWriter.WriteLine("Reverting Pending Item: " + (object)obj.Id);
                                            }
                                        }
                                        flag2 = items.MoreAvailable;
                                        if (flag2)
                                            view2.Offset += pageSize;
                                    }
                                    catch (Exception ex)
                                    {
                                        outputLogBox.AppendText(((object)ex).ToString()+"\r");
                                        using (StreamWriter streamWriter = System.IO.File.AppendText(logLocation + "\\" + id + "_SimpleLog.txt"))
                                            streamWriter.WriteLine("Folder: " + folder.DisplayName + " failed. Retrying...");
                                        using (StreamWriter streamWriter = System.IO.File.AppendText(logLocation + "\\" + id + "_ExtendedLog.txt"))
                                        {
                                            streamWriter.WriteLine(folder.DisplayName);
                                            streamWriter.WriteLine((object)ex);
                                        }
                                        if (num5 == EWSRetries)
                                        {
                                            outputLogBox.AppendText("Throttling detected... backing off for 5 mins...\r");
                                            Thread.Sleep(300000);
                                        }
                                        else
                                            Thread.Sleep(30000);
                                        ++num5;
                                    }
                                }
                                else
                                {
                                    num4 = 0;
                                    break;
                                }
                            }
                            using (StreamWriter streamWriter = System.IO.File.AppendText(logLocation + "\\" + id + "_SimpleLog.txt"))
                                streamWriter.WriteLine("Folder: " + folder.DisplayName + " complete.");
                            using (StreamWriter streamWriter = System.IO.File.AppendText(logLocation + "\\" + id + "_Output.csv"))
                                streamWriter.WriteLine(folder.DisplayName + delimiter + (object)num6 + delimiter + (object)num7);
                            outputLogBox.AppendText("Messages scanned: " + (object)num6 + "\r");
                            outputLogBox.AppendText("Shortcuts: " + (object)num7 + "\r");
                        }
                        flag1 = folders.MoreAvailable;
                        if (flag1)
                            view1.Offset += pageSize;
                    }
                    outputLogBox.AppendText("Total Messages scanned: " + (object)num3 + "\r");
                    outputLogBox.AppendText("Total Shortcuts: " + (object)num2 + "\r");
                    using (StreamWriter streamWriter = System.IO.File.AppendText(logLocation + "\\MasterOutput.csv"))
                        streamWriter.WriteLine(id + delimiter + (object)num3 + delimiter + (object)num2);
                }
                catch (Exception ex)
                {
                    statusLabel.ResetText();
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Failed";
                    outputLogBox.AppendText(((object)ex).ToString() + "\r");
                }
            }
            if (statusLabel.Text != "Failed")
            {
                statusLabel.ResetText();
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Complete";
            }
            outputLogBox.AppendText("Script Complete: " + DateTime.Now.ToString() + "\r");
        }
    }
}
