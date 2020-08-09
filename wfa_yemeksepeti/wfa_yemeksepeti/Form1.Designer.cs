namespace wfa_yemeksepeti
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btniptal = new System.Windows.Forms.Button();
            this.btnözet = new System.Windows.Forms.Button();
            this.btnonay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltoplamtutar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "lütfen porsiyon giriniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "lütfen porsiyon giriniz:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lütfen bir yemek seçiniz:",
            "PİLAV",
            "KEBAP",
            "AKÇAABAT KÖFTE"});
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Lütfen bir yemek seçiniz:",
            "PİLAV",
            "KEBAP",
            "AKÇAABAT KÖFTE"});
            this.comboBox2.Location = new System.Drawing.Point(278, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(228, 24);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Btniptal
            // 
            this.Btniptal.BackColor = System.Drawing.Color.Red;
            this.Btniptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F);
            this.Btniptal.Location = new System.Drawing.Point(510, 60);
            this.Btniptal.Name = "Btniptal";
            this.Btniptal.Size = new System.Drawing.Size(278, 89);
            this.Btniptal.TabIndex = 8;
            this.Btniptal.Text = "SİPARİŞİ İPTAL ET :(";
            this.Btniptal.UseVisualStyleBackColor = false;
            this.Btniptal.Click += new System.EventHandler(this.Btniptal_Click);
            // 
            // btnözet
            // 
            this.btnözet.BackColor = System.Drawing.Color.Teal;
            this.btnözet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F);
            this.btnözet.Location = new System.Drawing.Point(425, 155);
            this.btnözet.Name = "btnözet";
            this.btnözet.Size = new System.Drawing.Size(182, 283);
            this.btnözet.TabIndex = 9;
            this.btnözet.Text = "SİPARİŞ ÖZETİ";
            this.btnözet.UseVisualStyleBackColor = false;
            this.btnözet.Click += new System.EventHandler(this.btnözet_Click);
            // 
            // btnonay
            // 
            this.btnonay.BackColor = System.Drawing.Color.ForestGreen;
            this.btnonay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F);
            this.btnonay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnonay.Location = new System.Drawing.Point(613, 152);
            this.btnonay.Name = "btnonay";
            this.btnonay.Size = new System.Drawing.Size(175, 286);
            this.btnonay.TabIndex = 10;
            this.btnonay.Text = "SİPARİŞİ ONAYLA :)";
            this.btnonay.UseVisualStyleBackColor = false;
            this.btnonay.Click += new System.EventHandler(this.btnonay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.9F);
            this.label5.Location = new System.Drawing.Point(8, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "ÖDEMENİZ GEREKEN TUTAR:";
            // 
            // lbltoplamtutar
            // 
            this.lbltoplamtutar.AutoSize = true;
            this.lbltoplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.9F);
            this.lbltoplamtutar.ForeColor = System.Drawing.Color.Red;
            this.lbltoplamtutar.Location = new System.Drawing.Point(296, 418);
            this.lbltoplamtutar.Name = "lbltoplamtutar";
            this.lbltoplamtutar.Size = new System.Drawing.Size(24, 26);
            this.lbltoplamtutar.TabIndex = 12;
            this.lbltoplamtutar.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(326, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "₺";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label7.Location = new System.Drawing.Point(12, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "KÖFTE(Porsiyon) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "KEBAP(porsiyon) :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label9.Location = new System.Drawing.Point(12, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "PİLAV(200 gr) :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label10.Location = new System.Drawing.Point(154, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "16 ₺";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label11.Location = new System.Drawing.Point(154, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "22 ₺";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label12.Location = new System.Drawing.Point(154, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "6 ₺";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbltoplamtutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnonay);
            this.Controls.Add(this.btnözet);
            this.Controls.Add(this.Btniptal);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btniptal;
        private System.Windows.Forms.Button btnözet;
        private System.Windows.Forms.Button btnonay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltoplamtutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

