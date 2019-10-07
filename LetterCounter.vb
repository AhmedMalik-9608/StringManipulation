Module Module1

    Sub Main()
        Dim Str1, CurrentChar As String
        Dim Letter, Digit, Count, Special As Integer

        Letter = 0
        Special = 0
        Digit = 0
        Count = 0
        Str1 = ""
        CurrentChar = ""

        Console.Write("Enter the String: ")
        Str1 = Console.ReadLine

        For Count = 1 To Len(Str1)
            CurrentChar = Mid(Str1, Count, 1)

            If Asc(CurrentChar) >= 48 And Asc(CurrentChar) <= 57 Then
                Digit = Digit + 1

            ElseIf Asc(UCase(CurrentChar)) >= 65 And Asc(UCase(CurrentChar)) <= 90 Then
                Letter = Letter + 1

            Else : Special = Special + 1

            End If
        Next

        Console.WriteLine("There are " & Digit & " digits in the string")

        Console.WriteLine("There are " & Letter & " letters in the string")

        Console.WriteLine("There are " & Special & " special Characters and spaces in this string")

        Console.ReadKey()


    End Sub

End Module
