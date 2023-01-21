Public Class RadForm3

    Private Sub RadForm3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.Tithe' table. You can move, or remove it, as needed.
        Me.TitheTableAdapter.Fill(Me.Database1DataSet1.Tithe)
        'TODO: This line of code loads data into the 'MemDataDataSet1.aaaa' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'MemDataDataSet.Tithes' table. You can move, or remove it, as needed.
        '        On Error Resume Next
        'Me.TithesTableAdapter.Fill(Me.MemDataDataSet.Tithes)

    End Sub
End Class
