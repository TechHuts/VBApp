<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(204, 107)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(407, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(204, 150)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(407, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(204, 195)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(407, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(204, 242)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(407, 27)
        TextBox4.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(183, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 20)
        Label1.TabIndex = 4
        Label1.Text = "Kaustav Mazumder Slidely Task-3"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Info
        Button1.Location = New Point(22, 302)
        Button1.Name = "Button1"
        Button1.Size = New Size(271, 40)
        Button1.TabIndex = 5
        Button1.Text = "Toggle Stopwatch (Ctrl+T)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Highlight
        Button2.ForeColor = SystemColors.ButtonFace
        Button2.Location = New Point(22, 366)
        Button2.Name = "Button2"
        Button2.Size = New Size(589, 50)
        Button2.TabIndex = 6
        Button2.Text = "Submit (Ctrl + S)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 7
        Label2.Text = "Name :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 8
        Label3.Text = "Email :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 9
        Label4.Text = "Phone Num :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 244)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 20)
        Label5.TabIndex = 10
        Label5.Text = "GitHub Link For Task 3 :"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.ScrollBar
        TextBox5.Location = New Point(376, 309)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(161, 27)
        TextBox5.TabIndex = 11
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(642, 450)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Timer1 As Timer
End Class
