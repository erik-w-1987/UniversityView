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
    public partial class CourseView : UserControl
    {
        private const string NameString = "Name";

        private CourseViewModel _viewModel;

        private readonly List<CourseGuiEntry> _entries = new List<CourseGuiEntry>();

        private bool _addCourseVisible;
        private bool AddCourseVisible
        {
            get => _addCourseVisible;
            set
            {
                _addCourseVisible = value;
                _textBoxName.Visible = _addCourseVisible;

                if (_addCourseVisible)
                    _buttonAdd.Text = "Save";
                else
                    _buttonAdd.Text = "Add";
            }
        }

        internal CourseViewModel ViewModel
        {
            init
            {
                if (_viewModel is not null)
                {
                    _viewModel.ListCountChanged -= OnListChanged;
                    _viewModel.ListViewDataChanged -= OnListViewDataChanged;
                }

                _viewModel = value;
                _viewModel.ListCountChanged -= OnListChanged;
                _viewModel.ListCountChanged += OnListChanged;
                _viewModel.ListViewDataChanged -= OnListViewDataChanged;
                _viewModel.ListViewDataChanged += OnListViewDataChanged;
            }
        }

        public CourseView()
        {
            InitializeComponent();

            _textBoxName.Text = NameString;

            _textBoxName.Click += _textBoxName_Click;
        }

        private void OnListViewDataChanged(ListViewData data)
        {
            var entry = _entries[data.Index];
            if (entry == default(CourseGuiEntry))
                return;

            entry.Update(data);
        }

        private void OnListChanged(List<ListViewData> data)
        {
            _flowLayoutPanel.Controls.Clear();
            for (int ii = 0; ii < data.Count; ii++)
            {
                if (ii >= _entries.Count)
                {
                    CourseGuiEntry entry = new CourseGuiEntry
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
            CourseGuiEntry entry = sender as CourseGuiEntry;
            if (entry is null)
                return;

            _viewModel.SelectIndex(entry.Index);
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            CourseGuiEntry entry = sender as CourseGuiEntry;
            if (entry is null)
                return;

            _viewModel.Delete();
        }

        private void OnEditButtonClicked(object sender, EventArgs e)
        {
            CourseGuiEntry entry = sender as CourseGuiEntry;
            if (entry is null)
                return;

            _viewModel.StartEdit();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            CourseGuiEntry entry = sender as CourseGuiEntry;
            if (entry is null)
                return;
            _viewModel.UpdateCourseData(entry.Id, entry.Name);
            _viewModel.EndEdit();
        }

        private void _textBoxName_Click(object sender, EventArgs e)
        {
            if (_textBoxName.Text == NameString)
                _textBoxName.Text = string.Empty;
        }

        private void _buttonAdd_Click(object sender, EventArgs e)
        {
            if (AddCourseVisible)
                _viewModel.AddCourse(_textBoxName.Text);

            AddCourseVisible = !AddCourseVisible;
        }
    }
}
