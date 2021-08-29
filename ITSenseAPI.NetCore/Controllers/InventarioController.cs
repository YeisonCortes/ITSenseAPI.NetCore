using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ITSenseAPI.NetCore;
using ITSenseAPI.NetCore.Modelo;

namespace ITSenseAPI.NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        private readonly ITSenseContext _context;

        public InventarioController(ITSenseContext context)
        {
            _context = context;
        }

        // GET: api/Inventario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<mdInventario>>> GetmdInventario()
        {
            return await _context.Inventario.Include(x => x.Bodega).Include(e => e.Estado).ToListAsync();
        }

        // GET: api/Inventario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<mdInventario>> GetmdInventario(int id)
        {
            var mdInventario = await _context.Inventario.FindAsync(id);

            if (mdInventario == null)
            {
                return NotFound();
            }

            return mdInventario;
        }

        // PUT: api/Inventario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutmdInventario(int id, mdInventario mdInventario)
        {
            if (id != mdInventario.inCod)
            {
                return BadRequest();
            }

            _context.Entry(mdInventario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!mdInventarioExists(id))
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

        // POST: api/Inventario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<mdInventario>> PostmdInventario(mdInventario mdInventario)
        {
            _context.Inventario.Add(mdInventario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetmdInventario", new { id = mdInventario.inCod }, mdInventario);
        }

        // DELETE: api/Inventario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletemdInventario(int id)
        {
            var mdInventario = await _context.Inventario.FindAsync(id);
            if (mdInventario == null)
            {
                return NotFound();
            }

            _context.Inventario.Remove(mdInventario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool mdInventarioExists(int id)
        {
            return _context.Inventario.Any(e => e.inCod == id);
        }
    }
}
