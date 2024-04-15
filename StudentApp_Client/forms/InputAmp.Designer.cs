namespace StudentApp_Client.forms
{
    partial class InputAmp
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            studentsBox = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            statusBox = new ComboBox();
            label2 = new Label();
            button2 = new Button();
            label5 = new Label();
            groupBox = new ComboBox();
            dateBox = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(344, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(438, 430);
            dataGridView1.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(22, 394);
            button1.Name = "button1";
            button1.Size = new Size(316, 29);
            button1.TabIndex = 17;
            button1.Text = "Внести посещаемость";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 250);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 11;
            label3.Text = "Дата:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 317);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 12;
            label1.Text = "Студент:";
            // 
            // studentsBox
            // 
            studentsBox.FormattingEnabled = true;
            studentsBox.Location = new Point(93, 314);
            studentsBox.Name = "studentsBox";
            studentsBox.Size = new Size(245, 28);
            studentsBox.TabIndex = 9;
            studentsBox.SelectedIndexChanged += studentsBox_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(22, 28);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // statusBox
            // 
            statusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusBox.FormattingEnabled = true;
            statusBox.Items.AddRange(new object[] { "Уважительная причина", "Присутствовал", "Отсутствовал", "Болел" });
            statusBox.Location = new Point(93, 348);
            statusBox.Name = "statusBox";
            statusBox.Size = new Size(245, 28);
            statusBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 348);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 12;
            label2.Text = "Статус:";
            // 
            // button2
            // 
            button2.Location = new Point(22, 429);
            button2.Name = "button2";
            button2.Size = new Size(316, 29);
            button2.TabIndex = 19;
            button2.Text = "Удалить посещаемость";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 283);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 21;
            label5.Text = "Группа:";
            // 
            // groupBox
            // 
            groupBox.FormattingEnabled = true;
            groupBox.Location = new Point(93, 280);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(245, 28);
            groupBox.TabIndex = 20;
            groupBox.SelectedIndexChanged += groupBox_SelectedIndexChanged;
            // 
            // dateBox
            // 
            dateBox.Location = new Point(90, 247);
            dateBox.Mask = "00/00/0000";
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(248, 27);
            dateBox.TabIndex = 22;
            dateBox.ValidatingType = typeof(DateTime);
            dateBox.Validating += dateBox_Validating;
            // 
            // InputAmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(dateBox);
            Controls.Add(label5);
            Controls.Add(groupBox);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(statusBox);
            Controls.Add(studentsBox);
            Controls.Add(monthCalendar1);
            Name = "InputAmp";
            Text = "InputAmp";
            Load += InputAmp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label3;
        private Label label1;
        private ComboBox studentsBox;
        private MonthCalendar monthCalendar1;
        private ComboBox statusBox;
        private Label label2;
        private Button button2;
        private Label label5;
        private ComboBox groupBox;
        private MaskedTextBox dateBox;
    }
}