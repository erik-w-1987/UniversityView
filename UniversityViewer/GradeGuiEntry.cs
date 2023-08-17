using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityData;

namespace UniversityViewer
{
    public partial class GradeGuiEntry : UserControl
    {
        private bool _readOnly = true;

        public event EventHandler SaveClicked;
        public event EventHandler EditClicked;
        public event EventHandler DeleteButtonBlicked;
        public event EventHandler EntryClicked;
        public bool ReadOnly
        {
            get => _readOnly;
            private set
            {
                _readOnly = value;
                _studentComboBox.Enabled = !_readOnly;
                _comboBoxCourse.Enabled = !_readOnly;
                _comboBoxGrade.Enabled = !_readOnly;

                if (_readOnly)
                    _buttonEdit.Text = "Edit";
                else
                {
                    _buttonEdit.Text = "Save";
                }
            }
        }

        public int Index { get; private set; }
        public int Id { get; private set; }

        public Student Student
        {
            get => (Student)_studentComboBox.SelectedItem;
            private set => _studentComboBox.SelectedItem = value;
        }

        public Course Course
        {
            get => (Course)_comboBoxCourse.SelectedItem;
            private set => _comboBoxCourse.SelectedItem = value;
        }

        public GradeValue GradeValue
        {
            get => (GradeValue)_comboBoxGrade.SelectedItem;
            private set => _comboBoxGrade.SelectedItem = value;
        }

        public IList<GradeValue> AllGradeValues
        {
            set
            {
                _comboBoxGrade.DataSource = value;
            }
        }

        public GradeGuiEntry()
        {
            InitializeComponent();

            Click += OnEntryClick;
            _studentComboBox.Click += OnEntryClick;
            _comboBoxCourse.Click += OnEntryClick;
            _comboBoxGrade.Click += OnEntryClick;
            _tableLayoutPanel.Click += OnEntryClick;
        }

        private void OnEntryClick(object sender, EventArgs e)
        {
            if (!ReadOnly)
                return;

            EntryClicked?.Invoke(this, e);
        }

        private void _buttonEdit_Click(object sender, EventArgs e)
        {

            if (!_readOnly)
                SaveClicked(this, e);
            else
                EditClicked(this, e);
        }

        private void _deleteButton_Click(object sender, EventArgs e)
        {
            DeleteButtonBlicked.Invoke(this, e);
        }

        internal void UpdateStudents(IList<Student> students)
        {
            _studentComboBox.DataSource = null;
            _studentComboBox.DataSource = students;
        }

        internal void UpdateCourses(IList<Course> courses)
        {
            _comboBoxCourse.DataSource = null;
            _comboBoxCourse.DataSource = courses;
        }

        internal void Update(ListViewData data)
        {
            Index = data.Index;
            Id = data.Id;
            Student = data.Grade.Student;
            Course = data.Grade.Course;
            GradeValue = data.Grade.Value;

            ReadOnly = data.ReadOnly;

            UpdateButton(_buttonEdit, data.EditButtonState);
            UpdateButton(_deleteButton, data.DeleteButtonState);

            BackColor = data.Selected ? Color.DarkGray : Color.Transparent;
        }

        private void UpdateButton(Button button, ButtonState buttonState)
        {
            button.Visible = buttonState != ButtonState.Invisible;
            button.Enabled = buttonState == ButtonState.Active;
        }
    }
}
