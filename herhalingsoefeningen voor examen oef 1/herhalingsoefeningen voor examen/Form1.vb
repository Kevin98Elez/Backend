Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gebruikersnaam As String = TextBox1.Text
        Dim wachtwoord As String = TextBox2.Text
        Dim nummers As Integer = 0

        Dim myChars() As Char = wachtwoord.ToCharArray()
        For Each ch As Char In myChars
            If Char.IsDigit(ch) Then
                nummers += 1
            End If
        Next


        If wachtwoord.Length < 8 Then
            MsgBox("te weinig tekens in het wachtwoord")
            TextBox2.Text = ""

        ElseIf nummers < 1 Then
            MsgBox("wachtwoord moet een cijfer bevatten")

        ElseIf gebruikersnaam = "" Then
            MsgBox("gelieve een gebruikersnaam in te geven")
        Else
            MsgBox("u bent ingelogd")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If



    End Sub
End Class

