Imports System

Module Program
    Sub Main(args As String())

        ' Announce giveaway and let user choose door number
        Console.WriteLine("Remy's Big Giveaway, Round One!")
        Console.Write("Please choose Door #1, #2, or #3: ")
        Dim userValue As String = Console.ReadLine()

        ' Assign message based on door chosen
        Dim message As String = ""
        If userValue = "1" Then
            message = "You've won a new car!"
        ElseIf userValue = "2" Then
            message = "You've won a new boat!"
        ElseIf userValue = "3" Then
            message = "You've won a new cat!"
        Else
            message = "Sorry, you've won nothing."
        End If

        ' Output message
        Console.WriteLine("*drumroll* " & message)

        ' Demonstrate same program with IIf
        Console.WriteLine("Remy's Big Giveaway, Round 2!")
        Console.Write("Please choose Door #1, #2, or #3: ")
        userValue = Console.ReadLine()

        '' Demonstrate IIf statements
        message = IIf(userValue = "1", "car", "cat")
        Console.WriteLine("*drumroll* You've won a {0}!", message)

    End Sub

End Module
