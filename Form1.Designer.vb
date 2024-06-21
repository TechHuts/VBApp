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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Info
        Button1.Cursor = Cursors.Hand
        Button1.Location = New Point(40, 89)
        Button1.Name = "Button1"
        Button1.Size = New Size(477, 50)
        Button1.TabIndex = 0
        Button1.Text = "View Submission (Ctrl + V)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Highlight
        Button2.Cursor = Cursors.Hand
        Button2.ForeColor = Color.Snow
        Button2.Location = New Point(40, 157)
        Button2.Name = "Button2"
        Button2.Size = New Size(477, 50)
        Button2.TabIndex = 1
        Button2.Text = "Create new submission (Ctrl + N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(157, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 20)
        Label1.TabIndex = 2
        Label1.Text = "Kaustav Mazumder Slidely Task-3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 256)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label

End Class
