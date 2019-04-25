using System;
using System.Collections.Generic;

namespace CouserLib_DomainModel.Entities
{
    public partial class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherPwd { get; set; }
        public string TeacherName { get; set; }
        public DateTime? CreatTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
