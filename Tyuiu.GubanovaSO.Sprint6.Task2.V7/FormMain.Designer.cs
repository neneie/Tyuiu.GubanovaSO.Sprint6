namespace Tyuiu.GubanovaSO.Sprint6.Task2.V7
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
            pictureBox1 = new PictureBox();
            labelCondition_GSO = new Label();
            groupBoxInput_GSO = new GroupBox();
            textBoxStop_GSO = new TextBox();
            textBoxStart_GSO = new TextBox();
            labelStop_GSO = new Label();
            labelStart_GSO = new Label();
            buttonWhat_GSO = new Button();
            buttonDo_GSO = new Button();
            groupBoxOutput_GSO = new GroupBox();
            dataGridViewFunction_GSO = new DataGridView();
            ColumnInput = new DataGridViewTextBoxColumn();
            ColumnOutput = new DataGridViewTextBoxColumn();
            label1 = new Label();
            chartFunction_GSO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxFunction_GSO = new GroupBox();
            groupBoxCondition_GSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInput_GSO.SuspendLayout();
            groupBoxOutput_GSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_GSO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GSO).BeginInit();
            groupBoxFunction_GSO.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_GSO
            // 
            groupBoxCondition_GSO.Controls.Add(pictureBox1);
            groupBoxCondition_GSO.Controls.Add(labelCondition_GSO);
            groupBoxCondition_GSO.Location = new Point(12, 12);
            groupBoxCondition_GSO.Name = "groupBoxCondition_GSO";
            groupBoxCondition_GSO.Size = new Size(391, 228);
            groupBoxCondition_GSO.TabIndex = 1;
            groupBoxCondition_GSO.TabStop = false;
            groupBoxCondition_GSO.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2024_12_08_16_42_42;
            pictureBox1.Location = new Point(1, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelCondition_GSO
            // 
            labelCondition_GSO.AutoSize = true;
            labelCondition_GSO.Location = new Point(6, 43);
            labelCondition_GSO.Name = "labelCondition_GSO";
            labelCondition_GSO.Size = new Size(380, 60);
            labelCondition_GSO.TabIndex = 0;
            labelCondition_GSO.Text = "Протабулировать функцию на заданном диапазоне. \r\nРезультат вывести в таблицу\r\n\r\n";
            // 
            // groupBoxInput_GSO
            // 
            groupBoxInput_GSO.Controls.Add(textBoxStop_GSO);
            groupBoxInput_GSO.Controls.Add(textBoxStart_GSO);
            groupBoxInput_GSO.Controls.Add(labelStop_GSO);
            groupBoxInput_GSO.Controls.Add(labelStart_GSO);
            groupBoxInput_GSO.Location = new Point(12, 285);
            groupBoxInput_GSO.Name = "groupBoxInput_GSO";
            groupBoxInput_GSO.Size = new Size(291, 111);
            groupBoxInput_GSO.TabIndex = 2;
            groupBoxInput_GSO.TabStop = false;
            groupBoxInput_GSO.Text = "Ввод данных";
            // 
            // textBoxStop_GSO
            // 
            textBoxStop_GSO.Location = new Point(167, 66);
            textBoxStop_GSO.Name = "textBoxStop_GSO";
            textBoxStop_GSO.Size = new Size(94, 27);
            textBoxStop_GSO.TabIndex = 3;
            // 
            // textBoxStart_GSO
            // 
            textBoxStart_GSO.Location = new Point(6, 66);
            textBoxStart_GSO.Name = "textBoxStart_GSO";
            textBoxStart_GSO.Size = new Size(94, 27);
            textBoxStart_GSO.TabIndex = 2;
            // 
            // labelStop_GSO
            // 
            labelStop_GSO.AutoSize = true;
            labelStop_GSO.Location = new Point(167, 32);
            labelStop_GSO.Name = "labelStop_GSO";
            labelStop_GSO.Size = new Size(91, 20);
            labelStop_GSO.TabIndex = 1;
            labelStop_GSO.Text = "Конец шага";
            // 
            // labelStart_GSO
            // 
            labelStart_GSO.AutoSize = true;
            labelStart_GSO.Location = new Point(6, 32);
            labelStart_GSO.Name = "labelStart_GSO";
            labelStart_GSO.Size = new Size(85, 20);
            labelStart_GSO.TabIndex = 0;
            labelStart_GSO.Text = "Старт шага";
            // 
            // buttonWhat_GSO
            // 
            buttonWhat_GSO.BackColor = SystemColors.MenuHighlight;
            buttonWhat_GSO.Location = new Point(183, 402);
            buttonWhat_GSO.Name = "buttonWhat_GSO";
            buttonWhat_GSO.Size = new Size(120, 72);
            buttonWhat_GSO.TabIndex = 4;
            buttonWhat_GSO.Text = "Справка";
            buttonWhat_GSO.UseVisualStyleBackColor = false;
            buttonWhat_GSO.Click += buttonWhat_GSO_Click;
            // 
            // buttonDo_GSO
            // 
            buttonDo_GSO.BackColor = Color.Red;
            buttonDo_GSO.Location = new Point(12, 402);
            buttonDo_GSO.Name = "buttonDo_GSO";
            buttonDo_GSO.Size = new Size(149, 72);
            buttonDo_GSO.TabIndex = 5;
            buttonDo_GSO.Text = "Выполнить";
            buttonDo_GSO.UseVisualStyleBackColor = false;
            buttonDo_GSO.Click += buttonDo_GSO_Click;
            // 
            // groupBoxOutput_GSO
            // 
            groupBoxOutput_GSO.Controls.Add(dataGridViewFunction_GSO);
            groupBoxOutput_GSO.Controls.Add(label1);
            groupBoxOutput_GSO.Location = new Point(403, 12);
            groupBoxOutput_GSO.Name = "groupBoxOutput_GSO";
            groupBoxOutput_GSO.Size = new Size(182, 526);
            groupBoxOutput_GSO.TabIndex = 6;
            groupBoxOutput_GSO.TabStop = false;
            groupBoxOutput_GSO.Text = "Вывод данных";
            // 
            // dataGridViewFunction_GSO
            // 
            dataGridViewFunction_GSO.BackgroundColor = SystemColors.Menu;
            dataGridViewFunction_GSO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_GSO.Columns.AddRange(new DataGridViewColumn[] { ColumnInput, ColumnOutput });
            dataGridViewFunction_GSO.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewFunction_GSO.Location = new Point(18, 46);
            dataGridViewFunction_GSO.Name = "dataGridViewFunction_GSO";
            dataGridViewFunction_GSO.RowHeadersVisible = false;
            dataGridViewFunction_GSO.RowHeadersWidth = 51;
            dataGridViewFunction_GSO.Size = new Size(158, 474);
            dataGridViewFunction_GSO.TabIndex = 1;
            // 
            // ColumnInput
            // 
            ColumnInput.HeaderText = "X";
            ColumnInput.MinimumWidth = 6;
            ColumnInput.Name = "ColumnInput";
            ColumnInput.Width = 50;
            // 
            // ColumnOutput
            // 
            ColumnOutput.HeaderText = "F(X)";
            ColumnOutput.MinimumWidth = 6;
            ColumnOutput.Name = "ColumnOutput";
            ColumnOutput.Width = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Результат";
            // 
            // chartFunction_GSO
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_GSO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_GSO.Legends.Add(legend1);
            chartFunction_GSO.Location = new Point(6, 43);
            chartFunction_GSO.Name = "chartFunction_GSO";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_GSO.Series.Add(series1);
            chartFunction_GSO.Size = new Size(552, 448);
            chartFunction_GSO.TabIndex = 0;
            chartFunction_GSO.Text = "chart1";
            // 
            // groupBoxFunction_GSO
            // 
            groupBoxFunction_GSO.Controls.Add(chartFunction_GSO);
            groupBoxFunction_GSO.Location = new Point(591, 12);
            groupBoxFunction_GSO.Name = "groupBoxFunction_GSO";
            groupBoxFunction_GSO.Size = new Size(542, 520);
            groupBoxFunction_GSO.TabIndex = 7;
            groupBoxFunction_GSO.TabStop = false;
            groupBoxFunction_GSO.Text = "График";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 550);
            Controls.Add(groupBoxFunction_GSO);
            Controls.Add(groupBoxOutput_GSO);
            Controls.Add(buttonDo_GSO);
            Controls.Add(buttonWhat_GSO);
            Controls.Add(groupBoxInput_GSO);
            Controls.Add(groupBoxCondition_GSO);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 7 | Губанова С.О.";
            groupBoxCondition_GSO.ResumeLayout(false);
            groupBoxCondition_GSO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInput_GSO.ResumeLayout(false);
            groupBoxInput_GSO.PerformLayout();
            groupBoxOutput_GSO.ResumeLayout(false);
            groupBoxOutput_GSO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_GSO).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_GSO).EndInit();
            groupBoxFunction_GSO.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_GSO;
        private Label labelCondition_GSO;
        private GroupBox groupBoxInput_GSO;
        private TextBox textBoxStop_GSO;
        private TextBox textBoxStart_GSO;
        private Label labelStop_GSO;
        private Label labelStart_GSO;
        private Button buttonWhat_GSO;
        private Button buttonDo_GSO;
        private GroupBox groupBoxOutput_GSO;
        private Label label1;
        private DataGridView dataGridViewFunction_GSO;
        private DataGridViewTextBoxColumn ColumnInput;
        private DataGridViewTextBoxColumn ColumnOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GSO;
        private GroupBox groupBoxFunction_GSO;
        private PictureBox pictureBox1;
    }
}
