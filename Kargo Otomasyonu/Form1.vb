
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Kargo_Otomasyonu.Kargo_Otomasyonu

Public Class Form1
    Dim dc As Database_Control = New Database_Control
    Dim database As String = "fatura_no INTEGER PRIMARY KEY , gonderen_full_name VARCHAR , gonderen_tc VARCHAR , gonderen_tel VARCHAR , gonderen_type VARCHAR , gonderen_adres VARCHAR , alici_full_name VARCHAR , alici_tc VARCHAR , alici_tel VARCHAR , alici_type VARCHAR , alici_adres VARCHAR , alici_not VARCHAR , urun_type VARCHAR , urun_adet VARCHAR , urun_kg VARCHAR , toplam_ucret VARCHAR"
    Dim desi_ucret As Integer = -1, teslim_gun As Integer = -1
    Dim datatable_name As String = "kargo_data"
    Dim data_insert As String = "gonderen_full_name , gonderen_tc , gonderen_tel , gonderen_type , gonderen_adres , alici_full_name , alici_tc , alici_tel , alici_type , alici_adres , alici_not , urun_type , urun_adet , urun_kg , toplam_ucret"


    Dim marmara_bolgesi As String() = {"İSTANBUL", "BURSA", "KOCAELİ", "SAKARYA", "YALOVA", "TEKİRDAĞ", "EDİRNE", "KIRKLARELİ", "BALIKESİR", "ÇANAKKALE", "BİLECİK"}
    Dim ege_bolgesi As String() = {"İZMİR", "AYDIN", "MANİSA", "MUĞLA", "DENİZLİ", "UŞAK", "BALIKESİR", "KÜTAHYA", "AFYONKARAHİSAR"}
    Dim akdeniz_bolgesi As String() = {"ANTALYA", "MERSİN", "ADANA", "HATAY", "ISPARTA", "BURDUR", "OSMANİYE", "KAHRAMANMARAŞ"}
    Dim ic_anadolu_bolgesi As String() = {"ANKARA", "KONYA", "KAYSERİ", "SİVAS", "KIRIKKALE", "KARAMAN", "AKSARAY", "NİĞDE", "YOZGAT", "KIRŞEHİR", "ÇANKIRI", "ESKİŞEHİR", "NEVŞEHİR"}
    Dim dogu_anadolu_bolgesi As String() = {"ERZURUM", "VAN", "BİNGÖL", "ELAZIĞ", "TUNCELİ", "MALATYA", "MUŞ", "BİTLİS", "AĞRI", "KARS", "IĞDIR", "ARDAHAN", "ERZİNCAN"}
    Dim guneydogu_anadolu_bolgesi As String() = {"DİYARBAKIR", "ŞANLIURFA", "GAZİANTEP", "ADANA", "MARDİN", "SİİRT", "BATMAN", "ŞIRNAK", "HAKKARİ", "KİLİS", "ADIYAMAN"}
    Dim karadeniz_bolgesi As String() = {"TRABZON", "SAMSUN", "ORDU", "GİRESUN", "RİZE", "ARTVİN", "TOKAT", "SİNOP", "KASTAMONU", "BOLU", "DÜZCE", "ZONGULDAK", "BARTIN", "KARABÜK", "AMASYA", "ÇORUM", "BAYBURT", "GÜMÜŞHANE"}


    Private Sub kargo_ekle_btn_Click(sender As Object, e As EventArgs) Handles kargo_ekle_btn.Click
        ' Boş girdi yoksa kaydet varsa bildir
        Try
            If gonderen_ad.Text = String.Empty Or gonderen_soyad.Text = String.Empty Or
                       gonderen_tc.Text = String.Empty Or gonderen_tel.Text = String.Empty Or
                       gonderen_tip.Text = String.Empty Or gonderen_adres.Text = String.Empty Or alici_ad.Text = String.Empty Or alici_soyad.Text = String.Empty Or
                           alici_tc.Text = String.Empty Or alici_tel.Text = String.Empty Or
                           alici_tip.Text = String.Empty Or alici_adres.Text = String.Empty Or urun_tip.Text = String.Empty Or desi_ucret = -1 Then
                MsgBox("Lütfen 'Gönderen' , 'Alıcı' ve 'Desi Hesaplama' alanlarını doldurunuz.", vbCritical)
            Else
                'Kaydetme
                Dim k As Integer = dc.Insert_Data(datatable_name, data_insert, "'" & gonderen_ad.Text & " " & gonderen_soyad.Text & "' , '" & gonderen_tc.Text & "' , '" & gonderen_tel.Text & "' , '" & gonderen_tip.Text & "' , '" & gonderen_adres.Text & "' , '" & alici_ad.Text & " " & alici_soyad.Text & "' , '" & alici_tc.Text & "' , '" & alici_tel.Text & "' , '" & alici_tip.Text & "' , '" & alici_adres.Text & "' , '" & alici_not.Text & "' , '" & urun_tip.Text & "' , '" & urun_adet.Value.ToString & "' , '" & urun_kg.Value.ToString & "' , '" & desi_ucret.ToString & "'")
                MsgBox("Başarıyla Kaydedildi!" & vbNewLine & "Kargo Takip / Fatura No: " & k.ToString, vbInformation)
                clear_ui()
            End If
        Catch ex As Exception
            MsgBox("Verileriniz Kaydedilemedi", vbCritical)
        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Veritananı yoksa oluşturma
        Try
            dc.Create_Database(datatable_name, database)
        Catch ex As Exception
            MsgBox("Database Oluşturulamdı.", MsgBoxStyle.Critical)
        End Try
        clear_ui()

        'Arayüzün düzgün gözükmesi adına
        Dim group_size As Size = New Size(GroupBox1.Size)
        group_size.Width += 40
        Me.Size = New Size(group_size.Width, group_size.Height * 1.5)
    End Sub

    Private Sub desi_hesaplama()
        ' Desi hesaplama ve kg ile kıyaslayıp paket ücreti belirleme
        Dim desi As Double = (paket_en.Value * paket_boy.Value * paket_yukseklik.Value) / 5000, kg As Double = urun_kg.Value
        Dim baskin_deger As Double
        If desi < kg Then baskin_deger = kg Else baskin_deger = desi

        If baskin_deger = desi Then
            desi_ucret = ((baskin_deger * 6) + 40) + ((baskin_deger * 6) + 40) * 18 / 100
        ElseIf baskin_deger = kg Then
            desi_ucret = ((baskin_deger * 5) + 40) + ((baskin_deger * 6) + 40) * 18 / 100
        End If

    End Sub
    Private Sub ucret_hesap_btn_Click(sender As Object, e As EventArgs) Handles ucret_hesap_btn.Click
        ' urun_tip boş ise
        If urun_tip.Text = String.Empty Then
            MsgBox("Lütfen ürün tipini seçiniz!", vbCritical)
            top_ucret.Text = "Toplam Ücret: Belirsiz"
        Else
            ' Hesaplama ve yazdırma
            desi_hesaplama()
            top_ucret.Text = "Toplam Ücret: " & desi_ucret & " TL (%18 KDV Dahil)"
        End If
    End Sub

    Private Sub clear_ui()
        ' Arayüzdeki bütün girdileri temizler veya varsayılan değerine döndürür.
        gonderen_ad.Text = String.Empty
        gonderen_soyad.Text = String.Empty
        gonderen_tc.Text = String.Empty
        gonderen_tel.Text = String.Empty
        gonderen_tip.Text = String.Empty
        gonderen_adres.Text = String.Empty
        alici_ad.Text = String.Empty
        alici_soyad.Text = String.Empty
        alici_tc.Text = String.Empty
        alici_tel.Text = String.Empty
        alici_tip.Text = String.Empty
        alici_adres.Text = String.Empty
        alici_not.Text = String.Empty
        urun_tip.Text = String.Empty
        urun_adet.Value = 1
        urun_kg.Value = 0
        top_ucret.Text = "Toplam Ücret: Belirsiz"
        merkez_sehir.Text = String.Empty
        hedef_sehir.Text = String.Empty
        teslim_sure.Text = "Teslim Süresi: Belirsiz"
        desi_ucret = -1
        teslim_gun = -1
        kargo_bilgi.Text = String.Empty
        kargo_takip_no.Text = String.Empty
        paket_boy.Value = 0
        paket_en.Value = 0
        paket_yukseklik.Value = 0
        kargo_durum_bar.Value = 0
    End Sub

    Private Sub temizle_btn_Click(sender As Object, e As EventArgs) Handles temizle_btn.Click
        ' Arayüzdeki girdileri temizler.
        clear_ui()
    End Sub

    Private Sub kargo_iptal_btn_Click(sender As Object, e As EventArgs) Handles kargo_iptal_btn.Click
        ' Kayıt iptali için yeni bir iptal_kargo formu açar.
        Dim iptal_kargo As Iptal_Kargo = New Iptal_Kargo
        iptal_kargo.Show()
    End Sub

    Private Sub kargo_takip_btn_Click(sender As Object, e As EventArgs) Handles kargo_takip_btn.Click

        ' Burası kargo takip kısmı içindir.
        ' Eğer kargo_takip_no boş ise ilgili mesajı gösterir. Değilse veritabanından ilgili alıcı ismini alır.
        ' Ardından durum bildirimi için koddaki belirtilen aralıkta rastgele bir sayı oluşturularak rastgele bir durum elde edildi.
        ' Son olarakta kargo_bilgi aracılığıyla alıcı adı ve durum belirtildi.

        If kargo_takip_no.Text = String.Empty Then
            MsgBox("Lütfen Kargo Takip Numarası (Fatura Numarası)'nı giriniz")
        Else
            Dim alici As String = "Alıcı Adı: " & dc.Get_Data_For_Sender("kargo_data", kargo_takip_no.Text, 6)
            Dim random As Random = New Random
            Dim sayi As Integer = random.Next(1, 5)
            Dim status As String

            Select Case sayi
                Case 4
                    status = "     Durum: Kargo Teslim Alındı"
                    kargo_durum_bar.Value = 10
                Case 1
                    status = "     Durum: Kargo Yola Çıktı"
                    kargo_durum_bar.Value = 50
                Case 2
                    status = "     Durum: Kargo Dağıtıma Çıktı"
                    kargo_durum_bar.Value = 75
                Case 3
                    status = "     Durum: Kargo Teslim Edildi"
                    kargo_durum_bar.Value = 100
                Case Else
                    MsgBox(sayi)
            End Select


            kargo_bilgi.Text = alici & status

        End If
    End Sub

    Private Sub kayit_btn_Click(sender As Object, e As EventArgs) Handles kayit_btn.Click
        Dim kayitlar As Kayitlar = New Kayitlar
        kayitlar.Show()
    End Sub

    Function HangiBolgede(il As String) As String
        ' Girilen il hangi bölgenin ili olduğunu bul ve sonucu geri döndür.
        Dim bolge As String = ""
        If ege_bolgesi.Contains(il.ToUpper()) Then
            bolge = "ege"
        ElseIf marmara_bolgesi.Contains(il.ToUpper()) Then
            bolge = "marmara"
        ElseIf karadeniz_bolgesi.Contains(il.ToUpper()) Then
            bolge = "karadeniz"
        ElseIf ic_anadolu_bolgesi.Contains(il.ToUpper()) Then
            bolge = "ic_anadolu"
        ElseIf akdeniz_bolgesi.Contains(il.ToUpper()) Then
            bolge = "akdeniz"
        ElseIf dogu_anadolu_bolgesi.Contains(il.ToUpper()) Then
            bolge = "dogu_anadolu"
        ElseIf guneydogu_anadolu_bolgesi.Contains(il.ToUpper()) Then
            bolge = "guneydogu_anadolu"
        End If
        Return bolge
    End Function
    Private Function teslim_karsılastırma() As Integer
        Dim il1 As String = merkez_sehir.Text
        Dim il2 As String = hedef_sehir.Text

        Dim bolge1 As String = HangiBolgede(il1)
        Dim bolge2 As String = HangiBolgede(il2)

        ' Bölge sınırları birbirine yakınsa 2, uzaksa 3 döndürür.
        Select Case bolge1
            Case "marmara"
                If bolge2 = "ege" Or bolge2 = "akdeniz" Or bolge2 = "ic_anadolu" Then
                    Return 2
                ElseIf bolge2 = "dogu_anadolu" Or bolge2 = "guneydogu_anadolu" Or bolge2 = "karadeniz" Then
                    Return 3
                End If

            Case "ege"
                If bolge2 = "marmara" Or bolge2 = "akdeniz" Or bolge2 = "ic_anadolu" Then
                    Return 2
                ElseIf bolge2 = "karadeniz" Or bolge2 = "dogu_anadolu" Or bolge2 = "guneydogu_anadolu" Then
                    Return 3
                End If

            Case "akdeniz"
                If bolge2 = "ege" Or bolge2 = "ic_anadolu" Or bolge2 = "guneydogu_anadolu" Then
                    Return 2
                ElseIf bolge2 = "marmara" Or bolge2 = "dogu_anadolu" Or bolge2 = "karadeniz" Then
                    Return 3
                End If

            Case "ic_anadolu"
                If bolge2 = "akdeniz" Or bolge2 = "ege" Or bolge2 = "karadeniz" Then
                    Return 2
                ElseIf bolge2 = "marmara" Or bolge2 = "dogu_anadolu" Or bolge2 = "guneydogu_anadolu" Then
                    Return 3
                End If

            Case "karadeniz"
                If bolge2 = "ege" Or bolge2 = "guneydogu_anadolu" Or bolge2 = "akdeniz" Then
                    Return 3
                ElseIf bolge2 = "marmara" Or bolge2 = "dogu_anadolu" Or bolge2 = "ic_anadolu" Then
                    Return 2
                End If

            Case "dogu_anadolu"
                If bolge2 = "guneydogu_anadolu" Or bolge2 = "ic_anadolu" Or bolge2 = "karadeniz" Then
                    Return 2
                ElseIf bolge2 = "ege" Or bolge2 = "marmara" Or bolge2 = "akdeniz" Then
                    Return 3
                End If

            Case "guneydogu_anadolu"
                If bolge2 = "ege" Or bolge2 = "marmara" Or bolge2 = "karadeniz" Then
                    Return 3
                ElseIf bolge2 = "dogu_anadolu" Or bolge2 = "ic_anadolu" Or bolge2 = "akdeniz" Then
                    Return 2
                End If
        End Select
        If bolge1 = bolge2 Then Return 1 ' Eşitse 1 gün
        Return 0 ' Eğer bölge1 ve bölge2 birbirine komşu değilse veya geçersiz bölge ismi girilmişse 0 döndürür.
    End Function



    Private Sub merkez_sehir_SelectedValueChanged(sender As Object, e As EventArgs) Handles merkez_sehir.SelectedValueChanged, hedef_sehir.SelectedIndexChanged, merkez_sehir.TextChanged, hedef_sehir.TextChanged

        ' Görevlendirilmiş comboboxların değerleri değiştiğinde boş olup olmadıkları kontrol edilir ve teslim süresini belirtir.
        If merkez_sehir.Text <> String.Empty And hedef_sehir.Text <> String.Empty Then
            ' Karşılaştır ve Süreyi Belirt
            If teslim_karsılastırma() <> 0 Then
                teslim_gun = teslim_karsılastırma()
                teslim_sure.Text = "Teslim Süresi: " & teslim_gun & " İş Günü"
            Else
                teslim_gun = -1
                teslim_sure.Text = "Teslim Süresi: Belirsiz"
            End If

        Else
            teslim_gun = -1
            teslim_sure.Text = "Teslim Süresi: Belirsiz"
        End If


    End Sub
End Class
