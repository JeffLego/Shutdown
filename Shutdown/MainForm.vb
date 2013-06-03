Option Strict On
Option Explicit On
Public Class MainForm
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnCancel_Click()
        Dim parameter As String() = System.Environment.GetCommandLineArgs
        If parameter.Length > 1 Then
            If IsNumeric(parameter(1)) Then sd(Convert.ToInt32(parameter(1)))
        End If
        txtSeconds.SelectionStart = 2
    End Sub
    Private Sub OnTyping(sender As Object, e As KeyEventArgs) Handles txtSeconds.KeyDown
        If e.KeyCode = Keys.Back Then
            e.SuppressKeyPress = True
            Shift_Backward()
        End If
        If e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.Left Then
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.Right Then
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.Up Then
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.PageUp Then
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.Home Then
            e.SuppressKeyPress = True
        End If
    End Sub
    Private Sub AfterTyping() Handles txtSeconds.KeyUp
        Try
            If Not IsNumeric(txtSeconds.Text.ElementAt(2)) Then
                txtSeconds.Text = txtSeconds.Text.Substring(0, 2)
                txtSeconds.SelectionStart = 2
            End If
            For i As Integer = 2 To txtSeconds.Text.Length - 1
                If txtHours.Text.ElementAt(0) = "0" Then
                    Shift_Forward()
                Else
                    txtSeconds.Text = txtSeconds.Text.Substring(0, 2)
                    txtSeconds.SelectionStart = 2
                End If
            Next
        Catch Ex As ArgumentOutOfRangeException
        End Try
    End Sub
    Private Sub On_Click() Handles txtSeconds.Click, txtSeconds.DoubleClick
        txtSeconds.SelectionStart = 2
    End Sub
    Private Sub Shift_Forward()
        txtHours.Text = txtHours.Text.ElementAt(1) & txtMinutes.Text.ElementAt(0)
        txtMinutes.Text = txtMinutes.Text.ElementAt(1) & txtSeconds.Text.ElementAt(0)
        txtSeconds.Text = txtSeconds.Text.Substring(1)
        txtSeconds.SelectionStart = 2
    End Sub
    Private Sub Shift_Backward()
        txtSeconds.Text = txtMinutes.Text.ElementAt(1) & txtSeconds.Text.Substring(0, txtSeconds.Text.Length - 1)
        txtMinutes.Text = txtHours.Text.ElementAt(1) & txtMinutes.Text.ElementAt(0)
        txtHours.Text = "0" & txtHours.Text.ElementAt(0)
        txtSeconds.SelectionStart = 2
    End Sub
    Private Sub On_Enter(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, txtSeconds.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnOk_Click()
        End If
    End Sub
    Private Sub btnOk_Click() Handles btnOk.Click
        sd(calcSeconds())
    End Sub
    Private Function calcSeconds() As Integer
        Dim seconds As Integer = 0
        seconds = Convert.ToInt32(txtSeconds.Text) + Convert.ToInt32(txtMinutes.Text) * 60 + Convert.ToInt32(txtHours.Text) * 3600
        Return seconds
    End Function
    Private Sub btnCancel_Click() Handles btnCancel.Click
        System.Diagnostics.Process.Start(System.Environment.SystemDirectory & "\shutdown.exe", "/a")
        lblStatus_reset()
    End Sub
    Private Sub sd(seconds As Integer)
        System.Diagnostics.Process.Start(System.Environment.SystemDirectory & "\shutdown.exe", "/s /t " & seconds)
        setLblStatusTxt("0", "0", seconds.ToString)
    End Sub
    Private Sub lblStatus_reset()
        lblStatus.Visible = False
        lblStatus.Text = ""
        _timer.Enabled = False
    End Sub
    Private Sub setLblStatusTxt(Hours As String, Minutes As String, Seconds As String)
        Dim iSeconds As Integer = Convert.ToInt32(Seconds)
        Dim iMinutes As Integer = Convert.ToInt32(Minutes)
        Dim iHours As Integer = Convert.ToInt32(Hours)
        lblStatus.Visible = True
        iMinutes += Convert.ToInt32(ShiftCalc(iSeconds).Item(0))
        iSeconds = Convert.ToInt32(ShiftCalc(iSeconds).Item(1))
        iHours += Convert.ToInt32(ShiftCalc(iMinutes).Item(0))
        iMinutes = Convert.ToInt32(ShiftCalc(iMinutes).Item(1))
        Dim SecondAdd As String = ""
        Dim MinuteAdd As String = ""
        Dim HourAdd As String = ""
        If iSeconds <> 1 Then
            SecondAdd = "s"
        End If
        If iMinutes <> 1 Then
            MinuteAdd = "s"
        End If
        If iHours <> 1 Then
            HourAdd = "s"
        End If
        lblStatus.Text = "Shutdown in " & iHours & " Hour" & HourAdd & ", " & iMinutes & " Minute" & MinuteAdd & " and " & iSeconds & " Second" & SecondAdd
        _timer.Enabled = True
        _timer.Start()
    End Sub
    Private Function ShiftCalc(Seconds As Integer) As List(Of String)
        Dim result As List(Of String) = New List(Of String)
        result.Add(Int(Convert.ToDouble(Seconds) / Convert.ToDouble(60)).ToString)
        result.Add((Convert.ToDouble(Seconds) Mod 60).ToString)
        Return result
    End Function
    Private Sub _Timer_Tick() Handles _timer.Tick
        Dim Seconds As String = lblStatus.Text.Split(CChar(" "))(7)
        Dim Minutes As String = lblStatus.Text.Split(CChar(" "))(4)
        Dim Hours As String = lblStatus.Text.Split(CChar(" "))(2)
        Dim iSeconds As Integer = Convert.ToInt32(Seconds)
        Dim iMinutes As Integer = Convert.ToInt32(Minutes)
        Dim iHours As Integer = Convert.ToInt32(Hours)
        If iSeconds > 0 Then
            iSeconds -= 1
        Else
            iSeconds = 59
            If iMinutes > 0 Then
                iMinutes -= 1
            Else
                iMinutes = 59
                iHours -= 1
            End If
        End If
        setLblStatusTxt(iHours.ToString, iMinutes.ToString, iSeconds.ToString)
    End Sub
End Class
