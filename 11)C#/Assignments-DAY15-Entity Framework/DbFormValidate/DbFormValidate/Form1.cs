using Conn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFormValidate
{
    public partial class Form1 : Form
    {
        public int id;
        public string name;
        public string sal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Id_TextChanged(object sender, EventArgs e)
        {
             id = Convert.ToInt32(Id.Text);
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            name = Name.Text;
        }

        private void Salary_TextChanged(object sender, EventArgs e)
        {
            sal = Salary.Text;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            using (var empl = new ConnContext())
            {
                var Obj = new Emp { Name = name, Salary = sal };
                empl.Emps.Add(Obj);
                empl.SaveChanges();
            }
            System.Windows.Forms.MessageBox.Show("Data submitted succesfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modify mod = new Modify();
            mod.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            ViewAll obj = new ViewAll();
            obj.ShowDialog();
        }
    }
}
