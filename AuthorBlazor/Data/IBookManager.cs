using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestExam_297125_Exam_S21.Models;

namespace AuthorBlazor.Data
{
    public interface IBookManager
    {
        Task<IList<Book>> GetBooks();
        Task<bool> AddBook( Book book, int authorId);

        Task<bool> removeBook(int bookIsbn);
    }
}