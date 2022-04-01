namespace Timesheet
{
    public partial class Timesheet : Form
    {
        public Timesheet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mondayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timesheet_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();

        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            textBox8.Clear();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            textBox10.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""){
                textBox1.text = DateTime.Now.ToString()
            }
            else if (textbox3.text == "")
            {
                textBox3.Text = DateTime.Now.ToString()
            }

        }
            private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}