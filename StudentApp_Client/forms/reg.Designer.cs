namespace StudentApp_Client.forms
{
    partial class reg
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            all_studentsGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)all_studentsGrid).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(539, 472);
            button1.Name = "button1";
            button1.Size = new Size(251, 29);
            button1.TabIndex = 3;
            button1.Text = "Добавить студента";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(284, 472);
            button2.Name = "button2";
            button2.Size = new Size(249, 29);
            button2.TabIndex = 4;
            button2.Text = "Редактировать студента";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(19, 472);
            button3.Name = "button3";
            button3.Size = new Size(259, 29);
            button3.TabIndex = 5;
            button3.Text = "Удалить студента";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // all_studentsGrid
            // 
            all_studentsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            all_studentsGrid.Location = new Point(19, 12);
            all_studentsGrid.Name = "all_studentsGrid";
            all_studentsGrid.RowHeadersWidth = 51;
            all_studentsGrid.Size = new Size(771, 454);
            all_studentsGrid.TabIndex = 6;
            all_studentsGrid.CellContentClick += all_studentsGrid_CellContentClick;
            // 
            // reg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(all_studentsGrid);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "reg";
            Text = "reg";
            ((System.ComponentModel.ISupportInitialize)all_studentsGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView all_studentsGrid;
    }
}