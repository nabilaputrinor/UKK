Imports System.Data.SqlClient
Public Class FrmRegis
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim konfirmasi As String

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

    Private Sub FrmRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-V1TU2TO\SQLEXPRESS;Initial Catalog=db_UKK_NABILA;Integrated Security=True"
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
            MsgBox("Data User Berhasil Tersimpan", MsgBoxStyle.Information)
            bersih()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        konfirmasi = MsgBox("Anda yakin ingin keluar..?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Close()
        End If
    End Sub
End Class