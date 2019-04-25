using System;
using System.Collections.Generic;

namespace CouserLib_DomainModel.Entities
{
    public partial class Score
    {
        public int CcourseCode { get; set; }
        public int CstuId { get; set; }
        public double CourseScore { get; set; }

        public virtual Course CcourseCodeNavigation { get; set; }
        public virtual Student Cstu { get; set; }
    }
}
