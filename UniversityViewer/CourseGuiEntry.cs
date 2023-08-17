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
    public partial class CourseGuiEntry : UserControl
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
                _textBoxName.ReadOnly = _readOnly;

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
        public string Name
        {
            get => _textBoxName.Text;
            private set => _textBoxName.Text = value;
        }

        public CourseGuiEntry()
        {
            InitializeComponent();

            Click += OnEntryClick;
            _textBoxName.Click += OnEntryClick;
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

        internal void Update(ListViewData data)
        {
            Index = data.Index;
            Id = data.Id;
            Name = data.Course.Name;
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
