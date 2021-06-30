using Blazor.Server.Entities;
using Blazor.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoriesController : ControllerBase
    {
        private readonly HungTestContext _db;
        public CategoriesController(HungTestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return await _db.Categories.OrderBy(x => x.Name).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var result = await _db.Categories.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            _db.Categories.Add(category);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCategories), new { id = category.Id }, category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, Category category)
        {
            if (id != category.Id) return BadRequest();
            _db.Entry(category).State = EntityState.Modified;
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
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var result = await _db.Categories.FindAsync(id);
            if (result == null) return NotFound();
            _db.Categories.Remove(result);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool IsExists(int id)
        {
            return _db.Categories.Any(x => x.Id == id);
        }
    }
}
