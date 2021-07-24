using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentManagerment.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        [StringLength(maximumLength: 30, MinimumLength = 1)]
        public string SubjectName { get; set; }

        public virtual ICollection<Exam> Exam { get; set; }
    }
}