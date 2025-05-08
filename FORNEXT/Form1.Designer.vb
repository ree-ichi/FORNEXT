<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtoutput = New TextBox()
        btnForNext = New Button()
        btnWhileWend = New Button()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' txtoutput
        ' 
        txtoutput.Location = New Point(23, 33)
        txtoutput.Multiline = True
        txtoutput.Name = "txtoutput"
        txtoutput.ScrollBars = ScrollBars.Vertical
        txtoutput.Size = New Size(212, 249)
        txtoutput.TabIndex = 0
        ' 
        ' btnForNext
        ' 
        btnForNext.Location = New Point(365, 38)
        btnForNext.Name = "btnForNext"
        btnForNext.Size = New Size(175, 56)
        btnForNext.TabIndex = 1
        btnForNext.Text = "FOR NEXT"
        btnForNext.UseVisualStyleBackColor = True
        ' 
        ' btnWhileWend
        ' 
        btnWhileWend.Location = New Point(365, 133)
        btnWhileWend.Name = "btnWhileWend"
        btnWhileWend.Size = New Size(175, 56)
        btnWhileWend.TabIndex = 2
        btnWhileWend.Text = "WHILE WEND"
        btnWhileWend.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(365, 226)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(175, 56)
        btnClear.TabIndex = 3
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(btnWhileWend)
        Controls.Add(btnForNext)
        Controls.Add(txtoutput)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtoutput As TextBox
    Friend WithEvents btnForNext As Button
    Friend WithEvents btnWhileWend As Button
    Friend WithEvents btnClear As Button

End Class
