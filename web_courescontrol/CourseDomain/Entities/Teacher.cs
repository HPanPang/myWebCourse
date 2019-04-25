using System;
using System.Collections.Generic;

namespace CourseDomain.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            Selectcourse = new HashSet<Selectcourse>();
        }

        public int TeacherId { get; set; }
        public string TeacherPwd { get; set; }
        public string TeacherName { get; set; }
        public DateTime? CreatTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Sex { get; set; }
        public string Shoujihaoma { get; set; }
        public string Mingzu { get; set; }
        public string Zhengzhimianmao { get; set; }
        public string Chushengdi { get; set; }

        public virtual ICollection<Selectcourse> Selectcourse { get; set; }
    }
}
