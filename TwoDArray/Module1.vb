Module Module1

    Sub Main()
        'Dim a two d array
        Dim matrix(5, 10) As Integer

        'Nest for loops to loop over both indexes
        For i = 0 To 4
            For j = 0 To 9
                'Assign to location i,j
                matrix(i, j) = 1
            Next
        Next

    End Sub

End Module
