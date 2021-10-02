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
    public static string PasswordsFileName = "passwords_JSON.txt";
    public static LoginMasClass storedLogins = new Login.LoginMasClass();

    public static void RegUser(string _login, string _password)
    {
      LoginClass lg = new LoginClass() { login = _login, 
        password = LoginClass.GetSHA256(_password), 
        token = "" };
      storedLogins.Add(lg);
      SaveLogins();
     }
    public static void LoadLogins()
    {
      string restoredJsonString = File.ReadAllText(PasswordsFileName);
      storedLogins = JsonConvert.DeserializeObject<LoginMasClass>(restoredJsonString);
    }
    public static void SaveLogins()
    {
      string jsonString = JsonConvert.SerializeObject(storedLogins);
      File.WriteAllText(PasswordsFileName, jsonString);
    }
    public static void Main(string[] args)
    {
      LoadLogins();
      RegUser("kulvich1", "1234");
      RegUser("kulvich2", "1234");
      Console.WriteLine(storedLogins);
      



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
