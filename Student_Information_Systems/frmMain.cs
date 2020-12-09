using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_Systems
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin Switch = new frmLogin();
            this.Hide();
            Switch.ShowDialog();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            frmNewUser Switch = new frmNewUser();
            this.Hide();
            Switch.ShowDialog();
        }
    }
}
