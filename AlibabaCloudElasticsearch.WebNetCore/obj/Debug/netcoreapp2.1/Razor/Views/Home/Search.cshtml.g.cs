#pragma checksum "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3e5756e6ab05aaa09bbcc67014d2bf887e8600d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Search.cshtml", typeof(AspNetCore.Views_Home_Search))]
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
#line 1 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\_ViewImports.cshtml"
using AlibabaCloudElasticsearch.WebNetCore;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\_ViewImports.cshtml"
using AlibabaCloudElasticsearch.WebNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3e5756e6ab05aaa09bbcc67014d2bf887e8600d", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"862b56dc603217d0c7ffb4b7757a64a4c0c3a3f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(70, 23, true);
            WriteLiteral("\r\n<h2>Search</h2>\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(123, 41, true);
            WriteLiteral("    <input type=\"hidden\" name=\"indexName\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 164, "\"", 188, 1);
#line 13 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
WriteAttributeValue("", 172, Model.IndexName, 172, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(189, 243, true);
            WriteLiteral(" />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <p>Query</p>\r\n        </div>\r\n        <div class=\"col-md-5\">\r\n            <input type=\"text\" name=\"query\" class=\"form-control\" />\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
            EndContext();
            BeginContext(434, 159, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-5\">\r\n            <input type=\"submit\" value=\"Search\" class=\"btn btn-success\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
}

#line default
#line hidden
            BeginContext(596, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
 if(Model.Respuesta.Any())
{

#line default
#line hidden
            BeginContext(629, 385, true);
            WriteLiteral(@"    <table class=""table table-striped"">
        <thead>
            <tr>
                <td>First name</td>
                <td>Last name</td>
                <td>Date of birth</td>
                <td>Company</td>
                <td>Department</td>
                <td>Role</td>
                <td>Years in role</td>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 46 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
             foreach(var document in Model.Respuesta)
            {

#line default
#line hidden
            BeginContext(1084, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1123, 18, false);
#line 49 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
               Write(document.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1141, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1169, 17, false);
#line 50 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
               Write(document.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1186, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1214, 20, false);
#line 51 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
               Write(document.DateOfBirth);

#line default
#line hidden
            EndContext();
            BeginContext(1234, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1262, 16, false);
#line 52 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
               Write(document.Company);

#line default
#line hidden
            EndContext();
            BeginContext(1278, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1306, 19, false);
#line 53 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
               Write(document.Department);

#line default
#line hidden
            EndContext();
            BeginContext(1325, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1353, 13, false);
#line 54 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
               Write(document.Role);

#line default
#line hidden
            EndContext();
            BeginContext(1366, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1394, 20, false);
#line 55 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
               Write(document.YearsInRole);

#line default
#line hidden
            EndContext();
            BeginContext(1414, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
            }

#line default
#line hidden
            BeginContext(1455, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 60 "C:\Users\Administrator\Desktop\ac_elasticsearch_demo\AlibabaCloudElasticsearch.WebNetCore\Views\Home\Search.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
