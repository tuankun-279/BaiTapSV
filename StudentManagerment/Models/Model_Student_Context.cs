using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentManagerment.Models
{
    public class Model_Student_Context : DbContext

    {
        public Model_Student_Context() : base("QLyLopHoc")
        {

        }
        //DbSet<Student> Students { get; set; }
        //DbSet<Subject> Subjects { get; set; }
        //DbSet<Exam> Exams { get; set; }

        public System.Data.Entity.DbSet<StudentManagerment.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<StudentManagerment.Models.Subject> Subjects { get; set; }

        public System.Data.Entity.DbSet<StudentManagerment.Models.Exam> Exams { get; set; }
    }
    
}