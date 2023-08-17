using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityData;

namespace UniversityViewer
{
    public partial class GradeView : UserControl
    {
        private const string FirstName = "First Name";
        private const string LastName = "Last Name";
        private const string RegistrationNumber = "Registration Nr.";

        private IList<Student> _students;
        private IList<Course> _courses;

        private GradeViewModel _viewModel;

        private readonly List<GradeGuiEntry> _entries = new List<GradeGuiEntry>();

        internal GradeViewModel ViewModel
        {
            init
            {
                if (_viewModel is not null)
                {
                    _viewModel.ListCountChanged -= OnGradeListChanged;
                    _viewModel.ListViewDataChanged -= OnListViewDataChanged;
                }

                _viewModel = value;
                _viewModel.ListCountChanged -= OnGradeListChanged;
                _viewModel.ListCountChanged += OnGradeListChanged;
                _viewModel.ListViewDataChanged -= OnListViewDataChanged;
                _viewModel.ListViewDataChanged += OnListViewDataChanged;

                _viewModel.StudentListChanged -= OnStudentListChanged;
                _viewModel.StudentListChanged += OnStudentListChanged;
                _viewModel.CourseListChanged -= OnCourseListChanged;
                _viewModel.CourseListChanged += OnCourseListChanged;
            }
        }

        private void OnCourseListChanged(IList<Course> courses)
        {
            _courses = courses;
            _comboBoxCourse.DataSource = null;
            _comboBoxCourse.DataSource = courses;
        }

        private void OnStudentListChanged(IList<Student> students)
        {
            _students = students;
            _comboBoxStudent.DataSource = null;
            _comboBoxStudent.DataSource = students;
        }

        public GradeView()
        {
            InitializeComponent();
        }

        private void OnListViewDataChanged(ListViewData data)
        {
            var entry = _entries[data.Index];
            if (entry == default(GradeGuiEntry))
                return;
            entry.UpdateCourses(_courses);
            entry.UpdateStudents(_students);
            entry.Update(data);
        }

        private void OnGradeListChanged(List<ListViewData> data)
        {
            _comboBoxGrade.DataSource = null;
            _comboBoxGrade.DataSource = _viewModel.AllGradesValues;

            _flowLayoutPanel.Controls.Clear();
            for (int ii = 0; ii < data.Count; ii++)
            {
                if (ii >= _entries.Count)
                {
                    GradeGuiEntry entry = new GradeGuiEntry
                    {
                        Size = new Size(_flowLayoutPanel.Width - 50, 80),
                        AllGradeValues = _viewModel.AllGradesValues,
                    };
                    entry.SaveClicked += OnSaveButtonClicked;
                    entry.EditClicked += OnEditButtonClicked;
                    entry.DeleteButtonBlicked += OnDeleteClicked;
                    entry.EntryClicked += OnEntryClicked;
                    entry.UpdateStudents(_students);
                    entry.UpdateCourses(_courses);
                    _entries.Add(entry);
                }
                
                _entries[ii].Update(data[ii]);

                if (data[ii].Show)
                    _flowLayoutPanel.Controls.Add(_entries[ii]);
                
                
            }

        }

        private void OnEntryClicked(object sender, EventArgs e)
        {
            GradeGuiEntry entry = sender as GradeGuiEntry;
            if (entry is null)
                return;

            entry.UpdateStudents(_students);
            entry.UpdateCourses(_courses);
            _viewModel.SelectIndex(entry.Index);
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            GradeGuiEntry entry = sender as GradeGuiEntry;
            if (entry is null)
                return;

            _viewModel.Delete();
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            GradeGuiEntry entry = sender as GradeGuiEntry;
            if (entry is null)
                return;

            _viewModel.StartEdit();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            GradeGuiEntry entry = sender as GradeGuiEntry;
            if (entry is null)
                return;
            _viewModel.SaveGradeData(entry.Id, entry.GradeValue, entry.Student, entry.Course);
            _viewModel.EndEdit();
        }

        private void _buttonAdd_Click(object sender, EventArgs e)
        {
            if (_comboBoxGrade.SelectedItem is null || _comboBoxStudent.SelectedItem is null || _comboBoxCourse.SelectedItem is null)
                return;
            _viewModel.AddGrade((GradeValue)_comboBoxGrade.SelectedItem, (Student)_comboBoxStudent.SelectedItem, (Course)_comboBoxCourse.SelectedItem);
        }
    }
}
