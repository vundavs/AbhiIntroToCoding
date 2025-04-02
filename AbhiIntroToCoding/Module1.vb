Imports System.Data.SqlTypes
Imports System.Globalization
Imports System.Linq.Expressions
Imports System.Reflection
Imports System.Runtime.Remoting.Proxies
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Security.Policy

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

        'BUT FIRST, default values 
        ' If we just Dim a variable with a certain datatype and don't assign a value to it, 
        ' it will have a default value depending on the datatype
        ' String: null
        ' Integer and Decimal: 0
        ' Boolean: False 
        ' Char?
        Dim Initial As Char
        Console.WriteLine("Initial is " & Initial)
        ' Single? Double?
        Dim bankBalance As Double
        Console.WriteLine("bankBalance is " & bankBalance)
        Dim cashFlow As Single
        Console.WriteLine("bankBalance is " & bankBalance)
        ' Let's check those by printing them out


        'STRING HANDLING OPERATIONS 
        Dim BookName As String = "Chamber of Secrets"
        Dim NumberStr As String = "22"
        'Getting the length of a string - StringName.Length()
        Console.WriteLine(BookName.Length())
        'Getting the position of a string - StringName.IndexOf(character), StringName(Index position)
        Console.WriteLine("The first index of e is at " & BookName.IndexOf("e"))
        Console.WriteLine(BookName(0))
        'Getting substrings from a string (getting a 'chunk' from the string) - StringName.Substring(starting index, length)
        Console.WriteLine(BookName.Substring(1, 3))
        'Concatenating strings - We use &
        Console.WriteLine(BookName & " is the best Harry Potter book.")
        'Converting a character to its character code - Asc(Character)
        Console.WriteLine(Asc("A"))
        'Converting a character to code to the character - Chr(Character code)
        Console.WriteLine(Chr(65))
        'Converting a string to an integer - CInt(StringName)         
        Dim NumberInt As Integer = CInt(NumberStr)
        Console.WriteLine(VarType(CInt(NumberStr))) ' should ouptut integer
        'Converting a string to a real - CDec(StringName)
        Dim NumberReal As Decimal = CDec(NumberStr)
        'Converting an integer to a string - IntegerName.ToString() Or CStr(StringName)
        Console.WriteLine(VarType(NumberInt.ToString()))
        Console.WriteLine(VarType(CStr(NumberInt)))
        'Converting a real to a string - Real.ToString() Or CStr(StringName)
        Console.WriteLine(VarType(NumberReal.ToString()))
        Console.WriteLine(VarType(CStr(NumberReal)))


        'Split a string by a certain character
        'Input: String, Output: Array of each component
        Dim ArrayBookName() As String
        ArrayBookName = BookName.Split(" ")
        For Each Word In ArrayBookName
            Console.WriteLine(Word)
        Next


        'Other useful ones:
        'Reversing a string - StrReverse(StringName)
        'Replacing every occurance of a certain char with another char - StringName.Replace("oldchar", "newchar")
        'Converting a string to uppercase - StringName.ToUpper()
        'Converting a string to lowercase - StringName.ToLower()

        'Task01
        'Separate the string "This_is_a_string" by the "_" character
        'and output each separated value line by line

        'Task02 
        'Take a user input of some text that needs to be encrupted and a shift key to shift
        'each of the characters by that shift key and output the encrypted text


        'Generating random numbers 
        Dim n As New Random
        Dim RandomNumber As Integer
        RandomNumber = n.Next(1, 5) 'min value is inclusive and max value is exclusive 

        'Subroutines
        'A subroutine is a named 'out of line’ block of code that may be executed (called) by simply writing
        'its name in a program statement.

        'Why do we use them?
        '• It makes your code easier to read and understand
        '• It may make your program more memory efficient (uses up less memory when it's running)
        '• It makes your program easier to maintain (easier to update)
        '• It makes your code easier to test a nd debug
        '• It makes it easier for someone else to look at your code
        '• We can reuse the code however many times you need to

        'There are two different types of subroutines:

        'Functions
        '   A function HAS TO RETURN A VALUE
        '   Key words: 'function', 'end function' and 'return'
        '   You have to declare a data type – e.g. 'Function As Integer'
        '   (this means that an integer will be returned)
        '   General example
        '   Function Identifier As DataType
        '       Code Here
        '       Return SomeValueWithSameDataType
        '   End Function       
        '   Once a function returns a value the function will stop running 
        '   This can be an advantage as we can return a default value 
        '   Example is shown below Sub Main
        '   To call a function you need to "save" the returned value somewhere 
        '   and then you can do whatever you want with it e.g. output it, add something to it,
        '   concatenate something to it 
        Dim ResultOfFunction As Boolean = IsAGreaterThanB()
        Console.WriteLine(ResultOfFunction)

        'Procedures
        '   Can't return a value
        '   Don't have to declare a data type 
        '   General example
        '   Sub Identifier 
        '       (can do anything else like outputting a value, assignment etc.)
        '   End Sub 

        ' You can also pass values into both functions and subroutines
        ' I'll show a few examples below

        ResultOfFunction = IsAGreaterThanBVer2(2, 0)
        Console.WriteLine(ResultOfFunction)

        Console.WriteLine(AreaOfCircle(5))
        Console.WriteLine(AreaOfCircle(20))

        OutputTimesTable(5)

        'Tasks
        '01 Write a function that takes an input of an integer and then return a boolean value 
        '   based on whether it's prime or not 
        '02 Write a subroutine that will OUTPUT the date in the format "Today is 15/9 and the year is 2020"
        '   Today.Date(), Today.Time(), Today.Day(), Today.Month(), Today.Year()

        ' Now lets try do a mini project
        ' Output a menu with two options: 1. decypher 2. cipher
        ' Then ask the user which option they want
        ' Then do accordingly - you'll have to ask for the key to be able to decypher or cipher 
        ' their text 
        ' Display the decyphered or ciphered text


        Console.ReadLine() 'waiting on input - program won't close immediately
    End Sub

    Function IsAGreaterThanB() As Boolean
        Dim a, b As Integer
        a = 1
        b = 2
        If a > b Then
            Return True
        End If
        Console.WriteLine("Will I run?")
        Return False
    End Function
    Function IsAGreaterThanBVer2(a As Integer, b As Integer) As Boolean
        If a > b Then
            Return True
        End If
        Console.WriteLine("Will I run?")
        Return False
    End Function

    Function AreaOfCircle(Radius As Decimal) As Decimal
        Dim Area As Decimal
        Area = Math.PI * Math.Pow(Radius, 2)
        Return Area
    End Function

    Sub OutputTimesTable(TimesTable As Integer)
        For i = 1 To 12
            Console.Write(i * TimesTable & " ")
        Next
    End Sub



End Module
