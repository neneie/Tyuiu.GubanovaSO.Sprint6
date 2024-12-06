using Tyuiu.GubanovaSO.Sprint6.Task0.V20.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task0.V20
{
    public partial class Form1main : Form
    {
        public Form1main()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonDo_GSO_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutput_GSO.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_GSO.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonWhat_GSO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила Губанова Софья", "Сообщение", MessageBoxButtons.OK);
        }

    }
}
