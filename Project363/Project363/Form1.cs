using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project363
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.jet.OleDb.4.0;" +
            @"Data Source=D:\CPE363\database\finalDB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // เมื่อฟอร์มปิด, ทำตามที่คุณต้องการ
            // ในที่นี้เราจะให้โปรแกรมหยุดทำงาน
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string login = "SELECT * FROM user_db WHERE username = '" + txtUser.Text + "'and password = '" + txtPass.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Login successful");
                Page1 page1 = new Page1();
                page1.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("The Username or password is incorrect");
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
            }
            con.Close();
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '•';
            }
        }
    }
}
