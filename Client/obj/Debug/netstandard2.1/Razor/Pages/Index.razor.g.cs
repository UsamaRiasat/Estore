#pragma checksum "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e66c2b266c59781dc2a808c5eba9750e3d839862"
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
#line 11 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Estore.Server.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\_Imports.razor"
using Estore.Client.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""modal fade lug"" id=""myModal"" role=""dialog"">
        <div class=""modal-dialog"">
            -->
            
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
            __builder.AddMarkupContent(1, @"<div id=""sidebar"" class=""top-nav"">
        <ul id=""sidebar-nav"" class=""sidebar-nav"">
            <li><a href=""#"">Help</a></li>
            <li><a href=""howitworks.html"">How it works</a></li>
            <li><a href=""#"">chamb for Business</a></li>
        </ul>
    </div>
    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page-content-product");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "main-product");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row clearfix");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "find-box");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.AddMarkupContent(17, "<h1>Find your next product or<br>business partner here.</h1>\r\n                        ");
            __builder.AddMarkupContent(18, "<h4>It has never been easier.</h4>\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "product-sh");
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.AddMarkupContent(22, @"<div class=""col-sm-6"">
                                <div class=""form-sh"">
                                    <input type=""text"" placeholder=""Search something you love"">
                                </div>
                            </div>
                            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-sm-3");
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-sh");
            __builder.AddMarkupContent(28, "\r\n                                    ");
            __builder.OpenElement(29, "select");
            __builder.AddAttribute(30, "class", "selectpicker");
            __builder.AddMarkupContent(31, "\r\n                                        ");
            __builder.OpenElement(32, "option");
            __builder.AddContent(33, "Textiles");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                        ");
            __builder.OpenElement(35, "option");
            __builder.AddContent(36, "Furniture");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                        ");
            __builder.OpenElement(38, "option");
            __builder.AddContent(39, "Leather");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.AddMarkupContent(44, "<div class=\"col-sm-3\">\r\n                                <div class=\"form-sh\"> <a class=\"btn\" href=\"#\">Search</a> </div>\r\n                            </div>\r\n                            ");
            __builder.AddMarkupContent(45, "<p>Or simply<a href=\"#\"> click here </a> and get inspired!</p>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.AddMarkupContent(49, "<div class=\"row clearfix\">\r\n                    <div class=\"col-lg-3 col-sm-6 col-md-3\">\r\n                        <a href=\"/ProductPage\">\r\n                            <div class=\"box-img\">\r\n                                <h4>Product</h4>\r\n                                <img src=\"images/product/1.png\" alt>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"col-lg-3 col-sm-6 col-md-3\">\r\n                        <a href=\"/ProductPage\">\r\n                            <div class=\"box-img\">\r\n                                <h4>Product</h4>\r\n                                <img src=\"images/product/2.png\" alt>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"col-lg-3 col-sm-6 col-md-3\">\r\n                        <a href=\"/ProductPage\">\r\n                            <div class=\"box-img\">\r\n                                <h4>Product</h4>\r\n                                <img src=\"images/product/4.png\" alt>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"col-lg-3 col-sm-6 col-md-3\">\r\n                        <a href=\"/ProductPage\">\r\n                            <div class=\"box-img\">\r\n                                <h4>Product</h4>\r\n                                <img src=\"images/product/5.png\" alt>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"col-lg-3 col-sm-6 col-md-3\">\r\n                        <a href=\"/ProductPage\">\r\n                            <div class=\"box-img\">\r\n                                <h4>Product</h4>\r\n                                <img src=\"images/product/10.png\" alt>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"col-lg-3 col-sm-6 col-md-3\">\r\n                        <a href=\"/ProductPage\">\r\n                            <div class=\"box-img\">\r\n                                <h4>Product</h4>\r\n                                <img src=\"images/product/11.png\" alt>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"col-lg-3 col-sm-6 col-md-3\">\r\n                        <a href=\"/ProductPage\">\r\n                            <div class=\"box-img\">\r\n                                <h4>Product</h4>\r\n                                <img src=\"images/product/12.png\" alt>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"col-lg-3 col-sm-6 col-md-3\">\r\n                        <a href=\"/ProductPage\">\r\n                            <div class=\"box-img\">\r\n                                <h4>Product</h4>\r\n                                <img src=\"images/product/13.png\" alt>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"categories_link\">\r\n                        <a href=\"#\">Browse all categories here</a>\r\n                    </div>\r\n                </div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.AddMarkupContent(53, "<div class=\"cat-main-box\">\r\n        <div class=\"container\">\r\n            <div class=\"row panel-row\">\r\n                <div class=\"col-md-4 col-sm-6 wow fadeIn\" data-wow-delay=\"0.0s\">\r\n                    <div class=\"panel panel-default\">\r\n                        <div class=\"panel-body\">\r\n                            <img src=\"images/xpann-icon.jpg\" class=\"icon-small\" alt>\r\n                            <h4>�Chamb� Your Business</h4>\r\n                            <p>\r\n                                Grow easily with chamb. Create free account.\r\n                                We help expanding your business easily.\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4 col-sm-6 wow fadeIn\" data-wow-delay=\"0.2s\">\r\n                    <div class=\"panel panel-default\">\r\n                        <div class=\"panel-body\">\r\n                            <img src=\"images/create-icon.jpg\" class=\"icon-small\" alt>\r\n                            <h4>Create and add</h4>\r\n                            <p>\r\n                                Grow easily with chamb. Create free account.\r\n                                We help expanding your business easily.\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4 col-sm-6 wow fadeIn hidden-sm\" data-wow-delay=\"0.4s\">\r\n                    <div class=\"panel panel-default\">\r\n                        <div class=\"panel-body\">\r\n                            <img src=\"images/get-icon.jpg\" class=\"icon-small\" alt>\r\n                            <h4>Get inspired</h4>\r\n                            <p>\r\n                                Grow easily with chamb. Create free account.\r\n                                We help expanding your business easily.\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            __builder.AddMarkupContent(54, "<div class=\"products_exciting_box\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6 col-sm-6 wow fadeIn\" data-wow-delay=\"0.2s\">\r\n                    <div class=\"exciting_box f_pd\">\r\n                        <img src=\"images/exciting_img-01.jpg\" class=\"icon-small\" alt>\r\n                        <h4>\r\n                            Explore <strong>exciting</strong> and exotic products\r\n                            tailored to you.\r\n                        </h4>\r\n                        <p>\r\n                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod\r\n                            tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\n                            quis nostrud exercitation ullamco laboris..\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6 col-sm-6 wow fadeIn\" data-wow-delay=\"0.4s\">\r\n                    <div class=\"exciting_box l_pd\">\r\n                        <img src=\"images/exciting_img-02.jpg\" class=\"icon-small\" alt>\r\n                        <h4><strong>List your products on</strong> chamb and grow connections.</h4>\r\n                        <p>\r\n                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod\r\n                            tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,\r\n                            quis nostrud exercitation ullamco laboris..\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            __builder.AddMarkupContent(55, "<div class=\"start-free-box\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"container\">\r\n                    <div class=\"main-start-box\">\r\n                        <div class=\"free-box-a clearfix\">\r\n                            <div class=\"col-md-6 col-sm-6\">\r\n                                <div class=\"left-a-f\">\r\n                                    <h3>A platform built for scale & expansion. Start for free.</h3>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6 col-sm-6\">\r\n                                <div class=\"right-a-f\">\r\n                                    <p>\r\n                                        Over the comming years, way thet business through the web\r\n                                        works will change at agreat - and chamb is the\r\n                                        gamebreaker.\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"main-start-box\">\r\n                    <div class=\"bg_img_left\"><img src=\"images/bg_img1.png\" alt=\"#\"></div>\r\n                    <div class=\"container\">\r\n                        <div class=\"buyer-box clearfix\">\r\n                            <div class=\"col-md-6 col-sm-6 wow fadeIn\" data-wow-delay=\"0.2s\">\r\n                                <div class=\"left-buyer\">\r\n                                    <img class=\"img-responsive\" src=\"images/creat_pro.png\" alt=\"#\">\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6 col-sm-6 wow fadeIn\" data-wow-delay=\"0.4s\">\r\n                                <div class=\"right-buyer\">\r\n                                    <h4>seller</h4>\r\n                                    <h2>\r\n                                        Empower your factory<br>\r\n                                        <span>With a new lead Channel</span>\r\n                                    </h2>\r\n                                    <p>\r\n                                        Never worry about sales or income ftom outbound\r\n                                        channels. with chamb your store is directly\r\n                                        connected to thousands of interested in your\r\n                                        products.\r\n                                    </p>\r\n                                    <a href=\"#\">Create a Seller account</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"bg_img_right\"><img src=\"images/bg_img1.png\" alt=\"#\"></div>\r\n                <div class=\"main-start-box\">\r\n                    <div class=\"container\">\r\n                        <div class=\"supplier clearfix\">\r\n                            <div class=\"col-md-5 col-sm-6\">\r\n                                <div class=\"left-supplier\">\r\n                                    <h4>supplier</h4>\r\n                                    <h2>Grow your store <br><span>With a new sales channel</span></h2>\r\n                                    <p>\r\n                                        Never worry about sales or income ftom outbound\r\n                                        channels. with chamb your store is directly\r\n                                        connected to thousands of interested in your\r\n                                        products.\r\n                                    </p>\r\n                                    .\r\n                                    <a href=\"#\">Create a supplier account</a>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-7 col-sm-6\">\r\n                                <div class=\"right-supplier\">\r\n                                    <img class=\"img-responsive\" src=\"images/supplier-pc-img.png\" alt=\"#\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
