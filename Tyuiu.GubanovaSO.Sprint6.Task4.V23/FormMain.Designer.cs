namespace Tyuiu.GubanovaSO.Sprint6.Task4.V23
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
            buttonWhat_GSO = new Button();
            buttonDo_GSO = new Button();
            groupBoxInput_GSO = new GroupBox();
            textBoxStop_GSO = new TextBox();
            textBoxStart_GSO = new TextBox();
            labelStop_GSO = new Label();
            labelStart_GSO = new Label();
            buttonSave_GSO = new Button();
            groupBoxFunction_GSO = new GroupBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutput_GSO = new GroupBox();
            textBox1 = new TextBox();
            groupBoxCondition_GSO = new GroupBox();
            labelCondition_GSO = new Label();
            groupBoxInput_GSO.SuspendLayout();
            groupBoxFunction_GSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBoxOutput_GSO.SuspendLayout();
            groupBoxCondition_GSO.SuspendLayout();
            SuspendLayout();
            // 
            // buttonWhat_GSO
            // 
            buttonWhat_GSO.BackColor = Color.Silver;
            buttonWhat_GSO.Location = new Point(737, 27);
            buttonWhat_GSO.Name = "buttonWhat_GSO";
            buttonWhat_GSO.Size = new Size(64, 61);
            buttonWhat_GSO.TabIndex = 9;
            buttonWhat_GSO.Text = "?";
            buttonWhat_GSO.UseVisualStyleBackColor = false;
            buttonWhat_GSO.Click += buttonWhat_GSO_Click;
            // 
            // buttonDo_GSO
            // 
            buttonDo_GSO.BackColor = Color.Silver;
            buttonDo_GSO.Location = new Point(631, 27);
            buttonDo_GSO.Name = "buttonDo_GSO";
            buttonDo_GSO.Size = new Size(100, 61);
            buttonDo_GSO.TabIndex = 8;
            buttonDo_GSO.Text = "Выполнить";
            buttonDo_GSO.UseVisualStyleBackColor = false;
            buttonDo_GSO.Click += buttonDo_GSO_Click;
            // 
            // groupBoxInput_GSO
            // 
            groupBoxInput_GSO.Controls.Add(textBoxStop_GSO);
            groupBoxInput_GSO.Controls.Add(textBoxStart_GSO);
            groupBoxInput_GSO.Controls.Add(labelStop_GSO);
            groupBoxInput_GSO.Controls.Add(labelStart_GSO);
            groupBoxInput_GSO.Location = new Point(416, 15);
            groupBoxInput_GSO.Name = "groupBoxInput_GSO";
            groupBoxInput_GSO.Size = new Size(209, 79);
            groupBoxInput_GSO.TabIndex = 10;
            groupBoxInput_GSO.TabStop = false;
            groupBoxInput_GSO.Text = "Ввод данных";
            // 
            // textBoxStop_GSO
            // 
            textBoxStop_GSO.Location = new Point(106, 46);
            textBoxStop_GSO.Name = "textBoxStop_GSO";
            textBoxStop_GSO.Size = new Size(94, 27);
            textBoxStop_GSO.TabIndex = 3;
            // 
            // textBoxStart_GSO
            // 
            textBoxStart_GSO.Location = new Point(6, 46);
            textBoxStart_GSO.Name = "textBoxStart_GSO";
            textBoxStart_GSO.Size = new Size(94, 27);
            textBoxStart_GSO.TabIndex = 2;
            // 
            // labelStop_GSO
            // 
            labelStop_GSO.AutoSize = true;
            labelStop_GSO.Location = new Point(106, 23);
            labelStop_GSO.Name = "labelStop_GSO";
            labelStop_GSO.Size = new Size(91, 20);
            labelStop_GSO.TabIndex = 1;
            labelStop_GSO.Text = "Конец шага";
            // 
            // labelStart_GSO
            // 
            labelStart_GSO.AutoSize = true;
            labelStart_GSO.Location = new Point(6, 23);
            labelStart_GSO.Name = "labelStart_GSO";
            labelStart_GSO.Size = new Size(85, 20);
            labelStart_GSO.TabIndex = 0;
            labelStart_GSO.Text = "Старт шага";
            // 
            // buttonSave_GSO
            // 
            buttonSave_GSO.BackColor = Color.Silver;
            buttonSave_GSO.Location = new Point(807, 27);
            buttonSave_GSO.Name = "buttonSave_GSO";
            buttonSave_GSO.Size = new Size(100, 61);
            buttonSave_GSO.TabIndex = 11;
            buttonSave_GSO.Text = "Сохранить";
            buttonSave_GSO.UseVisualStyleBackColor = false;
            buttonSave_GSO.Click += buttonSave_GSO_Click;
            // 
            // groupBoxFunction_GSO
            // 
            groupBoxFunction_GSO.Controls.Add(chart1);
            groupBoxFunction_GSO.Location = new Point(403, 94);
            groupBoxFunction_GSO.Name = "groupBoxFunction_GSO";
            groupBoxFunction_GSO.Size = new Size(630, 384);
            groupBoxFunction_GSO.TabIndex = 12;
            groupBoxFunction_GSO.TabStop = false;
            groupBoxFunction_GSO.Text = "График";
            // 
            // chart1
            // 
            chartArea1.Name = "chart1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(6, 26);
            chart1.Name = "chart1";
            series1.ChartArea = "chart1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(618, 359);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // groupBoxOutput_GSO
            // 
            groupBoxOutput_GSO.Controls.Add(textBox1);
            groupBoxOutput_GSO.Location = new Point(19, 94);
            groupBoxOutput_GSO.Name = "groupBoxOutput_GSO";
            groupBoxOutput_GSO.Size = new Size(378, 384);
            groupBoxOutput_GSO.TabIndex = 13;
            groupBoxOutput_GSO.TabStop = false;
            groupBoxOutput_GSO.Text = "Вывод";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 350);
            textBox1.TabIndex = 14;
            // 
            // groupBoxCondition_GSO
            // 
            groupBoxCondition_GSO.Controls.Add(labelCondition_GSO);
            groupBoxCondition_GSO.Location = new Point(19, 10);
            groupBoxCondition_GSO.Name = "groupBoxCondition_GSO";
            groupBoxCondition_GSO.Size = new Size(391, 84);
            groupBoxCondition_GSO.TabIndex = 14;
            groupBoxCondition_GSO.TabStop = false;
            groupBoxCondition_GSO.Text = "Условие";
            // 
            // labelCondition_GSO
            // 
            labelCondition_GSO.AutoSize = true;
            labelCondition_GSO.Location = new Point(6, 17);
            labelCondition_GSO.Name = "labelCondition_GSO";
            labelCondition_GSO.Size = new Size(338, 60);
            labelCondition_GSO.TabIndex = 0;
            labelCondition_GSO.Text = "Произвести табулирование f(x) на заданном\r\n диапазоне [-5; 5]. Результат вывести в textBox, \r\nпостроить график функции и сохранить в файл\r\n";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 490);
            Controls.Add(groupBoxCondition_GSO);
            Controls.Add(groupBoxOutput_GSO);
            Controls.Add(groupBoxFunction_GSO);
            Controls.Add(buttonSave_GSO);
            Controls.Add(groupBoxInput_GSO);
            Controls.Add(buttonWhat_GSO);
            Controls.Add(buttonDo_GSO);
            Name = "FormMain";
            Text = "Form1";
            groupBoxInput_GSO.ResumeLayout(false);
            groupBoxInput_GSO.PerformLayout();
            groupBoxFunction_GSO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBoxOutput_GSO.ResumeLayout(false);
            groupBoxOutput_GSO.PerformLayout();
            groupBoxCondition_GSO.ResumeLayout(false);
            groupBoxCondition_GSO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonWhat_GSO;
        private Button buttonDo_GSO;
        private GroupBox groupBoxInput_GSO;
        private TextBox textBoxStop_GSO;
        private TextBox textBoxStart_GSO;
        private Label labelStop_GSO;
        private Label labelStart_GSO;
        private Button buttonSave_GSO;
        private GroupBox groupBoxFunction_GSO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GroupBox groupBoxOutput_GSO;
        private TextBox textBox1;
        private GroupBox groupBoxCondition_GSO;
        private Label labelCondition_GSO;
    }
}
