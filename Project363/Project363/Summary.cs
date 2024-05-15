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
using System.Windows.Forms.DataVisualization.Charting;

namespace Project363
{
    public partial class Summary : Form
    {
        private Page1 originalForm;
        private Chart pieChart;

        public Summary(Page1 originalForm)
        {
            InitializeComponent();
            this.originalForm = originalForm;
            this.FormClosed += Summary_FormClosed;
            this.StartPosition = FormStartPosition.CenterScreen;

            // สร้าง Chart
            pieChart = new Chart();
            pieChart.Size = new Size(427, 427);
            // กำหนดพื้นที่แสดงข้อมูล
            ChartArea chartArea = new ChartArea();
            pieChart.ChartAreas.Add(chartArea);
            // เพิ่ม Chart ลงใน Controls ของ PictureBox
            chartPictureBox.Controls.Add(pieChart);
        }

        private void Summary_Load(object sender, EventArgs e)
        {
            lblOrder1.Text = "0";
            lblOrder2.Text = "0";
            lblOrder3.Text = "0";
            lblOrder4.Text = "0";
            lblOrder5.Text = "0";
            lblOrder6.Text = "0";
            lblOrder7.Text = "0";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            originalForm?.ShoworiginalForm();
        }

        private void Summary_FormClosed(object sender, FormClosedEventArgs e)
        {
            // เมื่อฟอร์มปิด, ทำตามที่คุณต้องการ
            // ในที่นี้เราจะให้โปรแกรมหยุดทำงาน
            Application.Exit();
        }

