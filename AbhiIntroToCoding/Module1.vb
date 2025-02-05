Imports System.Data.SqlTypes
Imports System.Globalization
Imports System.Linq.Expressions
Imports System.Runtime.Remoting.Proxies

Module Module1

    Structure Town
        Dim townName As String
        Dim population As Integer
        Dim area As Decimal
        Dim county As String
    End Structure


    Sub Main()
        ' SECRET
        Dim ToSearchArray(20) As Integer
        ToSearchArray = {87, 43, 12, 56, 29, 99, 3, 68, 15, 47, 34, 81, 92, 21, 50, 8, 19, 65, 11, 77}

        '' DATA TYPES 
        '' Need to know: Integer, Real, Boolean, Character, String
        '' NOTE: you're writing code on paper - common mistake "Dim money As Real" 
        '' Standard declaration = Dim VariableName As DataType
        'Dim Number As Integer
        'Number = 10
        'Dim Price As Decimal
        'Price = 10.5
        'Dim IsValid As Boolean
        'IsValid = False
        'Dim letter As Char
        'letter = "c"
        'Dim a As String
        'a = "Abhinav"
        '' Other datatypes equivalent to Real
        'Dim height As Single
        'Dim length As Double
        '' secret: Big Integer 

        '' First Program (Declaration, Outputting and Inputting, Concatenation)
        '' Get the user's name and store it in a variable, output "hello world, {their name}"
        ''Console.WriteLine("Enter your name: ") 'Use WriteLine for outputting results etc.
        'Dim name As String
        'Console.Write("Enter your name: ") 'Use Write for userinput
        'name = Console.ReadLine() 'Unlink Write and WriteLine, NEVER use Read
        'Console.WriteLine("Hello World, " & name)

        ''CONSTANT DECLARATION
        'Const RADIUS = 56

        ''ARITHMETIC OPERATIONS 
        'Dim b, c, Sum, Subtr, Mult, IntDiv, Modulo, SquareOfTwo As Integer
        'Dim RDiv As Decimal
        'b = 10
        'c = 3
        'Sum = b + c
        'Subtr = c - b
        'Mult = b * c
        'RDiv = b / c
        'Console.WriteLine(RDiv)
        'Modulo = 10 Mod 3
        'Console.WriteLine(Modulo)
        'IntDiv = b \ c
        'Console.WriteLine(IntDiv)
        'SquareOfTwo = Math.Pow(2, 5)
        'Console.WriteLine(SquareOfTwo)

        ''SELECTION (including boolean expressions)
        'Dim Age, AgeLimit As Integer
        'Console.Write("Enter input: ")
        'Age = Console.ReadLine()
        'AgeLimit = 18

        ''Checking for an age greater than 10
        'If Age > 10 Then
        '    Console.WriteLine("Your input is greater than 10")
        'End If

        '' = equal to 
        '' > greater than 
        '' < less than
        '' >= greater than or equal to 
        '' <= less than or equal to 
        '' <> not equal to 

        '' ONE IMPORTANT THING TO NOTE: comparing numbers (uses size), of you've got strings e.g. 
        '' apple > aubergine would true, a = a, p = u but what if we had apple > aUbergine would be false

        'If Age > 10 Then
        '    Console.WriteLine("Your input is greater than 10")
        'Else
        '    Console.WriteLine("Your input is not greater than 10")
        'End If

        'If Age > 10 Then
        '    Console.WriteLine("Your input is greater than 10")
        'ElseIf Age < 10 Then
        '    Console.WriteLine("Your input is less than 10")
        'Else
        '    Console.WriteLine("Your input is 10")
        'End If

        ''Checking if the age is greater than ten but less than the age limit
        'If (Age > 10) And (Age < 18) Then
        '    Console.WriteLine("Valid")
        'End If

        ''ITERATION

        ''COUNTER CONTROLLED
        ''Method 1: Outputting the ten times table
        ''Inclusive so i = 1,2,3,4,5,6,7,8,9,10 before the loop ends 
        'For i = 1 To 10
        '    Console.WriteLine(i * 10)
        'Next

        ''How you would use steps to increment in diff ways not just the default +1 each time
        'For i = 1 To 10 Step 2
        '    Console.WriteLine(i * 10)
        'Next

        ''Method 2: Outputting each letter of name on a separate line
        ''Iterating through an iterable item e.g. strings, arrays, lists etc. 
        'For Each ch In name
        '    Console.WriteLine(ch)
        'Next

        ''CONDITION-CONTROLLED LOOPS

        ''Method 1:
        'Dim Answer As String
        'While IsValid = False
        '    Console.Write("Is it valid NOW? (Y/N) ")
        '    Answer = Console.ReadLine()
        '    If Answer = "Y" Then
        '        IsValid = True
        '    End If
        'End While

        ''Method 2: 
        'Dim CanEnd As Boolean = False
        'Do
        '    Console.Write("Can I end this program now? (Y/N) ")
        '    Answer = Console.ReadLine()
        '    If Answer = "Y" Then
        '        CanEnd = True
        '    End If
        'Loop Until CanEnd = True
        ''OR.....
        'Do
        '    Console.Write("Can I end this program now? (Y/N) ")
        '    Answer = Console.ReadLine()
        '    If Answer = "Y" Then
        '        CanEnd = True
        '    End If
        'Loop While CanEnd = False

        ''NESTED ITERATION 
        ''Example: Outputting times tables from 1 to 12
        'For i = 1 To 12
        '    For j = 1 To 12
        '        Console.Write((i * j).ToString.PadLeft(4)) 'The padding is just for formatting don't worry
        '    Next
        '    Console.WriteLine()
        'Next
        ''KEY NOTE: You MUST use different variables for the counter e.g. i,j,k or a,b,c etc. 
        ''You can nest any type of loop (count or conditioned controlled)
        ''For example, a for loop can be nested inside a while loop or a while loop can be nested within a for loop.

        ''BOOLEAN OPERATORS
        'Dim DummyNumber As Integer = 32

        'If DummyNumber >= 32 And DummyNumber <= 40 Then
        '    Console.WriteLine("Correct!")
        'End If

        'If DummyNumber < 10 Or DummyNumber > 20 Then
        '    Console.WriteLine("Correct!")
        'End If

        'If Not DummyNumber = 32 Then
        '    Console.WriteLine("Dummy number is not equal to 32")
        'End If
        ''TIP: DONT USE MORE THAN TWO "CLAUSES"

        ''DATA STRUCTURES
        ''Arrays 
        ''Declaring an Array (of integers)
        'Dim FirstArray(5) As Integer

        ''Adding items to an array 

        ''For i = 0 To 4
        ''    Console.Write("Enter number: ")
        ''    FirstArray(i) = Console.ReadLine()
        ''Next

        ''Do THIS don't do above (more dynamic)
        'For i = 0 To FirstArray.Length - 1
        '    Console.Write("Enter number: ")
        '    FirstArray(i) = Console.ReadLine()
        'Next


        ''Accessing items through an array 
        ''Use this if changing the element
        'For i = 0 To FirstArray.Length - 1
        '    Console.WriteLine(FirstArray(i))
        'Next

        ''Use if you're not changing any elements
        'For Each digit In FirstArray
        '    Console.WriteLine(digit)
        'Next

        ''Updating values in an array 
        'FirstArray(4) = 9

        'TASK: Search through a given array and create a new array containing numbers that are 
        'less than 50 but greater than 10. 

        'EXT: WITH A LIST INSTEAD (SM BETTER)

        Dim ListOfNewNums As New List(Of Integer)
        For i = 0 To ToSearchArray.Length - 1
            If ToSearchArray(i) > 10 And ToSearchArray(i) < 50 Then
                ListOfNewNums.Add(ToSearchArray(i))
            End If
        Next

        For Each num In ListOfNewNums
            Console.WriteLine(num)
        Next

        '2D Arrays 
        ' The biggest thing to note with 2D arrays, you can only put the same datatypes
        'Dim ChessBoard(8, 8,) As String
        'ChessBoard(4, 0) = "King"

        'For i = 0 To 7
        '    For j = 0 To 7
        '        Console.Write("Enter the occupier: ")
        '        ChessBoard(i, j) = Console.ReadLine()
        '    Next
        'Next


        'Records
        'They're defined outside of the sub routine ^^ DEFINED ABOVE
        'Declaring a record (example town info)
        Dim t0 As Town

        'Adding to a record 
        t0.townName = "Leeds"
        t0.population = 16
        t0.area = 78
        t0.county = "West Yorkshire"

        'Accessing items in a record 
        Console.WriteLine(t0.townName)

        Dim t1 As Town
        t1.townName = "York"
        t1.population = 210000
        t1.area = 271.94
        t1.county = "North Yorkshire"

        Dim t2 As Town
        t2.townName = "Bath"
        t2.population = 101557
        t2.area = 29.0
        t2.county = "Somerset"

        Dim t3 As Town
        t3.townName = "Luton"
        t3.population = 218045
        t3.area = 43.35
        t3.county = "Bedfordshire"

        Dim t4 As Town
        t4.townName = "Dundee"
        t4.population = 148280
        t4.area = 67.0
        t4.county = "Scotland"

        Dim t5 As Town
        t5.townName = "Norwich"
        t5.population = 143118
        t5.area = 39.02
        t5.county = "Norfolk"


        'TASK01: Find the total area of all towns
        Dim TotalArea As Decimal
        TotalArea = t1.area + t2.area + t3.area + t4.area + t5.area
        Console.Write(TotalArea)

        'TASK02: Find the town name with the largest population
        Dim Towns() As Town = {t1, t2, t3, t4, t5}
        Dim LargestPop As Integer = 0
        Dim LargestName As String
        For Each town In Towns
            If town.population > LargestPop Then
                LargestPop = town.population
                LargestName = town.townName
            End If
        Next
        Console.WriteLine(LargestName)

        'TASK03: Find the average population of all towns
        Dim averagePopulation As Integer
        For Each Town In Towns
            averagePopulation += Town.population
        Next
        averagePopulation /= Towns.Length
        Console.WriteLine(averagePopulation)

        'Calculating Factorials
        Dim result As Integer = 1
        For i = 1 To 5
            result *= i
        Next
        Console.WriteLine(result)

        'TASK04: Find the town with the longest town name (to get the length of a string you use StringName.Length())
        Dim LongestName As String = ""
        For Each town In Towns
            If town.townName.Length() > LongestName.Length() Then
                LongestName = town.townName
            End If
        Next
        Console.WriteLine(LongestName)

        'EXT: List all of the towns that are in a county that the user enters. e.g The user enters
        '"West Yorkshire" And the program outputs "Heckmondwike Leeds"

        'Consequently, following the order of the spec, its file handling in VB next
        'But we'll leave that for the end 

        'STRING HANDLING OPERATIONS 
        'Getting the length of a string 
        'Getting the position of a string 
        'Getting substrings from a string (getting a 'chunk' from the string)
        'Concatenating strings
        'Converting a character to its character code 
        'Converting a character to code to the character 
        'Converting a string to an integer 
        'Converting a string to a real
        'Converting an integer to a string
        'Converting a real to a string 


        Console.ReadLine() 'waiting on input - program won't close immediately
    End Sub

End Module
