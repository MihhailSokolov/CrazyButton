Module ScoreSaveModule
    Public Sub ScoreSave(ByVal dir As String, ByVal score As Integer)
        Dim OldScore As Integer
        If System.IO.File.Exists(dir) Then
            System.IO.File.SetAttributes(dir, IO.FileAttributes.Normal)
        End If
        Dim Read As New System.IO.StreamReader(dir)
        If Read.ReadLine <> "" And IsNumeric(Read.ReadLine) = True Then
            OldScore = Val(Read.ReadLine)
        End If
        Read.Close()
        Dim record As New System.IO.StreamWriter(dir)
        If score < OldScore Then
            score = OldScore
        End If
        record.Write(score)
        record.Close()
        System.IO.File.SetAttributes(dir, IO.FileAttributes.ReadOnly Or IO.FileAttributes.Hidden)
    End Sub
End Module
