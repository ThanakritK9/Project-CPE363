using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project363
{
    public partial class AddEmployees : Form
    {

        private btnAbout oriForm;

        public AddEmployees(btnAbout oriForm)
        {
            InitializeComponent();
            this.oriForm = oriForm;
            this.FormClosed += AddEmployees_LoadClosed;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.OleDb.4.0;" +
            @"Data Source=D:\CPE363\database\finalDB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "" || txtCPass.Text == "" || txtFname.Text == "" || txtLname.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else if (txtPass.Text == txtCPass.Text)
            {
                try
                {
                    con.Open();
                    string register = "INSERT INTO user_db (username, [password], firstname, lastname, email) VALUES ('" + txtUser.Text + "','" + txtPass.Text + "','" + txtFname.Text + "','" + txtLname.Text + "','" + txtEmail.Text + "')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Success");

                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtCPass.Text = "";
                    txtFname.Text = "";
                    txtLname.Text = "";
                    txtEmail.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                oriForm?.ShowForm();
            }
            else
            {
                MessageBox.Show("Password does not match, Please try again");
                txtUser.Text = "";
                txtPass.Text = "";
                txtCPass.Text = "";
                txtFname.Text = "";
                txtLname.Text = "";
                txtEmail.Text = "";
                txtPass.Focus();
            }
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtCPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '•';
                txtCPass.PasswordChar = '•';
            }
        }

        private void AddEmployees_LoadClosed(object sender, FormClosedEventArgs e)
        {
            // เมื่อฟอร์มปิด, ทำตามที่คุณต้องการ
            // ในที่นี้เราจะให้โปรแกรมหยุดทำงาน
            Application.Exit();
        }
    }
}
