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
    public class SupplierController : ControllerBase
    {
        private readonly HungTestContext _db;
        public SupplierController(HungTestContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<Supplier>>> GetSuppliers()
        {
            return await _db.Suppliers.OrderBy(x => x.Name).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> GetSupplier(int id)
        {
            var result = await _db.Suppliers.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult<Supplier>> CreateSupplier(Supplier Supplier)
        {
            _db.Suppliers.Add(Supplier);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSuppliers), new { id = Supplier.Id }, Supplier);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSupplier(int id, Supplier Supplier)
        {
            if (id != Supplier.Id) return BadRequest();
            _db.Entry(Supplier).State = EntityState.Modified;
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
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            var result = await _db.Suppliers.FindAsync(id);
            if (result == null) return NotFound();
            _db.Suppliers.Remove(result);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool IsExists(int id)
        {
            return _db.Suppliers.Any(x => x.Id == id);
        }
    }
}
