using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student()
        {

        }

        public Student(string name, int sId, int numberOfCredits, double gpa)
        {
            this.Name = name;
            StudentId = sId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int sId)
        {
            Name = name;
            StudentId = sId;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public Student(string name)
        {
            Name = name;
            StudentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public string StudentInfo()
        {
            return (Name + " has a GPA of: " + Gpa);
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            double totalQualityScore = NumberOfCredits * Gpa;
            double qualityScore = grade * courseCredits;
            totalQualityScore += qualityScore;

            NumberOfCredits += courseCredits;

            Gpa = totalQualityScore / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            if(NumberOfCredits <= 29)
            {
                return "Freshman";
            }
            else if(NumberOfCredits > 29 && NumberOfCredits <= 59)
            {
                return "Sophomore";
            }
            else if (NumberOfCredits > 59 && NumberOfCredits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
               
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId &&
                   NumberOfCredits == student.NumberOfCredits &&
                   Gpa == student.Gpa;
        }
        public override string ToString()
        {
            return this.Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }
    }
}
