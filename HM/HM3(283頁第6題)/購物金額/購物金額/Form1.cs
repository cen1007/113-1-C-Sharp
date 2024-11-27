namespace 購物金額
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //取得輸入的金額
            double purchaseAmount = 0;

            if(double.TryParse(textBoxAmount.Text,out purchaseAmount))
            {
                int points = 0;

                if(purchaseAmount <= 100)
                {
                    points = 1;
                }
                else if (purchaseAmount <= 500)
                {
                    points = 5;
                }
                else if (purchaseAmount <= 1000)
                {
                    points = 10;
                }
                else if (purchaseAmount <= 2000)
                {
                    points = 15;
                }
                else
                {
                    points = 20;    
                }

                labelResult.Text = $"您獲得的點數是:{points}";
            }
            else
            {
                MessageBox.Show("請輸入有效的購物金額!");
            }
        }
    }
}
