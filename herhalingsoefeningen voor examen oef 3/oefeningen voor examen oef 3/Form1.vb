Public Class Form1
    Dim percentage(9) As Double
    Dim score(9) As Double
    Dim x As Integer
    Dim schrijven As String = ""
    Dim totaal As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        schrijven = ""
        totaal = InputBox("op hoeveel gaat de test?")

        For x = 0 To 9
            score(x) = InputBox("geef de score in voor leerling " & x + 1)
            schrijven += ("score van leerling " & x + 1 & " = " & score(x) & " op " & totaal & vbCrLf)
        Next
        MsgBox(schrijven)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim y As Integer = InputBox("van welke leerling wilt u de score aanpassen?")
        score(y - 1) = InputBox("geef de score in voor leerling " & y)
        schrijven = ""

        For x = 0 To 9
            schrijven += ("score van leerling " & x + 1 & " = " & score(x) & vbCrLf)
        Next
        MsgBox(schrijven)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(schrijven)
        Dim percentage_string As String = ""

        For x = 0 To 9
            percentage(x) = Math.Round((score(x) / totaal * 100), 2)
        Next
        For x = 0 To 9
            percentage_string += ("score van leerling " & x + 1 & " = " & percentage(x) & "%" & vbCrLf)
        Next
        MsgBox(percentage_string)
    End Sub
End Class
