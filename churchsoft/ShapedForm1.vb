Imports System.Data.SqlServerCe
Imports System.IO

Public Class ShapedForm1

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Dim cn As New SqlCeConnection
            Dim cmmd As New SqlCeCommand
            cmmd.CommandText = ("SELECT * FROM data1 WHERE CID ='" + TextBox1.Text + "'")
            cmmd.Connection = cn
            cn.ConnectionString = My.Settings.Database1ConnectionString
            cn.Open()
            'reading data (searching and displaying)
            Dim rd As SqlCeDataReader = cmmd.ExecuteReader
            If rd.Read Then
                For Each rw As DataGridViewRow In dgvAll.Rows
                    For Each cel As DataGridViewCell In rw.Cells
                        If cel.Value = TextBox1.Text Then
                            Dim idx As Integer = rw.Index
                            rw.Selected = True
                            RadForm1.Show()
                            RadForm1.btnSv.Enabled = False
                            RadForm1.btnUpd.Enabled = True
                            With RadForm1
                                .txtID.Text = dgvAll.CurrentRow.Cells(0).Value
                                .txtSn.Text = dgvAll.CurrentRow.Cells(1).Value
                                .txtFn.Text = dgvAll.CurrentRow.Cells(2).Value
                                .txtOn.Text = dgvAll.CurrentRow.Cells(3).Value
                                .mtbDOB.Text = dgvAll.CurrentRow.Cells(4).Value
                                .cbSx.Text = dgvAll.CurrentRow.Cells(15).Value
                                .cbChO.Text = dgvAll.CurrentRow.Cells(5).Value
                                .cbCf.Text = dgvAll.CurrentRow.Cells(6).Value
                                .cbBp.Text = dgvAll.CurrentRow.Cells(7).Value
                                .cbMS.Text = dgvAll.CurrentRow.Cells(8).Value
                                .txtMom.Text = dgvAll.CurrentRow.Cells(9).Value
                                .txtDad.Text = dgvAll.CurrentRow.Cells(10).Value
                                .txtHt.Text = dgvAll.CurrentRow.Cells(11).Value
                                .txtCt.Text = dgvAll.CurrentRow.Cells(12).Value
                                .txtSb.Text = dgvAll.CurrentRow.Cells(13).Value
                                .cbDb.Text = dgvAll.CurrentRow.Cells(16).Value

                                Dim imageData As Byte() = DirectCast(rd("pic"), Byte())
                                Dim ms As New MemoryStream(imageData)
                                'TextBox1.Text = dgvAll.CurrentCell.Value
                                .pcbx1.Image = Image.FromStream(ms)

                            End With
                        End If


                    Next
                Next
            Else
                MsgBox("No Records Found!", MsgBoxStyle.Information)
            End If
            rd.Close()
            cn.Close()
        Catch ex As Exception
        End Try
        Me.Close()
    End Sub

    Private Sub ShapedForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet13.data1' table. You can move, or remove it, as needed.
        Me.Data1TableAdapter.Fill(Me.Database1DataSet13.data1)

    End Sub

End Class
