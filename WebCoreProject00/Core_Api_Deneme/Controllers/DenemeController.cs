using Core_Api_Deneme.DataAcessL.ApiContext;
using Core_Api_Deneme.DataAcessL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Api_Deneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemeController : ControllerBase
    {
        [HttpGet]
        public IActionResult FarmList()
        {
            using var c = new Context();
            return Ok(c.MakuCiftliks.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult FarmGet(int id)
        {
            using var c = new Context();
            var value = c.MakuCiftliks.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }
        //[HttpGet("{id}")]
        //public IActionResult FarmsGet(int id)
        //{

        //    Context c = new Context();
        //    //var frm = c.MakuCiftliks.Where(x => x.ID == id);
        //    var values = c.MakuCiftliks.Where(x => x.ID == id && x.SutMiktari > 400).Select(y => y.SutMiktari);
        //    return Ok(values);

        //}
        [HttpDelete]
        public IActionResult FarmDelete(int id)
        {
            using var c = new Context();
            var value = c.MakuCiftliks.Find(id);
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

        [HttpPost]
        public IActionResult FarmAdd(MakuCiftlik p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }

        [HttpPut]
        public IActionResult UpdateCategory(MakuCiftlik p)
        {
            using var c = new Context();
            var value = c.Find<MakuCiftlik>(p.ID);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.SutMiktari = p.SutMiktari;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }


    }
}
