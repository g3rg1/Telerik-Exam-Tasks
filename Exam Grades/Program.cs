using System;

namespace Exam_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());
            var grades = new decimal[students];
            var fail = 0M;
            var three = 0M;
            var four = 0M;
            var top = 0M;
            var totalGrade = 0M;

            for (int i = 0; i < grades.Length; i++)
            {
                var grade = decimal.Parse(Console.ReadLine());
                grades[i] = grade;
                totalGrade += grade;

                if (grade < 3M)
                {
                    fail++;
                }
                else if (grade <= 3.99M && grade >= 3M)
                {
                    three++;
                }
                else if(grade <= 4.99M && grade >= 4M)
                {
                    four++;
                }
                else
                {
                    top++;
                }

            }
            Console.WriteLine($"Top students: {(top / students) * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(four / students) * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(three / students) * 100:F2}%");
            Console.WriteLine($"Fail: {(fail / students) * 100:F2}%");
            Console.WriteLine($"Average: {totalGrade/students:F2}");
        }
    }
}
