Imports System.Runtime.Serialization
Imports System.IO
Imports System.Data.SqlServerCe

Public Class Tithes
    Public ds As New DataSet
    Public edit As DataSet
    Dim das As SqlCeDataAdapter
    Private Sub Tithes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Tithes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet9.Tithe' table. You can move, or remove it, as needed.
        'Me.TitheTableAdapter.Fill(Me.Database1DataSet9.Tithe)
        Dim cnn As New SqlCeConnection
        'Dim dt As New DataTable

        cnn.ConnectionString = My.Settings.Database1ConnectionString
        cnn.Open()
        das = New SqlCeDataAdapter("Select * from Tithe", cnn)
        das.Fill(ds)
        dgv5.DataSource = ds.Tables(0)
        cnn.Close()

     
    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'create command builder for updating records

        Try
            Dim cnn As New SqlCeConnection
            Dim dt As New DataTable
            Dim cmb As SqlCeCommandBuilder

            Dim ans As DialogResult
            ans = MsgBox("You have to finish updating all records before you proceed" & vbCrLf & "Proceed?", MsgBoxStyle.OkCancel)
            If ans = Windows.Forms.DialogResult.OK Then
                cnn.ConnectionString = My.Settings.Database1ConnectionString
                das = New SqlCeDataAdapter("Select * from Tithe", cnn)
                cnn.Open()
                cmb = New SqlCeCommandBuilder(das)
                edit = ds.GetChanges
                If edit IsNot Nothing Then
                    das.Update(edit)
                End If
                cnn.Close()
            End If
            Me.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & vbCrLf & "Please Close And Reopen Window To Make Updates", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            'For Each row As DataGridViewRow In dgv5.Rows
            '    For Each cel As DataGridViewCell In row.Cells
            '        If cel.Value = tbxSearch.Text Then
            '            MsgBox("")
            '            cel.Selected = True
            '        End If
            '    Next
            'Next

            Dim dgv As DataGridView = dgv5
            Dim temp As Integer = 0
            For i As Integer = 0 To dgv.RowCount - 1
                For j As Integer = 0 To dgv.ColumnCount - 1
                    If dgv.Rows(i).Cells(j).Value.ToString = tbxSearch.Text Then
                        dgv5.ClearSelection()
                        dgv.Rows(i).Selected = True
                        temp = 1
                        If temp = 0 Then
                            MsgBox("Record not found")
                        End If
                    End If
                Next
            Next

        Catch er As System.NullReferenceException

            'MsgBox(er.Message, MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub tbxSearch_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxSearch.Enter
        Me.AcceptButton = btnSearch
        If tbxSearch.Text = "SEARCH" Then
            tbxSearch.Text = ""
        End If
    End Sub

    Private Sub tbxSearch_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxSearch.Leave
        Me.AcceptButton = btnUpdate
    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            'Dim cnn As New SqlCeConnection
            'Dim dt As New DataTable
            'Dim da As SqlCeDataAdapter
            'Dim cmb As SqlCeCommandBuilder
            Dim id As String = dgv5.CurrentRow.Cells(0).Value
            Dim idx As Integer = dgv5.Rows.IndexOf(dgv5.SelectedRows(0))

            'cnn.ConnectionString = My.Settings.Database1ConnectionString
            'das = New SqlCeDataAdapter("DELETE FROM data1 WHERE CID='" + id, cnn)
            '    cnn.Open()
            'cmb = New SqlCeCommandBuilder(das)
            'edit = ds.GetChanges
            'If edit IsNot Nothing Then
            '    das.Update(edit)
            'End If
            '    cnn.Close()

            Dim con As New SqlCeConnection
            Dim cmd As New SqlCeCommand
            con.ConnectionString = My.Settings.Database1ConnectionString
            cmd.Connection = con

            If dgv5.SelectedRows.Count = 1 Then

                Dim ans As DialogResult
                ans = MsgBox("Are you sure want want to delete this record?", MsgBoxStyle.YesNo)
                If ans = Windows.Forms.DialogResult.Yes Then
                    cmd.CommandText = "DELETE FROM Tithe WHERE CID='" + id + "'"
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    dgv5.Rows.RemoveAt(idx)
                End If

            Else
                MsgBox("Please select a record to delete", MsgBoxStyle.Information)
            End If


            'a function to load selected ID in data entry form
        Catch ex As Exception

        End Try
    End Sub
End Class
