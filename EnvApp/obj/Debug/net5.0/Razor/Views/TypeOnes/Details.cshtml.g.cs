#pragma checksum "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f7ec71e3ceb7ec1f471a42ca5b1b3e74b7b37c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TypeOnes_Details), @"mvc.1.0.view", @"/Views/TypeOnes/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\_ViewImports.cshtml"
using EnvApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\_ViewImports.cshtml"
using EnvApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f7ec71e3ceb7ec1f471a42ca5b1b3e74b7b37c7", @"/Views/TypeOnes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e88e9c9ce3f1218968f08342347a163e8f28eb", @"/Views/_ViewImports.cshtml")]
    public class Views_TypeOnes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EnvApp.Models.DB.TypeOne>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TypeOne</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.State_ProjectID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.State_ProjectID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Federal_Project_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Federal_Project_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Route_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Route_Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.County));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Work_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Work_Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Coordinates));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Coordinates));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Project_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Project_Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Federal_Aid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Federal_Aid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CE_Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.CE_Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Amms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Amms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Activities_Agreement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Activities_Agreement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Arch_RE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Arch_RE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hist_RE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hist_RE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Arch_RE_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Arch_RE_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hist_RE_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hist_RE_Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Through_Lanes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Through_Lanes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Close_Road));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Close_Road));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ROW_Acquisition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.ROW_Acquisition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Access_Control));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Access_Control));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fifty_Year_Structure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fifty_Year_Structure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Agency_Coordination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Agency_Coordination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IPAC_Screening_Zone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.IPAC_Screening_Zone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 152 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Section_404_Permit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 155 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Section_404_Permit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 158 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ground_Disturbance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 161 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ground_Disturbance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 164 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Waterway));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 167 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Waterway));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 170 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Special_Use_Permit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 173 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Special_Use_Permit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 176 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Floodplain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 179 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Floodplain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 182 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prepared_By));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 185 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prepared_By));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 188 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Approved_By));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 191 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Approved_By));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 194 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Adduser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 197 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Adduser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 200 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date_Added));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 203 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date_Added));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f7ec71e3ceb7ec1f471a42ca5b1b3e74b7b37c724620", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 208 "C:\Users\e096752\Documents\Repos\ELCC\EnvApp\Views\TypeOnes\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f7ec71e3ceb7ec1f471a42ca5b1b3e74b7b37c726759", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EnvApp.Models.DB.TypeOne> Html { get; private set; }
    }
}
#pragma warning restore 1591
