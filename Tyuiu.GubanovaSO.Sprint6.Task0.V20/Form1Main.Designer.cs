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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            groupBoxInput_GSO = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBoxOutput_GSO = new GroupBox();
            label2 = new Label();
            textBox2 = new TextBox();
            buttonDo_GSO = new Button();
            button1 = new Button();
            groupBoxCondition_GSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInput_GSO.SuspendLayout();
            groupBoxOutput_GSO.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_GSO
            // 
            groupBoxCondition_GSO.Controls.Add(pictureBox1);
            groupBoxCondition_GSO.Controls.Add(label3);
            groupBoxCondition_GSO.Location = new Point(12, 12);
            groupBoxCondition_GSO.Name = "groupBoxCondition_GSO";
            groupBoxCondition_GSO.Size = new Size(776, 204);
            groupBoxCondition_GSO.TabIndex = 0;
            groupBoxCondition_GSO.TabStop = false;
            groupBoxCondition_GSO.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.saefsd;
            pictureBox1.Location = new Point(547, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            groupBoxInput_GSO.Controls.Add(label1);
            groupBoxInput_GSO.Controls.Add(textBox1);
            groupBoxInput_GSO.Location = new Point(12, 222);
            groupBoxInput_GSO.Name = "groupBoxInput_GSO";
            groupBoxInput_GSO.Size = new Size(377, 132);
            groupBoxInput_GSO.TabIndex = 1;
            groupBoxInput_GSO.TabStop = false;
            groupBoxInput_GSO.Text = "Ввод данных";
            // 
            // label1
            // 
            label1.AccessibleName = "labelInput_GSO";
            label1.AutoSize = true;
            label1.Location = new Point(74, 48);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 1;
            label1.Text = "Переменная Х:";
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "textBoxInput_GSO";
            textBox1.Location = new Point(74, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxOutput_GSO
            // 
            groupBoxOutput_GSO.Controls.Add(label2);
            groupBoxOutput_GSO.Controls.Add(textBox2);
            groupBoxOutput_GSO.Location = new Point(395, 222);
            groupBoxOutput_GSO.Name = "groupBoxOutput_GSO";
            groupBoxOutput_GSO.Size = new Size(393, 132);
            groupBoxOutput_GSO.TabIndex = 2;
            groupBoxOutput_GSO.TabStop = false;
            groupBoxOutput_GSO.Text = "Вывод данных";
            // 
            // label2
            // 
            label2.AccessibleName = "labelOutput_GSO";
            label2.AutoSize = true;
            label2.Location = new Point(92, 48);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Результат";
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "textBoxOutput_GSO";
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(92, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 27);
            textBox2.TabIndex = 1;
            // 
            // buttonDo_GSO
            // 
            buttonDo_GSO.Location = new Point(548, 368);
            buttonDo_GSO.Name = "buttonDo_GSO";
            buttonDo_GSO.Size = new Size(202, 62);
            buttonDo_GSO.TabIndex = 3;
            buttonDo_GSO.Text = "Вычислить";
            buttonDo_GSO.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AccessibleName = "buttonWhat_GSO";
            button1.Location = new Point(478, 368);
            button1.Name = "button1";
            button1.Size = new Size(64, 62);
            button1.TabIndex = 4;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonDo_GSO);
            Controls.Add(groupBoxOutput_GSO);
            Controls.Add(groupBoxInput_GSO);
            Controls.Add(groupBoxCondition_GSO);
            Name = "Form1main";
            Text = "Спринт 6 | Таск 0 | Вариант 20 | Губанова С.О.";
            groupBoxCondition_GSO.ResumeLayout(false);
            groupBoxCondition_GSO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
