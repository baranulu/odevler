namespace wfa_mail_ayristirma
{
    partial class form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblhotmailsayi = new System.Windows.Forms.Label();
            this.lbllineage2sayi = new System.Windows.Forms.Label();
            this.lblgmailsayi = new System.Windows.Forms.Label();
            this.Btnekle = new System.Windows.Forms.Button();
            this.btnayristir = new System.Windows.Forms.Button();
            this.lsthotmail = new System.Windows.Forms.ListBox();
            this.lstlineage2 = new System.Windows.Forms.ListBox();
            this.lstgmail = new System.Windows.Forms.ListBox();
            this.lstçöp = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btntemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 25);
            this.textBox1.TabIndex = 0;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.12F);
            this.lblmail.Location = new System.Drawing.Point(12, 40);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(191, 25);
            this.lblmail.TabIndex = 1;
            this.lblmail.Text = "mail adresi giriniz: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(7, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "hotmail.com:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(7, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "lineage2.com:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(7, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "gmail.com:";
            // 
            // lblhotmailsayi
            // 
            this.lblhotmailsayi.AutoSize = true;
            this.lblhotmailsayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblhotmailsayi.ForeColor = System.Drawing.Color.Red;
            this.lblhotmailsayi.Location = new System.Drawing.Point(142, 214);
            this.lblhotmailsayi.Name = "lblhotmailsayi";
            this.lblhotmailsayi.Size = new System.Drawing.Size(20, 24);
            this.lblhotmailsayi.TabIndex = 5;
            this.lblhotmailsayi.Text = "0";
            // 
            // lbllineage2sayi
            // 
            this.lbllineage2sayi.AutoSize = true;
            this.lbllineage2sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbllineage2sayi.ForeColor = System.Drawing.Color.Red;
            this.lbllineage2sayi.Location = new System.Drawing.Point(142, 291);
            this.lbllineage2sayi.Name = "lbllineage2sayi";
            this.lbllineage2sayi.Size = new System.Drawing.Size(20, 24);
            this.lbllineage2sayi.TabIndex = 6;
            this.lbllineage2sayi.Text = "0";
            // 
            // lblgmailsayi
            // 
            this.lblgmailsayi.AutoSize = true;
            this.lblgmailsayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblgmailsayi.ForeColor = System.Drawing.Color.Red;
            this.lblgmailsayi.Location = new System.Drawing.Point(142, 378);
            this.lblgmailsayi.Name = "lblgmailsayi";
            this.lblgmailsayi.Size = new System.Drawing.Size(20, 24);
            this.lblgmailsayi.TabIndex = 7;
            this.lblgmailsayi.Text = "0";
            // 
            // Btnekle
            // 
            this.Btnekle.Location = new System.Drawing.Point(252, 71);
            this.Btnekle.Name = "Btnekle";
            this.Btnekle.Size = new System.Drawing.Size(276, 40);
            this.Btnekle.TabIndex = 8;
            this.Btnekle.Text = "EKLE";
            this.Btnekle.UseVisualStyleBackColor = true;
            this.Btnekle.Click += new System.EventHandler(this.Btnekle_Click);
            // 
            // btnayristir
            // 
            this.btnayristir.Location = new System.Drawing.Point(252, 117);
            this.btnayristir.Name = "btnayristir";
            this.btnayristir.Size = new System.Drawing.Size(276, 40);
            this.btnayristir.TabIndex = 9;
            this.btnayristir.Text = "AYRIŞTIR";
            this.btnayristir.UseVisualStyleBackColor = true;
            this.btnayristir.Click += new System.EventHandler(this.btnayristir_Click);
            // 
            // lsthotmail
            // 
            this.lsthotmail.FormattingEnabled = true;
            this.lsthotmail.ItemHeight = 16;
            this.lsthotmail.Location = new System.Drawing.Point(562, 58);
            this.lsthotmail.Name = "lsthotmail";
            this.lsthotmail.Size = new System.Drawing.Size(171, 228);
            this.lsthotmail.TabIndex = 10;
            // 
            // lstlineage2
            // 
            this.lstlineage2.FormattingEnabled = true;
            this.lstlineage2.ItemHeight = 16;
            this.lstlineage2.Location = new System.Drawing.Point(821, 58);
            this.lstlineage2.Name = "lstlineage2";
            this.lstlineage2.Size = new System.Drawing.Size(171, 228);
            this.lstlineage2.TabIndex = 11;
            // 
            // lstgmail
            // 
            this.lstgmail.FormattingEnabled = true;
            this.lstgmail.ItemHeight = 16;
            this.lstgmail.Location = new System.Drawing.Point(562, 335);
            this.lstgmail.Name = "lstgmail";
            this.lstgmail.Size = new System.Drawing.Size(171, 228);
            this.lstgmail.TabIndex = 12;
            // 
            // lstçöp
            // 
            this.lstçöp.FormattingEnabled = true;
            this.lstçöp.ItemHeight = 16;
            this.lstçöp.Location = new System.Drawing.Point(821, 335);
            this.lstçöp.Name = "lstçöp";
            this.lstçöp.Size = new System.Drawing.Size(171, 228);
            this.lstçöp.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(587, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "hotmail.com";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(840, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "lineage2.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.Location = new System.Drawing.Point(587, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "gmail.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(840, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "GEÇERSİZ";
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(393, 174);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(134, 40);
            this.btntemizle.TabIndex = 18;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 604);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstçöp);
            this.Controls.Add(this.lstgmail);
            this.Controls.Add(this.lstlineage2);
            this.Controls.Add(this.lsthotmail);
            this.Controls.Add(this.btnayristir);
            this.Controls.Add(this.Btnekle);
            this.Controls.Add(this.lblgmailsayi);
            this.Controls.Add(this.lbllineage2sayi);
            this.Controls.Add(this.lblhotmailsayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "form1";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblhotmailsayi;
        private System.Windows.Forms.Label lbllineage2sayi;
        private System.Windows.Forms.Label lblgmailsayi;
        private System.Windows.Forms.Button Btnekle;
        private System.Windows.Forms.Button btnayristir;
        private System.Windows.Forms.ListBox lsthotmail;
        private System.Windows.Forms.ListBox lstlineage2;
        private System.Windows.Forms.ListBox lstgmail;
        private System.Windows.Forms.ListBox lstçöp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btntemizle;
    }
}

