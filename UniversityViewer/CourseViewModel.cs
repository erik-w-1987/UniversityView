using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityData;

namespace UniversityViewer
{
    internal sealed class CourseViewModel : AbstractListView
    {
        public CourseViewModel(UniversityModel model) : base(model)
        {
            _model.CourseListChanged -= OnCourseListChanged;
            _model.CourseListChanged += OnCourseListChanged;
            _model.CourseDataChanged -= OnCourseDataChanged;
            _model.CourseDataChanged += OnCourseDataChanged;
        }

        private void OnCourseDataChanged(ICourse course)
        {
            var data = _listViewData.FirstOrDefault(dat => dat.Id == course.Id);
            InvokeListViewDataChanged(data);
        }

        private void OnCourseListChanged()
        {
            int index = 0;
            foreach (Course course in _model.Courses)
            {
                if (index >= _listViewData.Count)
                {
                    _listViewData.Add(new ListViewData());
                }
                UpdateListViewData(index, course);

                index++;
            }

            for (int index2 = index; index2 < _listViewData.Count; index2++)
            {
                _listViewData[index2].Show = false;
            }

            InvokeListCountChanged();
        }

        public void UpdateCourseData(int id, string name)
        {
            _model.UpdateCourseData(id, name);
        }

        public void AddCourse(string name)
        {
            _model.AddCourse(name);
        }

        public override void Delete()
        {
            if (_selectedIndex < 0)
                return;
            _model.DeleteCourse(_listViewData[_selectedIndex].Id);
            base.Delete();
        }
    }
}
