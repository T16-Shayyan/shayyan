Module Module1

    Sub Main()
        Dim char1 As Char = ""
        Dim str1 As String = ""
        Dim count As Integer = 0
        Dim count2 As Integer = 0
        Dim specialcount As Integer = 0
        Dim alphacount As Integer = 0
        Dim nocount As Integer = 0
        Dim thischar As Char = ""
        Dim total As Integer = 0
        Dim char2 As Char = ""
        Dim char1count As Integer = 0


        Console.Write("Enter String: ")
        str1 = LCase(Console.ReadLine)
        Console.Write("Enter Character: ")
        char1 = LCase(Console.ReadLine)

        For count2 = 1 To Len(str1)
            char2 = Mid(str1, count2, 1)
            If char2 = char1 Then
                char1count = char1count + 1

            End If
        Next
        Console.WriteLine("Number of entered character is: " & char1count)
        Console.ReadKey()

        For count = 1 To Len(str1)
            thischar = Mid(str1, count, 1)
            If (thischar >= "a" And thischar <= "z") Then
                alphacount = alphacount + 1
            ElseIf (Asc(thischar) >= 48 And Asc(thischar) <= 57) Then

                nocount = nocount + 1

            Else : specialcount = specialcount + 1
            End If
            total = specialcount + alphacount + specialcount

        Next
        total = specialcount + alphacount + nocount
        Console.WriteLine("Total Number of characters are: " & total)
        Console.ReadKey()
        Console.WriteLine("Alpha Count: " & alphacount)
        Console.ReadKey()
        Console.WriteLine("Number Count:" & nocount)
        Console.ReadKey()
        Console.WriteLine("Special Character Count: " & specialcount)
        Console.ReadKey()

    End Sub


End Module
