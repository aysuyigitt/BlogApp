#pragma checksum "C:\Users\AYSU YİĞİT\Source\Repos\BlogApp\BlogApp\Views\Posts\List.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d500ff278cf64140a9cf3a9fc8b08bd40e58fec65250eb6042e44705c7c0ec15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_List), @"mvc.1.0.view", @"/Views/Posts/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\AYSU YİĞİT\Source\Repos\BlogApp\BlogApp\Views\_ViewImports.cshtml"
using BlogApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AYSU YİĞİT\Source\Repos\BlogApp\BlogApp\Views\_ViewImports.cshtml"
using BlogApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d500ff278cf64140a9cf3a9fc8b08bd40e58fec65250eb6042e44705c7c0ec15", @"/Views/Posts/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2a2107e3875ee376763b7a1d7ec3392a23aa5d4c6baccc027f02693d1979a127", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Posts_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12"">
        <h2>Post List</h2>
        <a href=""/posts/create"" class=""btn btn-success mb-3"">New Post</a>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th style=""width: 200px; text-align: center; vertical-align: middle;"">Image</th>
                    <th style=""text-align: left; vertical-align: middle;"">Title</th>
                    <th style=""text-align: center; vertical-align: middle;"">IsActive</th>
                    <th style=""width: 200px; text-align: center; vertical-align: middle;"">Settings</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 17 "C:\Users\AYSU YİĞİT\Source\Repos\BlogApp\BlogApp\Views\Posts\List.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td style=\"text-align: center; vertical-align: middle;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d500ff278cf64140a9cf3a9fc8b08bd40e58fec65250eb6042e44705c7c0ec155029", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 902, "~/img/", 902, 6, true);
#nullable restore
#line 21 "C:\Users\AYSU YİĞİT\Source\Repos\BlogApp\BlogApp\Views\Posts\List.cshtml"
AddHtmlAttributeValue("", 908, item.Image, 908, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td style=\"vertical-align: middle;\">");
#nullable restore
#line 23 "C:\Users\AYSU YİĞİT\Source\Repos\BlogApp\BlogApp\Views\Posts\List.cshtml"
                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align: center; vertical-align: middle;\">");
#nullable restore
#line 24 "C:\Users\AYSU YİĞİT\Source\Repos\BlogApp\BlogApp\Views\Posts\List.cshtml"
                                                                           Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align: center; vertical-align: middle;\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1270, "\"", 1301, 2);
            WriteAttributeValue("", 1277, "/posts/edit/", 1277, 12, true);
#nullable restore
#line 26 "C:\Users\AYSU YİĞİT\Source\Repos\BlogApp\BlogApp\Views\Posts\List.cshtml"
WriteAttributeValue("", 1289, item.PostId, 1289, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 29 "C:\Users\AYSU YİĞİT\Source\Repos\BlogApp\BlogApp\Views\Posts\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
