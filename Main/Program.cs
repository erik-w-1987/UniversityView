using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using UniversityData;

Random rnd = new Random();

using (var db = new UniversityDatabase())
{

    //ctx.SaveChanges();

    foreach (var student in db.Students.Skip(1).Take(10))
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} {student.RegistrationNumber}");
    }


    foreach (var course in db.Courses)
    {
        Console.WriteLine(course.Name);
    }

    db.Students.FirstOrDefault(student => student.Id == 123456);

    foreach (Grade grade in db.Grades)
    {
        Console.WriteLine($"{grade.Student.LastName} {grade.Course.Name} {grade.Value}");
    }


}