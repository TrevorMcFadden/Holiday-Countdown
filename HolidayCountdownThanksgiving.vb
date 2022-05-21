Public Class HolidayCountdownThanksgiving
    'MyBase subroutine
    Private Sub MyBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim YEAR As Integer = Date.Now.ToString("yyyy")
        Dim FW As Integer = 4
        Dim TD = GetNthDayOfNthWeek(DateSerial(YEAR, 11, 1), DayOfWeek.Thursday, FW)
        Dim SD As Date = Date.Now.ToString("M/d/yyyy")
        Dim DD As TimeSpan = TD.Subtract(SD)
        ThanksgivingLabel.Text = "Thanksgiving is in " & DD.Days.ToString() & " days (" & TD & ")."
        If DD.Days = 1 Then
            ThanksgivingLabel.Text = "Thanksgiving is in 1 day (" & TD & ")."
        End If
        If DD.Days = 0 Then
            ThanksgivingLabel.Text = "Happy Thanksgiving! Remember to be thankful."
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
    Private Shared Function GetNthDayOfNthWeek(dt As Date, DayofWeek As Integer, WhichWeek As Integer) As Date
        Dim dtFirst As Date = DateSerial(dt.Year, dt.Month, 1)
        Dim dtRet As Date = dtFirst.AddDays(6 - dtFirst.AddDays(-(DayofWeek + 1)).DayOfWeek)
        dtRet = dtRet.AddDays((WhichWeek - 1) * 7)
        If dtRet >= dtFirst.AddMonths(1) Then
            dtRet = dtRet.AddDays(-7)
        End If
        Return dtRet
    End Function
End Class