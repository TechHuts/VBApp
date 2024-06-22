Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json


Public Class Form2
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization code after the InitializeComponent() call.

    End Sub

    Private ctrlPressed As Boolean = False
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if the Control key is pressed
        If e.Control Then
            ctrlPressed = True
        End If


        ' Check if both Control and V keys are pressed
        If ctrlPressed AndAlso e.KeyCode = Keys.T Then
            Button1.PerformClick()
        End If

        If ctrlPressed AndAlso e.KeyCode = Keys.S Then
            Button2.PerformClick()
        End If
    End Sub

    ' Event handler for the form's KeyUp event
    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        ' Reset the key states when the keys are released
        If e.KeyCode = Keys.ControlKey Then
            ctrlPressed = False
        End If

    End Sub
    Private elapsedTime As TimeSpan
    Private stopwatchRunning As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If stopwatchRunning Then
            Timer1.Stop()
        Else
            Timer1.Start()

        End If

        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox5.ReadOnly = True
        elapsedTime = TimeSpan.Zero
        TextBox5.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))
        TextBox5.Text = elapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Public Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class

    Private ReadOnly client As HttpClient = New HttpClient()

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Yes")
        SaveSubmissionAsync().Wait()
    End Sub

    Private Async Function SaveSubmissionAsync() As Task
        Dim submission As New Submission With {
            .name = TextBox1.Text,
            .email = TextBox2.Text,
            .phone = TextBox3.Text,
            .github_link = TextBox4.Text,
            .stopwatch_time = TextBox5.Text
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")


        Try
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            response.EnsureSuccessStatusCode()
            MessageBox.Show("Submission successful!")
        Catch ex As HttpRequestException
            MessageBox.Show($"Request error: {ex.Message}")
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the form's KeyPreview property to True to capture key events before they reach any other control
        Me.KeyPreview = True
    End Sub

End Class