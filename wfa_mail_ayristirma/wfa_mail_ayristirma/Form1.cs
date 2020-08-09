using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_mail_ayristirma
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        
        private void form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Birden fazla mail adresi girecekseniz,mailleri (;) ile ayiriniz.\nSpace tuşu kullanmayınız!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Btnekle_Click(object sender, EventArgs e)
        {
            string[] gelenmetin = { textBox1.Text };
        }


        
        
         
        private void btnayristir_Click(object sender, EventArgs e)
        {

            string gelenmail = textBox1.Text;
            string[] ayrilacakmail = gelenmail.Split(';');
            
            foreach (string mail in ayrilacakmail)
            {
                if (mail.Contains("@hotmail.com"))
                {                   
                    lsthotmail.Items.Add(mail);
                    
 
                }
                
                else if (mail.Contains("@gmail.com"))
                {
                    lstgmail.Items.Add(mail);
                    
                }
                else if (mail.Contains("@lineage2.com"))
                {
                    lstlineage2.Items.Add(mail);
                    
                }
                else
                {
                    lstçöp.Items.Add(mail);
                }
              
            }
            lblhotmailsayi.Text = lsthotmail.Items.Count.ToString();
            lbllineage2sayi.Text = lstlineage2.Items.Count.ToString();
            lblgmailsayi.Text = lstgmail.Items.Count.ToString();
            

           
            
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            lstgmail.Items.Clear();
            lstlineage2.Items.Clear();
            lsthotmail.Items.Clear();
            lstçöp.Items.Clear();
            textBox1.Clear();
            textBox1.Focus();
            lblgmailsayi.Text = default;
            lblhotmailsayi.Text = default;
            lbllineage2sayi.Text = default;
        }
    }
}
