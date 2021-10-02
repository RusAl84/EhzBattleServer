using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Login { 
  [Serializable]
  public  class LoginClass
  {
    public LoginClass(string _login, string _password)
    {
      this.login = _login;
      this.password = _password;
    }
    public LoginClass()
    {
    }
    public string login { get; set; }
    public string password { get; set; }
    public string token { get; set; }
    public static string GetMD5(string input)
    {
      // Use input string to calculate MD5 hash
      using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
      {
        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
        byte[] hashBytes = md5.ComputeHash(inputBytes);

        // Convert the byte array to hexadecimal string
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hashBytes.Length; i++)
        {
          sb.Append(hashBytes[i].ToString("X2"));
        }
        return sb.ToString();
      }
    }
    public static string GetSHA256(string input)
    {
      // Create a SHA256   
      using (SHA256 sha256Hash = SHA256.Create())
      {
        // ComputeHash - returns byte array  
        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

        // Convert byte array to a string   
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < bytes.Length; i++)
        {
          builder.Append(bytes[i].ToString("x2"));
        }
        return builder.ToString();
      }

    }
    public string GenToken()
    {
      byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
      byte[] key = Guid.NewGuid().ToByteArray();
      return  Convert.ToBase64String(time.Concat(key).ToArray());
    }

    public override string ToString()
    {
      return String.Format($"login:{login} password:{password} token:{token}");
    }
  }
  [Serializable]
  public  class LoginMasClass
  {
    public List<LoginClass> ListOfLogins = new List<LoginClass>();
    public void Add(LoginClass lg)
    {
      ListOfLogins.Add(lg);
    }
    public string CheckLoginPassword(LoginClass lg)
    {
      foreach(LoginClass item in ListOfLogins)
      {
        if (lg.login == item.login)
        {
          if (LoginClass.GetSHA256(lg.password) == item.password)
          {
            return lg.GenToken();
          }
        }
      }
      return "";
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
