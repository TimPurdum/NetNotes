#pragma checksum "C:\git\NoteSystem\NetNotes.RazorComponents.Library\StaffComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7251da9d720e15cb9f06374eae6d597a8a685aaf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NetNotes.RazorComponents.Library
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using NetNotes.Ui.Blazor;

#line default
#line hidden
#line 9 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using NetNotes.Ui.Blazor.Shared;

#line default
#line hidden
#line 10 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using NetNotes.RazorComponents.Library;

#line default
#line hidden
#line 11 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using NetNotes.Business.Elements;

#line default
#line hidden
#line 12 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using NetNotes.Business.Elements.Interfaces;

#line default
#line hidden
#line 13 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\_Imports.razor"
using System.Drawing;

#line default
#line hidden
    public class StaffComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
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
    }
}
#pragma warning restore 1591
