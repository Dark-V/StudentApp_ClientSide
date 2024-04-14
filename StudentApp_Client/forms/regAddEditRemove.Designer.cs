namespace StudentApp_Client.forms
{
    partial class regAddEditRemove
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            groupBox = new ComboBox();
            label2 = new Label();
            specialityBox = new ComboBox();
            label3 = new Label();
            departmentBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            genderBox = new ComboBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            FamilyBox = new TextBox();
            nameBox = new TextBox();
            secondNameBox = new TextBox();
            groupBox2 = new GroupBox();
            toolTip1 = new ToolTip(components);
            groupBox3 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.user_noimage;
            pictureBox1.Image = Properties.Resources.user_noimage;
            pictureBox1.InitialImage = Properties.Resources.user_noimage;
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 250);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 378);
            button1.Name = "button1";
            button1.Size = new Size(608, 29);
            button1.TabIndex = 1;
            button1.Text = "error";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 3;
            label1.Text = "Номер группы";
            // 
            // groupBox
            // 
            groupBox.DropDownStyle = ComboBoxStyle.DropDownList;
            groupBox.FormattingEnabled = true;
            groupBox.Location = new Point(132, 34);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(261, 28);
            groupBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 71);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Специальность";
            // 
            // specialityBox
            // 
            specialityBox.DropDownStyle = ComboBoxStyle.DropDownList;
            specialityBox.FormattingEnabled = true;
            specialityBox.Location = new Point(132, 68);
            specialityBox.Name = "specialityBox";
            specialityBox.Size = new Size(261, 28);
            specialityBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 105);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 3;
            label3.Text = "Отделение";
            // 
            // departmentBox
            // 
            departmentBox.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentBox.FormattingEnabled = true;
            departmentBox.Location = new Point(132, 102);
            departmentBox.Name = "departmentBox";
            departmentBox.Size = new Size(261, 28);
            departmentBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 29);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Фамилия";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 62);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 3;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 97);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 3;
            label6.Text = "Отечество";
            // 
            // genderBox
            // 
            genderBox.FormattingEnabled = true;
            genderBox.Items.AddRange(new object[] { "мужской", "женский" });
            genderBox.Location = new Point(100, 127);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(293, 28);
            genderBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 130);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 5;
            label7.Text = "Пол";
            label7.Click += label7_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(departmentBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(specialityBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(218, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 151);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные об группе";
            // 
            // FamilyBox
            // 
            FamilyBox.Location = new Point(100, 26);
            FamilyBox.Name = "FamilyBox";
            FamilyBox.Size = new Size(293, 27);
            FamilyBox.TabIndex = 9;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(100, 60);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(293, 27);
            nameBox.TabIndex = 10;
            // 
            // secondNameBox
            // 
            secondNameBox.Location = new Point(100, 94);
            secondNameBox.Name = "secondNameBox";
            secondNameBox.Size = new Size(293, 27);
            secondNameBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(FamilyBox);
            groupBox2.Controls.Add(secondNameBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nameBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(genderBox);
            groupBox2.Location = new Point(218, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 178);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Данные об студенте";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Location = new Point(12, 279);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 93);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Данные авторизации";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 62);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 12;
            label9.Text = "Пароль";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 29);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 12;
            label8.Text = "Логин";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(74, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(74, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 27);
            textBox1.TabIndex = 9;
            // 
            // regAddEditRemove
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 415);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(650, 462);
            MinimizeBox = false;
            MinimumSize = new Size(650, 462);
            Name = "regAddEditRemove";
            Text = "Информация об студенте";
            Load += regAddEditRemove_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private ComboBox groupBox;
        private Label label2;
        private ComboBox specialityBox;
        private Label label3;
        private ComboBox departmentBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox genderBox;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox FamilyBox;
        private TextBox nameBox;
        private TextBox secondNameBox;
        private GroupBox groupBox2;
        private ToolTip toolTip1;
        private GroupBox groupBox3;
        private Label label9;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}