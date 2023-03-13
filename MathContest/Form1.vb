'Isabella Dougherty
'RCET0265
'Spring 2023
'Math Contest
'https://github.com/IsabellaDougherty/MathContest


Public Class Form1
    Dim studentsName As String
    Dim studentsAge As String
    Dim studentsGrade As String

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        studentsName = NameTextBox.Text
    End Sub
    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        studentsAge = AgeTextBox.Text
    End Sub
    Private Sub OkayButton_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged
        studentsGrade = GradeTextBox.Text
    End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If Len(studentsName) = 0 Or Len(studentsAge) = 0 Or Len(studentsGrade) = 0 Then
            MsgBox("You must fill in all sections of the student's information!", vbOKOnly)
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        studentsName = ""
        studentsGrade = ""
        studentsAge = ""
        NameTextBox.Clear()
        AgeTextBox.Clear()
        GradeTextBox.Clear()
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        StudentsAnswerTextBox.Clear()
    End Sub

    Private Sub SubtractionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractionRadioButton.CheckedChanged
        If AdditionRadioButton.Checked Then
            AdditionRadioButton.Checked = False

        ElseIf MultiplicationRadioButton.Checked Then
            MultiplicationRadioButton.Checked = False

        ElseIf DivisionRadioButton.Checked Then
            DivisionRadioButton.Checked = False

        ElseIf SubtractionRadioButton.Checked = False Then
            SubtractionRadioButton.Checked = True
        End If
    End Sub

    Private Sub MultiplicationRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplicationRadioButton.CheckedChanged
        If AdditionRadioButton.Checked Then
            AdditionRadioButton.Checked = False

        ElseIf DivisionRadioButton.Checked Then
            DivisionRadioButton.Checked = False

        ElseIf SubtractionRadioButton.Checked Then
            SubtractionRadioButton.Checked = False

        ElseIf MultiplicationRadioButton.Checked = False Then
            MultiplicationRadioButton.Checked = True

        End If
    End Sub

    Private Sub DivisionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DivisionRadioButton.CheckedChanged
        If AdditionRadioButton.Checked Then
            AdditionRadioButton.Checked = False

        ElseIf SubtractionRadioButton.Checked Then
            SubtractionRadioButton.Checked = False

        ElseIf MultiplicationRadioButton.Checked Then
            MultiplicationRadioButton.Checked = False

        ElseIf DivisionRadioButton.Checked = False Then
            DivisionRadioButton.Checked = True
        End If
    End Sub

    Private Sub AdditionRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AdditionRadioButton.CheckedChanged
        If SubtractionRadioButton.Checked Then
            SubtractionRadioButton.Checked = False
        ElseIf MultiplicationRadioButton.Checked Then
            MultiplicationRadioButton.Checked = False
        ElseIf DivisionRadioButton.Checked Then
            DivisionRadioButton.Checked = False
        ElseIf AdditionRadioButton.Checked = False Then
            AdditionRadioButton.Checked = True
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub
End Class
