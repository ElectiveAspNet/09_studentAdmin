using System;
using System.Linq;
using UniversityAdministration.Models;
using UniversityAdministration.Models.Entities;

namespace UniversityAdministration
{
    internal class DbInitializer
    {
        internal static void Initialize(UniversityAdministrationContext context)
        {
            context.Database.EnsureCreated();

           // Look for any students.
            if (context.Student.Any())
            {
               return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Student.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{Title = "ASP.NET MVC", Etcs = 10},
                new Course{Title = "Node.sj Backend web development", Etcs = 10},
                new Course{Title = "Futtog", Etcs = 10},
                new Course{Title = "Android Game development", Etcs = 10},
                new Course{Title = "Cops & Hackers", Etcs = 10}
            };
            foreach (Course c in courses)
            {
                context.Course.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{ CourseId = 1, StudentId = 1},
                new Enrollment{ CourseId = 2, StudentId = 1},
                new Enrollment{ CourseId = 3, StudentId = 1},
                new Enrollment{ CourseId = 2, StudentId = 2},
                new Enrollment{ CourseId = 3, StudentId = 2},
                new Enrollment{ CourseId = 4, StudentId = 2},
                 new Enrollment{ CourseId = 4, StudentId = 3},
                  new Enrollment{ CourseId = 5, StudentId = 3}
            };

            foreach (Enrollment e in enrollments)
            {
                context.Enrollment.Add(e);
            }
            context.SaveChanges();

        }
    }
}