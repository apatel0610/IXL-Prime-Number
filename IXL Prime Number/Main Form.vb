' Name:         Main Form.vb
' Solution:     Display two buttons for selection.
' Programmer:   Aashit Patel on 05-02-2018

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        Me.Hide()
        frmPrime20.Show()
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        Me.Hide()
        frmPrime100.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class