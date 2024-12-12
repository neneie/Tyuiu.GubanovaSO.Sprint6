namespace Tyuiu.GubanovaSO.Sprint6.Task6.V18
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxInput_GSO = new GroupBox();
            textBoxInput_GSO = new TextBox();
            groupBoxOutput_GSO = new GroupBox();
            textBoxOutput_GSO = new TextBox();
            groupBoxCondition_GSO = new GroupBox();
            textBoxCondition_GSO = new TextBox();
            buttonOpenFile_GSO = new Button();
            buttonDo_GSO = new Button();
            buttonWhat_GSO = new Button();
            openFileDialogTask_GSO = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            groupBoxInput_GSO.SuspendLayout();
            groupBoxOutput_GSO.SuspendLayout();
            groupBoxCondition_GSO.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInput_GSO
            // 
            groupBoxInput_GSO.Controls.Add(textBoxInput_GSO);
            groupBoxInput_GSO.Location = new Point(12, 183);
            groupBoxInput_GSO.Name = "groupBoxInput_GSO";
            groupBoxInput_GSO.Size = new Size(558, 365);
            groupBoxInput_GSO.TabIndex = 0;
            groupBoxInput_GSO.TabStop = false;
            groupBoxInput_GSO.Text = "Ввод";
            // 
            // textBoxInput_GSO
            // 
            textBoxInput_GSO.Location = new Point(13, 28);
            textBoxInput_GSO.Multiline = true;
            textBoxInput_GSO.Name = "textBoxInput_GSO";
            textBoxInput_GSO.Size = new Size(539, 320);
            textBoxInput_GSO.TabIndex = 0;
            // 
            // groupBoxOutput_GSO
            // 
            groupBoxOutput_GSO.Controls.Add(textBoxOutput_GSO);
            groupBoxOutput_GSO.Location = new Point(576, 183);
            groupBoxOutput_GSO.Name = "groupBoxOutput_GSO";
            groupBoxOutput_GSO.Size = new Size(542, 376);
            groupBoxOutput_GSO.TabIndex = 1;
            groupBoxOutput_GSO.TabStop = false;
            groupBoxOutput_GSO.Text = "Вывод";
            // 
            // textBoxOutput_GSO
            // 
            textBoxOutput_GSO.BackColor = SystemColors.Window;
            textBoxOutput_GSO.Location = new Point(13, 28);
            textBoxOutput_GSO.Multiline = true;
            textBoxOutput_GSO.Name = "textBoxOutput_GSO";
            textBoxOutput_GSO.Size = new Size(523, 320);
            textBoxOutput_GSO.TabIndex = 0;
            // 
            // groupBoxCondition_GSO
            // 
            groupBoxCondition_GSO.Controls.Add(textBoxCondition_GSO);
            groupBoxCondition_GSO.Location = new Point(12, 93);
            groupBoxCondition_GSO.Name = "groupBoxCondition_GSO";
            groupBoxCondition_GSO.Size = new Size(1106, 86);
            groupBoxCondition_GSO.TabIndex = 2;
            groupBoxCondition_GSO.TabStop = false;
            groupBoxCondition_GSO.Text = "Условие";
            // 
            // textBoxCondition_GSO
            // 
            textBoxCondition_GSO.BackColor = SystemColors.Menu;
            textBoxCondition_GSO.ForeColor = SystemColors.ControlText;
            textBoxCondition_GSO.Location = new Point(13, 26);
            textBoxCondition_GSO.Multiline = true;
            textBoxCondition_GSO.Name = "textBoxCondition_GSO";
            textBoxCondition_GSO.Size = new Size(1087, 54);
            textBoxCondition_GSO.TabIndex = 0;
            textBoxCondition_GSO.Text = resources.GetString("textBoxCondition_GSO.Text");
            // 
            // buttonOpenFile_GSO
            // 
            buttonOpenFile_GSO.BackgroundImage = Properties.Resources.folder_page_white1;
            buttonOpenFile_GSO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_GSO.Location = new Point(25, 12);
            buttonOpenFile_GSO.Name = "buttonOpenFile_GSO";
            buttonOpenFile_GSO.Size = new Size(94, 75);
            buttonOpenFile_GSO.TabIndex = 3;
            toolTip1.SetToolTip(buttonOpenFile_GSO, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_GSO.UseVisualStyleBackColor = true;
            buttonOpenFile_GSO.Click += buttonOpenFile_GSO_Click;
            // 
            // buttonDo_GSO
            // 
            buttonDo_GSO.BackgroundImage = Properties.Resources.page_go;
            buttonDo_GSO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDo_GSO.Location = new Point(125, 12);
            buttonDo_GSO.Name = "buttonDo_GSO";
            buttonDo_GSO.Size = new Size(93, 75);
            buttonDo_GSO.TabIndex = 4;
            toolTip1.SetToolTip(buttonDo_GSO, "Производится поиск в файле вхождения символов \"n\"\r\nи конкатенирует строки, в которых находиться этот символ");
            buttonDo_GSO.UseVisualStyleBackColor = true;
            buttonDo_GSO.Click += buttonDo_GSO_Click;
            // 
            // buttonWhat_GSO
            // 
            buttonWhat_GSO.BackgroundImage = Properties.Resources.emotion_evilgrin;
            buttonWhat_GSO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonWhat_GSO.Location = new Point(1019, 12);
            buttonWhat_GSO.Name = "buttonWhat_GSO";
            buttonWhat_GSO.Size = new Size(93, 75);
            buttonWhat_GSO.TabIndex = 5;
            toolTip1.SetToolTip(buttonWhat_GSO, "Сведенья о программе");
            buttonWhat_GSO.UseVisualStyleBackColor = true;
            buttonWhat_GSO.Click += buttonWhat_GSO_Click;
            // 
            // openFileDialogTask_GSO
            // 
            openFileDialogTask_GSO.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1130, 550);
            Controls.Add(buttonWhat_GSO);
            Controls.Add(buttonDo_GSO);
            Controls.Add(buttonOpenFile_GSO);
            Controls.Add(groupBoxCondition_GSO);
            Controls.Add(groupBoxOutput_GSO);
            Controls.Add(groupBoxInput_GSO);
            Name = "FormMain";
            Text = "Form1";
            groupBoxInput_GSO.ResumeLayout(false);
            groupBoxInput_GSO.PerformLayout();
            groupBoxOutput_GSO.ResumeLayout(false);
            groupBoxOutput_GSO.PerformLayout();
            groupBoxCondition_GSO.ResumeLayout(false);
            groupBoxCondition_GSO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInput_GSO;
        private TextBox textBoxInput_GSO;
        private GroupBox groupBoxOutput_GSO;
        private TextBox textBoxOutput_GSO;
        private GroupBox groupBoxCondition_GSO;
        private TextBox textBoxCondition_GSO;
        private Button buttonOpenFile_GSO;
        private Button buttonDo_GSO;
        private Button buttonWhat_GSO;
        private OpenFileDialog openFileDialogTask_GSO;
        private ToolTip toolTip1;
    }
}
