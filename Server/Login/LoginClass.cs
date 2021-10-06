using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using Newtonsoft.Json;

namespace Login { 
  [Serializable]
  public  class LoginClass
  {
    public string login { get; set; }
    public string password { get; set; }
    private string token;
    private DateTime timeStamp;
    public LoginClass(string _login, string _password)
    {
      this.login = _login.ToLower();
      this.password = _password;
    }
    public LoginClass()
    {
    }

    public string GenToken()
    {
      byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
      byte[] key = Guid.NewGuid().ToByteArray();
      string token = Convert.ToBase64String(time.Concat(key).ToArray());
      return  token;
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
