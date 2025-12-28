namespace Dönem_Projesi
{
    partial class StokDurum
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
            textBox5 = new TextBox();
            label8 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(169, 105);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 113);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 17;
            label8.Text = "Ürün Kodu : ";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(61, 27);
            label5.Name = "label5";
            label5.Size = new Size(460, 42);
            label5.TabIndex = 16;
            label5.Text = "Stok Durum Görüntüleme / Güncelleme";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(66, 155);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 94);
            listBox1.TabIndex = 19;
            listBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(340, 113);
            label1.Name = "label1";
            label1.Size = new Size(181, 23);
            label1.TabIndex = 20;
            label1.Text = "Güncel Ürün Miktarını Giriniz";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(340, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(446, 228);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Vazgeç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(66, 274);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 24;
            button3.Text = "Listele";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // StokDurum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_10_19_at_21_28_28;
            ClientSize = new Size(594, 374);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label5);
            Name = "StokDurum";
            Text = "StokDurum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private Label label8;
        private Label label5;
        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}