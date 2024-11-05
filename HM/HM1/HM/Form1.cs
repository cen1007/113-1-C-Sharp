namespace HM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "梅花5";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "菱形10";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "愛心K";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "菱形6";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "黑桃8";
        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
