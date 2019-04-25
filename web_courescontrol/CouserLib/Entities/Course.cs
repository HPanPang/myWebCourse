using System;
using System.Collections.Generic;

namespace CouserLib_DomainModel.Entities
{
    public partial class Course
    {
        public Course()
        {
            Score = new HashSet<Score>();
        }

        public int CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseType { get; set; }
        public float CourseCredit { get; set; }

        public virtual ICollection<Score> Score { get; set; }
    }
}
