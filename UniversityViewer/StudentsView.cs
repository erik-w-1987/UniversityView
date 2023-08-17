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
    public partial class StudentsView : UserControl
    {
        private const string FirstName = "First Name";
        private const string LastName = "Last Name";
        private const string RegistrationNumber = "Registration Nr.";

        private StudentViewModel _viewModel;

        private readonly List<StudentGuiEntry> _entries = new List<StudentGuiEntry>();

        private bool _addPatientVisible;
        private bool AddStudentVisible
        {
            get => _addPatientVisible;
            set
            {
                _addPatientVisible = value;
                _textBoxFirstName.Visible = _addPatientVisible;
                _textBoxLastName.Visible = _addPatientVisible;
                _textBoxRegId.Visible = _addPatientVisible;

                if (_addPatientVisible)
                    _buttonAdd.Text = "Save";
                else
                    _buttonAdd.Text = "Add";
            }
        }

        internal StudentViewModel ViewModel
        {
            init
            {
                if (_viewModel is not null)
                {
                    _viewModel.ListCountChanged -= OnStudentListChanged;
                    _viewModel.ListViewDataChanged -= OnListViewDataChanged;
                }

                _viewModel = value;
                _viewModel.ListCountChanged -= OnStudentListChanged;
                _viewModel.ListCountChanged += OnStudentListChanged;
                _viewModel.ListViewDataChanged -= OnListViewDataChanged;
                _viewModel.ListViewDataChanged += OnListViewDataChanged;
            }
        }

        public StudentsView()
        {
            InitializeComponent();

            _textBoxFirstName.Text = FirstName;
            _textBoxLastName.Text = LastName;
            _textBoxRegId.Text = RegistrationNumber;

            _textBoxFirstName.Click += _textBoxFirstName_Click;
            _textBoxLastName.Click += _textBoxLastName_Click;
            _textBoxRegId.Click += _textBoxRegId_Click;
        }

        private void OnListViewDataChanged(ListViewData data)
        {
            var entry = _entries[data.Index];
            if (entry == default(StudentGuiEntry))
                return;

            entry.Update(data);
        }

        private void OnStudentListChanged(List<ListViewData> data)
        {
            _flowLayoutPanel.Controls.Clear();
            for (int ii = 0; ii < data.Count; ii++)
            {
                if (ii >= _entries.Count)
                {
                    StudentGuiEntry entry = new StudentGuiEntry
                    {
                        Size = new Size(_flowLayoutPanel.Width - 50, 80),
                    };
                    entry.SaveClicked += OnSaveButtonClicked;
                    entry.EditClicked += OnEditButtonClicked;
                    entry.DeleteButtonBlicked += OnDeleteClicked;
                    entry.EntryClicked += OnEntryClicked;
                    _entries.Add(entry);
                }

                _entries[ii].Update(data[ii]);

                if (data[ii].Show)
                    _flowLayoutPanel.Controls.Add(_entries[ii]);
                
            }

        }

        private void OnEntryClicked(object sender, EventArgs e)
        {
            StudentGuiEntry entry = sender as StudentGuiEntry;
            if (entry is null)
                return;

            _viewModel.SelectIndex(entry.Index);
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            StudentGuiEntry entry = sender as StudentGuiEntry;
            if (entry is null)
                return;

            _viewModel.Delete();
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            StudentGuiEntry entry = sender as StudentGuiEntry;
            if (entry is null)
                return;

            _viewModel.StartEdit();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            StudentGuiEntry entry = sender as StudentGuiEntry;
            if (entry is null)
                return;
            _viewModel.SaveStudentData(entry.Id, entry.FirstName, entry.LastName, entry.RegistrationNumber);
            _viewModel.EndEdit();
        }

        private void _textBoxFirstName_Click(object sender, EventArgs e)
        {
            if (_textBoxFirstName.Text == FirstName)
                _textBoxFirstName.Text = string.Empty;
        }

        private void _textBoxLastName_Click(object sender, EventArgs e)
        {
            if (_textBoxLastName.Text == LastName)
                _textBoxLastName.Text = string.Empty;
        }

        private void _textBoxRegId_Click(object sender, EventArgs e)
        {
            if (_textBoxRegId.Text == RegistrationNumber)
                _textBoxRegId.Text = string.Empty;
        }

        private void _buttonAdd_Click(object sender, EventArgs e)
        {
            if (AddStudentVisible)
                _viewModel.AddStudent(_textBoxFirstName.Text, _textBoxLastName.Text, int.Parse(_textBoxRegId.Text));

            AddStudentVisible = !AddStudentVisible;
        }
    }
}
