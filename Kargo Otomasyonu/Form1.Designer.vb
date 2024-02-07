<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.paket_yukseklik = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ucret_hesap_btn = New System.Windows.Forms.Button()
        Me.paket_boy = New System.Windows.Forms.NumericUpDown()
        Me.urun_kg = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.urun_adet = New System.Windows.Forms.NumericUpDown()
        Me.paket_en = New System.Windows.Forms.NumericUpDown()
        Me.top_ucret = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.urun_tip = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.alici_not = New System.Windows.Forms.RichTextBox()
        Me.alici_adres = New System.Windows.Forms.RichTextBox()
        Me.alici_tip = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.alici_tel = New System.Windows.Forms.TextBox()
        Me.alici_tc = New System.Windows.Forms.TextBox()
        Me.alici_soyad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.alici_ad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gonderen_adres = New System.Windows.Forms.RichTextBox()
        Me.gonderen_tip = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gonderen_tel = New System.Windows.Forms.TextBox()
        Me.gonderen_tc = New System.Windows.Forms.TextBox()
        Me.gonderen_soyad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gonderen_ad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kayit_btn = New System.Windows.Forms.Button()
        Me.temizle_btn = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.hedef_sehir = New System.Windows.Forms.ComboBox()
        Me.merkez_sehir = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.teslim_sure = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.kargo_iptal_btn = New System.Windows.Forms.Button()
        Me.kargo_ekle_btn = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.kargo_durum_bar = New System.Windows.Forms.ProgressBar()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.kargo_bilgi = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.kargo_takip_btn = New System.Windows.Forms.Button()
        Me.kargo_takip_no = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.paket_yukseklik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paket_boy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.urun_kg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.urun_adet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paket_en, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.kayit_btn)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.kargo_ekle_btn)
        Me.GroupBox1.Controls.Add(Me.temizle_btn)
        Me.GroupBox1.Controls.Add(Me.kargo_iptal_btn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1574, 516)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kargo Gönderim"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.paket_yukseklik)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.ucret_hesap_btn)
        Me.GroupBox4.Controls.Add(Me.paket_boy)
        Me.GroupBox4.Controls.Add(Me.urun_kg)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.urun_adet)
        Me.GroupBox4.Controls.Add(Me.paket_en)
        Me.GroupBox4.Controls.Add(Me.top_ucret)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.urun_tip)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Location = New System.Drawing.Point(791, 38)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(765, 215)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Desi Hesaplama"
        '
        'paket_yukseklik
        '
        Me.paket_yukseklik.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.paket_yukseklik.Location = New System.Drawing.Point(526, 111)
        Me.paket_yukseklik.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.paket_yukseklik.Name = "paket_yukseklik"
        Me.paket_yukseklik.Size = New System.Drawing.Size(220, 27)
        Me.paket_yukseklik.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label18.Location = New System.Drawing.Point(373, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Paket Eni (cm):"
        '
        'ucret_hesap_btn
        '
        Me.ucret_hesap_btn.Location = New System.Drawing.Point(376, 160)
        Me.ucret_hesap_btn.Name = "ucret_hesap_btn"
        Me.ucret_hesap_btn.Size = New System.Drawing.Size(370, 34)
        Me.ucret_hesap_btn.TabIndex = 4
        Me.ucret_hesap_btn.Text = "Hesapla"
        Me.ucret_hesap_btn.UseVisualStyleBackColor = True
        '
        'paket_boy
        '
        Me.paket_boy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.paket_boy.Location = New System.Drawing.Point(526, 71)
        Me.paket_boy.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.paket_boy.Name = "paket_boy"
        Me.paket_boy.Size = New System.Drawing.Size(220, 27)
        Me.paket_boy.TabIndex = 3
        '
        'urun_kg
        '
        Me.urun_kg.Location = New System.Drawing.Point(135, 111)
        Me.urun_kg.Name = "urun_kg"
        Me.urun_kg.Size = New System.Drawing.Size(220, 27)
        Me.urun_kg.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label22.Location = New System.Drawing.Point(373, 75)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(108, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Paket Boyu (cm):"
        '
        'urun_adet
        '
        Me.urun_adet.Location = New System.Drawing.Point(135, 69)
        Me.urun_adet.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.urun_adet.Name = "urun_adet"
        Me.urun_adet.Size = New System.Drawing.Size(220, 27)
        Me.urun_adet.TabIndex = 3
        Me.urun_adet.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'paket_en
        '
        Me.paket_en.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.paket_en.Location = New System.Drawing.Point(526, 30)
        Me.paket_en.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.paket_en.Name = "paket_en"
        Me.paket_en.Size = New System.Drawing.Size(220, 27)
        Me.paket_en.TabIndex = 3
        '
        'top_ucret
        '
        Me.top_ucret.AutoSize = True
        Me.top_ucret.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.top_ucret.Location = New System.Drawing.Point(17, 170)
        Me.top_ucret.Name = "top_ucret"
        Me.top_ucret.Size = New System.Drawing.Size(280, 16)
        Me.top_ucret.TabIndex = 0
        Me.top_ucret.Text = "Toplam Ücret: 3000 TL (%18 KDV Dahil)"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label25.Location = New System.Drawing.Point(373, 116)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(139, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Paket Yüksekliği (cm):"
        '
        'urun_tip
        '
        Me.urun_tip.FormattingEnabled = True
        Me.urun_tip.Items.AddRange(New Object() {"Giyim ve Moda Ürünleri", "Elektronik Ürünler", "Kişisel Bakım Ürünleri", "Ev Eşyaları", "Kitap ve Medya Ürünleri", "Sağlık Ürünleri", "Hediyelik Eşya Ürünleri", "Yiyecek ve İçecek Ürünleri"})
        Me.urun_tip.Location = New System.Drawing.Point(135, 30)
        Me.urun_tip.Name = "urun_tip"
        Me.urun_tip.Size = New System.Drawing.Size(220, 28)
        Me.urun_tip.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.Location = New System.Drawing.Point(17, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Ürün Ağırlığı (Kg):"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Ürün Adedi:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 16)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Ürün Tipi:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.alici_not)
        Me.GroupBox3.Controls.Add(Me.alici_adres)
        Me.GroupBox3.Controls.Add(Me.alici_tip)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.alici_tel)
        Me.GroupBox3.Controls.Add(Me.alici_tc)
        Me.GroupBox3.Controls.Add(Me.alici_soyad)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.alici_ad)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 266)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(763, 237)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alıcı"
        '
        'alici_not
        '
        Me.alici_not.Location = New System.Drawing.Point(412, 151)
        Me.alici_not.Name = "alici_not"
        Me.alici_not.Size = New System.Drawing.Size(332, 67)
        Me.alici_not.TabIndex = 3
        Me.alici_not.Text = ""
        '
        'alici_adres
        '
        Me.alici_adres.Location = New System.Drawing.Point(412, 32)
        Me.alici_adres.Name = "alici_adres"
        Me.alici_adres.Size = New System.Drawing.Size(332, 105)
        Me.alici_adres.TabIndex = 3
        Me.alici_adres.Text = ""
        '
        'alici_tip
        '
        Me.alici_tip.FormattingEnabled = True
        Me.alici_tip.Items.AddRange(New Object() {"Bireysel", "Kurumsal (Anlaşmalı)"})
        Me.alici_tip.Location = New System.Drawing.Point(127, 190)
        Me.alici_tip.Name = "alici_tip"
        Me.alici_tip.Size = New System.Drawing.Size(220, 28)
        Me.alici_tip.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "T.C. Kimlik No:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Soyad:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(360, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Not:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Ad:"
        '
        'alici_tel
        '
        Me.alici_tel.Location = New System.Drawing.Point(127, 151)
        Me.alici_tel.Name = "alici_tel"
        Me.alici_tel.Size = New System.Drawing.Size(220, 27)
        Me.alici_tel.TabIndex = 1
        '
        'alici_tc
        '
        Me.alici_tc.Location = New System.Drawing.Point(127, 110)
        Me.alici_tc.Name = "alici_tc"
        Me.alici_tc.Size = New System.Drawing.Size(220, 27)
        Me.alici_tc.TabIndex = 1
        '
        'alici_soyad
        '
        Me.alici_soyad.Location = New System.Drawing.Point(127, 70)
        Me.alici_soyad.Name = "alici_soyad"
        Me.alici_soyad.Size = New System.Drawing.Size(220, 27)
        Me.alici_soyad.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(360, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Adres:"
        '
        'alici_ad
        '
        Me.alici_ad.Location = New System.Drawing.Point(127, 32)
        Me.alici_ad.Name = "alici_ad"
        Me.alici_ad.Size = New System.Drawing.Size(220, 27)
        Me.alici_ad.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Telefon No:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 197)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Alıcı Tipi:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gonderen_adres)
        Me.GroupBox2.Controls.Add(Me.gonderen_tip)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.gonderen_tel)
        Me.GroupBox2.Controls.Add(Me.gonderen_tc)
        Me.GroupBox2.Controls.Add(Me.gonderen_soyad)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.gonderen_ad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 215)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gönderen"
        '
        'gonderen_adres
        '
        Me.gonderen_adres.Location = New System.Drawing.Point(412, 32)
        Me.gonderen_adres.Name = "gonderen_adres"
        Me.gonderen_adres.Size = New System.Drawing.Size(332, 168)
        Me.gonderen_adres.TabIndex = 3
        Me.gonderen_adres.Text = ""
        '
        'gonderen_tip
        '
        Me.gonderen_tip.FormattingEnabled = True
        Me.gonderen_tip.Items.AddRange(New Object() {"Bireysel", "Kurumsal (Anlaşmalı)"})
        Me.gonderen_tip.Location = New System.Drawing.Point(127, 172)
        Me.gonderen_tip.Name = "gonderen_tip"
        Me.gonderen_tip.Size = New System.Drawing.Size(220, 28)
        Me.gonderen_tip.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "T.C. Kimlik No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Soyad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ad:"
        '
        'gonderen_tel
        '
        Me.gonderen_tel.Location = New System.Drawing.Point(127, 135)
        Me.gonderen_tel.Name = "gonderen_tel"
        Me.gonderen_tel.Size = New System.Drawing.Size(220, 27)
        Me.gonderen_tel.TabIndex = 1
        '
        'gonderen_tc
        '
        Me.gonderen_tc.Location = New System.Drawing.Point(127, 99)
        Me.gonderen_tc.Name = "gonderen_tc"
        Me.gonderen_tc.Size = New System.Drawing.Size(220, 27)
        Me.gonderen_tc.TabIndex = 1
        '
        'gonderen_soyad
        '
        Me.gonderen_soyad.Location = New System.Drawing.Point(127, 65)
        Me.gonderen_soyad.Name = "gonderen_soyad"
        Me.gonderen_soyad.Size = New System.Drawing.Size(220, 27)
        Me.gonderen_soyad.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.Location = New System.Drawing.Point(360, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Adres:"
        '
        'gonderen_ad
        '
        Me.gonderen_ad.Location = New System.Drawing.Point(127, 32)
        Me.gonderen_ad.Name = "gonderen_ad"
        Me.gonderen_ad.Size = New System.Drawing.Size(220, 27)
        Me.gonderen_ad.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telefon No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Gönderici Tipi:"
        '
        'kayit_btn
        '
        Me.kayit_btn.Location = New System.Drawing.Point(1317, 423)
        Me.kayit_btn.Name = "kayit_btn"
        Me.kayit_btn.Size = New System.Drawing.Size(220, 35)
        Me.kayit_btn.TabIndex = 3
        Me.kayit_btn.Text = "Kayıtları Görüntüle"
        Me.kayit_btn.UseVisualStyleBackColor = True
        '
        'temizle_btn
        '
        Me.temizle_btn.Location = New System.Drawing.Point(1317, 377)
        Me.temizle_btn.Name = "temizle_btn"
        Me.temizle_btn.Size = New System.Drawing.Size(220, 35)
        Me.temizle_btn.TabIndex = 3
        Me.temizle_btn.Text = "Temizle"
        Me.temizle_btn.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.hedef_sehir)
        Me.GroupBox5.Controls.Add(Me.merkez_sehir)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.teslim_sure)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Location = New System.Drawing.Point(791, 266)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(492, 237)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Teslim Süresi"
        '
        'hedef_sehir
        '
        Me.hedef_sehir.FormattingEnabled = True
        Me.hedef_sehir.Items.AddRange(New Object() {"ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AMASYA", "ANKARA", "ANTALYA", "ARTVİN", "AYDIN", "BALIKESİR", "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM", "DENİZLİ", "DİYARBAKIR", "EDİRNE", "ELAZIĞ", "ERZİNCAN", "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ", "HATAY", "ISPARTA", "MERSİN", "İSTANBUL", "İZMİR", "KARS", "KASTAMONU", "KAYSERİ", "KIRKLARELİ", "KIRŞEHİR", "KOCAELİ", "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "KAHRAMANMARAŞ", "MARDİN", "MUĞLA", "MUŞ", "NEVŞEHİR", "NİĞDE", "ORDU", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS", "TEKİRDAĞ", "TOKAT", "TRABZON", "TUNCELİ", "ŞANLIURFA", "UŞAK", "VAN", "YOZGAT", "ZONGULDAK", "AKSARAY", "BAYBURT", "KARAMAN", "KIRIKKALE", "BATMAN", "ŞIRNAK", "BARTIN", "ARDAHAN", "IĞDIR", "YALOVA", "KARABÜK", "KİLİS", "OSMANİYE", "DÜZCE"})
        Me.hedef_sehir.Location = New System.Drawing.Point(136, 75)
        Me.hedef_sehir.Name = "hedef_sehir"
        Me.hedef_sehir.Size = New System.Drawing.Size(220, 28)
        Me.hedef_sehir.TabIndex = 2
        '
        'merkez_sehir
        '
        Me.merkez_sehir.FormattingEnabled = True
        Me.merkez_sehir.Items.AddRange(New Object() {"ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AMASYA", "ANKARA", "ANTALYA", "ARTVİN", "AYDIN", "BALIKESİR", "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM", "DENİZLİ", "DİYARBAKIR", "EDİRNE", "ELAZIĞ", "ERZİNCAN", "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ", "HATAY", "ISPARTA", "MERSİN", "İSTANBUL", "İZMİR", "KARS", "KASTAMONU", "KAYSERİ", "KIRKLARELİ", "KIRŞEHİR", "KOCAELİ", "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "KAHRAMANMARAŞ", "MARDİN", "MUĞLA", "MUŞ", "NEVŞEHİR", "NİĞDE", "ORDU", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS", "TEKİRDAĞ", "TOKAT", "TRABZON", "TUNCELİ", "ŞANLIURFA", "UŞAK", "VAN", "YOZGAT", "ZONGULDAK", "AKSARAY", "BAYBURT", "KARAMAN", "KIRIKKALE", "BATMAN", "ŞIRNAK", "BARTIN", "ARDAHAN", "IĞDIR", "YALOVA", "KARABÜK", "KİLİS", "OSMANİYE", "DÜZCE"})
        Me.merkez_sehir.Location = New System.Drawing.Point(135, 32)
        Me.merkez_sehir.Name = "merkez_sehir"
        Me.merkez_sehir.Size = New System.Drawing.Size(220, 28)
        Me.merkez_sehir.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Nerden:"
        '
        'teslim_sure
        '
        Me.teslim_sure.AutoSize = True
        Me.teslim_sure.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.teslim_sure.Location = New System.Drawing.Point(16, 151)
        Me.teslim_sure.Name = "teslim_sure"
        Me.teslim_sure.Size = New System.Drawing.Size(149, 16)
        Me.teslim_sure.TabIndex = 0
        Me.teslim_sure.Text = "Teslim Süresi: 0 Gün"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 81)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(55, 16)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Nereye:"
        '
        'kargo_iptal_btn
        '
        Me.kargo_iptal_btn.Location = New System.Drawing.Point(1317, 331)
        Me.kargo_iptal_btn.Name = "kargo_iptal_btn"
        Me.kargo_iptal_btn.Size = New System.Drawing.Size(220, 35)
        Me.kargo_iptal_btn.TabIndex = 3
        Me.kargo_iptal_btn.Text = "İptal Et"
        Me.kargo_iptal_btn.UseVisualStyleBackColor = True
        '
        'kargo_ekle_btn
        '
        Me.kargo_ekle_btn.Location = New System.Drawing.Point(1317, 285)
        Me.kargo_ekle_btn.Name = "kargo_ekle_btn"
        Me.kargo_ekle_btn.Size = New System.Drawing.Size(220, 35)
        Me.kargo_ekle_btn.TabIndex = 3
        Me.kargo_ekle_btn.Text = "Kaydet"
        Me.kargo_ekle_btn.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.kargo_takip_btn)
        Me.GroupBox6.Controls.Add(Me.kargo_takip_no)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 534)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1574, 159)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Kargo Takip"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.kargo_durum_bar)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Controls.Add(Me.kargo_bilgi)
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Location = New System.Drawing.Point(416, 26)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1140, 118)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        '
        'kargo_durum_bar
        '
        Me.kargo_durum_bar.Location = New System.Drawing.Point(194, 74)
        Me.kargo_durum_bar.Name = "kargo_durum_bar"
        Me.kargo_durum_bar.Size = New System.Drawing.Size(815, 23)
        Me.kargo_durum_bar.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label23.Location = New System.Drawing.Point(109, 76)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Gönderici"
        '
        'kargo_bilgi
        '
        Me.kargo_bilgi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.kargo_bilgi.Location = New System.Drawing.Point(190, 35)
        Me.kargo_bilgi.Name = "kargo_bilgi"
        Me.kargo_bilgi.Size = New System.Drawing.Size(638, 26)
        Me.kargo_bilgi.TabIndex = 3
        Me.kargo_bilgi.Text = "Alıcı Adı: Kerem Kılınç     Durum: Yolda"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label24.Location = New System.Drawing.Point(1027, 76)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 16)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Alıcı"
        '
        'kargo_takip_btn
        '
        Me.kargo_takip_btn.Location = New System.Drawing.Point(237, 89)
        Me.kargo_takip_btn.Name = "kargo_takip_btn"
        Me.kargo_takip_btn.Size = New System.Drawing.Size(122, 34)
        Me.kargo_takip_btn.TabIndex = 2
        Me.kargo_takip_btn.Text = "Sorgula"
        Me.kargo_takip_btn.UseVisualStyleBackColor = True
        '
        'kargo_takip_no
        '
        Me.kargo_takip_no.Location = New System.Drawing.Point(139, 46)
        Me.kargo_takip_no.Name = "kargo_takip_no"
        Me.kargo_takip_no.Size = New System.Drawing.Size(220, 27)
        Me.kargo_takip_no.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Kargo Takip No:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1602, 723)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Kargo_Otomasyon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.paket_yukseklik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paket_boy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.urun_kg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.urun_adet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paket_en, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents temizle_btn As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents hedef_sehir As ComboBox
    Friend WithEvents merkez_sehir As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents teslim_sure As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents kargo_iptal_btn As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ucret_hesap_btn As Button
    Friend WithEvents urun_kg As NumericUpDown
    Friend WithEvents urun_adet As NumericUpDown
    Friend WithEvents urun_tip As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents alici_not As RichTextBox
    Friend WithEvents alici_adres As RichTextBox
    Friend WithEvents alici_tip As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents alici_tel As TextBox
    Friend WithEvents alici_tc As TextBox
    Friend WithEvents alici_soyad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents alici_ad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents kargo_ekle_btn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gonderen_adres As RichTextBox
    Friend WithEvents gonderen_tip As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gonderen_tel As TextBox
    Friend WithEvents gonderen_tc As TextBox
    Friend WithEvents gonderen_soyad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gonderen_ad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents kayit_btn As Button
    Friend WithEvents top_ucret As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents kargo_durum_bar As ProgressBar
    Friend WithEvents Label23 As Label
    Friend WithEvents kargo_bilgi As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents kargo_takip_btn As Button
    Friend WithEvents kargo_takip_no As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents paket_yukseklik As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents paket_boy As NumericUpDown
    Friend WithEvents Label22 As Label
    Friend WithEvents paket_en As NumericUpDown
    Friend WithEvents Label25 As Label
End Class
