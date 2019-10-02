Module Module1

    Sub Main()
        Dim Name1, FinalName, Word2, Word1, Name2 As String
        Dim SpacePos As Integer

        Name1 = ""
        Name2 = ""
        Word1 = ""

        FinalName = ""
        SpacePos = 0

        Console.Write("Enter the Full Name 1 : ")
        Name1 = Console.ReadLine

        Console.Write("Enter Full Name 2 : ")
        Name2 = Console.ReadLine

        SpacePos = InStr(Name1, " ")
        Word1 = Left(Name1, SpacePos)

        SpacePos = InStr(Name2, " ")
        Word2 = Right(Name2, Len(Name2) - SpacePos)

        FinalName = Word1 & Word2
        Console.Write(FinalName)
        Console.ReadKey()

    End Sub

End Module
