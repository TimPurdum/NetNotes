#pragma checksum "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "975f27543139785481d0516597c963c5a16321b7"
// <auto-generated/>
#pragma warning disable 1591
namespace NoteSystem.Ui.Blazor.Components
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
    public class MeasureComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
   
    var offsetX = LineSpacing + (Measure.ShowClef ? (Size.Height / 3.5) : 0) +
        (Measure.ShowKey ? (Measure.KeySignature.NumberOfFlats > 0
            ? LineSpacing * Measure.KeySignature.NumberOfFlats
            : LineSpacing * Measure.KeySignature.NumberOfSharps) : 0);

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "svg");
            __builder.AddAttribute(2, "style", "width:" + " " + (
#nullable restore
#line 7 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                        Size.Width

#line default
#line hidden
#nullable disable
            ) + ";" + " height:" + " " + (
#nullable restore
#line 7 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                                             Size.Height

#line default
#line hidden
#nullable disable
            ) + ";" + "\r\n     " + (
#nullable restore
#line 8 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
       Transform != null ? $"transform: {Transform.ToString()};" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 9 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
         foreach (var rhythmUnit in Measure.Pattern)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "            ");
            __builder.OpenComponent<NoteSystem.Ui.Blazor.Components.NoteComponent>(5);
            __builder.AddAttribute(6, "RhythmUnit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NoteSystem.Business.Elements.Interfaces.IRhythmUnit>(
#nullable restore
#line 11 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                                       rhythmUnit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "LineSpacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 11 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                                                                LineSpacing

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Offset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 11 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                                                                                     offsetX

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 12 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
            offsetX += LineSpacing * 2;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
          offsetX = 0;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenComponent<NoteSystem.Ui.Blazor.Components.StaffComponent>(11);
            __builder.AddAttribute(12, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Drawing.Size>(
#nullable restore
#line 16 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                              Size

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 17 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
         if (Measure.ShowClef)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "            ");
            __builder.OpenComponent<NoteSystem.Ui.Blazor.Components.TrebleClefComponent>(15);
            __builder.AddAttribute(16, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Drawing.Size>(
#nullable restore
#line 19 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                                       Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 19 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                                                      offsetX

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 20 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
            offsetX += Size.Height / 3.5;
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
         if (Measure.ShowKey)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "            ");
            __builder.OpenComponent<NoteSystem.Ui.Blazor.Components.KeySignatureComponent>(20);
            __builder.AddAttribute(21, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Drawing.Size>(
#nullable restore
#line 24 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                                         Size

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "KeySignature", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NoteSystem.Business.Elements.KeySignature>(
#nullable restore
#line 24 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                                                             Measure.KeySignature

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "OffsetX", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 25 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                                            offsetX

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Clef", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<NoteSystem.Business.Elements.Clef>(
#nullable restore
#line 25 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
                                                           Measure.Clef

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 26 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\git\NoteSystem\NoteSystem.Ui.Blazor\Components\MeasureComponent.razor"
       
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
