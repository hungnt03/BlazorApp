using Blazor.Shared;
using Blazor.Shared.Commons;
using Blazor.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Local.Services
{
    public interface ICategoryService
    {
        Category category { get; }
        Task<IList<Category>> GetAll();
        Task<Category> GetById(string id);
        Task Create(Category model);
        Task Update(string id, Category model);
        Task Delete(string id);
    }
    public class CategoryService : CommonService,ICategoryService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        public Category category { private set; get; }

        public CategoryService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService)
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;            
        }

        public async Task Create(Category model)
        {
            model.CreatedBy = User.Username;
            model.CreatedAt = System.DateTime.Now;
            await _httpService.Post("/api/categories", model);
        }

        public async Task Delete(string id)
        {
            await _httpService.Delete($"/api/categories/{id}");
        }

        public async Task<IList<Category>> GetAll()
        {
            User = await _localStorageService.GetItem<User>(StringUtil.USER_KEY);
            return await _httpService.Get<IList<Category>>("/api/categories");
        }

        public async Task<Category> GetById(string id)
        {
            return await _httpService.Get<Category>($"/api/categories/{id}");
        }

        public async Task Update(string id, Category model)
        {
            model.UpdatedBy = User.Username;
            model.UpdatedAt = System.DateTime.Now;
            await  _httpService.Put($"/api/categories/{id}", model);
        }
    }
}
