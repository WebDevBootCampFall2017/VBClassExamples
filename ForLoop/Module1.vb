Module Module1

    Sub Main()

        'Loop from 10 to 20, in steps of 2
        '10, 12, 14, etc...
        For a = 10 To 20 Step 2

            'Only print if our number is greater than
            '15
            If a > 15 Then
                'Print out our number
                Console.WriteLine("{0}", a)
            Else
                'Print dumb message
                Console.WriteLine("I don't bother with" +
                        " small numbers")
            End If

        Next

        'Wait for a key press
        Console.ReadKey()
    End Sub

End Module
