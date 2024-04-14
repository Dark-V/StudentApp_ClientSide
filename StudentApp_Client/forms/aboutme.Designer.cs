namespace StudentApp_Client.forms
{
    partial class aboutme
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            dep = new Label();
            name = new Label();
            speciality = new Label();
            group = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            role = new Label();
            pictureBox1 = new PictureBox();
            status = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 468);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(dep);
            panel3.Controls.Add(name);
            panel3.Controls.Add(speciality);
            panel3.Controls.Add(group);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 182);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 262);
            panel3.TabIndex = 2;
            // 
            // dep
            // 
            dep.AutoSize = true;
            dep.Font = new Font("Times New Roman", 12F);
            dep.ImageAlign = ContentAlignment.BottomRight;
            dep.Location = new Point(3, 76);
            dep.Name = "dep";
            dep.Size = new Size(148, 22);
            dep.TabIndex = 0;
            dep.Text = "Направление: ...";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Times New Roman", 12F);
            name.Location = new Point(3, 10);
            name.Name = "name";
            name.Size = new Size(126, 22);
            name.TabIndex = 0;
            name.Text = "Инициалы: ...";
            // 
            // speciality
            // 
            speciality.AutoSize = true;
            speciality.Font = new Font("Times New Roman", 12F);
            speciality.Location = new Point(3, 54);
            speciality.Name = "speciality";
            speciality.Size = new Size(167, 22);
            speciality.TabIndex = 0;
            speciality.Text = "Специальность: ...";
            // 
            // group
            // 
            group.AutoSize = true;
            group.Font = new Font("Times New Roman", 12F);
            group.Location = new Point(3, 32);
            group.Name = "group";
            group.Size = new Size(97, 22);
            group.TabIndex = 0;
            group.Text = "Группа: ...";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(643, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(154, 262);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(role);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(status);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(643, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(154, 173);
            panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 135);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // role
            // 
            role.AutoSize = true;
            role.Location = new Point(0, 145);
            role.Name = "role";
            role.Size = new Size(68, 20);
            role.TabIndex = 4;
            role.Text = "Статус: ...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.student;
            pictureBox1.Location = new Point(255, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 135);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Location = new Point(255, 144);
            status.Name = "status";
            status.Size = new Size(68, 20);
            status.TabIndex = 2;
            status.Text = "Статус: ...";
            // 
            // aboutme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "aboutme";
            Text = "aboutme";
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Label dep;
        private Label group;
        private Label speciality;
        private Label name;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label status;
        private PictureBox pictureBox2;
        private Label role;
    }
}