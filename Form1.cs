namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (listBox1.Text) + 0 ;


            textBox8.Text = (textBox2.Text) + (textBox3.Text) + (textBox4.Text) + (textBox5.Text) + (textBox6.Text);
            textBox7.Text = (textBox8.Text) + 50;
            textBox9.Text = (textBox8.Text) + (textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";

            textBox9.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}