using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace CodeFirstStudentDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new SchoolContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 21
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added to the database.");
            Console.ReadKey();
        }
    }
}
