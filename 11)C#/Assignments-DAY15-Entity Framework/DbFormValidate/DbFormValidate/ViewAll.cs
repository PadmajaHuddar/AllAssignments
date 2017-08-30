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
    public partial class ViewAll : Form
    {
        public ViewAll()
        {
            InitializeComponent();
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Conn_ConnContextDataSet.Emps' table. You can move, or remove it, as needed.
            this.empsTableAdapter.Fill(this._Conn_ConnContextDataSet.Emps);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.ShowDialog();
        }
    }
}
