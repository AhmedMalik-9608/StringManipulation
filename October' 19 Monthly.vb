Module Module1

    Sub Main()
        Dim BinString As String
        Dim Count1, Count2, BinInt, DecInt, Product As Integer
        Dim char1, char2 As Char
        Dim validBinaryString As Boolean

        BinString = ""
        Count1 = 0
        Count2 = 0
        BinInt = 0
        DecInt = 0
        Product = 1
        char1 = ""
        char2 = ""
        validBinaryString = True

        Console.Write("Enter the Binary String: ")
        BinString = Console.ReadLine

        If Len(BinString) < 1 Or Len(BinString) > 8 Then
            Console.WriteLine("Invalid Binary String")
        Else
            For Count1 = 1 To Len(BinString)
                char1 = Mid(BinString, Count1, 1)
                If char1 <> "1" And char1 <> "0" Then
                    validBinaryString = False
                    Exit For
                End If
            Next
            If validBinaryString = False Then
                Console.WriteLine("Invalid Binary String")
            Else
                For Count2 = Len(BinString) To 1 Step -1
                    char2 = Mid(BinString, Count2, 1)
                    BinInt = Val(char2)
                    BinInt = BinInt * Product
                    DecInt = DecInt + BinInt
                    Product = Product * 2
                Next
                Console.WriteLine("The Denary Value of " & BinString & " is : " & DecInt)
            End If
        End If
        Console.ReadKey()
    End Sub

End Module
