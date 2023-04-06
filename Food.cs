using Microsoft.VisualBasic;
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
    public partial class Food : Form
    {
        List<Menu> menu;
        Menu selectmenu;
        public Food()
        { 
            InitializeComponent();
            menu= new List<Menu>();
            menu.Add(new crispy_pork());
            menu.Add(new Korean_Fried_Chicken());
            menu.Add(new Fried_Chicken_Salad());
            menu.Add(new Crispy_Pork_with_Rice());
            menu.Add(new Tonkatsu());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectmenu = menu[0];
            this.pictureBox1.Image = selectmenu.getImage();
            this.textBox1.Text = selectmenu.getName();
            this.textBox2.Text = selectmenu.getType();
            this.textBox3.Text = selectmenu.getOrder().ToString();
            this.textBox4.Text = selectmenu.getPayment();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectmenu = menu[1];
            this.pictureBox1.Image = selectmenu.getImage();
            this.textBox1.Text = selectmenu.getName();
            this.textBox2.Text = selectmenu.getType();
            this.textBox3.Text = selectmenu.getOrder().ToString();
            this.textBox4.Text = selectmenu.getPayment();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectmenu = menu[2];
            this.pictureBox1.Image = selectmenu.getImage();
            this.textBox1.Text = selectmenu.getName();
            this.textBox2.Text = selectmenu.getType();
            this.textBox3.Text = selectmenu.getOrder().ToString();
            this.textBox4.Text = selectmenu.getPayment();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectmenu = menu[3];
            this.pictureBox1.Image = selectmenu.getImage();
            this.textBox1.Text = selectmenu.getName();
            this.textBox2.Text = selectmenu.getType();
            this.textBox3.Text = selectmenu.getOrder().ToString();
            this.textBox4.Text = selectmenu.getPayment();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectmenu = menu[4];
            this.pictureBox1.Image = selectmenu.getImage();
            this.textBox1.Text = selectmenu.getName();
            this.textBox2.Text = selectmenu.getType();
            this.textBox3.Text = selectmenu.getOrder().ToString();
            this.textBox4.Text = selectmenu.getPayment();
        }
    }
}
