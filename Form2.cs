using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            //ส่วนรายการอาหาร
            //สร้างตัวเเปรสำหรับเก็บผลรวม
            int total = 0;
            //ก่อนการคำนวณให้ตรวจสอบช่องที่กรอกจะต้องไม่เป็นค่าว่างก่อน
            if (txtFood1.Text != "")
            {
                total += Convert.ToInt32(txtFood1.Text) * 30;
            }
            if (txtFood2.Text != "")
            {
                total += Convert.ToInt32(txtFood2.Text) * 50;
            }
            if (txtFood3.Text != "")
            {
                total += Convert.ToInt32(txtFood3.Text) * 50;
            }
            if (txtFood4.Text != "")
            {
                total += Convert.ToInt32(txtFood4.Text) * 50;
            }
            if (txtFood5.Text != "")
            {
                total += Convert.ToInt32(txtFood5.Text) * 30;
            }
            if (txtFood6.Text != "")
            {
                total += Convert.ToInt32(txtFood6.Text) * 50;
            }
            if (txtFood7.Text != "")
            {
                total += Convert.ToInt32(txtFood7.Text) * 40;
            }
            if (txtFood8.Text != "")
            {
                total += Convert.ToInt32(txtFood8.Text) * 40;
            }
            lblPay.Text = total.ToString();
        }
    }
}
