using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityData
{
    public interface IUniversityDatabase
    {
        IEnumerable<Student> Students { get; }

        IEnumerable<Course> Courses { get; }

        IEnumerable<Grade> Grades { get; }

        void AddNewStudent(Student student);
        void AddNewCourse(Course course);

        void AddNewGrade(Grade grade);

        void Save();

        void DeleteStudent(int id);

        void DeleteCourse(int id);

        void DeleteGrade(int id);
    }
}
