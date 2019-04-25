using System;
using System.Collections.Generic;

namespace CouserLib_DomainModel.Entities
{
    public partial class Student
    {
        public Student()
        {
            Score = new HashSet<Score>();
        }

        public int StuId { get; set; }
        public string StuName { get; set; }
        public string StuClass { get; set; }
        public string StuCrdit { get; set; }
        public string StuPwd { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual ICollection<Score> Score { get; set; }
    }
}
