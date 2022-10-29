Public Class CreateAccount
    Dim firstname As String
    Dim surname As String
    Dim employeenumber As String
    Dim emailaddress As String
    Dim phonenumber As String
    Dim password As String
    Dim profiledetails As String
    Dim fileReader As String
    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\dshin\Downloads\test.txt")
        Dim file As System.IO.StreamWriter
        firstname = txtFirstName.Text
        surname = txtSurname.Text
        employeenumber = txtEmployeeNumber.Text
        emailaddress = txtEmailAddresss.Text
        phonenumber = txtPhoneNumber.Text
        password = txtPassword.Text
        profiledetails = firstname + "," + surname + "," + emailaddress + "," + phonenumber + "," + employeenumber + "," + password
        If fileReader.Contains(profiledetails) Then
            MsgBox("These details are already being used for an account!")
        ElseIf profiledetails.Contains(",,") Then
            MsgBox("Please enter all details for account creation")
        Else
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\dshin\Downloads\test.csv", True)
            file.WriteLine(profiledetails)
            file.Close()
            MsgBox("Account Created!")
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub
End Class