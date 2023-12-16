using BlazorWebAPI.WASM.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SharedData.Models;
using System;
using System.Collections.Generic;
using System.Net.Http; 
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAPI.WASM
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddScoped<IService<Employee>, EmployeeService>();
			builder.Services.AddScoped<IService<Department>, DepartmentService>();


			builder.Services.AddScoped(sp => new HttpClient { 
				BaseAddress = new Uri(sp.GetRequiredService<IConfiguration>()["IP"]) });

			await builder.Build().RunAsync();
		}
	}
}
