Public Class HolidayCountdownChristmas
    'MyBase subroutine
    Private Sub MyBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CD As Date = Date.Now.ToString("12/25/yyyy")
        Dim SD As Date = Date.Now.ToString("M/d/yyyy")
        Dim DD As TimeSpan = CD.Subtract(SD)
        ChristmasLabel.Text = "Christmas is in " & DD.Days.ToString() & " days (" & CD & ")."
        If DD.Days = 1 Then
            ChristmasLabel.Text = "Christmas is in 1 day (" & CD & ")."
        End If
        If DD.Days = 0 Then
            ChristmasLabel.Text = "Merry Christmas! Jesus Christ is born!"
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