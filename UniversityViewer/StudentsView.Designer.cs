using System.Windows.Forms;

namespace UniversityViewer
{
    partial class StudentsView
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
            this._textBoxFirstName = new System.Windows.Forms.TextBox();
            this._textBoxLastName = new System.Windows.Forms.TextBox();
            this._textBoxRegId = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(144, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
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
            // _textBoxFirstName
            // 
            this._textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._textBoxFirstName.Location = new System.Drawing.Point(504, 8);
            this._textBoxFirstName.Multiline = true;
            this._textBoxFirstName.Name = "_textBoxFirstName";
            this._textBoxFirstName.Size = new System.Drawing.Size(194, 54);
            this._textBoxFirstName.TabIndex = 3;
            this._textBoxFirstName.Tag = "";
            this._textBoxFirstName.Text = "First Name";
            this._textBoxFirstName.Visible = false;
            // 
            // _textBoxLastName
            // 
            this._textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._textBoxLastName.Location = new System.Drawing.Point(715, 8);
            this._textBoxLastName.Multiline = true;
            this._textBoxLastName.Name = "_textBoxLastName";
            this._textBoxLastName.Size = new System.Drawing.Size(194, 54);
            this._textBoxLastName.TabIndex = 4;
            this._textBoxLastName.Text = "Last Name";
            this._textBoxLastName.Visible = false;
            // 
            // _textBoxRegId
            // 
            this._textBoxRegId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._textBoxRegId.Location = new System.Drawing.Point(930, 8);
            this._textBoxRegId.Multiline = true;
            this._textBoxRegId.Name = "_textBoxRegId";
            this._textBoxRegId.Size = new System.Drawing.Size(194, 54);
            this._textBoxRegId.TabIndex = 5;
            this._textBoxRegId.Text = "Registration Nr";
            this._textBoxRegId.Visible = false;
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
            this.label4.Text = "Registration Nr.";
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
            this.label3.Text = "Last Name";
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
            this.label2.Text = "First Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StudentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this._textBoxRegId);
            this.Controls.Add(this._textBoxLastName);
            this.Controls.Add(this._textBoxFirstName);
            this.Controls.Add(this._buttonAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "StudentsView";
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
        private TextBox _textBoxFirstName;
        private TextBox _textBoxLastName;
        private TextBox _textBoxRegId;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
