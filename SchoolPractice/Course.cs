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

    }
}
