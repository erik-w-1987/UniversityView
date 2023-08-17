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
    public partial class StudentGuiEntry : UserControl
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
                _textBoxLastName.ReadOnly = _readOnly;
                _textBoxRegId.ReadOnly = _readOnly;

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
        public string FirstName
        {
            get => _textBoxName.Text;
            private set => _textBoxName.Text = value;
        }

        public string LastName
        {
            get => _textBoxLastName.Text;
            private set => _textBoxLastName.Text = value;
        }

        public int RegistrationNumber
        {
            get => int.Parse(_textBoxRegId.Text);
            private set => _textBoxRegId.Text = value.ToString();
        }

        public StudentGuiEntry()
        {
            InitializeComponent();

            Click += OnEntryClick;
            _textBoxName.Click += OnEntryClick;
            _textBoxLastName.Click += OnEntryClick;
            _textBoxRegId.Click += OnEntryClick;
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
            FirstName = data.Student.FirstName;
            LastName = data.Student.LastName;
            RegistrationNumber = data.Student.RegistrationNumber;

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
