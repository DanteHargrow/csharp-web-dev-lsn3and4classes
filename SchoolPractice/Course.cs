using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Course
    {
        public string CourseName { get; set; }
        List<string> students = new List<string> { "Dante", "Mike", "Tim" };
        private string teacherName;

        public void theTeacher(string firstName, string lastName)
        {
            this.teacherName = firstName+" "+lastName;
        }
        public string getTeacherName()
        {
            return $"The teacher of this course is {this.teacherName}";
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   CourseName == course.CourseName &&
                   EqualityComparer<List<string>>.Default.Equals(students, course.students) &&
                   teacherName == course.teacherName;
        }
        public override string ToString()
        {
            return teacherName + " teaches " + CourseName;
        }
    }
}
