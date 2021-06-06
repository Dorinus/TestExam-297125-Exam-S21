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
    public class AuthorController : ControllerBase
    {
        private AuthorDBContext AuthorDbContext;

        public AuthorController()
        {
            AuthorDbContext = new AuthorDBContext();
        }


        [HttpGet]
        [Route("/author")]
        public async Task<IList<Author>> GetAuthors()
        {
            try
            {
                IList<Author> authors = await AuthorDbContext.Authors.Include(a => a.Books).ToListAsync();
                return authors;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPost]
        [Route("/author")]
        public async Task<bool> AddTodo([FromBody] Author author)
        {
            Console.WriteLine("Got a new author to create " + author.FirstName);

            try
            {
                await AuthorDbContext.Authors.AddAsync(author);
                AuthorDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
