#pragma checksum "C:\Users\usama riasat\Documents\6th Semester\EAD\Semester Project\Git Clone\Estore\Client\Pages\Productpage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed7758c565566e877c2d0c26ffc3a3530002e701"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductPage")]
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
            __builder.AddAttribute(11, "class", "row");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, @"<div class=""col-md-2 col-sm-4"">
                <div class=""left-profile-box-m prod-page"">
                    <div class=""pro-img"">
                        <img src=""images/150x150.png"" alt=""#"">
                    </div>
                    <div class=""pof-text"">
                        <h3>Morgan Mobilya</h3>
                        <div class=""check-box""></div>
                    </div>
                    <a href=""#"">Visit store</a>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(14, "<div class=\"col-md-7 col-sm-8\">\r\n                <div class=\"md-prod-page\">\r\n                    <div class=\"md-prod-page-in\">\r\n                        <div class=\"page-preview\">\r\n                            <div class=\"preview\">\r\n                                <div class=\"preview-pic tab-content\">\r\n                                    <div class=\"tab-pane active\" id=\"pic-1\"><img src=\"images/lag-60.png\" alt=\"#\"></div>\r\n                                    <div class=\"tab-pane\" id=\"pic-2\"><img src=\"images/lag-61.png\" alt=\"#\"></div>\r\n                                    <div class=\"tab-pane\" id=\"pic-3\"><img src=\"images/lag-60.png\" alt=\"#\"></div>\r\n                                    <div class=\"tab-pane\" id=\"pic-4\"><img src=\"images/lag-61.png\" alt=\"#\"></div>\r\n                                </div>\r\n                                <ul class=\"preview-thumbnail nav nav-tabs\">\r\n                                    <li class=\"active\"><a data-target=\"#pic-1\" data-toggle=\"tab\"><img src=\"images/lag-60.png\" alt=\"#\"></a></li>\r\n                                    <li><a data-target=\"#pic-2\" data-toggle=\"tab\"><img src=\"images/lag-61.png\" alt=\"#\"></a></li>\r\n                                    <li><a data-target=\"#pic-3\" data-toggle=\"tab\"><img src=\"images/lag-60.png\" alt=\"#\"></a></li>\r\n                                    <li><a data-target=\"#pic-4\" data-toggle=\"tab\"><img src=\"images/lag-61.png\" alt=\"#\"></a></li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"btn-dit-list clearfix\">\r\n                            <div class=\"left-dit-p\">\r\n                                <div class=\"prod-btn\">\r\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\r\n                                    <p>23 likes</p>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"right-dit-p\">\r\n                                <div class=\"like-list\">\r\n                                    <ul>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img class src=\"images/list-img-01.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img src=\"images/list-img-02.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img src=\"images/list-img-03.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img src=\"images/list-img-04.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img src=\"images/list-img-05.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><img src=\"images/list-img-06.png\" alt></div>\r\n                                        </li>\r\n                                        <li>\r\n                                            <div class=\"im-b\"><i class=\"fa fa-ellipsis-h\" aria-hidden=\"true\"></i></div>\r\n                                        </li>\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"description-box\">\r\n                        <div class=\"dex-a\">\r\n                            <h4>Description</h4>\r\n                            <p>\r\n                                Lorem Ipsum is simply dummy text of the printing and typesetting industry.\r\n                                lorem Ipsum has been the industry\'s standard dummy text ever since the 1500s,\r\n                                when an unknown printer took a galley of type and scrambled it to make a\r\n                                type specimen book..\r\n                            </p>\r\n                            <br>\r\n                            <p>Small: H 25 cm / &Oslash; 12 cm</p>\r\n                            <p>Large H 24 cm / &Oslash; 25 cm</p>\r\n                        </div>\r\n                        <div class=\"spe-a\">\r\n                            <h4>Specifications</h4>\r\n                            <ul>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Measurments</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>H25 cm / 0 12 cm and H 24 cm / 0 25 cm</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Material</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>Material Name</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Wire</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>Wire Name</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Comdition</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>Brand new</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>SKU number</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>SKU number</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Shipping</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>Shipping worldwide</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Warranty</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>1 years</p>\r\n                                    </div>\r\n                                </li>\r\n                                <li class=\"clearfix\">\r\n                                    <div class=\"col-md-4\">\r\n                                        <h5>Delivery</h5>\r\n                                    </div>\r\n                                    <div class=\"col-md-8\">\r\n                                        <p>Choose country</p>\r\n                                    </div>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"similar-box\">\r\n                    <h2>Similiar products from Morgan Mobilya</h2>\r\n                    <div class=\"row cat-pd\">\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"small-box-c\">\r\n                                <div class=\"small-img-b\">\r\n                                    <img class=\"img-responsive\" src=\"images/tr1.png\" alt=\"#\">\r\n                                </div>\r\n                                <div class=\"dit-t clearfix\">\r\n                                    <div class=\"left-ti\">\r\n                                        <h4>Product</h4>\r\n                                        <p>By <span>Beko</span> under <span>Lights</span></p>\r\n                                    </div>\r\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\r\n                                </div>\r\n                                <div class=\"prod-btn\">\r\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\r\n                                    <p>23 likes</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"small-box-c\">\r\n                                <div class=\"small-img-b\">\r\n                                    <img class=\"img-responsive\" src=\"images/tr2.png\" alt=\"#\">\r\n                                </div>\r\n                                <div class=\"dit-t clearfix\">\r\n                                    <div class=\"left-ti\">\r\n                                        <h4>Product</h4>\r\n                                        <p>By <span>Beko</span> under <span>Chairs</span></p>\r\n                                    </div>\r\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\r\n                                </div>\r\n                                <div class=\"prod-btn\">\r\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\r\n                                    <p>23 likes</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"row cat-pd\">\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"small-box-c\">\r\n                                <div class=\"small-img-b\">\r\n                                    <img class=\"img-responsive\" src=\"images/tr3.png\" alt=\"#\">\r\n                                </div>\r\n                                <div class=\"dit-t clearfix\">\r\n                                    <div class=\"left-ti\">\r\n                                        <h4>Product</h4>\r\n                                        <p>By <span>Beko</span> under <span>Lights</span></p>\r\n                                    </div>\r\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\r\n                                </div>\r\n                                <div class=\"prod-btn\">\r\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\r\n                                    <p>23 likes</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <div class=\"small-box-c\">\r\n                                <div class=\"small-img-b\">\r\n                                    <img class=\"img-responsive\" src=\"images/tr4.png\" alt=\"#\">\r\n                                </div>\r\n                                <div class=\"dit-t clearfix\">\r\n                                    <div class=\"left-ti\">\r\n                                        <h4>Product</h4>\r\n                                        <p>By <span>Beko</span> under <span>Chairs</span></p>\r\n                                    </div>\r\n                                    <a href=\"#\" tabindex=\"0\">$1220</a>\r\n                                </div>\r\n                                <div class=\"prod-btn\">\r\n                                    <a href=\"#\"><i class=\"fa fa-star\" aria-hidden=\"true\"></i> Save to wishlist</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-up\" aria-hidden=\"true\"></i> Like this</a>\r\n                                    <p>23 likes</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-md-3 col-sm-12");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "price-box-right");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.AddMarkupContent(21, "<h4>Price</h4>\r\n                    ");
            __builder.AddMarkupContent(22, "<h3>$1.320 <span>pr.peice</span></h3>\r\n                    ");
            __builder.AddMarkupContent(23, "<p>Option</p>\r\n                    ");
            __builder.OpenElement(24, "select");
            __builder.AddAttribute(25, "class", "form-control select2");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "option");
            __builder.AddContent(28, "Flying Carpet Green rug");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "AK");
            __builder.AddContent(32, "Alaska");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "HI");
            __builder.AddContent(36, "Hawaii");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "CA");
            __builder.AddContent(40, "California");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "NV");
            __builder.AddContent(44, "Nevada");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "OR");
            __builder.AddContent(48, "Oregon");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "value", "WA");
            __builder.AddContent(52, "Washington");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "option");
            __builder.AddAttribute(55, "value", "AZ");
            __builder.AddContent(56, "Arizona");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", "CO");
            __builder.AddContent(60, "Colorado");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "option");
            __builder.AddAttribute(63, "value", "ID");
            __builder.AddContent(64, "Idaho");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", "MT");
            __builder.AddContent(68, "Montana");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "NE");
            __builder.AddContent(72, "Nebraska");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "NM");
            __builder.AddContent(76, "New Mexico");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        ");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", "ND");
            __builder.AddContent(80, "North Dakota");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "option");
            __builder.AddAttribute(83, "value", "UT");
            __builder.AddContent(84, "Utah");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.OpenElement(86, "option");
            __builder.AddAttribute(87, "value", "WY");
            __builder.AddContent(88, "Wyoming");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                        ");
            __builder.OpenElement(90, "option");
            __builder.AddAttribute(91, "value", "AL");
            __builder.AddContent(92, "Alabama");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                        ");
            __builder.OpenElement(94, "option");
            __builder.AddAttribute(95, "value", "AR");
            __builder.AddContent(96, "Arkansas");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                        ");
            __builder.OpenElement(98, "option");
            __builder.AddAttribute(99, "value", "IL");
            __builder.AddContent(100, "Illinois");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.OpenElement(102, "option");
            __builder.AddAttribute(103, "value", "IA");
            __builder.AddContent(104, "Iowa");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                        ");
            __builder.OpenElement(106, "option");
            __builder.AddAttribute(107, "value", "KS");
            __builder.AddContent(108, "Kansas");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                        ");
            __builder.OpenElement(110, "option");
            __builder.AddAttribute(111, "value", "KY");
            __builder.AddContent(112, "Kentucky");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.AddMarkupContent(115, "<a href=\"#\">Contact company</a>\r\n                    ");
            __builder.AddMarkupContent(116, "<h5><i class=\"fa fa-clock-o\" aria-hidden=\"true\"></i> <strong>16 hours</strong> avg. responsive time</h5>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\r\n}");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductServices svc { get; set; }
    }
}
#pragma warning restore 1591
