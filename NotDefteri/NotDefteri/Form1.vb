Public Class Form1

    Private Sub ButtonSil_Click(sender As Object, e As EventArgs) Handles ButtonSil.Click
        Dim Metin As String = TextBox1.Text.Trim
        Dim YeniMetin As String = Metin(0)
        For i = 1 To Metin.Length - 1
            If Metin(i - 1) <> " " Then
                YeniMetin &= Metin(i)
            ElseIf Metin(i) <> " " Then
                YeniMetin &= Metin(i)
            End If
        Next
        TextBox1.Text = YeniMetin
    End Sub
End Class
