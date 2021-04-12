Imports System.Data.SqlClient
Public Class FrmLelang
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM lelang"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Lelang"
        DataGridView1.Columns(1).HeaderText = "ID Barang"
        DataGridView1.Columns(2).HeaderText = "Tanggal Lelang"
        DataGridView1.Columns(3).HeaderText = "Harga Akhir"
        DataGridView1.Columns(4).HeaderText = "ID User"
        DataGridView1.Columns(5).HeaderText = "ID Petugas"
        DataGridView1.Columns(6).HeaderText = "Status"

        DataGridView1.Columns(0).Width = 150
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(5).Width = 150
        DataGridView1.Columns(6).Width = 200
    End Sub

    Sub bersih()
        txtid_lelang.Text = ""
        txtid_brg.Text = ""
        txttgl.Text = ""
        txtharga.Text = ""
        txtid_user.Text = ""
        txtid_petugas.Text = ""
        cbstatus.Text = ""
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) as id_lelang FROM lelang"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_lelang").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid_lelang.Text = "IL-0" + Trim(Str(kodeauto))
            Case 2 : txtid_lelang.Text = "IL-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    Private Sub FrmLelang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-V1TU2TO\SQLEXPRESS;Initial Catalog=db_UKK_NABILA;Integrated Security=True"
        tampildata()
        txtid_lelang.Enabled = True
        relasi_barang()
        relasi_user()
        relasi_petugas()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        kodeotomatis()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtid_lelang.Text = "" Then
            MessageBox.Show("ID Wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid_lelang.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO lelang VALUES ('" & txtid_lelang.Text &
                "','" & txtid_brg.Text & "','" & txttgl.Text & "','" & txtharga.Text & "','" & txtid_user.Text & "','" & txtid_petugas.Text & "','" & cbstatus.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Pelelangan Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtid_lelang.Text = "" Then
            MessageBox.Show("ID  wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid_lelang.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE lelang SET id_barang  ='" & txtid_brg.Text & "', tgl_lelang ='" & txttgl.Text & "' ,harga_akhir ='" & txtharga.Text & "' ,id_user ='" & txtid_user.Text & "' , id_petugas ='" & txtid_petugas.Text & "' , status ='" & cbstatus.Text & "' WHERE id_lelang ='" & txtid_lelang.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Pelelangan Berhasil Terubah", MsgBoxStyle.Information)
            tampildata()
            txtid_lelang.Enabled = False
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim baris As Integer
        Dim id As String

        baris = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1(0, baris).Value.ToString

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE FROM lelang WHERE id_lelang = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Pelelangan Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM lelang WHERE id_lelang LIKE '%" & txtcari.Text & "%' OR id_barang LIKE '%" & txtcari.Text & "%' OR tgl_lelang LIKE '%" & txtcari.Text & "%' OR id_user LIKE '%" & txtcari.Text & "%' OR id_petugas LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid_lelang.Text = DataGridView1.SelectedCells(0).Value
        txtid_brg.Text = DataGridView1.SelectedCells(1).Value
        txttgl.Text = DataGridView1.SelectedCells(2).Value
        txtharga.Text = DataGridView1.SelectedCells(3).Value
        txtid_user.Text = DataGridView1.SelectedCells(4).Value
        txtid_petugas.Text = DataGridView1.SelectedCells(5).Value
        cbstatus.Text = DataGridView1.SelectedCells(6).Value
    End Sub

    Sub relasi_barang()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("select * from barang", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtid_brg.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtid_brg.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub txtid_brg_TextChanged(sender As Object, e As EventArgs) Handles txtid_brg.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select * from barang where id_barang = '" & txtid_brg.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub

    Sub relasi_user()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("select * from masyarakat", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtid_user.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtid_user.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub txtid_user_TextChanged(sender As Object, e As EventArgs) Handles txtid_user.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select * from masyarakat where id_user = '" & txtid_user.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub

    Sub relasi_petugas()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New SqlDataAdapter("select * from petugas", cn)
        da.Fill(dt)
        Dim r As DataRow
        txtid_petugas.AutoCompleteCustomSource.Clear()
        For Each r In dt.Rows
            txtid_petugas.AutoCompleteCustomSource.Add(r.Item(0).ToString)
        Next


    End Sub

    Private Sub txtid_petugas_TextChanged(sender As Object, e As EventArgs) Handles txtid_petugas.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select * from petugas where id_petugas = '" & txtid_petugas.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub
End Class