﻿'Isabella Dougherty
'RCET0265
'Spring 2023
'Math Contest
'https://github.com/IsabellaDougherty/MathContest


Public Class MathContest
    Dim studentsName As String = Nothing
    Dim answer As String
    Dim studentsAge As Integer = Nothing
    Dim studentsGrade As Integer = Nothing
    Dim first As Integer
    Dim second As Integer
    Dim correct As Integer
    Dim answeredCorrectly As Boolean
    Dim happened As Boolean
    Dim random As New Random()

    'Checks if the input name is empty or not. If it is not, turns the viable boolean true to be used later and makes the
    'clear button usable
    Private Sub NameTextBox_Leave(sender As Object, e As EventArgs) Handles NameTextBox.Leave
        If NameTextBox.Text = "" Then
        Else
            ClearButton.Enabled = True
        End If
        studentsName = NameTextBox.Text
    End Sub
    'Checks if the input age is empty or not. If it is not, makes the clear button usable
    Private Sub AgeTextBox_Leave(sender As Object, e As EventArgs) Handles AgeTextBox.Leave
        If AgeTextBox.Text = "" Then
        Else
            ClearButton.Enabled = True
        End If
        Try
            studentsAge = CInt(AgeTextBox.Text)
            If studentsAge < 7 Or studentsAge > 11 Then
                MsgBox("Student not eligable to compete")
            End If
        Catch ex As Exception
            If AgeTextBox.Text <> "" Then
                MsgBox("You must input the age (numbers not letters.)")
                AgeTextBox.Text = ""
                AgeTextBox.Focus()
            End If
        End Try
    End Sub

    'Checks if the input grade is empty or not. If it is not, makes the clear button usable
    Private Sub GradeTextBox_Leave(sender As Object, e As EventArgs) Handles GradeTextBox.Leave
        If GradeTextBox.Text = "" Then
        Else
            ClearButton.Enabled = True
        End If

        Try
            studentsGrade = CInt(GradeTextBox.Text)
            If studentsGrade < 1 Or studentsGrade > 4 Then
                MsgBox("Student not eligable to compete")
            End If
        Catch ex As Exception
            If GradeTextBox.Text <> "" Then
                MsgBox("You must input the grade (numbers not letters.)")
                GradeTextBox.Text = ""
                GradeTextBox.Focus()
            End If
        End Try
    End Sub

    Private Sub NumberGen()
        If NameTextBox.Text <> "" And AgeTextBox.Text <> "" And GradeTextBox.Text <> "" Then
            first = random.Next(1, 11)
            second = random.Next(1, 11)

            If AdditionRadioButton.Checked = True Then
                correct = first + second
            ElseIf SubtractionRadioButton.Checked = True Then
                correct = first - second
            ElseIf MultiplicationRadioButton.Checked = True Then
                correct = first * second
            ElseIf DivisionRadioButton.Checked = True Then
                correct = first / second
            Else
                MsgBox("You must select a function.")
            End If

        End If
    End Sub

    'Checks for if any of the information inputs are empty. If one is the user is alerted they must fill that
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

    End Sub

    'Clears every variable and textbox
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        studentsName = ""
        studentsGrade = Nothing
        studentsAge = Nothing
        NameTextBox.Clear()
        AgeTextBox.Clear()
        GradeTextBox.Clear()
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        StudentsAnswerTextBox.Clear()
        SubmitButton.Enabled = False
        SummeryButton.Enabled = False
    End Sub

    'Checks for if any of the information textboxes are empty. If one is defaults back to the addition radio button. If not the radio
    'button is allowed to change
    Private Sub SubtractionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractionRadioButton.CheckedChanged
        If NameTextBox.Text = "" Or AgeTextBox.Text = "" Or GradeTextBox.Text = "" Then
            AdditionRadioButton.Checked = True
        Else
            AdditionRadioButton.Checked = False
            MultiplicationRadioButton.Checked = False
            DivisionRadioButton.Checked = False
        End If
    End Sub

    'Checks for if any of the information textboxes are empty. If one is defaults back to the addition radio button. If not the radio
    'button is allowed to change
    Private Sub MultiplicationRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplicationRadioButton.CheckedChanged
        If NameTextBox.Text = "" Or AgeTextBox.Text = "" Or GradeTextBox.Text = "" Then
            AdditionRadioButton.Checked = True
        Else
            AdditionRadioButton.Checked = False
            SubtractionRadioButton.Checked = False
            DivisionRadioButton.Checked = False
        End If
    End Sub

    'Checks for if any of the information textboxes are empty. If one is defaults back to the addition radio button. If not the radio
    'button is allowed to change
    Private Sub DivisionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivisionRadioButton.CheckedChanged
        If NameTextBox.Text = "" Or AgeTextBox.Text = "" Or GradeTextBox.Text = "" Then
            AdditionRadioButton.Checked = True
        Else
            AdditionRadioButton.Checked = False
            SubtractionRadioButton.Checked = False
            MultiplicationRadioButton.Checked = False
        End If
    End Sub

    'Checks if the code has already been called. If it has, then it checks for if any of the information
    'textboxes are empty. If one is it alerts them they need to fill in that informaiton. If not the radio
    'button is allowed to change
    Private Sub AdditionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AdditionRadioButton.CheckedChanged
        If happened And (NameTextBox.Text = "" Or AgeTextBox.Text = "" Or GradeTextBox.Text = "") And AdditionRadioButton.Checked = False Then
            If NameTextBox.Text = "" Then
                NameTextBox.Focus()
            ElseIf AgeTextBox.Text = "" Then
                AgeTextBox.Focus()
            ElseIf GradeTextBox.Text = "" Then
                GradeTextBox.Focus()
            End If
            AdditionRadioButton.Checked = True
            MsgBox("You must fill in all sections of the student's information!", vbOKOnly)
        Else
            SubtractionRadioButton.Checked = False
            MultiplicationRadioButton.Checked = False
            DivisionRadioButton.Checked = False
        End If
        happened = True
    End Sub

    'Ends the runtime
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub

End Class
