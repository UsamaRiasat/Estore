<<<<<<< HEAD
#pragma checksum "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Productpage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d58f80477d056daab3e77cfa665801422d25ae7"
=======
#pragma checksum "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Productpage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b09593855306f1b66d617a350deb6999eb504ea7"
>>>>>>> c6a3433559cf7a6aa12f974f94a517290c265339
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
#line 11 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Server.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\_Imports.razor"
using Estore.Client.Controls;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductPage/{id:int}")]
    public partial class Productpage : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(2, @"<div class=""terms-conditions product-page"">
    <div class=""terms-title"">
        <div class=""container"">
            <div class=""row"">
                <ol class=""breadcrumb"">
                    <li><a href=""#"">Forntpage </a></li>
                    <li class=""active"">Furniture</li>
                    <li class=""active"">Sofa</li>
                    <li><a href=""#"">All setup Sofa</a></li>
                </ol>
            </div>
        </div>
    </div>
</div>
");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "product-page-main");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddMarkupContent(8, "\r\n        ");
<<<<<<< HEAD
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-12");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "prod-page-title");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.AddMarkupContent(18, "<h2>All setup Sofa</h2>\r\n                    ");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, "By ");
            __builder.OpenElement(21, "span");
            __builder.AddContent(22, 
#nullable restore
#line 49 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Productpage.razor"
                                 p.Name
=======
            __builder.AddMarkupContent(9, @"<div class=""row"">
            <div class=""col-md-12"">
                <div class=""prod-page-title"">
                    <h2>All setup Sofa</h2>
                    <p>By <span>Dex Morgan Mobilya</span></p>
                </div>
            </div>
        </div>
        ");
            __builder.OpenElement(10, "div");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenComponent<Estore.Client.Controls.ProductInfo>(12);
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(17, "<div class=\"text-center\" style=\"margin-top: 50px\">\r\n    <h1>Recent Products</h1>\r\n</div>\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "panel-body w-75");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "tab-content");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "tab-pane fade in active");
            __builder.AddAttribute(26, "id", "tab1default");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "product-box-main row w-50");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 166 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Productpage.razor"
                 foreach (var p in Catalog.Products)
                {

>>>>>>> c6a3433559cf7a6aa12f974f94a517290c265339

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-md-2 col-sm-4");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "left-profile-box-m prod-page");
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.AddMarkupContent(36, "<div class=\"pro-img\">\r\n                        <img src=\"images/150x150.png\" alt=\"#\">\r\n                    </div>\r\n                    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "pof-text");
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "h3");
            __builder.AddContent(41, ">");
            __builder.AddContent(42, 
#nullable restore
#line 60 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Productpage.razor"
                              p.Name
=======
            __builder.AddContent(31, "                    ");
            __builder.OpenComponent<Estore.Client.Controls.ProductsForUser>(32);
            __builder.AddAttribute(33, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 169 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Productpage.razor"
                                                p.Category
>>>>>>> c6a3433559cf7a6aa12f974f94a517290c265339

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        <div class=\"check-box\"></div>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.AddMarkupContent(45, "<a href=\"#\">Visit store</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.AddMarkupContent(48, "<div class=\"col-md-7 col-sm-8\">\r\n                <div class=\"md-prod-page\">\r\n                    <div class=\"md-prod-page-in\">\r\n                        <div class=\"page-preview\">\r\n                            <div class=\"preview\">\r\n                                <div class=\"preview-pic tab-content\">\r\n                                    <div class=\"tab-pane active\" id=\"pic-1\"><img src=\"images/lag-60.png\" alt=\"#\"></div>\r\n                                    <div class=\"tab-pane\" id=\"pic-2\"><img src=\"images/lag-61.png\" alt=\"#\"></div>\r\n                                    <div class=\"tab-pane\" id=\"pic-3\"><img src=\"images/lag-60.png\" alt=\"#\"></div>\r\n                                    <div class=\"tab-pane\" id=\"pic-4\"><img src=\"images/lag-61.png\" alt=\"#\"></div>\r\n                                </div>\r\n                                <ul class=\"preview-thumbnail nav nav-tabs\">\r\n                                    <li class=\"active\"><a data-target=\"#pic-1\" data-toggle=\"tab\"><img src=\"images/lag-60.png\" alt=\"#\"></a></li>\r\n                                    <li><a data-target=\"#pic-2\" data-toggle=\"tab\"><img src=\"images/lag-61.png\" alt=\"#\"></a></li>\r\n                                    <li><a data-target=\"#pic-3\" data-toggle=\"tab\"><img src=\"images/lag-60.png\" alt=\"#\"></a></li>\r\n                                    <li><a data-target=\"#pic-4\" data-toggle=\"tab\"><img src=\"images/lag-61.png\" alt=\"#\"></a></li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"btn-dit-list clearfix\">\r\n                            <div class=\"left-dit-p\">\r\n                                <div class=\"prod-btn\">\r\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\r\n                                    <p>23 likes</p>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"right-dit-p\">\r\n                                <div class=\"like-list\">\r\n                                    <ul>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img class src=\"images/list-img-01.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img src=\"images/list-img-02.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img src=\"images/list-img-03.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img src=\"images/list-img-04.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img src=\"images/list-img-05.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img src=\"images/list-img-06.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><i class=\"fa fa-ellipsis-h\" aria-hidden=\"true\"></i></div>\r\n                                        </li>\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"description-box\">\r\n                        <div class=\"dex-a\">\r\n                            <h4>Description</h4>\r\n                            <p>\r\n                                Lorem Ipsum is simply dummy text of the printing and typesetting industry.\r\n                                lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s,\r\n                                when an unknown printer took a galley of type and scrambled it to make a\r\n                                type specimen book..\r\n                            </p>\r\n                            <br>\r\n                            <p>Small: H 25 cm / &Oslash; 12 cm</p>\r\n                            <p>Large H 24 cm / &Oslash; 25 cm</p>\r\n                        </div>\r\n                        <div class=\"spe-a\">\r\n                            <h4>Specifications</h4>\r\n                            <ul>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Measurments</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>H25 cm / 0 12 cm and H 24 cm / 0 25 cm</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Material</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>Material Name</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Wire</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>Wire Name</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Comdition</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>Brand new</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>SKU number</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>SKU number</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Shipping</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>Shipping worldwide</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Warranty</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>1 years</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Delivery</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>Choose country</p>\r\n                                    </div>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"similar-box\">\r\n                    <h2>Similiar products from Morgan Mobilya</h2>\r\n                    <div class=\"row cat-pd\">\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"small-box-c\">\r\n                                <div class=\"small-img-b\">\r\n                                    <img class=\"img-responsive\" src=\"images/tr1.png\" alt=\"#\">\r\n                                </div>\r\n                                <div class=\"dit-t clearfix\">\r\n                                    <div class=\"left-ti\">\r\n                                        <h4>Product</h4>\r\n                                        <p>By <span>Beko</span> under <span>Lights</span></p>\r\n                                    </div>\r\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\r\n                                </div>\r\n                                <div class=\"prod-btn\">\r\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\r\n                                    <p>23 likes</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"small-box-c\">\r\n                                <div class=\"small-img-b\">\r\n                                    <img class=\"img-responsive\" src=\"images/tr2.png\" alt=\"#\">\r\n                                </div>\r\n                                <div class=\"dit-t clearfix\">\r\n                                    <div class=\"left-ti\">\r\n                                        <h4>Product</h4>\r\n                                        <p>By <span>Beko</span> under <span>Chairs</span></p>\r\n                                    </div>\r\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\r\n                                </div>\r\n                                <div class=\"prod-btn\">\r\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\r\n                                    <p>23 likes</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row cat-pd\">\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"small-box-c\">\r\n                                <div class=\"small-img-b\">\r\n                                    <img class=\"img-responsive\" src=\"images/tr3.png\" alt=\"#\">\r\n                                </div>\r\n                                <div class=\"dit-t clearfix\">\r\n                                    <div class=\"left-ti\">\r\n                                        <h4>Product</h4>\r\n                                        <p>By <span>Beko</span> under <span>Lights</span></p>\r\n                                    </div>\r\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\r\n                                </div>\r\n                                <div class=\"prod-btn\">\r\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\r\n                                    <p>23 likes</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"small-box-c\">\r\n                                <div class=\"small-img-b\">\r\n                                    <img class=\"img-responsive\" src=\"images/tr4.png\" alt=\"#\">\r\n                                </div>\r\n                                <div class=\"dit-t clearfix\">\r\n                                    <div class=\"left-ti\">\r\n                                        <h4>Product</h4>\r\n                                        <p>By <span>Beko</span> under <span>Chairs</span></p>\r\n                                    </div>\r\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\r\n                                </div>\r\n                                <div class=\"prod-btn\">\r\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\r\n                                    <p>23 likes</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "col-md-3 col-sm-12");
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "price-box-right");
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.AddMarkupContent(55, "<h4>Price</h4>\r\n                    ");
            __builder.AddMarkupContent(56, "<h3>$1.320 <span>pr.peice</span></h3>\r\n                    ");
            __builder.AddMarkupContent(57, "<p>Option</p>\r\n                    ");
            __builder.OpenElement(58, "select");
            __builder.AddAttribute(59, "class", "form-control select2");
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "option");
            __builder.AddContent(62, "Flying Carpet Green rug");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", "AK");
            __builder.AddContent(66, "Alaska");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", "HI");
            __builder.AddContent(70, "Hawaii");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "option");
            __builder.AddAttribute(73, "value", "CA");
            __builder.AddContent(74, "California");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", "NV");
            __builder.AddContent(78, "Nevada");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", "OR");
            __builder.AddContent(82, "Oregon");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.OpenElement(84, "option");
            __builder.AddAttribute(85, "value", "WA");
            __builder.AddContent(86, "Washington");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                        ");
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", "AZ");
            __builder.AddContent(90, "Arizona");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        ");
            __builder.OpenElement(92, "option");
            __builder.AddAttribute(93, "value", "CO");
            __builder.AddContent(94, "Colorado");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.OpenElement(96, "option");
            __builder.AddAttribute(97, "value", "ID");
            __builder.AddContent(98, "Idaho");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                        ");
            __builder.OpenElement(100, "option");
            __builder.AddAttribute(101, "value", "MT");
            __builder.AddContent(102, "Montana");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                        ");
            __builder.OpenElement(104, "option");
            __builder.AddAttribute(105, "value", "NE");
            __builder.AddContent(106, "Nebraska");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                        ");
            __builder.OpenElement(108, "option");
            __builder.AddAttribute(109, "value", "NM");
            __builder.AddContent(110, "New Mexico");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.OpenElement(112, "option");
            __builder.AddAttribute(113, "value", "ND");
            __builder.AddContent(114, "North Dakota");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                        ");
            __builder.OpenElement(116, "option");
            __builder.AddAttribute(117, "value", "UT");
            __builder.AddContent(118, "Utah");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                        ");
            __builder.OpenElement(120, "option");
            __builder.AddAttribute(121, "value", "WY");
            __builder.AddContent(122, "Wyoming");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                        ");
            __builder.OpenElement(124, "option");
            __builder.AddAttribute(125, "value", "AL");
            __builder.AddContent(126, "Alabama");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                        ");
            __builder.OpenElement(128, "option");
            __builder.AddAttribute(129, "value", "AR");
            __builder.AddContent(130, "Arkansas");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                        ");
            __builder.OpenElement(132, "option");
            __builder.AddAttribute(133, "value", "IL");
            __builder.AddContent(134, "Illinois");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                        ");
            __builder.OpenElement(136, "option");
            __builder.AddAttribute(137, "value", "IA");
            __builder.AddContent(138, "Iowa");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                        ");
            __builder.OpenElement(140, "option");
            __builder.AddAttribute(141, "value", "KS");
            __builder.AddContent(142, "Kansas");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                        ");
            __builder.OpenElement(144, "option");
            __builder.AddAttribute(145, "value", "KY");
            __builder.AddContent(146, "Kentucky");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n                    ");
            __builder.AddMarkupContent(149, "<a href=\"#\">Contact company</a>\r\n                    ");
            __builder.AddMarkupContent(150, "<h5><i class=\"fa fa-clock-o\" aria-hidden=\"true\"></i> <strong>16 hours</strong> avg. responsive time</h5>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n");
=======
            ));
            __builder.AddAttribute(34, "image", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 169 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Productpage.razor"
                                                                    p.ImageAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ProductName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 169 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Productpage.razor"
                                                                                                  p.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "Price", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 169 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Productpage.razor"
                                                                                                                  p.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "Ratings", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 169 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Productpage.razor"
                                                                                                                                    123

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 170 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Productpage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
>>>>>>> c6a3433559cf7a6aa12f974f94a517290c265339
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 327 "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Productpage.razor"
      
    [Parameter]
    public int id { get; set; }
    Product p = new Product();
    protected async override Task OnInitializedAsync()
    {

        p = await svc.GetProductDetail(id);
        Console.WriteLine(p);
        await base.OnInitializedAsync();
    }
=======
#line 177 "E:\BIT\Semester-VI\EAD\Semester Project\Estore\Client\Pages\Productpage.razor"
              
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
        
>>>>>>> c6a3433559cf7a6aa12f974f94a517290c265339

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductServices svc { get; set; }
    }
}
#pragma warning restore 1591
