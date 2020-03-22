#pragma checksum "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f31723f49af3b183f8c0539a090409d81b3dd55"
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
    public partial class NoteComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "svg");
            __builder.AddAttribute(1, "x", 
#nullable restore
#line 1 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
         Offset

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "y", 
#nullable restore
#line 1 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
                     VerticalNotePosition()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "width", 
#nullable restore
#line 1 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
                                                      LineSpacing * 4

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "height", 
#nullable restore
#line 1 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
                                                                                  LineSpacing * 8

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 2 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
     if (Note.Duration.CommonTimeBeatLength < 4)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenComponent<NetNotes.RazorComponents.Library.NoteStemComponent>(7);
            __builder.AddAttribute(8, "Transform", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
                                       StemTransform()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 4 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
                                                                  LineSpacing * 3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 4 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
                                                                                             LineSpacing / 5

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 5 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
     if (Note.Beams.Any())
    {
        // BUILD BEAMS
    }
    else if (Note.Duration.Flags > 0)
    {
        for (var i = 0; i < Note.Duration.Flags; i++)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "            ");
            __builder.OpenComponent<NetNotes.RazorComponents.Library.FlagComponent>(13);
            __builder.AddAttribute(14, "Transform", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
                                       FlagTransform(i)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 15 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "    ");
            __builder.OpenComponent<NetNotes.RazorComponents.Library.NoteHeadComponent>(17);
            __builder.AddAttribute(18, "Transform", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
                                   HeadTransform()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "NoteHead", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NetNotes.Business.Elements.NoteHead>(
#nullable restore
#line 18 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
                                 GetNoteHead()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\NoteComponent.razor"
       
    [Parameter]
    public Note Note { get; set; }

    [Parameter]
    public double Offset { get; set; }

    [Parameter]
    public double LineSpacing { get; set; }

    public string StemTransform()
    {
        if (Note.Pitch.HasValue && Note.Pitch.Value.StaffLocation < 6)
        {
            return $"translate({LineSpacing * 1.43}px, 0)";
        }
        var stemWidth = LineSpacing / 5;
        stemWidth = stemWidth > 1 ? stemWidth : 1;
        return $"translate({stemWidth * 1.2}px, {LineSpacing * 3.1}px)";
    }

    public string HeadTransform()
    {
        return $"translate(0, {LineSpacing * 2.85}px) scale({0.009 * LineSpacing}, {0.009 * LineSpacing})";
    }

    public string FlagTransform(int index)
    {
        if (Note.Pitch.HasValue && Note.Pitch.Value.StaffLocation < 6)
        {
            // right-side up
            return $"translate(-{LineSpacing * 9.3}px, -{LineSpacing * 9.4}px) scale({0.04 * LineSpacing}, {0.04 * LineSpacing})";
        }
        // up-side down
        return $"translate(-{LineSpacing * 10.5}px, {LineSpacing * 15.58}px) scale({0.04 * LineSpacing}, -{0.04 * LineSpacing})";
    }

    public double VerticalNotePosition()
    {
        var pitchValue = Note.Pitch.HasValue ? Note.Pitch.Value : Pitches.B4;
        return (LineSpacing * 5.9) - (pitchValue.StaffLocation * (LineSpacing / 2));
    }

    public NoteHead GetNoteHead()
    {
        if (Note.Duration.CommonTimeBeatLength >= 2.0)
        {
            return new NoteHead(NoteHeadShape.OpenOval);
        }

        return new NoteHead(NoteHeadShape.ClosedOval);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
