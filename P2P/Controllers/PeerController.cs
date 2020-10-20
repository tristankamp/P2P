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
    [Route("api/powernap/[controller]")]
    [ApiController]

    public class PeerController : ControllerBase
    {
        public static readonly Dictionary<string, Peer> peers = new Dictionary<string, Peer>()
        {
            {"File1", new Peer("127.0.0.1",2049)},
            {"File2", new Peer("127.0.0.2",2050)},
            {"File3", new Peer("127.0.0.3",2051)},
            {"File4", new Peer("127.0.0.4",2052)},
            {"File5", new Peer("127.0.0.5",2053)},
        };

        public int postresponse;

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
            if (peers.ContainsKey(FileName))
            {
                return Ok(peers[FileName]);
            }
            else
                return NotFound($"{FileName} not found");
        }

        // POST api/<PeerController>
        [HttpPost("{key}")]
        public int Post(string key, [FromBody] Peer PeerToAdd)
        {
            if (peers.ContainsKey(key) != true)
            {
                peers.Add(key, PeerToAdd);
                return 1;
            }

            if (peers.ContainsKey(key) == true)
            {
                return 0;
            }
            else return -1;
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
