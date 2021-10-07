using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EhzBattleServer.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RefreshController : ControllerBase
  {

    // POST api/<RefreshController>
    [HttpPost]
    public string Post([FromBody] string reciveToken)
    {
      Console.WriteLine(reciveToken);
      string token = Program.storedLogins.refreshToken(reciveToken);
      Console.WriteLine(token);
      return token;
    }
  }
}
