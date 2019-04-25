using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseDomain.Entities
{
    public class StudentRepository
    {
        public void Add(Student student)
        {
            using (var context = new coursecontrolContext())
            {
                context.Student.Add(student);
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (var context = new coursecontrolContext())
            {
                var student = context.Student.FirstOrDefault(x => x.StuId == id);
                context.Student.Remove(student);
                context.SaveChanges();
            }
        }
        public void Update(Student student)
        {
            using (var context = new coursecontrolContext())
            {
                context.Student.Update(student);
                context.SaveChanges();
            }
        }
        public Student Query(int stuId)
        {
            Student student = null;
            using (var context = new coursecontrolContext())
            {
                student = context.Student.FirstOrDefault(x => x.StuId == stuId);
                context.SaveChanges();
            }
            return student;
        }
    }
}
