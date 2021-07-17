using Blazor.Shared;
using Blazor.Shared.Commons;
using Blazor.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Local.Services
{
    public interface IUnitService
    {
        Unit unit { get; }
        Task<IList<Unit>> GetAll();
        Task<Unit> GetById(string id);
        Task Create(Unit model);
        Task Update(string id, Unit model);
        Task Delete(string id);
    }
    public class UnitService : CommonService, IUnitService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        public Unit unit { private set; get; }

        public UnitService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService)
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Create(Unit model)
        {
            model.CreatedBy = User.Username;
            model.CreatedDate = System.DateTime.Now;
            await _httpService.Post("/api/unit", model);
        }

        public async Task Delete(string id)
        {
            await _httpService.Delete($"/api/unit/{id}");
        }

        public async Task<IList<Unit>> GetAll()
        {
            User = await _localStorageService.GetItem<User>(StringUtil.USER_KEY);
            return await _httpService.Get<IList<Unit>>("/api/unit");
        }

        public async Task<Unit> GetById(string id)
        {
            return await _httpService.Get<Unit>($"/api/unit/{id}");
        }

        public async Task Update(string id, Unit model)
        {
            model.UpdatedBy = User.Username;
            model.UpdatedDate = System.DateTime.Now;
            await _httpService.Put($"/api/unit/{id}", model);
        }
    }
}
