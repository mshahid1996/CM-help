using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C.M_HelpLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                  .ConfigureAppConfiguration((context, config) =>
                  {
                      var settings = config.Build();

                      if (!context.HostingEnvironment.IsDevelopment())
                      {

                          var keyVaultEndpoint = "https://cmkey.vault.azure.net/"; //settings["VaultURI"];

                          if (!string.IsNullOrEmpty(keyVaultEndpoint))
                          {
                              var azureServiceTokenProvider = new AzureServiceTokenProvider();
                              var keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback));
                              config.AddAzureKeyVault(keyVaultEndpoint, keyVaultClient, new DefaultKeyVaultSecretManager());
                          }
                      }

                  })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}