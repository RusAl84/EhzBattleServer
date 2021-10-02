using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Login
{
  [Serializable]
  public class LoginMasClass
  {
    public string LoginsFileName;
    public List<LoginClass> ListOfLogins = new List<LoginClass>();
    public LoginMasClass(string _loginsFileName)
    {
      LoginsFileName = _loginsFileName;
    }
    public void AddUser(LoginClass lg)
    {
      bool existUser = false;
      foreach (LoginClass item in ListOfLogins)
      {
        if (item.login == lg.login)
          existUser = true;
      }
      if (!existUser)
        ListOfLogins.Add(lg);
      else
        Console.WriteLine($"Error login: {lg.login} already exists");
    }
    public string CheckLoginPassword(LoginClass lg)
    {
      //ListOfLogins.Find((LoginClass item) => item.login == lg.login)
      for (int i=0;i < ListOfLogins.Count();i++)
      {
        if (lg.login == ListOfLogins[i].login)
        {
          if (lg.password == ListOfLogins[i].password)
          {
            ListOfLogins[i].token = lg.GenToken();
            ListOfLogins[i].timeStamp = DateTime.Now.ToString();
            return ListOfLogins[i].token;
          }
        }
      }
      return "";
    }
    public void RegUser(string _login, string _password)
    {
      LoginClass lg = new LoginClass()
      {
        login = _login,
        password = LoginClass.GetSHA256(_password),
        token = ""
      };
      AddUser(lg);
      SaveLogins();
    }
    public void LoadLogins()
    {
      if (File.Exists(LoginsFileName))
      {
        string restoredJsonString = File.ReadAllText(LoginsFileName);
        this.ListOfLogins = JsonConvert.DeserializeObject<List<LoginClass>>(restoredJsonString);
      }
    }
    public void SaveLogins()
    {
      string jsonString = JsonConvert.SerializeObject(ListOfLogins,Formatting.Indented);
      File.WriteAllText(LoginsFileName, jsonString);
    }
    public override string ToString()
    {
      string str1 = "";
      foreach (LoginClass item in ListOfLogins)
        str1 += "\n" + item;
      return str1;
    }
  }
}
