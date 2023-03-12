<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AdditionCheckBox = New System.Windows.Forms.CheckBox()
        Me.SubtractionCheckBox = New System.Windows.Forms.CheckBox()
        Me.MultiplicationCheckBox = New System.Windows.Forms.CheckBox()
        Me.DivisionCheckBox = New System.Windows.Forms.CheckBox()
        Me.InformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.ProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.MathProblemTypeLabel = New System.Windows.Forms.Label()
        Me.MathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentsAnswerLabel = New System.Windows.Forms.Label()
        Me.StudentsAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummeryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.InformationGroupBox.SuspendLayout()
        Me.ProblemTypeGroupBox.SuspendLayout()
        Me.MathProblemGroupBox.SuspendLayout()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NameTextBox.Location = New System.Drawing.Point(7, 64)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 23)
        Me.NameTextBox.TabIndex = 0
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(7, 47)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(43, 15)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AgeTextBox.Location = New System.Drawing.Point(7, 114)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 23)
        Me.AgeTextBox.TabIndex = 2
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(7, 96)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(30, 15)
        Me.AgeLabel.TabIndex = 3
        Me.AgeLabel.Text = "Age"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GradeTextBox.Location = New System.Drawing.Point(7, 169)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(100, 23)
        Me.GradeTextBox.TabIndex = 4
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(7, 152)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(45, 15)
        Me.GradeLabel.TabIndex = 5
        Me.GradeLabel.Text = "Grade"
        '
        'AdditionCheckBox
        '
        Me.AdditionCheckBox.AutoSize = True
        Me.AdditionCheckBox.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AdditionCheckBox.Location = New System.Drawing.Point(5, 63)
        Me.AdditionCheckBox.Name = "AdditionCheckBox"
        Me.AdditionCheckBox.Size = New System.Drawing.Size(102, 27)
        Me.AdditionCheckBox.TabIndex = 6
        Me.AdditionCheckBox.Text = "Addition"
        Me.AdditionCheckBox.UseVisualStyleBackColor = True
        '
        'SubtractionCheckBox
        '
        Me.SubtractionCheckBox.AutoSize = True
        Me.SubtractionCheckBox.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SubtractionCheckBox.Location = New System.Drawing.Point(5, 96)
        Me.SubtractionCheckBox.Name = "SubtractionCheckBox"
        Me.SubtractionCheckBox.Size = New System.Drawing.Size(126, 27)
        Me.SubtractionCheckBox.TabIndex = 7
        Me.SubtractionCheckBox.Text = "Subtraction"
        Me.SubtractionCheckBox.UseVisualStyleBackColor = True
        '
        'MultiplicationCheckBox
        '
        Me.MultiplicationCheckBox.AutoSize = True
        Me.MultiplicationCheckBox.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MultiplicationCheckBox.Location = New System.Drawing.Point(5, 129)
        Me.MultiplicationCheckBox.Name = "MultiplicationCheckBox"
        Me.MultiplicationCheckBox.Size = New System.Drawing.Size(146, 27)
        Me.MultiplicationCheckBox.TabIndex = 8
        Me.MultiplicationCheckBox.Text = "Multiplication"
        Me.MultiplicationCheckBox.UseVisualStyleBackColor = True
        '
        'DivisionCheckBox
        '
        Me.DivisionCheckBox.AutoSize = True
        Me.DivisionCheckBox.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DivisionCheckBox.Location = New System.Drawing.Point(5, 162)
        Me.DivisionCheckBox.Name = "DivisionCheckBox"
        Me.DivisionCheckBox.Size = New System.Drawing.Size(96, 27)
        Me.DivisionCheckBox.TabIndex = 9
        Me.DivisionCheckBox.Text = "Division"
        Me.DivisionCheckBox.UseVisualStyleBackColor = True
        '
        'InformationGroupBox
        '
        Me.InformationGroupBox.BackColor = System.Drawing.Color.PowderBlue
        Me.InformationGroupBox.Controls.Add(Me.GradeLabel)
        Me.InformationGroupBox.Controls.Add(Me.GradeTextBox)
        Me.InformationGroupBox.Controls.Add(Me.AgeLabel)
        Me.InformationGroupBox.Controls.Add(Me.AgeTextBox)
        Me.InformationGroupBox.Controls.Add(Me.NameLabel)
        Me.InformationGroupBox.Controls.Add(Me.NameTextBox)
        Me.InformationGroupBox.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InformationGroupBox.Location = New System.Drawing.Point(9, 12)
        Me.InformationGroupBox.Name = "InformationGroupBox"
        Me.InformationGroupBox.Size = New System.Drawing.Size(129, 198)
        Me.InformationGroupBox.TabIndex = 10
        Me.InformationGroupBox.TabStop = False
        Me.InformationGroupBox.Text = "Student's Information"
        '
        'ProblemTypeGroupBox
        '
        Me.ProblemTypeGroupBox.BackColor = System.Drawing.Color.PowderBlue
        Me.ProblemTypeGroupBox.Controls.Add(Me.MathProblemTypeLabel)
        Me.ProblemTypeGroupBox.Controls.Add(Me.DivisionCheckBox)
        Me.ProblemTypeGroupBox.Controls.Add(Me.MultiplicationCheckBox)
        Me.ProblemTypeGroupBox.Controls.Add(Me.SubtractionCheckBox)
        Me.ProblemTypeGroupBox.Controls.Add(Me.AdditionCheckBox)
        Me.ProblemTypeGroupBox.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ProblemTypeGroupBox.Location = New System.Drawing.Point(147, 12)
        Me.ProblemTypeGroupBox.Name = "ProblemTypeGroupBox"
        Me.ProblemTypeGroupBox.Size = New System.Drawing.Size(170, 198)
        Me.ProblemTypeGroupBox.TabIndex = 11
        Me.ProblemTypeGroupBox.TabStop = False
        '
        'MathProblemTypeLabel
        '
        Me.MathProblemTypeLabel.AutoSize = True
        Me.MathProblemTypeLabel.Font = New System.Drawing.Font("Constantia", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MathProblemTypeLabel.Location = New System.Drawing.Point(0, 21)
        Me.MathProblemTypeLabel.Name = "MathProblemTypeLabel"
        Me.MathProblemTypeLabel.Size = New System.Drawing.Size(168, 21)
        Me.MathProblemTypeLabel.TabIndex = 10
        Me.MathProblemTypeLabel.Text = "Math Problem Type"
        '
        'MathProblemGroupBox
        '
        Me.MathProblemGroupBox.BackColor = System.Drawing.Color.PowderBlue
        Me.MathProblemGroupBox.Controls.Add(Me.StudentsAnswerLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.StudentsAnswerTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.MathProblemGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.MathProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.MathProblemGroupBox.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MathProblemGroupBox.Location = New System.Drawing.Point(9, 216)
        Me.MathProblemGroupBox.Name = "MathProblemGroupBox"
        Me.MathProblemGroupBox.Size = New System.Drawing.Size(308, 143)
        Me.MathProblemGroupBox.TabIndex = 12
        Me.MathProblemGroupBox.TabStop = False
        Me.MathProblemGroupBox.Text = "Current Math Problem"
        '
        'StudentsAnswerLabel
        '
        Me.StudentsAnswerLabel.AutoSize = True
        Me.StudentsAnswerLabel.Location = New System.Drawing.Point(101, 82)
        Me.StudentsAnswerLabel.Name = "StudentsAnswerLabel"
        Me.StudentsAnswerLabel.Size = New System.Drawing.Size(120, 15)
        Me.StudentsAnswerLabel.TabIndex = 5
        Me.StudentsAnswerLabel.Text = "Student's Answer: "
        '
        'StudentsAnswerTextBox
        '
        Me.StudentsAnswerTextBox.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StudentsAnswerTextBox.Location = New System.Drawing.Point(6, 100)
        Me.StudentsAnswerTextBox.Name = "StudentsAnswerTextBox"
        Me.StudentsAnswerTextBox.Size = New System.Drawing.Size(295, 23)
        Me.StudentsAnswerTextBox.TabIndex = 4
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(177, 28)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(112, 15)
        Me.SecondNumberLabel.TabIndex = 3
        Me.SecondNumberLabel.Text = "Second Number: "
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(160, 49)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(142, 23)
        Me.SecondNumberTextBox.TabIndex = 2
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(33, 28)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(96, 15)
        Me.FirstNumberLabel.TabIndex = 1
        Me.FirstNumberLabel.Text = "First Number: "
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(7, 49)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(142, 23)
        Me.FirstNumberTextBox.TabIndex = 0
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.BackColor = System.Drawing.Color.PowderBlue
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SummeryButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(323, 12)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(208, 347)
        Me.ButtonsGroupBox.TabIndex = 13
        Me.ButtonsGroupBox.TabStop = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.SteelBlue
        Me.ExitButton.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.Location = New System.Drawing.Point(7, 262)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(189, 74)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'SummeryButton
        '
        Me.SummeryButton.BackColor = System.Drawing.Color.SteelBlue
        Me.SummeryButton.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SummeryButton.Location = New System.Drawing.Point(7, 182)
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(189, 74)
        Me.SummeryButton.TabIndex = 2
        Me.SummeryButton.Text = "Summery"
        Me.SummeryButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.SteelBlue
        Me.ClearButton.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ClearButton.Location = New System.Drawing.Point(7, 96)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(189, 74)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'SubmitButton
        '
        Me.SubmitButton.BackColor = System.Drawing.Color.SteelBlue
        Me.SubmitButton.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SubmitButton.Location = New System.Drawing.Point(7, 13)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(189, 74)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(543, 367)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.Controls.Add(Me.MathProblemGroupBox)
        Me.Controls.Add(Me.ProblemTypeGroupBox)
        Me.Controls.Add(Me.InformationGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.InformationGroupBox.ResumeLayout(False)
        Me.InformationGroupBox.PerformLayout()
        Me.ProblemTypeGroupBox.ResumeLayout(False)
        Me.ProblemTypeGroupBox.PerformLayout()
        Me.MathProblemGroupBox.ResumeLayout(False)
        Me.MathProblemGroupBox.PerformLayout()
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AdditionCheckBox As CheckBox
    Friend WithEvents SubtractionCheckBox As CheckBox
    Friend WithEvents MultiplicationCheckBox As CheckBox
    Friend WithEvents DivisionCheckBox As CheckBox
    Friend WithEvents InformationGroupBox As GroupBox
    Friend WithEvents ProblemTypeGroupBox As GroupBox
    Friend WithEvents MathProblemTypeLabel As Label
    Friend WithEvents MathProblemGroupBox As GroupBox
    Friend WithEvents StudentsAnswerLabel As Label
    Friend WithEvents StudentsAnswerTextBox As TextBox
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents ButtonsGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummeryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
End Class
