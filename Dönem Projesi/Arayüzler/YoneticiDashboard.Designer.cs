namespace Dönem_Projesi
{
    partial class YoneticiDashboard
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
            panel1 = new Panel();
            button5 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            listBox1 = new ListBox();
            label2 = new Label();
            panel3 = new Panel();
            listBox2 = new ListBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(-4, 117);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(233, 95);
            button1.TabIndex = 0;
            button1.Text = "Ürün Ekle / Çıkar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(-4, 306);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(229, 99);
            button2.TabIndex = 1;
            button2.Text = "Personel Sorgula";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Location = new Point(-3, 204);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(229, 103);
            button3.TabIndex = 2;
            button3.Text = "Personel Ekle / Çıkar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 539);
            panel1.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.Silver;
            button5.Location = new Point(-4, 403);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(229, 69);
            button5.TabIndex = 14;
            button5.Text = "Çıkış Yap";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 1);
            label1.Name = "label1";
            label1.Size = new Size(225, 113);
            label1.TabIndex = 4;
            label1.Text = "Yönetici Panel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(314, 126);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 95);
            panel2.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(123, 0);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(122, 104);
            listBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(222, 95);
            label2.TabIndex = 0;
            label2.Text = "Kullanıcı Sayısı";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(listBox2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(314, 284);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 99);
            panel3.TabIndex = 7;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(123, 0);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(122, 104);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(222, 99);
            label3.TabIndex = 0;
            label3.Text = "Kayıtlı Ürün Sayısı";
            // 
            // YoneticiDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_10_19_at_21_28_28;
            ClientSize = new Size(914, 539);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YoneticiDashboard";
            Text = "YoneticiDashboard";
            Load += YoneticiDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ListBox listBox1;
        private Panel panel3;
        private ListBox listBox2;
        private Label label3;
        private Button button5;
    }
}