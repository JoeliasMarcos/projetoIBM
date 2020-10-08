using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetoIBM.Models;
using projetoIBM.Data;
using System.Linq;

namespace projetoIBM.Controllers
{
     [ApiController]
        [Route("v1/Contratos")]
    public class contratoController : ControllerBase
    {[HttpGet]
    [Route("")]
        public async Task<ActionResult<List<Contrato>>> Get([FromServices] DataContext context)
        {
            var contratos = await context.Contratos.ToListAsync();
            return contratos;
        }

         [HttpGet]
        [Route("prestacaos/{id:int}")]
        public async Task<ActionResult<List<Contrato>>> GetByPrestacao([FromServices] DataContext context,int id)
        {
            var contratos = await context.Contratos.Include(x => x.Prestacao).Where(x => x.IdPrestacao == id).ToListAsync();
         

            return contratos;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Contrato>> Post([FromServices] DataContext context,[FromBody]Contrato model)
        {
           if (ModelState.IsValid)
           {
               context.Contratos.Add(model);
               await context.SaveChangesAsync();
               return model;
               
           }
           else
           {
               return BadRequest(ModelState);          
               
            }
        }

       
    }
}