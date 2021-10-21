Public Class FileIOForm
    Private Sub FileIOForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WriteFile()
        AppendFile()
        ReadRecords()
        Me.Close()
    End Sub

    Sub WriteFile()
        'Absolute path
        'Dim fileName As String = "C:\Users\ellio\source\repos\FileIOExampleExampleF21.txt"

        'Relative path  ../ means go up a diretory
        Dim fileName As String = "../../ExampleF21.txt"

        FileOpen(1, fileName, OpenMode.Output)

        'Write to text file. Quotation marks will be included in text.
        Write(1, "This is a test.")

        FileClose(1)

    End Sub

    Sub AppendFile()
        Dim fileName As String = "../../ExampleF21.txt"

        'Append to the end of file.
        FileOpen(1, fileName, OpenMode.Append)

        WriteLine(1, "Follow the white rabbit.")
        Write(1, "Why am I following the rabbit?")

        WriteLine(1, "Zone 1", SPC(10), "Zone 2")

        FileClose(1)

    End Sub

    Sub ReadLines()

    End Sub

    Sub ReadRecords()
        Dim fileName As String = "../../ExampleF21.txt"
        Dim recordData As String

        FileOpen(1, fileName, OpenMode.Input)

        For i = 0 To 3
            Input(1, recordData)
            Console.WriteLine(recordData)
        Next

        FileClose(1)
    End Sub
End Class
