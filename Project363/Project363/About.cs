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
    public partial class btnAbout : Form
    {
        private Page1 originalForm;
        private OleDbConnection con;
        private OleDbDataAdapter da;
        private DataSet ds;

        public btnAbout(Page1 originalForm)
        {
            InitializeComponent();
            this.originalForm = originalForm;
            this.FormClosed += About_FormClosed;
            this.StartPosition = FormStartPosition.CenterScreen;
            con = new OleDbConnection("Provider=Microsoft.jet.OleDb.4.0;" +
                                        @"Data Source=D:\CPE363\database\finalDB.mdb");
        }

        private void About_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM user_db";
                da = new OleDbDataAdapter(sql, con);
                ds = new DataSet();
                da.Fill(ds, "user_db");
                dataGridView1.DataSource = ds.Tables["user_db"];
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

            txtID.DataBindings.Add("Text", ds, "user_db.id");
            txtFname.DataBindings.Add("Text", ds, "user_db.firstname"); 
            txtLname.DataBindings.Add("Text", ds, "user_db.lastname");
            txtEmail.DataBindings.Add("Text", ds, "user_db.email");
            this.BindingContext[ds, "user_db"].Position = 0;
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            // เมื่อฟอร์มปิด, ทำตามที่คุณต้องการ
            // ในที่นี้เราจะให้โปรแกรมหยุดทำงาน
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            originalForm?.ShowOriginalForm();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.Rows[index].Cells["id"].Value); // หรือแทน "id" ด้วยชื่อคอลัมน์ที่เก็บ ID

                // อัปเดตข้อมูลใน TextBoxes
                txtID.Text = ds.Tables["user_db"].Rows[index]["id"].ToString();
                txtFname.Text = ds.Tables["user_db"].Rows[index]["firstname"].ToString();
                txtLname.Text = ds.Tables["user_db"].Rows[index]["lastname"].ToString();
                txtEmail.Text = ds.Tables["user_db"].Rows[index]["email"].ToString();
            }
        }

        // เมื่อต้องการให้หน้าก่อนหน้ากลับมา

        private AddEmployees addEmployees;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEmployees = new AddEmployees(this);
            addEmployees.Show();
            Visible = false;
        }

        public void ShowForm()
        {
           this.Show();
           addEmployees.Hide();  // ปิดหน้า addEmployees
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM user_db";
                da = new OleDbDataAdapter(sql, con);
                ds = new DataSet();
                da.Fill(ds, "user_db");
                dataGridView1.DataSource = ds.Tables["user_db"];
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
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
