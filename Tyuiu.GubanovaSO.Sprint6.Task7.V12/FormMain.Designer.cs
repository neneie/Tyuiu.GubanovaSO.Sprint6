namespace Tyuiu.GubanovaSO.Sprint6.Task7.V12
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
            label1 = new Label();
            groupBoxButton_GSO = new GroupBox();
            buttonSave_GSO = new Button();
            buttonDo_GSO = new Button();
            buttonWhat_GSO = new Button();
            buttonOpenFile_GSO = new Button();
            groupBoxCondition_GSO = new GroupBox();
            groupBox1 = new GroupBox();
            DataGridViewOutPut_GSO = new DataGridView();
            DataGridViewInPut_GSO = new DataGridView();
            saveFileDialog_GSO = new OpenFileDialog();
            openFileDialog_GSO = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            groupBoxButton_GSO.SuspendLayout();
            groupBoxCondition_GSO.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewOutPut_GSO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInPut_GSO).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(772, 60);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // groupBoxButton_GSO
            // 
            groupBoxButton_GSO.Controls.Add(buttonSave_GSO);
            groupBoxButton_GSO.Controls.Add(buttonDo_GSO);
            groupBoxButton_GSO.Controls.Add(buttonWhat_GSO);
            groupBoxButton_GSO.Controls.Add(buttonOpenFile_GSO);
            groupBoxButton_GSO.Location = new Point(12, 12);
            groupBoxButton_GSO.Name = "groupBoxButton_GSO";
            groupBoxButton_GSO.Size = new Size(1390, 92);
            groupBoxButton_GSO.TabIndex = 7;
            groupBoxButton_GSO.TabStop = false;
            // 
            // buttonSave_GSO
            // 
            buttonSave_GSO.BackgroundImage = Properties.Resources.tick;
            buttonSave_GSO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSave_GSO.Location = new Point(215, 14);
            buttonSave_GSO.Name = "buttonSave_GSO";
            buttonSave_GSO.Size = new Size(93, 75);
            buttonSave_GSO.TabIndex = 6;
            buttonSave_GSO.UseVisualStyleBackColor = true;
            // 
            // buttonDo_GSO
            // 
            buttonDo_GSO.BackgroundImage = Properties.Resources.page_go;
            buttonDo_GSO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDo_GSO.Location = new Point(116, 14);
            buttonDo_GSO.Name = "buttonDo_GSO";
            buttonDo_GSO.Size = new Size(93, 75);
            buttonDo_GSO.TabIndex = 4;
            buttonDo_GSO.UseVisualStyleBackColor = true;
            buttonDo_GSO.Click += buttonDo_GSO_Click;
            // 
            // buttonWhat_GSO
            // 
            buttonWhat_GSO.BackgroundImage = Properties.Resources.zoom;
            buttonWhat_GSO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonWhat_GSO.Location = new Point(1291, 14);
            buttonWhat_GSO.Name = "buttonWhat_GSO";
            buttonWhat_GSO.Size = new Size(93, 75);
            buttonWhat_GSO.TabIndex = 5;
            buttonWhat_GSO.UseVisualStyleBackColor = true;
            buttonWhat_GSO.Click += buttonWhat_GSO_Click;
            // 
            // buttonOpenFile_GSO
            // 
            buttonOpenFile_GSO.BackgroundImage = Properties.Resources.folder_explore;
            buttonOpenFile_GSO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_GSO.Location = new Point(0, 14);
            buttonOpenFile_GSO.Name = "buttonOpenFile_GSO";
            buttonOpenFile_GSO.Size = new Size(94, 75);
            buttonOpenFile_GSO.TabIndex = 3;
            buttonOpenFile_GSO.UseVisualStyleBackColor = true;
            buttonOpenFile_GSO.Click += buttonOpenFile_GSO_Click;
            // 
            // groupBoxCondition_GSO
            // 
            groupBoxCondition_GSO.Controls.Add(label1);
            groupBoxCondition_GSO.Location = new Point(12, 110);
            groupBoxCondition_GSO.Name = "groupBoxCondition_GSO";
            groupBoxCondition_GSO.Size = new Size(1390, 83);
            groupBoxCondition_GSO.TabIndex = 8;
            groupBoxCondition_GSO.TabStop = false;
            groupBoxCondition_GSO.Text = "Условие";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DataGridViewOutPut_GSO);
            groupBox1.Controls.Add(DataGridViewInPut_GSO);
            groupBox1.Location = new Point(12, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1396, 419);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // DataGridViewOutPut_GSO
            // 
            DataGridViewOutPut_GSO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewOutPut_GSO.Location = new Point(717, 26);
            DataGridViewOutPut_GSO.Name = "DataGridViewOutPut_GSO";
            DataGridViewOutPut_GSO.RowHeadersWidth = 51;
            DataGridViewOutPut_GSO.Size = new Size(673, 387);
            DataGridViewOutPut_GSO.TabIndex = 1;
            // 
            // DataGridViewInPut_GSO
            // 
            DataGridViewInPut_GSO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewInPut_GSO.Location = new Point(6, 26);
            DataGridViewInPut_GSO.Name = "DataGridViewInPut_GSO";
            DataGridViewInPut_GSO.RowHeadersWidth = 51;
            DataGridViewInPut_GSO.Size = new Size(705, 387);
            DataGridViewInPut_GSO.TabIndex = 0;
            // 
            // saveFileDialog_GSO
            // 
            saveFileDialog_GSO.FileName = "openFileDialog1";
            // 
            // openFileDialog_GSO
            // 
            openFileDialog_GSO.FileName = "openFileDialog1";
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
            ClientSize = new Size(1420, 630);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxCondition_GSO);
            Controls.Add(groupBoxButton_GSO);
            Name = "FormMain";
            Text = "Form1";
            groupBoxButton_GSO.ResumeLayout(false);
            groupBoxCondition_GSO.ResumeLayout(false);
            groupBoxCondition_GSO.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewOutPut_GSO).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewInPut_GSO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBoxButton_GSO;
        private Button buttonDo_GSO;
        private Button buttonWhat_GSO;
        private Button buttonOpenFile_GSO;
        private GroupBox groupBoxCondition_GSO;
        private GroupBox groupBox1;
        private DataGridView DataGridViewOutPut_GSO;
        private DataGridView DataGridViewInPut_GSO;
        private OpenFileDialog saveFileDialog_GSO;
        private OpenFileDialog openFileDialog_GSO;
        private Button buttonSave_GSO;
        private ToolTip toolTip1;
    }
}
