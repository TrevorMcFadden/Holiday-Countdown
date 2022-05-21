<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HolidayCountdownChristmas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HolidayCountdownChristmas))
        Me.TwentyFourHourButton = New System.Windows.Forms.RadioButton()
        Me.TwelveHourButton = New System.Windows.Forms.RadioButton()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.ChristmasLabel = New System.Windows.Forms.Label()
        Me.HolidayCountdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TwentyFourHourButton
        '
        Me.TwentyFourHourButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TwentyFourHourButton.AutoSize = True
        Me.TwentyFourHourButton.Location = New System.Drawing.Point(570, 146)
        Me.TwentyFourHourButton.Name = "TwentyFourHourButton"
        Me.TwentyFourHourButton.Size = New System.Drawing.Size(67, 19)
        Me.TwentyFourHourButton.TabIndex = 7
        Me.TwentyFourHourButton.Text = "24-hour"
        Me.TwentyFourHourButton.UseVisualStyleBackColor = True
        '
        'TwelveHourButton
        '
        Me.TwelveHourButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TwelveHourButton.AutoSize = True
        Me.TwelveHourButton.Checked = True
        Me.TwelveHourButton.Location = New System.Drawing.Point(497, 146)
        Me.TwelveHourButton.Name = "TwelveHourButton"
        Me.TwelveHourButton.Size = New System.Drawing.Size(67, 19)
        Me.TwelveHourButton.TabIndex = 6
        Me.TwelveHourButton.TabStop = True
        Me.TwelveHourButton.Text = "12-hour"
        Me.TwelveHourButton.UseVisualStyleBackColor = True
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.AutoSize = True
        Me.DateTimeLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimeLabel.ForeColor = System.Drawing.Color.Green
        Me.DateTimeLabel.Location = New System.Drawing.Point(13, 22)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(465, 30)
        Me.DateTimeLabel.TabIndex = 5
        Me.DateTimeLabel.Text = "Hello! Today is Saturday, December 25, 12:00 PM"
        '
        'ChristmasLabel
        '
        Me.ChristmasLabel.AutoSize = True
        Me.ChristmasLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ChristmasLabel.ForeColor = System.Drawing.Color.Red
        Me.ChristmasLabel.Location = New System.Drawing.Point(13, 63)
        Me.ChristmasLabel.Name = "ChristmasLabel"
        Me.ChristmasLabel.Size = New System.Drawing.Size(612, 45)
        Me.ChristmasLabel.TabIndex = 4
        Me.ChristmasLabel.Text = "Christmas is in 365 days (mm/dd/yyyy)."
        '
        'HolidayCountdownTimer
        '
        '
        'HolidayCountdownChristmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(650, 186)
        Me.Controls.Add(Me.TwentyFourHourButton)
        Me.Controls.Add(Me.TwelveHourButton)
        Me.Controls.Add(Me.DateTimeLabel)
        Me.Controls.Add(Me.ChristmasLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HolidayCountdownChristmas"
        Me.Text = "Holiday Countdown: Christmas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TwentyFourHourButton As RadioButton
    Friend WithEvents TwelveHourButton As RadioButton
    Friend WithEvents DateTimeLabel As Label
    Friend WithEvents ChristmasLabel As Label
    Friend WithEvents HolidayCountdownTimer As Timer
End Class
