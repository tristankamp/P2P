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
        private static readonly List<Peer> peers = new List<Peer>()
        {
            new Peer("File1","127.0.0.1",2049),
            new Peer("File2","130.0.0.1",2050),
            new Peer("File3","145.0.0.1",2051),
            new Peer("File4","131.0.0.1",2052),
            new Peer("File5","199.0.0.1",3000)
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
            if (peers.Exists(i => i.FileName == FileName))
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
