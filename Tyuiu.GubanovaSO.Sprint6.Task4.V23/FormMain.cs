using Tyuiu.GubanovaSO.Sprint6.Task4.V23.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task4.V23
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
                int start = Convert.ToInt32(textBoxStart_GSO.Text);
                int stop = Convert.ToInt32(textBoxStop_GSO.Text);

                string strLine;

                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(start, stop);

                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

                textBox1.Text = "";
                textBox1.AppendText("+---------+---------+" + Environment.NewLine);
                textBox1.AppendText("|    X    |  f(x)   |" + Environment.NewLine);
                textBox1.AppendText("+---------+---------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    this.chart1.Series[0].Points.AddXY(start, valueArray[i]);

                    if (valueArray[i] <= -10)
                    {
                        strLine = String.Format("|{0,5:d}    | {1,5:f2}  |", start, valueArray[i]);
                        textBox1.AppendText(strLine + Environment.NewLine);
                        start++;
                    }
                    else
                    {
                        strLine = String.Format("|{0,5:d}    | {1,5:f2}   |", start, valueArray[i]);
                        textBox1.AppendText(strLine + Environment.NewLine);
                        start++;
                    }
                }

                textBox1.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonWhat_GSO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Губанова Софья", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void textBoxStart_GSO_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && ((e.KeyChar != ',') || (e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }

        private void buttonSave_GSO_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.GetTempPath();
                string filePath = Path.Combine(tempPath, "OutPutFileTask4V23.txt");
                File.WriteAllText(filePath, textBox1.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + filePath + " Сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = filePath;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
