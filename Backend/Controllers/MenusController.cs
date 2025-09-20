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
    public class MenusController : ControllerBase
    {
        private readonly CosmeticosContext _context;

        public MenusController(CosmeticosContext context)
        {
            _context = context;
        }

        // GET: api/Menus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Menu>>> GetMenu()
        {
            return await _context.Menus.ToListAsync();
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Menu>> GetMenu(int id)
        {
            var menu = await _context.Menus.FindAsync(id);

            if (menu == null)
            {
                return NotFound();
            }

            return menu;
        }
        // GET: api/Productos/deleteds  ESTE
        [HttpGet("deleteds/")]

        public async Task<ActionResult<IEnumerable<Menu>>> GetMenuDeleteds()
        {
            return await _context.Menus.IgnoreQueryFilters()
                .Where(c => c.IsDeleted)
                .ToListAsync();
        }

        // PUT: api/Menus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenu(int id, Menu menu)
        {
            if (id != menu.Id)
            {
                return BadRequest();
            }

            _context.Entry(menu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuExists(id))
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

        // POST: api/Menus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Menu>> PostMenu(Menu menu)
        {
            _context.Menus.Add(menu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenu", new { id = menu.Id }, menu);
        }

        // DELETE: api/Menus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            var menu = await _context.Menus.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }

            _context.Menus.Remove(menu);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // RESTORE: api/Productos/restore/5  ESTE
        [HttpPut("restore/{id}")]
        public async Task<IActionResult> RestoreMenu(int id)
        {
            var menu = await _context.Menus.IgnoreQueryFilters().FirstOrDefaultAsync(p => p.Id.Equals(id));
            if (menu == null)
            {
                return NotFound();
            }
            menu.IsDeleted = false;//Soft Restore
            _context.Menus.Update(menu);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool MenuExists(int id)
        {
            return _context.Menus.Any(e => e.Id == id);
        }
    }
}
