Module Module1

    Sub Main()
        Dim str3 As String = ""
        Dim str2 As String = ""
        Dim str1 As String = ""
        Dim str4 As String = ""

        Console.Write("Enter string: ")
        str1 = Console.ReadLine()
            str2 = Left(str1, 2)
            str3 = Right(str1, 2)

        If Len(str1) <= 2 Then
            Console.WriteLine("Both Ends: ")
            Console.ReadKey()
        Else

            Console.WriteLine("Both Ends:" & str2 & str3)
            Console.ReadKey()
        End If


    End Sub

End Module
