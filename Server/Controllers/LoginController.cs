﻿using EhzClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


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
      string token = Program.storedLogins.CheckLoginPassword(reciveData);
      Console.WriteLine(Program.storedLogins);
      return token;
    }
  }
}
