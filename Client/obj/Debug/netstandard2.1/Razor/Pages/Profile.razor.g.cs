#pragma checksum "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7826161782300302a67b0bc396e5035fe53a98ed"
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
#line 1 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Client.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
using Estore.Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""modal fade lug"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog"">
        Modal content
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Change</h4>
            </div>
            <div class=""modal-body"">
                <ul>
                    <li><a href=""#""><img src=""images/flag-up-1.png"" alt> United States</a></li>
                    <li><a href=""#""><img src=""images/flag-up-2.png"" alt> France </a></li>
                </ul>
            </div>
        </div>
    </div>
</div>
");
            __builder.AddMarkupContent(1, "<div id=\"sidebar\" class=\"top-nav\">\r\n    <ul id=\"sidebar-nav\" class=\"sidebar-nav\">\r\n        <li><a href=\"#\">Help</a></li>\r\n        <li><a href=\"#\">How it works</a></li>\r\n        <li><a href=\"#\">Chamb for Business</a></li>\r\n    </ul>\r\n</div>\r\n");
            __builder.AddMarkupContent(2, @"<div class=""profile-box banner-p"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""profile-b"">
                    <img src=""images/lag-63.png"" alt=""#"">
                    <div class=""dit-p"">
                        <div class=""col-md-2""></div>
                        <div class=""col-md-10"">
                            <div class=""profile-left-b"">
                                <ul>
                                    <li><a href=""#"">Manufacturer </a></li>
                                    <li><a href=""#"">Furniture</a></li>
                                    <li><a href=""#"">Est.2002</a></li>
                                    <li><a href=""#"">54-100 employees</a></li>
                                </ul>
                            </div>
                            <div class=""profile-right-b"">
                                <a class=""vi-btn"" href=""#"">Visit website</a>
                                <a class=""fo-btn"" href=""#"">Follow</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "product-profile-box");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-2 col-sm-4 pr");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "profile-pro-left");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "left-profile-box-m");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.AddMarkupContent(21, "<div class=\"pro-img\">\r\n                            <img src=\"images/150x150.png\" alt=\"#\">\r\n                        </div>\r\n                        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "pof-text");
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "h3");
            __builder.AddContent(26, 
#nullable restore
#line 66 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
                                 SellerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            <div class=\"check-box\"></div>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.AddMarkupContent(29, "<a href=\"#\">Contact company</a>\r\n                        ");
            __builder.AddMarkupContent(30, "<p><img src=\"images/report-icon.jpg\" alt>Report this user</p>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-md-10 col-sm-8");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "profile-pro-right");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "panel with-nav-tabs panel-default");
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "panel-heading clearfix");
            __builder.AddMarkupContent(45, "\r\n                            ");
            __builder.OpenElement(46, "ul");
            __builder.AddAttribute(47, "class", "nav nav-tabs pull-left");
            __builder.AddMarkupContent(48, "\r\n                                ");
            __builder.OpenElement(49, "li");
            __builder.AddAttribute(50, "class", "active");
            __builder.OpenElement(51, "a");
            __builder.AddAttribute(52, "href", "#tab1default");
            __builder.AddAttribute(53, "data-toggle", "tab");
            __builder.AddContent(54, "Products ");
            __builder.OpenElement(55, "span");
            __builder.AddContent(56, 
#nullable restore
#line 79 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
                                                                                                            ProductQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                ");
            __builder.AddMarkupContent(58, "<li><a href=\"#tab2default\" data-toggle=\"tab\">About</a></li>\r\n                                ");
            __builder.AddMarkupContent(59, "<li><a href=\"#tab3default\" data-toggle=\"tab\">Contact</a></li>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.AddMarkupContent(61, @"<ul class=""nav nav-tabs pull-right right-t"">
                                <li class=""dropdown"">
                                    <a href=""#"" data-toggle=""dropdown"">Sort <span class=""caret""></span></a>
                                    <ul class=""dropdown-menu"" role=""menu"">
                                        <li><a href=""#tab4default"" data-toggle=""tab"">Default 4</a></li>
                                    </ul>
                                </li>
                                <li><a href=""#tab5default"" data-toggle=""tab""><i class=""fa fa-sliders"" aria-hidden=""true""></i> Refine</a></li>
                            </ul>
                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "panel-body");
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "tab-content");
            __builder.AddMarkupContent(68, "\r\n                                ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "tab-pane fade in active");
            __builder.AddAttribute(71, "id", "tab1default");
            __builder.AddMarkupContent(72, "\r\n                                    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "product-box-main row");
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 97 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
                                         foreach (var p in Catalog.Products)
                                        {


#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "                                            ");
            __builder.OpenComponent<Estore.Client.Controls.Products>(77);
            __builder.AddAttribute(78, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 100 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
                                                                 p.Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "image", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 100 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
                                                                                     p.ImageAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "ProductName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 100 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
                                                                                                                   p.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "Price", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 100 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
                                                                                                                                   p.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "Ratings", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 100 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
                                                                                                                                                     123

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 101 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(84, "\r\n                                      \r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                    ");
            __builder.AddMarkupContent(86, @"<div class=""loding-box"">
                                        <a href=""#"">
                                            <div class=""sk-wave"">
                                                <div class=""sk-rect sk-rect1""></div>
                                                <div class=""sk-rect sk-rect2""></div>
                                                <div class=""sk-rect sk-rect3""></div>
                                                <div class=""sk-rect sk-rect4""></div>
                                                <div class=""sk-rect sk-rect5""></div>
                                            </div>
                                            <span>Loding more awesome products...</span>
                                        </a>
                                    </div>
                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                                ");
            __builder.AddMarkupContent(88, "<div class=\"tab-pane fade\" id=\"tab2default\">\r\n                                    <div class=\"about-box\">\r\n                                        <h2>What Does Chamb Do</h2>\r\n                                        <p>Chamb brings buyers and suppliers of goods together to create lasting profitable relationships. Through new connections, economic roads, and insightful associations, we want Chamb to help transform your business into the next Apple!</p>\r\n                                        <p>At Chamb we understand the old adage of ???it???s not what you know, but Who you know??? is key to success. With that in mind, through much trial and just a little bit of error, we learned the one limiting factor of any business achieving its potential: Their connections.</p>\r\n                                        <p>Before Chamb existed, we noticed that though the power of the net rested at business??? finger tips, resources for discovering manufacturers and suppliers was limited at best and non-existent at worse. Smaller companies that housed great products and potential, were starving through a lack of connectivity.</p>\r\n                                        <p>We took it upon ourselves to change that. We developed a burning desire to create something to bridge the chasms between businesses across country and continent. So, with a goal in mind, a skilled team at hand, Chamb sprung forth: the website that helps discover and build profitable long-lasting networks amongst businesses around the world.</p>\r\n                                    </div>\r\n                                </div>\r\n                                ");
            __builder.AddMarkupContent(89, "<div class=\"tab-pane fade\" id=\"tab3default\">Default 3</div>\r\n                                ");
            __builder.AddMarkupContent(90, "<div class=\"tab-pane fade\" id=\"tab4default\">Default 4</div>\r\n                                ");
            __builder.AddMarkupContent(91, "<div class=\"tab-pane fade\" id=\"tab5default\">Default 5</div>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Profile.razor"
 
    public string SellerName = "Usama Riasat";
    public int ProductQuantity = 200;

    //Get list of products
    public string Category = "Furniture";
    public string ProductName = "Silver Sofa";
    public string Price = "799";
    public string Ratings = "231";

    private Catalog Catalog { get; set; } = new Catalog();
    protected async override Task OnInitializedAsync()
    {
        Catalog = await svc.GetProduct();
        await base.OnInitializedAsync();
    }

    //List<Product> products = new List<Product> {
    //    new Product(1,"Wood Chair","233$",40,"no","Chair","2",324),
    //    new Product(2,"Golden Table","700$",42,"no","Table","2",344),
    //    new Product(2,"Wood Chair","233$",40,"no","Chair","2",344),
    //    new Product(2,"Chair","233$",40,"no","Chair","2",344),
    //    new Product(2,"Wood Chair","233$",40,"no","Chair","2",344),
    //    new Product(2,"Y. Table","233$",40,"no","Table","2",344),
    //    new Product(2,"Wood Chair","233$",40,"no","Chair","2",344),
    //    new Product(2,"Chair","233$",40,"no","Chair","2",344),
    //    new Product(2,"Sofa Table","233$",40,"no","Table","2",344),
    //    new Product(3,"Wood Chair","233$",40,"no","Chair","2",344),
    //    new Product(2,"Chair","233$",40,"no","Chair","2",344),
    //};

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductServices svc { get; set; }
    }
}
#pragma warning restore 1591
