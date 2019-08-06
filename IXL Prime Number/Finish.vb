' Name:         frmFinish.vb
' Solution:     Display Congratulation Gif.
' Programmer:   Aashit Patel on 05-02-2018

Option Explicit On
Option Strict On
Option Infer Off

Imports System.ComponentModel

Public Class frmFinish

    Private Sub frmFinish_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmPrime20.Close()
        frmPrime100.Close()
        frmMain.Close()
    End Sub

    Private Sub frmFinish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

End Class