#pragma checksum "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da05a2e27d9d81b547e02ef9275bcf189d9c56e3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebAPI.WASM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card mb-3");
            __builder.AddMarkupContent(2, "<h5 class=\"card-header\">Departments</h5>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "<h5 class=\"card-title\">Our Departments</h5>\r\n        ");
            __builder.AddMarkupContent(6, "<p class=\"card-text\">Check Our Departments with employees in each.</p>\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-primary text-white cursor-pointer");
            __builder.AddAttribute(9, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\Index.razor"
                                                                            () => NavigateToDepartment()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Go TO Departments");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card");
            __builder.AddMarkupContent(14, "<h5 class=\"card-header\">Employess</h5>\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body");
            __builder.AddMarkupContent(17, "<h5 class=\"card-title\">Our Employees</h5>\r\n        ");
            __builder.AddMarkupContent(18, "<p class=\"card-text\">Check Our Employees.</p>\r\n        ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-primary text-white cursor-poniter");
            __builder.AddAttribute(21, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\Index.razor"
                                                                            () => NavigateToEmpoyess()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Go TO Employees");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\Index.razor"
       
    [Inject]
    public NavigationManager navigationManager { get; set; }
    private void NavigateToDepartment()
    {
        navigationManager.NavigateTo($"/Departments");
    }
    private void NavigateToEmpoyess()
    {
        navigationManager.NavigateTo($"/Employees");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591