using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityData;

namespace UniversityViewer
{
    internal enum ButtonState
    {
        Active,
        Inactive,
        Invisible
    }
    internal class ListViewData
    {
        private IStudent _student;

        private ICourse _course;

        private IGrade _grade;


        public int Id { get; private set; }
        public IStudent Student
        {
            get => _student;
            set
            {
                _student = value;
                Id = _student.Id;
            }
        }
        public ICourse Course
        {
            get => _course;
            set
            {
                _course = value;
                Id = _course.Id;
            }
        }
        public IGrade Grade
        {
            get => _grade;
            set
            {
                _grade = value;
                Id = _grade.Id;
            }
        }
        public ButtonState EditButtonState { get; set; } = ButtonState.Invisible;
        public ButtonState DeleteButtonState { get; set; } = ButtonState.Invisible;

        public bool ReadOnly { get; set; } = true;

        public bool Selected { get; set; }

        public bool Show { get; set; }

        public int Index { get; set; }

    }
}
