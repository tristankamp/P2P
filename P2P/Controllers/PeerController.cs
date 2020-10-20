using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace P2P.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeerController : ControllerBase
    {
        // GET: api/<PeerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PeerController>/5
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string FileName)
        {
            if (items.Exists(i => i.Id == id))
            {
                return Ok(items.Find(i => i.Id == id));
            }
            else
                return NotFound($"Item {id} not found");
        }

        // POST api/<PeerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PeerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
