Module Module1

    Sub Main()
        Dim Alphas, Str1, Char1 As String
        Dim Count1, Count2, LocatePos As Integer
        Dim isPangram As Boolean

        Alphas = "QWERTYUIOPASDFGHJKLZXCVBNM"
        Str1 = ""
        Char1 = ""
        LocatePos = 0
        Count1 = 0
        Count2 = 0
        isPangram = True

        Console.Write("Enter String: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)

        For Count1 = 1 To Len(Alphas)
            Char1 = UCase(Mid(Alphas, Count1, 1))
            LocatePos = InStr(Str1, Char1)
            If LocatePos = 0 Then
                isPangram = False
                Exit For
            End If

        Next

        If isPangram = True Then
            Console.WriteLine("The string is Pangram")
        Else
            Console.WriteLine("The string is not a Pangram")
        End If

        Console.ReadKey()

    End Sub

End Module
