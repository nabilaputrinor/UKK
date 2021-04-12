Public Class FrmLap

    Private Sub btnlapbrg_Click(sender As Object, e As EventArgs) Handles btnlapbrg.Click
        Dim lap_barang As New FrmLap_Brg
        lap_barang.TopLevel = False
        FrmMenu.PanelMenu.Controls.Add(lap_barang)
        lap_barang.Show()
    End Sub

    Private Sub btnlaphistory_Click(sender As Object, e As EventArgs) Handles btnlaphistory.Click
        Dim lap_history As New FrmLap_History
        lap_history.TopLevel = False
        FrmMenu.PanelMenu.Controls.Add(lap_history)
        lap_history.Show()
    End Sub

    Private Sub btnlaplelang_Click(sender As Object, e As EventArgs) Handles btnlaplelang.Click
        Dim lap_lelang As New FrmLap_Lelang
        lap_lelang.TopLevel = False
        FrmMenu.PanelMenu.Controls.Add(lap_lelang)
        lap_lelang.Show()
    End Sub
End Class