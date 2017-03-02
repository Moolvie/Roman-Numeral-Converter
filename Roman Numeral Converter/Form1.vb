Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' close it up
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variable
        Dim intNumber As Integer

        If Integer.TryParse(txtNumber.Text, intNumber) Then
            Select Case intNumber

                Case 1
                    lblNumber.Text = "I"
                Case 2
                    lblNumber.Text = "II"
                Case 3
                    lblNumber.Text = "III"
                Case 4
                    lblNumber.Text = "IV"
                Case 5
                    lblNumber.Text = "V"
                Case 6
                    lblNumber.Text = "VI"
                Case 7
                    lblNumber.Text = "VII"
                Case 8
                    lblNumber.Text = "VIII"
                Case 9
                    lblNumber.Text = "IX"
                Case 10
                    lblNumber.Text = "X"
                Case Else
                    MessageBox.Show("You must enter an integer between 1 and 10")
            End Select
        Else
            MessageBox.Show("Invalid input")
        End If
    End Sub
End Class
