'﻿'OwenFujii
''RCET 2265
''Spring 2024
''Roll of the Dice
''https://github.com/Masaharu41/RollTheDiceListBox.git

''Option Explicit On
''Option Strict On


Public Class RollTheDiceListBox
    Private Sub RollTheDice(sender As Object, e As EventArgs) Handles RollButton.Click
        '  DisplayListBox.Items.Add(Roll())
        Roll()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    Function Roll() As String

        Dim rollTracker() As Integer
        Dim display() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
        Dim diceRolled As Integer
        Dim twoRolled%, threeRolled%, fourRolled%, fiveRolled%
        Dim sixRolled%, sevenRolled%, eightRolled%, nineRolled%
        Dim tenRolled%, elevenRolled%, twelveRolled%
        Dim accumulateMessage As String
        Static lastMessage As String
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

        DisplayListBox.Items.Add("Roll of The Dice".PadLeft(36))
        DisplayListBox.Items.Add(StrDup(55, "-"))
        For i = 0 To UBound(display)
        lastMessage = (CStr(display(i)).PadLeft(4) & "|")
            accumulateMessage = accumulateMessage & lastMessage
            'DisplayListBox.Items.Add(lastMessage)
        Next
        DisplayListBox.Items.Add(accumulateMessage)
        lastMessage = (vbNewLine & StrDup(55, "-") & vbNewLine)
        'accumulateMessage = accumulateMessage & lastMessage
        DisplayListBox.Items.Add(lastMessage)
        accumulateMessage = ""
        For i = 0 To UBound(rollTracker)
            lastMessage = (CStr(rollTracker(i)).PadLeft(4) & "|")
            accumulateMessage = accumulateMessage & lastMessage
            '  DisplayListBox.Items.Add(lastMessage)
        Next
        DisplayListBox.Items.Add(accumulateMessage)
        Return accumulateMessage
    End Function


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
