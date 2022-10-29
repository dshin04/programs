Public Class Login
    Dim Username As String
    Dim Password As String
    Dim Details As String
    Dim fileReader As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\dshin\Downloads\test.csv")
        Username = txtUsername.Text
        Password = txtPassword.Text
        profiledetails = Username + "," + Password
        If fileReader.Contains(profiledetails) Then
            If Username = "" Then
                MsgBox("Please enter a username")
            ElseIf Password = "" Then
                MsgBox("Please enter a password")
            ElseIf profiledetails = "," Then
                MsgBox("Please Enter Login Details")
            ElseIf profiledetails.Contains("admin") Then
                MsgBox("test")
            Else
                MsgBox("Login Successful")
                Me.Hide()
                MainMenuEmployees.Show()
            End If
        Else
            MsgBox("Please Enter Correct Login Details")
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        CreateAccount.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub
End Class