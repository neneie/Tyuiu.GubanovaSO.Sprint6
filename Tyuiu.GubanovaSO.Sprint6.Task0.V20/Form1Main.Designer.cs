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
            groupBoxInput_GSO = new GroupBox();
            groupBoxOutput_GSO = new GroupBox();
            buttonDo_GSO = new Button();
            SuspendLayout();
            // 
            // groupBoxCondition_GSO
            // 
            groupBoxCondition_GSO.Location = new Point(12, 12);
            groupBoxCondition_GSO.Name = "groupBoxCondition_GSO";
            groupBoxCondition_GSO.Size = new Size(776, 204);
            groupBoxCondition_GSO.TabIndex = 0;
            groupBoxCondition_GSO.TabStop = false;
            groupBoxCondition_GSO.Text = "Условие";
            // 
            // groupBoxInput_GSO
            // 
            groupBoxInput_GSO.Location = new Point(12, 222);
            groupBoxInput_GSO.Name = "groupBoxInput_GSO";
            groupBoxInput_GSO.Size = new Size(377, 111);
            groupBoxInput_GSO.TabIndex = 1;
            groupBoxInput_GSO.TabStop = false;
            groupBoxInput_GSO.Text = "Ввод данных";
            // 
            // groupBoxOutput_GSO
            // 
            groupBoxOutput_GSO.Location = new Point(395, 222);
            groupBoxOutput_GSO.Name = "groupBoxOutput_GSO";
            groupBoxOutput_GSO.Size = new Size(393, 111);
            groupBoxOutput_GSO.TabIndex = 2;
            groupBoxOutput_GSO.TabStop = false;
            groupBoxOutput_GSO.Text = "Вывод данных";
            // groupBoxOutput_GSO.Enter += this.groupBoxOutput_GSO_Enter;
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
            // Form1main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDo_GSO);
            Controls.Add(groupBoxOutput_GSO);
            Controls.Add(groupBoxInput_GSO);
            Controls.Add(groupBoxCondition_GSO);
            Name = "Form1main";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_GSO;
        private GroupBox groupBoxInput_GSO;
        private GroupBox groupBoxOutput_GSO;
        private Button buttonDo_GSO;
    }
}
