' Name:         frmPrime20.vb
' Solution:     Quiz to decide number between 1 to 20 that is prime or not.
' Programmer:   Aashit Patel on 05-02-2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmPrime20
    Dim blRunning As Boolean = False
    ' Dim intMiliSeconds As Integer
    ' Dim intSeconds As Integer
    'Dim intMinutes As Integer
    'Dim intHours As Integer
    Dim startTime As DateTime
    Dim intAns As Integer ' Use as a flag for answer.
    Dim intCount As Integer = 0 'Counter for number of questions.

    Dim randGen As New Random
    Dim intNum As Integer
    Dim intPrimeLimit As Integer = 5
    Const intPrimeUpTo As Integer = 20
    Dim intLevel As Integer = 0

    Dim Rand As New Random()

    'Declare variable for Assessment object.
    Dim result As New Assessment

    ' Function to check prime number.
    Function IsPrime(number As Integer) As Boolean
        Dim i As Integer
        If number = 1 Then
            Return False
        End If
        If number = 2 Then
            Return True
        End If
        For i = 2 To (number - 1)
            If (number Mod i = 0) Then
                Return False
                Exit For
            End If
        Next i
        Return True
    End Function

    'Set the visibilty of solution.
    Public Function ShowSolution() As Integer
        lblWrong.Visible = True
        lblCorrect.Visible = True
        lblCorrectAns.Visible = True
        grpRemmeber.Visible = True
        grpSolve.Visible = True
        btnSubmit.Visible = False
        btnGotIt.Visible = True
        lblYes.Enabled = False
        lblNo.Enabled = False
        Return 0
    End Function

    Public Function SetlblDefault() As Integer
        lblYes.Font = New Font(lblYes.Font, FontStyle.Regular)
        lblYes.BackColor = Color.LightSteelBlue
        lblNo.Font = New Font(lblNo.Font, FontStyle.Regular)
        lblNo.BackColor = Color.LightSteelBlue
        btnSubmit.Visible = False
        Return 0
    End Function
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ' To start clock when form loads
        startTime = DateTime.Now
        blRunning = True
        Timer.Enabled = True
        Timer.Start()

        intNum = randGen.Next(1, 6)
        lblQNum.Text = intNum.ToString
    End Sub

    ' To generate timer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        'intMiliSeconds += 1
        'If intMiliSeconds = 1000 Then
        'intMiliSeconds = 0
        'intSeconds += 1
        'If (intSeconds = 60) Then
        'intSeconds = 0
        'intMinutes += 1
        'If (intMinutes = 60) Then
        'intMinutes = 0
        'intHours += 1
        'End If
        'End If
        'End If
        ' End If
        '        lblTimer.Text = intHours.ToString("D2") & ":" _
        '                           & intMinutes.ToString("d2") & ":" _
        '                          & intSeconds.ToString("d2")

        Dim diff As TimeSpan = DateTime.Now - startTime
        'result.GetTimer()
        lblTimer.Text = diff.ToString("hh\:mm\:ss")
    End Sub

    Private Sub lblYes_Click(sender As Object, e As EventArgs) Handles lblYes.Click
        lblYes.BackColor = Color.LightGreen
        lblYes.Font = New Font(lblYes.Font, FontStyle.Bold)
        lblNo.Font = New Font(lblNo.Font, FontStyle.Regular)
        lblNo.BackColor = Color.LightSteelBlue
        btnSubmit.Visible = True
        intAns = 0
    End Sub

    Private Sub lblNo_Click(sender As Object, e As EventArgs) Handles lblNo.Click
        lblNo.BackColor = Color.LightGreen
        lblNo.Font = New Font(lblNo.Font, FontStyle.Bold)
        lblYes.Font = New Font(lblYes.Font, FontStyle.Regular)
        lblYes.BackColor = Color.LightSteelBlue
        btnSubmit.Visible = True
        intAns = 1
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim blPrime As Boolean
        Dim intScore As Integer
        Dim intPrime As Integer

        ' Assign values to object's properties.
        Integer.TryParse(lblCount.ToString, result.Count)
        Integer.TryParse(lblSmartScore.ToString, result.SmartScore)

        Integer.TryParse(lblQNum.Text, intPrime)
        blPrime = IsPrime(intPrime)

        If blPrime = True Then
            If intAns = 0 Then
                MessageBox.Show("Good Job!")
                result.GetQuestionCount()
                result.IncreaseScore()
                intLevel += 1
                If intLevel = 5 Then
                    intPrimeLimit += 5
                    intLevel = 0
                End If
            Else
                result.GetQuestionCount()
                result.DecreaseScore()
                intLevel = 0
                'Show the solution with correction.
                ShowSolution()
                lblCorrectAns.Text = "Yes"
                lblRemember.Text = "The Only factors of a prime number are 1 and itself"
                lblSolve.Text = "The only factors of " + intNum.ToString + " are 1 and " _
                                 + intNum.ToString + " so " + intNum.ToString + " is a prime number."
                Exit Sub
            End If
        End If

        If blPrime = False Then
            If intAns = 1 Then
                MessageBox.Show("Good Job!")
                result.GetQuestionCount()
                result.IncreaseScore()
                intLevel += 1
                If intLevel = 5 Then
                    intPrimeLimit += 5
                    intLevel = 0
                End If
            Else
                result.GetQuestionCount()
                result.DecreaseScore()
                intLevel = 0
                'Show the solution with correction.
                ShowSolution()
                lblCorrectAns.Text = "No"
                If intNum = 1 Then
                    lblRemember.Text = "1 is neither Prime nor Composite."
                    lblSolve.Text = "1 is not a Prime number."

                Else
                    lblRemember.Text = "The Only factors of a prime number are 1 and itself"
                    lblSolve.Text = intNum.ToString + " has factors other than 1 and itself so " +
                                        intNum.ToString + " is not a prime number."
                End If
                Exit Sub
            End If
        End If

        'To set both lables to normal style.
        SetlblDefault()

        ' Display number of question attended.
        lblCount.Text = result.Count.ToString
        lblSmartScore.Text = result.SmartScore.ToString

        'Get value of Smart Score.
        Integer.TryParse(lblSmartScore.Text, intScore)

        result.GetRibbon()
        Select Case intScore
            Case >= 90
                RibbonGold.Visible = result.Ribbon
            Case >= 80
                RibbonSilver.Visible = result.Ribbon
            Case >= 70
                RibbonBronze.Visible = result.Ribbon
        End Select

        ' Generate random number up to 20 untill mastery.
        If intScore = 100 Then
            frmFinish.Show()
        Else
            If intPrimeLimit <= intPrimeUpTo Then
                intNum = randGen.Next(1, intPrimeLimit + 1)
                lblQNum.Text = intNum.ToString
            Else
                intNum = randGen.Next(1, intPrimeUpTo + 1)
                lblQNum.Text = intNum.ToString
            End If
        End If
    End Sub

    Private Sub btnGotIt_Click(sender As Object, e As EventArgs) Handles btnGotIt.Click
        lblWrong.Visible = False
        lblCorrect.Visible = False
        lblCorrectAns.Text = String.Empty
        lblCorrectAns.Visible = False
        grpRemmeber.Visible = False
        grpSolve.Visible = False
        btnGotIt.Visible = False
        lblYes.Enabled = True
        lblNo.Enabled = True

        'To set button and both lables to normal style.
        SetlblDefault()

        If intPrimeLimit <= intPrimeUpTo Then
            intNum = randGen.Next(1, intPrimeLimit + 1)
            lblQNum.Text = intNum.ToString
        Else
            intNum = randGen.Next(1, intPrimeUpTo + 1)
            lblQNum.Text = intNum.ToString
        End If
    End Sub

    Private Sub frmPrime20_Closing(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.Close()
    End Sub
End Class
