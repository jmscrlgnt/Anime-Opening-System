Public Class ForgotPassword


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim expectedUsername As String = "Group1"
        Dim username As String = TextBox2.Text
        Dim email As String = TextBox1.Text

        If String.IsNullOrEmpty(username) OrElse
      String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter all required information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not email.Contains("@") OrElse Not email.EndsWith(".com") Then
            MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If username = expectedUsername Then

            MessageBox.Show("Password reset email has been sent to the provided email address.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form1 As New LoginForm()
            LoginForm.Show()
            Me.Hide()
        Else

            MessageBox.Show("The provided username does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim form1 As New LoginForm()
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class