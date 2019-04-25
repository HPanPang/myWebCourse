using CourseDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseDomain.Service
{
    public class TeacherService
    {
        private TeacherRepository teacherRepository;
        public TeacherService()
        {
            teacherRepository = new TeacherRepository();
        }
        public Teacher GetDrInfo(int id)
        {
            var teacher = teacherRepository.Query(id);
            return teacher;
        }
        public bool Judge(int id, string pwd)
        {
            var teacher = teacherRepository.Query(id);
            if (teacher == null) return false;
            if (teacher.TeacherPwd == pwd)
            {
                return true;
            }
            else return false;

        }
        public bool JudgePwd(int id, string oldPwd, string newPwd)
        {
            var teacher = teacherRepository.Query(id);
            if (teacher == null) return false;
            if (teacher.TeacherPwd == oldPwd)
            {
                teacher.TeacherPwd = newPwd;
                teacherRepository.Update(teacher);
                return true;
            }
            else return false;
        }
    }
}
