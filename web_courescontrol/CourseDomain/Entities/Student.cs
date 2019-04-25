using System;
using System.Collections.Generic;

namespace CourseDomain.Entities
{
    public partial class Student
    {
        public Student()
        {
            Score = new HashSet<Score>();
            Selectcourse = new HashSet<Selectcourse>();
        }

        public int StuId { get; set; }
        public string StuName { get; set; }
        public string StuClass { get; set; }
        public string StuCrdit { get; set; }
        public string StuPwd { get; set; }
        public string Sex { get; set; }
        public string Mingzu { get; set; }
        public string Zhengzhimianmao { get; set; }
        public string Laiyuansheng { get; set; }
        public string Chushengdi { get; set; }
        public string Shengfenzheng { get; set; }
        public string Shoujihaoma { get; set; }
        public string Xueyuan { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual ICollection<Score> Score { get; set; }
        public virtual ICollection<Selectcourse> Selectcourse { get; set; }
    }
}
