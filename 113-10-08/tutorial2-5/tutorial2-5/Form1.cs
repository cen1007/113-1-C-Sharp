namespace tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�P�I��
        private void btnShowBack_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true; //�]�wvisible�ݩʬ���
            ptxfront.Visible = false;
        }
        //��ܼ��J�P����
        private void btnShowFront_Click(object sender, EventArgs e)
        {
            ptxback.Visible = false;
            ptxfront.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
