#pragma checksum "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Show-products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abc1676d68c763ea1bcc783595e8a03185cb0b3d"
// <auto-generated/>
#pragma warning disable 1591
namespace Estore.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Estore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Estore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Estore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Estore.Client.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Show-products.razor"
using Estore.Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Products")]
    public partial class Show_products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Show-products.razor"
 foreach (var product in Catalog.Products)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, 
#nullable restore
#line 9 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Show-products.razor"
         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "<br>\r\n");
#nullable restore
#line 10 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Show-products.razor"
    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Show-products.razor"
       

    private Catalog Catalog { get; set; } = new Catalog();
    protected async override Task OnInitializedAsync()
    {
        Catalog = await svc.GetProduct();
        await base.OnInitializedAsync();
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductServices svc { get; set; }
    }
}
#pragma warning restore 1591
