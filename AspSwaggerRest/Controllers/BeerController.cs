using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspSwaggerRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        List<Beer> Beers = new List<Beer>()
        {
            new Beer(){ Id = 1, Name = "Delirium"},
            new Beer(){ Id = 2, Name = "Corona"},
            new Beer(){ Id = 3, Name = "Erdinger"},
        };

        [HttpGet]
        public ActionResult<Beer> Get(int Id)
        {
            var beer = Beers.Where(b => b.Id == Id).FirstOrDefault();
            if (beer == null) return NotFound();
            return beer;
        }
    }

    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
