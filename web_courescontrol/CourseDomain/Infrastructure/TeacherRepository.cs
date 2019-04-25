using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseDomain.Entities
{
    public class TeacherRepository
    {
        public void Add(Teacher teacher)
        {
            using (var context = new coursecontrolContext())
            {
                context.Teacher.Add(teacher);
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new coursecontrolContext())
            {
                var teacher = context.Teacher.FirstOrDefault(x => x.TeacherId == id);
                context.Teacher.Remove(teacher);
                context.SaveChanges();
            }
        }
        public void Update(Teacher teacher)
        {
            using (var context = new coursecontrolContext())
            {
                context.Teacher.Update(teacher);
                context.SaveChanges();
            }
        }
        public Teacher Query(int teacherId)
        {
            Teacher teacher = null;
            using (var context = new coursecontrolContext())
            {
                teacher = context.Teacher.FirstOrDefault(x => x.TeacherId == teacherId);
                context.SaveChanges();
            }
            return teacher;
        }
    }
}
