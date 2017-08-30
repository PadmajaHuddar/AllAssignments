using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conn;

namespace DbFormValidate
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(emplid.Text);
            ConnContext cc = new ConnContext();
            var empl = cc.Emps.FirstOrDefault(i => i.ID == id);
            cc.Emps.Remove(empl);
            cc.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Data deleted succesfully");
            Form1 obj = new Form1();
            obj.ShowDialog();
            this.Close();
        }
    }
}
