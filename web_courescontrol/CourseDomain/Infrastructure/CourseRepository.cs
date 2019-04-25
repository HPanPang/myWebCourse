using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseDomain.Entities
{
    public class CourseRepository
    {
        public void Add(Course course)
        {
            using (var context = new coursecontrolContext())
            {
                context.Course.Add(course);
                context.SaveChanges();
            }
        }
        public void Delete(int id,int coursecode)
        {
            using (var context = new coursecontrolContext())
            {
                var course = context.Course.FirstOrDefault(x => x.CourseCode == coursecode);
                context.Course.Remove(course);
                context.SaveChanges();
            }
        }
        public void Update(Course course)
        {
            using (var context = new coursecontrolContext())
            {
                context.Course.Update(course);
                context.SaveChanges();
            }
        }
        public Course Query(int CourseCode)
        {
            Course course = null;
            using (var context = new coursecontrolContext())
            {
                course = context.Course.FirstOrDefault(x => x.CourseCode == CourseCode);
                context.SaveChanges();
            }
            return course;
        }

        public List<Course> Query(string type)
        {
            List<Course> listCourse = new List<Course>();
            using (var context = new coursecontrolContext())
            {
                listCourse = (from u in context.Course
                              where u.CourseType == type
                             select u
                             ).ToList();
                context.SaveChanges();
            }
            return listCourse;
        }
    }
}
