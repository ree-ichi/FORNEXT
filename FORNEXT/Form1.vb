Public Class Form1
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        txtoutput.Clear()
        For i As Double = 1 To 10 Step 0.5
            txtoutput.AppendText("FOR NEXT KE: " & i & vbCrLf)
            If i = 4 Then
                Exit For
            End If
        Next
    End Sub

    Private Sub btnWhileWend_Click(sender As Object, e As EventArgs) Handles btnWhileWend.Click
        txtoutput.Clear()
        Dim i As Integer = 0
        While i <= 10
            txtoutput.AppendText("WHILE WEND KE: " & i & vbCrLf)
            i += 2
        End While
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtoutput.Clear()
    End Sub
End Class
