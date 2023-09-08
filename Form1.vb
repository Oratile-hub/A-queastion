Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim isNumber As String

        isNumber = txtEnterNumber.Text

        On Error GoTo ErrorHandler

        Dim numericValue As Double
        numericValue = CDbl(isNumber)

        MsgBox("You entered a valid number: " & numericValue)
        Exit Sub

ErrorHandler:
        MsgBox("Error: " & isNumber & " is not a number")



    End Sub
End Class
