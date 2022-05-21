<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HolidayCountdownMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HolidayCountdownMain))
        Me.HolidayCountdownToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewYearsDayButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.EasterButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.ThanksgivingButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.ChristmasButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.NewYearsEveButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.PrintButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewWindowButtonTS = New System.Windows.Forms.ToolStripButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.HolidayCountdownToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'HolidayCountdownToolStrip
        '
        Me.HolidayCountdownToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HolidayCountdownToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewYearsDayButtonTS, Me.EasterButtonTS, Me.ThanksgivingButtonTS, Me.ChristmasButtonTS, Me.NewYearsEveButtonTS, Me.PrintButtonTS, Me.ToolStripSeparator1, Me.NewWindowButtonTS})
        Me.HolidayCountdownToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.HolidayCountdownToolStrip.Name = "HolidayCountdownToolStrip"
        Me.HolidayCountdownToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.HolidayCountdownToolStrip.TabIndex = 5
        Me.HolidayCountdownToolStrip.Text = "ToolStrip1"
        '
        'NewYearsDayButtonTS
        '
        Me.NewYearsDayButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewYearsDayButtonTS.Image = CType(resources.GetObject("NewYearsDayButtonTS.Image"), System.Drawing.Image)
        Me.NewYearsDayButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewYearsDayButtonTS.Name = "NewYearsDayButtonTS"
        Me.NewYearsDayButtonTS.Size = New System.Drawing.Size(91, 22)
        Me.NewYearsDayButtonTS.Text = "New Year's Day"
        Me.NewYearsDayButtonTS.ToolTipText = "Open the New Year's Day countdown"
        '
        'EasterButtonTS
        '
        Me.EasterButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EasterButtonTS.Image = CType(resources.GetObject("EasterButtonTS.Image"), System.Drawing.Image)
        Me.EasterButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EasterButtonTS.Name = "EasterButtonTS"
        Me.EasterButtonTS.Size = New System.Drawing.Size(42, 22)
        Me.EasterButtonTS.Text = "Easter"
        Me.EasterButtonTS.ToolTipText = "Open the Easter countdown"
        '
        'ThanksgivingButtonTS
        '
        Me.ThanksgivingButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ThanksgivingButtonTS.Image = CType(resources.GetObject("ThanksgivingButtonTS.Image"), System.Drawing.Image)
        Me.ThanksgivingButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ThanksgivingButtonTS.Name = "ThanksgivingButtonTS"
        Me.ThanksgivingButtonTS.Size = New System.Drawing.Size(81, 22)
        Me.ThanksgivingButtonTS.Text = "Thanksgiving"
        Me.ThanksgivingButtonTS.ToolTipText = "Open the Thanksgiving countdown"
        '
        'ChristmasButtonTS
        '
        Me.ChristmasButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ChristmasButtonTS.Image = CType(resources.GetObject("ChristmasButtonTS.Image"), System.Drawing.Image)
        Me.ChristmasButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChristmasButtonTS.Name = "ChristmasButtonTS"
        Me.ChristmasButtonTS.Size = New System.Drawing.Size(64, 22)
        Me.ChristmasButtonTS.Text = "Christmas"
        Me.ChristmasButtonTS.ToolTipText = "Open the Christmas countdown"
        '
        'NewYearsEveButtonTS
        '
        Me.NewYearsEveButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewYearsEveButtonTS.Image = CType(resources.GetObject("NewYearsEveButtonTS.Image"), System.Drawing.Image)
        Me.NewYearsEveButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewYearsEveButtonTS.Name = "NewYearsEveButtonTS"
        Me.NewYearsEveButtonTS.Size = New System.Drawing.Size(89, 22)
        Me.NewYearsEveButtonTS.Text = "New Year's Eve"
        Me.NewYearsEveButtonTS.ToolTipText = "Open the New Year's Eve countdown"
        '
        'PrintButtonTS
        '
        Me.PrintButtonTS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.PrintButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintButtonTS.Image = CType(resources.GetObject("PrintButtonTS.Image"), System.Drawing.Image)
        Me.PrintButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintButtonTS.Name = "PrintButtonTS"
        Me.PrintButtonTS.Size = New System.Drawing.Size(36, 22)
        Me.PrintButtonTS.Text = "Print"
        Me.PrintButtonTS.ToolTipText = "Print the form"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'NewWindowButtonTS
        '
        Me.NewWindowButtonTS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.NewWindowButtonTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewWindowButtonTS.Image = CType(resources.GetObject("NewWindowButtonTS.Image"), System.Drawing.Image)
        Me.NewWindowButtonTS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewWindowButtonTS.Name = "NewWindowButtonTS"
        Me.NewWindowButtonTS.Size = New System.Drawing.Size(44, 22)
        Me.NewWindowButtonTS.Text = "New..."
        '
        'PrintDocument1
        '
        '
        'HolidayCountdownMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HolidayCountdownToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "HolidayCountdownMain"
        Me.Text = "Holiday Countdown"
        Me.HolidayCountdownToolStrip.ResumeLayout(False)
        Me.HolidayCountdownToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HolidayCountdownToolStrip As ToolStrip
    Friend WithEvents EasterButtonTS As ToolStripButton
    Friend WithEvents ThanksgivingButtonTS As ToolStripButton
    Friend WithEvents ChristmasButtonTS As ToolStripButton
    Friend WithEvents NewYearsEveButtonTS As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NewWindowButtonTS As ToolStripButton
    Friend WithEvents PrintButtonTS As ToolStripButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents NewYearsDayButtonTS As ToolStripButton
End Class
