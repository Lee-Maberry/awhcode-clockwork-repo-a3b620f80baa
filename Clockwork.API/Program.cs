using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Clockwork.API.Migrations;

namespace Clockwork.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();

            Clockwork.API.Migrations.InitialCreate initialCreate = new Clockwork.API.Migrations.InitialCreate();
            
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
