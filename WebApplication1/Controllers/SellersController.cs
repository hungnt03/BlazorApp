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
    public class SellersController : ControllerBase
    {
        private readonly HungTestContext _db;
        public SellersController(HungTestContext db) => _db = db;

        [HttpGet("{condition}")]
        public async Task<ActionResult<List<Product>>> GetProducts(string condition)
        {
            return await _db.Products.Where(p => p.Barcode.Equals(condition) || p.Name.Contains(condition)).OrderBy(x => x.Name).ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetDefaultProducts()
        {
            return await _db.Products.Where(p => p.Pin.Value).ToListAsync();
        }
    }
}
