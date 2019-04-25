using System;
using System.Collections.Generic;

namespace CourseDomain.Entities
{
    public partial class Selectcourse
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public int StudentId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
