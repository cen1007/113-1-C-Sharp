namespace 類型座位
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int PRICE_A = 15;
            const int PRICE_B = 12; 
            const int PRICE_C = 9;

            try
            {
                int ticketsA = int.Parse(txtClassA.Text);
                int ticketsB = int.Parse(txtClassB.Text);
                int ticketsC = int.Parse(txtClassC.Text);

                int revenueA = ticketsA * PRICE_A;
                int revenueB = ticketsB * PRICE_B;
                int revenueC = ticketsC * PRICE_C;
                int totalRevenue = revenueA + revenueB + revenueC;

                txtRevenueA.Text = "Revenue from Class A: $" + revenueA;
                txtRevenueB.Text = "Revenue from Class B: $" + revenueB;
                txtRevenueC.Text = "Revenue from Class C: $" + revenueC;
                txtTotalRevenue.Text = "Total Revenue: $" + totalRevenue;
            }
            catch 
            {
                MessageBox.Show("請輸入有效的數字");
            }
        }
    }
}
