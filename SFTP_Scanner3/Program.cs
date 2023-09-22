// Decompiled with JetBrains decompiler
// Type: SFTP_Scanner2.Program
// Assembly: SFTP_Scanner2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A57D4CDA-4FDD-4186-BDEA-1DC02A133696
// Assembly location: C:\Users\Jamie.leslie\Downloads\SFTP_Scanner2_v21_Summary.exe

using Renci.SshNet;
using Renci.SshNet.Sftp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SFTP_Scanner2
{
    internal class Program
    {
        public static StreamWriter fileSummary = new StreamWriter("output_summary.csv", true);
        public static long fileSize = 0;
        public static int fileCount = 0;

        private static void Main(string[] args)
        {
            Program.fileSummary.AutoFlush = true;
            Console.WriteLine("Enter Hostname:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter Username:");
            string str2 = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string str3 = Console.ReadLine();
            Console.WriteLine("Enter Path:");
            string dirName = Console.ReadLine();
            using (SftpClient client = new SftpClient(str1, str2, str3))
            {
                try
                {
                    ((BaseClient)client).Connect();
                    Console.WriteLine("Connected to SFTP");
                    Program.ListDirectory(client, dirName);
                    Program.fileSummary.Close();
                    ((BaseClient)client).Disconnect();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An exception has been caught " + ex.ToString());
                }
            }
        }

        public static void ListDirectory(SftpClient client, string dirName)
        {
            Console.WriteLine("Scanning " + dirName.ToString());
            string str = "output_NoName.csv";
            if (dirName == "/")
                str = "output_NoName.csv";
            else if (dirName.Contains("/"))
                str = "output_" + dirName.Substring(dirName.LastIndexOf("/") + 1, dirName.Length - (dirName.LastIndexOf("/") + 1)) + ".csv";
            if (dirName.Contains("/."))
                str = "output_NoName.csv";
            IEnumerable<SftpFile> source = client.ListDirectory(dirName, (Action<int>)null);
            Console.WriteLine(source.Count<SftpFile>().ToString() + " files/folders");
            Program.fileCount = 0;
            Program.fileSize = 0L;
            foreach (SftpFile sftpFile in source)
            {
                if (sftpFile.Name != "." && sftpFile.Name != "..")
                {
                    if (sftpFile.IsDirectory)
                    {
                        Program.ListDirectory(client, sftpFile.FullName);
                    }
                    else
                    {
                        ++Program.fileCount;
                        Program.fileSize += (long)(int)sftpFile.Length;
                    }
                }
            }
            Program.fileSummary.WriteLine(dirName.ToString() + "*" + Program.fileCount.ToString() + "*" + Program.fileSize.ToString());
        }
    }
}
