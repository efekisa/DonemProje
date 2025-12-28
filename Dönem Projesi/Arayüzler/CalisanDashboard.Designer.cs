namespace Dönem_Projesi
{
    partial class CalisanDashboard
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
            panel1 = new Panel();
            label4 = new Label();
            button5 = new Button();
            panel3 = new Panel();
            listBox2 = new ListBox();
            panel2 = new Panel();
            listBox1 = new ListBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_10_19_at_21_28_28;
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 585);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(587, 38);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Silver;
            button5.Location = new Point(3, 408);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(229, 63);
            button5.TabIndex = 13;
            button5.Text = "Çıkış Yap";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(393, 284);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 199);
            panel3.TabIndex = 12;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(561, 284);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 184);
            listBox2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(397, 165);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 95);
            panel2.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(164, 0);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 64);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(274, 95);
            label2.TabIndex = 0;
            label2.Text = "Aktif Kullanıcı Sayısı";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 105);
            label1.TabIndex = 4;
            label1.Text = "Çalışan Panel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(3, 188);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(229, 99);
            button2.TabIndex = 1;
            button2.Text = "Kupon Tanımla/ İptal et";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(3, 85);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(229, 95);
            button1.TabIndex = 0;
            button1.Text = "Stok Durumu Görüntüle / Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Location = new Point(0, 295);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(229, 105);
            button4.TabIndex = 3;
            button4.Text = "İzin haklarım / Talep et";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(278, 199);
            label3.TabIndex = 0;
            label3.Text = "Stoğu Azalanlar";
            // 
            // CalisanDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 585);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CalisanDashboard";
            Text = "CalisanDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button button4;
        private Panel panel2;
        private ListBox listBox1;
        private Label label2;
        private Panel panel3;
        private ListBox listBox2;
        private Button button5;
        private Label label4;
        private Label label3;
    }
}