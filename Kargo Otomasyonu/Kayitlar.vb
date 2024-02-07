Imports Kargo_Otomasyonu.Kargo_Otomasyonu

Public Class Kayitlar
    Private Sub Kayitlar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim database_control As Database_Control = New Database_Control
        ' Veritabanındaki tüm verileri alıp tabloya yazar.
        database_control.Get_Data_From_Database("kargo_data", DataGridView1)
    End Sub
End Class