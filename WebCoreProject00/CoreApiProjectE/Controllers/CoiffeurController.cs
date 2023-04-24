using CoreApiProjectE.DAL.ApiContext;
using CoreApiProjectE.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiProjectE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoiffeurController : ControllerBase
    {
        [HttpGet]
        public IActionResult CoiffeurList()
        {
            using var c = new Context();
            return Ok(c.Coiffeurs.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult CoiffeurGet(int id)
        {
            using var c = new Context();
            var value = c.Coiffeurs.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }
        [HttpPost]
        public IActionResult CoiffeurAdd(Coiffeur p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }
        [HttpDelete]
        public IActionResult CoiffeurDelete(int id)
        {
            using var c = new Context();
            var value = c.Coiffeurs.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult UpdateCoiffeur(Coiffeur p)
        {
            using var c = new Context();
            var value = c.Find<Coiffeur>(p.ID);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.CustomerName = p.CustomerName;
                value.OperationTime = p.OperationTime;
                value.Payment = p.Payment;
                value.AuthorizedPerson= p.AuthorizedPerson;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }
    }
}
