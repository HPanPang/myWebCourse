using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseDomain.Entities
{
    public class SelectourseRepository
    {
        public void Add(Selectcourse selectcourse)
        {
            using (var context = new coursecontrolContext())
            {
                context.Selectcourse.Add(selectcourse);
                context.SaveChanges();
            }
        }
        public void Delete(int coursecode,int stuid)
        {
            using (var context = new coursecontrolContext())
            {
                var selectcourse = context.Selectcourse.Where(d => d.StudentId == stuid).FirstOrDefault(x => x.CourseId == coursecode);
                context.Selectcourse.Remove(selectcourse);
                context.SaveChanges();
            }
        }
        public void Update(Selectcourse selectcourse)
        {
            using (var context = new coursecontrolContext())
            {
                context.Selectcourse.Update(selectcourse);
                context.SaveChanges();
            }
        }
        public Selectcourse Query(int stuid)//
        {
            Selectcourse selectcourse = null;
            using (var context = new coursecontrolContext())
            {
                var test = context.Selectcourse.ToList();
                foreach(var item in test)
                {
                    
                }
                //selectcourse = context.Selectcourse.FirstOrDefault(x => x.StudentId == stuid);
                context.SaveChanges();
            }
            return selectcourse;
        }
    }
}
