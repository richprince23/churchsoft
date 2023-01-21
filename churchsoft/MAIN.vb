Public Class MAIN

    Private Sub RadTileElement1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDE.Click
        RadForm1.Show()
        RadForm1.btnUpd.Enabled = False
        RadForm1.btnSv.Enabled = True

    End Sub

    Private Sub RadTileElement8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEX.Click
        Application.Exit()

    End Sub

    Private Sub RadTileElement7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDL.Click
        RadForm2.Show()

    End Sub

    Private Sub bntUPIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntUPIn.Click
        ShapedForm1.Show()
        'RadForm1.btnUpd.Enabled = True
        'RadForm1.btnSv.Enabled = False

    End Sub

    Private Sub MAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTH.Click
        RadForm4.Show()
    End Sub

    Private Sub btnTList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTList.Click
        ' Tithes_List.Show()
        Tithes.Show()
    End Sub

    Private Sub btnMz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMz.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        AboutBox1.Show()
    End Sub
End Class
