using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student Dante = new Student();
            Dante.NumberOfCredits = 1;
            Dante.Gpa = 4.0;

            Teacher Kim = new Teacher();
            Course math = new Course();
            Kim.FirstName = "Kim";
            Kim.LastName = "Hargrow";
            math.CourseName = "Math 101";
            math.theTeacher(Kim.FirstName,Kim.LastName);
            string teacherName = math.getTeacherName();
            Console.WriteLine(teacherName);
        }
    }
}
