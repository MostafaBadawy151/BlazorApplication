#pragma checksum "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\NewDepartment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55ee2b29efac862822d22b7f890c0d6df9d8c20b"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Department/Create")]
    public partial class NewDepartment : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>NewDepartment</h3>");
#nullable restore
#line 5 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\NewDepartment.razor"
 if (department != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 7 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\NewDepartment.razor"
                     department

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\NewDepartment.razor"
                                                Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\t\t");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\t\t");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "mt-2");
                __builder2.AddMarkupContent(11, "<label>Name</label>\r\n\t\t\t");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 12 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\NewDepartment.razor"
                                    department.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => department.Name = __value, department.Name))));
                __builder2.AddAttribute(16, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => department.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n\t\t\t");
                global::__Blazor.BlazorWebAPI.WASM.Pages.NewDepartment.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 13 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\NewDepartment.razor"
                                    ()=>department.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n\t\t<input type=\"submit\" value=\"Add\" class=\"btn btn-success mt-4\">");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 17 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\NewDepartment.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "G:\Blazor\BlazorWebAPI Solution\BlazorWebAPI.WASM\Pages\NewDepartment.razor"
       

	public Department department { get; set; } = new Department();

	[Inject]
	public NavigationManager NavManager { get; set; }


	public async void Save()
	{
		await DeptService.Insert(department);
		NavManager.NavigateTo("/Departments");
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService<Department> DeptService { get; set; }
    }
}
namespace __Blazor.BlazorWebAPI.WASM.Pages.NewDepartment
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
