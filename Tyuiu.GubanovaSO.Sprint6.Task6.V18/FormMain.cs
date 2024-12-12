using Tyuiu.GubanovaSO.Sprint6.Task6.V18.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;

        private void buttonDo_GSO_Click(object sender, EventArgs e)
        {
            textBoxOutput_GSO.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpenFile_GSO_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GSO.ShowDialog();
            openFilePath = openFileDialogTask_GSO.FileName;
            textBoxInput_GSO.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_GSO.Text = groupBoxOutput_GSO.Text + " " + openFileDialogTask_GSO.FileName;
            buttonDo_GSO.Enabled = true;
        }

        private void buttonWhat_GSO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
