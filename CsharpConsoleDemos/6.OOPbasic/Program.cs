using System;
using System.Text;

namespace OopBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Makis", "1234567890", 10, 5);
            s.PrintStudentInfo();
        }
    }

    class Student
    {
        public string studentName;
        public int mathMarks;
        private string ssn;
        public int scienceMarks;

        public string SSN
        {
            get
            {
                StringBuilder tempSSN = new StringBuilder(ssn);
                for (int i = 0; i < 7; i++)
                    tempSSN[i] = '*';
                return tempSSN.ToString();
            }
            set
            {
                ssn = value;
            }
        }

        public Student(string sName, string ssnum, int smathMarks, int sMarks)
        {
            studentName = sName;
            SSN = ssnum;
            mathMarks = smathMarks;
            scienceMarks = sMarks;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student ID Number: " + SSN);
            Console.WriteLine("Marks in Math: " + mathMarks.ToString());
            Console.WriteLine("Marks in Science" + scienceMarks.ToString());
            Console.WriteLine();
        }

    }
}