using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Student_Information_Systems
{
    public partial class frmAdmin : Form
    {
        OleDbConnection Connection = new OleDbConnection();
        OleDbCommand Command = new OleDbCommand();
        string CurrentUser = frmLogin.getCurrentUser();
        public frmAdmin()
        {
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\ICS4U1\Unit_4\Assignment\Assignment_4\Student_Information_Systems\bin\Debug\Students.accdb";
            InitializeComponent();
            try
            {
                Connection.Open();
                Connection.Close();
            }
            catch
            {
                Connection.Close();
                MessageBox.Show("Connection To Database Is Unsuccessful");
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
        }
    }
}
