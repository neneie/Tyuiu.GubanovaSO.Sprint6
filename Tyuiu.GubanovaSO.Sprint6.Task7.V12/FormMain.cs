using Tyuiu.GubanovaSO.Sprint6.Task7.V12.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task7.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_GSO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_GSO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new();
        static int rows;
        static int cols;
        static string path;
        public static int[,] mtr(string path)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;


            int[,] arr = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                string[] linr = lines[r].Split(';');
                for (int c = 0; c < cols; c++)
                {
                    arr[r, c] = Convert.ToInt32(linr[c]);
                }
            }
            return arr;
        }
        private void buttonWhat_GSO_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void buttonOpenFile_GSO_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog_GSO.ShowDialog();
                path = saveFileDialog_GSO.FileName;
                saveFileDialog_GSO.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog_GSO.Title = "Выберите файл";
                int[,] arr = new int[rows, cols];
                arr = mtr(path);
                DataGridViewInPut_GSO.ColumnCount = cols;
                DataGridViewOutPut_GSO.ColumnCount = cols;
                DataGridViewInPut_GSO.RowCount = rows;
                DataGridViewOutPut_GSO.RowCount = rows;
                for (int i = 0; i < cols; i++)
                {
                    DataGridViewInPut_GSO.Columns[i].Width = 50;
                    DataGridViewOutPut_GSO.Columns[i].Width = 50;
                }
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        DataGridViewInPut_GSO.Rows[r].Cells[c].Value = arr[r, c];
                    }
                }
            }
        }

        private void buttonDo_GSO_Click(object sender, EventArgs e)
        {
            {
                int[,] arr = new int[rows, cols];
                arr = ds.GetMatrix(path);
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        DataGridViewOutPut_GSO.Rows[r].Cells[c].Value = arr[r, c];
                    }
                }
            }
        }

        private void buttonSave_GSO_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog_GSO.FileName = "OutPutTask7.csv";
                saveFileDialog_GSO.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialog_GSO.ShowDialog();

                string path1 = saveFileDialog_GSO.FileName;
                FileInfo fi = new FileInfo(path1);
                bool fe = fi.Exists;
                if (fe)
                {
                    File.Delete(path1);
                }
                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (j != cols - 1)
                        {
                            str = str + DataGridViewOutPut_GSO.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str = str + DataGridViewOutPut_GSO.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path1, str + Environment.NewLine);
                    str = "";

                }
            }
        }
    }
}
