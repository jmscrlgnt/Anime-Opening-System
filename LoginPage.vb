Public Class LoginForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Hide()

        Dim AdminLoginPage As New AdminLoginPage()
        AdminLoginPage.Show()
    End Sub



    Private Sub LnklblPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnklblPassword.LinkClicked
        Dim ForgotPassword As New ForgotPassword()
        ForgotPassword.Show()
        Me.Hide()
    End Sub

    Private Sub LnklblSign_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim Signup As New SignupPage()
        SignupPage.Show()
        Me.Hide()
    End Sub








    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Votingpage As New VotingPage()
        Votingpage.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim AdminControlpanel As New AdminControlPanel()
        AdminControlpanel.Show()
        Me.Hide()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim expectedUsername As String = "Asser"
        Dim expectedPassword As String = "jmscrlgnt"

        Dim enteredUsername As String = txtUsername.Text
        Dim enteredPassword As String = txtPassword.Text

        If enteredUsername = expectedUsername AndAlso enteredPassword = expectedPassword Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim votingpage As New VotingPage()
            votingpage.Show()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
        End If

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()

        Dim AdminLoginPage As New AdminLoginPage()
        AdminLoginPage.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Signup As New SignupPage()
        SignupPage.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub
End Class
