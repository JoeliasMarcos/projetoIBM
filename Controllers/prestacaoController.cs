using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetoIBM.Models;
using projetoIBM.Data;

namespace projetoIBM.Controllers
{
     [ApiController]
        [Route("v1/Prestacao")]
    public class prestacaoController : ControllerBase
    {[HttpGet]
    [Route("")]
        public async Task<ActionResult<List<Prestacao>>> Get([FromServices] DataContext context)
        {
            var prestacaos = await context.Prestacaos.ToListAsync();
            return prestacaos;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Prestacao>> GetById([FromServices] DataContext context, int id)
        {
            
            var prestacaos = await context.Prestacaos.Include(x=> x.IdPrestacao).AsNoTracking().FirstOrDefaultAsync(x=> x.IdPrestacao ==id);
                        return prestacaos;
        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Prestacao>> Post([FromServices] DataContext context,[FromBody]Prestacao model)
        {
           if (ModelState.IsValid)
           {
               context.Prestacaos.Add(model);
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