        private void btnOrder1_Click(object sender, EventArgs e)
        {
            // สร้าง OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // แสดงกล่องโต้ตอบเพื่อให้ผู้ใช้เลือกไฟล์
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // อ่านข้อมูลจากไฟล์
                string filePath = openFileDialog.FileName;
                // ใช้ StreamReader ในการอ่านข้อมูลบรรทัดเดียว
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // อ่านบรรทัดเดียว
                    string line = reader.ReadLine();

                    // ตรวจสอบว่าข้อมูลในบรรทัดเป็นตัวเลขหรือไม่
                    if (int.TryParse(line, out int number))
                    {
                        // แสดงข้อมูลเป็นตัวเลขใน Label
                        lblOrder1.Text = number.ToString();
                    }
                    else
                    {
                        // แสดงข้อความผิดพลาดถ้าข้อมูลในบรรทัดไม่ใช่ตัวเลข
                        lblOrder1.Text = "Error: The file does not contain a valid number.";
                    }
                }
            }
        }

        private void btnOrder2_Click(object sender, EventArgs e)
        {
            // สร้าง OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // แสดงกล่องโต้ตอบเพื่อให้ผู้ใช้เลือกไฟล์
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // อ่านข้อมูลจากไฟล์
                string filePath = openFileDialog.FileName;
                // ใช้ StreamReader ในการอ่านข้อมูลบรรทัดเดียว
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // อ่านบรรทัดเดียว
                    string line = reader.ReadLine();

                    // ตรวจสอบว่าข้อมูลในบรรทัดเป็นตัวเลขหรือไม่
                    if (int.TryParse(line, out int number))
                    {
                        // แสดงข้อมูลเป็นตัวเลขใน Label
                        lblOrder2.Text = number.ToString();
                    }
                    else
                    {
                        // แสดงข้อความผิดพลาดถ้าข้อมูลในบรรทัดไม่ใช่ตัวเลข
                        lblOrder2.Text = "Error: The file does not contain a valid number.";
                    }
                }
            }
        }

        private void btnOrder3_Click(object sender, EventArgs e)
        {
            // สร้าง OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // แสดงกล่องโต้ตอบเพื่อให้ผู้ใช้เลือกไฟล์
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // อ่านข้อมูลจากไฟล์
                string filePath = openFileDialog.FileName;
                // ใช้ StreamReader ในการอ่านข้อมูลบรรทัดเดียว
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // อ่านบรรทัดเดียว
                    string line = reader.ReadLine();

                    // ตรวจสอบว่าข้อมูลในบรรทัดเป็นตัวเลขหรือไม่
                    if (int.TryParse(line, out int number))
                    {
                        // แสดงข้อมูลเป็นตัวเลขใน Label
                        lblOrder3.Text = number.ToString();
                    }
                    else
                    {
                        // แสดงข้อความผิดพลาดถ้าข้อมูลในบรรทัดไม่ใช่ตัวเลข
                        lblOrder3.Text = "Error: The file does not contain a valid number.";
                    }
                }
            }
        }

        private void btnOrder4_Click(object sender, EventArgs e)
        {
            // สร้าง OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // แสดงกล่องโต้ตอบเพื่อให้ผู้ใช้เลือกไฟล์
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // อ่านข้อมูลจากไฟล์
                string filePath = openFileDialog.FileName;
                // ใช้ StreamReader ในการอ่านข้อมูลบรรทัดเดียว
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // อ่านบรรทัดเดียว
                    string line = reader.ReadLine();

                    // ตรวจสอบว่าข้อมูลในบรรทัดเป็นตัวเลขหรือไม่
                    if (int.TryParse(line, out int number))
                    {
                        // แสดงข้อมูลเป็นตัวเลขใน Label
                        lblOrder4.Text = number.ToString();
                    }
                    else
                    {
                        // แสดงข้อความผิดพลาดถ้าข้อมูลในบรรทัดไม่ใช่ตัวเลข
                        lblOrder4.Text = "Error: The file does not contain a valid number.";
                    }
                }
            }
        }

        private void btnOrder5_Click(object sender, EventArgs e)
        {
            // สร้าง OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // แสดงกล่องโต้ตอบเพื่อให้ผู้ใช้เลือกไฟล์
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // อ่านข้อมูลจากไฟล์
                string filePath = openFileDialog.FileName;
                // ใช้ StreamReader ในการอ่านข้อมูลบรรทัดเดียว
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // อ่านบรรทัดเดียว
                    string line = reader.ReadLine();

                    // ตรวจสอบว่าข้อมูลในบรรทัดเป็นตัวเลขหรือไม่
                    if (int.TryParse(line, out int number))
                    {
                        // แสดงข้อมูลเป็นตัวเลขใน Label
                        lblOrder5.Text = number.ToString();
                    }
                    else
                    {
                        // แสดงข้อความผิดพลาดถ้าข้อมูลในบรรทัดไม่ใช่ตัวเลข
                        lblOrder5.Text = "Error: The file does not contain a valid number.";
                    }
                }
            }
        }

        private void btnOrder6_Click(object sender, EventArgs e)
        {
            // สร้าง OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // แสดงกล่องโต้ตอบเพื่อให้ผู้ใช้เลือกไฟล์
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // อ่านข้อมูลจากไฟล์
                string filePath = openFileDialog.FileName;
                // ใช้ StreamReader ในการอ่านข้อมูลบรรทัดเดียว
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // อ่านบรรทัดเดียว
                    string line = reader.ReadLine();

                    // ตรวจสอบว่าข้อมูลในบรรทัดเป็นตัวเลขหรือไม่
                    if (int.TryParse(line, out int number))
                    {
                        // แสดงข้อมูลเป็นตัวเลขใน Label
                        lblOrder6.Text = number.ToString();
                    }
                    else
                    {
                        // แสดงข้อความผิดพลาดถ้าข้อมูลในบรรทัดไม่ใช่ตัวเลข
                        lblOrder6.Text = "Error: The file does not contain a valid number.";
                    }
                }
            }
        }

        private void btnOrder7_Click(object sender, EventArgs e)
        {
            // สร้าง OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // แสดงกล่องโต้ตอบเพื่อให้ผู้ใช้เลือกไฟล์
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // อ่านข้อมูลจากไฟล์
                string filePath = openFileDialog.FileName;
                // ใช้ StreamReader ในการอ่านข้อมูลบรรทัดเดียว
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // อ่านบรรทัดเดียว
                    string line = reader.ReadLine();

                    // ตรวจสอบว่าข้อมูลในบรรทัดเป็นตัวเลขหรือไม่
                    if (int.TryParse(line, out int number))
                    {
                        // แสดงข้อมูลเป็นตัวเลขใน Label
                        lblOrder7.Text = number.ToString();
                    }
                    else
                    {
                        // แสดงข้อความผิดพลาดถ้าข้อมูลในบรรทัดไม่ใช่ตัวเลข
                        lblOrder7.Text = "Error: The file does not contain a valid number.";
                    }
                }
            }
        }

        // สร้างกราฟวงกลมจากข้อมูลที่ได้อ่านจากไฟล์
        private void CreatePieChart()
        {
            // ล้าง Series ทุกครั้งที่เรียกใช้เมท็อด
            pieChart.Series.Clear();

            // สร้าง Series สำหรับข้อมูล
            Series series = new Series();
            pieChart.Series.Add(series);

            // ตั้งค่าชื่อ Series (ในกรณีนี้ให้ใส่ชื่อว่า "Days")
            series.Name = "Oders";

            // เพิ่มข้อมูลลงใน Series
            series.Points.AddXY("Order 1" + " : " + lblOrder1.Text, int.Parse(lblOrder1.Text));
            series.Points.AddXY("Order 2" + " : " + lblOrder2.Text, int.Parse(lblOrder2.Text));
            series.Points.AddXY("Order 3" + " : " + lblOrder3.Text, int.Parse(lblOrder3.Text));
            series.Points.AddXY("Order 4" + " : " + lblOrder4.Text, int.Parse(lblOrder4.Text));
            series.Points.AddXY("Order 5" + " : " + lblOrder5.Text, int.Parse(lblOrder5.Text));
            series.Points.AddXY("Order 6" + " : " + lblOrder6.Text, int.Parse(lblOrder6.Text));
            series.Points.AddXY("Order 7" + " : " + lblOrder7.Text, int.Parse(lblOrder7.Text));

            // กำหนดรูปแบบให้เป็นแผนภูมิวงกลม
            series.ChartType = SeriesChartType.Pie;

            // ตั้งค่าสีของแต่ละ Slice
            series.Points[0].Color = Color.Navy;
            series.Points[1].Color = Color.MidnightBlue;
            series.Points[2].Color = Color.RoyalBlue;
            series.Points[3].Color = Color.CornflowerBlue;
            series.Points[4].Color = Color.DodgerBlue;
            series.Points[5].Color = Color.LightSkyBlue;
            series.Points[6].Color = Color.PowderBlue;

            // ตั้งค่าฟอนต์ของ Label ของแต่ละ Slice ในแผนภูมิวงกลม
            foreach (DataPoint point in series.Points)
            {
                point.CustomProperties = "PieLabelStyle=Outside"; // ตั้งค่า LabelStyle เป็น Outside
                point.Label = string.Format("{0} ({1:P})", point.AxisLabel, point.YValues[0] / series.Points.Sum(p => p.YValues[0])); // แสดงเปอร์เซ็นต์
                point.Font = new Font("AomsinThin", 7, FontStyle.Bold); // เปลี่ยนฟอนต์ของ Label ของแต่ละ Slice
            }

            // อัปเดต Chart เพื่อแสดงแผนภูมิวงกลม
            pieChart.Update();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            // เรียกใช้เมท็อดสร้างกราฟวงกลม
            CreatePieChart();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
