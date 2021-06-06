using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestExam_297125_Exam_S21.DataAcces;
using TestExam_297125_Exam_S21.Models;

namespace TestExam_297125_Exam_S21.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class BookController: ControllerBase
    {
        private AuthorDBContext AuthorDbContext;
        
        public BookController()
        {
            AuthorDbContext = new AuthorDBContext();
        }
        
        [HttpGet]
        [Route("/book")]
        public async Task<IList<Book>> GetBooks()
        {
            try
            {
                IList<Book> books = await AuthorDbContext.Books.ToListAsync();
                return books;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("/book/{id:int}")]
        public async Task<bool> AddBook([FromBody] Book book, [FromRoute] int id)
        {
            
            
            try
            {
                Console.WriteLine(book.ISBN);
                Console.WriteLine(book.Title);
                Console.WriteLine(book.Genre);
                Console.WriteLine(book.PublicationYear);
                Console.WriteLine(book.NumOfPages);
                Console.WriteLine("Author id : " + id);

                AuthorDbContext.Books.Add(book);
                var author = await AuthorDbContext.Authors.Include(aut => aut.Books).FirstOrDefaultAsync(a => a.Id == id);
                author.Books.Add(book);
                AuthorDbContext.Update(author);
                AuthorDbContext.Authors.Update(author);
                await AuthorDbContext.SaveChangesAsync();
                
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        [HttpDelete]
        [Route("/book/{bookIsbn:int}")]
        public async Task<ActionResult<bool>> removeBook([FromRoute] int bookIsbn)
        {
            try
            {
                var book = await AuthorDbContext.Books.FirstOrDefaultAsync(b => b.ISBN == bookIsbn);
                AuthorDbContext.Books.Remove(book);
                await AuthorDbContext.SaveChangesAsync();
                return StatusCode(200, true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}