#pragma checksum "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5dd696a5f00b345a04803351dd70ad55c9e8e79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\_ViewImports.cshtml"
using RSOILab1;

#line default
#line hidden
#line 2 "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\_ViewImports.cshtml"
using RSOILab1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5dd696a5f00b345a04803351dd70ad55c9e8e79", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b20db8b65727afc853c7b52192a17f6618789972", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    string name;
    int?[] nums;

    if (ViewBag.name != null)
    {
        name = ViewBag.name;
    }
    else
    {
        name = "defaultuser";
    }

#line default
#line hidden
            BeginContext(213, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(218, 17, false);
#line 15 "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\Home\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(235, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(247, 19, false);
#line 16 "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\Home\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(266, 26, true);
            WriteLiteral("</h3>\r\n\r\n<p>Здравствуйте, ");
            EndContext();
            BeginContext(293, 4, false);
#line 18 "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\Home\Index.cshtml"
            Write(name);

#line default
#line hidden
            EndContext();
            BeginContext(297, 17, true);
            WriteLiteral("! Текущее время: ");
            EndContext();
            BeginContext(315, 30, false);
#line 18 "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\Home\Index.cshtml"
                                  Write(DateTime.Now.ToString("HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(345, 9, true);
            WriteLiteral(".</p>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\Home\Index.cshtml"
    
    nums = ViewBag.nums;
    if (nums.Length != 0)
    {

#line default
#line hidden
            BeginContext(420, 41, true);
            WriteLiteral("        <p>Сумма элементов массива равна ");
            EndContext();
            BeginContext(462, 10, false);
#line 24 "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\Home\Index.cshtml"
                                    Write(nums.Sum());

#line default
#line hidden
            EndContext();
            BeginContext(472, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 25 "C:\Users\cappy\source\repos\RSOILab1\RSOILab1\Views\Home\Index.cshtml"
    }
 

#line default
#line hidden
            BeginContext(489, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591