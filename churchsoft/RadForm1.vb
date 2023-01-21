Imports System.Data.SqlServerCe
Imports System.IO
Imports System.Drawing.Printing

Public Class RadForm1
    Private num As Integer = 0


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLdPc.Click
        Using ofd As New OpenFileDialog
            With ofd
                .DefaultExt = "Pictures(* .png;*.bmp;*.jpg)|*.png;*.bmp;*.jpg"
                .FileName = ""
                Dim empty As String = ""
                .Filter = String.Format("Pictures(*.png;*.bmp;*.jpg)|{0}*.png;*.bmp;*.jpg", empty)

                If .ShowDialog = DialogResult.OK Then

                    pcbx1.Image = Image.FromFile(ofd.FileName)
                    btnRtL.Enabled = True
                    btnRtR.Enabled = True
                End If
            End With
        End Using
    End Sub

    Private Sub RadForm1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Num = num
        My.Settings.Save()
        
    End Sub

    Private Sub RadForm1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        num = My.Settings.Num
        Console.WriteLine(num)
        If btnSv.Enabled = False Then
            AcceptButton = btnSv
        Else
            AcceptButton = btnUpd
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSv.Click
        ' txtID.Text = 
        Try
            'check for null values
            If txtSn.Text <> "" And txtFn.Text <> "" And mtbDOB.MaskCompleted = True And cbSx.Text <> "" And cbDb.Text <> "" And _
                cbMS.Text <> "" And cbCf.Text <> "" And cbBp.Text <> "" And cbChO.Text <> "" And txtMom.Text <> "" And _
                txtDad.Text <> "" And txtHt.Text <> "" And txtCt.Text <> "" And txtSb.Text <> "" And btnRtL.Enabled = True And Not IsNothing(pcbx1.Image) Then

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ' IF NO NULL VALUES, CREATE ID AND SHOW IT IT TXTID

                num = num + 1

                If num.ToString.Length = 4 Then
                ElseIf num.ToString.Length = 3 Then
                    txtID.Text = "CID0" & num & txtSn.Text.ElementAt(0) & "" & txtFn.Text.ElementAt(0)
                    My.Settings.Num = num
                    My.Settings.Save()
                ElseIf num.ToString.Length = 2 Then
                    txtID.Text = "CID00" & num & txtSn.Text.ElementAt(0) & "" & txtFn.Text.ElementAt(0)
                    My.Settings.Num = num
                    My.Settings.Save()

                ElseIf num.ToString.Length = 1 Then
                    txtID.Text = "CID000" & num & txtSn.Text.ElementAt(0) & "" & txtFn.Text.ElementAt(0)
                    My.Settings.Num = num
                    My.Settings.Save()

                End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim con As New SqlCeConnection
                Dim cmd As New SqlCeCommand
                con.ConnectionString = My.Settings.Database1ConnectionString
                cmd.Connection = con
                cmd.CommandText = "INSERT INTO data1" & "(CID, Firstname, Surname, Other_Names, Date_of_Birth, Church_Organization, Confirmed, Baptized, Marital_Status, Mother, Father, Hometown, Current_Town, Suburb, pic, Sex, db)" _
                   & "VALUES(@cid, @fn, @sn, @on, @dob, @co, @cf, @bp, @ms, @mom, @dad, @ht, @ct, @sb, @pic, @sx, @db)"
                cmd.Parameters.AddWithValue("@cid", txtID.Text)
                cmd.Parameters.AddWithValue("@fn", txtFn.Text)
                cmd.Parameters.AddWithValue("@sn", txtSn.Text)
                cmd.Parameters.AddWithValue("@on", txtOn.Text)
                cmd.Parameters.AddWithValue("@dob", mtbDOB.Text)
                cmd.Parameters.AddWithValue("@co", cbChO.Text)
                cmd.Parameters.AddWithValue("@cf", cbCf.Text)
                cmd.Parameters.AddWithValue("@bp", cbBp.Text)
                cmd.Parameters.AddWithValue("@ms", cbMS.Text)
                cmd.Parameters.AddWithValue("@mom", txtMom.Text)
                cmd.Parameters.AddWithValue("@dad", txtDad.Text)
                cmd.Parameters.AddWithValue("@ht", txtHt.Text)
                cmd.Parameters.AddWithValue("@ct", txtCt.Text)
                cmd.Parameters.AddWithValue("@sb", txtSb.Text)
                cmd.Parameters.AddWithValue("@sx", cbSx.Text)
                cmd.Parameters.AddWithValue("@db", cbDb.Text)

                'ADD PIC
                Dim ms As New MemoryStream()
                pcbx1.Image.Save(ms, pcbx1.Image.RawFormat)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlCeParameter("@pic", SqlDbType.Image)
                p.Value = data
                cmd.Parameters.Add(p)



                ''EXECUTE SAVE COMMAND
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("ID IS : " & txtID.Text.ToString, MsgBoxStyle.Information, "Save Successful")
                con.Close()

                Me.Refresh()

            End If

        Catch ex As Exception
            MsgBox(ex.ToString & vbNewLine & "Please check and refill all fields")
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRtL.Click
        pcbx1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRtR.Click
        pcbx1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cbChO_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbChO.Leave
        If cbChO.Text.Length = 0 Then
            cbChO.Text = cbChO.Items.Item(9)

        End If
    End Sub

    Private Sub cbMS_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMS.Leave
        If Not cbMS.Items.Contains(cbMS.Text) Then
            ErrorProvider1.SetError(cbMS, "Please enter valid Status")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub cbSx_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSx.Leave
        If Not cbSx.Items.Contains(cbSx.Text) Then
            ErrorProvider1.SetError(cbSx, "Please enter valid Sex")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub cbDb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDb.Leave
        If Not cbDb.Items.Contains(cbDb.Text) Then
            ErrorProvider1.SetError(cbDb, "Please enter valid Day of birth")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub cbCf_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCf.Leave
        If Not cbCf.Items.Contains(cbCf.Text) Then
            ErrorProvider1.SetError(cbCf, "Please enter valid data")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub cbBp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBp.Leave
        If Not cbBp.Items.Contains(cbBp.Text) Then
            ErrorProvider1.SetError(cbBp, "Please enter valid data")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtSn_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSn.Leave
        If txtSn.Text = "" Then
            ErrorProvider1.SetError(txtSn, "Please enter valid name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub txtFn_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFn.Leave
        If txtFn.Text = "" Then
            ErrorProvider1.SetError(txtFn, "Please enter valid name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub mtbDOB_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtbDOB.Leave
        If Not mtbDOB.MaskCompleted Then
            ErrorProvider1.SetError(mtbDOB, "Please enter valid name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub btnCnl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCnl.Click
        Me.Close()
    End Sub

    Sub printSetup()
        With pgSetup1
            .Document = PrtDoc1
            .AllowPrinter = True
            .EnableMetric = True
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                pgSetup1.PageSettings = New System.Drawing.Printing.PageSettings
                pgSetup1.PrinterSettings = New PrinterSettings
            End If
        End With
    End Sub

    Private Sub PrtDoc1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrtDoc1.PrintPage
        PrintToGraphics(e.Graphics, e.MarginBounds)
    End Sub

    Sub PrintToGraphics(ByVal graphics As Graphics, ByVal bounds As Rectangle)
        Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))

        Dim pw, ph, pl, pt As Integer
        pw = bounds.Width
        ph = bounds.Height
        pl = bounds.Left
        pt = bounds.Top

        Dim tar As Rectangle = New Rectangle(pl, pt, pw, ph)
        Dim xsc As Double = bmp.Width / pw
        Dim ysc As Double = bmp.Height / ph

        If xsc < ysc Then
            tar.Width = Int(xsc * tar.Width / ysc)
        Else
            tar.Height = Int(ysc * tar.Height / xsc)
        End If
        graphics.PageUnit = GraphicsUnit.Display
        graphics.DrawImage(bmp, tar)
    End Sub

    Private Sub btnPr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click
        printSetup()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        ppvDg1.Document = PrtDoc1
        ppvDg1.ShowDialog()
    End Sub

    Private Sub PrintDirectlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDirectlyToolStripMenuItem.Click
        PrtDoc1.Print()
    End Sub

    Private Sub btnUpd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpd.Click
        Dim con As New SqlCeConnection
        Dim cmd As New SqlCeCommand
        con.ConnectionString = My.Settings.Database1ConnectionString
        cmd.Connection = con
        cmd.CommandText = "UPDATE data1 SET Surname = @sn, Firstname = @fn, Other_Names = @on, Date_of_Birth = @dob, Church_Organization = @co, Confirmed = @cf, Baptized = @bp, Marital_Status = @ms, Mother = @mom, Father = @dad, Hometown = @ht, Current_Town= @ct, Suburb = @sb, pic = @pic, Sex = @sx, db = @db WHERE CID = @cid"
        cmd.Parameters.AddWithValue("@cid", txtID.Text)
        cmd.Parameters.AddWithValue("@sn", txtSn.Text)
        cmd.Parameters.AddWithValue("@fn", txtFn.Text)
        cmd.Parameters.AddWithValue("@on", txtOn.Text)
        cmd.Parameters.AddWithValue("@dob", mtbDOB.Text)
        cmd.Parameters.AddWithValue("@co", cbChO.Text)
        cmd.Parameters.AddWithValue("@cf", cbCf.Text)
        cmd.Parameters.AddWithValue("@bp", cbBp.Text)
        cmd.Parameters.AddWithValue("@ms", cbMS.Text)
        cmd.Parameters.AddWithValue("@mom", txtMom.Text)
        cmd.Parameters.AddWithValue("@dad", txtDad.Text)
        cmd.Parameters.AddWithValue("@ht", txtHt.Text)
        cmd.Parameters.AddWithValue("@ct", txtCt.Text)
        cmd.Parameters.AddWithValue("@sb", txtSb.Text)
        cmd.Parameters.AddWithValue("@sx", cbSx.Text)
        cmd.Parameters.AddWithValue("@db", cbDb.Text)


        'cmd.Parameters.Add("@cid", SqlDbType.NVarChar, 100, "Fisrtname")
        '
        'ADD PIC
        Dim ms As New MemoryStream()
        pcbx1.Image.Save(ms, pcbx1.Image.RawFormat)
        Dim data As Byte() = ms.GetBuffer()
        Dim p As New SqlCeParameter("@pic", SqlDbType.Image)

        p.Value = data
        cmd.Parameters.Add(p)

        ''EXECUTE UPDATE COMMAND
        con.Open()
        cmd.ExecuteNonQuery()
        MsgBox("ID IS : " & txtID.Text.ToString, MsgBoxStyle.Information, "Update Successful")

        con.Close()
        ms.Close()

        Me.Refresh()


    End Sub
End Class
