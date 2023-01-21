<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadForm4))
        Me.lbEnterIDHere = New System.Windows.Forms.Label()
        Me.tbxCID = New System.Windows.Forms.TextBox()
        Me.lbChooseMonth = New System.Windows.Forms.Label()
        Me.lbAmount = New System.Windows.Forms.Label()
        Me.cbxChooseMonth = New System.Windows.Forms.ComboBox()
        Me.tbxEnterAmount = New System.Windows.Forms.TextBox()
        Me.lbChooseYear = New System.Windows.Forms.Label()
        Me.cbxYear = New System.Windows.Forms.ComboBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lbName = New System.Windows.Forms.Label()
        Me.Data1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet4 = New churchsoft.Database1DataSet4()
        Me.Data1TableAdapter = New churchsoft.Database1DataSet4TableAdapters.data1TableAdapter()
        Me.Database1DataSet2 = New churchsoft.Database1DataSet2()
        Me.Data1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data1TableAdapter1 = New churchsoft.Database1DataSet2TableAdapters.data1TableAdapter()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.CIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherNamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet6 = New churchsoft.Database1DataSet6()
        Me.Database1DataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data1TableAdapter2 = New churchsoft.Database1DataSet6TableAdapters.data1TableAdapter()
        Me.tbx1 = New System.Windows.Forms.TextBox()
        Me.Data1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.CIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JanuaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FebruaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AprilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JuneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JulyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AugustDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeptemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OctoberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NovemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DecemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet7 = New churchsoft.Database1DataSet7()
        Me.TitheTableAdapter = New churchsoft.Database1DataSet7TableAdapters.TitheTableAdapter()
        Me.lbStatus = New System.Windows.Forms.Label()
        CType(Me.Data1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbEnterIDHere
        '
        Me.lbEnterIDHere.AutoSize = True
        Me.lbEnterIDHere.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEnterIDHere.Location = New System.Drawing.Point(17, 31)
        Me.lbEnterIDHere.Name = "lbEnterIDHere"
        Me.lbEnterIDHere.Size = New System.Drawing.Size(135, 30)
        Me.lbEnterIDHere.TabIndex = 0
        Me.lbEnterIDHere.Text = "Enter ID here"
        '
        'tbxCID
        '
        Me.tbxCID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxCID.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCID.Location = New System.Drawing.Point(196, 28)
        Me.tbxCID.MaxLength = 9
        Me.tbxCID.Name = "tbxCID"
        Me.tbxCID.Size = New System.Drawing.Size(133, 35)
        Me.tbxCID.TabIndex = 0
        '
        'lbChooseMonth
        '
        Me.lbChooseMonth.AutoSize = True
        Me.lbChooseMonth.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbChooseMonth.Location = New System.Drawing.Point(17, 192)
        Me.lbChooseMonth.Name = "lbChooseMonth"
        Me.lbChooseMonth.Size = New System.Drawing.Size(150, 30)
        Me.lbChooseMonth.TabIndex = 2
        Me.lbChooseMonth.Text = "Choose Month"
        '
        'lbAmount
        '
        Me.lbAmount.AutoSize = True
        Me.lbAmount.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAmount.Location = New System.Drawing.Point(17, 314)
        Me.lbAmount.Name = "lbAmount"
        Me.lbAmount.Size = New System.Drawing.Size(146, 30)
        Me.lbAmount.TabIndex = 3
        Me.lbAmount.Text = "Amount (GHS)"
        '
        'cbxChooseMonth
        '
        Me.cbxChooseMonth.AutoCompleteCustomSource.AddRange(New String() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbxChooseMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxChooseMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxChooseMonth.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxChooseMonth.FormattingEnabled = True
        Me.cbxChooseMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbxChooseMonth.Location = New System.Drawing.Point(183, 189)
        Me.cbxChooseMonth.Name = "cbxChooseMonth"
        Me.cbxChooseMonth.Size = New System.Drawing.Size(159, 38)
        Me.cbxChooseMonth.TabIndex = 2
        Me.cbxChooseMonth.Text = "Choose Month"
        '
        'tbxEnterAmount
        '
        Me.tbxEnterAmount.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEnterAmount.Location = New System.Drawing.Point(183, 314)
        Me.tbxEnterAmount.Name = "tbxEnterAmount"
        Me.tbxEnterAmount.Size = New System.Drawing.Size(159, 43)
        Me.tbxEnterAmount.TabIndex = 3
        Me.tbxEnterAmount.Text = "Enter Amount"
        '
        'lbChooseYear
        '
        Me.lbChooseYear.AutoSize = True
        Me.lbChooseYear.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbChooseYear.Location = New System.Drawing.Point(17, 103)
        Me.lbChooseYear.Name = "lbChooseYear"
        Me.lbChooseYear.Size = New System.Drawing.Size(127, 30)
        Me.lbChooseYear.TabIndex = 6
        Me.lbChooseYear.Text = "Choose Year"
        '
        'cbxYear
        '
        Me.cbxYear.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxYear.FormattingEnabled = True
        Me.cbxYear.Items.AddRange(New Object() {"2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040"})
        Me.cbxYear.Location = New System.Drawing.Point(183, 103)
        Me.cbxYear.Name = "cbxYear"
        Me.cbxYear.Size = New System.Drawing.Size(159, 38)
        Me.cbxYear.TabIndex = 1
        '
        'btnPay
        '
        Me.btnPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(196, 405)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(133, 38)
        Me.btnPay.TabIndex = 4
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(92, 73)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(0, 21)
        Me.lbName.TabIndex = 8
        Me.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Data1BindingSource
        '
        Me.Data1BindingSource.DataMember = "data1"
        Me.Data1BindingSource.DataSource = Me.Database1DataSet4
        '
        'Database1DataSet4
        '
        Me.Database1DataSet4.DataSetName = "Database1DataSet4"
        Me.Database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Data1TableAdapter
        '
        Me.Data1TableAdapter.ClearBeforeFill = True
        '
        'Database1DataSet2
        '
        Me.Database1DataSet2.DataSetName = "Database1DataSet2"
        Me.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Data1BindingSource1
        '
        Me.Data1BindingSource1.DataMember = "data1"
        Me.Data1BindingSource1.DataSource = Me.Database1DataSet2
        '
        'Data1TableAdapter1
        '
        Me.Data1TableAdapter1.ClearBeforeFill = True
        '
        'dgv1
        '
        Me.dgv1.AutoGenerateColumns = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CIDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.OtherNamesDataGridViewTextBoxColumn})
        Me.dgv1.DataSource = Me.Data1BindingSource2
        Me.dgv1.Location = New System.Drawing.Point(388, 84)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(71, 49)
        Me.dgv1.TabIndex = 9
        Me.dgv1.TabStop = False
        Me.dgv1.Visible = False
        '
        'CIDDataGridViewTextBoxColumn
        '
        Me.CIDDataGridViewTextBoxColumn.DataPropertyName = "CID"
        Me.CIDDataGridViewTextBoxColumn.HeaderText = "CID"
        Me.CIDDataGridViewTextBoxColumn.Name = "CIDDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'OtherNamesDataGridViewTextBoxColumn
        '
        Me.OtherNamesDataGridViewTextBoxColumn.DataPropertyName = "Other_Names"
        Me.OtherNamesDataGridViewTextBoxColumn.HeaderText = "Other_Names"
        Me.OtherNamesDataGridViewTextBoxColumn.Name = "OtherNamesDataGridViewTextBoxColumn"
        '
        'Data1BindingSource2
        '
        Me.Data1BindingSource2.DataMember = "data1"
        Me.Data1BindingSource2.DataSource = Me.Database1DataSet6
        '
        'Database1DataSet6
        '
        Me.Database1DataSet6.DataSetName = "Database1DataSet6"
        Me.Database1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSet2BindingSource
        '
        Me.Database1DataSet2BindingSource.DataSource = Me.Database1DataSet2
        Me.Database1DataSet2BindingSource.Position = 0
        '
        'Data1TableAdapter2
        '
        Me.Data1TableAdapter2.ClearBeforeFill = True
        '
        'tbx1
        '
        Me.tbx1.Location = New System.Drawing.Point(399, 189)
        Me.tbx1.Name = "tbx1"
        Me.tbx1.Size = New System.Drawing.Size(45, 20)
        Me.tbx1.TabIndex = 10
        Me.tbx1.TabStop = False
        Me.tbx1.Text = " "
        Me.tbx1.Visible = False
        '
        'Data1BindingSource3
        '
        Me.Data1BindingSource3.DataMember = "data1"
        Me.Data1BindingSource3.DataSource = Me.Database1DataSet2BindingSource
        '
        'dgv2
        '
        Me.dgv2.AutoGenerateColumns = False
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CIDDataGridViewTextBoxColumn1, Me.JanuaryDataGridViewTextBoxColumn, Me.FebruaryDataGridViewTextBoxColumn, Me.MarchDataGridViewTextBoxColumn, Me.AprilDataGridViewTextBoxColumn, Me.MayDataGridViewTextBoxColumn, Me.JuneDataGridViewTextBoxColumn, Me.JulyDataGridViewTextBoxColumn, Me.AugustDataGridViewTextBoxColumn, Me.SeptemberDataGridViewTextBoxColumn, Me.OctoberDataGridViewTextBoxColumn, Me.NovemberDataGridViewTextBoxColumn, Me.DecemberDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn})
        Me.dgv2.DataSource = Me.TitheBindingSource
        Me.dgv2.Location = New System.Drawing.Point(388, 139)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(56, 25)
        Me.dgv2.TabIndex = 15
        Me.dgv2.TabStop = False
        Me.dgv2.Visible = False
        '
        'CIDDataGridViewTextBoxColumn1
        '
        Me.CIDDataGridViewTextBoxColumn1.DataPropertyName = "CID"
        Me.CIDDataGridViewTextBoxColumn1.HeaderText = "CID"
        Me.CIDDataGridViewTextBoxColumn1.Name = "CIDDataGridViewTextBoxColumn1"
        '
        'JanuaryDataGridViewTextBoxColumn
        '
        Me.JanuaryDataGridViewTextBoxColumn.DataPropertyName = "January"
        Me.JanuaryDataGridViewTextBoxColumn.HeaderText = "January"
        Me.JanuaryDataGridViewTextBoxColumn.Name = "JanuaryDataGridViewTextBoxColumn"
        '
        'FebruaryDataGridViewTextBoxColumn
        '
        Me.FebruaryDataGridViewTextBoxColumn.DataPropertyName = "February"
        Me.FebruaryDataGridViewTextBoxColumn.HeaderText = "February"
        Me.FebruaryDataGridViewTextBoxColumn.Name = "FebruaryDataGridViewTextBoxColumn"
        '
        'MarchDataGridViewTextBoxColumn
        '
        Me.MarchDataGridViewTextBoxColumn.DataPropertyName = "March"
        Me.MarchDataGridViewTextBoxColumn.HeaderText = "March"
        Me.MarchDataGridViewTextBoxColumn.Name = "MarchDataGridViewTextBoxColumn"
        '
        'AprilDataGridViewTextBoxColumn
        '
        Me.AprilDataGridViewTextBoxColumn.DataPropertyName = "April"
        Me.AprilDataGridViewTextBoxColumn.HeaderText = "April"
        Me.AprilDataGridViewTextBoxColumn.Name = "AprilDataGridViewTextBoxColumn"
        '
        'MayDataGridViewTextBoxColumn
        '
        Me.MayDataGridViewTextBoxColumn.DataPropertyName = "May"
        Me.MayDataGridViewTextBoxColumn.HeaderText = "May"
        Me.MayDataGridViewTextBoxColumn.Name = "MayDataGridViewTextBoxColumn"
        '
        'JuneDataGridViewTextBoxColumn
        '
        Me.JuneDataGridViewTextBoxColumn.DataPropertyName = "June"
        Me.JuneDataGridViewTextBoxColumn.HeaderText = "June"
        Me.JuneDataGridViewTextBoxColumn.Name = "JuneDataGridViewTextBoxColumn"
        '
        'JulyDataGridViewTextBoxColumn
        '
        Me.JulyDataGridViewTextBoxColumn.DataPropertyName = "July"
        Me.JulyDataGridViewTextBoxColumn.HeaderText = "July"
        Me.JulyDataGridViewTextBoxColumn.Name = "JulyDataGridViewTextBoxColumn"
        '
        'AugustDataGridViewTextBoxColumn
        '
        Me.AugustDataGridViewTextBoxColumn.DataPropertyName = "August"
        Me.AugustDataGridViewTextBoxColumn.HeaderText = "August"
        Me.AugustDataGridViewTextBoxColumn.Name = "AugustDataGridViewTextBoxColumn"
        '
        'SeptemberDataGridViewTextBoxColumn
        '
        Me.SeptemberDataGridViewTextBoxColumn.DataPropertyName = "September"
        Me.SeptemberDataGridViewTextBoxColumn.HeaderText = "September"
        Me.SeptemberDataGridViewTextBoxColumn.Name = "SeptemberDataGridViewTextBoxColumn"
        '
        'OctoberDataGridViewTextBoxColumn
        '
        Me.OctoberDataGridViewTextBoxColumn.DataPropertyName = "October"
        Me.OctoberDataGridViewTextBoxColumn.HeaderText = "October"
        Me.OctoberDataGridViewTextBoxColumn.Name = "OctoberDataGridViewTextBoxColumn"
        '
        'NovemberDataGridViewTextBoxColumn
        '
        Me.NovemberDataGridViewTextBoxColumn.DataPropertyName = "November"
        Me.NovemberDataGridViewTextBoxColumn.HeaderText = "November"
        Me.NovemberDataGridViewTextBoxColumn.Name = "NovemberDataGridViewTextBoxColumn"
        '
        'DecemberDataGridViewTextBoxColumn
        '
        Me.DecemberDataGridViewTextBoxColumn.DataPropertyName = "December"
        Me.DecemberDataGridViewTextBoxColumn.HeaderText = "December"
        Me.DecemberDataGridViewTextBoxColumn.Name = "DecemberDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'TitheBindingSource
        '
        Me.TitheBindingSource.DataMember = "Tithe"
        Me.TitheBindingSource.DataSource = Me.Database1DataSet7
        '
        'Database1DataSet7
        '
        Me.Database1DataSet7.DataSetName = "Database1DataSet7"
        Me.Database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitheTableAdapter
        '
        Me.TitheTableAdapter.ClearBeforeFill = True
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(140, 469)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(61, 13)
        Me.lbStatus.TabIndex = 16
        Me.lbStatus.Text = ".................."
        '
        'RadForm4
        '
        Me.AcceptButton = Me.btnPay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 491)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.tbx1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.cbxYear)
        Me.Controls.Add(Me.lbChooseYear)
        Me.Controls.Add(Me.tbxEnterAmount)
        Me.Controls.Add(Me.cbxChooseMonth)
        Me.Controls.Add(Me.lbAmount)
        Me.Controls.Add(Me.lbChooseMonth)
        Me.Controls.Add(Me.tbxCID)
        Me.Controls.Add(Me.lbEnterIDHere)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Data1BindingSource1, "Firstname", True))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RadForm4"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "PAY TITHE"
        CType(Me.Data1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbEnterIDHere As System.Windows.Forms.Label
    Friend WithEvents tbxCID As System.Windows.Forms.TextBox
    Friend WithEvents lbChooseMonth As System.Windows.Forms.Label
    Friend WithEvents lbAmount As System.Windows.Forms.Label
    Friend WithEvents cbxChooseMonth As System.Windows.Forms.ComboBox
    Friend WithEvents tbxEnterAmount As System.Windows.Forms.TextBox
    Friend WithEvents lbChooseYear As System.Windows.Forms.Label
    Friend WithEvents cbxYear As System.Windows.Forms.ComboBox
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet4 As churchsoft.Database1DataSet4
    Friend WithEvents Data1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Data1TableAdapter As churchsoft.Database1DataSet4TableAdapters.data1TableAdapter
    Friend WithEvents Database1DataSet2 As churchsoft.Database1DataSet2
    Friend WithEvents Data1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Data1TableAdapter1 As churchsoft.Database1DataSet2TableAdapters.data1TableAdapter
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet6 As churchsoft.Database1DataSet6
    Friend WithEvents Data1BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Data1TableAdapter2 As churchsoft.Database1DataSet6TableAdapters.data1TableAdapter
    Friend WithEvents tbx1 As System.Windows.Forms.TextBox
    Friend WithEvents CIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherNamesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data1BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet7 As churchsoft.Database1DataSet7
    Friend WithEvents TitheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitheTableAdapter As churchsoft.Database1DataSet7TableAdapters.TitheTableAdapter
    Friend WithEvents CIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JanuaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FebruaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AprilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JuneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JulyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AugustDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SeptemberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OctoberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NovemberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DecemberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbStatus As System.Windows.Forms.Label
End Class

