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
    internal sealed class StudentViewModel : AbstractListView
    {
        public StudentViewModel(UniversityModel model) : base(model)
        {
            _model.StudentListChanged -= OnStudentListChanged;
            _model.StudentListChanged += OnStudentListChanged;
            _model.StudentDataChanged -= OnStudentDataChanged;
            _model.StudentDataChanged += OnStudentDataChanged;
        }

        private void OnStudentDataChanged(IStudent student)
        {
            var data = _listViewData.FirstOrDefault(dat => dat.Id == student.Id);
            InvokeListViewDataChanged(data);
        }

        private void OnStudentListChanged()
        {
            int index = 0;
            foreach (Student student in _model.Students)
            {
                if (index >= _listViewData.Count)
                {
                    _listViewData.Add(new ListViewData());
                }
                UpdateListViewData(index, student);

                index++;
            }

            for (int index2 = index; index2 < _listViewData.Count; index2++)
            {
                _listViewData[index2].Show = false;
            }

            InvokeListCountChanged();
        }


        public void AddStudent(string firstName, string lastName, int regNumber)
        {
            _model.AddStudent(firstName, lastName, regNumber);
        }

        public void SaveStudentData(int id, string firstName, string lastName, int regNumber)
        {
            _model.UpdateStudentData(id, firstName, lastName, regNumber);
        }


        public override void Delete()
        {
            if (_selectedIndex < 0)
                return;
            _model.DeleteStudent(_listViewData[_selectedIndex].Id);
            base.Delete();
        }
    }


    
}
