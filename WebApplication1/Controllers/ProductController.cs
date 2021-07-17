using Blazor.Server.Entities;
using Blazor.Shared.Commons;
using Blazor.Shared.Entities;
using Blazor.Shared.Others;
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
    public class ProductController : ControllerBase
    {
        private readonly HungTestContext _db;
        public ProductController(HungTestContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductModel>>> GetProducts()
        {
            var products = await _db.Products.OrderBy(x => x.Name).ToListAsync();
            var units = await _db.Units.ToDictionaryAsync(x => x.Id, x => x.Name);
            var results = new List<ProductModel>();
            foreach(var product in products)
            {
                var model = MapperUtil.Map<Product,ProductModel>(product);
                if (units.ContainsKey(model.Unit)) model.UnitName = units[model.Unit];
                results.Add(model);
            }
            return results;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(string id)
        {
            var result = await _db.Products.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProducts), new { id = product.Barcode }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(string id, Product Product)
        {
            if (id != Product.Barcode) return BadRequest();
            _db.Entry(Product).State = EntityState.Modified;
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
        public async Task<IActionResult> DeleteProduct(string id)
        {
            var result = await _db.Products.FindAsync(id);
            if (result == null) return NotFound();
            _db.Products.Remove(result);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool IsExists(string id)
        {
            return _db.Products.Any(x => x.Barcode == id);
        }
    }
}
