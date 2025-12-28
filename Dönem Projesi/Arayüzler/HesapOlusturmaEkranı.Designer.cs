namespace Dönem_Projesi
{
    partial class HesapOlusturmaEkranı
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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            textBox6 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.CausesValidation = false;
            textBox1.Location = new Point(73, 64);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 21);
            textBox1.TabIndex = 0;
            textBox1.Text = "Ad";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(167, 109);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 21);
            textBox3.TabIndex = 2;
            textBox3.Text = "Kullanıcı Adı";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(167, 162);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 21);
            textBox4.TabIndex = 3;
            textBox4.Text = "Şifre";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.Location = new Point(167, 206);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(158, 21);
            textBox5.TabIndex = 4;
            textBox5.Text = "Şifre Tekrar";
            textBox5.TextAlign = HorizontalAlignment.Center;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(141, 273);
            button1.Name = "button1";
            button1.Size = new Size(224, 56);
            button1.TabIndex = 5;
            button1.Text = "Hesap Oluştur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.ForeColor = Color.Black;
            textBox6.Location = new Point(286, 64);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(158, 21);
            textBox6.TabIndex = 6;
            textBox6.Text = "Soyad";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 42);
            label1.TabIndex = 7;
            label1.Text = "Hesap Oluşturma ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(194, 335);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 8;
            button2.Text = "vazgeç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HesapOlusturmaEkranı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_10_19_at_21_28_28;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(518, 450);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "HesapOlusturmaEkranı";
            Text = "HesapOlusturmaEkranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private TextBox textBox6;
        private Label label1;
        private Button button2;
    }
}