Module Module1

    Sub Main()
        '16 is 1000, but zero filled to 16 bits
        Dim a As Int16 = 16

        '32 is 10000, but zero filled to 16 bits
        Dim b As Int16 = 32

        Console.WriteLine("a & b = {0}", a And b)
        Console.WriteLine("a | b = {0}", a Or b)
        Console.WriteLine("a ~ b = {0}", a Xor b)
        Console.WriteLine("^ b = {0}", Not b)

        Console.ReadKey()


    End Sub

End Module
