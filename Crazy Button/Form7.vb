Public Class Form7
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
        Me.Close()
    End Sub

    Private Sub Form7_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim g As Graphics = Me.CreateGraphics
        g.DrawLine(Pens.Black, 0, 0, Me.Width, 0)
        g.DrawLine(Pens.Black, 0, 0, 0, Me.Height)
        g.DrawLine(Pens.Black, Me.Width - 1, Me.Height, Me.Width - 1, 0)
        g.DrawLine(Pens.Black, 0, Me.Height - 1, Me.Width, Me.Height - 1)
    End Sub

    Private Sub Form7_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim EasyBest As Integer
        If System.IO.File.Exists("C:\Crazy Button\Scores\EasyModeBest.txt") Then
            Dim read1 As New System.IO.StreamReader("C:\Crazy Button\Scores\EasyModeBest.txt")
            EasyBest = Val(read1.ReadLine)
            read1.Close()
        Else
            EasyBest = 0
        End If

        Dim NormalBest As Integer
        If System.IO.File.Exists("C:\Crazy Button\Scores\NormalModeBest.txt") Then
            Dim read2 As New System.IO.StreamReader("C:\Crazy Button\Scores\NormalModeBest.txt")
            NormalBest = Val(read2.ReadLine)
            read2.Close()
        Else
            NormalBest = 0
        End If

        Dim HardBest As Integer
        If System.IO.File.Exists("C:\Crazy Button\Scores\HardModeBest.txt") Then
            Dim read3 As New System.IO.StreamReader("C:\Crazy Button\Scores\HardModeBest.txt")
            HardBest = Val(read3.ReadLine)
            read3.Close()
        Else
            HardBest = 0
        End If
        
        Dim ExtremeBest As Integer
        If System.IO.File.Exists("C:\Crazy Button\Scores\ExtremeModeBest.txt") Then
            Dim read4 As New System.IO.StreamReader("C:\Crazy Button\Scores\ExtremeModeBest.txt")
            ExtremeBest = Val(read4.ReadLine)
            read4.Close()
        Else
            ExtremeBest = 0
        End If

        Label3.Text = EasyBest
        Label5.Text = NormalBest
        Label7.Text = HardBest
        Label9.Text = ExtremeBest
    End Sub
End Class