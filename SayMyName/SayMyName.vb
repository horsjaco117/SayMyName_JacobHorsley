﻿'Jacob Horsley
'Spring 2025
'RCET 2265
'SayMyName
'https://github.com/horsjaco117/SayMyName_JacobHorsley

Option Explicit On
Option Strict On


Module SayMyName 'Figure out how to rename this

    Sub Main()

        Dim userinput As String

        Console.WriteLine("What is your Name?") 'Ask name
        Console.WriteLine()

        userinput = Console.ReadLine() 'give it name
        Console.WriteLine()

        Console.WriteLine("Hello there " & userinput) 'It tells you name

    End Sub

End Module
