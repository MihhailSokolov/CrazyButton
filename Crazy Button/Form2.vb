Public Class Form2
    Dim bDrag As Boolean
    Dim cx, cy, dx, dy As Single
    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        bDrag = True : dx = e.X : dy = e.Y : cx = Me.Left : cy = Me.Top
    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If bDrag Then
            cx = cx + e.X - dx : cy = cy + e.Y - dy
            Me.Location = New Point(cx, cy)
        End If
    End Sub

    Private Sub Form2_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        bDrag = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then Me.Visible = False : Form3.Visible = True
        If RadioButton2.Checked = True Then Me.Visible = False : Form4.Visible = True
        If RadioButton3.Checked = True Then Me.Visible = False : Form5.Visible = True
        If RadioButton4.Checked = True Then Me.Visible = False : Form6.Visible = True
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then Button1.Enabled = True
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then Button1.Enabled = True
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then Button1.Enabled = True
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then Button1.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Visible = True
    End Sub
    Private Sub Form2_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = Me.CreateGraphics
        g.DrawLine(Pens.Black, 0, 0, Me.Width, 0)
        g.DrawLine(Pens.Black, 0, 0, 0, Me.Height)
        g.DrawLine(Pens.Black, Me.Width - 1, Me.Height, Me.Width - 1, 0)
        g.DrawLine(Pens.Black, 0, Me.Height - 1, Me.Width, Me.Height - 1)
    End Sub
End Class