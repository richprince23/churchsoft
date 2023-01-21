<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShapedForm1
    Inherits Telerik.WinControls.UI.ShapedForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShapedForm1))
        Me.RoundRectShapeTitle = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.RadTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
        Me.EllipseShape1 = New Telerik.WinControls.EllipseShape()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvAll = New System.Windows.Forms.DataGridView()
        Me.CIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherNamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateofBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChurchOrganizationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfirmedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaptizedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaritalStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HometownDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentTownDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuburbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PicDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet13 = New churchsoft.Database1DataSet13()
        Me.Data1TableAdapter = New churchsoft.Database1DataSet13TableAdapters.data1TableAdapter()
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoundRectShapeTitle
        '
        Me.RoundRectShapeTitle.BottomLeftRounded = False
        Me.RoundRectShapeTitle.BottomRightRounded = False
        '
        'RadTitleBar1
        '
        Me.RadTitleBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadTitleBar1.Location = New System.Drawing.Point(1, 1)
        Me.RadTitleBar1.Name = "RadTitleBar1"
        '
        '
        '
        Me.RadTitleBar1.RootElement.ApplyShapeToControl = True
        Me.RadTitleBar1.RootElement.Shape = Me.RoundRectShapeTitle
        Me.RadTitleBar1.Size = New System.Drawing.Size(423, 23)
        Me.RadTitleBar1.TabIndex = 0
        Me.RadTitleBar1.TabStop = False
        Me.RadTitleBar1.Text = "SEARCH MEMBER ID"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(137, 223)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 1
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 2
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ENTER MEMBER ID"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(78, 126)
        Me.TextBox1.MaxLength = 9
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(287, 47)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvAll
        '
        Me.dgvAll.AllowUserToAddRows = False
        Me.dgvAll.AllowUserToDeleteRows = False
        Me.dgvAll.AutoGenerateColumns = False
        Me.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CIDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.OtherNamesDataGridViewTextBoxColumn, Me.DateofBirthDataGridViewTextBoxColumn, Me.ChurchOrganizationDataGridViewTextBoxColumn, Me.ConfirmedDataGridViewTextBoxColumn, Me.BaptizedDataGridViewTextBoxColumn, Me.MaritalStatusDataGridViewTextBoxColumn, Me.MotherDataGridViewTextBoxColumn, Me.FatherDataGridViewTextBoxColumn, Me.HometownDataGridViewTextBoxColumn, Me.CurrentTownDataGridViewTextBoxColumn, Me.SuburbDataGridViewTextBoxColumn, Me.PicDataGridViewImageColumn, Me.SexDataGridViewTextBoxColumn, Me.DbDataGridViewTextBoxColumn})
        Me.dgvAll.DataSource = Me.Data1BindingSource
        Me.dgvAll.Location = New System.Drawing.Point(289, 189)
        Me.dgvAll.Name = "dgvAll"
        Me.dgvAll.ReadOnly = True
        Me.dgvAll.Size = New System.Drawing.Size(67, 63)
        Me.dgvAll.TabIndex = 4
        Me.dgvAll.Visible = False
        '
        'CIDDataGridViewTextBoxColumn
        '
        Me.CIDDataGridViewTextBoxColumn.DataPropertyName = "CID"
        Me.CIDDataGridViewTextBoxColumn.HeaderText = "CID"
        Me.CIDDataGridViewTextBoxColumn.Name = "CIDDataGridViewTextBoxColumn"
        Me.CIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OtherNamesDataGridViewTextBoxColumn
        '
        Me.OtherNamesDataGridViewTextBoxColumn.DataPropertyName = "Other_Names"
        Me.OtherNamesDataGridViewTextBoxColumn.HeaderText = "Other_Names"
        Me.OtherNamesDataGridViewTextBoxColumn.Name = "OtherNamesDataGridViewTextBoxColumn"
        Me.OtherNamesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateofBirthDataGridViewTextBoxColumn
        '
        Me.DateofBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Birth"
        Me.DateofBirthDataGridViewTextBoxColumn.HeaderText = "Date_of_Birth"
        Me.DateofBirthDataGridViewTextBoxColumn.Name = "DateofBirthDataGridViewTextBoxColumn"
        Me.DateofBirthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChurchOrganizationDataGridViewTextBoxColumn
        '
        Me.ChurchOrganizationDataGridViewTextBoxColumn.DataPropertyName = "Church_Organization"
        Me.ChurchOrganizationDataGridViewTextBoxColumn.HeaderText = "Church_Organization"
        Me.ChurchOrganizationDataGridViewTextBoxColumn.Name = "ChurchOrganizationDataGridViewTextBoxColumn"
        Me.ChurchOrganizationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConfirmedDataGridViewTextBoxColumn
        '
        Me.ConfirmedDataGridViewTextBoxColumn.DataPropertyName = "Confirmed"
        Me.ConfirmedDataGridViewTextBoxColumn.HeaderText = "Confirmed"
        Me.ConfirmedDataGridViewTextBoxColumn.Name = "ConfirmedDataGridViewTextBoxColumn"
        Me.ConfirmedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BaptizedDataGridViewTextBoxColumn
        '
        Me.BaptizedDataGridViewTextBoxColumn.DataPropertyName = "Baptized"
        Me.BaptizedDataGridViewTextBoxColumn.HeaderText = "Baptized"
        Me.BaptizedDataGridViewTextBoxColumn.Name = "BaptizedDataGridViewTextBoxColumn"
        Me.BaptizedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaritalStatusDataGridViewTextBoxColumn
        '
        Me.MaritalStatusDataGridViewTextBoxColumn.DataPropertyName = "Marital_Status"
        Me.MaritalStatusDataGridViewTextBoxColumn.HeaderText = "Marital_Status"
        Me.MaritalStatusDataGridViewTextBoxColumn.Name = "MaritalStatusDataGridViewTextBoxColumn"
        Me.MaritalStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MotherDataGridViewTextBoxColumn
        '
        Me.MotherDataGridViewTextBoxColumn.DataPropertyName = "Mother"
        Me.MotherDataGridViewTextBoxColumn.HeaderText = "Mother"
        Me.MotherDataGridViewTextBoxColumn.Name = "MotherDataGridViewTextBoxColumn"
        Me.MotherDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FatherDataGridViewTextBoxColumn
        '
        Me.FatherDataGridViewTextBoxColumn.DataPropertyName = "Father"
        Me.FatherDataGridViewTextBoxColumn.HeaderText = "Father"
        Me.FatherDataGridViewTextBoxColumn.Name = "FatherDataGridViewTextBoxColumn"
        Me.FatherDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HometownDataGridViewTextBoxColumn
        '
        Me.HometownDataGridViewTextBoxColumn.DataPropertyName = "Hometown"
        Me.HometownDataGridViewTextBoxColumn.HeaderText = "Hometown"
        Me.HometownDataGridViewTextBoxColumn.Name = "HometownDataGridViewTextBoxColumn"
        Me.HometownDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrentTownDataGridViewTextBoxColumn
        '
        Me.CurrentTownDataGridViewTextBoxColumn.DataPropertyName = "Current_Town"
        Me.CurrentTownDataGridViewTextBoxColumn.HeaderText = "Current_Town"
        Me.CurrentTownDataGridViewTextBoxColumn.Name = "CurrentTownDataGridViewTextBoxColumn"
        Me.CurrentTownDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuburbDataGridViewTextBoxColumn
        '
        Me.SuburbDataGridViewTextBoxColumn.DataPropertyName = "Suburb"
        Me.SuburbDataGridViewTextBoxColumn.HeaderText = "Suburb"
        Me.SuburbDataGridViewTextBoxColumn.Name = "SuburbDataGridViewTextBoxColumn"
        Me.SuburbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PicDataGridViewImageColumn
        '
        Me.PicDataGridViewImageColumn.DataPropertyName = "pic"
        Me.PicDataGridViewImageColumn.HeaderText = "pic"
        Me.PicDataGridViewImageColumn.Name = "PicDataGridViewImageColumn"
        Me.PicDataGridViewImageColumn.ReadOnly = True
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DbDataGridViewTextBoxColumn
        '
        Me.DbDataGridViewTextBoxColumn.DataPropertyName = "db"
        Me.DbDataGridViewTextBoxColumn.HeaderText = "db"
        Me.DbDataGridViewTextBoxColumn.Name = "DbDataGridViewTextBoxColumn"
        Me.DbDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Data1BindingSource
        '
        Me.Data1BindingSource.DataMember = "data1"
        Me.Data1BindingSource.DataSource = Me.Database1DataSet13
        '
        'Database1DataSet13
        '
        Me.Database1DataSet13.DataSetName = "Database1DataSet13"
        Me.Database1DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Data1TableAdapter
        '
        Me.Data1TableAdapter.ClearBeforeFill = True
        '
        'ShapedForm1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(425, 304)
        Me.Controls.Add(Me.dgvAll)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.RadTitleBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShapedForm1"
        Me.Shape = Me.EllipseShape1
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEARCH MEMBER ID"
        Me.ThemeName = "ControlDefault"
        CType(Me.RadTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RoundRectShapeTitle As Telerik.WinControls.RoundRectShape
    Friend WithEvents RadTitleBar1 As Telerik.WinControls.UI.RadTitleBar
    Friend WithEvents EllipseShape1 As Telerik.WinControls.EllipseShape
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgvAll As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet13 As churchsoft.Database1DataSet13
    Friend WithEvents Data1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Data1TableAdapter As churchsoft.Database1DataSet13TableAdapters.data1TableAdapter
    Friend WithEvents CIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherNamesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateofBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChurchOrganizationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfirmedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BaptizedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaritalStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MotherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FatherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HometownDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentTownDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuburbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PicDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

