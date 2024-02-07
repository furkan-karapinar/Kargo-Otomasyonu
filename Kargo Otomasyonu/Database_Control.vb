Imports System
Imports System.Collections.Generic
Imports System.Data.SQLite
Imports System.IO
Imports System.Linq
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports ComboBox = System.Windows.Forms.ComboBox

Namespace Kargo_Otomasyonu
    Friend Class Database_Control
        Private path As String = "database.db", cs As String = "URI=file:" & Application.StartupPath & "\database.db"
        Private data_connection As SQLiteConnection
        Private command As SQLiteCommand
        Private reader As SQLiteDataReader

        Public Sub Create_Database(ByVal datatable_name As String, ByVal data_options As String)
            ' Veritabanı yoksa oluşturur.
            If Not System.IO.File.Exists(path) Then
                SQLiteConnection.CreateFile(path)
            End If

            Using sqlite = New SQLiteConnection("Data Source=" & path)
                sqlite.Open()
                Dim sql As String = "CREATE TABLE IF NOT EXISTS " & datatable_name & " (" & data_options & ")"
                Dim cmd As SQLiteCommand = New SQLiteCommand(sql, sqlite)
                cmd.ExecuteNonQuery()
                cmd.Cancel()
            End Using
        End Sub

        Public Sub Get_Data_From_Database(ByVal datatable_name As String, ByVal dataGrid As DataGridView)
            ' Veritabanından tüm verileri alır.
            Try
                dataGrid.Rows.Clear()
                Dim data_connection = New SQLiteConnection(cs)
                data_connection.Open()
                Dim stm As String = "SELECT * FROM " & datatable_name
                Dim command = New SQLiteCommand(stm, data_connection)
                reader = command.ExecuteReader()

                While reader.Read()
                    dataGrid.Rows.Insert(0, reader.GetValue(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15))
                End While

            Catch
                MessageBox.Show("Veri Alımı Hatası")
            End Try
        End Sub


        Public Function Get_Data_For_Sender(ByVal datatable_name As String, ByVal fatura_no As String, ByVal deger As Integer) As String
            ' Veritabanından fatura numarası ile alıcı ve gönderici adı alınır.
            Try
                Dim data As String
                Dim data_connection = New SQLiteConnection(cs)
                data_connection.Open()
                Dim stm As String = "SELECT * FROM " & datatable_name & " WHERE fatura_no = " & fatura_no
                Dim command = New SQLiteCommand(stm, data_connection)
                reader = command.ExecuteReader()

                While reader.Read()
                    data = reader.GetString(deger)
                End While
                Return data
            Catch
                MessageBox.Show("Veri Alımı Hatası")
                Return "Null"
            End Try
        End Function


        Public Sub Delete_Data(ByVal datatable_name As String, ByVal database_item_name As String, ByVal item_name As String)
            ' Veritabanından veri siler
            Try
                Dim con = New SQLiteConnection(cs)
                con.Open()
                Dim cmd = New SQLiteCommand(con)
                cmd.CommandText = "DELETE FROM " & datatable_name & " WHERE " & database_item_name & "=@name"
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@name", item_name)
                cmd.ExecuteNonQuery()
                cmd.Cancel()
            Catch
                MessageBox.Show("Veri Silme Hatası")
            End Try
        End Sub

        Public Function Insert_Data(ByVal datatable_name As String, ByVal item_names As String, ByVal item_values As String) As Integer
            ' Veritabanına veri ekler
            Try
                Dim con = New SQLiteConnection(cs)
                con.Open()
                Dim cmd = New SQLiteCommand(con)
                cmd.CommandText = "INSERT INTO " & datatable_name & "(" & item_names & ") VALUES(" & item_values & "); SELECT last_insert_rowid();"
                'cmd.ExecuteNonQuery()
                Dim lastRowId = cmd.ExecuteScalar()
                cmd.Cancel()
                Return lastRowId
            Catch
                MessageBox.Show("Veri Giriş Hatası")
                Return 0
            End Try
        End Function


    End Class
End Namespace
