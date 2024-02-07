<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kayitlar
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.fatura_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gonderen_full_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gonderen_tc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gonderen_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gonderen_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gonderen_adres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alici_full_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alici_tc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alici_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alici_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alici_adres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alici_not = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.urun_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.urun_adet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.urun_kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toplam_ucret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fatura_no, Me.gonderen_full_name, Me.gonderen_tc, Me.gonderen_tel, Me.gonderen_type, Me.gonderen_adres, Me.alici_full_name, Me.alici_tc, Me.alici_tel, Me.alici_type, Me.alici_adres, Me.alici_not, Me.urun_type, Me.urun_adet, Me.urun_kg, Me.toplam_ucret})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(931, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'fatura_no
        '
        Me.fatura_no.HeaderText = "Kargo / Fatura No"
        Me.fatura_no.MinimumWidth = 6
        Me.fatura_no.Name = "fatura_no"
        Me.fatura_no.Width = 125
        '
        'gonderen_full_name
        '
        Me.gonderen_full_name.HeaderText = "Gönderen Tam Adı"
        Me.gonderen_full_name.MinimumWidth = 6
        Me.gonderen_full_name.Name = "gonderen_full_name"
        Me.gonderen_full_name.Width = 125
        '
        'gonderen_tc
        '
        Me.gonderen_tc.HeaderText = "Gönderen T.C. No"
        Me.gonderen_tc.MinimumWidth = 6
        Me.gonderen_tc.Name = "gonderen_tc"
        Me.gonderen_tc.Width = 125
        '
        'gonderen_tel
        '
        Me.gonderen_tel.HeaderText = "Gönderen Tel No"
        Me.gonderen_tel.MinimumWidth = 6
        Me.gonderen_tel.Name = "gonderen_tel"
        Me.gonderen_tel.Width = 125
        '
        'gonderen_type
        '
        Me.gonderen_type.HeaderText = "Gönderen Tipi"
        Me.gonderen_type.MinimumWidth = 6
        Me.gonderen_type.Name = "gonderen_type"
        Me.gonderen_type.Width = 125
        '
        'gonderen_adres
        '
        Me.gonderen_adres.HeaderText = "Gönderenin Adresi"
        Me.gonderen_adres.MinimumWidth = 6
        Me.gonderen_adres.Name = "gonderen_adres"
        Me.gonderen_adres.Width = 125
        '
        'alici_full_name
        '
        Me.alici_full_name.HeaderText = "Alıcı Tam Adı"
        Me.alici_full_name.MinimumWidth = 6
        Me.alici_full_name.Name = "alici_full_name"
        Me.alici_full_name.Width = 125
        '
        'alici_tc
        '
        Me.alici_tc.HeaderText = "Alıcı T.C. No"
        Me.alici_tc.MinimumWidth = 6
        Me.alici_tc.Name = "alici_tc"
        Me.alici_tc.Width = 125
        '
        'alici_tel
        '
        Me.alici_tel.HeaderText = "Alıcı Tel No"
        Me.alici_tel.MinimumWidth = 6
        Me.alici_tel.Name = "alici_tel"
        Me.alici_tel.Width = 125
        '
        'alici_type
        '
        Me.alici_type.HeaderText = "Alıcı Tipi"
        Me.alici_type.MinimumWidth = 6
        Me.alici_type.Name = "alici_type"
        Me.alici_type.Width = 125
        '
        'alici_adres
        '
        Me.alici_adres.HeaderText = "Alıcı Adresi"
        Me.alici_adres.MinimumWidth = 6
        Me.alici_adres.Name = "alici_adres"
        Me.alici_adres.Width = 125
        '
        'alici_not
        '
        Me.alici_not.HeaderText = "Alıcı Notu"
        Me.alici_not.MinimumWidth = 6
        Me.alici_not.Name = "alici_not"
        Me.alici_not.Width = 125
        '
        'urun_type
        '
        Me.urun_type.HeaderText = "Ürün Tipi"
        Me.urun_type.MinimumWidth = 6
        Me.urun_type.Name = "urun_type"
        Me.urun_type.Width = 125
        '
        'urun_adet
        '
        Me.urun_adet.HeaderText = "Ürün Adeti"
        Me.urun_adet.MinimumWidth = 6
        Me.urun_adet.Name = "urun_adet"
        Me.urun_adet.Width = 125
        '
        'urun_kg
        '
        Me.urun_kg.HeaderText = "Ürün Kg"
        Me.urun_kg.MinimumWidth = 6
        Me.urun_kg.Name = "urun_kg"
        Me.urun_kg.Width = 125
        '
        'toplam_ucret
        '
        Me.toplam_ucret.HeaderText = "Toplam Ödenen Ücret"
        Me.toplam_ucret.MinimumWidth = 6
        Me.toplam_ucret.Name = "toplam_ucret"
        Me.toplam_ucret.Width = 125
        '
        'Kayitlar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Kayitlar"
        Me.Text = "Kayıtlar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents fatura_no As DataGridViewTextBoxColumn
    Friend WithEvents gonderen_full_name As DataGridViewTextBoxColumn
    Friend WithEvents gonderen_tc As DataGridViewTextBoxColumn
    Friend WithEvents gonderen_tel As DataGridViewTextBoxColumn
    Friend WithEvents gonderen_type As DataGridViewTextBoxColumn
    Friend WithEvents gonderen_adres As DataGridViewTextBoxColumn
    Friend WithEvents alici_full_name As DataGridViewTextBoxColumn
    Friend WithEvents alici_tc As DataGridViewTextBoxColumn
    Friend WithEvents alici_tel As DataGridViewTextBoxColumn
    Friend WithEvents alici_type As DataGridViewTextBoxColumn
    Friend WithEvents alici_adres As DataGridViewTextBoxColumn
    Friend WithEvents alici_not As DataGridViewTextBoxColumn
    Friend WithEvents urun_type As DataGridViewTextBoxColumn
    Friend WithEvents urun_adet As DataGridViewTextBoxColumn
    Friend WithEvents urun_kg As DataGridViewTextBoxColumn
    Friend WithEvents toplam_ucret As DataGridViewTextBoxColumn
End Class
