using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.DataContext;
using Service.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly CosmeticosContext _context;

        public VentasController(CosmeticosContext context)
        {
            _context = context;
        }

        // GET: api/Venta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venta>>> GetVentas()
        {
            return await _context.Ventas.ToListAsync();
        }

        // GET: api/Ventas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Venta>> GetVentas(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);

            if (venta == null)
            {
                return NotFound();
            }

            return venta;
        }

        // GET: api/Ventas/deleteds  ESTE
        [HttpGet("deleteds/")]

        public async Task<ActionResult<IEnumerable<Venta>>> GetVentasDeleteds()
        {
            return await _context.Ventas.IgnoreQueryFilters()
                .Where(c => c.IsDeleted)
                .ToListAsync();
        }

        // PUT: api/Ventas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVenta(int id, Venta venta)
        {
            if (id != venta.Id)
            {
                return BadRequest();
            }

            _context.Entry(venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaExists(id))
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

        // POST: api/Venta

        [HttpPost]
        public async Task<ActionResult<Venta>> PostVenta(Venta venta)
        {
            _context.Ventas.Add(venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVenta", new { id = venta.Id }, venta);
        }

        // DELETE: api/Venta/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVenta(int id)
        {
            var venta = await _context.Ventas.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }

            venta.IsDeleted = true; //soft delete
            _context.Ventas.Update(venta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // RESTORE: api/Ventas/restore/5  ESTE
        [HttpPut("restore/{id}")]
        public async Task<IActionResult> RestoreVenta(int id)
        {
            var venta = await _context.Ventas.IgnoreQueryFilters().FirstOrDefaultAsync(v => v.Id.Equals(id));
            if (venta == null)
            {
                return NotFound();
            }
            venta.IsDeleted = false;//Soft Restore
            _context.Ventas.Update(venta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VentaExists(int id)
        {
            return _context.Ventas.Any(e => e.Id == id);
        }
    }
}
