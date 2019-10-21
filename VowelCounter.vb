Module Module1

    Sub Main()
        Dim Vowel, Str1, VowChar, Char1 As String
        Dim Count2, Count1, VowelCount As Integer

        Vowel = "AEIOU"
        Str1 = ""
        VowChar = ""
        Count1 = 0
        Count2 = 0
        Char1 = ""
        VowelCount = 0

        Console.Write("Enter the String: ")
        Str1 = Console.ReadLine

        For Count1 = 1 To Len(Vowel)

            VowChar = UCase(Mid(Vowel, Count1, 1))

            For Count2 = 1 To Len(Str1)
                Char1 = UCase(Mid(Str1, Count2, 1))

                If VowChar = Char1 Then
                    VowelCount = VowelCount + 1
                End If
            Next

        Next

        Console.Write("There are " & VowelCount & " Vowels in the string")

        Console.ReadKey()
    End Sub

End Module
