Public Class Form3
    'Easy Mode
    Dim dx As Integer = 3
    Dim dy As Integer = 4.5
    Dim size1 As Integer
    Dim x, y As Integer
    Dim score As Integer
    Dim time As Integer = 60
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If msg.WParam.ToInt32() = CInt(Keys.Enter) Or msg.WParam.ToInt32() = CInt(Keys.Space) Then
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = score + 1
        Label2.Text = score
        Label2.Refresh()
    End Sub
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form2.Visible = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        size1 = Button1.Height
        x = Button1.Left
        y = Button1.Top
    End Sub
    Private Sub Form3_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = Me.CreateGraphics
        g.DrawLine(Pens.Black, 0, 400, 500, 400)
        g.DrawLine(Pens.Black, 0, 0, Me.Width, 0)
        g.DrawLine(Pens.Black, 0, 0, 0, Me.Height)
        g.DrawLine(Pens.Black, Me.Width - 1, Me.Height, Me.Width - 1, 0)
        g.DrawLine(Pens.Black, 0, Me.Height - 1, Me.Width, Me.Height - 1)
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        time = time - 1
        Label4.Text = time
        Label4.Refresh()
        If time = 0 Then
            Timer2.Enabled = False
            Timer1.Enabled = False
            MsgBox("Game Over. Your score is " & score)
            ScoreSave("C:\Crazy Button\Scores\EasyModeBest.txt", score)
            Me.Close()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + dx
        y = y + dy
        Button1.Left = x
        Button1.Top = y
        If x < 0 Or x > 500 - size1 - size1 + 30 Then dx = -dx
        If y < 0 Or y > 400 - size1 - 4 Then dy = -dy
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = True
        Button1.Enabled = True
        Button1.Text = "Click me!"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = False
        Button1.Enabled = False
        Button2.Text = "Resume"
        Button1.Text = ""
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Me.Close()
    End Sub
End Class