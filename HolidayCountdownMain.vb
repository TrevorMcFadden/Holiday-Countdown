Imports System.Drawing.Printing

Public Class HolidayCountdownMain
    Dim MI As Bitmap
    'HolidayCountdownToolStrip subroutines
    Private Sub NewYearsDayButtonTS_Click(sender As Object, e As EventArgs) Handles NewYearsDayButtonTS.Click
        Dim LNYD As New HolidayCountdownNewYearsDay With {.MdiParent = Me}
        LNYD.Show()
    End Sub
    Private Sub EasterButtonTS_Click(sender As Object, e As EventArgs) Handles EasterButtonTS.Click
        Dim LE As New HolidayCountdownEaster With {.MdiParent = Me}
        LE.Show()
    End Sub
    Private Sub ThanksgivingButtonTS_Click(sender As Object, e As EventArgs) Handles ThanksgivingButtonTS.Click
        Dim LT As New HolidayCountdownThanksgiving With {.MdiParent = Me}
        LT.Show()
    End Sub
    Private Sub ChristmasButtonTS_Click(sender As Object, e As EventArgs) Handles ChristmasButtonTS.Click
        Dim LC As New HolidayCountdownChristmas With {.MdiParent = Me}
        LC.Show()
    End Sub
    Private Sub NewYearsEveButtonTS_Click(sender As Object, e As EventArgs) Handles NewYearsEveButtonTS.Click
        Dim LNYE As New HolidayCountdownNewYearsEve With {.MdiParent = Me}
        LNYE.Show()
    End Sub
    Private Sub NewWindowButtonTS_Click(sender As Object, e As EventArgs) Handles NewWindowButtonTS.Click
        Dim NW As New HolidayCountdownMain
        NW.Show()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(MI, 0, 0)
    End Sub
    Private Sub PrintButtonTS_Click(sender As Object, e As EventArgs) Handles PrintButtonTS.Click
        Dim MG As Graphics = CreateGraphics()
        Dim S As Size = Size
        MI = New Bitmap(S.Width, S.Height, MG)
        Dim MEMG As Graphics = Graphics.FromImage(MI)
        MEMG.CopyFromScreen(Location.X, Location.Y, 0, 0, S)
        PrintDocument1.Print()
    End Sub
End Class