using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTiposSangre.Models;

namespace ApiTiposSangre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposSangreController : ControllerBase
    {
        private readonly Conexiones _context;

        public TiposSangreController(Conexiones context)
        {
            _context = context;
        }

        // GET: api/TiposSangre
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tipo_sangre>>> Gettipo_sangre()
        {
            return await _context.tipo_sangre.ToListAsync();
        }

        // GET: api/TiposSangre/5
        [HttpGet("{id}")]
        public async Task<ActionResult<tipo_sangre>> Gettipo_sangre(int id)
        {
            var tipo_sangre = await _context.tipo_sangre.FindAsync(id);

            if (tipo_sangre == null)
            {
                return NotFound();
            }

            return tipo_sangre;
        }

        // PUT: api/TiposSangre/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Puttipo_sangre(int id, tipo_sangre tipo_sangre)
        {
            if (id != tipo_sangre.id_tipo_sangre)
            {
                return BadRequest();
            }

            _context.Entry(tipo_sangre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tipo_sangreExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TiposSangre
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<tipo_sangre>> Posttipo_sangre(tipo_sangre tipo_sangre)
        {
            _context.tipo_sangre.Add(tipo_sangre);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Gettipo_sangre", new { id = tipo_sangre.id_tipo_sangre }, tipo_sangre);
        }

        // DELETE: api/TiposSangre/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletetipo_sangre(int id)
        {
            var tipo_sangre = await _context.tipo_sangre.FindAsync(id);
            if (tipo_sangre == null)
            {
                return NotFound();
            }

            _context.tipo_sangre.Remove(tipo_sangre);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool tipo_sangreExists(int id)
        {
            return _context.tipo_sangre.Any(e => e.id_tipo_sangre == id);
        }
    }
}
