namespace Dönem_Projesi
{
    partial class PersonelSorgula
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
            button3 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            listBox3 = new ListBox();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(240, 216);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(103, 31);
            button3.TabIndex = 41;
            button3.Text = "Vazgeç";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(50, 216);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(103, 31);
            button4.TabIndex = 40;
            button4.Text = "Sorgula";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(226, 135);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(131, 27);
            textBox6.TabIndex = 37;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 145);
            label9.Name = "label9";
            label9.Size = new Size(142, 20);
            label9.TabIndex = 36;
            label9.Text = "Personel Numarası : ";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(50, 44);
            label8.Name = "label8";
            label8.Size = new Size(307, 56);
            label8.TabIndex = 35;
            label8.Text = "Personel Sorgula";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(565, 48);
            label1.Name = "label1";
            label1.Size = new Size(246, 48);
            label1.TabIndex = 42;
            label1.Text = "... Kişinin Bilgileri";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(listBox3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(509, 135);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 99);
            panel2.TabIndex = 45;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(138, 0);
            listBox3.Margin = new Padding(3, 4, 3, 4);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(227, 104);
            listBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(365, 99);
            label4.TabIndex = 0;
            label4.Text = "Kalan İzin Hakkı";
            // 
            // PersonelSorgula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 595);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(label8);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PersonelSorgula";
            Text = "PersonelSorgula";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button4;
        private TextBox textBox6;
        private Label label9;
        private Label label8;
        private Label label1;
        private Panel panel2;
        private ListBox listBox3;
        private Label label4;
    }
}