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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void newnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void old_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modi_Click(object sender, EventArgs e)
        {
            string oldnm1 = oldn.Text;
            string newnm1 = newnm.Text;
            ConnContext cc = new ConnContext();
            var emp = cc.Emps.Where(i => i.Name == oldnm1);
            foreach (var item in emp)
            {
                item.Name = newnm1;
            }
            cc.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Data updated succesfully");
        }
    }
}
