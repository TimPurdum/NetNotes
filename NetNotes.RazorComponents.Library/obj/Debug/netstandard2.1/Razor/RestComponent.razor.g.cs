#pragma checksum "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccdd09ff5363137c9d6fda7879fa6accba4e3b5c"
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
    public partial class RestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
 switch (Rest.Duration.Name)
{
    case "Quarter": 
        scaleSize = Width * 0.03;

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "g");
            __builder.AddAttribute(2, "id", "layer1");
            __builder.AddAttribute(3, "transform", "translate(" + (
#nullable restore
#line 5 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
                                              OffsetX - (100 * scaleSize)

#line default
#line hidden
#nullable disable
            ) + "," + (
#nullable restore
#line 5 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
                                                                             (OffsetY * 1.75) - (500 * scaleSize)

#line default
#line hidden
#nullable disable
            ) + ")" + " scale(" + (
#nullable restore
#line 5 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
                                                                                                                            scaleSize

#line default
#line hidden
#nullable disable
            ) + "," + " " + (
#nullable restore
#line 5 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
                                                                                                                                          scaleSize

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddMarkupContent(4, @"
            <path d=""m 138.76116,462.5307 c -6.84377,8.15627 -10.26565,14.25001 -10.26562,18.28125 -3e-5,3.89063 3.25778,9.72656 9.77343,17.50781 l -2.03906,2.88282 c -3.28128,-1.92189 -6.09377,-2.88283 -8.4375,-2.88282 -3.04689,-10e-6 -4.57033,1.82811 -4.57031,5.48438 -2e-5,3.74998 1.66404,7.47654 4.99219,11.17969 l -1.82813,2.74218 c -9.23438,-6.84377 -13.85157,-12.93751 -13.85156,-18.28125 -1e-5,-2.71876 0.93749,-4.875 2.8125,-6.46875 1.73436,-1.5 3.98436,-2.25 6.75,-2.25 1.78123,0 3.74998,0.46875 5.90625,1.40625 l -14.13281,-18.77343 c 6.70311,-5.90624 10.05467,-11.24998 10.05468,-16.03125 -10e-6,-3.79685 -2.27345,-8.57809 -6.82031,-14.34375 l 5.625,0 16.03125,19.54687"" style=""font-size:144px;font-family:musica;-inkscape-font-specification:musica"" id=""path2829""></path>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 8 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
        break;
    case "Eighth":
        scaleSize = Width * 0.1;

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "g");
            __builder.AddAttribute(8, "id", "layer1");
            __builder.AddAttribute(9, "transform", "translate(" + (
#nullable restore
#line 11 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
                                              OffsetX - (526 * scaleSize)

#line default
#line hidden
#nullable disable
            ) + "," + (
#nullable restore
#line 11 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
                                                                             (OffsetY * 1.75) - (86 * scaleSize)

#line default
#line hidden
#nullable disable
            ) + ")" + " scale(" + (
#nullable restore
#line 11 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
                                                                                                                           scaleSize

#line default
#line hidden
#nullable disable
            ) + "," + " " + (
#nullable restore
#line 11 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
                                                                                                                                         scaleSize

#line default
#line hidden
#nullable disable
            ) + ")");
            __builder.AddMarkupContent(10, @"
            <path d=""M 531.098,74.847 C 530.578,74.945 530.18,75.304 530,75.8 C 529.961,75.96 529.961,75.999 529.961,76.218 C 529.961,76.519 529.98,76.679 530.121,76.917 C 530.32,77.316 530.738,77.636 531.215,77.753 C 531.715,77.894 532.551,77.773 533.508,77.456 L 533.746,77.374 L 532.57,80.624 L 531.414,83.87 C 531.414,83.87 531.453,83.89 531.516,83.933 C 531.633,84.011 531.832,84.07 531.973,84.07 C 532.211,84.07 532.512,83.933 532.551,83.812 C 532.551,83.773 533.109,81.878 533.785,79.628 L 534.98,75.503 L 534.941,75.445 C 534.844,75.324 534.645,75.285 534.523,75.382 C 534.484,75.421 534.422,75.503 534.383,75.562 C 534.203,75.863 533.746,76.398 533.508,76.597 C 533.289,76.777 533.168,76.796 532.969,76.718 C 532.789,76.62 532.73,76.519 532.609,75.98 C 532.492,75.445 532.352,75.202 532.051,75.003 C 531.773,74.824 531.414,74.765 531.098,74.847 z "" style=""fill:#000000;stroke:#000000"" id=""path130""></path>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 14 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
        break;
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\git\NoteSystem\NetNotes.RazorComponents.Library\RestComponent.razor"
       
    [Parameter]
    public Rest Rest { get; set; }

    [Parameter]
    public double OffsetX { get; set; }

    [Parameter]
    public double OffsetY { get; set; }

    [Parameter]
    public double Width { get; set; }

    private double scaleSize;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
