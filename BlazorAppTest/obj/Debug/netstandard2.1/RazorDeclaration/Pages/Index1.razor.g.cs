#pragma checksum "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\Pages\Index1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5361f6c390f6ca0d9bf0443717c20ad103491be7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppTest.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/dhello")]
    public partial class Index1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\altco\source\repos\BlazorAppTest\BlazorAppTest\Pages\Index1.razor"
      
    string message = "Another Hello World!";
    bool active = false;
    void RotateToStop()
    {
        active = false;
    }
    async void RotateMessage()
    {
        active = true;

        for(; ; )
        {
            message = message.Substring(1) + message.Substring(0, 1);
            this.StateHasChanged();
            await Task.Delay(500);
            if (!active) { break; }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
