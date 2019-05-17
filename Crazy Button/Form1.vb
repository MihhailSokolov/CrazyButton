Public Class Form1
    Dim bDrag As Boolean
    Dim cx, cy, dx, dy As Single
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        bDrag = True : dx = e.X : dy = e.Y : cx = Me.Left : cy = Me.Top
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If bDrag Then
            cx = cx + e.X - dx : cy = cy + e.Y - dy
            Me.Location = New Point(cx, cy)
        End If
    End Sub
    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        bDrag = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form2.Visible = True
        System.IO.Directory.CreateDirectory("C:\Crazy Button\Scores")
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("To play press 'Start!' then select difficulty you want. After that press button 'Play' and enjoy the game. Now the button is crazy, you must click on this button. But firstly you must catch this Crazy Button...                                                                         When you want to change difficulty or exit, just close the window and then if you want to change difficulty, change it. Or if you want to exit press 'Back' or close the window and then press 'Exit' or close the window again.")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form7.Show()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = Me.CreateGraphics
        g.DrawLine(Pens.Black, 0, 0, Me.Width, 0)
        g.DrawLine(Pens.Black, 0, 0, 0, Me.Height)
        g.DrawLine(Pens.Black, Me.Width - 1, Me.Height, Me.Width - 1, 0)
        g.DrawLine(Pens.Black, 0, Me.Height - 1, Me.Width, Me.Height - 1)
    End Sub
End Class