Module Module1

    Sub Main()

        Dim str1 As String = ""
        Dim char1 As Char = ""
        Dim char2 As Char = ""
        Dim spos As String = " "
        Dim count As Integer = 0
        Dim hchar As Char = ""
        Dim count2 As Integer = 0
        Dim nchar As Integer = 0
        Dim hnum As Integer = 0

        Console.Write("Input a string: ")
        str1 = Console.ReadLine()
        For count = 1 To Len(str1)
            nchar = 0
            char1 = Mid(str1, count, 1)

            For count2 = 1 To Len(str1)

                char2 = Mid(str1, count2, 1)
                If char1 = char2 Then
                    nchar = nchar + 1
                End If
                If nchar > hnum Then
                    hnum = nchar
                    hchar = char2



                End If
            Next


        Next

        Console.WriteLine("most repeated character is: " & hchar)
        Console.ReadKey()
        Console.WriteLine("Repeated times: " & nchar)
        Console.ReadKey()
    End Sub

End Module
