using Blazor.Local.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.Local
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services
                .AddScoped<IAccountService, AccountService>()
                .AddScoped<IAlertService, AlertService>()
                .AddScoped<IHttpService, HttpService>()
                .AddScoped<ILocalStorageService, LocalStorageService>()
                .AddScoped<ICategoryService, CategoryService>()
                .AddScoped<IProductService, ProductService>()
                .AddScoped<IUnitService, UnitService>()
                .AddScoped<ISupplierService, SupplierService>()
                .AddScoped<ISellerService, SellerService>();
            // configure http client
            builder.Services.AddScoped(x => {
                var apiUrl = new Uri(builder.Configuration["apiUrl"]);
                return new HttpClient() { BaseAddress = apiUrl };
            });

            //await builder.Build().RunAsync();
            var host = builder.Build();

            var accountService = host.Services.GetRequiredService<IAccountService>();
            await accountService.Initialize();

            await host.RunAsync();
        }
    }
}
