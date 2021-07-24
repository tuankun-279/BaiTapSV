using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagerment.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [StringLength(maximumLength: 150, MinimumLength = 2)]
        public string StudentName { get; set; }
        [Required]
        public string StudentRollId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StudentDOB { get; set; }
        [Required]
        public int ClassId { get; set; }

        public virtual ICollection<Exam> Exam { get; set; }
    }
}