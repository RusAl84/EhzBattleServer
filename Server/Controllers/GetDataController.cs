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
  public class GetDataController : ControllerBase
  {
    // GET: api/<GetDataController>
    [HttpGet]
    public string Get()
    {
      //string json = JsonConvert.SerializeObject(result);

      //string jsonString = DateTime.Now.Subtract(Program.freezTime).TotalSeconds.ToString();
      string jsonString = Program.freezTime.Subtract(DateTime.Now).TotalSeconds.ToString();
      TimeSpan difTime = Program.freezTime.Subtract(DateTime.Now);


      return jsonString;
    }

  //  // GET api/<GetDataController>/5
  //  [HttpGet("{id}")]
  //  public string Get(int id)
  //  {
  //    return "value";
  //  }

  //  // POST api/<GetDataController>
  //  [HttpPost]
  //  public void Post([FromBody] string value)
  //  {
  //  }

  //  // PUT api/<GetDataController>/5
  //  [HttpPut("{id}")]
  //  public void Put(int id, [FromBody] string value)
  //  {
  //  }

  //  // DELETE api/<GetDataController>/5
  //  [HttpDelete("{id}")]
  //  public void Delete(int id)
  //  {
  //  }
  }
}
