#pragma checksum "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73d08487bb62d80bfabe87eec94bbccf3b0b2fea"
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
    public class MeasureComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
   
    var offsetX = LineSpacing + (Measure.ShowClef ? (Size.Height / 3.5) : 0) +
        (Measure.ShowKey ? (Measure.KeySignature.NumberOfFlats > 0
            ? LineSpacing * Measure.KeySignature.NumberOfFlats
            : LineSpacing * Measure.KeySignature.NumberOfSharps) : 0) +
            (Measure.ShowTime ? (LineSpacing * 1.5) : 0);

    var noteSpacing = (Size.Width - offsetX) / (Measure.Pattern.Count() + 0.5);

    offsetX += noteSpacing / 2;

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "svg");
            __builder.AddAttribute(2, "style", "width:" + " " + (
#nullable restore
#line 12 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                        Size.Width

#line default
#line hidden
#nullable disable
            ) + ";" + " height:" + " " + (
#nullable restore
#line 12 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                             Size.Height

#line default
#line hidden
#nullable disable
            ) + ";" + " border:" + " 0px;" + "\r\n     " + (
#nullable restore
#line 13 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
       Transform != null ? $"transform: {Transform.ToString()};" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 14 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
         foreach (var rhythmUnit in Measure.Pattern)
        {
            if (rhythmUnit is Note note) 
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "                ");
            __builder.OpenComponent<NetNotes.RazorComponents.Library.NoteComponent>(5);
            __builder.AddAttribute(6, "Note", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NetNotes.Business.Elements.Note>(
#nullable restore
#line 18 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                     note

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "LineSpacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 18 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                        LineSpacing

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Offset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 18 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                                             offsetX

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 19 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
            }
            else if (rhythmUnit is Rest rest)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenComponent<NetNotes.RazorComponents.Library.RestComponent>(11);
            __builder.AddAttribute(12, "Rest", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NetNotes.Business.Elements.Rest>(
#nullable restore
#line 22 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                     rest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OffsetY", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 22 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                    StaffOffsetY

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 22 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                                           offsetX

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 22 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                                                             LineSpacing * 1.5

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 23 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
            }
            offsetX += noteSpacing;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
          offsetX = 0;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenComponent<NetNotes.RazorComponents.Library.StaffComponent>(18);
            __builder.AddAttribute(19, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Drawing.Size>(
#nullable restore
#line 28 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                              Size

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n\r\n");
#nullable restore
#line 30 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
         if (Measure.ShowClef)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "            ");
            __builder.OpenComponent<NetNotes.RazorComponents.Library.TrebleClefComponent>(22);
            __builder.AddAttribute(23, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Drawing.Size>(
#nullable restore
#line 32 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                       Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 32 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                      offsetX

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 33 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
            offsetX += Size.Height / 3.5;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
         if (Measure.ShowKey)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "            ");
            __builder.OpenComponent<NetNotes.RazorComponents.Library.KeySignatureComponent>(27);
            __builder.AddAttribute(28, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Drawing.Size>(
#nullable restore
#line 37 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                         Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "KeySignature", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NetNotes.Business.Elements.KeySignature>(
#nullable restore
#line 37 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                             Measure.KeySignature

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 38 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                            offsetX

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "Clef", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NetNotes.Business.Elements.Clef>(
#nullable restore
#line 38 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                           Measure.Clef

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 39 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"

            offsetX += Measure.KeySignature.NumberOfFlats > 0
            ? LineSpacing * Measure.KeySignature.NumberOfFlats
            : LineSpacing * Measure.KeySignature.NumberOfSharps;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
         if (Measure.ShowTime)
        {
            offsetX += LineSpacing * 0.5;

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "            ");
            __builder.OpenComponent<NetNotes.RazorComponents.Library.TimeSignatureComponent>(34);
            __builder.AddAttribute(35, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 47 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                            StaffOffsetY

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 47 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                                   LineSpacing * 4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "TimeSignature", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NetNotes.Business.Elements.TimeSignature>(
#nullable restore
#line 48 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                   Measure.TimeSignature

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 48 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                                                   offsetX

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 49 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "        ");
            __builder.OpenComponent<NetNotes.RazorComponents.Library.BarlineComponent>(41);
            __builder.AddAttribute(42, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 50 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                   Size.Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "OffsetY", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 50 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                        StaffOffsetY

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 50 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
                                                                               LineSpacing / 6

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\MeasureComponent.razor"
       
    [Parameter]
    public Measure Measure { get; set; }

    [Parameter]
    public Transform Transform { get; set; }

    [Parameter]
    public Size Size { get; set; }


    public double StaffOffsetY => Size.Height / 3;
    public double LineSpacing => StaffOffsetY / 4;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
