namespace Tyuiu.GubanovaSO.Sprint6.Task0.V20
{
    partial class Form1main
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
            pictureBoxCondition_GSO = new PictureBox();
            label3 = new Label();
            groupBoxInput_GSO = new GroupBox();
            labelInput_GSO = new Label();
            textBoxInput_GSO = new TextBox();
            groupBoxOutput_GSO = new GroupBox();
            labelOutput_GSO = new Label();
            textBoxOutput_GSO = new TextBox();
            buttonDo_GSO = new Button();
            buttonWhat_GSO = new Button();
            groupBoxCondition_GSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_GSO).BeginInit();
            groupBoxInput_GSO.SuspendLayout();
            groupBoxOutput_GSO.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_GSO
            // 
            groupBoxCondition_GSO.Controls.Add(pictureBoxCondition_GSO);
            groupBoxCondition_GSO.Controls.Add(label3);
            groupBoxCondition_GSO.Location = new Point(12, 12);
            groupBoxCondition_GSO.Name = "groupBoxCondition_GSO";
            groupBoxCondition_GSO.Size = new Size(776, 204);
            groupBoxCondition_GSO.TabIndex = 0;
            groupBoxCondition_GSO.TabStop = false;
            groupBoxCondition_GSO.Text = "Условие";
            // 
            // pictureBoxCondition_GSO
            // 
            pictureBoxCondition_GSO.Image = Properties.Resources.saefsd;
            pictureBoxCondition_GSO.Location = new Point(547, 26);
            pictureBoxCondition_GSO.Name = "pictureBoxCondition_GSO";
            pictureBoxCondition_GSO.Size = new Size(191, 136);
            pictureBoxCondition_GSO.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCondition_GSO.TabIndex = 1;
            pictureBoxCondition_GSO.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 47);
            label3.Name = "label3";
            label3.Size = new Size(260, 20);
            label3.TabIndex = 0;
            label3.Text = "Вычислить выражение по формуле:";
            // 
            // groupBoxInput_GSO
            // 
            groupBoxInput_GSO.Controls.Add(labelInput_GSO);
            groupBoxInput_GSO.Controls.Add(textBoxInput_GSO);
            groupBoxInput_GSO.Location = new Point(12, 222);
            groupBoxInput_GSO.Name = "groupBoxInput_GSO";
            groupBoxInput_GSO.Size = new Size(377, 132);
            groupBoxInput_GSO.TabIndex = 1;
            groupBoxInput_GSO.TabStop = false;
            groupBoxInput_GSO.Text = "Ввод данных";
            // 
            // labelInput_GSO
            // 
            labelInput_GSO.AccessibleName = "";
            labelInput_GSO.AutoSize = true;
            labelInput_GSO.Location = new Point(74, 48);
            labelInput_GSO.Name = "labelInput_GSO";
            labelInput_GSO.Size = new Size(114, 20);
            labelInput_GSO.TabIndex = 1;
            labelInput_GSO.Text = "Переменная Х:";
            // 
            // textBoxInput_GSO
            // 
            textBoxInput_GSO.AccessibleName = "";
            textBoxInput_GSO.Location = new Point(74, 84);
            textBoxInput_GSO.Name = "textBoxInput_GSO";
            textBoxInput_GSO.Size = new Size(172, 27);
            textBoxInput_GSO.TabIndex = 0;
            textBoxInput_GSO.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxOutput_GSO
            // 
            groupBoxOutput_GSO.Controls.Add(labelOutput_GSO);
            groupBoxOutput_GSO.Controls.Add(textBoxOutput_GSO);
            groupBoxOutput_GSO.Location = new Point(395, 222);
            groupBoxOutput_GSO.Name = "groupBoxOutput_GSO";
            groupBoxOutput_GSO.Size = new Size(393, 132);
            groupBoxOutput_GSO.TabIndex = 2;
            groupBoxOutput_GSO.TabStop = false;
            groupBoxOutput_GSO.Text = "Вывод данных";
            // 
            // labelOutput_GSO
            // 
            labelOutput_GSO.AccessibleName = "";
            labelOutput_GSO.AutoSize = true;
            labelOutput_GSO.Location = new Point(92, 48);
            labelOutput_GSO.Name = "labelOutput_GSO";
            labelOutput_GSO.Size = new Size(75, 20);
            labelOutput_GSO.TabIndex = 2;
            labelOutput_GSO.Text = "Результат";
            // 
            // textBoxOutput_GSO
            // 
            textBoxOutput_GSO.AccessibleName = "";
            textBoxOutput_GSO.BackColor = SystemColors.Menu;
            textBoxOutput_GSO.Location = new Point(92, 84);
            textBoxOutput_GSO.Name = "textBoxOutput_GSO";
            textBoxOutput_GSO.Size = new Size(159, 27);
            textBoxOutput_GSO.TabIndex = 1;
            // 
            // buttonDo_GSO
            // 
            buttonDo_GSO.AccessibleName = "";
            buttonDo_GSO.Location = new Point(548, 368);
            buttonDo_GSO.Name = "buttonDo_GSO";
            buttonDo_GSO.Size = new Size(202, 62);
            buttonDo_GSO.TabIndex = 3;
            buttonDo_GSO.Text = "Вычислить";
            buttonDo_GSO.UseVisualStyleBackColor = true;
            buttonDo_GSO.Click += buttonDo_GSO_Click;
            // 
            // buttonWhat_GSO
            // 
            buttonWhat_GSO.AccessibleName = "";
            buttonWhat_GSO.Location = new Point(478, 368);
            buttonWhat_GSO.Name = "buttonWhat_GSO";
            buttonWhat_GSO.Size = new Size(64, 62);
            buttonWhat_GSO.TabIndex = 4;
            buttonWhat_GSO.Text = "?";
            buttonWhat_GSO.UseVisualStyleBackColor = true;
            buttonWhat_GSO.Click += buttonWhat_GSO_Click;
            // 
            // Form1main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonWhat_GSO);
            Controls.Add(buttonDo_GSO);
            Controls.Add(groupBoxOutput_GSO);
            Controls.Add(groupBoxInput_GSO);
            Controls.Add(groupBoxCondition_GSO);
            Name = "Form1main";
            Text = "Спринт 6 | Таск 0 | Вариант 20 | Губанова С.О.";
            groupBoxCondition_GSO.ResumeLayout(false);
            groupBoxCondition_GSO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition_GSO).EndInit();
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
        private Button buttonDo_GSO;
        private TextBox textBoxInput_GSO;
        private TextBox textBoxOutput_GSO;
        private Label labelInput_GSO;
        private Label labelOutput_GSO;
        private Label label3;
        private PictureBox pictureBoxCondition_GSO;
        private Button buttonWhat_GSO;
    }
}
