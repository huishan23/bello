Public Class From1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim country As String
        Dim capital As String

        country = TextBox1.Text

        Select Case country

            Case "Malaysia"
                capital = "Kuala Lumpur"
            Case "Thailand"
                capital = "Bangkok"
            Case "Filipina"
                capital = "Manila"
            Case Else
                capital = "unknown"
        End Select

        TextBox2.Text = capital
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
