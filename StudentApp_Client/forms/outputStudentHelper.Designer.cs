﻿namespace StudentApp_Client.forms
{
    partial class outputStudentHelper
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
            studentsBox = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // studentsBox
            // 
            studentsBox.FormattingEnabled = true;
            studentsBox.Location = new Point(123, 18);
            studentsBox.Name = "studentsBox";
            studentsBox.Size = new Size(192, 28);
            studentsBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(4, 82);
            button1.Name = "button1";
            button1.Size = new Size(311, 29);
            button1.TabIndex = 1;
            button1.Text = "Выбрать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 2;
            label1.Text = "ФИО студента";
            // 
            // outputStudentHelper
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 128);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(studentsBox);
            MaximizeBox = false;
            MaximumSize = new Size(345, 175);
            MinimizeBox = false;
            MinimumSize = new Size(345, 175);
            Name = "outputStudentHelper";
            Text = "Выбор";
            FormClosed += outputStudentHelper_FormClosed;
            Load += outputStudentHelper_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox studentsBox;
        private Button button1;
        private Label label1;
    }
}