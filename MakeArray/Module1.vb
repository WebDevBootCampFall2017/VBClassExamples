Module Module1

    Sub Main()

        'Define array
        Dim numbers() As Double = {1.2, 1.3, 1.4}

        'Make Output array
        Dim output_numbers(3)

        'Loop over each element
        For a = 0 To numbers.Length - 1
            'Make Changes
            output_numbers(a) = numbers(a) ^ 2

            'Do something
            Console.WriteLine("{0} ^ 2 = {1}", numbers(a),
                              output_numbers(a))
        Next

        'Wait for key press
        Console.ReadKey()

    End Sub

End Module
