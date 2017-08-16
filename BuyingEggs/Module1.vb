REM This is also a comment
Imports System.Text.RegularExpressions

Module Module1

    Sub Main()

        Do
            'Step 1: Ask user for input
            Console.WriteLine(Regex.Unescape("How Many Eggs \nwould you like?"))

            'Step 2: Get text input from user
            Dim user_input As String = Console.ReadLine

            'Dim outside of the try block
            Dim int_eggs

            'Try to convert string to int
            Try
                'Step 3: Convert String to int
                int_eggs = Integer.Parse(user_input)
            Catch ex As Exception
                'This only responds to FormatException
                Console.WriteLine("That's not a number")
                Console.ReadKey()
                Continue Do
            End Try

            'Step 4: Respond with the number of eggs
            Console.WriteLine("You bought {0}", int_eggs)

            'Step 5: Wait for key press
            Console.ReadKey()

            'Exit the loop
            Exit Do
        Loop Until False

    End Sub

End Module
