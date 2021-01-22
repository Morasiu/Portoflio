#pragma checksum "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "152ec8a534ce048a714fe26caeb997b97e40cdb4"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio.Components.Projects
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio.Components.Projects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
    public partial class ProjectLink : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor"
 if (!string.IsNullOrWhiteSpace(Link)) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazorise.Row>(0);
            __builder.AddAttribute(1, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 2 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor"
                 Margin.Is3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Class", "text-center");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Column>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(6, "a");
                    __builder3.AddAttribute(7, "href", 
#nullable restore
#line 4 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor"
                      Link

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 5 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor"
                 if (Link.Contains("github")) {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Blazorise.Button>(8);
                    __builder3.AddAttribute(9, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 6 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor"
                                   Color.Dark

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(11, "<i class=\"fab fa-github\"></i> Github\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 9 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor"
                }
                else {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Blazorise.Button>(12);
                    __builder3.AddAttribute(13, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 11 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor"
                                   Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(15, "\r\n                        Link\r\n                    ");
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 14 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 18 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Projects\ProjectLink.razor"
       

    [Parameter]
    public string Link { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
