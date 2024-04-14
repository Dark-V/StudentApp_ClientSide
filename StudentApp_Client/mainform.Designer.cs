namespace StudentApp_Client
{
    partial class mainform
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            inputAmp = new Button();
            gradesForm = new Button();
            amp = new Button();
            grades = new Button();
            about = new Button();
            auth = new Button();
            outputs = new Button();
            logout = new Button();
            perm = new Button();
            reg = new Button();
            inputGrades = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            status_bar_part2 = new Label();
            status_bar_part1 = new Label();
            help_icon = new PictureBox();
            helpProvider1 = new HelpProvider();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)help_icon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(inputAmp);
            panel1.Controls.Add(gradesForm);
            panel1.Controls.Add(amp);
            panel1.Controls.Add(grades);
            panel1.Controls.Add(about);
            panel1.Controls.Add(auth);
            panel1.Controls.Add(outputs);
            panel1.Controls.Add(logout);
            panel1.Controls.Add(perm);
            panel1.Controls.Add(reg);
            panel1.Controls.Add(inputGrades);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 599);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 424);
            label2.Name = "label2";
            label2.Size = new Size(153, 20);
            label2.TabIndex = 3;
            label2.Text = "Для администрации:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 332);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 2;
            label1.Text = "Для учителей:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images__1_1;
            pictureBox1.Location = new Point(5, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 140);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // inputAmp
            // 
            inputAmp.Enabled = false;
            inputAmp.Location = new Point(5, 390);
            inputAmp.Name = "inputAmp";
            inputAmp.Size = new Size(185, 30);
            inputAmp.TabIndex = 0;
            inputAmp.Text = "Ввод посещаемости ";
            inputAmp.UseVisualStyleBackColor = true;
            inputAmp.Click += inputAmp_Click;
            // 
            // gradesForm
            // 
            gradesForm.Enabled = false;
            gradesForm.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            gradesForm.Location = new Point(5, 298);
            gradesForm.Name = "gradesForm";
            gradesForm.Size = new Size(185, 30);
            gradesForm.TabIndex = 0;
            gradesForm.Text = "Отчетность успеваемости";
            gradesForm.UseVisualStyleBackColor = true;
            gradesForm.Click += gradesForm_Click;
            // 
            // amp
            // 
            amp.Enabled = false;
            amp.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            amp.Location = new Point(5, 263);
            amp.Name = "amp";
            amp.Size = new Size(185, 30);
            amp.TabIndex = 0;
            amp.Text = "Просмотр посещаемости";
            amp.UseVisualStyleBackColor = true;
            amp.Click += amp_Click;
            // 
            // grades
            // 
            grades.Enabled = false;
            grades.Location = new Point(5, 228);
            grades.Name = "grades";
            grades.Size = new Size(185, 30);
            grades.TabIndex = 0;
            grades.Text = "Просмотр моих оценок";
            grades.UseVisualStyleBackColor = true;
            grades.Click += grades_Click;
            // 
            // about
            // 
            about.Enabled = false;
            about.Location = new Point(5, 193);
            about.Name = "about";
            about.Size = new Size(185, 30);
            about.TabIndex = 0;
            about.Text = "Об пользователе";
            about.UseVisualStyleBackColor = true;
            about.Click += about_Click;
            // 
            // auth
            // 
            auth.Location = new Point(5, 158);
            auth.Name = "auth";
            auth.Size = new Size(185, 30);
            auth.TabIndex = 0;
            auth.Text = "Авторизация";
            auth.UseVisualStyleBackColor = true;
            auth.Click += button1_Click;
            // 
            // outputs
            // 
            outputs.Enabled = false;
            outputs.Location = new Point(5, 531);
            outputs.Name = "outputs";
            outputs.Size = new Size(185, 30);
            outputs.TabIndex = 0;
            outputs.Text = "Отчеты";
            outputs.UseVisualStyleBackColor = true;
            outputs.Click += sql_Click;
            // 
            // logout
            // 
            logout.Enabled = false;
            logout.Location = new Point(6, 566);
            logout.Name = "logout";
            logout.Size = new Size(185, 30);
            logout.TabIndex = 0;
            logout.Text = "Выход";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // perm
            // 
            perm.Enabled = false;
            perm.Location = new Point(6, 482);
            perm.Name = "perm";
            perm.Size = new Size(185, 30);
            perm.TabIndex = 0;
            perm.Text = "Выдача прав";
            perm.UseVisualStyleBackColor = true;
            perm.Click += perm_Click;
            // 
            // reg
            // 
            reg.Enabled = false;
            reg.Location = new Point(6, 447);
            reg.Name = "reg";
            reg.Size = new Size(185, 30);
            reg.TabIndex = 0;
            reg.Text = "Регистрация студентов";
            reg.UseVisualStyleBackColor = true;
            reg.Click += reg_Click;
            // 
            // inputGrades
            // 
            inputGrades.Enabled = false;
            inputGrades.Location = new Point(5, 355);
            inputGrades.Name = "inputGrades";
            inputGrades.Size = new Size(185, 30);
            inputGrades.TabIndex = 0;
            inputGrades.Text = "Ввод оценок";
            inputGrades.UseVisualStyleBackColor = true;
            inputGrades.Click += inputGrades_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(194, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 599);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(status_bar_part2);
            panel3.Controls.Add(status_bar_part1);
            panel3.Controls.Add(help_icon);
            panel3.Location = new Point(0, 605);
            panel3.Name = "panel3";
            panel3.Size = new Size(998, 28);
            panel3.TabIndex = 2;
            // 
            // status_bar_part2
            // 
            status_bar_part2.AutoSize = true;
            status_bar_part2.Location = new Point(777, 3);
            status_bar_part2.Name = "status_bar_part2";
            status_bar_part2.Size = new Size(212, 20);
            status_bar_part2.TabIndex = 2;
            status_bar_part2.Text = "Дата: ??.??.???? Версия: 0.0.0.0";
            // 
            // status_bar_part1
            // 
            status_bar_part1.AutoSize = true;
            status_bar_part1.Location = new Point(28, 3);
            status_bar_part1.Name = "status_bar_part1";
            status_bar_part1.Size = new Size(368, 20);
            status_bar_part1.TabIndex = 1;
            status_bar_part1.Text = "Вход: НЕИЗВЕСТНО. Пользователь: НЕ ОБНАРУЖЕН";
            // 
            // help_icon
            // 
            help_icon.Image = Properties.Resources.question_icon;
            help_icon.Location = new Point(6, 5);
            help_icon.Name = "help_icon";
            help_icon.Size = new Size(16, 16);
            help_icon.TabIndex = 0;
            help_icon.TabStop = false;
            help_icon.Click += help_icon_click;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "C:\\Users\\DarkV\\Desktop\\test\\1.chm";
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 638);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "mainform";
            ShowIcon = false;
            Text = "Student Helper+";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)help_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button inputGrades;
        private Button inputAmp;
        private Button gradesForm;
        private Button amp;
        private Button grades;
        private Button auth;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button perm;
        private Button reg;
        private Button logout;
        private Button about;
        private Button outputs;
        private Panel panel3;
        private PictureBox help_icon;
        public Label status_bar_part1;
        public Label status_bar_part2;
        private HelpProvider helpProvider1;
    }
}
