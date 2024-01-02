using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewForm1 : Form
    {
        public NewForm1()
        {
            InitializeComponent();
        }

        private void btnAddTree_Click(object sender, EventArgs e)
        {
            NewForm2 formAdd = new NewForm2();
            formAdd.ShowDialog();
        }
    }
}
