<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Me.pgb1 = New System.Windows.Forms.ProgressBar()
        Me.lbLoading = New System.Windows.Forms.Label()
        Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pgb1
        '
        Me.pgb1.Location = New System.Drawing.Point(344, 531)
        Me.pgb1.MarqueeAnimationSpeed = 10
        Me.pgb1.Name = "pgb1"
        Me.pgb1.Size = New System.Drawing.Size(148, 23)
        Me.pgb1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pgb1.TabIndex = 0
        '
        'lbLoading
        '
        Me.lbLoading.AutoSize = True
        Me.lbLoading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLoading.Location = New System.Drawing.Point(369, 557)
        Me.lbLoading.Name = "lbLoading"
        Me.lbLoading.Size = New System.Drawing.Size(107, 25)
        Me.lbLoading.TabIndex = 1
        Me.lbLoading.Text = "Loading..."
        '
        'lbWESLEYMETHODISTCHURCHTWIFOHEMANG
        '
        Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG.AutoSize = True
        Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG.BackColor = System.Drawing.SystemColors.Control
        Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG.ForeColor = System.Drawing.Color.Black
        Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG.Location = New System.Drawing.Point(82, 27)
        Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG.Name = "lbWESLEYMETHODISTCHURCHTWIFOHEMANG"
        Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG.Size = New System.Drawing.Size(682, 35)
        Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG.TabIndex = 2
        Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG.Text = "WESLEY METHODIST CHURCH, TWIFO HEMANG"
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.churchsoft.My.Resources.Resources.C__Data_Users_DefApps_AppData_INTERNETEXPLORER_Temp_Saved_Images_methodist_1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(838, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbWESLEYMETHODISTCHURCHTWIFOHEMANG)
        Me.Controls.Add(Me.lbLoading)
        Me.Controls.Add(Me.pgb1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pgb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbLoading As System.Windows.Forms.Label
    Friend WithEvents lbWESLEYMETHODISTCHURCHTWIFOHEMANG As System.Windows.Forms.Label

End Class
