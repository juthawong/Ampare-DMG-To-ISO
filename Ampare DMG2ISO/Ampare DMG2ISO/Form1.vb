Imports System.IO
Public Class Form1
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            If File.Exists("dmg2img.exe") Then
                Process.Start("cmd", "/C dmg2img.exe """ + OpenFileDialog1.FileName + """ """ + SaveFileDialog1.FileName + """")
                MsgBox("Command Has Been Executed, This Application Act As GUI to DMG2IMG For Everyday User", MsgBoxStyle.Information, "Thank you for using Ampare DMG2ISO")
            Else
                MsgBox("DMG2IMG is not Found", MsgBoxStyle.Exclamation, "Oops!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub
End Class
