Module Module1

    Sub Main()
        Dim str1 As String = ""
        Dim thischar As Char = ""
        Dim vowelno As Integer = 0
        Dim count As Integer = 0

        Console.Write("Input string: ")
        str1 = LCase(Console.ReadLine)
        vowelno = 0
        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)

            If (thischar = "a" Or thischar = "e" Or thischar = "i" Or thischar = "o" Or thischar = "u") Then

                vowelno = vowelno + 1


            End If
        Next
        Console.WriteLine("Number of Vowels are: " & vowelno)
        Console.ReadKey()
    End Sub

End Module
