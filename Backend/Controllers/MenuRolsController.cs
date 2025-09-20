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
    public class MenuRolsController : ControllerBase
    {
        private readonly CosmeticosContext _context;

        public MenuRolsController(CosmeticosContext context)
        {
            _context = context;
        }

        // GET: api/MenuRols
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuRol>>> GetMenuRoles()
        {
            return await _context.MenuRoles.ToListAsync();
        }

        // GET: api/MenuRols/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuRol>> GetMenuRol(int id)
        {
            var menuRol = await _context.MenuRoles.FindAsync(id);

            if (menuRol == null)
            {
                return NotFound();
            }

            return menuRol;
        }
        // GET: api/Productos/deleteds  ESTE
        [HttpGet("deleteds/")]

        public async Task<ActionResult<IEnumerable<MenuRol>>> GetMenuDeleteds()
        {
            return await _context.MenuRoles.IgnoreQueryFilters()
                .Where(c => c.IsDeleted)
                .ToListAsync();
        }

        // PUT: api/MenuRols/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenuRol(int id, MenuRol menuRol)
        {
            if (id != menuRol.Id)
            {
                return BadRequest();
            }

            _context.Entry(menuRol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuRolExists(id))
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

        // POST: api/MenuRols
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MenuRol>> PostMenuRol(MenuRol menuRol)
        {
            _context.MenuRoles.Add(menuRol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenuRol", new { id = menuRol.Id }, menuRol);
        }

        // DELETE: api/MenuRols/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuRol(int id)
        {
            var menuRol = await _context.MenuRoles.FindAsync(id);
            if (menuRol == null)
            {
                return NotFound();
            }

            _context.MenuRoles.Remove(menuRol);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // RESTORE: api/Productos/restore/5  ESTE
        [HttpPut("restore/{id}")]
        public async Task<IActionResult> RestoreMenuRol(int id)
        {
            var menurol = await _context.MenuRoles.IgnoreQueryFilters().FirstOrDefaultAsync(p => p.Id.Equals(id));
            if (menurol == null)
            {
                return NotFound();
            }
            menurol.IsDeleted = false;//Soft Restore
            _context.MenuRoles.Update(menurol);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenuRolExists(int id)
        {
            return _context.MenuRoles.Any(e => e.Id == id);
        }
    }
}
