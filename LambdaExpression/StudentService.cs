using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpression
{
    class StudentService
    {
        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student(){FirstName="Tom", LastName="Hanks", AvgGrade=3.0f},
                new Student(){FirstName="Bruce", LastName="Willis", AvgGrade=3.5f},
                new Student(){FirstName="Mike", LastName="Tyson", AvgGrade=4.5f}
            };
        }
    }
}
