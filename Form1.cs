namespace Assignment1
{
    public partial class Colors : Form
    {
        public Colors()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is orange!");

            label2.Text = "ORANGE";
            label2.Visible = true;
            label1.Visible = false;
            label3.Visible = false;

            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;    
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is blue!");

            label1.Text = "BLUE";
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = false;

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is black!");

            label3.Text = "BLACK";
            label3.Visible = true;
            label1.Visible = false;
            label2.Visible = false; 

            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
        }
    }
}
