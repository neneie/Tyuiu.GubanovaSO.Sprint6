using Tyuiu.GubanovaSO.Sprint6.Task5.V17.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task5.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\Sonya\source\repos\Tyuiu.GubanovaSO.Sprint6\Tyuiu.GubanovaSO.Sprint6.Task5.V17\bin\Debug\InPutDataFileTask5V17.txt";

        private void buttonDo_GSO_Click(object sender, EventArgs e)
        {
            dataGridViewResult_GSO.ColumnCount = 2;
            dataGridViewResult_GSO.Columns[0].Width = 30;
            dataGridViewResult_GSO.Columns[1].Width = 50;
            this.chartFunction_GSO.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_GSO.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_GSO.Series[0].Points.Clear();
            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewResult_GSO.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartFunction_GSO.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpen_GSO_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonWhat_GSO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила Губанова Софья", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
