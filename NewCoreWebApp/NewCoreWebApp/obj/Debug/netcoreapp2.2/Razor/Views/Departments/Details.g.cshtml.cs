#pragma checksum "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca6703f2491dbd5e508c013fe655d9dafe11cd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_Details), @"mvc.1.0.view", @"/Views/Departments/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departments/Details.cshtml", typeof(AspNetCore.Views_Departments_Details))]
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
#line 1 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\_ViewImports.cshtml"
using NewCoreWebApp;

#line default
#line hidden
#line 2 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\_ViewImports.cshtml"
using NewCoreWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca6703f2491dbd5e508c013fe655d9dafe11cd5", @"/Views/Departments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2146949c854a5f613b1bf3079888a287ecdd0a63", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewCoreWebApp.Models.EmployeeModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(101, 252, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js\"></script>\r\n<script src=\'https://kit.fontawesome.com/a076d05399.js\'></script>\r\n");
            EndContext();
            BeginContext(353, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ca6703f2491dbd5e508c013fe655d9dafe11cd55092", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(405, 217, true);
            WriteLiteral("\r\n<div>\r\n    <h4>ListWise Department</h4>\r\n    <hr />\r\n\r\n    <table class=\"table table-condensed table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"row\">\r\n\r\n                    ");
            EndContext();
            BeginContext(623, 40, false);
#line 20 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(663, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(731, 39, false);
#line 23 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(770, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(838, 41, false);
#line 26 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(879, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(947, 41, false);
#line 29 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(988, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1056, 43, false);
#line 32 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1099, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1167, 41, false);
#line 35 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1276, 40, false);
#line 38 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1316, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1384, 39, false);
#line 41 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1491, 47, false);
#line 44 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.JoiningDate));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1606, 50, false);
#line 47 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.DepartmentName));

#line default
#line hidden
            EndContext();
            BeginContext(1656, 79, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1792, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1865, 39, false);
#line 56 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1904, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1984, 38, false);
#line 59 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Dob));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2102, 40, false);
#line 62 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2142, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2222, 40, false);
#line 65 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2262, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2342, 42, false);
#line 68 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2384, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2464, 40, false);
#line 71 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.State));

#line default
#line hidden
            EndContext();
            BeginContext(2504, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2584, 39, false);
#line 74 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(2623, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2703, 38, false);
#line 77 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(2741, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2821, 46, false);
#line 80 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.JoiningDate));

#line default
#line hidden
            EndContext();
            BeginContext(2867, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2947, 49, false);
#line 83 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DepartmentName));

#line default
#line hidden
            EndContext();
            BeginContext(2996, 72, true);
            WriteLiteral("\r\n                    </td>\r\n                  \r\n                </tr>\r\n");
            EndContext();
#line 87 "C:\Users\vishalg\Documents\Visual Studio 2017\Projects\NewCoreWebApp\NewCoreWebApp\Views\Departments\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(3083, 55, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n<div>\r\n\r\n    ");
            EndContext();
            BeginContext(3138, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ca6703f2491dbd5e508c013fe655d9dafe11cd516894", async() => {
                BeginContext(3160, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3176, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewCoreWebApp.Models.EmployeeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591