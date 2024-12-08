using Tyuiu.GubanovaSO.Sprint6.Task2.V7.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task2.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDo_GSO_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_GSO.Text);
                int stopStep = Convert.ToInt32(textBoxStop_GSO.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_GSO.Titles.Add("График функции (sin(x)/x+1,2) - sin(x) * 2 - 2x");

                this.chartFunction_GSO.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_GSO.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_GSO.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_GSO.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonWhat_GSO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 Выполнила Губанова Софья", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
