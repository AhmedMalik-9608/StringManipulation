Module Module1

    Sub Main()
        Dim String1 As String
        Dim isvalid As Boolean
        Dim nextchar As Char
        Dim count As Integer

        String1 = ""
        isvalid = True
        nextchar = ""
        count = 0

        Console.Write("Enter the code in a format AAAA-999-aaa : ")
        String1 = Console.ReadLine



        If Len(String1) <> 12 Then
            isvalid = False
            Console.WriteLine("The Length must be 12 Characters.")
        End If



        If isvalid = True Then

            If Mid(String1, 5, 1) <> "-" Or Mid(String1, 9, 1) <> "-" Then
                isvalid = False
                Console.WriteLine("The 5th and 9th character must be a '-'.")
            End If

        End If



        If isvalid = True Then

            For count = 1 To 4
                nextchar = Mid(String1, count, 1)

                If nextchar < "A" Or nextchar > "Z" Then
                    isvalid = False
                    Console.WriteLine("The first four characters must be CAPITAL letters.")
                    Exit For
                End If

            Next

        End If



        If isvalid = True Then

            For count = 6 To 8
                nextchar = Mid(String1, count, 1)

                If nextchar < "0" Or nextchar > "9" Then
                    isvalid = False
                    Console.WriteLine("The middle three characters must be a digit.")
                    Exit For
                End If

            Next

        End If


        If isvalid = True Then

            For count = 10 To 12
                nextchar = Mid(String1, count, 1)

                If nextchar < "a" Or nextchar > "z" Then
                    isvalid = False
                    Console.WriteLine("The last three characters must be SMALL letters")
                    Exit For
                End If

            Next

        End If


        If isvalid = True Then
            Console.WriteLine("Valid string.")
        Else
            Console.WriteLine("Invalid String.")
        End If

        Console.ReadKey()

    End Sub

End Module
