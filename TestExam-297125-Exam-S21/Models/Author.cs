using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestExam_297125_Exam_S21.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(15)]
        public String FirstName { get; set; }
        [Required, MaxLength(15)]
        public String LastName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}