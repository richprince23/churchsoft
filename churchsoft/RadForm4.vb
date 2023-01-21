Imports System.Data.SqlServerCe

Public Class RadForm4


    Private Sub tbxEnterAmount_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxEnterAmount.Enter
        If tbxEnterAmount.Text = "Enter Amount" Then
            tbxEnterAmount.Text = ""
        End If

    End Sub

    Private Sub tbxEnterAmount_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxEnterAmount.Leave
        If tbxEnterAmount.Text = "" Then
            tbxEnterAmount.Text = "Enter Amount"
        End If
    End Sub

    Private Sub RadForm4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet7.Tithe' table. You can move, or remove it, as needed.
        Me.TitheTableAdapter.Fill(Me.Database1DataSet7.Tithe)
        'TODO: This line of code loads data into the 'Database1DataSet6.data1' table. You can move, or remove it, as needed.
        Me.Data1TableAdapter2.Fill(Me.Database1DataSet6.data1)
       
        'auto year
        cbxYear.Text = Date.Today.Year


    End Sub
    Private Sub checkID()
        'check text length and automatically update name from id
        Try
            If tbxCID.TextLength = 9 Then

                Dim cn As New SqlCeConnection
                Dim cmmd As New SqlCeCommand
                cmmd.CommandText = ("SELECT * FROM data1 WHERE CID ='" + tbxCID.Text + "'")
                cmmd.Connection = cn
                cn.ConnectionString = My.Settings.Database1ConnectionString
                cn.Open()
                'reading data( searching and displaying)
                Dim rd As SqlCeDataReader = cmmd.ExecuteReader
                If rd.Read Then

                    lbName.Text = dgv1.CurrentRow.Cells(1).Value & " " & dgv1.CurrentRow.Cells(3).Value & " " & dgv1.CurrentRow.Cells(2).Value

                End If

                cn.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub checkPaid()
        'check for existing ID in Tithe
        Try
            If tbxCID.TextLength = 9 Then
                Dim cn As New SqlCeConnection
                Dim cmmd As New SqlCeCommand
                cmmd.CommandText = ("SELECT * FROM Tithe WHERE CID ='" + tbxCID.Text + "'")
                cmmd.Connection = cn
                cn.ConnectionString = My.Settings.Database1ConnectionString
                cn.Open()
                'reading data( searching and displaying)
                Dim rd As SqlCeDataReader = cmmd.ExecuteReader
                If rd.Read Then
                    For Each cl As DataGridViewCell In dgv2.CurrentRow.Cells

                        If cl.Value = "" Then
                            MsgBox("emptty cell")
                        End If
                    Next
                    'lbName.Text = dgv1.CurrentRow.Cells(1).Value & " " & dgv1.CurrentRow.Cells(3).Value & " " & dgv1.CurrentRow.Cells(2).Value
                Else
                    lbStatus.Text = "Sorry, There is NO paid tithe for user"
                End If
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tbxCID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxCID.Leave
       
    End Sub
    Private Sub chek()

    End Sub
    Private Sub tbxCID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbxCID.TextChanged
        checkID()
    End Sub

    Private Sub cbxChooseMonth_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxChooseMonth.Enter
        If cbxChooseMonth.Text = "Choose Month" Then
            cbxChooseMonth.Text = ""
        End If
    End Sub

    Private Sub cbxChooseMonth_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxChooseMonth.Leave
        If cbxChooseMonth.Text = "" Then
            cbxChooseMonth.Text = "Choose Month"
        End If
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        Try
            'Check if ID has ever paid 
            'check for paid months
            'Choose month and pay into selected month

            ' Check for Nulls before commanding
            For Each col As DataGridViewRow In dgv1.Rows
                For Each cel As DataGridViewCell In col.Cells
                    If cel.Value = tbxCID.Text Or cel.Value <> "" Then
                        If cbxYear.Text <> "" And cbxChooseMonth.Text <> "" And tbxEnterAmount.Text <> "" And IsNumeric(tbxEnterAmount.Text) Then

                            Dim conn As New SqlCeConnection(My.Settings.Database1ConnectionString)
                            Dim cmd As New SqlCeCommand
                            cmd.Connection = conn

                            ' Choose commandText with mathicng months

                            Dim mth As String = cbxChooseMonth.Text
                            Select Case mth
                                Case "January"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, January, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "February"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, February, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "March"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, March, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "April"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, April, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "May"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, May, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "June"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, June, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "July"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, July, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "August"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, August, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "September"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, September, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "October"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, October, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "November"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, November, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case "December"
                                    cmd.CommandText = "INSERT INTO Tithe" & "(CID, December, Year)" & "VALUES(@CID, @Amt, @Yr)"
                                    cmd.Parameters.AddWithValue("@CID", tbxCID.Text)
                                    cmd.Parameters.AddWithValue("@Amt", tbxEnterAmount.Text)
                                    cmd.Parameters.AddWithValue("@Yr", cbxYear.Text)

                                Case Else
                                    MsgBox("Please Select A Valid Month")
                            End Select

                            'execute insert command
                            conn.Open()
                            cmd.ExecuteNonQuery()
                            conn.Close()
                            lbStatus.Text = "Payment Successful!"

                        End If
                    End If
                Next
            Next
        Catch ex As SqlCeException
            ' MsgBox("Record already exists; to update it, open the Tithe List")
        Catch er As Exception

            lbStatus.Text = "Please recheck and fill all fields coreectly"
        End Try
    End Sub
End Class
