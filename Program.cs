using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WichellHelperWeb.Models;

namespace WichellHelperWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<String> testData = new List<string>();

            testData.Add("TEST1");
            testData.Add("USER");

            NameDistributer nameDistributer = new NameDistributer();

            Dictionary<String, String> keyValuePairs = nameDistributer.GetPairsOfUsers(testData);

            Console.WriteLine(keyValuePairs.Count);
            Console.WriteLine(keyValuePairs["USER"]);


            CreateHostBuilder(args).Build().Run();
        }
        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    }
}
