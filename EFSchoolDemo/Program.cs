using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFSchoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                if (db.Database.CanConnect())
                {
                    var students = db.Students.ToList();
                    var grades = db.Grades.ToList();
                    var courses = db.Courses.ToList();                    
                }
                else Console.WriteLine("Failed to connect!");
            }
        }
    }
}
