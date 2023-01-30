Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lopen As Boolean = False
        Dim optrekken As Integer = 0
        Dim situps As Integer = 0
        Dim opdrukken As Integer = 0
        Dim gesprongen As Double = 0
        Dim input_lopen As String = ""

        'lopen

        'testaanpassing

        Do While lopen = False
            input_lopen = InputBox("heb je 10km in een uur gelopen?" & vbCrLf & "schrijf ja als het lukte," & vbCrLf & "schrijf nee als het niet lukte")
            Dim output_lopen As String = input_lopen.ToUpper()
            If output_lopen = "NEE" Then
                MsgBox("begin met looptraining")

            End If
            If output_lopen = "JA" Then
                lopen = True

            End If
        Loop

        MsgBox("geslaagd met lopen")

        'krachttraining

        Do While optrekken < 12
            optrekken = InputBox("hoeveel keer kon je jezelf optrekken?")
            If optrekken < 12 Then
                MsgBox("start met krachttraining")
            End If
        Loop

        Do While situps < 60
            situps = InputBox("hoeveel situps kon je doen?")
            If situps < 60 Then
                MsgBox("start met krachttraining")
            End If
        Loop

        Do While opdrukken < 30
            opdrukken = InputBox("hoeveel keer kon je jezelf opdrukken?")
            If opdrukken < 30 Then
                MsgBox("start met krachttraining")
            End If
        Loop

        MsgBox("geslaagd met krachttraining")

        'verspringen

        Dim vereisten_verspringen As Double = InputBox("geef in hoeveel meter je moet springen")

        Do While gesprongen < vereisten_verspringen
            gesprongen = InputBox("hoe ver heb je gesprongen?")
            If gesprongen < vereisten_verspringen Then
                MsgBox("start de training met verspringen")
            End If
        Loop

        MsgBox("je mag meedoen met de normale training")

    End Sub
End Class
