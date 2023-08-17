namespace UniversityViewer
{
    partial class GradeGuiEntry
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._comboBoxGrade = new System.Windows.Forms.ComboBox();
            this._comboBoxCourse = new System.Windows.Forms.ComboBox();
            this._deleteButton = new System.Windows.Forms.Button();
            this._buttonEdit = new System.Windows.Forms.Button();
            this._studentComboBox = new System.Windows.Forms.ComboBox();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 5;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._tableLayoutPanel.Controls.Add(this._comboBoxGrade, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._comboBoxCourse, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._deleteButton, 4, 0);
            this._tableLayoutPanel.Controls.Add(this._buttonEdit, 3, 0);
            this._tableLayoutPanel.Controls.Add(this._studentComboBox, 0, 0);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 1;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(951, 96);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _comboBoxGrade
            // 
            this._comboBoxGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxGrade.FormattingEnabled = true;
            this._comboBoxGrade.Location = new System.Drawing.Point(525, 3);
            this._comboBoxGrade.Name = "_comboBoxGrade";
            this._comboBoxGrade.Size = new System.Drawing.Size(184, 40);
            this._comboBoxGrade.TabIndex = 6;
            // 
            // _comboBoxCourse
            // 
            this._comboBoxCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this._comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxCourse.FormattingEnabled = true;
            this._comboBoxCourse.Location = new System.Drawing.Point(335, 3);
            this._comboBoxCourse.Name = "_comboBoxCourse";
            this._comboBoxCourse.Size = new System.Drawing.Size(184, 40);
            this._comboBoxCourse.TabIndex = 5;
            // 
            // _deleteButton
            // 
            this._deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deleteButton.Location = new System.Drawing.Point(833, 3);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(115, 90);
            this._deleteButton.TabIndex = 2;
            this._deleteButton.Text = "Delete";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this._deleteButton_Click);
            // 
            // _buttonEdit
            // 
            this._buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._buttonEdit.Location = new System.Drawing.Point(715, 3);
            this._buttonEdit.Name = "_buttonEdit";
            this._buttonEdit.Size = new System.Drawing.Size(112, 90);
            this._buttonEdit.TabIndex = 1;
            this._buttonEdit.Text = "Edit";
            this._buttonEdit.UseVisualStyleBackColor = true;
            this._buttonEdit.Click += new System.EventHandler(this._buttonEdit_Click);
            // 
            // _studentComboBox
            // 
            this._studentComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._studentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._studentComboBox.FormattingEnabled = true;
            this._studentComboBox.Location = new System.Drawing.Point(3, 3);
            this._studentComboBox.Name = "_studentComboBox";
            this._studentComboBox.Size = new System.Drawing.Size(326, 40);
            this._studentComboBox.TabIndex = 4;
            // 
            // GradeGuiEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "GradeGuiEntry";
            this.Size = new System.Drawing.Size(951, 96);
            this._tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel _tableLayoutPanel;
        private Button _buttonEdit;
        private Button _deleteButton;
        private ComboBox _studentComboBox;
        private ComboBox _comboBoxGrade;
        private ComboBox _comboBoxCourse;
    }
}
