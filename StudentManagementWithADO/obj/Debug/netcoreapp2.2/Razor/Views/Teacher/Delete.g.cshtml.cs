#pragma checksum "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29bcd06e2e0d652d2835b5232f90d2b789e7454b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Delete), @"mvc.1.0.view", @"/Views/Teacher/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Delete.cshtml", typeof(AspNetCore.Views_Teacher_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29bcd06e2e0d652d2835b5232f90d2b789e7454b", @"/Views/Teacher/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bda7d1b4fa2122a170884a92e9113cb6a38eb45", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagementWithADO.Models.Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(92, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Teacher</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(270, 38, false);
#line 15 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(308, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(372, 34, false);
#line 18 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(406, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(469, 40, false);
#line 21 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(509, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(573, 36, false);
#line 24 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(609, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(672, 42, false);
#line 27 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Skills));

#line default
#line hidden
            EndContext();
            BeginContext(714, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(778, 38, false);
#line 30 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Skills));

#line default
#line hidden
            EndContext();
            BeginContext(816, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(879, 49, false);
#line 33 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalStudents));

#line default
#line hidden
            EndContext();
            BeginContext(928, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(992, 45, false);
#line 36 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalStudents));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1100, 42, false);
#line 39 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1206, 38, false);
#line 42 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1307, 43, false);
#line 45 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AddedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1412, 39, false);
#line 48 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AddedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1489, 298, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29bcd06e2e0d652d2835b5232f90d2b789e7454b10139", async() => {
                BeginContext(1515, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1598, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29bcd06e2e0d652d2835b5232f90d2b789e7454b10613", async() => {
                    BeginContext(1620, 12, true);
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
                BeginContext(1636, 11, true);
                WriteLiteral("\r\n         ");
                EndContext();
                BeginContext(1648, 52, false);
#line 55 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
    Write(Html.ActionLink("Edit", "Edit", new { id=Model.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(1700, 13, true);
                WriteLiteral(" |\r\n         ");
                EndContext();
                BeginContext(1714, 59, false);
#line 56 "C:\Users\Acer\source\repos\AspDotNetCoreWithEFCoreProjects\StudentManagementWithADO\Views\Teacher\Delete.cshtml"
    Write(Html.ActionLink("Details", "Details", new {  id=Model.Id }));

#line default
#line hidden
                EndContext();
                BeginContext(1773, 7, true);
                WriteLiteral(" \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1787, 10, true);
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
