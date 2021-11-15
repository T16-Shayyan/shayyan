
Module module1



    Sub Main()
        Dim string1 As String = ""
        Dim count As Integer = 0
        Dim thischar As Char = ""
        Dim truefalse As Boolean
        Console.Write("INPUT: ")
        string1 = LCase(Console.ReadLine)

        For count = 1 To Len(string1)
            thischar = Mid(string1, count, 1)
            If (thischar >= "a" And thischar <= "z") Then

                truefalse = True
            Else
                truefalse = False
            End If

        Next
        Console.WriteLine("Only Alphabets: " & truefalse)
        Console.ReadKey()
    End Sub

End Module
