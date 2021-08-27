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
    public class MovimientoController : ControllerBase
    {
        private readonly ITSenseContext _context;

        public MovimientoController(ITSenseContext context)
        {
            _context = context;
        }

        // GET: api/Movimiento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movimientos>>> GetMovimientos()
        {
            return await _context.Movimientos.ToListAsync();
        }

        // GET: api/Movimiento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movimientos>> GetMovimientos(int id)
        {
            var movimientos = await _context.Movimientos.FindAsync(id);

            if (movimientos == null)
            {
                return NotFound();
            }

            return movimientos;
        }

        // PUT: api/Movimiento/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovimientos(int id, Movimientos movimientos)
        {
            if (id != movimientos.moCod)
            {
                return BadRequest();
            }

            _context.Entry(movimientos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimientosExists(id))
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

        // POST: api/Movimiento
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movimientos>> PostMovimientos(Movimientos movimientos)
        {
            _context.Movimientos.Add(movimientos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovimientos", new { id = movimientos.moCod }, movimientos);
        }

        // DELETE: api/Movimiento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovimientos(int id)
        {
            var movimientos = await _context.Movimientos.FindAsync(id);
            if (movimientos == null)
            {
                return NotFound();
            }

            _context.Movimientos.Remove(movimientos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovimientosExists(int id)
        {
            return _context.Movimientos.Any(e => e.moCod == id);
        }
    }
}
