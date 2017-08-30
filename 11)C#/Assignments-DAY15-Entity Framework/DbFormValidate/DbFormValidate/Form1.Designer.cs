namespace DbFormValidate
{
    partial class Form1
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
            this.EmpID = new System.Windows.Forms.Label();
            this.EmpName = new System.Windows.Forms.Label();
            this.EmpSalary = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmpID
            // 
            this.EmpID.AutoSize = true;
            this.EmpID.Location = new System.Drawing.Point(37, 39);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(39, 13);
            this.EmpID.TabIndex = 0;
            this.EmpID.Text = "EmpID";
            // 
            // EmpName
            // 
            this.EmpName.AutoSize = true;
            this.EmpName.Location = new System.Drawing.Point(37, 94);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(56, 13);
            this.EmpName.TabIndex = 1;
            this.EmpName.Text = "EmpName";
            // 
            // EmpSalary
            // 
            this.EmpSalary.AutoSize = true;
            this.EmpSalary.Location = new System.Drawing.Point(37, 141);
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.Size = new System.Drawing.Size(57, 13);
            this.EmpSalary.TabIndex = 2;
            this.EmpSalary.Text = "EmpSalary";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(249, 39);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(170, 20);
            this.Id.TabIndex = 3;
            this.Id.TextChanged += new System.EventHandler(this.Id_TextChanged);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(249, 87);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(170, 20);
            this.Name.TabIndex = 4;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(249, 141);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(170, 20);
            this.Salary.TabIndex = 5;
            this.Salary.TextChanged += new System.EventHandler(this.Salary_TextChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Submit.Location = new System.Drawing.Point(97, 209);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Modify
            // 
            this.Modify.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Modify.Location = new System.Drawing.Point(228, 209);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(75, 23);
            this.Modify.TabIndex = 7;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = false;
            this.Modify.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete.Location = new System.Drawing.Point(359, 209);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.view.Location = new System.Drawing.Point(484, 39);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 149);
            this.view.TabIndex = 10;
            this.view.Text = "View All Records";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 261);
            this.Controls.Add(this.view);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.EmpSalary);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.EmpID);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmpID;
        private System.Windows.Forms.Label EmpName;
        private System.Windows.Forms.Label EmpSalary;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button view;
    }
}

