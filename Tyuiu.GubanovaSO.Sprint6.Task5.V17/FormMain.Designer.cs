namespace Tyuiu.GubanovaSO.Sprint6.Task5.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_GSO = new GroupBox();
            labelCondition_GSO = new Label();
            groupBoxOutput_GSO = new GroupBox();
            dataGridViewResult_GSO = new DataGridView();
            groupBoxFunction_GSO = new GroupBox();
            chartFunction_GSO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonOpen_GSO = new Button();
            buttonWhat_GSO = new Button();
            buttonDo_GSO = new Button();
            groupBoxCondition_GSO.SuspendLayout();
            groupBoxOutput_GSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GSO).BeginInit();
            groupBoxFunction_GSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GSO).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_GSO
            // 
            groupBoxCondition_GSO.Controls.Add(labelCondition_GSO);
            groupBoxCondition_GSO.Location = new Point(12, 12);
            groupBoxCondition_GSO.Name = "groupBoxCondition_GSO";
            groupBoxCondition_GSO.Size = new Size(391, 84);
            groupBoxCondition_GSO.TabIndex = 21;
            groupBoxCondition_GSO.TabStop = false;
            groupBoxCondition_GSO.Text = "Условие";
            // 
            // labelCondition_GSO
            // 
            labelCondition_GSO.AutoSize = true;
            labelCondition_GSO.Location = new Point(6, 18);
            labelCondition_GSO.Name = "labelCondition_GSO";
            labelCondition_GSO.Size = new Size(281, 60);
            labelCondition_GSO.TabIndex = 0;
            labelCondition_GSO.Text = "Прочитать данные из файла. Вынести \r\nположительные значения и построить\r\nдиаграмму\r\n";
            // 
            // groupBoxOutput_GSO
            // 
            groupBoxOutput_GSO.Controls.Add(dataGridViewResult_GSO);
            groupBoxOutput_GSO.Location = new Point(12, 96);
            groupBoxOutput_GSO.Name = "groupBoxOutput_GSO";
            groupBoxOutput_GSO.Size = new Size(168, 505);
            groupBoxOutput_GSO.TabIndex = 20;
            groupBoxOutput_GSO.TabStop = false;
            groupBoxOutput_GSO.Text = "Вывод";
            // 
            // dataGridViewResult_GSO
            // 
            dataGridViewResult_GSO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_GSO.ColumnHeadersVisible = false;
            dataGridViewResult_GSO.Location = new Point(6, 24);
            dataGridViewResult_GSO.Name = "dataGridViewResult_GSO";
            dataGridViewResult_GSO.RowHeadersVisible = false;
            dataGridViewResult_GSO.RowHeadersWidth = 51;
            dataGridViewResult_GSO.Size = new Size(156, 476);
            dataGridViewResult_GSO.TabIndex = 0;
            // 
            // groupBoxFunction_GSO
            // 
            groupBoxFunction_GSO.Controls.Add(chartFunction_GSO);
            groupBoxFunction_GSO.Location = new Point(216, 102);
            groupBoxFunction_GSO.Name = "groupBoxFunction_GSO";
            groupBoxFunction_GSO.Size = new Size(548, 333);
            groupBoxFunction_GSO.TabIndex = 19;
            groupBoxFunction_GSO.TabStop = false;
            groupBoxFunction_GSO.Text = "График";
            // 
            // chartFunction_GSO
            // 
            chartFunction_GSO.BackColor = SystemColors.Menu;
            chartArea1.Name = "ChartArea1";
            chartFunction_GSO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_GSO.Legends.Add(legend1);
            chartFunction_GSO.Location = new Point(6, 24);
            chartFunction_GSO.Name = "chartFunction_GSO";
            chartFunction_GSO.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            chartFunction_GSO.Series.Add(series1);
            chartFunction_GSO.Size = new Size(523, 292);
            chartFunction_GSO.TabIndex = 0;
            chartFunction_GSO.Text = "chart1";
            // 
            // buttonOpen_GSO
            // 
            buttonOpen_GSO.BackColor = Color.Silver;
            buttonOpen_GSO.Location = new Point(523, 29);
            buttonOpen_GSO.Name = "buttonOpen_GSO";
            buttonOpen_GSO.Size = new Size(128, 61);
            buttonOpen_GSO.TabIndex = 18;
            buttonOpen_GSO.Text = "Открыть файл";
            buttonOpen_GSO.UseVisualStyleBackColor = false;
            buttonOpen_GSO.Click += buttonOpen_GSO_Click;
            // 
            // buttonWhat_GSO
            // 
            buttonWhat_GSO.BackColor = Color.Silver;
            buttonWhat_GSO.Location = new Point(657, 29);
            buttonWhat_GSO.Name = "buttonWhat_GSO";
            buttonWhat_GSO.Size = new Size(64, 61);
            buttonWhat_GSO.TabIndex = 16;
            buttonWhat_GSO.Text = "?";
            buttonWhat_GSO.UseVisualStyleBackColor = false;
            buttonWhat_GSO.Click += buttonWhat_GSO_Click;
            // 
            // buttonDo_GSO
            // 
            buttonDo_GSO.BackColor = Color.Silver;
            buttonDo_GSO.Location = new Point(417, 29);
            buttonDo_GSO.Name = "buttonDo_GSO";
            buttonDo_GSO.Size = new Size(100, 61);
            buttonDo_GSO.TabIndex = 15;
            buttonDo_GSO.Text = "Выполнить";
            buttonDo_GSO.UseVisualStyleBackColor = false;
            buttonDo_GSO.Click += buttonDo_GSO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 608);
            Controls.Add(groupBoxCondition_GSO);
            Controls.Add(groupBoxOutput_GSO);
            Controls.Add(groupBoxFunction_GSO);
            Controls.Add(buttonOpen_GSO);
            Controls.Add(buttonWhat_GSO);
            Controls.Add(buttonDo_GSO);
            Name = "FormMain";
            Text = " ";
            groupBoxCondition_GSO.ResumeLayout(false);
            groupBoxCondition_GSO.PerformLayout();
            groupBoxOutput_GSO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_GSO).EndInit();
            groupBoxFunction_GSO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_GSO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_GSO;
        private Label labelCondition_GSO;
        private GroupBox groupBoxOutput_GSO;
        private GroupBox groupBoxFunction_GSO;
        private Button buttonOpen_GSO;
        private Button buttonWhat_GSO;
        private Button buttonDo_GSO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GSO;
        private DataGridView dataGridViewResult_GSO;
    }
}
