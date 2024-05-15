using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project363
{
    public partial class Page1 : Form
    {

        public Page1()
        {
            InitializeComponent();
            this.FormClosed += Page1_FormClosed;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        int p1 = 300,p2 = 150, p3 = 199, p4 = 380, p5 = 50, p6 = 99;
        int OD1 = 0, OD2 = 0, OD3 = 0, OD4 = 0, OD5 = 0, OD6 = 0;
        int pd1 = 0, pd2 = 0, pd3 = 0, pd4 = 0, pd5 = 0, pd6 = 0;
        double TotalPrice = 0;

    private void Page1_Load(object sender, EventArgs e)
        {
            txtPrice1.Text = p1.ToString();
            txtPrice2.Text = p2.ToString();
            txtPrice3.Text = p3.ToString();
            txtPrice4.Text = p4.ToString();
            txtPrice5.Text = p5.ToString();
            txtPrice6.Text = p6.ToString();
            pd1 = p1;
            pd2 = p2;
            pd3 = p3;
            pd4 = p4;
            pd5 = p5;
            pd6 = p6;
            lblP1.Text = "0";
            lblP2.Text = "0";
            lblP3.Text = "0";
            lblP4.Text = "0";
            lblP5.Text = "0";
            lblP6.Text = "0";
            txtPrice1.Enabled = false;
            txtPrice2.Enabled = false;
            txtPrice3.Enabled = false;
            txtPrice4.Enabled = false;
            txtPrice5.Enabled = false;
            txtPrice6.Enabled = false;
            btnSave1.Enabled = false;
            btnSave2.Enabled = false;
            btnSave3.Enabled = false;
            btnSave4.Enabled = false;
            btnSave5.Enabled = false;
            btnSave6.Enabled = false;;
            btnQ1.Enabled = false;
            btnQ2.Enabled = false;
            btnQ3.Enabled = false;
            btnQ4.Enabled = false;
            btnQ5.Enabled = false;
            btnQ6.Enabled = false;
            txtQ1.Text = "1";
            txtQ2.Text = "1";
            txtQ3.Text = "1";
            txtQ4.Text = "1";
            txtQ5.Text = "1";
            txtQ6.Text = "1";
            txtQ1.Enabled = false;
            txtQ2.Enabled = false;
            txtQ3.Enabled = false;
            txtQ4.Enabled = false;
            txtQ5.Enabled = false;
            txtQ6.Enabled = false;
            btnClear.Enabled = false;
            btnTotalPrice.Enabled = false;
            btnSO.Enabled = false;
            btnSTTP.Enabled = false;
            btnSO.BackColor = SystemColors.Control;
            btnSTTP.BackColor = SystemColors.Control;
            btnCalculate.Enabled = false;
        }

        private void btnCP1_Click(object sender, EventArgs e)
        {
            txtPrice1.Enabled = true;
            txtPrice1.Text = "";
            btnSave1.Enabled=true;
            btnCP1.Enabled=false;
            btnAdd1.Enabled = false;
        }

        private void btnCP2_Click(object sender, EventArgs e)
        {
            txtPrice2.Enabled = true;
            txtPrice2.Text = "";
            btnSave2.Enabled = true;
            btnCP2.Enabled = false;
            btnAdd2.Enabled = false;
        }

        private void btnCP3_Click(object sender, EventArgs e)
        {
            txtPrice3.Enabled = true;
            txtPrice3.Text = "";
            btnSave3.Enabled=true;
            btnCP3.Enabled = false;
            btnAdd3.Enabled = false;
        }

        private void btnCP4_Click(object sender, EventArgs e)
        {
            txtPrice4.Enabled = true;
            txtPrice4.Text = "";
            btnSave4.Enabled=true;
            btnCP4.Enabled = false;
            btnAdd4.Enabled=false;
        }

        private void btnCP5_Click(object sender, EventArgs e)
        {
            txtPrice5.Enabled = true;
            txtPrice5.Text = "";
            btnSave5.Enabled=true;
            btnCP5.Enabled = false;
            btnAdd5.Enabled=false;
        }

        private void btnCP6_Click(object sender, EventArgs e)
        {
            txtPrice6.Enabled = true;
            txtPrice6.Text = "";
            btnSave6.Enabled=true;
            btnCP6.Enabled = false;
            btnAdd6.Enabled=false;
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            txtPrice1.Enabled = false;
            p1 = Convert.ToInt32(txtPrice1.Text);
            txtPrice1.Text = p1.ToString();
            pd1 = p1;
            btnSave1 .Enabled = false;
            btnAdd1.Enabled = true;
            btnCP1.Enabled = true;
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            txtPrice2.Enabled = false;
            p2 = Convert.ToInt32(txtPrice2.Text);
            txtPrice2.Text = p2.ToString();
            pd2 = p2;
            btnSave2.Enabled = false;
            btnAdd2.Enabled = true;
            btnCP2.Enabled = true;
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            txtPrice3.Enabled = false;
            p3 = Convert.ToInt32(txtPrice3.Text);
            txtPrice3.Text = p3.ToString();
            pd3 = p3;
            btnSave3.Enabled = false;
            btnAdd3.Enabled = true;
            btnCP3.Enabled = true;
        }

        private void btnSave4_Click(object sender, EventArgs e)
        {
            txtPrice4.Enabled = false;
            p4 = Convert.ToInt32(txtPrice4.Text);
            txtPrice4.Text = p4.ToString();
            pd4 = p4;
            btnSave4.Enabled = false;
            btnAdd4.Enabled = true;
            btnCP4.Enabled = true;
        }

        private void btnSave5_Click(object sender, EventArgs e)
        {
            txtPrice5.Enabled = false;
            p5 = Convert.ToInt32(txtPrice5.Text);
            txtPrice5.Text = p5.ToString();
            pd5 = p5;
            btnSave5 .Enabled = false;
            btnAdd5.Enabled = true;
            btnCP5.Enabled = true;
        }

        private void btnSave6_Click(object sender, EventArgs e)
        {
            txtPrice6.Enabled = false;
            p6 = Convert.ToInt32(txtPrice6.Text);
            txtPrice6.Text = p6.ToString();
            pd6 = p6;
            btnSave6.Enabled = false;
            btnAdd6.Enabled = true;
            btnCP6.Enabled = true;
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd1 .Enabled = false;
            lblOrder.Text = "This Order";
            if (OD1 == 0)
            {
                lblPD1.Text = lbl1.Text;
                lblP1.Text = p1.ToString();
                OD1 = 1;
            }
            else if (OD2 == 0)
            {
                lblPD2.Text = lbl1.Text;
                lblP2.Text = p1.ToString();
                OD2 = 1;
            }
            else if (OD3 == 0)
            {
                lblPD3.Text = lbl1.Text;
                lblP3.Text = p1.ToString();
                OD3 = 1;
            }
            else if (OD4 == 0)
            {
                lblPD4.Text = lbl1.Text;
                lblP4.Text = p1.ToString();
                OD4 = 1;
            }
            else if (OD5 == 0)
            {
                lblPD5.Text = lbl1.Text;
                lblP5.Text = p1.ToString();
                OD5 = 1;
            }
            else if (OD6 == 0)
            {
                lblPD6.Text = lbl1.Text;
                lblP6.Text = p1.ToString();
                OD6 = 1;
            }
            else
            {
                MessageBox.Show("Please clear the order.");
                btnAdd1.Enabled = true;
            }
            btnCP1.Enabled = false;
            btnTotalPrice.Enabled = true;
            if (lblP1.Text != "0")
            {
                txtQ1.Enabled = true;
                btnQ1.Enabled = true;
            }
            if (lblP2.Text != "0")
            {
                txtQ2.Enabled = true;
                btnQ2.Enabled = true;
            }
            if (lblP3.Text != "0")
            {
                txtQ3.Enabled = true;
                btnQ3.Enabled = true;
            }
            if (lblP4.Text != "0")
            {
                txtQ4.Enabled = true;
                btnQ4.Enabled = true;
            }
            if (lblP5.Text != "0")
            {
                txtQ5.Enabled = true;
                btnQ5.Enabled = true;
            }
            if (lblP6.Text != "0")
            {
                txtQ6.Enabled = true;
                btnQ6.Enabled = true;
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd2.Enabled = false;
            lblOrder.Text = "This Order";
            if (OD1 == 0)
            {
                lblPD1.Text = lbl2.Text;
                lblP1.Text = p2.ToString();
                OD1 = 1;
            }
            else if (OD2 == 0)
            {
                lblPD2.Text = lbl2.Text;
                lblP2.Text = p2.ToString();
                OD2 = 1;
            }
            else if (OD3 == 0)
            {
                lblPD3.Text = lbl2.Text;
                lblP3.Text = p2.ToString();
                OD3 = 1;
            }
            else if (OD4 == 0)
            {
                lblPD4.Text = lbl2.Text;
                lblP4.Text = p2.ToString();
                OD4 = 1;
            }
            else if (OD5 == 0)
            {
                lblPD5.Text = lbl2.Text;
                lblP5.Text = p2.ToString();
                OD5 = 1;
            }
            else if (OD6 == 0)
            {
                lblPD6.Text = lbl2.Text;
                lblP6.Text = p2.ToString();
                OD6 = 1;
            }
            else
            {
                MessageBox.Show("Please clear the order.");
                btnAdd2.Enabled = true;
            }
            btnCP2.Enabled = false;
            btnTotalPrice.Enabled = true;
            if (lblP1.Text != "0")
            {
                txtQ1.Enabled = true;
                btnQ1.Enabled = true;
            }
            if (lblP2.Text != "0")
            {
                txtQ2.Enabled = true;
                btnQ2.Enabled = true;
            }
            if (lblP3.Text != "0")
            {
                txtQ3.Enabled = true;
                btnQ3.Enabled = true;
            }
            if (lblP4.Text != "0")
            {
                txtQ4.Enabled = true;
                btnQ4.Enabled = true;
            }
            if (lblP5.Text != "0")
            {
                txtQ5.Enabled = true;
                btnQ5.Enabled = true;
            }
            if (lblP6.Text != "0")
            {
                txtQ6.Enabled = true;
                btnQ6.Enabled = true;
            }
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd3.Enabled = false;
            lblOrder.Text = "This Order";
            if (OD1 == 0)
            {
                lblPD1.Text = lbl3.Text;
                lblP1.Text = p3.ToString();
                OD1 = 1;
            }
            else if (OD2 == 0)
            {
                lblPD2.Text = lbl3.Text;
                lblP2.Text = p3.ToString();
                OD2 = 1;
            }
            else if (OD3 == 0)
            {
                lblPD3.Text = lbl3.Text;
                lblP3.Text = p3.ToString();
                OD3 = 1;
            }
            else if (OD4 == 0)
            {
                lblPD4.Text = lbl3.Text;
                lblP4.Text = p3.ToString();
                OD4 = 1;
            }
            else if (OD5 == 0)
            {
                lblPD5.Text = lbl3.Text;
                lblP5.Text = p3.ToString();
                OD5 = 1;
            }
            else if (OD6 == 0)
            {
                lblPD6.Text = lbl3.Text;
                lblP6.Text = p3.ToString();
                OD6 = 1;
            }
            else
            {
                MessageBox.Show("Please clear the order.");
                btnAdd3.Enabled = true;
            }
            btnCP3.Enabled = false;
            btnTotalPrice.Enabled = true;
            if (lblP1.Text != "0")
            {
                txtQ1.Enabled = true;
                btnQ1.Enabled = true;
            }
            if (lblP2.Text != "0")
            {
                txtQ2.Enabled = true;
                btnQ2.Enabled = true;
            }
            if (lblP3.Text != "0")
            {
                txtQ3.Enabled = true;
                btnQ3.Enabled = true;
            }
            if (lblP4.Text != "0")
            {
                txtQ4.Enabled = true;
                btnQ4.Enabled = true;
            }
            if (lblP5.Text != "0")
            {
                txtQ5.Enabled = true;
                btnQ5.Enabled = true;
            }
            if (lblP6.Text != "0")
            {
                txtQ6.Enabled = true;
                btnQ6.Enabled = true;
            }
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd4.Enabled = false;
            lblOrder.Text = "This Order";
            if (OD1 == 0)
            {
                lblPD1.Text = lbl4.Text;
                lblP1.Text = p4.ToString();
                OD1 = 1;
            }
            else if (OD2 == 0)
            {
                lblPD2.Text = lbl4.Text;
                lblP2.Text = p4.ToString();
                OD2 = 1;
            }
            else if (OD3 == 0)
            {
                lblPD3.Text = lbl4.Text;
                lblP3.Text = p4.ToString();
                OD3 = 1;
            }
            else if (OD4 == 0)
            {
                lblPD4.Text = lbl4.Text;
                lblP4.Text = p4.ToString();
                OD4 = 1;
            }
            else if (OD5 == 0)
            {
                lblPD5.Text = lbl4.Text;
                lblP5.Text = p4.ToString();
                OD5 = 1;
            }
            else if (OD6 == 0)
            {
                lblPD6.Text = lbl4.Text;
                lblP6.Text = p4.ToString();
                OD6 = 1;
            }
            else
            {
                MessageBox.Show("Please clear the order.");
                btnAdd4.Enabled = true;
            }
            btnCP4.Enabled = false;
            btnTotalPrice.Enabled = true;
            if (lblP1.Text != "0")
            {
                txtQ1.Enabled = true;
                btnQ1.Enabled = true;
            }
            if (lblP2.Text != "0")
            {
                txtQ2.Enabled = true;
                btnQ2.Enabled = true;
            }
            if (lblP3.Text != "0")
            {
                txtQ3.Enabled = true;
                btnQ3.Enabled = true;
            }
            if (lblP4.Text != "0")
            {
                txtQ4.Enabled = true;
                btnQ4.Enabled = true;
            }
            if (lblP5.Text != "0")
            {
                txtQ5.Enabled = true;
                btnQ5.Enabled = true;
            }
            if (lblP6.Text != "0")
            {
                txtQ6.Enabled = true;
                btnQ6.Enabled = true;
            }
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd5.Enabled = false;
            lblOrder.Text = "This Order";
            if (OD1 == 0)
            {
                lblPD1.Text = lbl5.Text;
                lblP1.Text = p5.ToString();
                OD1 = 1;
            }
            else if (OD2 == 0)
            {
                lblPD2.Text = lbl5.Text;
                lblP2.Text = p5.ToString();
                OD2 = 1;
            }
            else if (OD3 == 0)
            {
                lblPD3.Text = lbl5.Text;
                lblP3.Text = p5.ToString();
                OD3 = 1;
            }
            else if (OD4 == 0)
            {
                lblPD4.Text = lbl5.Text;
                lblP4.Text = p5.ToString();
                OD4 = 1;
            }
            else if (OD5 == 0)
            {
                lblPD5.Text = lbl5.Text;
                lblP5.Text = p5.ToString();
                OD5 = 1;
            }
            else if (OD6 == 0)
            {
                lblPD6.Text = lbl5.Text;
                lblP6.Text = p5.ToString();
                OD6 = 1;
            }
            else
            {
                MessageBox.Show("Please clear the order.");
                btnAdd5.Enabled = true;
            }
            btnCP5.Enabled = false;
            btnTotalPrice.Enabled = true;
            if (lblP1.Text != "0")
            {
                txtQ1.Enabled = true;
                btnQ1.Enabled = true;
            }
            if (lblP2.Text != "0")
            {
                txtQ2.Enabled = true;
                btnQ2.Enabled = true;
            }
            if (lblP3.Text != "0")
            {
                txtQ3.Enabled = true;
                btnQ3.Enabled = true;
            }
            if (lblP4.Text != "0")
            {
                txtQ4.Enabled = true;
                btnQ4.Enabled = true;
            }
            if (lblP5.Text != "0")
            {
                txtQ5.Enabled = true;
                btnQ5.Enabled = true;
            }
            if (lblP6.Text != "0")
            {
                txtQ6.Enabled = true;
                btnQ6.Enabled = true;
            }
        }

        private void btnAdd6_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = true;
            btnAdd6.Enabled = false;
            lblOrder.Text = "This Order";
            if (OD1 == 0)
            {
                lblPD1.Text = lbl6.Text;
                lblP1.Text = p6.ToString();
                OD1 = 1;
            }
            else if (OD2 == 0)
            {
                lblPD2.Text = lbl6.Text;
                lblP2.Text = p6.ToString();
                OD2 = 1;
            }
            else if (OD3 == 0)
            {
                lblPD3.Text = lbl6.Text;
                lblP3.Text = p6.ToString();
                OD3 = 1;
            }
            else if (OD4 == 0)
            {
                lblPD4.Text = lbl6.Text;
                lblP4.Text = p6.ToString();
                OD4 = 1;
            }
            else if (OD5 == 0)
            {
                lblPD5.Text = lbl6.Text;
                lblP5.Text = p6.ToString();
                OD5 = 1;
            }
            else if (OD6 == 0)
            {
                lblPD6.Text = lbl6.Text;
                lblP6.Text = p6.ToString();
                OD6 = 1;
            }
            else
            {
                MessageBox.Show("Please clear the order.");
                btnAdd6.Enabled = true;
            }
            btnCP6.Enabled = false;
            btnTotalPrice.Enabled = true;
            if (lblP1.Text != "0")
            {
                txtQ1.Enabled = true;
                btnQ1.Enabled = true;
            }
            if (lblP2.Text != "0")
            {
                txtQ2.Enabled = true;
                btnQ2.Enabled = true;
            }
            if (lblP3.Text != "0")
            {
                txtQ3.Enabled = true;
                btnQ3.Enabled = true;
            }
            if (lblP4.Text != "0")
            {
                txtQ4.Enabled = true;
                btnQ4.Enabled = true;
            }
            if (lblP5.Text != "0")
            { 
                txtQ5.Enabled = true;
                btnQ5.Enabled = true;
            }
            if (lblP6.Text != "0")
            {
                txtQ6.Enabled = true;
                btnQ6.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            btnTotalPrice.Enabled = false;
            lblOrder.Text = "Order Cleared";
            btnAdd1.Enabled = true;
            btnAdd2.Enabled = true;
            btnAdd3.Enabled = true;
            btnAdd4.Enabled = true;
            btnAdd5.Enabled = true;
            btnAdd6.Enabled = true;
            btnCP1.Enabled = true;
            btnCP2.Enabled = true;
            btnCP3.Enabled = true;
            btnCP4.Enabled = true;
            btnCP5.Enabled = true;
            btnCP6.Enabled = true;
            btnQ1.Enabled = false;
            btnQ2.Enabled = false;
            btnQ3.Enabled = false;
            btnQ4.Enabled = false;
            btnQ5.Enabled = false;
            btnQ6.Enabled = false;
            txtQ1.Enabled = false;
            txtQ2.Enabled = false;
            txtQ3.Enabled = false;
            txtQ4.Enabled = false;
            txtQ5.Enabled = false;
            txtQ6.Enabled = false;
            btnSO.Enabled = false;
            btnSTTP.Enabled = false;
            lblPD1.Text = "";
            lblPD2.Text = "";
            lblPD3.Text = "";
            lblPD4.Text = "";
            lblPD5.Text = "";
            lblPD6.Text = "";
            lblP1.Text = "0";
            lblP2.Text = "0";
            lblP3.Text = "0";
            lblP4.Text = "0";
            lblP5.Text = "0";
            lblP6.Text = "0";
            txtQ1.Text = "1";
            txtQ2.Text = "1";
            txtQ3.Text = "1";
            txtQ4.Text = "1";
            txtQ5.Text = "1";
            txtQ6.Text = "1";
            lblTotalPrice.Text = "";
            OD1 = 0;
            OD2 = 0;
            OD3 = 0;
            OD4 = 0;
            OD5 = 0;
            OD6 = 0;
            p1 = Convert.ToInt32(txtPrice1.Text);
            p2 = Convert.ToInt32(txtPrice2.Text);
            p3 = Convert.ToInt32(txtPrice3.Text);
            p4 = Convert.ToInt32(txtPrice4.Text);
            p5 = Convert.ToInt32(txtPrice5.Text);
            p6 = Convert.ToInt32(txtPrice6.Text);
            pd1 = Convert.ToInt32(txtPrice1.Text);
            pd2 = Convert.ToInt32(txtPrice2.Text);
            pd3 = Convert.ToInt32(txtPrice3.Text);
            pd4 = Convert.ToInt32(txtPrice4.Text);
            pd5 = Convert.ToInt32(txtPrice5.Text);
            pd6 = Convert.ToInt32(txtPrice6.Text);
        }

        private void btnQ1_Click(object sender, EventArgs e)
        {
            if (lblP1.Text == pd1.ToString() && lblPD1.Text == lbl1.Text)
            {
                pd1 = p1 * Convert.ToInt32(txtQ1.Text);
                lblP1.Text = pd1.ToString();
            }
            else if (lblP1.Text == pd2.ToString() && lblPD1.Text == lbl2.Text)
            {
                pd2 = p2 * Convert.ToInt32(txtQ1.Text);
                lblP1.Text = pd2.ToString();
            }
            else if (lblP1.Text == pd3.ToString() && lblPD1.Text == lbl3.Text)
            {
                pd3 = p3 * Convert.ToInt32(txtQ1.Text);
                lblP1.Text = pd3.ToString();
            }
            else if (lblP1.Text == pd4.ToString() && lblPD1.Text == lbl4.Text)
            {
                pd4 = p4 * Convert.ToInt32(txtQ1.Text);
                lblP1.Text = pd4.ToString();
            }
            else if (lblP1.Text == pd5.ToString() && lblPD1.Text == lbl5.Text)
            {
                pd5 = p5 * Convert.ToInt32(txtQ1.Text);
                lblP1.Text = pd5.ToString();
            }
            else if (lblP1.Text == pd6.ToString() && lblPD1.Text == lbl6.Text)
            {
                pd6 = p6 * Convert.ToInt32(txtQ1.Text);
                lblP1.Text = pd6.ToString();
            }

        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
            if (lblP2.Text == pd1.ToString() && lblPD2.Text == lbl1.Text)
            {
                pd1 = p1 * Convert.ToInt32(txtQ2.Text);
                lblP2.Text = pd1.ToString();
            }
            else if (lblP2.Text == pd2.ToString() && lblPD2.Text == lbl2.Text)
            {
                pd2 = p2 * Convert.ToInt32(txtQ2.Text);
                lblP2.Text = pd2.ToString();
            }
            else if (lblP2.Text == pd3.ToString() && lblPD2.Text == lbl3.Text)
            {
                pd3 = p3 * Convert.ToInt32(txtQ2.Text);
                lblP2.Text = pd3.ToString();
            }
            else if (lblP2.Text == pd4.ToString() && lblPD2.Text == lbl4.Text)
            {
                pd4 = p4 * Convert.ToInt32(txtQ2.Text);
                lblP2.Text = pd4.ToString();
            }
            else if (lblP2.Text == pd5.ToString() && lblPD2.Text == lbl5.Text)
            {
                pd5 = p5 * Convert.ToInt32(txtQ2.Text);
                lblP2.Text = pd5.ToString();
            }
            else if (lblP2.Text == pd6.ToString() && lblPD2.Text == lbl6.Text)
            {
                pd6 = p6 * Convert.ToInt32(txtQ2.Text);
                lblP2.Text = pd6.ToString();
            }
        }


        private void btnQ3_Click(object sender, EventArgs e)
        {
            if (lblP3.Text == pd1.ToString() && lblPD3.Text == lbl1.Text)
            {
                pd1 = p1 * Convert.ToInt32(txtQ3.Text);
                lblP3.Text = pd1.ToString();
            }
            else if (lblP3.Text == pd2.ToString() && lblPD3.Text == lbl2.Text)
            {
                pd2 = p2 * Convert.ToInt32(txtQ3.Text);
                lblP3.Text = pd2.ToString();
            }
            else if (lblP3.Text == pd3.ToString() && lblPD3.Text == lbl3.Text)
            {
                pd3 = p3 * Convert.ToInt32(txtQ3.Text);
                lblP3.Text = pd3.ToString();
            }
            else if (lblP3.Text == pd4.ToString() && lblPD3.Text == lbl4.Text)
            {
                pd4 = p4 * Convert.ToInt32(txtQ3.Text);
                lblP3.Text = pd4.ToString();
            }
            else if (lblP3.Text == pd5.ToString() && lblPD3.Text == lbl5.Text)
            {
                pd5 = p5 * Convert.ToInt32(txtQ3.Text);
                lblP3.Text = pd5.ToString();
            }
            else if (lblP3.Text == pd6.ToString() && lblPD3.Text == lbl6.Text)
            {
                pd6 = p6 * Convert.ToInt32(txtQ3.Text);
                lblP3.Text = pd6.ToString();
            }
        }

        private void btnQ4_Click(object sender, EventArgs e)
        {
            if (lblP4.Text == pd1.ToString() && lblPD4.Text == lbl1.Text)
            {
                pd1 = p1 * Convert.ToInt32(txtQ4.Text);
                lblP4.Text = pd1.ToString();
            }
            else if (lblP4.Text == pd2.ToString() && lblPD4.Text == lbl2.Text)
            {
                pd2 = p2 * Convert.ToInt32(txtQ4.Text);
                lblP4.Text = pd2.ToString();
            }
            else if (lblP4.Text == pd3.ToString() && lblPD4.Text == lbl3.Text)
            {
                pd3 = p3 * Convert.ToInt32(txtQ4.Text);
                lblP4.Text = pd3.ToString();
            }
            else if (lblP4.Text == pd4.ToString() && lblPD4.Text == lbl4.Text)
            {
                pd4 = p4 * Convert.ToInt32(txtQ4.Text);
                lblP4.Text = pd4.ToString();
            }
            else if (lblP4.Text == pd5.ToString() && lblPD4.Text == lbl5.Text)
            {
                pd5 = p5 * Convert.ToInt32(txtQ4.Text);
                lblP4.Text = pd5.ToString();
            }
            else if (lblP4.Text == pd6.ToString() && lblPD4.Text == lbl6.Text)
            {
                pd6 = p6 * Convert.ToInt32(txtQ4.Text);
                lblP4.Text = pd6.ToString();
            }
        }

        private void btnQ5_Click(object sender, EventArgs e)
        {
            if (lblP5.Text == pd1.ToString() && lblPD5.Text == lbl1.Text)
            {
                pd1 = p1 * Convert.ToInt32(txtQ5.Text);
                lblP5.Text = pd1.ToString();
            }
            else if (lblP5.Text == pd2.ToString() && lblPD5.Text == lbl2.Text)
            {
                pd2 = p2 * Convert.ToInt32(txtQ5.Text);
                lblP5.Text = pd2.ToString();
            }
            else if (lblP5.Text == pd3.ToString() && lblPD5.Text == lbl3.Text)
            {
                pd3 = p3 * Convert.ToInt32(txtQ5.Text);
                lblP5.Text = pd3.ToString();
            }
            else if (lblP5.Text == pd4.ToString() && lblPD5.Text == lbl4.Text)
            {
                pd4 = p4 * Convert.ToInt32(txtQ5.Text);
                lblP5.Text = pd4.ToString();
            }
            else if (lblP5.Text == pd5.ToString() && lblPD5.Text == lbl5.Text)
            {
                pd5 = p5 * Convert.ToInt32(txtQ5.Text);
                lblP5.Text = pd5.ToString();
            }
            else if (lblP5.Text == pd6.ToString() && lblPD5.Text == lbl6.Text)
            {
                pd6 = p6 * Convert.ToInt32(txtQ5.Text);
                lblP5.Text = pd6.ToString();
            }
        }

        private void btnQ6_Click(object sender, EventArgs e)
        {
            if (lblP6.Text == pd1.ToString() && lblPD6.Text == lbl1.Text)
            {
                pd1 = p1 * Convert.ToInt32(txtQ6.Text);
                lblP6.Text = pd1.ToString();
            }
            else if (lblP6.Text == pd2.ToString() && lblPD6.Text == lbl2.Text)
            {
                pd2 = p2 * Convert.ToInt32(txtQ6.Text);
                lblP6.Text = pd2.ToString();
            }
            else if (lblP6.Text == pd3.ToString() && lblPD6.Text == lbl3.Text)
            {
                pd3 = p3 * Convert.ToInt32(txtQ6.Text);
                lblP6.Text = pd3.ToString();
            }
            else if (lblP6.Text == pd4.ToString() && lblPD6.Text == lbl4.Text)
            {
                pd4 = p4 * Convert.ToInt32(txtQ6.Text);
                lblP6.Text = pd4.ToString();
            }
            else if (lblP6.Text == pd5.ToString() && lblPD6.Text == lbl5.Text)
            {
                pd5 = p5 * Convert.ToInt32(txtQ6.Text);
                lblP6.Text = pd5.ToString();
            }
            else if (lblP6.Text == pd6.ToString() && lblPD6.Text == lbl6.Text)
            {
                pd6 = p6 * Convert.ToInt32(txtQ6.Text);
                lblP6.Text = pd6.ToString();
            }
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            btnSO.Enabled = true;
            btnSTTP.Enabled = true;
            TotalPrice = Convert.ToInt32(lblP1.Text) + Convert.ToInt32(lblP2.Text) +
                         Convert.ToInt32(lblP3.Text) + Convert.ToInt32(lblP4.Text) +
                         Convert.ToInt32(lblP5.Text) + Convert.ToInt32(lblP6.Text);
            lblTotalPrice.Text = "Total Price" + " : " + TotalPrice.ToString();
        }

        private void Save(string filepath)
        {
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                 writer.WriteLine($"{lblOrder.Text}_{DateTime.Now:dd/MM/yyyy_HH:mm}");
                    if (lblPD1.Text != "")
                    {
                        writer.WriteLine(lblPD1.Text + " : " + lblP1.Text);
                    }
                    if (lblPD2.Text != "")
                    {
                        writer.WriteLine(lblPD2.Text + " : " + lblP2.Text);
                    }
                    if (lblPD3.Text != "")
                    {
                        writer.WriteLine(lblPD3.Text + " : " + lblP3.Text);
                    }
                    if (lblPD4.Text != "")
                    {
                        writer.WriteLine(lblPD4.Text + " : " + lblP4.Text);
                    }
                    if (lblPD5.Text != "")
                    {
                        writer.WriteLine(lblPD5.Text + " : " + lblP5.Text);
                    }
                    if (lblPD6.Text != "")
                    {
                        writer.WriteLine(lblPD6.Text + " : " + lblP6.Text);
                    }
                writer.WriteLine(lblTotalPrice.Text);
            }
            MessageBox.Show("File Saved", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSO_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog.FileName = $"{lblOrder.Text}_{DateTime.Now:ddMMyyyy_HHmm}.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = $"{lblOrder.Text}_{DateTime.Now:ddMMyyyy_HHmm}.txt";

                string filepath = Path.Combine(Path.GetDirectoryName(saveFileDialog.FileName), fileName);
                Save(filepath);
            }
        }

        private void btnSTTP_Click(object sender, EventArgs e)
        {
            // ดึงข้อความจากหน้าต่างหรือที่จัดเก็บข้อมูลไว้
            string contentToSave = TotalPrice.ToString();

            // แสดง SaveFileDialog เพื่ออนุญาตให้ผู้ใช้เลือกตำแหน่งที่จะบันทึกไฟล์
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.FileName = $"{"Total Price"}_{TotalPrice.ToString()}_{DateTime.Now:ddMMyyyy_HHmm}.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // รับชื่อไฟล์ที่เลือกและสร้าง StreamWriter
                    string fileName = saveFileDialog.FileName;
                    // เขียนเนื้อหาลงในไฟล์
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.Write(contentToSave);
                    }
                    MessageBox.Show("File Saved", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private btnAbout aboutForm;

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutForm = new btnAbout(this);
            aboutForm.Show();
            this.Hide();
        }

        // เมื่อต้องการให้หน้าก่อนหน้ากลับมา
        public void ShowOriginalForm()
        {
            this.Show();
            aboutForm.Hide();  // ปิดหน้า About
        }

        private Summary summaryForm;

        private void btnSummary_Click(object sender, EventArgs e)
        {
            summaryForm = new Summary(this);
            summaryForm.Show();
            this.Hide();
        }

        // เมื่อต้องการให้หน้าก่อนหน้ากลับมา
        public void ShoworiginalForm()
        {
            this.Show();
            summaryForm.Hide();  // ปิดหน้า Summary
        }

        private void Page1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // เมื่อฟอร์มปิด, ทำตามที่คุณต้องการ
            // ในที่นี้เราจะให้โปรแกรมหยุดทำงาน
            Application.Exit();
        }
    }
}
