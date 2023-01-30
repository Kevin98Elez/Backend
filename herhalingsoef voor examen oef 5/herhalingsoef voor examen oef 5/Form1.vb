Public Class Form1

    Dim naam As String = InputBox("geef uw naam in")
    Dim voornaam As String = InputBox("geef uw voornaam in")
    Dim rekeningnmr As String = InputBox("geef uw rekeningnummer in")


    Dim gender As String = InputBox("geef uw gender in")
    Dim zichtrekening As Integer = InputBox("hoeveel staat er op de zichtrekening?")
    Dim spaarrekening As Integer = InputBox("hoeveel staat er op de spaarrekening?")

    Dim rente As Integer = InputBox("uw rentevoet per jaar in %")
    Dim log As String = ""
    Dim log_nieuw As String = ""
    Dim x As Integer = 0
    Dim log_array(x) As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = naam
        TextBox2.Text = voornaam
        rekeningnmr = Format(rekeningnmr, "### ### ###")
        TextBox3.Text = rekeningnmr
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        Label5.Text = zichtrekening
        Label7.Text = spaarrekening
        CheckBox3.Checked = True



        If gender.ToUpper = "MAN" Then
            CheckBox1.Checked = True
        End If
        If gender.ToUpper = "VROUW" Then
            CheckBox2.Checked = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        'pond
        CheckBox3.Checked = False
        CheckBox5.Checked = False

        Label5.Text = zichtrekening
        Label7.Text = spaarrekening

        Dim euro_nieuw As Integer
        Dim spaarrekening_nieuw As Integer

        If CheckBox4.Checked Then
            euro_nieuw = zichtrekening * 0.88
            spaarrekening_nieuw = spaarrekening * 0.88
        End If
        Label5.Text = euro_nieuw
        Label7.Text = spaarrekening_nieuw

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        'euro
        CheckBox4.Checked = False
        CheckBox5.Checked = False

        Dim euro_nieuw As Integer
        Dim spaarrekening_nieuw As Integer

        If CheckBox3.Checked Then
            euro_nieuw = zichtrekening
            spaarrekening_nieuw = spaarrekening
        End If
        Label5.Text = euro_nieuw
        Label7.Text = spaarrekening_nieuw

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        'dollar
        CheckBox3.Checked = False
        CheckBox4.Checked = False


        Dim euro_nieuw As Integer
        Dim spaarrekening_nieuw As Integer

        If CheckBox5.Checked Then
            euro_nieuw = zichtrekening
            spaarrekening_nieuw = spaarrekening
        End If
        Label5.Text = euro_nieuw * 1.09
        Label7.Text = spaarrekening_nieuw * 1.09

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nieuw As Integer = InputBox("geef het toegevoegd bedrag in (in euro)")
        zichtrekening += nieuw
        If nieuw < 0 Then
            nieuw = Math.Abs(nieuw)
            Array.Resize(log_array, log_array.Length + 1)
            log_array(x) = (vbCrLf & "er is " & nieuw & " euro van uw zichtrekening gehaald")
            log &= (vbCrLf & "er is " & nieuw & " euro van uw zichtrekening gehaald")
            x += 1

        Else
            Array.Resize(log_array, log_array.Length + 1)
            log_array(x) = (vbCrLf & "er is " & nieuw & " euro aan uw zichtrekening toegevoegd")
            log &= (vbCrLf & "er is " & nieuw & " euro aan uw zichtrekening toegevoegd")
            x += 1

        End If

        Label5.Text = zichtrekening

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nieuw As Integer = InputBox("geef het toegevoegd bedrag in (in euro)")
        If zichtrekening + nieuw >= -250 Then
            zichtrekening -= nieuw
            spaarrekening += nieuw
        End If


        If nieuw > 0 And zichtrekening >= 0 Then
            Array.Resize(log_array, log_array.Length + 1)
            log_array(x) = (vbCrLf & "er is " & nieuw & " euro van uw zichtrekening gehaald en op uw spaarrekening gezet")
            log &= (vbCrLf & "er is " & nieuw & " euro van uw zichtrekening gehaald en op uw spaarrekening gezet")
            x += 1

        End If
        If nieuw < 0 And spaarrekening >= 0 Then
            nieuw = Math.Abs(nieuw)
            Array.Resize(log_array, log_array.Length + 1)
            log_array(x) = (vbCrLf & "er is " & nieuw & " euro van uw spaarrekening gehaald en op uw zichtrekening gezet")
            log &= (vbCrLf & "er is " & nieuw & " euro van uw spaarrekening gehaald en op uw zichtrekening gezet")
            x += 1
        End If

        Label5.Text = zichtrekening
        Label7.Text = spaarrekening

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        For x = 0 To x
            log_nieuw &= log_array(x)
        Next


        MsgBox(log_nieuw)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim y As Integer = InputBox("welke handeling wilt u bekijken?")
        MsgBox(log_array(y - 1))
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim jaren As Integer = InputBox("hoeveel jaren wil u sparen?")
        Dim spaarrekening_extra As Integer = spaarrekening
        Dim extra(jaren) As Integer
        Dim y As Integer = spaarrekening
        Dim z As Integer = 0
        For jaren = 0 To jaren
            extra(jaren) = y * (rente / 100)
            z += extra(jaren)
        Next


        Dim spaarrekening_rente As Integer = 0

        spaarrekening_extra = spaarrekening + z
        MsgBox("na " & jaren - 1 & " jaren te hebben gespaard, zal er " & spaarrekening_extra & " op uw spaarrekening staan")
        MsgBox("na " & jaren - 1 & " jaren te hebben gespaard, zal er " & z & " euro extra op uw rekening staan")

    End Sub
End Class
