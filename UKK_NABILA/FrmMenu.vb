Public Class FrmMenu
    Dim konfirmasi As String

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Dim dathistory As New FrmDatHistory
        dathistory.TopLevel = False
        PanelMenu.Controls.Add(dathistory)
        dathistory.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim barang As New FrmBarang
        barang.TopLevel = False
        PanelMenu.Controls.Add(barang)
        barang.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim history As New FrmHistory
        history.TopLevel = False
        PanelMenu.Controls.Add(history)
        history.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim lelang As New FrmLelang
        lelang.TopLevel = False
        PanelMenu.Controls.Add(lelang)
        lelang.Show()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim laporan As New FrmLap
        laporan.TopLevel = False
        PanelMenu.Controls.Add(laporan)
        laporan.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim user As New FrmMasyarakat
        user.TopLevel = False
        PanelMenu.Controls.Add(user)
        user.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim petugas As New FrmPetugas
        petugas.TopLevel = False
        PanelMenu.Controls.Add(petugas)
        petugas.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        konfirmasi = MsgBox("Anda yakin ingin keluar..?", vbQuestion + vbYesNo, "Konfirmasi")
        If konfirmasi = vbYes Then
            Close()
        End If
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        Dim history As New FrmHistory
        history.TopLevel = False
        PanelMenu.Controls.Add(history)
        history.Show()
    End Sub
End Class