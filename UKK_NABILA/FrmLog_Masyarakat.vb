Imports System.Data.SqlClient
Public Class FrmLog_Masyarakat
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
            cmd.CommandText = "SELECT * FROM masyarakat WHERE username ='" & txtuser.Text & "' AND password ='" & txtpass.Text & "'"
            rd = cmd.ExecuteReader
            If rd.Read() Then
                FrmMenu.Label1.Enabled = False
                FrmMenu.Label2.Enabled = False
                FrmMenu.Label3.Enabled = False
                FrmMenu.Label4.Enabled = False
                FrmMenu.Label5.Enabled = False
                FrmMenu.Label6.Enabled = False
                FrmMenu.Label7.Enabled = False
                FrmMenu.Label8.Enabled = False
                FrmMenu.Label9.Enabled = False
                FrmMenu.Label10.Enabled = False
                FrmMenu.Label11.Enabled = False
                FrmMenu.Label12.Enabled = False
                FrmMenu.Show()
            Else
                MsgBox("data tidak tersedia")
            End If


            rd.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox("Terjadi Kesalahan!" & ex.Message)
        End Try
        bersih()
    End Sub

    Private Sub FrmLog_Masyarakat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        FrmRegis.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        konfirmasi = MsgBox("Kembali ke tampilan awal..?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Close()
        End If
    End Sub
End Class