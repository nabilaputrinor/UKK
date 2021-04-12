Imports System.Data.SqlClient
Public Class FrmDatHistory
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM history"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID History"
        DataGridView1.Columns(1).HeaderText = "ID Lelang"
        DataGridView1.Columns(2).HeaderText = "ID Barang"
        DataGridView1.Columns(3).HeaderText = "ID User"
        DataGridView1.Columns(4).HeaderText = "Harga Penawar"

        DataGridView1.Columns(0).Width = 220
        DataGridView1.Columns(1).Width = 220
        DataGridView1.Columns(2).Width = 220
        DataGridView1.Columns(3).Width = 220
        DataGridView1.Columns(4).Width = 230
    End Sub

    Private Sub FrmDatHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=DESKTOP-V1TU2TO\SQLEXPRESS;Initial Catalog=db_UKK_NABILA;Integrated Security=True"
        tampildata()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM history WHERE id_history LIKE '%" & txtcari.Text & "%' OR id_barang LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub
End Class