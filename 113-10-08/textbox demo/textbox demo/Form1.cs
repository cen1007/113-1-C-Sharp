namespace textbox_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string fullName;
            string firstName;
            string lastName;


            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            fullName = lastName + " " + firstName;

            lblshow.Text = fullName;
        }
    }
}
