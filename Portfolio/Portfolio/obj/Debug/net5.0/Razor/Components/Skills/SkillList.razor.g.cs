#pragma checksum "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Skills\SkillList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04bd4386f008ec6f0fd1cd70972598c5840a4a01"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio.Components.Skills
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
    public partial class SkillList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.Portfolio.Components.Skills.SkillList.TypeInference.CreateCascadingValue_0(__builder, 0, 1, 
#nullable restore
#line 1 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Skills\SkillList.razor"
                       nameof(TooltipText)

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 1 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Skills\SkillList.razor"
                                                   TooltipText

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.AddContent(4, 
#nullable restore
#line 2 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Skills\SkillList.razor"
     ChildContent

#line default
#line hidden
#nullable disable
                );
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Projekty\Portfolio\Portfolio\Portfolio\Components\Skills\SkillList.razor"
       
    [Parameter]
    public string TooltipText { get; set; }
    
    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Portfolio.Components.Skills.SkillList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
