Public Class Form1

    Private ctrlPressed As Boolean = False
    ' Event handler for the form's KeyDown event
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if the Control key is pressed
        If e.Control Then
            ctrlPressed = True
        End If


        ' Check if both Control and V keys are pressed
        If ctrlPressed AndAlso e.KeyCode = Keys.V Then
            Button1.PerformClick()
        End If

        If ctrlPressed AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub

    ' Event handler for the form's KeyUp event
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        ' Reset the key states when the keys are released
        If e.KeyCode = Keys.ControlKey Then
            ctrlPressed = False
        End If

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form3 As New Form3()

        ' Show the new form
        form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New Form2()

        ' Show the new form
        form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form's KeyPreview property to True to capture key events before they reach any other control
        Me.KeyPreview = True
    End Sub
End Class
