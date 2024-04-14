namespace StudentApp_Client.forms
{
    partial class inputGrades
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
            monthCalendar1 = new MonthCalendar();
            studentsBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dicp = new ComboBox();
            label3 = new Label();
            dateBox = new TextBox();
            label4 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            scoreBox = new ComboBox();
            label5 = new Label();
            groupBox = new ComboBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(8, 22);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // studentsBox
            // 
            studentsBox.FormattingEnabled = true;
            studentsBox.Location = new Point(83, 331);
            studentsBox.Name = "studentsBox";
            studentsBox.Size = new Size(182, 28);
            studentsBox.TabIndex = 1;
            studentsBox.SelectedIndexChanged += studentsBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 334);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Студент:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 267);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Дисциплина:";
            // 
            // dicp
            // 
            dicp.DropDownStyle = ComboBoxStyle.DropDownList;
            dicp.FormattingEnabled = true;
            dicp.Location = new Point(113, 264);
            dicp.Name = "dicp";
            dicp.Size = new Size(151, 28);
            dicp.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 237);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Дата:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // dateBox
            // 
            dateBox.Location = new Point(62, 234);
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(203, 27);
            dateBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 369);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 2;
            label4.Text = "Оценка:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // button1
            // 
            button1.Location = new Point(13, 399);
            button1.Name = "button1";
            button1.Size = new Size(253, 29);
            button1.TabIndex = 6;
            button1.Text = "Опубликовать оценку";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(283, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(488, 441);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // scoreBox
            // 
            scoreBox.DropDownStyle = ComboBoxStyle.DropDownList;
            scoreBox.FormattingEnabled = true;
            scoreBox.Items.AddRange(new object[] { "5 (отлично)", "4 (хорошо)", "3 (удовлетворительно)", "2 (не удовлетворительно)", "1 (плохо)", "0 (очень плохо)" });
            scoreBox.Location = new Point(114, 366);
            scoreBox.Name = "scoreBox";
            scoreBox.Size = new Size(151, 28);
            scoreBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 299);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 10;
            label5.Text = "Группа:";
            // 
            // groupBox
            // 
            groupBox.FormattingEnabled = true;
            groupBox.Location = new Point(84, 296);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(182, 28);
            groupBox.TabIndex = 9;
            groupBox.SelectedIndexChanged += groupBox_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(13, 434);
            button2.Name = "button2";
            button2.Size = new Size(253, 29);
            button2.TabIndex = 11;
            button2.Text = "Удалить оценку";
            button2.UseVisualStyleBackColor = true;
            // 
            // inputGrades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 477);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(groupBox);
            Controls.Add(scoreBox);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(dateBox);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(dicp);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(studentsBox);
            Controls.Add(monthCalendar1);
            Name = "inputGrades";
            Text = "inputGrades";
            Load += inputGrades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private ComboBox studentsBox;
        private Label label1;
        private Label label2;
        private ComboBox dicp;
        private Label label3;
        private TextBox dateBox;
        private Label label4;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox scoreBox;
        private Label label5;
        private ComboBox groupBox;
        private Button button2;
    }
}