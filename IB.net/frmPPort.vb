Option Explicit On

Imports System.Drawing.Printing

Public Class frmPPort

    Private Sub frmPPort_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim pkInstalledPrinters As String

        GetWindowPos(Me, 200, 200)

        ' Find all printers installed
        For Each pkInstalledPrinters In PrinterSettings.InstalledPrinters
            lstPrinters.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters

        ' Set the combo to the first printer in the list
        lstPrinters.SelectedIndex = 0

        ''Get printers
        'Dim P As Printer

        'For Each P In Printers
        '    If UCase(P.Port) <> "FILE:" Then
        '        lstPrinters.AddItem P.DeviceName
        '    End If
        'Next

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub lstPrinters_DoubleClick(sender As Object, e As EventArgs) Handles lstPrinters.DoubleClick

        cmdOK.PerformClick()

    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click

        Dim PName As String

        If lstPrinters.Items.Count > 0 Then
            PName = lstPrinters.SelectedItem

            For Each pkInstalledPrinters In PrinterSettings.InstalledPrinters
                If pkInstalledPrinters = PName Then
                End If
            Next pkInstalledPrinters
            'For Each P In Printers
            '    If P.DeviceName = PName Then
            '        PPort = P.Port
            '        PPort2 = P.DeviceName
            '        Exit For
            '    End If
            'Next
        End If

        Me.Close()

    End Sub
End Class