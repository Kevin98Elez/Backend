Public Class Form1


    Private Function som(ByVal x, ByVal y)

        Return x + y

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim getal_1 As Double = InputBox("geef getal 1 in")
        Dim getal_2 As Double = InputBox("geef getal 2 in")


        MsgBox(som(getal_1, getal_2))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim getal_1 As String = InputBox("geef woord 1 in")
        Dim getal_2 As String = InputBox("geef woord 2 in")

        MsgBox(som(getal_1, getal_2))
    End Sub
End Class
