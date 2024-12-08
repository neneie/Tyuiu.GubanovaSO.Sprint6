using Tyuiu.GubanovaSO.Sprint6.Task3.V4.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task3.V4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_GSO = new GroupBox();
            labelCondition_GSO = new Label();
            buttonDo_GSO = new Button();
            buttonWhat_GSO = new Button();
            dataGridViewMtrx_GSO = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_GSO).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_GSO
            // 
            groupBoxCondition_GSO.Location = new Point(12, 12);
            groupBoxCondition_GSO.Name = "groupBoxCondition_GSO";
            groupBoxCondition_GSO.Size = new Size(371, 204);
            groupBoxCondition_GSO.TabIndex = 2;
            groupBoxCondition_GSO.TabStop = false;
            groupBoxCondition_GSO.Text = "Условие";
            // 
            // labelCondition_GSO
            // 
            labelCondition_GSO.AutoSize = true;
            labelCondition_GSO.Location = new Point(18, 36);
            labelCondition_GSO.Name = "labelCondition_GSO";
            labelCondition_GSO.Size = new Size(361, 160);
            labelCondition_GSO.TabIndex = 0;
            labelCondition_GSO.Text = resources.GetString("labelCondition_GSO.Text");
            // 
            // buttonDo_GSO
            // 
            buttonDo_GSO.BackColor = Color.Silver;
            buttonDo_GSO.Location = new Point(573, 191);
            buttonDo_GSO.Name = "buttonDo_GSO";
            buttonDo_GSO.Size = new Size(120, 43);
            buttonDo_GSO.TabIndex = 6;
            buttonDo_GSO.Text = "Выполнить";
            buttonDo_GSO.UseVisualStyleBackColor = false;
            buttonDo_GSO.Click += buttonDo_GSO_Click;
            // 
            // buttonWhat_GSO
            // 
            buttonWhat_GSO.BackColor = Color.Silver;
            buttonWhat_GSO.Location = new Point(520, 191);
            buttonWhat_GSO.Name = "buttonWhat_GSO";
            buttonWhat_GSO.Size = new Size(47, 43);
            buttonWhat_GSO.TabIndex = 7;
            buttonWhat_GSO.Text = "?";
            buttonWhat_GSO.UseVisualStyleBackColor = false;
            buttonWhat_GSO.Click += buttonWhat_GSO_Click;
            // 
            // dataGridViewMtrx_GSO
            // 
            dataGridViewMtrx_GSO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMtrx_GSO.ColumnHeadersVisible = false;
            dataGridViewMtrx_GSO.Location = new Point(389, 12);
            dataGridViewMtrx_GSO.Name = "dataGridViewMtrx_GSO";
            dataGridViewMtrx_GSO.RowHeadersVisible = false;
            dataGridViewMtrx_GSO.RowHeadersWidth = 51;
            dataGridViewMtrx_GSO.Size = new Size(304, 155);
            dataGridViewMtrx_GSO.TabIndex = 8;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 246);
            Controls.Add(labelCondition_GSO);
            Controls.Add(dataGridViewMtrx_GSO);
            Controls.Add(buttonWhat_GSO);
            Controls.Add(buttonDo_GSO);
            Controls.Add(groupBoxCondition_GSO);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 4 | Губанова С.О.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_GSO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCondition_GSO;
        private Label labelCondition_GSO;
        private Button buttonDo_GSO;
        private Button buttonWhat_GSO;
        private DataGridView dataGridViewMtrx_GSO;
    }
}
