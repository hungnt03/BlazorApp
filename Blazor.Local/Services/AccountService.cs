using Blazor.Shared;
using Blazor.Shared.Commons;
using Blazor.Shared.Identities;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Local.Services
{
    public interface IAccountService
    {
        User User { get; }
        Task Initialize();
        Task Login(LoginCredentials model);
        Task Logout();
        Task Register(UserDetails model);
        Task<IList<User>> GetAll();
        Task<User> GetById(string id);
        Task Update(string id, EditUser model);
        Task Delete(string id);
    }
    public class AccountService : IAccountService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;

        public User User { get; private set; }

        public AccountService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService
        )
        {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            User = await _localStorageService.GetItem<User>(StringUtil.USER_KEY);
        }

        public async Task Login(LoginCredentials model)
        {
            User = await _httpService.Post<User>("/api/auth/login", model);
            User.Username = model.Username;
            await _localStorageService.SetItem(StringUtil.USER_KEY, User);
        }

        public async Task Logout()
        {
            User = null;
            await _localStorageService.RemoveItem(StringUtil.USER_KEY);
            _navigationManager.NavigateTo("account/login");
        }

        public async Task Register(UserDetails model)
        {
            await _httpService.Post("/api/auth/register", model);
        }

        public async Task<IList<User>> GetAll()
        {
            return await _httpService.Get<IList<User>>("/api/auth/users");
        }

        public async Task<User> GetById(string id)
        {
            return await _httpService.Get<User>($"/users/{id}");
        }

        public async Task Update(string id, EditUser model)
        {
            await _httpService.Put($"/users/{id}", model);

            // update stored user if the logged in user updated their own record
            if (id == User.Id)
            {
                // update local storage
                User.FirstName = model.FirstName;
                User.LastName = model.LastName;
                User.Username = model.Username;
                await _localStorageService.SetItem(StringUtil.USER_KEY, User);
            }
        }

        public async Task Delete(string id)
        {
            await _httpService.Delete($"/users/{id}");

            // auto logout if the logged in user deleted their own record
            if (id == User.Id)
                await Logout();
        }
    }
}
