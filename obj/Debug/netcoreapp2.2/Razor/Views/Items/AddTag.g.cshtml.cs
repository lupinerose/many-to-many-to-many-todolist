#pragma checksum "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\AddTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15438a3ffed4846a4b186aee0049d39387fea766"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_AddTag), @"mvc.1.0.view", @"/Views/Items/AddTag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/AddTag.cshtml", typeof(AspNetCore.Views_Items_AddTag))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15438a3ffed4846a4b186aee0049d39387fea766", @"/Views/Items/AddTag.cshtml")]
    public class Views_Items_AddTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\AddTag.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 49, true);
            WriteLiteral("\n<h2>Add a tag</h2>\n\n<h4>Add a tag to this task: ");
            EndContext();
            BeginContext(106, 43, false);
#line 9 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\AddTag.cshtml"
                       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(149, 7, true);
            WriteLiteral("</h4>\n\n");
            EndContext();
#line 11 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\AddTag.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(189, 37, false);
#line 13 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\AddTag.cshtml"
Write(Html.HiddenFor(model => model.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(233, 29, false);
#line 15 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\AddTag.cshtml"
Write(Html.Label("Select category"));

#line default
#line hidden
            EndContext();
            BeginContext(268, 26, false);
#line 16 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\AddTag.cshtml"
Write(Html.DropDownList("TagId"));

#line default
#line hidden
            EndContext();
            BeginContext(296, 41, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
            EndContext();
#line 19 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\AddTag.cshtml"
}

#line default
#line hidden
            BeginContext(339, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(344, 40, false);
#line 21 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\AddTag.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(384, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
