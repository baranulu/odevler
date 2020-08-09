namespace WFA_LOGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrastgelesayi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblgirişhakki = new System.Windows.Forms.Label();
            this.txtgirilensayi = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI GİRİŞ EKRANI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aşağıda ki sayıları giriniz";
            // 
            // lblrastgelesayi
            // 
            this.lblrastgelesayi.AutoSize = true;
            this.lblrastgelesayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lblrastgelesayi.Location = new System.Drawing.Point(121, 123);
            this.lblrastgelesayi.Name = "lblrastgelesayi";
            this.lblrastgelesayi.Size = new System.Drawing.Size(70, 22);
            this.lblrastgelesayi.TabIndex = 2;
            this.lblrastgelesayi.Text = "000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label4.Location = new System.Drawing.Point(12, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "kalan giriş hakkınız:";
            // 
            // lblgirişhakki
            // 
            this.lblgirişhakki.AutoSize = true;
            this.lblgirişhakki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblgirişhakki.ForeColor = System.Drawing.Color.Red;
            this.lblgirişhakki.Location = new System.Drawing.Point(193, 360);
            this.lblgirişhakki.Name = "lblgirişhakki";
            this.lblgirişhakki.Size = new System.Drawing.Size(20, 24);
            this.lblgirişhakki.TabIndex = 4;
            this.lblgirişhakki.Text = "5";
            // 
            // txtgirilensayi
            // 
            this.txtgirilensayi.Location = new System.Drawing.Point(12, 220);
            this.txtgirilensayi.Name = "txtgirilensayi";
            this.txtgirilensayi.Size = new System.Drawing.Size(308, 22);
            this.txtgirilensayi.TabIndex = 5;
            // 
            // btngiris
            // 
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btngiris.Location = new System.Drawing.Point(64, 264);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(204, 40);
            this.btngiris.TabIndex = 6;
            this.btngiris.Text = "Giriş yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtgirilensayi);
            this.Controls.Add(this.lblgirişhakki);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblrastgelesayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblrastgelesayi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblgirişhakki;
        private System.Windows.Forms.TextBox txtgirilensayi;
        private System.Windows.Forms.Button btngiris;
    }
}

