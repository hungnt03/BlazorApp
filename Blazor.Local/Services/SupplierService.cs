using Blazor.Shared;
using Blazor.Shared.Commons;
using Blazor.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Local.Services
{
    public interface ISupplierService
    {
        Supplier supplier { get; }
        Task<IList<Supplier>> GetAll();
        Task<Supplier> GetById(string id);
        Task Create(Supplier model);
        Task Update(string id, Supplier model);
        Task Delete(string id);
    }
    public class SupplierService : CommonService, ISupplierService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        public Supplier supplier { private set; get; }

        public SupplierService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService)
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Create(Supplier model)
        {
            model.CreatedBy = User.Username;
            model.CreatedAt = System.DateTime.Now;
            await _httpService.Post("/api/supplier", model);
        }

        public async Task Delete(string id)
        {
            await _httpService.Delete($"/api/supplier/{id}");
        }

        public async Task<IList<Supplier>> GetAll()
        {
            User = await _localStorageService.GetItem<User>(StringUtil.USER_KEY);
            return await _httpService.Get<IList<Supplier>>("/api/supplier");
        }

        public async Task<Supplier> GetById(string id)
        {
            return await _httpService.Get<Supplier>($"/api/supplier/{id}");
        }

        public async Task Update(string id, Supplier model)
        {
            model.UpdatedBy = User.Username;
            model.UpdatedAt = System.DateTime.Now;
            await _httpService.Put($"/api/supplier/{id}", model);
        }
    }
}
