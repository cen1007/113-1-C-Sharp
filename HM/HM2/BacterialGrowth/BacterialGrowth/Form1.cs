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
            //���o��J��
            int initialBacteria = int.Parse(txtInitialBacteria.Text);
            int doublingTime = int.Parse(txtDoublingTime.Text);
            double growthRate = 2; //�ӵ߭���

            //�M�� ListBox
            lstBacterialGrowth.Items.Clear();

            //�p��ӵߦ���
            for (int day = 1; day <= 10; day++)
            {
                double bacteriaCount = initialBacteria * Math.Pow(growthRate, (double)day / doublingTime);
                lstBacterialGrowth.Items.Add($"��{day}��:{Math.Round(bacteriaCount)}�Ӳӵ�");
            }
        }
    }
}
