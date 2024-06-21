Public Class Form3
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        ' Add any initialization code after the InitializeComponent() call.
    End Sub

    Private ctrlPressed As Boolean = False
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if the Control key is pressed
        If e.Control Then
            ctrlPressed = True
        End If


        ' Check if both Control and V keys are pressed
        If ctrlPressed AndAlso e.KeyCode = Keys.N Then
            Button1.PerformClick()
        End If

        If ctrlPressed AndAlso e.KeyCode = Keys.P Then
            Button2.PerformClick()
        End If
    End Sub

    ' Event handler for the form's KeyUp event
    Private Sub Form3_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        ' Reset the key states when the keys are released
        If e.KeyCode = Keys.ControlKey Then
            ctrlPressed = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form's KeyPreview property to True to capture key events before they reach any other control
        Me.KeyPreview = True
    End Sub
End Class