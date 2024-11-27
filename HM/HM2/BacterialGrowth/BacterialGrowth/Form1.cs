namespace BacterialGrowth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //取得輸入值
            int initialBacteria = int.Parse(txtInitialBacteria.Text);
            int doublingTime = int.Parse(txtDoublingTime.Text);
            double growthRate = 2; //細菌倍數

            //清空 ListBox
            lstBacterialGrowth.Items.Clear();

            //計算細菌成長
            for (int day = 1; day <= 10; day++)
            {
                double bacteriaCount = initialBacteria * Math.Pow(growthRate, (double)day / doublingTime);
                lstBacterialGrowth.Items.Add($"第{day}天:{Math.Round(bacteriaCount)}個細菌");
            }
        }
    }
}
