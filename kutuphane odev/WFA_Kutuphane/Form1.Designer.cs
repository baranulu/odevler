namespace WFA_Kutuphane
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
            this.components = new System.ComponentModel.Container();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tsmDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSil = new System.Windows.Forms.ToolStripMenuItem();
            this.txtISBNNo = new MetroFramework.Controls.MetroTextBox();
            this.cmbTur = new MetroFramework.Controls.MetroComboBox();
            this.dtBasimYili = new MetroFramework.Controls.MetroDateTime();
            this.nmrSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.nmrBaskiSayisi = new System.Windows.Forms.NumericUpDown();
            this.txtYayinEvi = new MetroFramework.Controls.MetroTextBox();
            this.txtYazarAdi = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new MetroFramework.Controls.MetroTile();
            this.btnDuzenle = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKitaplar = new System.Windows.Forms.ListBox();
            this.txtKitapAdi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayfaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBaskiSayisi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDuzenle,
            this.tsmSil});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(137, 56);
            // 
            // tsmDuzenle
            // 
            this.tsmDuzenle.Image = global::WFA_Kutuphane.Properties.Resources.icons8_edit_52px;
            this.tsmDuzenle.Name = "tsmDuzenle";
            this.tsmDuzenle.Size = new System.Drawing.Size(214, 26);
            this.tsmDuzenle.Text = "Düzenle";
            this.tsmDuzenle.Click += new System.EventHandler(this.tsmDuzenle_Click);
            // 
            // tsmSil
            // 
            this.tsmSil.Image = global::WFA_Kutuphane.Properties.Resources.icons8_trash_64px;
            this.tsmSil.Name = "tsmSil";
            this.tsmSil.Size = new System.Drawing.Size(214, 26);
            this.tsmSil.Text = "Sil";
            this.tsmSil.Click += new System.EventHandler(this.tsmSil_Click);
            // 
            // txtISBNNo
            // 
            // 
            // 
            // 
            this.txtISBNNo.CustomButton.Image = null;
            this.txtISBNNo.CustomButton.Location = new System.Drawing.Point(383, 1);
            this.txtISBNNo.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtISBNNo.CustomButton.Name = "";
            this.txtISBNNo.CustomButton.Size = new System.Drawing.Size(47, 43);
            this.txtISBNNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtISBNNo.CustomButton.TabIndex = 1;
            this.txtISBNNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtISBNNo.CustomButton.UseSelectable = true;
            this.txtISBNNo.CustomButton.Visible = false;
            this.txtISBNNo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtISBNNo.Lines = new string[0];
            this.txtISBNNo.Location = new System.Drawing.Point(173, 347);
            this.txtISBNNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtISBNNo.MaxLength = 32767;
            this.txtISBNNo.Name = "txtISBNNo";
            this.txtISBNNo.PasswordChar = '\0';
            this.txtISBNNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtISBNNo.SelectedText = "";
            this.txtISBNNo.SelectionLength = 0;
            this.txtISBNNo.SelectionStart = 0;
            this.txtISBNNo.ShortcutsEnabled = true;
            this.txtISBNNo.Size = new System.Drawing.Size(323, 37);
            this.txtISBNNo.TabIndex = 5;
            this.txtISBNNo.UseSelectable = true;
            this.txtISBNNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtISBNNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.ItemHeight = 24;
            this.cmbTur.Location = new System.Drawing.Point(173, 304);
            this.cmbTur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(321, 30);
            this.cmbTur.TabIndex = 4;
            this.cmbTur.UseSelectable = true;
            // 
            // dtBasimYili
            // 
            this.dtBasimYili.Location = new System.Drawing.Point(173, 261);
            this.dtBasimYili.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtBasimYili.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtBasimYili.Name = "dtBasimYili";
            this.dtBasimYili.Size = new System.Drawing.Size(321, 30);
            this.dtBasimYili.TabIndex = 3;
            // 
            // nmrSayfaSayisi
            // 
            this.nmrSayfaSayisi.Location = new System.Drawing.Point(173, 222);
            this.nmrSayfaSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrSayfaSayisi.Name = "nmrSayfaSayisi";
            this.nmrSayfaSayisi.Size = new System.Drawing.Size(323, 30);
            this.nmrSayfaSayisi.TabIndex = 2;
            // 
            // nmrBaskiSayisi
            // 
            this.nmrBaskiSayisi.Location = new System.Drawing.Point(173, 182);
            this.nmrBaskiSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nmrBaskiSayisi.Name = "nmrBaskiSayisi";
            this.nmrBaskiSayisi.Size = new System.Drawing.Size(323, 30);
            this.nmrBaskiSayisi.TabIndex = 2;
            // 
            // txtYayinEvi
            // 
            // 
            // 
            // 
            this.txtYayinEvi.CustomButton.Image = null;
            this.txtYayinEvi.CustomButton.Location = new System.Drawing.Point(383, 1);
            this.txtYayinEvi.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYayinEvi.CustomButton.Name = "";
            this.txtYayinEvi.CustomButton.Size = new System.Drawing.Size(47, 43);
            this.txtYayinEvi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYayinEvi.CustomButton.TabIndex = 1;
            this.txtYayinEvi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYayinEvi.CustomButton.UseSelectable = true;
            this.txtYayinEvi.CustomButton.Visible = false;
            this.txtYayinEvi.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtYayinEvi.Lines = new string[0];
            this.txtYayinEvi.Location = new System.Drawing.Point(173, 138);
            this.txtYayinEvi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYayinEvi.MaxLength = 32767;
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.PasswordChar = '\0';
            this.txtYayinEvi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYayinEvi.SelectedText = "";
            this.txtYayinEvi.SelectionLength = 0;
            this.txtYayinEvi.SelectionStart = 0;
            this.txtYayinEvi.ShortcutsEnabled = true;
            this.txtYayinEvi.Size = new System.Drawing.Size(323, 37);
            this.txtYayinEvi.TabIndex = 1;
            this.txtYayinEvi.UseSelectable = true;
            this.txtYayinEvi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYayinEvi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtYazarAdi
            // 
            // 
            // 
            // 
            this.txtYazarAdi.CustomButton.Image = null;
            this.txtYazarAdi.CustomButton.Location = new System.Drawing.Point(383, 1);
            this.txtYazarAdi.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYazarAdi.CustomButton.Name = "";
            this.txtYazarAdi.CustomButton.Size = new System.Drawing.Size(47, 43);
            this.txtYazarAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYazarAdi.CustomButton.TabIndex = 1;
            this.txtYazarAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYazarAdi.CustomButton.UseSelectable = true;
            this.txtYazarAdi.CustomButton.Visible = false;
            this.txtYazarAdi.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtYazarAdi.Lines = new string[0];
            this.txtYazarAdi.Location = new System.Drawing.Point(173, 94);
            this.txtYazarAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYazarAdi.MaxLength = 32767;
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.PasswordChar = '\0';
            this.txtYazarAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYazarAdi.SelectedText = "";
            this.txtYazarAdi.SelectionLength = 0;
            this.txtYazarAdi.SelectionStart = 0;
            this.txtYazarAdi.ShortcutsEnabled = true;
            this.txtYazarAdi.Size = new System.Drawing.Size(323, 37);
            this.txtYazarAdi.TabIndex = 1;
            this.txtYazarAdi.UseSelectable = true;
            this.txtYazarAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYazarAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuncelle);
            this.groupBox3.Controls.Add(this.btnDuzenle);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(31, 500);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(951, 124);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kontrol Paneli";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.ActiveControl = null;
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnGuncelle.Location = new System.Drawing.Point(285, 32);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(657, 78);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.TileImage = global::WFA_Kutuphane.Properties.Resources.icons8_refresh_64px;
            this.btnGuncelle.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGuncelle.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnGuncelle.UseCustomBackColor = true;
            this.btnGuncelle.UseCustomForeColor = true;
            this.btnGuncelle.UseSelectable = true;
            this.btnGuncelle.UseTileImage = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.ActiveControl = null;
            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnDuzenle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btnDuzenle.Location = new System.Drawing.Point(13, 31);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(264, 79);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "KAYDET";
            this.btnDuzenle.TileImage = global::WFA_Kutuphane.Properties.Resources.icons8_save_64px;
            this.btnDuzenle.TileImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDuzenle.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDuzenle.UseCustomBackColor = true;
            this.btnDuzenle.UseCustomForeColor = true;
            this.btnDuzenle.UseSelectable = true;
            this.btnDuzenle.UseTileImage = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKitaplar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(572, 78);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(409, 415);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Listesi";
            // 
            // lstKitaplar
            // 
            this.lstKitaplar.ContextMenuStrip = this.metroContextMenu1;
            this.lstKitaplar.FormattingEnabled = true;
            this.lstKitaplar.ItemHeight = 25;
            this.lstKitaplar.Location = new System.Drawing.Point(8, 42);
            this.lstKitaplar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstKitaplar.Name = "lstKitaplar";
            this.lstKitaplar.Size = new System.Drawing.Size(392, 329);
            this.lstKitaplar.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            // 
            // 
            // 
            this.txtKitapAdi.CustomButton.Image = null;
            this.txtKitapAdi.CustomButton.Location = new System.Drawing.Point(383, 1);
            this.txtKitapAdi.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKitapAdi.CustomButton.Name = "";
            this.txtKitapAdi.CustomButton.Size = new System.Drawing.Size(47, 43);
            this.txtKitapAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKitapAdi.CustomButton.TabIndex = 1;
            this.txtKitapAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKitapAdi.CustomButton.UseSelectable = true;
            this.txtKitapAdi.CustomButton.Visible = false;
            this.txtKitapAdi.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtKitapAdi.Lines = new string[0];
            this.txtKitapAdi.Location = new System.Drawing.Point(173, 49);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKitapAdi.MaxLength = 32767;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.PasswordChar = '\0';
            this.txtKitapAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKitapAdi.SelectedText = "";
            this.txtKitapAdi.SelectionLength = 0;
            this.txtKitapAdi.SelectionStart = 0;
            this.txtKitapAdi.ShortcutsEnabled = true;
            this.txtKitapAdi.Size = new System.Drawing.Size(323, 37);
            this.txtKitapAdi.TabIndex = 1;
            this.txtKitapAdi.UseSelectable = true;
            this.txtKitapAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKitapAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(40, 353);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(91, 25);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "ISBN No : ";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(95, 309);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(49, 25);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Tür : ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(29, 266);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(99, 25);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Basım Yılı : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(11, 223);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(114, 25);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Sayfa Sayısı : ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(13, 183);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 25);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Baskı Sayısı : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(40, 144);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 25);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Yayın Evi : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(33, 100);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Yazar Adı : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(36, 55);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Kitap Adı : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtISBNNo);
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.dtBasimYili);
            this.groupBox1.Controls.Add(this.nmrSayfaSayisi);
            this.groupBox1.Controls.Add(this.nmrBaskiSayisi);
            this.groupBox1.Controls.Add(this.txtYayinEvi);
            this.groupBox1.Controls.Add(this.txtYazarAdi);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(533, 415);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri Ekleme Ekranı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 654);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrSayfaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBaskiSayisi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem tsmDuzenle;
        private System.Windows.Forms.ToolStripMenuItem tsmSil;
        private MetroFramework.Controls.MetroTextBox txtISBNNo;
        private MetroFramework.Controls.MetroComboBox cmbTur;
        private MetroFramework.Controls.MetroDateTime dtBasimYili;
        private System.Windows.Forms.NumericUpDown nmrSayfaSayisi;
        private System.Windows.Forms.NumericUpDown nmrBaskiSayisi;
        private MetroFramework.Controls.MetroTextBox txtYayinEvi;
        private MetroFramework.Controls.MetroTextBox txtYazarAdi;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile btnGuncelle;
        private MetroFramework.Controls.MetroTile btnDuzenle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstKitaplar;
        private MetroFramework.Controls.MetroTextBox txtKitapAdi;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

