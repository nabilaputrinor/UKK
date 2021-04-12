Imports System.Data.SqlClient
Public Class FrmLog_Petugas
    Dim konfirmasi As String

    Sub bersih()
        txtuser.Text = ""
        txtpass.Text = ""
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            Dim cn As New SqlConnection
            Dim cmd As New SqlCommand
            Dim rd As SqlDataReader

            cn.ConnectionString = "Data Source=DESKTOP-V1TU2TO\SQLEXPRESS;Initial Catalog=db_UKK_NABILA;Integrated Security=True"
            cmd.Connection = cn
            cn.Open()
            cmd.CommandText = "SELECT * FROM petugas WHERE username ='" & txtuser.Text & "' AND password ='" & txtpass.Text & "'"
            rd = cmd.ExecuteReader
            rd.Read()
            If rd("id_level") = "LV-01" Then
                MsgBox("Hai, Jangan Lupa Bahagia", MsgBoxStyle.Information)
                FrmMenu.Label4.Enabled = False
                FrmMenu.Label5.Enabled = False
                FrmMenu.Label12.Enabled = False
                FrmMenu.Label10.Enabled = False
                FrmMenu.Show()
            ElseIf rd("id_level") = "LV-02" Then
                MsgBox("Hai Admin, Jangan Lupa Bahagia", MsgBoxStyle.Information)
                FrmMenu.Label2.Enabled = False
                FrmMenu.Label3.Enabled = False
                FrmMenu.Label8.Enabled = False
                FrmMenu.Label9.Enabled = False
                FrmMenu.Show()
            Else
                MsgBox("Nama Pengguna dan Kata Sandi Tidak Tersedia", MsgBoxStyle.Information)
                txtuser.Text = ""
                txtpass.Text = ""
            End If
            rd.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox("Terjadi Kesalahan!" & ex.Message)
        End Try
        bersih()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        konfirmasi = MsgBox("Kembali ke tampilan awal..?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Close()
        End If
    End Sub
End Class