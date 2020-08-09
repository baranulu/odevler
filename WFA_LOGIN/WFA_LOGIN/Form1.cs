using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random rastgelesayi = new Random();
        int kalanhaksayisi = 5;
        private void Form1_Load(object sender, EventArgs e)
            
        {
            int rastgele = rastgelesayi.Next(lblrastgelesayi.Text.Length, 1000000);
            lblrastgelesayi.Text =(rastgele.ToString());

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtgirilensayi.Text == lblrastgelesayi.Text)
            {
                MessageBox.Show("tebrikler giriş yapılıyor!");


            }
            else
            
                kalanhaksayisi--;
            

             if (kalanhaksayisi !=0)
            {
                int rastgele = rastgelesayi.Next(100000, 1000000);
                lblrastgelesayi.Text = (rastgele.ToString());
                txtgirilensayi.Clear();
                txtgirilensayi.Focus();               
                lblgirişhakki.Text = kalanhaksayisi.ToString();
            }
            else
            {
                lblgirişhakki.Text = kalanhaksayisi.ToString();
                txtgirilensayi.Clear();
                txtgirilensayi.Enabled = false;
                btngiris.Enabled = false;
                lblrastgelesayi = default;
                MessageBox.Show("giriş sağlanamadı,hakkınız bitti,sie!");
            }
                
            
        }
    }
}
