#pragma checksum "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d2511d9871a9d3e29072c8f92a2c721e6c0d24e"
// <auto-generated/>
#pragma warning disable 1591
namespace Estore.Client.Controls
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
#line 1 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
using Estore.Server.Models;

#line default
#line hidden
#nullable disable
    public partial class AddProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card card-signin my-5 w-75");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body  align-items-center w-75");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<h2 class=\"card-title text-center mb-1\">Add Product</h2>\r\n            <br>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
                              product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "form-signin w-75");
            __builder.AddAttribute(13, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
                                                                          addProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-label-group");
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.AddMarkupContent(19, "<label for=\"productName\">Product Name</label>\r\n                    ");
                __builder2.OpenElement(20, "input");
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "id", "productName");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "placeholder", "Product Name");
                __builder2.AddAttribute(25, "required", true);
                __builder2.AddAttribute(26, "autofocus", true);
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
                                                                     product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Name = __value, product.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                <br>\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-label-group");
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.AddMarkupContent(34, "<label for=\"category\">Category</label>\r\n                    ");
                __builder2.OpenElement(35, "input");
                __builder2.AddAttribute(36, "type", "text");
                __builder2.AddAttribute(37, "id", "productCategory");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "placeholder", "Category");
                __builder2.AddAttribute(40, "required", true);
                __builder2.AddAttribute(41, "autofocus", true);
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
                                                                         product.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Category = __value, product.Category));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                <br>\r\n                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-label-group mb-1");
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.AddMarkupContent(49, "<label for=\"price\">Price</label>\r\n                    ");
                __builder2.OpenElement(50, "input");
                __builder2.AddAttribute(51, "type", "text");
                __builder2.AddAttribute(52, "id", "inputPassword");
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "placeholder", "Price");
                __builder2.AddAttribute(55, "required", true);
                __builder2.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
                                                                       product.Price

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Price = __value, product.Price));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                <br>\r\n                ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-label-group mb-1");
                __builder2.AddMarkupContent(62, "\r\n                    ");
                __builder2.AddMarkupContent(63, "<label for=\"discount\">Discount</label>\r\n                    ");
                __builder2.OpenElement(64, "input");
                __builder2.AddAttribute(65, "type", "number");
                __builder2.AddAttribute(66, "id", "discount");
                __builder2.AddAttribute(67, "class", "form-control");
                __builder2.AddAttribute(68, "placeholder", "Discount");
                __builder2.AddAttribute(69, "required", true);
                __builder2.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
                                                                    product.Discount

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Discount = __value, product.Discount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                <br>\r\n                ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-label-group mb-1");
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __builder2.AddMarkupContent(77, "<label for=\"image\">image</label>\r\n                    ");
                __builder2.OpenElement(78, "input");
                __builder2.AddAttribute(79, "type", "text");
                __builder2.AddAttribute(80, "id", "image");
                __builder2.AddAttribute(81, "class", "form-control");
                __builder2.AddAttribute(82, "placeholder", "Image");
                __builder2.AddAttribute(83, "required", true);
                __builder2.AddAttribute(84, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
                                                               product.ImageAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.ImageAddress = __value, product.ImageAddress));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                <br>\r\n                ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-label-group mb-1");
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.AddMarkupContent(91, "<label for=\"OwnerID\">OwnerID</label>\r\n                    ");
                __builder2.OpenElement(92, "input");
                __builder2.AddAttribute(93, "type", "text");
                __builder2.AddAttribute(94, "id", "OwnerID");
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "placeholder", "OwnerID");
                __builder2.AddAttribute(97, "required", true);
                __builder2.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
                                                                 product.OwnerId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.OwnerId = __value, product.OwnerId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                <br>\r\n                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-label-group mb-1");
                __builder2.AddMarkupContent(104, "\r\n                    ");
                __builder2.AddMarkupContent(105, "<label for=\"ratings\">ratings</label>\r\n                    ");
                __builder2.OpenElement(106, "input");
                __builder2.AddAttribute(107, "type", "number");
                __builder2.AddAttribute(108, "id", "ratings");
                __builder2.AddAttribute(109, "class", "form-control");
                __builder2.AddAttribute(110, "placeholder", "Ratings");
                __builder2.AddAttribute(111, "required", true);
                __builder2.AddAttribute(112, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
                                                                   product.Ratings

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => product.Ratings = __value, product.Ratings, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                <br>\r\n                ");
                __builder2.AddMarkupContent(116, "<button class=\"btn btn-lg btn-primary mb-1 btn-block text-uppercase\" type=\"submit\">Add</button>\r\n\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(117, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Controls\AddProducts.razor"
       
   
    Product product = new Product();

   
        private async Task addProduct()
        {
            var status = await svc.AddProduct(product);
            Console.WriteLine($"here is from service {status}");
        }


   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductServices svc { get; set; }
    }
}
#pragma warning restore 1591