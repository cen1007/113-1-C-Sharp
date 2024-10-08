namespace tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //顯示撲克牌背面
        private void btnShowBack_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true; //設定visible屬性為假
            ptxfront.Visible = false;
        }
        //顯示撲克牌正面
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
