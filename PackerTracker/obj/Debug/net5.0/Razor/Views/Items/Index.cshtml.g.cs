#pragma checksum "/Users/curtisbrooks/Desktop/Epicodus/packertracker/PackerTracker/Views/Items/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64e5b3aad5078ab4221e7d30da8028a6f8f02c38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
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
#line 1 "/Users/curtisbrooks/Desktop/Epicodus/packertracker/PackerTracker/Views/Items/Index.cshtml"
using PackerTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64e5b3aad5078ab4221e7d30da8028a6f8f02c38", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Packing List</h1>\n");
#nullable restore
#line 4 "/Users/curtisbrooks/Desktop/Epicodus/packertracker/PackerTracker/Views/Items/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>There are no items in your list.</p>\n");
#nullable restore
#line 7 "/Users/curtisbrooks/Desktop/Epicodus/packertracker/PackerTracker/Views/Items/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul>\n");
#nullable restore
#line 9 "/Users/curtisbrooks/Desktop/Epicodus/packertracker/PackerTracker/Views/Items/Index.cshtml"
   foreach (Item item in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li><a");
            BeginWriteAttribute("href", " href=\'", 172, "\'", 194, 2);
            WriteAttributeValue("", 179, "/items/", 179, 7, true);
#nullable restore
#line 11 "/Users/curtisbrooks/Desktop/Epicodus/packertracker/PackerTracker/Views/Items/Index.cshtml"
WriteAttributeValue("", 186, item.Id, 186, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "/Users/curtisbrooks/Desktop/Epicodus/packertracker/PackerTracker/Views/Items/Index.cshtml"
                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 12 "/Users/curtisbrooks/Desktop/Epicodus/packertracker/PackerTracker/Views/Items/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n<a href=\"/items/new\">Add new item.</a>\n");
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
