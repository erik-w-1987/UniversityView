namespace UniversityViewer
{
    partial class CourseGuiEntry
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
            this._deleteButton = new System.Windows.Forms.Button();
            this._buttonEdit = new System.Windows.Forms.Button();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 3;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tableLayoutPanel.Controls.Add(this._deleteButton, 2, 0);
            this._tableLayoutPanel.Controls.Add(this._buttonEdit, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._textBoxName, 0, 0);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 1;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(951, 96);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _deleteButton
            // 
            this._deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._deleteButton.Location = new System.Drawing.Point(834, 3);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(114, 90);
            this._deleteButton.TabIndex = 2;
            this._deleteButton.Text = "Delete";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this._deleteButton_Click);
            // 
            // _buttonEdit
            // 
            this._buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this._buttonEdit.Location = new System.Drawing.Point(716, 3);
            this._buttonEdit.Name = "_buttonEdit";
            this._buttonEdit.Size = new System.Drawing.Size(112, 90);
            this._buttonEdit.TabIndex = 1;
            this._buttonEdit.Text = "Edit";
            this._buttonEdit.UseVisualStyleBackColor = true;
            this._buttonEdit.Click += new System.EventHandler(this._buttonEdit_Click);
            // 
            // _textBoxName
            // 
            this._textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textBoxName.Location = new System.Drawing.Point(3, 3);
            this._textBoxName.Multiline = true;
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.ReadOnly = true;
            this._textBoxName.Size = new System.Drawing.Size(707, 90);
            this._textBoxName.TabIndex = 1;
            // 
            // CourseGuiEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "CourseGuiEntry";
            this.Size = new System.Drawing.Size(951, 96);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel _tableLayoutPanel;
        private TextBox _textBoxName;
        private Button _buttonEdit;
        private Button _deleteButton;
    }
}
