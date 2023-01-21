Imports System.Drawing
Imports System.Data.SqlServerCe
Imports System.IO

Public Class RadForm2

    Public ds As New DataSet
    Public edit As DataSet
    Dim das As SqlCeDataAdapter

    Private Sub RadForm2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet14.data1' table. You can move, or remove it, as needed.
        Me.Data1TableAdapter1.Fill(Me.Database1DataSet14.data1)
        'TODO: This line of code loads data into the 'Database1DataSet2.data1' table. You can move, or remove it, as needed.
        Me.Data1TableAdapter.Fill(Me.Database1DataSet2.data1)
        DataGridView1.AutoResizeColumns()
    End Sub

    Private Sub PrintListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintListToolStripMenuItem.Click
        PrtDoc.Print()
    End Sub

    Private Sub PrtDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrtDoc.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click

        ' a function to load selected ID in data entry form
        Try
            Dim cn As New SqlCeConnection
            Dim cmmd As New SqlCeCommand
            Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
            If DataGridView1.SelectedRows.Count = 1 Then
                cmmd.CommandText = ("SELECT * FROM data1 WHERE CID ='" + id + "'")
                cmmd.Connection = cn
                cn.ConnectionString = My.Settings.Database1ConnectionString
                cn.Open()
                'reading data (searching and displaying)
                Dim rd As SqlCeDataReader = cmmd.ExecuteReader
                If rd.Read Then
                    RadForm1.Show()
                    RadForm1.btnSv.Enabled = False
                    RadForm1.btnUpd.Enabled = True
                    With RadForm1
                        .txtID.Text = DataGridView1.CurrentRow.Cells(0).Value
                        .txtSn.Text = DataGridView1.CurrentRow.Cells(1).Value
                        .txtFn.Text = DataGridView1.CurrentRow.Cells(2).Value
                        .txtOn.Text = DataGridView1.CurrentRow.Cells(3).Value
                        .mtbDOB.Text = DataGridView1.CurrentRow.Cells(4).Value
                        .cbSx.Text = DataGridView1.CurrentRow.Cells(15).Value
                        .cbChO.Text = DataGridView1.CurrentRow.Cells(5).Value
                        .cbCf.Text = DataGridView1.CurrentRow.Cells(6).Value
                        .cbBp.Text = DataGridView1.CurrentRow.Cells(7).Value
                        .cbMS.Text = DataGridView1.CurrentRow.Cells(8).Value
                        .txtMom.Text = DataGridView1.CurrentRow.Cells(9).Value
                        .txtDad.Text = DataGridView1.CurrentRow.Cells(10).Value
                        .txtHt.Text = DataGridView1.CurrentRow.Cells(11).Value
                        .txtCt.Text = DataGridView1.CurrentRow.Cells(12).Value
                        .txtSb.Text = DataGridView1.CurrentRow.Cells(13).Value
                        .cbDb.Text = DataGridView1.CurrentRow.Cells(16).Value

                        Dim imageData As Byte() = DirectCast(rd("pic"), Byte())
                        Dim ms As New MemoryStream(imageData)
                        'TextBox1.Text = dgvAll.CurrentCell.Value
                        .pcbx1.Image = Image.FromStream(ms)

                    End With
                End If
                rd.Close()
                Me.Close()
                cn.Close()

            Else
                MsgBox("Please select a record to update", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            'Dim cnn As New SqlCeConnection
            'Dim dt As New DataTable
            'Dim da As SqlCeDataAdapter
            'Dim cmb As SqlCeCommandBuilder
            Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
            Dim idx As Integer = DataGridView1.Rows.IndexOf(DataGridView1.SelectedRows(0))

            Dim con As New SqlCeConnection
            Dim cmd As New SqlCeCommand
            con.ConnectionString = My.Settings.Database1ConnectionString
            cmd.Connection = con
            If DataGridView1.SelectedRows.Count = 1 Then

                Dim ans As DialogResult
                ans = MsgBox("Are you sure want want to delete this record?", MsgBoxStyle.YesNo)
                If ans = Windows.Forms.DialogResult.Yes Then
                    cmd.CommandText = "DELETE FROM data1 WHERE CID='" + id + "'"
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    DataGridView1.Rows.RemoveAt(idx)
                End If
            Else
                MsgBox("Please select a record to delete", MsgBoxStyle.Information)
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub NewRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewRecordToolStripMenuItem.Click
        RadForm1.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
