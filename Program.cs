using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using FluentValidation;
using Flux.Wasm.Dto;
using Flux.Wasm.DtoValidation;
using Fluxor;

namespace Flux.Wasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddFluxor(config =>
            {
                config
                    .ScanAssemblies(typeof(Program).Assembly)
                    .UseReduxDevTools();
            });

            //builder.Services.AddTransient<IValidator<CompanyDetailDto>, CompanyDetailDtoValidator>();
            //builder.Services.AddTransient<IValidator<PaymentInfoDto>, PaymentInfoDtoValidator>();
            //builder.Services.AddTransient<IValidator<UserDto>, UserDtoValidator>();

            await builder.Build().RunAsync();
        }
    }
}
