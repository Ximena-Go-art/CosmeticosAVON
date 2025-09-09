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
    public class VentaDetallesController : ControllerBase
    {
        private readonly CosmeticosContext _context;

        public VentaDetallesController(CosmeticosContext context)
        {
            _context = context;
        }

        // GET: api/VentaDetalles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VentaDetalle>>> GetVentaDetalles()
        {
            return await _context.VentaDetalles.ToListAsync();
        }

        // GET: api/VentaDetalles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VentaDetalle>> GetVentaDetalle(int id)
        {
            var ventaDetalle = await _context.VentaDetalles.FindAsync(id);

            if (ventaDetalle == null)
            {
                return NotFound();
            }

            return ventaDetalle;
        }

        // GET: api/VentaDetalles/deleteds  ESTE
        [HttpGet("deleteds/")]

        public async Task<ActionResult<IEnumerable<VentaDetalle>>> GetVentasDetalleDeleteds()
        {
            return await _context.VentaDetalles.IgnoreQueryFilters()
                .Where(vd => vd.IsDeleted)
                .ToListAsync();
        }

        // PUT: api/VentaDetalles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVentaDetalle(int id, VentaDetalle ventaDetalle)
        {
            if (id != ventaDetalle.Id)
            {
                return BadRequest();
            }

            _context.Entry(ventaDetalle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaDetalleExists(id))
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

        // POST: api/VentaDetalles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VentaDetalle>> PostVentaDetalle(VentaDetalle ventaDetalle)
        {
            _context.VentaDetalles.Add(ventaDetalle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVentaDetalle", new { id = ventaDetalle.Id }, ventaDetalle);
        }

        // DELETE: api/VentaDetalles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVentaDetalle(int id)
        {
            var ventaDetalle = await _context.VentaDetalles.FindAsync(id);
            if (ventaDetalle == null)
            {
                return NotFound();
            }

            _context.VentaDetalles.Remove(ventaDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // RESTORE: api/Venta Detalle/restore/5  ESTE
        [HttpPut("restore/{id}")]
        public async Task<IActionResult> RestoreVentaDetalle(int id)
        {
            var ventaDetalle = await _context.VentaDetalles.IgnoreQueryFilters().FirstOrDefaultAsync(vd => vd.Id.Equals(id));
            if (ventaDetalle == null)
            {
                return NotFound();
            }
            ventaDetalle.IsDeleted = false;//Soft Restore
            _context.VentaDetalles.Update(ventaDetalle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VentaDetalleExists(int id)
        {
            return _context.VentaDetalles.Any(e => e.Id == id);
        }
    }
}
