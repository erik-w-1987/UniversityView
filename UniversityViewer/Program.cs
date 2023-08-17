using Database;
using System;
using System.Windows.Forms;

namespace UniversityViewer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (UniversityDatabase db = new UniversityDatabase())
            {
                UniversityModel model = new UniversityModel(db);
                StudentViewModel studentsViewModel = new StudentViewModel(model);
                CourseViewModel courseViewModel = new CourseViewModel(model);
                GradeViewModel gradeViewModel = new GradeViewModel(model);
                StudentsView studentsView = new StudentsView { ViewModel = studentsViewModel };
                CourseView courseView = new CourseView { ViewModel = courseViewModel };
                GradeView gradeView = new GradeView { ViewModel = gradeViewModel };
                model.Initialize();
                Application.Run(new MainWindow { StudentsControl = studentsView, CoursesControl = courseView, GradesControl = gradeView });
            }
            
        }
    }
}