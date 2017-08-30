namespace DbFormValidate
{
    partial class Delete
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
            this.emplid = new System.Windows.Forms.TextBox();
            this.EmpId = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emplid
            // 
            this.emplid.Location = new System.Drawing.Point(137, 33);
            this.emplid.Name = "emplid";
            this.emplid.Size = new System.Drawing.Size(100, 20);
            this.emplid.TabIndex = 0;
            this.emplid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmpId
            // 
            this.EmpId.AutoSize = true;
            this.EmpId.Location = new System.Drawing.Point(30, 36);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(37, 13);
            this.EmpId.TabIndex = 1;
            this.EmpId.Text = "EmpId";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(87, 167);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EmpId);
            this.Controls.Add(this.emplid);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emplid;
        private System.Windows.Forms.Label EmpId;
        private System.Windows.Forms.Button DeleteBtn;
    }
}