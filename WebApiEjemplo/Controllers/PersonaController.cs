using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEjemplo.Entidades;

namespace WebApiEjemplo.Controllers
{
    [ApiController]
    [Route("api/persona")]
    public class PersonaController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public PersonaController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult> Post(Persona persona)
        {
            context.Add(persona);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
