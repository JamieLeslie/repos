using Microsoft.Exchange.WebServices.Data;
using System;
using System.Configuration;
using System.Net.Security;
using System.Net;
using Microsoft.Identity.Client;
using OAuth2ClientHandler.Authorizer;
using OAuth2ClientHandler;
using System.Net.Http;

namespace EWSTestnet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Connect_OAuth();
        }

        public static void Connect_OAuth()
        {
            var cca = ConfidentialClientApplicationBuilder
                  .Create(ConfigurationManager.AppSettings["appId"])
                  .WithClientSecret(ConfigurationManager.AppSettings["clientSecret"])
                  .WithTenantId(ConfigurationManager.AppSettings["tenantId"])
                  .Build();

            var ewsScopes = new string[] { "https://outlook.office365.com/.default" };

            AuthenticationResult authResult = null;

            try
            {
                authResult = cca.AcquireTokenForClient(ewsScopes).ExecuteAsync().Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            Console.ReadLine();

            try
            {
                var ewsClient = new ExchangeService();

                ewsClient.Url = new Uri("https://outlook.office365.com/EWS/Exchange.asmx");
                ewsClient.Credentials = new OAuthCredentials(authResult.AccessToken);
                ewsClient.ImpersonatedUserId = new ImpersonatedUserId(ConnectingIdType.SmtpAddress, "bluesource@1xvtw0.onmicrosoft.com");

                ewsClient.HttpHeaders.Add("X-AnchorMailbox", "bluesource@1xvtw0.onmicrosoft.com");

                var folders = ewsClient.FindFolders(WellKnownFolderName.Inbox, new FolderView(10));

                foreach (var folder in folders)
                {
                    Console.WriteLine("" + folder.DisplayName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.ReadLine();
        }
    }
}
