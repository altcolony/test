#pragma checksum "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7db4321db85dec3b50cbdd117f68b925c0ad60aa"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppTest.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\_Imports.razor"
using BlazorAppTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\_Imports.razor"
using BlazorAppTest.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<BlazorAppTest.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __Blazor.BlazorAppTest.Shared.MainLayout.TypeInference.CreateCascadingValue_0(__builder, 10, 11, 
#nullable restore
#line 12 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\Shared\MainLayout.razor"
                            siteName

#line default
#line hidden
#nullable disable
            , 12, "siteName", 13, (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "h1");
                __builder2.AddContent(18, 
#nullable restore
#line 14 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\Shared\MainLayout.razor"
                 siteName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddContent(20, 
#nullable restore
#line 15 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\Shared\MainLayout.razor"
      
    string siteName = "Our Super Website";

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorAppTest.Shared.MainLayout
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
