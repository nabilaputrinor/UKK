Imports System.Data.SqlClient
Public Class FrmPetugas
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM petugas"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Petugas"
        DataGridView1.Columns(1).HeaderText = "Nama Petugas"
        DataGridView1.Columns(2).HeaderText = "Username"
        DataGridView1.Columns(3).HeaderText = "Password"
        DataGridView1.Columns(4).HeaderText = "ID Level"

        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 215
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(4).Width = 200
    End Sub

    Sub bersih()
        txtid_petugas.Text = ""
        txtnama.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        txtid_level.Text = ""
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) as id_petugas FROM petugas"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_petugas").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid_petugas.Text = "IP-0" + Trim(Str(kodeauto))
            Case 2 : txtid_petugas.Text = "IP-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    Private Sub FrmPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-V1TU2TO\SQLEXPRESS;Initial Catalog=db_UKK_NABILA;Integrated Security=True"
        tampildata()
        txtid_petugas.Enabled = False
        relasi_level()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        kodeotomatis()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtid_petugas.Text = "" Then
            MessageBox.Show("ID Wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid_petugas.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO petugas VALUES ('" & txtid_petugas.Text &
                "','" & txtnama.Text & "','" & txtuser.Text & "','" & txtpass.Text & "','" & txtid_level.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Petugas Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtid_petugas.Text = "" Then
            MessageBox.Show("ID  wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid_petugas.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE petugas SET nama_petugas  ='" & txtnama.Text & "', username ='" & txtuser.Text & "' , password ='" & txtpass.Text & "' , id_level ='" & txtid_level.Text & "' WHERE id_petugas ='" & txtid_petugas.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data Petugas Berhasil Terubah", MsgBoxStyle.Information)
            tampildata()
            txtid_petugas.Enabled = False
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim baris As Integer
        Dim id As String

        baris = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1(0, baris).Value.ToString

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE FROM petugas WHERE id_petugas = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data Petugas Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM petugas WHERE id_petugas LIKE '%" & txtcari.Text & "%' OR nama_petugas LIKE '%" & txtcari.Text & "%' OR username LIKE '%" & txtcari.Text & "%' OR id_level LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid_petugas.Text = DataGridView1.SelectedCells(0).Value
        txtnama.Text = DataGridView1.SelectedCells(1).Value
        txtuser.Text = DataGridView1.SelectedCells(2).Value
        txtpass.Text = DataGridView1.SelectedCells(3).Value
        txtid_level.Text = DataGridView1.SelectedCells(4).Value
    End Sub

    Sub relasi_level()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("select * from level", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtid_level.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtid_level.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub txtid_level_TextChanged(sender As Object, e As EventArgs) Handles txtid_level.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "select * from level where id_level = '" & txtid_level.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub
End Class