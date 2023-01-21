<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tithes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tithes))
        Me.dgv5 = New System.Windows.Forms.DataGridView()
        Me.CIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Database1DataSet9 = New churchsoft.Database1DataSet9()
        Me.Database1DataSet8 = New churchsoft.Database1DataSet8()
        Me.Database1DataSet8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitheTableAdapter = New churchsoft.Database1DataSet9TableAdapters.TitheTableAdapter()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.dgv5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv5
        '
        Me.dgv5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv5.AutoGenerateColumns = False
        Me.dgv5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CIDDataGridViewTextBoxColumn, Me.JanuaryDataGridViewTextBoxColumn, Me.FebruaryDataGridViewTextBoxColumn, Me.MarchDataGridViewTextBoxColumn, Me.AprilDataGridViewTextBoxColumn, Me.MayDataGridViewTextBoxColumn, Me.JuneDataGridViewTextBoxColumn, Me.JulyDataGridViewTextBoxColumn, Me.AugustDataGridViewTextBoxColumn, Me.SeptemberDataGridViewTextBoxColumn, Me.OctoberDataGridViewTextBoxColumn, Me.NovemberDataGridViewTextBoxColumn, Me.DecemberDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn})
        Me.dgv5.DataSource = Me.TitheBindingSource
        Me.dgv5.GridColor = System.Drawing.SystemColors.Control
        Me.dgv5.Location = New System.Drawing.Point(-1, 1)
        Me.dgv5.Name = "dgv5"
        Me.dgv5.Size = New System.Drawing.Size(1138, 458)
        Me.dgv5.TabIndex = 0
        '
        'CIDDataGridViewTextBoxColumn
        '
        Me.CIDDataGridViewTextBoxColumn.DataPropertyName = "CID"
        Me.CIDDataGridViewTextBoxColumn.HeaderText = "CID"
        Me.CIDDataGridViewTextBoxColumn.Name = "CIDDataGridViewTextBoxColumn"
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
        Me.TitheBindingSource.DataSource = Me.Database1DataSet9
        '
        'Database1DataSet9
        '
        Me.Database1DataSet9.DataSetName = "Database1DataSet9"
        Me.Database1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSet8
        '
        Me.Database1DataSet8.DataSetName = "Database1DataSet8"
        Me.Database1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSet8BindingSource
        '
        Me.Database1DataSet8BindingSource.DataSource = Me.Database1DataSet8
        Me.Database1DataSet8BindingSource.Position = 0
        '
        'TitheTableAdapter
        '
        Me.TitheTableAdapter.ClearBeforeFill = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Location = New System.Drawing.Point(568, 467)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(119, 32)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'tbxSearch
        '
        Me.tbxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSearch.Location = New System.Drawing.Point(86, 472)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.Size = New System.Drawing.Size(313, 27)
        Me.tbxSearch.TabIndex = 2
        Me.tbxSearch.Text = "SEARCH"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Location = New System.Drawing.Point(405, 472)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 27)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Location = New System.Drawing.Point(736, 467)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(114, 31)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Tithes
        '
        Me.AcceptButton = Me.btnUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 506)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.tbxSearch)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dgv5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tithes"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "TITHE LIST"
        CType(Me.dgv5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv5 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet8BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet8 As churchsoft.Database1DataSet8
    Friend WithEvents Database1DataSet9 As churchsoft.Database1DataSet9
    Friend WithEvents TitheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitheTableAdapter As churchsoft.Database1DataSet9TableAdapters.TitheTableAdapter
    Friend WithEvents CIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents tbxSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class

