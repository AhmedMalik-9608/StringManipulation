Module Module1

    Sub Main()
        Dim Str1, FinalStr, charToRemove, replacingChar, CurrentChar As String
        Dim Count As Integer

        Count = 0
        Str1 = ""
        FinalStr = ""
        charToRemove = ""
        replacingChar = ""

        Console.Write("Enter the string to Modify: ")
        Str1 = Console.ReadLine

        Console.Write("Enter the Character to be removed: ")
        charToRemove = Console.ReadLine

        Console.Write("Enter the Character to Replace with: ")
        replacingChar = Console.ReadLine

        For Count = 1 To Len(Str1)
            CurrentChar = Mid(Str1, Count, 1)
            If CurrentChar = charToRemove Then
                FinalStr = FinalStr & replacingChar
            Else
                FinalStr = FinalStr & CurrentChar
            End If
        Next
        Console.WriteLine("The Modified String is: " & FinalStr)
        Console.ReadKey()
    End Sub

End Module
