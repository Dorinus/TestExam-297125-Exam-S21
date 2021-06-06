using System;
using System.ComponentModel.DataAnnotations;

namespace TestExam_297125_Exam_S21.Models
{
    public class Book
    {
        [Key]
        public int ISBN { get; set; }
        [Required, MaxLength(40)]
        public String Title { get; set; }
        public int PublicationYear { get; set; }
        public int NumOfPages { get; set; }
        public String Genre { get; set; }
    }
}