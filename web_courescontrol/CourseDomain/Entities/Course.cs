using System;
using System.Collections.Generic;

namespace CourseDomain.Entities
{
    public partial class Course
    {
        public Course()
        {
            Score = new HashSet<Score>();
            Selectcourse = new HashSet<Selectcourse>();
        }

        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseType { get; set; }
        public float CourseCredit { get; set; }

        public virtual ICollection<Score> Score { get; set; }
        public virtual ICollection<Selectcourse> Selectcourse { get; set; }
    }
}
