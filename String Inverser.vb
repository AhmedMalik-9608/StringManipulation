Module Module1

    Sub Main()
        Dim InitialStr, FinalStr, CharToExamine As String
        Dim Count As Integer

        Count = 0
        FinalStr = ""
        InitialStr = ""

        Console.Write("Enter The String to Inverse: ")
        InitialStr = Console.ReadLine

        For Count = 1 To Len(InitialStr)
            CharToExamine = Mid(InitialStr, Count, 1)
            FinalStr = CharToExamine & FinalStr
        Next

        Console.WriteLine("The Inverse of the String is: " & FinalStr)
        Console.ReadKey()

    End Sub

End Module
