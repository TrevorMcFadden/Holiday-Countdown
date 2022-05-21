Public Class HolidayCountdownEaster
    'MyBase subroutine
    Private Sub MyBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Y As Integer = Date.Now.ToString("yyyy")
        Dim D As Integer = ((255 - 11 * (Y Mod 19) - 21) Mod 30) + 21
        Dim ED = New DateTime(y, 3, 1)
        ED.AddDays(+D + (D > 48) + 6 - ((Y + Y \ 4 + D + (D > 48) + 1) Mod 7))
        Dim SD As Date = Date.Now.ToString("M/d/yyyy")
        Dim DD As TimeSpan = ED.Subtract(SD)
        EasterLabel.Text = "Easter is in " & DD.Days.ToString() & " days (" & ED & ")."
        If DD.Days = 1 Then
            EasterLabel.Text = "Easter is in 1 day (" & ED & ")."
        End If
        If DD.Days = 0 Then
            EasterLabel.Text = "Happy Easter! Jesus is risen!"
        End If
        HolidayCountdownTimer.Start()
    End Sub
    'HolidayCountdownTimer subroutine
    Private Sub HolidayCountdownimer_Tick(sender As Object, e As EventArgs) Handles HolidayCountdownTimer.Tick
        If TwelveHourButton.Checked = True Then
            DateTimeLabel.Text = "Hello! Today is " & Date.Now.ToString("dddd, MMMM d, h:mm tt")
            TwentyFourHourButton.Checked = False
        End If
        If TwentyFourHourButton.Checked = True Then
            DateTimeLabel.Text = "Hello! Today is " & Date.Now.ToString("dddd, MMMM d, HH:mm tt")
            TwelveHourButton.Checked = False
        End If
    End Sub
End Class