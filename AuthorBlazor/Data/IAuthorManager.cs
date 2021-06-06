using System.Collections.Generic;
using System.Threading.Tasks;
using TestExam_297125_Exam_S21.Models;

namespace AuthorBlazor.Data
{
    public interface IAuthorManager
    {
        Task<bool> createAuthor(Author author);
        Task<IList<Author>> getAuthors();
    }
}