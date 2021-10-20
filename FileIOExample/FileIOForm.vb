Public Class FileIOForm
    Private Sub FileIOForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WriteFile()
    End Sub

    Sub WriteFile()
        'Absolute path
        'Dim fileName As String = "C:\Users\ellio\source\repos\FileIOExampleExampleF21.txt"

        'Relative path  ../ means go up a diretory
        Dim fileName As String = "../../ExampleF21.txt"

        FileOpen(1, fileName, OpenMode.Output)

        FileClose(1)


    End Sub
End Class
