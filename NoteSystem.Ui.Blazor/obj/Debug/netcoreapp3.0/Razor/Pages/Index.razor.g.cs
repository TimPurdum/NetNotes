#pragma checksum "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "395eaf129e4e35f1b4bc84d80523bde741a30a32"
// <auto-generated/>
#pragma warning disable 1591
namespace NoteSystem.Ui.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using NoteSystem.Ui.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using NoteSystem.Ui.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using NoteSystem.Ui.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using NoteSystem.Business.Elements;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using NoteSystem.Business.Elements.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "border: 1px solid pink");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 8 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Pages\Index.razor"
      
        var ms = new Measure(Clefs.Treble, TimeSignatures._4_4, KeySignatures.GFlatMajor, "A/4, G/4, F/4, F/4")
        {
            ShowClef = true,
            ShowKey = true
        };
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenComponent<NoteSystem.Ui.Blazor.Components.MeasureComponent>(5);
            __builder.AddAttribute(6, "Measure", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NoteSystem.Business.Elements.Measure>(
#nullable restore
#line 15 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Pages\Index.razor"
                               ms

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Drawing.Size>(
#nullable restore
#line 15 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Pages\Index.razor"
                                         new Size(400, 100)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<NoteSystem.Ui.Blazor.Components.MeasureComponent>(9);
            __builder.AddAttribute(10, "Measure", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NoteSystem.Business.Elements.Measure>(
#nullable restore
#line 16 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Pages\Index.razor"
                               ms

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Drawing.Size>(
#nullable restore
#line 16 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Pages\Index.razor"
                                         new Size(400, 200)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenComponent<NoteSystem.Ui.Blazor.Components.MeasureComponent>(13);
            __builder.AddAttribute(14, "Measure", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NoteSystem.Business.Elements.Measure>(
#nullable restore
#line 17 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Pages\Index.razor"
                               ms

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Drawing.Size>(
#nullable restore
#line 17 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Pages\Index.razor"
                                         new Size(600, 400)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
