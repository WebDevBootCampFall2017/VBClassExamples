Module Module1

    Sub Main()
        'First make a string
        Dim random_string = "Today is a nice day for a walk in the park"

        'Next make a search target
        Dim search_target = "nice"

        'get index
        Dim index = random_string.IndexOf(search_target)

        'Print the index of the search target in the string
        Console.WriteLine("{0}", index)

        'Get the value at the index
        Dim result_string = random_string.Substring(index,
                                       search_target.Length)

        'print the found string
        Console.WriteLine("{0}", result_string)

        'wait for key press
        Console.ReadKey()
    End Sub

End Module
