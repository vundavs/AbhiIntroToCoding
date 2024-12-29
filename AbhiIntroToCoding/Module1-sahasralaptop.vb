Imports System.Globalization
Imports System.Linq.Expressions
Imports System.Runtime.Remoting.Proxies
Imports System.Security.Cryptography

Module Module1

    Sub Main()
        ' DATA TYPES 
        ' Need to know: Integer, Real, Boolean, Character, String
        ' NOTE: you're writing code on paper - common mistake "Dim money As Real" 
        ' Standard declaration = Dim VariableName As DataType
        Dim Number As Integer
        Number = 10
        Dim Price As Decimal
        Price = 10.5
        Dim IsValid As Boolean
        IsValid = False
        Dim letter As Char
        letter = "c"
        Dim a As String
        a = "Abhinav"
        ' Other datatypes equivalent to Real
        Dim height As Single
        Dim length As Double
        ' secret: Big Integer 

        ' First Program (Declaration, Outputting and Inputting, Concatenation)
        ' Get the user's name and store it in a variable, output "hello world, {their name}"
        'Console.WriteLine("Enter your name: ") 'Use WriteLine for outputting results etc.
        Dim Name As String
        Console.Write("Enter your name: ") 'Use Write for userinput
        Name = Console.ReadLine() 'Unlink Write and WriteLine, NEVER use Read
        Console.WriteLine("Hello World, " & Name)

        'CONSTANT DECLARATION
        Const RADIUS = 56

        'ARITHMETIC OPERATIONS 
        Dim b, c, Sum, Subtr, Mult, IntDiv, Modulo, SquareOfTwo As Integer
        Dim RDiv As Decimal
        b = 10
        c = 3
        Sum = b + c
        Subtr = c - b
        Mult = b * c
        RDiv = b / c
        Console.WriteLine(RDiv)
        Modulo = 10 Mod 3
        Console.WriteLine(Modulo)
        IntDiv = b \ c
        Console.WriteLine(IntDiv)
        SquareOfTwo = Math.Pow(2, 5)
        Console.WriteLine(SquareOfTwo)

        'SELECTION (including boolean expressions)
        Dim Age, AgeLimit As Integer
        Console.Write("Enter input: ")
        Age = Console.ReadLine()
        AgeLimit = 18

        'Checking for an age greater than 10
        If Age > 10 Then
            Console.WriteLine("Your input is greater than 10")
        End If

        ' = equal to 
        ' > greater than 
        ' < less than
        ' >= greater than or equal to 
        ' <= less than or equal to 
        ' <> not equal to 

        ' ONE IMPORTANT THING TO NOTE: comparing numbers (uses size), of you've got strings e.g. 
        ' apple > aubergine would true, a = a, p = u but what if we had apple > aUbergine would be false

        If Age > 10 Then
            Console.WriteLine("Your input is greater than 10")
        Else
            Console.WriteLine("Your input is not greater than 10")
        End If

        If Age > 10 Then
            Console.WriteLine("Your input is greater than 10")
        ElseIf Age < 10 Then
            Console.WriteLine("Your input is less than 10")
        Else
            Console.WriteLine("Your input is 10")
        End If

        'Checking if the age is greater than ten but less than the age limit
        If (Age > 10) And (Age < 18) Then
            Console.WriteLine("Valid")
        End If

        'ITERATION
        'FOR LOOP
        'Outputting the ten times table
        For i = 1 To 10
            Console.WriteLine(i * 10)
        Next

        For i = 10 To 1 Step -1
            Console.WriteLine(i * 10)
        Next

        For Each letter In Name
            Console.Write(Char.ToUpper(letter))
        Next
        Console.WriteLine()

        'WHILE LOOPS

        Dim Guess, Answer As Integer
        Guess = 0
        Answer = 15
        While Guess <> Answer
            Console.Write("Enter guess: ")
            Guess = Console.ReadLine()
        End While
        Console.WriteLine("Hooray! You guessed it right!")

        Do
            Console.Write("Enter your guess: ")
            Guess = Console.ReadLine()
        Loop Until Guess = Answer
        Console.WriteLine("Correct. Well Done!")

        Do
            Console.Write("Enter your guess: ")
            Guess = Console.ReadLine()
        Loop While Guess <> Answer
        Console.WriteLine("Correct. Well Done!")

        Console.ReadLine() 'waiting on input - program won't close immediately
    End Sub

End Module
