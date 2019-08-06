' Name:         Assessment.vb
' Programmer:   Aashit Patel on 05-02-2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class Assessment
    Private intCounter As Integer
    Private startTime As DateTime
    Private intSmartScore As Integer
    Private blRibbon As Boolean

    Public ReadOnly Property Count As Integer
        Get
            Return intCounter
        End Get
    End Property

    Public ReadOnly Property Timer As DateTime
        Get
            Return startTime
        End Get
    End Property

    Public ReadOnly Property SmartScore As Integer
        Get
            Return intSmartScore
        End Get
    End Property

    Public ReadOnly Property Ribbon As Boolean
        Get
            Return blRibbon
        End Get
    End Property

    Public Sub New()
        intCounter = 0
        startTime = DateTime.Now
        intSmartScore = 0
        blRibbon = False
    End Sub

    Public Sub GetQuestionCount()
        intCounter = intCounter + 1
    End Sub

    Public Sub GetTimer()

    End Sub

    Public Sub IncreaseScore()
        Select Case intSmartScore
            Case 0 To 10
                intSmartScore += 10
            Case 11 To 20
                intSmartScore += 9
            Case 21 To 30
                intSmartScore += 8
            Case 31 To 40
                intSmartScore += 7
            Case 41 To 50
                intSmartScore += 6
            Case 51 To 60
                intSmartScore += 5
            Case 61 To 70
                intSmartScore += 4
            Case 71 To 80
                intSmartScore += 3
            Case 81 To 90
                intSmartScore += 2
            Case 91 To 99
                intSmartScore += 1
        End Select
    End Sub

    Public Sub DecreaseScore()
        Select Case intSmartScore
            Case 0
                intSmartScore = 0
            Case 1 To 10
                intSmartScore -= 1
            Case 11 To 20
                intSmartScore -= 2
            Case 21 To 30
                intSmartScore -= 2
            Case 31 To 40
                intSmartScore -= 3
            Case 41 To 50
                intSmartScore -= 3
            Case 51 To 60
                intSmartScore -= 4
            Case 61 To 70
                intSmartScore -= 5
            Case 71 To 80
                intSmartScore -= 6
            Case 81 To 90
                intSmartScore -= 7
            Case 91 To 99
                intSmartScore -= 8
        End Select
    End Sub

    Public Sub GetRibbon()
        blRibbon = True
    End Sub

End Class
