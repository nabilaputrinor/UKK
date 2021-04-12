Imports System.Data.SqlClient
Public Class FrmMasyarakat
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM masyarakat"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID User"
        DataGridView1.Columns(1).HeaderText = "Nama Lengkap"
        DataGridView1.Columns(2).HeaderText = "Username"
        DataGridView1.Columns(3).HeaderText = "Password"
        DataGridView1.Columns(4).HeaderText = "No. Telp"

        DataGridView1.Columns(0).Width = 200
        DataGridView1.Columns(1).Width = 250
        DataGridView1.Columns(2).Width = 250
        DataGridView1.Columns(3).Width = 250
        DataGridView1.Columns(4).Width = 250
    End Sub

    Sub bersih()
        txtid_user.Text = ""
        txtnama.Text = ""
        txtuser.Text = ""
        txtpass.Text = ""
        txttelp.Text = ""
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) as id_user FROM masyarakat"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_user").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid_user.Text = "IM-0" + Trim(Str(kodeauto))
            Case 2 : txtid_user.Text = "IM-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

    Private Sub FrmMasyarakat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-V1TU2TO\SQLEXPRESS;Initial Catalog=db_UKK_NABILA;Integrated Security=True"
        tampildata()
        txtid_user.Enabled = False
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        kodeotomatis()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtid_user.Text = "" Then
            MessageBox.Show("ID Wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid_user.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO masyarakat VALUES ('" & txtid_user.Text &
                "','" & txtnama.Text & "','" & txtuser.Text & "','" & txtpass.Text & "','" & txttelp.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data User Berhasil Tersimpan", MsgBoxStyle.Information)
            tampildata()
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtid_user.Text = "" Then
            MessageBox.Show("ID  wajib diisi, tidak boleh dikosongkan")
        ElseIf txtid_user.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE masyarakat SET nama_lengkap  ='" & txtnama.Text & "', username ='" & txtuser.Text & "' , password ='" & txtpass.Text & "' , telp ='" & txttelp.Text & "' WHERE id_user ='" & txtid_user.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data User Berhasil Terubah", MsgBoxStyle.Information)
            tampildata()
            txtid_user.Enabled = False
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim baris As Integer
        Dim id As String

        baris = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1(0, baris).Value.ToString

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE FROM masyarakat WHERE id_user = '" + id + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data User Berhasil Terhapus", MsgBoxStyle.Information)
        tampildata()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM masyarakat WHERE id_user LIKE '%" & txtcari.Text & "%' OR nama_lengkap LIKE '%" & txtcari.Text & "%' OR username LIKE '%" & txtcari.Text & "%' OR password LIKE '%" & txtcari.Text & "%' OR telp LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtid_user.Text = DataGridView1.SelectedCells(0).Value
        txtnama.Text = DataGridView1.SelectedCells(1).Value
        txtuser.Text = DataGridView1.SelectedCells(2).Value
        txtpass.Text = DataGridView1.SelectedCells(3).Value
        txttelp.Text = DataGridView1.SelectedCells(4).Value
    End Sub
End Class