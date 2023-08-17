using System.Windows.Forms;

namespace UniversityViewer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this._gradesButton = new System.Windows.Forms.Button();
            this._CoursesButton = new System.Windows.Forms.Button();
            this._studentsButton = new System.Windows.Forms.Button();
            this._mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this._gradesButton);
            this.panel1.Controls.Add(this._CoursesButton);
            this.panel1.Controls.Add(this._studentsButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 901);
            this.panel1.TabIndex = 0;
            // 
            // _gradesButton
            // 
            this._gradesButton.Location = new System.Drawing.Point(56, 240);
            this._gradesButton.Name = "_gradesButton";
            this._gradesButton.Size = new System.Drawing.Size(233, 71);
            this._gradesButton.TabIndex = 3;
            this._gradesButton.Text = "Grades";
            this._gradesButton.UseVisualStyleBackColor = true;
            this._gradesButton.Click += new System.EventHandler(this._gradesButton_Click);
            // 
            // _CoursesButton
            // 
            this._CoursesButton.Location = new System.Drawing.Point(56, 135);
            this._CoursesButton.Name = "_CoursesButton";
            this._CoursesButton.Size = new System.Drawing.Size(233, 71);
            this._CoursesButton.TabIndex = 2;
            this._CoursesButton.Text = "Courses";
            this._CoursesButton.UseVisualStyleBackColor = true;
            this._CoursesButton.Click += new System.EventHandler(this._CoursesButton_Click);
            // 
            // _studentsButton
            // 
            this._studentsButton.Location = new System.Drawing.Point(56, 25);
            this._studentsButton.Name = "_studentsButton";
            this._studentsButton.Size = new System.Drawing.Size(233, 71);
            this._studentsButton.TabIndex = 1;
            this._studentsButton.Text = "Students";
            this._studentsButton.UseVisualStyleBackColor = true;
            this._studentsButton.Click += new System.EventHandler(this._studentsButton_Click);
            // 
            // _mainPanel
            // 
            this._mainPanel.Location = new System.Drawing.Point(405, 12);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(1521, 901);
            this._mainPanel.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2113, 930);
            this.Controls.Add(this._mainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button _studentsButton;
        private Button _CoursesButton;
        private Button _gradesButton;
        private Panel _mainPanel;
    }
}