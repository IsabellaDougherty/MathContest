'Isabella Dougherty
'RCET0265
'Spring 2023
'Math Contest
'https://github.com/IsabellaDougherty/MathContest


Public Class MathContest
    Dim studentsName As String = Nothing
    Dim studentsAge As Integer = Nothing
    Dim studentsGrade As Integer = Nothing
    Dim first As Integer
    Dim second As Integer
    Dim temp As Integer
    Dim correct As Decimal
    Dim answer As Decimal
    Dim totalCorrect As Integer
    Dim totalQuestions As Integer
    Dim answeredCorrectly As Boolean
    Dim happened As Boolean
    Dim random As New Random()

    'Checks if the input name is empty or not. If it is not, makes the clear button usable
    Private Sub NameTextBox_Leave(sender As Object, e As EventArgs) Handles NameTextBox.Leave
        If NameTextBox.Text = "" Then
        Else
            ClearButton.Enabled = True
        End If
        studentsName = NameTextBox.Text
        NumberGen()
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
            NumberGen()
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

    'Is called whenever the user chooses a different radio button or hits the select button. If all three are filled, numbers populate the first and
    'second number text boxes. If the second random number is larger then the first, to avoid negative answers the second number will swap with the
    'first number. Correct value will be assigned to the correct variable.
    Private Sub NumberGen()
        If NameTextBox.Text <> "" And AgeTextBox.Text <> "" And GradeTextBox.Text <> "" Then
            first = random.Next(1, 11)
            second = random.Next(1, 11)

            If second > first Then
                temp = second
                second = first
                first = temp
            End If

            FirstNumberTextBox.Text = CStr(first)
            SecondNumberTextBox.Text = CStr(second)

            If AdditionRadioButton.Checked = True Then
                correct = first + second
            ElseIf SubtractionRadioButton.Checked = True Then
                correct = first - second
            ElseIf MultiplicationRadioButton.Checked = True Then
                correct = first * second
            ElseIf DivisionRadioButton.Checked = True Then
                correct = first / second
                correct = Math.Round(correct, 3)
            End If

        End If
    End Sub

    'Assigns a variable the students answer and checks if the answer was input as a number, if not it focuses them back to the now empty box to reenter it as
    'a number instead of letters. If the answer is entered as a number, the total questions variable adds one. Then code checks if their answer is correct.
    'If code is not correct, displays in a message box the correct answer. If the answer is correct a congratulations message is shown. After the answer has
    'been validated, a new set of numbers is displayed.
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        Try
            answer = CDec(StudentsAnswerTextBox.Text)
            answer = Math.Round(answer, 3)
            totalQuestions += 1
            NameTextBox.Enabled = False
            AgeTextBox.Enabled = False
            GradeTextBox.Enabled = False
            If answer = correct Then
                totalCorrect += 1
                MsgBox("Congratulations! Your answer is correct!")
            Else
                MsgBox($"Incorrect. The correct answer was: {correct}")
            End If
            StudentsAnswerTextBox.Text = ""
            NumberGen()
        Catch ex As Exception
            MsgBox("You must enter the answer as numbers, not letters.")
            StudentsAnswerTextBox.Text = ""
            StudentsAnswerTextBox.Focus()
        End Try
    End Sub

    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        MsgBox($"The student has answered  {totalCorrect}  correct questions out of  {totalQuestions}  questions asked.
Their current score based off this is: {totalCorrect}  / {totalQuestions}")
    End Sub

    'Clears every variable and textbox
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        studentsName = ""
        studentsGrade = Nothing
        studentsAge = Nothing
        totalCorrect = 0
        totalQuestions = 0
        NameTextBox.Enabled = True
        AgeTextBox.Enabled = True
        GradeTextBox.Enabled = True
        AdditionRadioButton.Checked = True
        NameTextBox.Clear()
        AgeTextBox.Clear()
        GradeTextBox.Clear()
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        StudentsAnswerTextBox.Clear()
        SubmitButton.Enabled = False
        SummeryButton.Enabled = False
        ClearButton.Enabled = False
    End Sub

    'Checks for if any of the information textboxes are empty. If one is defaults back to the addition radio button. If not the radio
    'button is allowed to change
    Private Sub SubtractionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractionRadioButton.CheckedChanged
        If NameTextBox.Text = "" Or AgeTextBox.Text = "" Or GradeTextBox.Text = "" Then
            AdditionRadioButton.Checked = True
        Else
            NumberGen()
            If AdditionRadioButton.Checked = True Then
                AdditionRadioButton.Checked = False
            ElseIf MultiplicationRadioButton.Checked = True Then
                MultiplicationRadioButton.Checked = False
            ElseIf DivisionRadioButton.Checked = True Then
                DivisionRadioButton.Checked = False
            ElseIf SubtractionRadioButton.Checked = False Then
                SubtractionRadioButton.Checked = True
            End If
            SubmitButton.Enabled = True
            SummeryButton.Enabled = True
        End If
    End Sub

    'Checks for if any of the information textboxes are empty. If one is defaults back to the addition radio button. If not the radio
    'button is allowed to change
    Private Sub MultiplicationRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplicationRadioButton.CheckedChanged
        If NameTextBox.Text = "" Or AgeTextBox.Text = "" Or GradeTextBox.Text = "" Then
            AdditionRadioButton.Checked = True
        Else
            NumberGen()
            If AdditionRadioButton.Checked = True Then
                AdditionRadioButton.Checked = False
            ElseIf SubtractionRadioButton.Checked = True Then
                SubtractionRadioButton.Checked = False
            ElseIf DivisionRadioButton.Checked = True Then
                DivisionRadioButton.Checked = False
            ElseIf MultiplicationRadioButton.Checked = False Then
                MultiplicationRadioButton.Checked = True
            End If
            SubmitButton.Enabled = True
            SummeryButton.Enabled = True
        End If
    End Sub

    'Checks for if any of the information textboxes are empty. If one is defaults back to the addition radio button. If not the radio
    'button is allowed to change
    Private Sub DivisionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivisionRadioButton.CheckedChanged
        If NameTextBox.Text = "" Or AgeTextBox.Text = "" Or GradeTextBox.Text = "" Then
            AdditionRadioButton.Checked = True
        Else
            NumberGen()
            If AdditionRadioButton.Checked = True Then
                AdditionRadioButton.Checked = False
            ElseIf SubtractionRadioButton.Checked = True Then
                SubtractionRadioButton.Checked = False
            ElseIf MultiplicationRadioButton.Checked = True Then
                MultiplicationRadioButton.Checked = False
            ElseIf DivisionRadioButton.Checked = False Then
                DivisionRadioButton.Checked = True
            End If
            SubmitButton.Enabled = True
            SummeryButton.Enabled = True
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
            NumberGen()
            If DivisionRadioButton.Checked = True Then
                DivisionRadioButton.Checked = False
            ElseIf SubtractionRadioButton.Checked = True Then
                SubtractionRadioButton.Checked = False
            ElseIf MultiplicationRadioButton.Checked = True Then
                MultiplicationRadioButton.Checked = False
            ElseIf AdditionRadioButton.Checked = False Then
                AdditionRadioButton.Checked = True
            End If
            SubmitButton.Enabled = True
            SummeryButton.Enabled = True
        End If
        happened = True
    End Sub

    'Makes it so when the focus is in the answering text box the + or delete buttons can be pressed to trigger the summery or exit the application
    Private Sub StudentsAnswerTextBox_KeyPress(sender As Object, e As KeyEventArgs) Handles StudentsAnswerTextBox.KeyDown
        If e.KeyCode = Keys.Add Then
            SummeryButton.PerformClick()
            StudentsAnswerTextBox.Text = ""
        ElseIf e.KeyCode = Keys.Delete Then
            ExitButton.PerformClick()
        End If
    End Sub

    'Ends the runtime
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub
End Class
