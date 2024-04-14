namespace StudentApp_Client.forms
{
    partial class outputs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePickerTO = new DateTimePicker();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox = new ComboBox();
            formatBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            dateTimePickerFROM = new DateTimePicker();
            groupBox2 = new GroupBox();
            button1 = new Button();
            reportGrid = new DataGridView();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            button2 = new Button();
            printDialog1 = new System.Drawing.Printing.PrintDocument();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reportGrid).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerTO
            // 
            dateTimePickerTO.Location = new Point(46, 61);
            dateTimePickerTO.Name = "dateTimePickerTO";
            dateTimePickerTO.Size = new Size(250, 27);
            dateTimePickerTO.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 67);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 3;
            label3.Text = "До:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox);
            groupBox1.Controls.Add(formatBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(336, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 99);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип отчета";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox
            // 
            groupBox.FormattingEnabled = true;
            groupBox.Location = new Point(79, 28);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(151, 28);
            groupBox.TabIndex = 0;
            // 
            // formatBox
            // 
            formatBox.DropDownStyle = ComboBoxStyle.DropDownList;
            formatBox.FormattingEnabled = true;
            formatBox.Items.AddRange(new object[] { "..." });
            formatBox.Location = new Point(79, 62);
            formatBox.Name = "formatBox";
            formatBox.Size = new Size(151, 28);
            formatBox.TabIndex = 0;
            formatBox.SelectedIndexChanged += formatBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 31);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 1;
            label4.Text = "Группа:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 67);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 1;
            label5.Text = "Формат:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 34);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 6;
            label1.Text = "От:";
            // 
            // dateTimePickerFROM
            // 
            dateTimePickerFROM.Location = new Point(46, 28);
            dateTimePickerFROM.Name = "dateTimePickerFROM";
            dateTimePickerFROM.Size = new Size(250, 27);
            dateTimePickerFROM.TabIndex = 5;
            dateTimePickerFROM.Value = new DateTime(2023, 4, 7, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePickerTO);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePickerFROM);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 99);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Временной промежуток";
            // 
            // button1
            // 
            button1.Location = new Point(724, 35);
            button1.Name = "button1";
            button1.Size = new Size(64, 64);
            button1.TabIndex = 8;
            button1.Text = "🖨️";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // reportGrid
            // 
            reportGrid.AllowUserToAddRows = false;
            reportGrid.AllowUserToDeleteRows = false;
            reportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportGrid.Location = new Point(12, 117);
            reportGrid.Name = "reportGrid";
            reportGrid.RowHeadersWidth = 51;
            reportGrid.Size = new Size(776, 228);
            reportGrid.TabIndex = 9;
            reportGrid.CellContentClick += reportGrid_CellContentClick;
            reportGrid.ColumnHeaderMouseClick += reportGrid_ColumnHeaderMouseClick;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(12, 355);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(776, 241);
            formsPlot1.TabIndex = 10;
            formsPlot1.MouseUp += formsPlot1_MClick;
            // 
            // button2
            // 
            button2.Location = new Point(581, 36);
            button2.Name = "button2";
            button2.Size = new Size(137, 64);
            button2.TabIndex = 8;
            button2.Text = "Сформировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // outputs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 604);
            Controls.Add(formsPlot1);
            Controls.Add(reportGrid);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "outputs";
            Text = "Отчеты";
            Load += outputs_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reportGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePickerTO;
        private Label label3;
        private GroupBox groupBox1;
        private ComboBox groupBox;
        public ComboBox formatBox;
        private Label label4;
        private Label label5;
        private Label label1;
        private DateTimePicker dateTimePickerFROM;
        private GroupBox groupBox2;
        public Button button1;
        private DataGridView reportGrid;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        public Button button2;
        private System.Drawing.Printing.PrintDocument printDialog1;
    }
}