#pragma checksum "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ddeedafb3dec58c5937b0afb39a6ff8d3ac0910"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthorBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 2 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
using AuthorBlazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
using TestExam_297125_Exam_S21.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewAllBooks")]
    public partial class ViewAllBooks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>View All Books</h3>");
#nullable restore
#line 11 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
 if (Authors == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
}
else if (!Authors.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>No Books exist in the system. Or something went wrong</em></p>");
#nullable restore
#line 22 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Title</th> <th>PubYear</th> <th>NumbOfPages</th> \r\n            <th>AuthorFirstName</th> <th>AuthorLastName</th><th>Remove</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 33 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
         foreach (var author in  Authors)
        {

            foreach (var book in author.Books)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 39 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
                         book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(10, " ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 39 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
                                              book.PublicationYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(13, " ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 39 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
                                                                             book.NumOfPages

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(16, " ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 39 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
                                                                                                       author.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 40 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
                         author.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
                                            () => RemoveBook(book.ISBN)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
            }
            
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "D:\dotNetProjects\TestExam-297125-Exam-S21\AuthorBlazor\Pages\ViewAllBooks.razor"
       
    private IList<Author> Authors;
    
    protected override async Task OnInitializedAsync()
    {
        Authors = await AuthorManager.getAuthors();
    }

    private async void RemoveBook(int bookIsbn)
    {
        bool response = await BookManager.removeBook(bookIsbn);
        if (response)
        {
            NavigationManager.NavigateTo("/ViewAllBooks");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookManager BookManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorManager AuthorManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
