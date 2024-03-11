﻿'OwenFujii
'RCET 2265
'Spring 2024
'Roll of the Dice
'https://github.com/Masaharu41/RollTheDice.git

Option Explicit On
Option Strict On


Public Class RollTheDiceListBox

    Sub Main()

        Dim rollTracker() As Integer
        Dim display() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
        Dim diceRolled As Integer
        Dim twoRolled%, threeRolled%, fourRolled%, fiveRolled%
        Dim sixRolled%, sevenRolled%, eightRolled%, nineRolled%
        Dim tenRolled%, elevenRolled%, twelveRolled%
        'A for loop which rolls the dice 1000 times and tracks how often each number is rolled
        For i = 1 To 1000
            diceRolled = RollDice()
            If diceRolled = 2 Then
                twoRolled = twoRolled + 1

            ElseIf diceRolled = 3 Then
                threeRolled = threeRolled + 1

            ElseIf diceRolled = 4 Then
                fourRolled = fourRolled + 1

            ElseIf diceRolled = 5 Then
                fiveRolled = fiveRolled + 1

            ElseIf diceRolled = 6 Then
                sixRolled = sixRolled + 1

            ElseIf diceRolled = 7 Then
                sevenRolled = sevenRolled + 1

            ElseIf diceRolled = 8 Then
                eightRolled = eightRolled + 1

            ElseIf diceRolled = 9 Then
                nineRolled = nineRolled + 1

            ElseIf diceRolled = 10 Then
                tenRolled = tenRolled + 1

            ElseIf diceRolled = 11 Then
                elevenRolled = elevenRolled + 1

            ElseIf diceRolled = 12 Then
                twelveRolled = twelveRolled + 1

            End If
        Next

        rollTracker = {twoRolled, threeRolled, fourRolled, fiveRolled, sixRolled, sevenRolled, eightRolled, nineRolled,
                tenRolled, elevenRolled, twelveRolled}
        'Display the results of the 1000 rolls of the dice
        Console.WriteLine("Roll of The Dice".PadLeft(36))
        Console.WriteLine(StrDup(55, "-"))
        For i = 0 To UBound(display)
            Console.Write(CStr(display(i)).PadLeft(4) & "|")
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(55, "-"))
        For i = 0 To UBound(rollTracker)
            Console.Write(CStr(rollTracker(i)).PadLeft(4) & "|")
        Next
        Console.Read()
    End Sub


    Function RollDice() As Integer
        Dim diceRolled As Integer
        Dim diceRoll1 As Integer
        Dim diceRoll2 As Integer
        'Function that adds two random 1 to 6 to give the sum of two dice rolls
        Randomize()
        diceRoll1 = CInt(Int((6 * Rnd()) + 1))
        diceRoll2 = CInt(Int((6 * Rnd()) + 1))
        diceRolled = diceRoll1 + diceRoll2
        Return diceRolled
    End Function

End Class
