#pragma checksum "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ccc696c42ca1a778aa56c69ff2e38aab4cde185"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Create), @"mvc.1.0.view", @"/Views/Items/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Create.cshtml", typeof(AspNetCore.Views_Items_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ccc696c42ca1a778aa56c69ff2e38aab4cde185", @"/Views/Items/Create.cshtml")]
    public class Views_Items_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 26, true);
            WriteLiteral("\n<h4>Add a new task</h4>\n\n");
            EndContext();
#line 9 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(115, 41, false);
#line 11 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\Create.cshtml"
Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(162, 43, false);
#line 12 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\Create.cshtml"
Write(Html.TextBoxFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(207, 73, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add new item\" class=\"btn btn-default\" />\n");
            EndContext();
#line 15 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\Create.cshtml"
}

#line default
#line hidden
            BeginContext(282, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(286, 42, false);
#line 16 "C:\Users\brook\desktop\many-to-many-to-many\ToDoList\Views\Items\Create.cshtml"
Write(Html.ActionLink("Show all items", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(328, 4, true);
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
