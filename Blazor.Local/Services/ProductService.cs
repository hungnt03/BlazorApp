using Blazor.Shared;
using Blazor.Shared.Commons;
using Blazor.Shared.Entities;
using Blazor.Shared.Others;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Local.Services
{
    public interface IProductService
    {
        Product product { get; }
        Task<IList<ProductModel>> GetAll();
        Task<IList<Unit>> GetUnits();
        Task<IList<Category>> GetCategories();
        Task<IList<Supplier>> GetSuppliers();
        Task<Product> GetById(string id);
        Task Create(Product model);
        Task Update(string id, Product model);
        Task Delete(string id);
    }
    public class ProductService : CommonService, IProductService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        public Product product { private set; get; }

        public ProductService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService)
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Create(Product model)
        {
            model.CreatedBy = User.Username;
            model.CreatedAt = System.DateTime.Now;
            await _httpService.Post("/api/product", model);
        }

        public async Task Delete(string id)
        {
            await _httpService.Delete($"/api/product/{id}");
        }

        public async Task<IList<ProductModel>> GetAll()
        {
            User = await _localStorageService.GetItem<User>(StringUtil.USER_KEY);
            return await _httpService.Get<IList<ProductModel>>("/api/product");
        }

        public async Task<Product> GetById(string id)
        {
            return await _httpService.Get<Product>($"/api/product/{id}");
        }

        public async Task Update(string id, Product model)
        {
            model.UpdatedBy = User.Username;
            model.UpdatedAt = System.DateTime.Now;
            await _httpService.Put($"/api/product/{id}", model);
        }

        public Task<IList<Unit>> GetUnits()
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Category>> GetCategories()
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Supplier>> GetSuppliers()
        {
            throw new System.NotImplementedException();
        }
    }
}
