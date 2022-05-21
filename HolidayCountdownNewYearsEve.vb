Public Class HolidayCountdownNewYearsEve
    'MyBase subroutine
    Private Sub MyBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NYED As Date = Date.Now.ToString("12/31/yyyy")
        Dim SD As Date = Date.Now.ToString("M/d/yyyy")
        Dim DD As TimeSpan = NYED.Subtract(SD)
        NewYearsEveLabel.Text = "New Year's Eve is in " & DD.Days.ToString() & " days (" & NYED & ")."
        If DD.Days = 1 Then
            NewYearsEveLabel.Text = "New Year's Eve is in 1 day (" & NYED & ")."
        End If
        If DD.Days = 0 Then
            NewYearsEveLabel.Text = "Happy New Year's Eve!"
        End If
        HolidayCountdownTimer.Start()
    End Sub
    'HolidayCountdownTimer subroutine
    Private Sub HolidayCountdownTimer_Tick(sender As Object, e As EventArgs) Handles HolidayCountdownTimer.Tick
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