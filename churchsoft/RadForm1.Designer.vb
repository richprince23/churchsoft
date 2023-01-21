<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadForm1))
        Me.btnSv = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnUpd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLdPc = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCnl = New System.Windows.Forms.Button()
        Me.txtFn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbDb = New System.Windows.Forms.ComboBox()
        Me.txtSn = New System.Windows.Forms.TextBox()
        Me.cbBp = New System.Windows.Forms.ComboBox()
        Me.cbCf = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMom = New System.Windows.Forms.TextBox()
        Me.pcbx1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtSb = New System.Windows.Forms.TextBox()
        Me.txtCt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtHt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOn = New System.Windows.Forms.TextBox()
        Me.btnRtL = New System.Windows.Forms.Button()
        Me.btnRtR = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.cbMS = New System.Windows.Forms.ComboBox()
        Me.cbSx = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbChO = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mtbDOB = New System.Windows.Forms.MaskedTextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PrtDoc1 = New System.Drawing.Printing.PrintDocument()
        Me.pgSetup1 = New System.Windows.Forms.PageSetupDialog()
        Me.ppvDg1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.cmsPrintOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDirectlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pcbx1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsPrintOptions.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSv
        '
        Me.btnSv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSv.Location = New System.Drawing.Point(364, 649)
        Me.btnSv.Name = "btnSv"
        Me.btnSv.Size = New System.Drawing.Size(100, 46)
        Me.btnSv.TabIndex = 16
        Me.btnSv.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.btnSv, "Save data.")
        Me.btnSv.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(551, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 24)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Dayborn"
        '
        'btnUpd
        '
        Me.btnUpd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpd.Location = New System.Drawing.Point(548, 649)
        Me.btnUpd.Name = "btnUpd"
        Me.btnUpd.Size = New System.Drawing.Size(100, 46)
        Me.btnUpd.TabIndex = 17
        Me.btnUpd.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.btnUpd, "Update existing data.")
        Me.btnUpd.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 395)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Mother"
        '
        'btnLdPc
        '
        Me.btnLdPc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLdPc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLdPc.Location = New System.Drawing.Point(1031, 253)
        Me.btnLdPc.Name = "btnLdPc"
        Me.btnLdPc.Size = New System.Drawing.Size(75, 28)
        Me.btnLdPc.TabIndex = 0
        Me.btnLdPc.Text = "Browse"
        Me.ToolTip1.SetToolTip(Me.btnLdPc, "Load picture")
        Me.btnLdPc.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Other names"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Surname"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 462)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Father"
        '
        'btnCnl
        '
        Me.btnCnl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCnl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCnl.Location = New System.Drawing.Point(733, 649)
        Me.btnCnl.Name = "btnCnl"
        Me.btnCnl.Size = New System.Drawing.Size(100, 46)
        Me.btnCnl.TabIndex = 18
        Me.btnCnl.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.btnCnl, "Cancel and close")
        Me.btnCnl.UseVisualStyleBackColor = True
        '
        'txtFn
        '
        Me.txtFn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFn.Location = New System.Drawing.Point(207, 97)
        Me.txtFn.Name = "txtFn"
        Me.txtFn.Size = New System.Drawing.Size(216, 20)
        Me.txtFn.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtFn, "Fisrtname")
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Date of Birth"
        '
        'cbDb
        '
        Me.cbDb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbDb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbDb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDb.FormattingEnabled = True
        Me.cbDb.Items.AddRange(New Object() {"SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY"})
        Me.cbDb.Location = New System.Drawing.Point(679, 153)
        Me.cbDb.Name = "cbDb"
        Me.cbDb.Size = New System.Drawing.Size(143, 21)
        Me.cbDb.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.cbDb, "Day born")
        '
        'txtSn
        '
        Me.txtSn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSn.Location = New System.Drawing.Point(207, 52)
        Me.txtSn.Name = "txtSn"
        Me.txtSn.Size = New System.Drawing.Size(216, 20)
        Me.txtSn.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtSn, "Surname")
        '
        'cbBp
        '
        Me.cbBp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbBp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBp.FormattingEnabled = True
        Me.cbBp.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbBp.Location = New System.Drawing.Point(679, 229)
        Me.cbBp.Name = "cbBp"
        Me.cbBp.Size = New System.Drawing.Size(143, 21)
        Me.cbBp.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.cbBp, "Baptized")
        '
        'cbCf
        '
        Me.cbCf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCf.FormattingEnabled = True
        Me.cbCf.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbCf.Location = New System.Drawing.Point(206, 292)
        Me.cbCf.Name = "cbCf"
        Me.cbCf.Size = New System.Drawing.Size(168, 21)
        Me.cbCf.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.cbCf, "Confirmed")
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Church Organisation"
        '
        'txtMom
        '
        Me.txtMom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMom.Location = New System.Drawing.Point(206, 400)
        Me.txtMom.Name = "txtMom"
        Me.txtMom.Size = New System.Drawing.Size(269, 20)
        Me.txtMom.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.txtMom, "Name of mother")
        '
        'pcbx1
        '
        Me.pcbx1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pcbx1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbx1.Location = New System.Drawing.Point(961, 47)
        Me.pcbx1.Name = "pcbx1"
        Me.pcbx1.Size = New System.Drawing.Size(200, 200)
        Me.pcbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbx1.TabIndex = 0
        Me.pcbx1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Confirmed"
        '
        'txtDad
        '
        Me.txtDad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDad.Location = New System.Drawing.Point(206, 462)
        Me.txtDad.Name = "txtDad"
        Me.txtDad.Size = New System.Drawing.Size(269, 20)
        Me.txtDad.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtDad, "Name of father")
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Marital Status"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(551, 369)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Hometown"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(551, 417)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 24)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Current Town"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(551, 462)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 24)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Suburb"
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(521, 565)
        Me.txtID.MaxLength = 9
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(163, 38)
        Me.txtID.TabIndex = 0
        Me.txtID.TabStop = False
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSb
        '
        Me.txtSb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSb.Location = New System.Drawing.Point(733, 462)
        Me.txtSb.Name = "txtSb"
        Me.txtSb.Size = New System.Drawing.Size(331, 20)
        Me.txtSb.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.txtSb, "Suburb of current town")
        '
        'txtCt
        '
        Me.txtCt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCt.Location = New System.Drawing.Point(733, 417)
        Me.txtCt.Name = "txtCt"
        Me.txtCt.Size = New System.Drawing.Size(331, 20)
        Me.txtCt.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.txtCt, "Current Town")
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(392, 575)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 24)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Member ID"
        '
        'txtHt
        '
        Me.txtHt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHt.Location = New System.Drawing.Point(733, 369)
        Me.txtHt.Name = "txtHt"
        Me.txtHt.Size = New System.Drawing.Size(331, 20)
        Me.txtHt.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txtHt, "Hometown or Place of birth")
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(551, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Baptized"
        '
        'txtOn
        '
        Me.txtOn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOn.Location = New System.Drawing.Point(207, 143)
        Me.txtOn.Name = "txtOn"
        Me.txtOn.Size = New System.Drawing.Size(216, 20)
        Me.txtOn.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtOn, "Other names")
        '
        'btnRtL
        '
        Me.btnRtL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRtL.Enabled = False
        Me.btnRtL.Location = New System.Drawing.Point(1090, 308)
        Me.btnRtL.Name = "btnRtL"
        Me.btnRtL.Size = New System.Drawing.Size(27, 21)
        Me.btnRtL.TabIndex = 19
        Me.btnRtL.TabStop = False
        Me.btnRtL.Text = "L"
        Me.ToolTip1.SetToolTip(Me.btnRtL, "Rotate Left")
        Me.btnRtL.UseVisualStyleBackColor = True
        '
        'btnRtR
        '
        Me.btnRtR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRtR.Enabled = False
        Me.btnRtR.Location = New System.Drawing.Point(1031, 308)
        Me.btnRtR.Name = "btnRtR"
        Me.btnRtR.Size = New System.Drawing.Size(28, 21)
        Me.btnRtR.TabIndex = 19
        Me.btnRtR.TabStop = False
        Me.btnRtR.Text = "R"
        Me.ToolTip1.SetToolTip(Me.btnRtR, "Rotate Right")
        Me.btnRtR.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'cbMS
        '
        Me.cbMS.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbMS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMS.FormattingEnabled = True
        Me.cbMS.Items.AddRange(New Object() {"SINGLE", "MARRIED", "DIVORCED", "WIDOWED"})
        Me.cbMS.Location = New System.Drawing.Point(206, 242)
        Me.cbMS.Name = "cbMS"
        Me.cbMS.Size = New System.Drawing.Size(168, 21)
        Me.cbMS.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.cbMS, "Marital status")
        '
        'cbSx
        '
        Me.cbSx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbSx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbSx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbSx.FormattingEnabled = True
        Me.cbSx.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbSx.Location = New System.Drawing.Point(679, 79)
        Me.cbSx.Name = "cbSx"
        Me.cbSx.Size = New System.Drawing.Size(143, 21)
        Me.cbSx.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.cbSx, "Sex")
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(551, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 24)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Sex"
        '
        'cbChO
        '
        Me.cbChO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbChO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbChO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbChO.FormattingEnabled = True
        Me.cbChO.Items.AddRange(New Object() {"MEN'S FELLOWSHIP", "WOMEN'S FELLOWSHIP", "YOUTH FELLOWSHIP", "GUILD", "SUWMA", "BRIGADE", "CHOIR", "SINGING BAND", "CHRIST'S LITTLE BAND", "NONE"})
        Me.cbChO.Location = New System.Drawing.Point(206, 345)
        Me.cbChO.Name = "cbChO"
        Me.cbChO.Size = New System.Drawing.Size(269, 21)
        Me.cbChO.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.cbChO, "Church organization")
        '
        'mtbDOB
        '
        Me.mtbDOB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtbDOB.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbDOB.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.mtbDOB.Location = New System.Drawing.Point(207, 186)
        Me.mtbDOB.Mask = "00/00/0000"
        Me.mtbDOB.Name = "mtbDOB"
        Me.mtbDOB.Size = New System.Drawing.Size(168, 29)
        Me.mtbDOB.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.mtbDOB, "Date of birth")
        Me.mtbDOB.ValidatingType = GetType(Date)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PrtDoc1
        '
        '
        'ppvDg1
        '
        Me.ppvDg1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppvDg1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppvDg1.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppvDg1.Enabled = True
        Me.ppvDg1.Icon = CType(resources.GetObject("ppvDg1.Icon"), System.Drawing.Icon)
        Me.ppvDg1.Name = "ppvDg1"
        Me.ppvDg1.Visible = False
        '
        'cmsPrintOptions
        '
        Me.cmsPrintOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PageSetupToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.PrintDirectlyToolStripMenuItem})
        Me.cmsPrintOptions.Name = "cmsPrintOptions"
        Me.cmsPrintOptions.Size = New System.Drawing.Size(144, 70)
        Me.cmsPrintOptions.Text = "PrintOptions"
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'PrintDirectlyToolStripMenuItem
        '
        Me.PrintDirectlyToolStripMenuItem.Name = "PrintDirectlyToolStripMenuItem"
        Me.PrintDirectlyToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintDirectlyToolStripMenuItem.Text = "Print Directly"
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 707)
        Me.ContextMenuStrip = Me.cmsPrintOptions
        Me.Controls.Add(Me.mtbDOB)
        Me.Controls.Add(Me.cbChO)
        Me.Controls.Add(Me.cbSx)
        Me.Controls.Add(Me.cbMS)
        Me.Controls.Add(Me.btnRtR)
        Me.Controls.Add(Me.btnRtL)
        Me.Controls.Add(Me.btnCnl)
        Me.Controls.Add(Me.btnUpd)
        Me.Controls.Add(Me.btnSv)
        Me.Controls.Add(Me.btnLdPc)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbBp)
        Me.Controls.Add(Me.cbCf)
        Me.Controls.Add(Me.cbDb)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtSb)
        Me.Controls.Add(Me.txtCt)
        Me.Controls.Add(Me.txtHt)
        Me.Controls.Add(Me.txtDad)
        Me.Controls.Add(Me.txtMom)
        Me.Controls.Add(Me.txtOn)
        Me.Controls.Add(Me.txtFn)
        Me.Controls.Add(Me.txtSn)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pcbx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "DATA ENTRY"
        CType(Me.pcbx1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsPrintOptions.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSv As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents btnUpd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnLdPc As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCnl As Button
    Friend WithEvents txtFn As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbDb As ComboBox
    Friend WithEvents txtSn As TextBox
    Friend WithEvents cbBp As ComboBox
    Friend WithEvents cbCf As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMom As TextBox
    Friend WithEvents pcbx1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtSb As TextBox
    Friend WithEvents txtCt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtHt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOn As TextBox
    Friend WithEvents btnRtL As Button
    Friend WithEvents btnRtR As Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents cbMS As System.Windows.Forms.ComboBox
    Friend WithEvents cbSx As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbChO As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents mtbDOB As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PrtDoc1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents pgSetup1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents ppvDg1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents cmsPrintOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDirectlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
