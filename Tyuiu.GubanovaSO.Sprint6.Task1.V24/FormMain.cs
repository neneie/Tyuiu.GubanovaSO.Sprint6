using Tyuiu.GubanovaSO.Sprint6.Task1.V24.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task1.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void textBoxStart_GSO_Enter(object sender, EventArgs e)
        {
            if (textBoxStart_GSO.Text == "Введите значение")
            {
                textBoxStart_GSO.Clear();
                textBoxStart_GSO.ForeColor = Color.Black;
            }
        }

        private void textBoxStart_GSO_Leave(object sender, EventArgs e)
        {
            if (textBoxStart_GSO.Text == "")
            {
                textBoxStart_GSO.Text = "Введите значение";
                textBoxStart_GSO.ForeColor = Color.Gray;
            }
        }
        private void textBoxStop_GSO_Enter(object sender, EventArgs e)
        {
            if (textBoxStop_GSO.Text == "Введите значение")
            {
                textBoxStop_GSO.Clear();
                textBoxStop_GSO.ForeColor = Color.Black;
            }
        }

        private void textBoxStop_GSO_Leave(object sender, EventArgs e)
        {
            if (textBoxStop_GSO.Text == "")
            {
                textBoxStop_GSO.Text = "Введите значение";
                textBoxStop_GSO.ForeColor = Color.Gray;
            }
        }
        private void buttonDo_GSO_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startValue = Convert.ToInt32(textBoxStart_GSO.Text);
                int stopValue = Convert.ToInt32(textBoxStop_GSO.Text);
                double[] masValue = ds.GetMassFunction(startValue, stopValue);

                textBoxOutput_GSO.Font = new Font(FontFamily.GenericMonospace, 9);
                textBoxOutput_GSO.Text = "";
                textBoxOutput_GSO.AppendText("+-----------------+-----------------+" + Environment.NewLine);
                textBoxOutput_GSO.AppendText("|        x        |       f(x)      |" + Environment.NewLine);
                textBoxOutput_GSO.AppendText("+-----------------+-----------------+" + Environment.NewLine);
                //         String.Format("|    {0,5:d}      |    {1,5:f2}       |", startValue, masValue[i]);
                for (int i = 0; i < masValue.Length; i++)
                {
                    string line = String.Format("|    {0,5:d}        |      {1,5:f2}\t    |", startValue++, masValue[i]);
                    textBoxOutput_GSO.AppendText(line + Environment.NewLine);
                }

                textBoxOutput_GSO.AppendText("+-----------------+-----------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Данные введены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Губанова Софья", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
