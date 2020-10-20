using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P2P.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace P2P.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PeerController : ControllerBase
    {
        public static readonly Dictionary<string, Peer> peers = new Dictionary<string, Peer>()
        {
            {"File 1", new Peer("127.0.0.1",2049)},
            {"File 2", new Peer("127.0.0.2",2050)},
            {"File 3", new Peer("127.0.0.3",2051)},
            {"File 4", new Peer("127.0.0.4",2052)},
            {"File 5", new Peer("127.0.0.5",2053)},
        };
        
    

        // GET: api/<PeerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PeerController>/5
        [HttpGet]
        [Route("{FileName}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(string FileName)
        {
            if (peers.ContainsKey(i => i.FileName == FileName))
            {
                return Ok(peers.Find(i => i.FileName == FileName));
            }
            else
                return NotFound($"Peer {FileName} not found");
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
