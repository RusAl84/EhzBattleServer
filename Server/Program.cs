using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Login;

namespace EhzBattleServer
{
  public class Program
  {
    public static string LoginsFileName = "users.json";
    public static LoginMasClass storedLogins = new Login.LoginMasClass(LoginsFileName);
    public static s

    public static void Main(string[] args)
    {
      storedLogins.LoadLogins();
      //storedLogins.RegUser("kulvich", "1234");
      //storedLogins.RegUser("rusal", "1234");
      //Console.WriteLine(storedLogins);
      CreateHostBuilder(args).Build().Run();
      storedLogins.SaveLogins();
    } 

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
