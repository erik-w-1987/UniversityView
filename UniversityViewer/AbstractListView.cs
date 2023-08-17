using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityData;

namespace UniversityViewer
{
    internal abstract class AbstractListView
    {
        protected UniversityModel _model;

        protected int _selectedIndex = -1;

        public event Action<ListViewData> ListViewDataChanged;
        public event Action<List<ListViewData>> ListCountChanged;

        protected readonly List<ListViewData> _listViewData = new List<ListViewData>();
        public AbstractListView(UniversityModel model)
        {
            _model = model;
        }

        
        protected void UpdateListViewData(int index, IStudent student)
        {
            _listViewData[index].Student = student;
            _listViewData[index].Show = true;
            _listViewData[index].Index = index;
        }

        protected void UpdateListViewData(int index, ICourse course)
        {
            _listViewData[index].Course = course;
            _listViewData[index].Show = true;
            _listViewData[index].Index = index;
        }

        protected void UpdateListViewData(int index, IGrade grade)
        {
            _listViewData[index].Grade = grade;
            _listViewData[index].Show = true;
            _listViewData[index].Index = index;
        }

        private void UpdateListViewMetaData(ListViewData data, bool selected, ButtonState edit, ButtonState delete, bool readOnly)
        {
            data.Selected = selected;
            data.EditButtonState = edit;
            data.DeleteButtonState = delete;
            data.ReadOnly = readOnly;

            ListViewDataChanged?.Invoke(data);
        }

        protected void InvokeListViewDataChanged(ListViewData data)
        {
            ListViewDataChanged?.Invoke(data);
        }

        protected void InvokeListCountChanged()
        {
            ListCountChanged?.Invoke(_listViewData);
        }

        public void SelectIndex(int index)
        {
            if (_selectedIndex >= 0)
            {
                UpdateListViewMetaData(_listViewData[_selectedIndex], false, ButtonState.Invisible, ButtonState.Invisible, true);
            }

            _selectedIndex = index;
            UpdateListViewMetaData(_listViewData[_selectedIndex], true, ButtonState.Active, ButtonState.Active, true);
        }

        public void StartEdit()
        {
            if (_selectedIndex < 0)
                return;

            UpdateListViewMetaData(_listViewData[_selectedIndex], true, ButtonState.Active, ButtonState.Inactive, false);
        }

        public void EndEdit()
        {
            if (_selectedIndex < 0)
                return;
            UpdateListViewMetaData(_listViewData[_selectedIndex], true, ButtonState.Active, ButtonState.Active, true);
        }

        public virtual void Delete()
        {
            if (_selectedIndex < 0)
                return;
            UpdateListViewMetaData(_listViewData[_selectedIndex], false, ButtonState.Invisible, ButtonState.Invisible, true);
            _selectedIndex = -1;
        }

    }
}
