
namespace Dönem_Projesi
{
    partial class IzinTalep
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
            button4 = new Button();
            textBox6 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            button1 = new Button();
            listBox2 = new ListBox();
            panel3 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(243, 236);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 45;
            button4.Text = "Talep Gönder";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(243, 197);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(115, 23);
            textBox6.TabIndex = 44;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 205);
            label9.Name = "label9";
            label9.Size = new Size(145, 15);
            label9.TabIndex = 43;
            label9.Text = "Kaç gün izin istiyorsunuz ?";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(347, 42);
            label8.TabIndex = 42;
            label8.Text = "İzin Talep";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(178, 3);
            button1.Name = "button1";
            button1.Size = new Size(168, 68);
            button1.TabIndex = 48;
            button1.Text = "Kalan Hakkı Görüntüle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(0, 0);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(172, 79);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(listBox2);
            panel3.Location = new Point(12, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 74);
            panel3.TabIndex = 47;
            // 
            // IzinTalep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_10_19_at_21_28_28;
            ClientSize = new Size(370, 315);
            Controls.Add(panel3);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(label8);
            Name = "IzinTalep";
            Text = "IzinTalep";
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Button button4;
        private TextBox textBox6;
        private Label label9;
        private Label label8;
        private Button button1;
        private ListBox listBox2;
        private Panel panel3;
    }
}