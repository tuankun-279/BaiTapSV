
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagerment.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        [Range(0, 100)]
        public int Mark { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }
    }
}