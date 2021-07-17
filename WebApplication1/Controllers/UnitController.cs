using Blazor.Server.Entities;
using Blazor.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UnitController : ControllerBase
    {
        private readonly HungTestContext _db;
        public UnitController(HungTestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Unit>>> GetUnits()
        {
            return await _db.Units.OrderBy(x => x.Name).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Unit>> GetUnit(int id)
        {
            var result = await _db.Units.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> CreateUnit(Unit Unit)
        {
            _db.Units.Add(Unit);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetUnits), new { id = Unit.Id }, Unit);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUnit(int id, Unit Unit)
        {
            if (id != Unit.Id) return BadRequest();
            _db.Entry(Unit).State = EntityState.Modified;
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                if (!IsExists(id)) return NotFound();
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnit(int id)
        {
            var result = await _db.Units.FindAsync(id);
            if (result == null) return NotFound();
            _db.Units.Remove(result);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool IsExists(int id)
        {
            return _db.Units.Any(x => x.Id == id);
        }
    }
}
