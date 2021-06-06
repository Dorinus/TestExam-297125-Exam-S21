// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AuthorBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\_Imports.razor"
using AuthorBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\_Imports.razor"
using AuthorBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\CreateAuthor.razor"
using AuthorBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\CreateAuthor.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\CreateAuthor.razor"
using TestExam_297125_Exam_S21.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreateAuthor")]
    public partial class CreateAuthor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\CreateAuthor.razor"
       
    private Author newAuthor = new Author();

    private async void CreateNewAuthor()
    {
        try
        {
            var response = await AuthorManager.createAuthor(newAuthor);
            if (response)
            {
                NavigationManager.NavigateTo("/");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorManager AuthorManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
