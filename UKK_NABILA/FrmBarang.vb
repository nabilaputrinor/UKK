Imports System.Data.SqlClient
Public Class FrmBarang
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM barang"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Barang"
        DataGridView1.Columns(1).HeaderText = "Nama Barang"
        DataGridView1.Columns(2).HeaderText = "Tanggal"
        DataGridView1.Columns(3).HeaderText = "Harga Awal"
        DataGridView1.Columns(4).HeaderText = "Deskripsi Barang"

        DataGridView1.Columns(0).Width = 150
        DataGridView1.Columns(1).Width = 500
        DataGridView1.Columns(2).Width = 285
        DataGridView1.Columns(3).Width = 285
        DataGridView1.Columns(4).Width = 500
    End Sub

    Sub bersih()
        txtid_brg.Text = ""
        txtnama_brg.Text = ""
        txttgl.Text = ""
        txtharga.Text = ""
        txtdesk.Text = ""
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) as id_barang FROM barang"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_barang").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid_brg.Text = "IB-0" + Trim(Str(kodeauto))
            Case 2 : txtid_brg.Text = "IB-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    Private Sub FrmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-V1TU2TO\SQLEXPRESS;Initial Catalog=db_UKK_NABILA;Integrated Security=True"
        tampildata()
        txtid_brg.Enabled = False
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        kodeotomatis()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtid_brg.Text = "" Then
            MessageBox.Show("ID Wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid_brg.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO barang VALUES ('" & txtid_brg.Text &
                "','" & txtnama_brg.Text & "','" & txttgl.Text & "','" & txtharga.Text & "','" & txtdesk.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Barang Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Public Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtid_brg.Text = "" Then
            MessageBox.Show("ID  wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid_brg.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE barang SET nama_barang  ='" & txtnama_brg.Text & "', tgl ='" & txttgl.Text & "' , harga_awal ='" & txtharga.Text & "' , desk_barang ='" & txtdesk.Text & "' WHERE id_barang ='" & txtid_brg.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Barang Berhasil Terubah", MsgBoxStyle.Information)
            tampildata()
            txtid_brg.Enabled = False
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim baris As Integer
        Dim id As String

        baris = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1(0, baris).Value.ToString

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE FROM barang WHERE id_barang = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Barang Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM barang WHERE id_barang LIKE '%" & txtcari.Text & "%' OR nama_barang LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid_brg.Text = DataGridView1.SelectedCells(0).Value
        txtnama_brg.Text = DataGridView1.SelectedCells(1).Value
        txttgl.Text = DataGridView1.SelectedCells(2).Value
        txtharga.Text = DataGridView1.SelectedCells(3).Value
        txtdesk.Text = DataGridView1.SelectedCells(4).Value
    End Sub
End Class