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
        btnCalculate = New Button()
        txtEnterNumber = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = SystemColors.ControlLightLight
        btnCalculate.Location = New Point(413, 295)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(150, 65)
        btnCalculate.TabIndex = 0
        btnCalculate.Text = "Calcualte"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' txtEnterNumber
        ' 
        txtEnterNumber.Location = New Point(413, 171)
        txtEnterNumber.Name = "txtEnterNumber"
        txtEnterNumber.Size = New Size(150, 31)
        txtEnterNumber.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(258, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 25)
        Label1.TabIndex = 2
        Label1.Text = "Enter a number"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtEnterNumber)
        Controls.Add(btnCalculate)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtEnterNumber As TextBox
    Friend WithEvents Label1 As Label
End Class
