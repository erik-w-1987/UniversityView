using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityViewer
{
    public partial class MainWindow : Form
    {
        public Control StudentsControl { get;  init; }
        public Control CoursesControl { get; init; }

        public Control GradesControl { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _studentsButton_Click(object sender, EventArgs e)
        {
            _mainPanel.Controls.Clear();
            StudentsControl.Dock = DockStyle.Fill;
            _mainPanel.Controls.Add(StudentsControl);
        }

        private void _CoursesButton_Click(object sender, EventArgs e)
        {
            _mainPanel.Controls.Clear();
            CoursesControl.Dock = DockStyle.Fill;
            _mainPanel.Controls.Add(CoursesControl);
        }

        private void _gradesButton_Click(object sender, EventArgs e)
        {
            _mainPanel.Controls.Clear();
            GradesControl.Dock = DockStyle.Fill;
            _mainPanel.Controls.Add(GradesControl);
            GradesControl.Invalidate();
        }
    }
}
