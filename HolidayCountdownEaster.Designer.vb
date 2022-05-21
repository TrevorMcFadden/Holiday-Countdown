<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HolidayCountdownEaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HolidayCountdownEaster))
        Me.EasterLabel = New System.Windows.Forms.Label()
        Me.DateTimeLabel = New System.Windows.Forms.Label()
        Me.TwelveHourButton = New System.Windows.Forms.RadioButton()
        Me.TwentyFourHourButton = New System.Windows.Forms.RadioButton()
        Me.HolidayCountdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'EasterLabel
        '
        Me.EasterLabel.AutoSize = True
        Me.EasterLabel.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EasterLabel.ForeColor = System.Drawing.Color.White
        Me.EasterLabel.Location = New System.Drawing.Point(12, 60)
        Me.EasterLabel.Name = "EasterLabel"
        Me.EasterLabel.Size = New System.Drawing.Size(555, 45)
        Me.EasterLabel.TabIndex = 0
        Me.EasterLabel.Text = "Easter is in 365 days (mm/dd/yyyy)."
        '
        'DateTimeLabel
        '
        Me.DateTimeLabel.AutoSize = True
        Me.DateTimeLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimeLabel.ForeColor = System.Drawing.Color.Chartreuse
        Me.DateTimeLabel.Location = New System.Drawing.Point(12, 19)
        Me.DateTimeLabel.Name = "DateTimeLabel"
        Me.DateTimeLabel.Size = New System.Drawing.Size(465, 30)
        Me.DateTimeLabel.TabIndex = 1
        Me.DateTimeLabel.Text = "Hello! Today is Saturday, December 25, 12:00 PM"
        '
        'TwelveHourButton
        '
        Me.TwelveHourButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TwelveHourButton.AutoSize = True
        Me.TwelveHourButton.Checked = True
        Me.TwelveHourButton.Location = New System.Drawing.Point(438, 143)
        Me.TwelveHourButton.Name = "TwelveHourButton"
        Me.TwelveHourButton.Size = New System.Drawing.Size(67, 19)
        Me.TwelveHourButton.TabIndex = 2
        Me.TwelveHourButton.TabStop = True
        Me.TwelveHourButton.Text = "12-hour"
        Me.TwelveHourButton.UseVisualStyleBackColor = True
        '
        'TwentyFourHourButton
        '
        Me.TwentyFourHourButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TwentyFourHourButton.AutoSize = True
        Me.TwentyFourHourButton.Location = New System.Drawing.Point(511, 143)
        Me.TwentyFourHourButton.Name = "TwentyFourHourButton"
        Me.TwentyFourHourButton.Size = New System.Drawing.Size(67, 19)
        Me.TwentyFourHourButton.TabIndex = 3
        Me.TwentyFourHourButton.TabStop = True
        Me.TwentyFourHourButton.Text = "24-hour"
        Me.TwentyFourHourButton.UseVisualStyleBackColor = True
        '
        'HolidayCountdownTimer
        '
        '
        'HolidayCountdownEaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(592, 186)
        Me.Controls.Add(Me.TwentyFourHourButton)
        Me.Controls.Add(Me.TwelveHourButton)
        Me.Controls.Add(Me.DateTimeLabel)
        Me.Controls.Add(Me.EasterLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HolidayCountdownEaster"
        Me.Text = "Holiday Countdown: Easter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EasterLabel As Label
    Friend WithEvents DateTimeLabel As Label
    Friend WithEvents TwelveHourButton As RadioButton
    Friend WithEvents TwentyFourHourButton As RadioButton
    Friend WithEvents HolidayCountdownTimer As Timer
End Class
