Imports System.Text

Public Class Tool

    'ensure form is in the middle of the screen
    Public Shared Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)

        Dim r As Rectangle
        If parent IsNot Nothing Then
            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)
    End Sub
    'copy file from one destination to another destination
    Public Shared Sub copyFile(ByVal sourceFileUrl As String, ByVal destinationFileUrl As String)
        My.Computer.FileSystem.CopyFile(
        sourceFileUrl,
        destinationFileUrl,
        Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
    End Sub
    'concat string list's element by using ","
    Public Shared Function jointArray(ByVal List As List(Of String)) As String


        Dim sb As New StringBuilder
        For Each a As String In List
            sb.Append(a & ",")
        Next
        Dim jointString As String = sb.ToString.Substring(0, sb.Length - 1)
        Return jointString
    End Function

End Class
