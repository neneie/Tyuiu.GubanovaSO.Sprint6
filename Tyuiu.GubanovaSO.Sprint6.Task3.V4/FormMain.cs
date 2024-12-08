using Tyuiu.GubanovaSO.Sprint6.Task3.V4.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task3.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -14, -7, 18, 12, -20 },
                                         { -2, -4, 20, -19, 8 },
                                         { -18, -5, -10, 14, -17 },
                                         { -1, 2, -10, 0, 11 },
                                         { 6, -18, 0, 19, 16 } };
        private void buttonDo_GSO_Click(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    dataGridViewMtrx_GSO.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }
        }

        private void buttonWhat_GSO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 3 ��������� �������� �����", "���������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;   // ���������� ����� 
            int columns = mtrx.Length / rows;       // ���������� �������

            dataGridViewMtrx_GSO.ColumnCount = columns;
            dataGridViewMtrx_GSO.RowCount = rows;


            //������ ������ ��������
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMtrx_GSO.Columns[i].Width = 60;
            }
            // ��������� ������� ������� �� �������
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMtrx_GSO.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}