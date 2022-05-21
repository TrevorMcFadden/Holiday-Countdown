<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HolidayCountdownNewYearsEve
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HolidayCountdownNewYearsEve))
        Me.TwentyFourHourButton = New System.Windows.Forms.RadioButton()
        Me.TwelveHourButton = New System.Windows.Forms.RadioButton()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.NewYearsEveLabel = New System.Windows.Forms.Label()
        Me.HolidayCountdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TwentyFourHourButton
        '
        Me.TwentyFourHourButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TwentyFourHourButton.AutoSize = True
        Me.TwentyFourHourButton.ForeColor = System.Drawing.Color.White
        Me.TwentyFourHourButton.Location = New System.Drawing.Point(637, 146)
        Me.TwentyFourHourButton.Name = "TwentyFourHourButton"
        Me.TwentyFourHourButton.Size = New System.Drawing.Size(67, 19)
        Me.TwentyFourHourButton.TabIndex = 11
        Me.TwentyFourHourButton.Text = "24-hour"
        Me.TwentyFourHourButton.UseVisualStyleBackColor = True
        '
        'TwelveHourButton
        '
        Me.TwelveHourButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TwelveHourButton.AutoSize = True
        Me.TwelveHourButton.Checked = True
        Me.TwelveHourButton.ForeColor = System.Drawing.Color.White
        Me.TwelveHourButton.Location = New System.Drawing.Point(564, 146)
        Me.TwelveHourButton.Name = "TwelveHourButton"
        Me.TwelveHourButton.Size = New System.Drawing.Size(67, 19)
        Me.TwelveHourButton.TabIndex = 10
        Me.TwelveHourButton.TabStop = True
        Me.TwelveHourButton.Text = "12-hour"
        Me.TwelveHourButton.UseVisualStyleBackColor = True
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.AutoSize = True
        Me.DateTimeLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimeLabel.ForeColor = System.Drawing.Color.Gold
        Me.DateTimeLabel.Location = New System.Drawing.Point(12, 22)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(465, 30)
        Me.DateTimeLabel.TabIndex = 9
        Me.DateTimeLabel.Text = "Hello! Today is Saturday, December 25, 12:00 PM"
        '
        'NewYearsEveLabel
        '
        Me.NewYearsEveLabel.AutoSize = True
        Me.NewYearsEveLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NewYearsEveLabel.ForeColor = System.Drawing.Color.White
        Me.NewYearsEveLabel.Location = New System.Drawing.Point(12, 63)
        Me.NewYearsEveLabel.Name = "NewYearsEveLabel"
        Me.NewYearsEveLabel.Size = New System.Drawing.Size(686, 45)
        Me.NewYearsEveLabel.TabIndex = 8
        Me.NewYearsEveLabel.Text = "New Year's Eve is in 365 days (mm/dd/yyyy)."
        '
        'HolidayCountdownTimer
        '
        '
        'HolidayCountdownNewYearsEve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(718, 186)
        Me.Controls.Add(Me.TwentyFourHourButton)
        Me.Controls.Add(Me.TwelveHourButton)
        Me.Controls.Add(Me.DateTimeLabel)
        Me.Controls.Add(Me.NewYearsEveLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HolidayCountdownNewYearsEve"
        Me.Text = "Holiday Countdown: New Year's Eve"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TwentyFourHourButton As RadioButton
    Friend WithEvents TwelveHourButton As RadioButton
    Friend WithEvents DateTimeLabel As Label
    Friend WithEvents NewYearsEveLabel As Label
    Friend WithEvents HolidayCountdownTimer As Timer
End Class
