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
    public partial class frmLogin : Form
    {
        OleDbConnection Connection = new OleDbConnection();
        OleDbCommand Command = new OleDbCommand();
        private static string CurrentUser = "";
        public frmLogin()
        {
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\ICS4U1\Unit_4\Assignment\Assignment_4\Student_Information_Systems\bin\Debug\Students.accdb"; 
            InitializeComponent();
            try
            {
                Connection.Open();
                lblConnection.Text = "Connection: Connected";
                Connection.Close();
            }
            catch
            {
                Connection.Close();
                MessageBox.Show("Connection To Database Is Unsuccessful");
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain Switch = new frmMain();
            this.Hide();
            Switch.ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = "SELECT * FROM tblStudents WHERE UserName='" + txtUserName.Text + "'AND Password='" + txtPassword.Text + "'";
            int Counter = 0;
            string FirstName = "", LastName = "";
            OleDbDataReader Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Counter++;
                FirstName = Reader["FirstName"].ToString();
                LastName = Reader["LastName"].ToString();
            }
            if (Counter == 1)
            {
                MessageBox.Show("Welcome " + FirstName + " " + LastName);
                this.Hide();
                if (txtUserName.Text.ToLower() == "admin")
                {
                    setCurrentUser();
                    getCurrentUser();
                    frmAdmin Switch = new frmAdmin();
                    Switch.ShowDialog();
                }
                else
                {
                    setCurrentUser();
                    getCurrentUser();
                    frmUser Switch = new frmUser();
                    Switch.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Go Away " + txtUserName.Text);
            }
            Reader.Close();
            Connection.Close();
        }
        public void setCurrentUser()
        {
            CurrentUser = txtUserName.Text;
        }
        public static string getCurrentUser()
        {
            return CurrentUser;
        }
    }
}
