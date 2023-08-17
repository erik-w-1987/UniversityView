using System.Windows.Forms;

namespace UniversityViewer
{
    partial class GradeView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._buttonAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._comboBoxStudent = new System.Windows.Forms.ComboBox();
            this._comboBoxCourse = new System.Windows.Forms.ComboBox();
            this._comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this._flowLayoutPanel);
            this.panel1.Location = new System.Drawing.Point(3, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1514, 767);
            this.panel1.TabIndex = 0;
            // 
            // _flowLayoutPanel
            // 
            this._flowLayoutPanel.AutoScroll = true;
            this._flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._flowLayoutPanel.Name = "_flowLayoutPanel";
            this._flowLayoutPanel.Size = new System.Drawing.Size(1514, 767);
            this._flowLayoutPanel.TabIndex = 0;
            this._flowLayoutPanel.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grades";
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Location = new System.Drawing.Point(1130, 3);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(150, 59);
            this._buttonAdd.TabIndex = 2;
            this._buttonAdd.Text = "Add";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this._buttonAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1277, 56);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(641, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 56);
            this.label4.TabIndex = 2;
            this.label4.Text = "Grade";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(322, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 56);
            this.label3.TabIndex = 1;
            this.label3.Text = "Course";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _comboBoxStudent
            // 
            this._comboBoxStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxStudent.FormattingEnabled = true;
            this._comboBoxStudent.Location = new System.Drawing.Point(411, 10);
            this._comboBoxStudent.Name = "_comboBoxStudent";
            this._comboBoxStudent.Size = new System.Drawing.Size(301, 40);
            this._comboBoxStudent.TabIndex = 7;
            // 
            // _comboBoxCourse
            // 
            this._comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxCourse.FormattingEnabled = true;
            this._comboBoxCourse.Location = new System.Drawing.Point(721, 10);
            this._comboBoxCourse.Name = "_comboBoxCourse";
            this._comboBoxCourse.Size = new System.Drawing.Size(213, 40);
            this._comboBoxCourse.TabIndex = 8;
            // 
            // _comboBoxGrade
            // 
            this._comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxGrade.FormattingEnabled = true;
            this._comboBoxGrade.Location = new System.Drawing.Point(940, 10);
            this._comboBoxGrade.Name = "_comboBoxGrade";
            this._comboBoxGrade.Size = new System.Drawing.Size(184, 40);
            this._comboBoxGrade.TabIndex = 9;
            // 
            // GradeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._comboBoxGrade);
            this.Controls.Add(this._comboBoxCourse);
            this.Controls.Add(this._comboBoxStudent);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "GradeView";
            this.Size = new System.Drawing.Size(1520, 901);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel _flowLayoutPanel;
        private Button _buttonAdd;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox _comboBoxStudent;
        private ComboBox _comboBoxCourse;
        private ComboBox _comboBoxGrade;
    }
}
