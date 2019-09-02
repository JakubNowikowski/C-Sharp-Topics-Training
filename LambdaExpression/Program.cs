using System;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentService studentService = new StudentService();

            var students = studentService.GetStudents();

            // Print last name of students whose average grade is more than 4.0
            foreach (var student in students.FindAll(a => a.AvgGrade > 4.0f))
                Console.WriteLine(student.LastName);

            Console.ReadKey();
        }
    }
}
