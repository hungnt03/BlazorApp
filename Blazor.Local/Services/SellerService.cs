using Blazor.Shared;
using Blazor.Shared.Commons;
using Blazor.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Local.Services
{
    public interface ISellerService
    {
        Task<IList<Product>> GetDefaultProducts();
        Task<IList<Product>> SearchProducts(string condition);
    }
    public class SellerService : ISellerService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private IAccountService _accountService;
        public SellerService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService,
            IAccountService accountService)
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
            _accountService = accountService;
        }
        public async Task<IList<Product>> GetDefaultProducts()
        {
            return await _httpService.Get<IList<Product>>("/api/sellers");
        }

        public async Task<IList<Product>> SearchProducts(string condition)
        {
            return await _httpService.Get<IList<Product>>($"/api/sellers/{condition}");
        }
    }
}
