using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_yemeksepeti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "SEBONUN YERİ";
            btnonay.BackColor = Color.MediumSpringGreen;
            btnözet.BackColor = Color.DeepSkyBlue;
            Btniptal.BackColor = Color.Red;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }


        decimal kebapfiyati = 22.5M;
        decimal pilavfiyati = 6;
        decimal köftefiyati = 16;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex != 0 && comboBox1.Text != comboBox2.Text)
            {
                btnonay.BackColor = Color.MediumSpringGreen;
                btnözet.BackColor = Color.DeepSkyBlue;
                Btniptal.BackColor = Color.Red;

                btnonay.Enabled = true;
                btnözet.Enabled = true;
                Btniptal.Enabled = true;
            }
            else
            {
                btnonay.BackColor = Color.LightGray;
                btnözet.BackColor = Color.LightGray;
                Btniptal.BackColor = Color.LightGray;
                btnonay.Enabled = false;
                btnözet.Enabled = false;
                Btniptal.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex != 0 && comboBox1.Text != comboBox2.Text)
            {
                btnonay.BackColor = Color.MediumSpringGreen;
                btnözet.BackColor = Color.DeepSkyBlue;
                Btniptal.BackColor = Color.Red;

                btnonay.Enabled = true;
                btnözet.Enabled = true;
                Btniptal.Enabled = true;
            }
            else
            {
                btnonay.BackColor = Color.LightGray;
                btnözet.BackColor = Color.LightGray;
                Btniptal.BackColor = Color.LightGray;
                btnonay.Enabled = false;
                btnözet.Enabled = false;
                Btniptal.Enabled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

              
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {   
                // Verify that the pressed key isn't CTRL or any non-numeric digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                

            
        }
        private void hesapla()
        {
            decimal odenecektoplamtutar = 0;
            decimal birinciyemekporsiyonu = Convert.ToDecimal(textBox1.Text);
            decimal ikinyemekporsiyonu = Convert.ToDecimal(textBox2.Text);

            switch (comboBox1.Text)
            {
                case "KEBAP":
                    odenecektoplamtutar += kebapfiyati * birinciyemekporsiyonu;
                    break;
                case "PİLAV":
                    odenecektoplamtutar += pilavfiyati * birinciyemekporsiyonu;
                    break;
                case "AKÇAABAT KÖFTE":
                    odenecektoplamtutar += köftefiyati * birinciyemekporsiyonu;
                    break;
            }
            switch (comboBox2.Text)
            {
                case "KEBAP":
                    odenecektoplamtutar += kebapfiyati * ikinyemekporsiyonu;
                    break;    
                case "AKÇAABAT KÖFTE":
                    odenecektoplamtutar += köftefiyati * ikinyemekporsiyonu;
                    break;
                case "PİLAV":
                    odenecektoplamtutar += pilavfiyati * ikinyemekporsiyonu;
                    break;

            }
            lbltoplamtutar.Text = odenecektoplamtutar.ToString();

          
            
        }
        
        


        private void btnonay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("lütfen birinci yemeğin porsiyonunu giriniz");
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("lütfen ikinci yemeğin porsiyonunu giriniz");
            }


            hesapla();
            
            MessageBox.Show("siparişiniz başarıyla alındı,en kısa sürede adresinize teslim edilecektir.", "Teşekkürler:)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox1.Clear();
            textBox2.Clear();
            lbltoplamtutar.Text = "0";

        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox1.Clear();
            textBox2.Clear();
            lbltoplamtutar.Text = "0";
        }

        
        private void btnözet_Click(object sender, EventArgs e)
        {
            hesapla();
            MessageBox.Show($"seçilen birinci yemek: {comboBox1.Text} porsiyon: {textBox1.Text}\nseçilen ikinici yemek: {comboBox2.Text} porsiyon: {textBox1.Text}\n TOPLAM ÖDENECEK TUTAR: {lbltoplamtutar.Text}");
        }

       

        
    }
}
