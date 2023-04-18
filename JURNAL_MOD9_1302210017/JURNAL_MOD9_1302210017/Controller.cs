using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JURNAL_MOD9_1302210017
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {

        private static List<Mahasiswa> dataMhw = new List<Mahasiswa>
        {
            new Mahasiswa("Walid Hanif Ataullah","1302213120"),
            new Mahasiswa("Muhammaad Raffa Zuhayr", "1302210068"),
            new Mahasiswa("Muhammad Yassin Rafi", "1302210055"),
            new Mahasiswa("Sylvana Rheina","1302210017"),
        };

        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMhw;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMhw[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa newMhw)
        {
            dataMhw.Add(newMhw);
        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa updatedMhw)
        {
            dataMhw[id] = updatedMhw;
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMhw.RemoveAt(id);
        }
    }
}