using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UniversityData;

namespace UniversityViewer
{
    internal sealed class GradeViewModel : AbstractListView
    {
        private readonly List<Student> _students = new List<Student>();
        private readonly List<Course> _courses = new List<Course>();
        public event Action<IList<Student>> StudentListChanged;
        public event Action<IList<Course>> CourseListChanged;

        public IList<GradeValue> AllGradesValues;

        public GradeViewModel(UniversityModel model) : base(model)
        {
            _model = model;
            _model.GradeListChanged += OnGradeListChanged;
            _model.GradeDataChanged += OnGradeDataChanged;

            _model.StudentListChanged += OnStudentListChanged;
            _model.CourseListChanged += OnCourseListChanged;
            _model.StudentDataChanged += OnStudentDataChanged;
            _model.CourseDataChanged += OnCourseDataChanged;

            AllGradesValues = new List<GradeValue>();

            foreach (var value in Enum.GetValues<GradeValue>())
            {
                AllGradesValues.Add(value);
            }
        }

        private void OnCourseDataChanged(Course course)
        {
            CourseListChanged?.Invoke(_courses);
            var dataList = _listViewData.Where(dat => dat.Grade.Course.Id == course.Id);
            foreach (var data in dataList)
            {
                InvokeListViewDataChanged(data);
            }
            
        }

        private void OnStudentDataChanged(Student student)
        {
            StudentListChanged?.Invoke(_students);
            var dataList = _listViewData.Where(dat => dat.Grade.Student.Id == student.Id);
            foreach (var data in dataList)
            {
                InvokeListViewDataChanged(data);
            }
            
        }

        private void OnCourseListChanged()
        {
            _courses.Clear();
            foreach (Course course in _model.Courses)
            {
                _courses.Add(course);
            }
            CourseListChanged?.Invoke(_courses);
        }


        private void OnGradeDataChanged(IGrade grade)
        {
            var data = _listViewData.FirstOrDefault(dat => dat.Id == grade.Id);
            InvokeListViewDataChanged(data);
        }

        private void OnStudentListChanged()
        {
            _students.Clear();
            foreach (Student student in _model.Students)
            {
                _students.Add(student);
            }
            StudentListChanged?.Invoke(_students);
        }

        private void OnGradeListChanged()
        {
            int index = 0;
            foreach (Grade grade in _model.Grades)
            {
                if (index >= _listViewData.Count)
                {
                    _listViewData.Add(new ListViewData());
                }
                UpdateListViewData(index, grade);

                index++;
            }

            for (int index2 = index; index2 < _listViewData.Count; index2++)
            {
                _listViewData[index2].Show = false;
            }

            InvokeListCountChanged();
        }


        public void AddGrade(GradeValue value, Student student, Course course)
        {
            _model.AddGrade(value, student, course);
        }

        public void SaveGradeData(int id, GradeValue value, Student student, Course course)
        {
            _model.UpdateGradeData(id, value, student, course);
        }


        public override void Delete()
        {
            if (_selectedIndex < 0)
                return;
            _model.DeleteGrade(_listViewData[_selectedIndex].Id);
            base.Delete();
        }
    }


    
}
