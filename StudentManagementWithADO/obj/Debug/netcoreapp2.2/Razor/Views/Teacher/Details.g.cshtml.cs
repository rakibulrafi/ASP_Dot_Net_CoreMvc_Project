#pragma checksum "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7033126452be9d805752076c7fefa6e70e89979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Details), @"mvc.1.0.view", @"/Views/Teacher/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Details.cshtml", typeof(AspNetCore.Views_Teacher_Details))]
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
#line 1 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\_ViewImports.cshtml"
using StudentManagementWithADO;

#line default
#line hidden
#line 2 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\_ViewImports.cshtml"
using StudentManagementWithADO.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7033126452be9d805752076c7fefa6e70e89979", @"/Views/Teacher/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bda7d1b4fa2122a170884a92e9113cb6a38eb45", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagementWithADO.Models.Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Teacher</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(224, 38, false);
#line 14 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(262, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(326, 34, false);
#line 17 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(360, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(423, 40, false);
#line 20 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(463, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(527, 36, false);
#line 23 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(563, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(626, 42, false);
#line 26 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Skills));

#line default
#line hidden
            EndContext();
            BeginContext(668, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(732, 38, false);
#line 29 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayFor(model => model.Skills));

#line default
#line hidden
            EndContext();
            BeginContext(770, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(833, 49, false);
#line 32 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalStudents));

#line default
#line hidden
            EndContext();
            BeginContext(882, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(946, 45, false);
#line 35 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalStudents));

#line default
#line hidden
            EndContext();
            BeginContext(991, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1054, 42, false);
#line 38 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1160, 38, false);
#line 41 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1261, 43, false);
#line 44 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1368, 39, false);
#line 47 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1455, 54, false);
#line 52 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1518, 58, false);
#line 53 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Details.cshtml"
Write(Html.ActionLink("Delete", "Delete", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 13, true);
            WriteLiteral(" |\r\n   \r\n    ");
            EndContext();
            BeginContext(1589, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7033126452be9d805752076c7fefa6e70e8997910353", async() => {
                BeginContext(1611, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1627, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManagementWithADO.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
