using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityData;

namespace Database
{
    public class UniversityDatabase : IDisposable, IUniversityDatabase
    {
        private bool _disposed;

        public readonly UniversityContext _context;

        private readonly DataCache<StudentDb, Student > _studentCache;

        private readonly DataCache<CourseDb, Course> _courseCache;

        private readonly DataCache<GradeDb, Grade> _gradeCache;
        public IEnumerable<Student> Students => _studentCache.Data;

        public IEnumerable<Course> Courses => _courseCache.Data;

        public IEnumerable<Grade> Grades => _gradeCache.Data;

        public UniversityDatabase()
        {
            _context = new UniversityContext();

            _studentCache = new DataCache<StudentDb, Student>(_context.Students, studendDb => studendDb.CreateStudent());

            _courseCache = new DataCache<CourseDb, Course>(_context.Courses, courseDb => courseDb.CreateCourse()); ;

            _gradeCache = new DataCache<GradeDb, Grade>(_context.Grades, gradeDb => gradeDb.CreateGrade(_studentCache.GetById(gradeDb.StudentId), _courseCache.GetById(gradeDb.CourseId)));
        }

        public void AddNewStudent(Student student)
        {
            _context.Students.Add(new StudentDb { FirstName = student.FirstName, LastName = student.LastName, RegistrationNumber = student.RegistrationNumber });
        }
        public void AddNewCourse(Course course)
        {
            _context.Courses.Add(new CourseDb { Name = course.Name });
        }

        public void AddNewGrade(Grade grade)
        {
            _context.Grades.Add(new GradeDb { Value = grade.Value, StudentId = grade.Student.Id, CourseId = grade.Course.Id });
        }

        public void DeleteStudent(int id)
        {
            var grades = _context.Grades.Where(g => g.StudentId == id);
            foreach (var g in grades)
            {
                _gradeCache.Delete(g.Id);
            }
            _context.Grades.RemoveRange(grades);

            _context.SaveChanges();

            _studentCache.Delete(id);
            StudentDb studentDb = _context.Students.First(st => st.Id == id);
            _context.Students.Remove(studentDb);

            _context.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            var grades = _context.Grades.Where(g => g.CourseId == id);

            foreach (var g in grades)
            {
                _gradeCache.Delete(g.Id);
            }
            _context.Grades.RemoveRange(grades);
            _context.SaveChanges();

            _courseCache.Delete(id);
            CourseDb courseDb = _context.Courses.First(co => co.Id == id);
            _context.Courses.Remove(courseDb);

            _context.SaveChanges();

            
        }

        public void DeleteGrade(int id)
        {
            GradeDb gradeDb = _context.Grades.First(gr => gr.Id == id);
            _context.Grades.Remove(gradeDb);
            _context.SaveChanges();
            _gradeCache.Delete(id);
        }

        public void Save()
        {
            foreach (Student student in _studentCache.OnlyCachedData)
            {
                StudentDb studentDb = _context.Students.First(st => st.Id == student.Id);

                studentDb.FirstName = student.FirstName;
                studentDb.LastName = student.LastName;
                studentDb.RegistrationNumber = student.RegistrationNumber;
            }

            foreach (Course course in _courseCache.OnlyCachedData)
            {
                CourseDb studentDb = _context.Courses.First(cc => cc.Id == course.Id);
                studentDb.Name = course.Name;
            }

            foreach (Grade grade in _gradeCache.OnlyCachedData)
            {
                GradeDb gradeDb = _context.Grades.First(g => g.Id == grade.Id);
                gradeDb.Value = grade.Value;
                gradeDb.StudentId = grade.Student.Id;
                gradeDb.CourseId = grade.Course.Id;
            }

            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispse(true);
            GC.SuppressFinalize(this);
        }

        private void Dispse(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _context?.Dispose();
            }

            _disposed = true;
        }
    }
}
