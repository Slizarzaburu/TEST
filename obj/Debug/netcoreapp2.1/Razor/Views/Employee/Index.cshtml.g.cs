#pragma checksum "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4ec61cf6a6016a2424e30bfab8ee7dfd0705b97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ec61cf6a6016a2424e30bfab8ee7dfd0705b97", @"/Views/Employee/Index.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WEB_LIZARZABURU.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(109, 2066, true);
            WriteLiteral(@"<div class=""card card-outline-info"">
    <div class=""card-header"">
        <h4 class=""mb-0 text-white""></h4>
    </div>
    <div class=""card-body"">
        <div class=""row page-titles"">
            <div class=""col-md-6 col-8 align-self-center"">
                <h3 class=""text-themecolor mb-0 mt-0"">MasGlobalTEST</h3>
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a>Employess</a></li>
                    <li class=""breadcrumb-item active"">List</li>
                </ol>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-body"">
                <div class=""accordion"" id=""accordionTable"">
                    <div class=""card m-b-5"">
                        <div id=""col1"" class=""collapse show"" aria-labelledby=""heading1"" data-parent=""#accordionTable"">
                            <div class=""card-body"">
                                <div class=""table-responsive"">
                                    <table id=""demo-");
            WriteLiteral(@"foo-accordion"" class=""table table-bordered m-b-0 toggle-arrow-tiny table-hover"" data-filtering=""true"" data-cascade=""true"" data-sorting=""true"" data-toggle-column=""last"" data-paging=""true"" data-paging-size=""6"">
                                        <thead>
                                            <tr class=""footable-filtering"">
                                                <th data-toggle=""true""> ID </th>
                                                <th> First Name </th>
                                                <th> Last Name </th>
                                                <th> Identification </th>
                                                <th> Phone Number </th>
                                                <th> Occupation </th>
                                                <th> Ver </th>
                                                
                                            </tr>
                                        </thead>
                               ");
            WriteLiteral("         <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
            BeginContext(2296, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(2399, 7, false);
#line 44 "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml"
                                               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2406, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2466, 14, false);
#line 45 "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml"
                                               Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2480, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2540, 13, false);
#line 46 "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml"
                                               Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2553, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2613, 19, false);
#line 47 "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml"
                                               Write(item.Identification);

#line default
#line hidden
            EndContext();
            BeginContext(2632, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2692, 16, false);
#line 48 "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml"
                                               Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2708, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2768, 15, false);
#line 49 "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml"
                                               Write(item.Occupation);

#line default
#line hidden
            EndContext();
            BeginContext(2783, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2843, 124, false);
#line 50 "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml"
                                               Write(Html.ActionLink("Ver", "InformationDetail", new { idEmployee = item.Id }, new { @class = "btn-sm btn-rounded btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(2967, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\skynet\Desktop\TEST_LIZARZABURU_STEVEN\WEB_LIZARZABURU\Views\Employee\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3072, 352, true);
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>




















");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WEB_LIZARZABURU.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591