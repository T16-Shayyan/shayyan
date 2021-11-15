Module Module1

    Sub Main()
        Dim str As String = ""
        Dim newstr As String = ""
        Dim char1 As Char = ""
        Dim thischar As Char = ""
        Dim newchar As Char = ""
        Dim count As Integer = 0

        Console.Write("Enter string: ")
        str = Console.ReadLine()
        Console.Write("Enter old char: ")
        char1 = Console.ReadLine()
        Console.Write("Enter new char: ")
        newchar = Console.ReadLine()

        For count = 1 To Len(str)
            thischar = Mid(str, count, 1)
            If thischar = char1 Then
                thischar = newchar
            End If
            newstr = newstr & thischar

        Next

        Console.WriteLine("New String: " & newstr)

        Console.ReadKey()

    End Sub

End Module
