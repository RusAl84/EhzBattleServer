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

namespace EhzBattleServer
{
  public class Program
  {
    public static string PasswordsFileName = "passwords_JSON.txt";
    public static LoginMasClass storedLogins = new LoginMasClass();
    public static void RegUser(string _login, string _password)
    {
      LoginClass lg = new LoginClass() { login = _login, password = _password, token = "" };
      string restoredJsonString = "";
      using (StreamReader sr = new StreamReader(PasswordsFileName))
      {
        restoredJsonString = sr.ReadToEnd();
      }
      storedLogins = JsonConvert.DeserializeObject<LoginMasClass>(restoredJsonString);
      storedLogins.Add(lg);
      string jsonString = JsonConvert.SerializeObject(storedLogins);
      //Console.WriteLine(jsonString);
      try
      {
        using (StreamWriter sw = new StreamWriter(PasswordsFileName, false, System.Text.Encoding.Default))
        {
          sw.WriteLine(jsonString);
        }
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
    public static void Main(string[] args)
    {

      //RegUser("Anya", "1234");





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
