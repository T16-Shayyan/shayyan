Module Module1

    Sub Main()
        Dim donutcount As Integer = 0

        Console.Write("Enter the Number of donuts: ")
        donutcount = Console.ReadLine()
        If donutcount <= 9 Then
            Console.WriteLine("Number of donuts: " & donutcount)
            Console.ReadKey()
        Else
            Console.WriteLine("Number of donuts: Many")
            Console.ReadKey()
        End If

    End Sub

End Module
