namespace DbFormValidate
{
    partial class Modify
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
            this.oldnm = new System.Windows.Forms.TextBox();
            this.Modi = new System.Windows.Forms.Button();
            this.newnm = new System.Windows.Forms.TextBox();
            this.EmpID = new System.Windows.Forms.Label();
            this.NewName = new System.Windows.Forms.Label();
            this.oldname = new System.Windows.Forms.Label();
            this.oldn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // oldnm
            // 
            this.oldnm.Location = new System.Drawing.Point(105, 6);
            this.oldnm.Name = "oldnm";
            this.oldnm.Size = new System.Drawing.Size(100, 20);
            this.oldnm.TabIndex = 0;
            this.oldnm.TextChanged += new System.EventHandler(this.old_TextChanged);
            // 
            // Modi
            // 
            this.Modi.Location = new System.Drawing.Point(105, 163);
            this.Modi.Name = "Modi";
            this.Modi.Size = new System.Drawing.Size(75, 23);
            this.Modi.TabIndex = 1;
            this.Modi.Text = "Modify";
            this.Modi.UseVisualStyleBackColor = true;
            this.Modi.Click += new System.EventHandler(this.Modi_Click);
            // 
            // newnm
            // 
            this.newnm.Location = new System.Drawing.Point(105, 94);
            this.newnm.Name = "newnm";
            this.newnm.Size = new System.Drawing.Size(100, 20);
            this.newnm.TabIndex = 2;
            this.newnm.TextChanged += new System.EventHandler(this.newnm_TextChanged);
            // 
            // EmpID
            // 
            this.EmpID.AutoSize = true;
            this.EmpID.Location = new System.Drawing.Point(13, 9);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(39, 13);
            this.EmpID.TabIndex = 3;
            this.EmpID.Text = "EmpID";
            // 
            // NewName
            // 
            this.NewName.AutoSize = true;
            this.NewName.Location = new System.Drawing.Point(16, 97);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(57, 13);
            this.NewName.TabIndex = 4;
            this.NewName.Text = "NewName";
            // 
            // oldname
            // 
            this.oldname.AutoSize = true;
            this.oldname.Location = new System.Drawing.Point(16, 52);
            this.oldname.Name = "oldname";
            this.oldname.Size = new System.Drawing.Size(51, 13);
            this.oldname.TabIndex = 5;
            this.oldname.Text = "OldName";
            // 
            // oldn
            // 
            this.oldn.Location = new System.Drawing.Point(105, 49);
            this.oldn.Name = "oldn";
            this.oldn.Size = new System.Drawing.Size(100, 20);
            this.oldn.TabIndex = 6;
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.oldn);
            this.Controls.Add(this.oldname);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.newnm);
            this.Controls.Add(this.Modi);
            this.Controls.Add(this.oldnm);
            this.Name = "Modify";
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldnm;
        private System.Windows.Forms.Button Modi;
        private System.Windows.Forms.TextBox newnm;
        private System.Windows.Forms.Label EmpID;
        private System.Windows.Forms.Label NewName;
        private System.Windows.Forms.Label oldname;
        private System.Windows.Forms.TextBox oldn;
    }
}