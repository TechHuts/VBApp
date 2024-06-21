<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(193, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 20)
        Label1.TabIndex = 5
        Label1.Text = "Kaustav Mazumder Slidely Task-3"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ScrollBar
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(202, 116)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(407, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ScrollBar
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(202, 208)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(407, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ScrollBar
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(202, 262)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(407, 27)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.ScrollBar
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(202, 161)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(407, 27)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.ScrollBar
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Location = New Point(202, 325)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(407, 27)
        TextBox5.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(337, 388)
        Button1.Name = "Button1"
        Button1.Size = New Size(295, 40)
        Button1.TabIndex = 11
        Button1.Text = "Next (Ctrl + N)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Info
        Button2.Location = New Point(13, 388)
        Button2.Name = "Button2"
        Button2.Size = New Size(295, 40)
        Button2.TabIndex = 12
        Button2.Text = "Previous (Ctrl + P)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(35, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 13
        Label2.Text = "Name :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 264)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 20)
        Label5.TabIndex = 14
        Label5.Text = "GitHub Link For Task 3 :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 20)
        Label3.TabIndex = 15
        Label3.Text = "Email :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 16
        Label4.Text = "Phone Num :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 327)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 20)
        Label6.TabIndex = 17
        Label6.Text = "StopWatch Time :"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(644, 450)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
End Class
