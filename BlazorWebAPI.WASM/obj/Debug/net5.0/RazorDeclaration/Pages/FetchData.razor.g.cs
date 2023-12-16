// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebAPI.WASM.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using BlazorWebAPI.WASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using BlazorWebAPI.WASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using BlazorWebAPI.WASM.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\_Imports.razor"
using SharedData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
