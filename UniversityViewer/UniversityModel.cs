using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityData;

namespace UniversityViewer 
{ 
    internal class UniversityModel
    {
        private IUniversityDatabase _database;

        public event Action<Student> StudentDataChanged;
        public event Action StudentListChanged;

        public event Action<Course> CourseDataChanged;
        public event Action CourseListChanged;

        public event Action<Grade> GradeDataChanged;
        public event Action GradeListChanged;

        public IEnumerable<IStudent> Students => _database.Students;
        public IEnumerable<ICourse> Courses => _database.Courses;

        public IEnumerable<IGrade> Grades => _database.Grades;

        public UniversityModel(IUniversityDatabase database)
        {
            _database = database;
        }

        public void Initialize()
        {
            StudentListChanged?.Invoke();
            CourseListChanged?.Invoke();
            GradeListChanged?.Invoke();
        }

        public void UpdateStudentData(int id, string firstName, string lastName, int regNumber)
        {
            var student = _database.Students.FirstOrDefault(s => s.Id == id);

            if (student == default(Student))
                return;

            student.FirstName = firstName;
            student.LastName = lastName;
            student.RegistrationNumber = regNumber;

            _database.Save();

            StudentDataChanged?.Invoke(student);
        }

        public void AddStudent(string firstName, string lastName, int regNumber)
        {
            if (_database.Students.Any(st => st.RegistrationNumber == regNumber))
                throw new Exception("Registration number already taken.");
            _database.AddNewStudent(new Student { FirstName = firstName, LastName = lastName, RegistrationNumber = regNumber });

            _database.Save();

            StudentListChanged?.Invoke();
        }

        public void DeleteStudent(int id)
        {
            _database.DeleteStudent(id);

            StudentListChanged?.Invoke();

            GradeListChanged?.Invoke();
        }

        public void DeleteCourse(int id)
        {
            _database.DeleteCourse(id);

            CourseListChanged?.Invoke();

            GradeListChanged?.Invoke();
        }

        public void UpdateCourseData(int id, string name)
        {
            var course = _database.Courses.FirstOrDefault(s => s.Id == id);

            if (course == default(Course))
                return;

            course.Name = name;

            _database.Save();

            CourseDataChanged?.Invoke(course);
        }

        public void AddCourse(string name)
        {

            _database.AddNewCourse(new Course { Name = name});

            _database.Save();

            CourseListChanged?.Invoke();
        }

        public void DeleteGrade(int id)
        {
            _database.DeleteGrade(id);

            GradeListChanged?.Invoke();
        }

        public void UpdateGradeData(int id, GradeValue value, Student student, Course course)
        {
            var grade = _database.Grades.FirstOrDefault(g => g.Id == id);

            if (grade == default(Grade))
                return;

            grade.Value = value;
            grade.Student = student;
            grade.Course = course;

            _database.Save();

            GradeDataChanged?.Invoke(grade);
        }

        public void AddGrade(GradeValue value, Student student, Course course)
        {

            _database.AddNewGrade(new Grade { Value = value, Student = student, Course = course });

            _database.Save();

            GradeListChanged?.Invoke();
        }
    }
}
