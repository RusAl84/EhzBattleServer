using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using Newtonsoft.Json;

namespace EhzClassLibrary
{ 
  [Serializable]
  public  class LoginClass
  {
    public string login { get; set; }
    public string password { get; set; }
    private string token;
    private DateTime timeStamp;
    private bool round;
    public LoginClass(string _login, string _password)
    {
      this.login = _login;
      this.password = _password;
    }
    public LoginClass()
    {
    }
    public string GenToken()
    {
      string salt = "СОЛЬ ЧТОБЫ НИКТО";
      byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
      byte[] key = Guid.NewGuid().ToByteArray();
      token = Convert.ToBase64String(time.Concat(key).ToArray());
      return  token;
    }
    public string GetToken()
    {
      return this.token;
    }
    public DateTime setTimeStamp() { 
      timeStamp = DateTime.Now;
      return timeStamp;
    }
    public override string ToString()
    {
      return String.Format($"login:{login} password:{password} token:{token} timeStamp: {timeStamp}");
    }

  }
}
