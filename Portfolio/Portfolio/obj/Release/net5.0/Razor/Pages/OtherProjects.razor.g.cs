#pragma checksum "D:\Projekty\Portfolio\Portfolio\Portfolio\Pages\OtherProjects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bdf6b3e4e8ea7a0996645965160be1dc35cada4"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Projects/Other")]
    public partial class OtherProjects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Container>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Portfolio.Components.Projects.ScreenshotProject>(2);
                __builder2.AddAttribute(3, "Name", "Clockify.Net");
                __builder2.AddAttribute(4, "ScreenshotPath", "Images/Projects/clockify.net.png");
                __builder2.AddAttribute(5, "ProjectLink", "https://github.com/Morasiu/Clockify.Net");
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "<span>\r\n            It\'s REST HTTP Client made using RestSharp library for consuming Clockify service API. It has tests written \r\n            using NUnit and Cloud build. Stable version 1.0.0 is available on Nuget and GitHub.\r\n        </span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n\r\n    ");
                __builder2.OpenComponent<Portfolio.Components.Projects.ScreenshotProject>(9);
                __builder2.AddAttribute(10, "Name", "Swashbuckle.AspNetCore.JsonMultipartFormDataSupport");
                __builder2.AddAttribute(11, "ScreenshotPath", "https://raw.githubusercontent.com/Morasiu/Swashbuckle.AspNetCore.JsonMultipartFormDataSupport/master/Example.png");
                __builder2.AddAttribute(12, "ProjectLink", "https://github.com/Morasiu/Swashbuckle.AspNetCore.JsonMultipartFormDataSupport");
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, @"<span>
            I've made a simple library which add support to ASP.Net Core for simultaneously sending JSON data and file
            using Http Request multipart/form-data. It also has support for Swashbuckle and Swagger and seamless
            integration. It's available on Nuget.
        </span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n    ");
                __builder2.OpenComponent<Portfolio.Components.Projects.ScreenshotProject>(16);
                __builder2.AddAttribute(17, "Name", "Telegram AI chatbot");
                __builder2.AddAttribute(18, "Date", "02.2020 - 03.2020");
                __builder2.AddAttribute(19, "ScreenshotPath", "Images/Projects/telegram_AI.jpeg");
                __builder2.AddAttribute(20, "ProjectLink", "https://github.com/Morasiu/Telegram-AI-Chatbot");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(22, @"<span>
            By using over 70 000 messages from my Telegram's (communicator like Whatsapp) conversations
            I've managed to write my chatbot which you can talk to. It's written using python with Tensorflow and Seq2Seq model.
            Despite it was my first attempt for machine learning I was a lot of fun. It speaks only polish since I mostly
            chat in polish. It could use some more training.
        </span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n\r\n    ");
                __builder2.OpenComponent<Portfolio.Components.Projects.ScreenshotProject>(24);
                __builder2.AddAttribute(25, "Name", "Programming challenges");
                __builder2.AddAttribute(26, "Date", "Still in progress");
                __builder2.AddAttribute(27, "ScreenshotPath", "https://github.com/Morasiu/ProgrammingChallenges/blob/master/docs/list.png?raw=true");
                __builder2.AddAttribute(28, "ProjectLink", "https://github.com/Morasiu/ProgrammingChallenges");
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(30, "<span>\r\n            I really like solving programming challenges. I\'ve made quite a lot of it including: sudoku solver,\r\n            A*-based maze generator etc.\r\n        </span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n\r\n    ");
                __builder2.OpenComponent<Portfolio.Components.Projects.ScreenshotProject>(32);
                __builder2.AddAttribute(33, "Name", "Termgine");
                __builder2.AddAttribute(34, "Date", "08.2019");
                __builder2.AddAttribute(35, "ScreenshotPath", "https://github.com/Morasiu/Termgine/blob/master/Docs/D&D_menu.png?raw=true");
                __builder2.AddAttribute(36, "ProjectLink", "https://github.com/Morasiu/Termgine");
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "<span>\r\n            It\'s game engine for making terminal-based-games. Currently rewriting it to ECS.\r\n        </span>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
