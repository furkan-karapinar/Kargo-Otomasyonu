Imports Kargo_Otomasyonu.Kargo_Otomasyonu

Public Class Iptal_Kargo
    Dim database_control As Database_Control = New Database_Control
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Girdi boş ise bildirir. Değilse fatura numarası ile kaydı bulur ve siler.
        Try
            If TextBox1.Text = String.Empty Then
                MsgBox("Lütfen kargo numarasını girin!")
            Else

                database_control.Delete_Data("kargo_data", "fatura_no", TextBox1.Text)
                MsgBox("Kayıt Silindi!", vbInformation)
            End If
        Catch ex As Exception
            MsgBox("Veritabanı hatası")
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Yazı değiştiğinde veritabanından alıcı ve gönderenin adını alır ve gösterir.
        Try
            If TextBox1.Text <> String.Empty Then
                Label2.Text = "Gönderen Adı: " & database_control.Get_Data_For_Sender("kargo_data", TextBox1.Text, 1)
                Label3.Text = "Alıcı Adı: " & database_control.Get_Data_For_Sender("kargo_data", TextBox1.Text, 6)
            End If

        Catch ex As Exception

        End Try

    End Sub


End Class