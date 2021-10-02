using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EhzBattleServer.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LoginController : ControllerBase
  {
    // POST api/<LoginController>
    [HttpPost]
    public string Post(LoginClass reciveData)
    {
      //{ "login":"rusal","password":"123", "token":""}

      string token = reciveData.GenToken(); /////
      Console.WriteLine(reciveData);
      //return value;
      return token;
    }
  }
}
