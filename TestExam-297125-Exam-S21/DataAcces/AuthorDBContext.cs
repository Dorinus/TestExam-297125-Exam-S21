using Microsoft.EntityFrameworkCore;
using TestExam_297125_Exam_S21.Models;

namespace TestExam_297125_Exam_S21.DataAcces
{
    public class AuthorDBContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Author.db");    }
    }
        
    
}