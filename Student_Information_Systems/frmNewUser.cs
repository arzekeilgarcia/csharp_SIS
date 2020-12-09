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
    public partial class frmNewUser : Form
    {
        OleDbConnection Connection = new OleDbConnection();
        OleDbCommand Command = new OleDbCommand();
        string Day, Month, Year, Date;
        public frmNewUser()
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
        private void btnJoin_Click(object sender, EventArgs e)
        {
            Day = cmbDay.Text;
            Month = cmbMonth.Text;
            Year = cmbYear.Text;
            Date = Day + "/" + Month + "/" + Year;
            DateTime dateTime = Convert.ToDateTime(Date);
            MessageBox.Show(dateTime.Day + " " + dateTime.Month + " " + dateTime.Year);
            /*
            Connection.Open();
            Command.Connection = Connection;
            Command.CommandText = "INSERT INTO tblStudents (FirstName, LastName, UserName, Password, DOB) VALUES ('" + txtFirstName.Text +
            "','" + txtLastName.Text + "','" + txtUserName.Text + "','" + txtPassword.Text + "')";
            Connection.Close();
            */
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain Switch = new frmMain();
            this.Hide();
            Switch.ShowDialog();
        }

        
    }
}
