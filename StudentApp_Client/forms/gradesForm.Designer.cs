namespace StudentApp_Client.forms
{
    partial class gradesForm
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
            panel2 = new Panel();
            rating = new Label();
            panel3 = new Panel();
            total = new Label();
            pristv = new Label();
            prop = new Label();
            megaill = new Label();
            ill = new Label();
            panel1 = new Panel();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(800, 321);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(rating);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(535, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 122);
            panel2.TabIndex = 2;
            // 
            // rating
            // 
            rating.AutoSize = true;
            rating.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            rating.Location = new Point(0, 74);
            rating.Name = "rating";
            rating.Size = new Size(201, 41);
            rating.TabIndex = 1;
            rating.Text = "Рейтинг: ...";
            rating.Click += rating_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(total);
            panel3.Controls.Add(pristv);
            panel3.Controls.Add(prop);
            panel3.Controls.Add(megaill);
            panel3.Controls.Add(ill);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 187);
            panel3.TabIndex = 3;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Times New Roman", 12F);
            total.ImageAlign = ContentAlignment.BottomRight;
            total.Location = new Point(0, 96);
            total.Name = "total";
            total.Size = new Size(85, 22);
            total.TabIndex = 1;
            total.Text = "Всего: ...";
            // 
            // pristv
            // 
            pristv.AutoSize = true;
            pristv.Font = new Font("Times New Roman", 12F);
            pristv.Location = new Point(0, 8);
            pristv.Name = "pristv";
            pristv.Size = new Size(163, 22);
            pristv.TabIndex = 2;
            pristv.Text = "Присутствовал: ...";
            // 
            // prop
            // 
            prop.AutoSize = true;
            prop.Font = new Font("Times New Roman", 12F);
            prop.Location = new Point(0, 30);
            prop.Name = "prop";
            prop.Size = new Size(228, 22);
            prop.TabIndex = 2;
            prop.Text = "Количество пропусков: ...";
            // 
            // megaill
            // 
            megaill.AutoSize = true;
            megaill.Font = new Font("Times New Roman", 12F);
            megaill.Location = new Point(0, 74);
            megaill.Name = "megaill";
            megaill.Size = new Size(235, 22);
            megaill.TabIndex = 3;
            megaill.Text = "Уважительная причина: ...";
            // 
            // ill
            // 
            ill.AutoSize = true;
            ill.Font = new Font("Times New Roman", 12F);
            ill.Location = new Point(0, 52);
            ill.Name = "ill";
            ill.Size = new Size(86, 22);
            ill.TabIndex = 4;
            ill.Text = "Болел: ...";
            // 
            // panel1
            // 
            panel1.Controls.Add(formsPlot1);
            panel1.Location = new Point(3, 328);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 236);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(0, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(778, 236);
            formsPlot1.TabIndex = 0;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // gradesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 576);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "gradesForm";
            Text = "gradesForm";
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label rating;
        private Panel panel3;
        private Label total;
        private Label prop;
        private Label megaill;
        private Label ill;
        private Label pristv;
        private Panel panel1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}