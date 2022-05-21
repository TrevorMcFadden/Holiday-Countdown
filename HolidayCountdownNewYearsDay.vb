Public Class HolidayCountdownNewYearsDay
    'MyBase subroutine
    Private Sub MyBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim NYDD As Date = Date.Now.ToString("1/1/yyyy")
        Dim SD As Date = Date.Now.ToString("M/d/yyyy")
        Dim DD As TimeSpan = NYDD.Subtract(SD)
        NewYearsDayLabel.Text = "New Year's Day is in " & DD.Days.ToString() & " days (" & NYDD & ")."
        If DD.Days = 1 Then
            NewYearsDayLabel.Text = "New Year's Day is in 1 day (" & NYDD & ")."
        End If
        If DD.Days = 0 Then
            NewYearsDayLabel.Text = "Happy New Year's"
        End If
        HolidayCountdownTimer.Start()
    End Sub
    'HolidayCoutndownTimer subroutine
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