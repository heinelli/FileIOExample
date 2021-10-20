Public Class FileIOForm
    Private Sub FileIOForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WriteFile()
    End Sub

    Sub WriteFile()
        Dim fileName As String = "ExampleF21.txt"

        FileOpen(1, fileName, OpenMode.Input)

        FileClose(1)


    End Sub
End Class
