using CourseDomain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseDomain.Service
{
    public class ScoreList
    {
        public int id;
        public string name;
        public int coursecode;
        public string coursename;
        public double coursescore;
        public double coursecredit;
        public string coursetype;
    }
    public class TSlist
    {
        public string StuName;
        public int id;
        public int CourseCode;
        public string CourseName;
        public double CourseCredit;
        public double CourseScore;
    }
    public class StudentService
    {
        private StudentRepository studentRepository;
        private SelectourseRepository selectourseRepository;
        private CourseRepository courseRepository;
        private ScoreRepository scoreRepository;
        
        public StudentService()
        {
            studentRepository = new StudentRepository();
            selectourseRepository = new SelectourseRepository();
            courseRepository = new CourseRepository();
            scoreRepository = new ScoreRepository();
        }
        public void SelectCourse(int id, int code)
        {

            scoreRepository.Add(id,code);
        }
        public void TuiXuan(int id,int code)
        {
            var score = scoreRepository.QueryByCode(code, id);
            scoreRepository.Delete(score);
        }
        public Student GetStuInfo(int id)
        {
            var student = studentRepository.Query(id);
            return student;
        }
        public List<TSlist> GetCourseList(string type,int id)
        {
            List<TSlist> kechengliebiao = new List<TSlist>();
            var courselist = courseRepository.Query(type);
            var student = studentRepository.Query(id);
            for(int i = 0; i < courselist.Count; i++)
            {
                TSlist temp = new TSlist();
                temp.CourseCode = courselist[i].CourseCode;
                temp.CourseCredit = courselist[i].CourseCredit;
                temp.CourseName = courselist[i].CourseName;
                temp.StuName = student.StuName;
                temp.id = id;
                var score = scoreRepository.QueryByCode(courselist[i].CourseCode,id);
                if (score == null) temp.CourseScore = -1;
                else if (score.CourseScore == null) temp.CourseScore = -2;
                else temp.CourseScore = (double)score.CourseScore;
                kechengliebiao.Add(temp);
            }
            return kechengliebiao;
        }
        public List<ScoreList> GetCourseList(int id)
        {
            List<ScoreList> socrelist = new List<ScoreList>();
            var student = studentRepository.Query(id);
            var scoreList = scoreRepository.Query(id);
            double tempCredit = 0;
            student.StuCrdit = tempCredit.ToString();
            studentRepository.Update(student);
            for (int i=0; i < scoreList.Count; i++)
            {
                var course = courseRepository.Query(scoreList[i].CcourseCode);
                ScoreList temp = new ScoreList();
                temp.id = scoreList[i].CstuId;
                temp.coursecode = course.CourseCode;
                temp.coursecredit = course.CourseCredit;
                temp.coursename = course.CourseName;
                temp.name = student.StuName;
                if (scoreList[i].CourseScore == null) temp.coursescore = 0;
                else temp.coursescore = (double)scoreList[i].CourseScore;
                temp.coursetype = course.CourseType;
                if (temp.coursescore >= 60) tempCredit += temp.coursecredit;

                socrelist.Add(temp);
            }
            student.StuCrdit = tempCredit.ToString();
            studentRepository.Update(student);
            ScoreList temp2 = new ScoreList();
            temp2.id = student.StuId;
            temp2.name = student.StuName;
            socrelist.Insert(0, temp2);
            return socrelist;                       
        }
        public bool Update(Student student)
        {
            studentRepository.Update(student);
            return true;
        }
        public bool Judge(int id, string pwd)
        {
            var student = studentRepository.Query(id);
            if (student == null) return false;
            if (student.StuPwd == pwd)
            {
                return true;
            }
            else return false;
        }
        public bool JudgePwd(int id, string oldPwd, string newPwd)
        {
            var student = studentRepository.Query(id);
            if (student == null) return false;
            if (student.StuPwd == oldPwd)
            {
                student.StuPwd = newPwd;
                studentRepository.Update(student);
                return true;
            }
            else return false;
        }
    }
}
