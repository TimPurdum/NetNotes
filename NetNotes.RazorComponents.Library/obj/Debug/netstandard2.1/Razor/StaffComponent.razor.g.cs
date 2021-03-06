#pragma checksum "C:\git\NoteSystem\NetNotes.RazorComponents.Library\StaffComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7251da9d720e15cb9f06374eae6d597a8a685aaf"
// <auto-generated/>
#pragma warning disable 1591
namespace NetNotes.RazorComponents.Library
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using NetNotes.RazorComponents.Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using NetNotes.Business.Elements;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using NetNotes.Business.Elements.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
    public partial class StaffComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\StaffComponent.razor"
 for (var i = 0; i < LineCount; i++)
{
    var y = StaffOffsetY + (LineSpacing * i);

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "line");
            __builder.AddAttribute(2, "x1", "0");
            __builder.AddAttribute(3, "y1", 
#nullable restore
#line 4 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\StaffComponent.razor"
                      y

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "x2", 
#nullable restore
#line 4 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\StaffComponent.razor"
                              Size.Width

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "y2", 
#nullable restore
#line 4 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\StaffComponent.razor"
                                               y

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "style", "stroke:black;stroke-width:" + (
#nullable restore
#line 5 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\StaffComponent.razor"
                                             LineThickness > 1 ? LineThickness : 1

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 6 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\StaffComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\StaffComponent.razor"
       
    [Parameter]
    public Size Size { get; set; }

    [Parameter]
    public int LineCount { get; set; } = 5;

    public double StaffOffsetY => Size.Height / 3.0;
    public double LineSpacing => StaffOffsetY / 4;
    public double LineThickness => Size.Height / 200.0;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
