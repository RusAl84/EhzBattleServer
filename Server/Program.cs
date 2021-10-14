using EhzClassLibrary;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace EhzBattleServer
{
  public class Program
  {
    public static string LoginsFileName = "users.json";
    public static LoginMasClass storedLogins = new LoginMasClass(LoginsFileName);
    public static DateTime freezTime;
    public const int roundInterval = 5;
     


    public static void Main(string[] args)
    {
      storedLogins.LoadLogins();
      storedLogins.RegUser("Sveta", "1234");
      storedLogins.RegUser("rusal", "1234");
      storedLogins.RegUser("Sasha", "1234");
      Console.WriteLine(storedLogins);
      Timer timer = new Timer(TimerCallback, null, 0, 1000 * roundInterval);
      CreateHostBuilder(args).Build().Run();
      storedLogins.SaveLogins();

    }
    private static void TimerCallback(Object o)
    {
      freezTime = DateTime.Now;
      Console.WriteLine("In TimerCallback: " + DateTime.Now);
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}
