namespace Tyuiu.GubanovaSO.Sprint6.Task1.V24
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
            groupBoxCondition_GSO = new GroupBox();
            labelCondition_GSO = new Label();
            groupBoxInput_GSO = new GroupBox();
            textBoxStop_GSO = new TextBox();
            textBoxStart_GSO = new TextBox();
            labelStop_GSO = new Label();
            labelStart_GSO = new Label();
            groupBoxOutput_GSO = new GroupBox();
            textBoxOutput_GSO = new TextBox();
            label1 = new Label();
            buttonWhat_GSO = new Button();
            buttonDo_GSO = new Button();
            groupBoxCondition_GSO.SuspendLayout();
            groupBoxInput_GSO.SuspendLayout();
            groupBoxOutput_GSO.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_GSO
            // 
            groupBoxCondition_GSO.Controls.Add(labelCondition_GSO);
            groupBoxCondition_GSO.Location = new Point(12, 12);
            groupBoxCondition_GSO.Name = "groupBoxCondition_GSO";
            groupBoxCondition_GSO.Size = new Size(548, 241);
            groupBoxCondition_GSO.TabIndex = 0;
            groupBoxCondition_GSO.TabStop = false;
            groupBoxCondition_GSO.Text = "Условие";
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
            groupBoxInput_GSO.Location = new Point(12, 259);
            groupBoxInput_GSO.Name = "groupBoxInput_GSO";
            groupBoxInput_GSO.Size = new Size(291, 90);
            groupBoxInput_GSO.TabIndex = 1;
            groupBoxInput_GSO.TabStop = false;
            groupBoxInput_GSO.Text = "Ввод данных";
            // 
            // textBoxStop_GSO
            // 
            textBoxStop_GSO.Location = new Point(167, 55);
            textBoxStop_GSO.Name = "textBoxStop_GSO";
            textBoxStop_GSO.Size = new Size(94, 27);
            textBoxStop_GSO.TabIndex = 3;
            textBoxStop_GSO.Enter += textBoxStop_GSO_Enter;
            textBoxStop_GSO.Leave += textBoxStop_GSO_Leave;
            // 
            // textBoxStart_GSO
            // 
            textBoxStart_GSO.Location = new Point(12, 55);
            textBoxStart_GSO.Name = "textBoxStart_GSO";
            textBoxStart_GSO.Size = new Size(94, 27);
            textBoxStart_GSO.TabIndex = 2;
            textBoxStart_GSO.Enter += textBoxStart_GSO_Enter;
            textBoxStart_GSO.Leave += textBoxStart_GSO_Leave;
            // 
            // labelStop_GSO
            // 
            labelStop_GSO.AutoSize = true;
            labelStop_GSO.Location = new Point(167, 21);
            labelStop_GSO.Name = "labelStop_GSO";
            labelStop_GSO.Size = new Size(91, 20);
            labelStop_GSO.TabIndex = 1;
            labelStop_GSO.Text = "Конец шага";
            // 
            // labelStart_GSO
            // 
            labelStart_GSO.AutoSize = true;
            labelStart_GSO.Location = new Point(12, 21);
            labelStart_GSO.Name = "labelStart_GSO";
            labelStart_GSO.Size = new Size(85, 20);
            labelStart_GSO.TabIndex = 0;
            labelStart_GSO.Text = "Старт шага";
            // 
            // groupBoxOutput_GSO
            // 
            groupBoxOutput_GSO.Controls.Add(textBoxOutput_GSO);
            groupBoxOutput_GSO.Controls.Add(label1);
            groupBoxOutput_GSO.Location = new Point(584, 12);
            groupBoxOutput_GSO.Name = "groupBoxOutput_GSO";
            groupBoxOutput_GSO.Size = new Size(360, 364);
            groupBoxOutput_GSO.TabIndex = 2;
            groupBoxOutput_GSO.TabStop = false;
            groupBoxOutput_GSO.Text = "Вывод данных";
            // 
            // textBoxOutput_GSO
            // 
            textBoxOutput_GSO.Location = new Point(6, 65);
            textBoxOutput_GSO.Multiline = true;
            textBoxOutput_GSO.Name = "textBoxOutput_GSO";
            textBoxOutput_GSO.Size = new Size(348, 293);
            textBoxOutput_GSO.TabIndex = 1;
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
            // buttonWhat_GSO
            // 
            buttonWhat_GSO.BackColor = SystemColors.MenuHighlight;
            buttonWhat_GSO.Location = new Point(303, 277);
            buttonWhat_GSO.Name = "buttonWhat_GSO";
            buttonWhat_GSO.Size = new Size(120, 72);
            buttonWhat_GSO.TabIndex = 3;
            buttonWhat_GSO.Text = "Справка";
            buttonWhat_GSO.UseVisualStyleBackColor = false;
            buttonWhat_GSO.Click += buttonWhat_Click;
            // 
            // buttonDo_GSO
            // 
            buttonDo_GSO.BackColor = Color.Red;
            buttonDo_GSO.Location = new Point(429, 277);
            buttonDo_GSO.Name = "buttonDo_GSO";
            buttonDo_GSO.Size = new Size(149, 72);
            buttonDo_GSO.TabIndex = 4;
            buttonDo_GSO.Text = "Выполнить";
            buttonDo_GSO.UseVisualStyleBackColor = false;
            buttonDo_GSO.Click += buttonDo_GSO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 385);
            Controls.Add(buttonDo_GSO);
            Controls.Add(buttonWhat_GSO);
            Controls.Add(groupBoxOutput_GSO);
            Controls.Add(groupBoxInput_GSO);
            Controls.Add(groupBoxCondition_GSO);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 24 | Губанова С.О.";
            groupBoxCondition_GSO.ResumeLayout(false);
            groupBoxCondition_GSO.PerformLayout();
            groupBoxInput_GSO.ResumeLayout(false);
            groupBoxInput_GSO.PerformLayout();
            groupBoxOutput_GSO.ResumeLayout(false);
            groupBoxOutput_GSO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_GSO;
        private GroupBox groupBoxInput_GSO;
        private GroupBox groupBoxOutput_GSO;
        private Button buttonWhat_GSO;
        private Label labelCondition_GSO;
        private Button buttonDo_GSO;
        private Label labelStart_GSO;
        private TextBox textBoxStop_GSO;
        private TextBox textBoxStart_GSO;
        private Label labelStop_GSO;
        private Label label1;
        private TextBox textBoxOutput_GSO;
    }
}
