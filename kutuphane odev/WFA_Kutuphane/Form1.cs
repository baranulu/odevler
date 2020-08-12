using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WFA_Kutuphane
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtKitapAdi.Text = string.Empty;
            txtYazarAdi.Text = string.Empty;
            txtYayinEvi.Text = string.Empty;
            txtISBNNo.Text = string.Empty;
            nmrBaskiSayisi.Value = 0;
            nmrSayfaSayisi.Value = 0;
            cmbTur.SelectedIndex = -1;
            dtBasimYili.Value = DateTime.Now;
        }



        string[] kitapturleri = { "Anı", "Roman", "bilim Kurgu", "Biyografi", "otobiyografi", "edebiyat", "masal", "öykü", "tarih", "sağlık" };
        
        private void Form1_Load(object sender, EventArgs e)
        {
           foreach(string tur in kitapturleri) 
            {
                cmbTur.Items.Add(tur);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtKitapAdi.Text == string.Empty || cmbTur.SelectedIndex == -1 || txtYazarAdi.Text == string.Empty)
            {
                txtKitapAdi.BackColor = Color.Orange;
                txtYazarAdi.BackColor = Color.Orange;
                cmbTur.BackColor = Color.Orange;

                errorProvider1.SetError(txtKitapAdi, "Kitap adı boş geçilemez!");
                errorProvider1.SetError(cmbTur, "Kitap türü boş geçilemez!");
                errorProvider1.SetError(txtYazarAdi, "Yazar adı boş geçilemez!");
            }
            else
            {
                Kitapkaydi Kk = new Kitapkaydi();
                Kk.Kitapadi = txtKitapAdi.Text;
                Kk.Yazaradi = txtYazarAdi.Text;
                Kk.Yayinevi = txtYayinEvi.Text;
                Kk.ISBNno = Convert.ToUInt64(txtISBNNo.Text);
                Kk.Baskisayisi =Convert.ToInt32(nmrBaskiSayisi.Value);
                Kk.sayfasayisi = Convert.ToInt32(nmrSayfaSayisi.Value);
                Kk.KitapTuru = cmbTur.SelectedIndex.ToString();
                Kk.Basimyili = dtBasimYili.Value.ToString();
                MessageBox.Show("kitap başarıyla kaydedildi!");
                lstKitaplar.Items.Add(Kk);
                temizle();
            }

        }
        Kitapkaydi kitapkaydi;
        int index = -1;
        private void tsmSil_Click(object sender, EventArgs e)
        {
            if(lstKitaplar.SelectedIndex != -1)
            {
                lstKitaplar.Items.Remove(lstKitaplar.SelectedItem);
            }
            else
            {
                MessageBox.Show("silmek istediğiniz kayıtı seçiniz");
            }
        }

        private void tsmDuzenle_Click(object sender, EventArgs e)
        {


            if(lstKitaplar.SelectedIndex!= -1)
            {
            kitapkaydi = (Kitapkaydi)lstKitaplar.SelectedItem;
            index = lstKitaplar.SelectedIndex;
            txtKitapAdi.Text     = kitapkaydi.Kitapadi;
            txtYazarAdi.Text     = kitapkaydi.Yazaradi;
            txtYayinEvi.Text     = kitapkaydi.Yayinevi;
            txtISBNNo.Text       = kitapkaydi.ISBNno.ToString();
            nmrBaskiSayisi.Value = kitapkaydi.Baskisayisi;
            nmrSayfaSayisi.Value = kitapkaydi.sayfasayisi;
            cmbTur.SelectedIndex = int.Parse(kitapkaydi.KitapTuru);
            dtBasimYili.Value =Convert.ToDateTime (kitapkaydi.Basimyili);
             }
            else
            {
                MessageBox.Show("düzenlemek istediğiniz kayıdı seçiniz!");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            lstKitaplar.Items.Remove(kitapkaydi);
            kitapkaydi.Kitapadi= txtKitapAdi.Text;
            kitapkaydi.Yazaradi  = txtYazarAdi.Text;
            kitapkaydi.Yayinevi= txtYayinEvi.Text;
            kitapkaydi.ISBNno= Convert.ToUInt64(txtISBNNo.Text);
            kitapkaydi.Baskisayisi = Convert.ToInt32(nmrBaskiSayisi.Value);
            kitapkaydi.sayfasayisi = Convert.ToInt32(nmrSayfaSayisi.Value);
            kitapkaydi.KitapTuru   = cmbTur.SelectedIndex.ToString();
            kitapkaydi.Basimyili  = dtBasimYili.Value.ToString();
            lstKitaplar.Items.Insert(index, kitapkaydi);
            MessageBox.Show("kayıt yeniden düzenlendi!");
            temizle();
        }
    }
}
