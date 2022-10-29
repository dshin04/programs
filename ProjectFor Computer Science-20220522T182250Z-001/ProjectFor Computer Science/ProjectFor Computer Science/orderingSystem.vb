Imports System.Net.Mail
Imports System.Net
Imports System.IO
Imports Microsoft.Office.Interop

Public Class Form2
    Dim regmeat As Integer
    Dim quartermeat As Integer
    Dim quarter As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lstOrder.Items.Add("Item1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnQuarter.Click
        If largeMeals = 1 Then
            lstOrder.Items.Add("Quarter Pounder Meal Large")
            lstOrder.Items.Add("    Large Fries Meal")
            lstOrder.Items.Add("    Drink?")
        ElseIf mediumMeals = 1 Then
            lstOrder.Items.Add("Quarter Pounder Meal Medium")
            lstOrder.Items.Add("    Medium Fries Meal")
            lstOrder.Items.Add("    Drink?")
        ElseIf smallMeals = 1 Then
            lstOrder.Items.Add("Quarter Pounder Meal Small")
            lstOrder.Items.Add("    Small Fries Meal")
            lstOrder.Items.Add("    Drink?")
        ElseIf largeMeals = 0 And mediumMeals = 0 And smallMeals = 0 Then
            quarter = quarter + 1
            If lstOrder.Items.Contains("(" & quarter - 1 & ")" & " Quarter Pounder") Then
                lstOrder.Items.Remove("(" & quarter - 1 & ")" & " Quarter Pounder")
                lstOrder.Items.Add("(" & quarter & ")" & " Quarter Pounder")
            Else
                lstOrder.Items.Add("(" & quarter & ")" & " Quarter Pounder")
            End If
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles drinkCocaCola.Click
        Dim replacedrink As Integer = lstOrder.SelectedIndex()
        If lstOrder.SelectedIndex = -1 Then
            lstOrder.Items.Add("Coca-Cola Drink")
        ElseIf Not lstOrder.SelectedItem.Contains("Drink?") Then
            lstOrder.Items.Add("Coca-Cola Drink")
        ElseIf lstOrder.SelectedItem.Contains("Drink?") Then
            lstOrder.Items.RemoveAt(replacedrink)
            lstOrder.Items.Insert(replacedrink, "    Coca-Cola Drink Meal")
        End If
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles removeItem.Click
        If lstOrder.Items.Count = 0 Then
            MsgBox("There are currently no items in the order")
        ElseIf (lstOrder.SelectedIndex = -1) Then
            MsgBox("Please select an item to delete")
        ElseIf lstOrder.SelectedItem.Contains("Drink Meal") Then
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() - 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() - 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex())
        ElseIf lstOrder.SelectedItem.Contains("Drink?") Then
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() - 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() - 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex())
        ElseIf lstOrder.SelectedItem.Contains("Fries Meal") Then
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() - 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() + 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex())
        ElseIf lstOrder.SelectedItem.Contains("Meal Large") Then
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() + 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() + 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex())
        ElseIf lstOrder.SelectedItem.Contains("Meal Medium") Then
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() + 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() + 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex())
        ElseIf lstOrder.SelectedItem.Contains("Meal Small") Then
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() + 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex() + 1)
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex())
        ElseIf lstOrder.SelectedItem.Contains(" Quarter Pounder") Then
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex())
            quarter = 0
        Else
            lstOrder.Items.RemoveAt(lstOrder.SelectedIndex())

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mealSmall_Click(sender As Object, e As EventArgs) Handles mealSmall.Click
        smallMeals = 1
        mediumMeals = 0
        largeMeals = 0
    End Sub

    Private Sub mealMedium_Click(sender As Object, e As EventArgs) Handles mealMedium.Click
        smallMeals = 0
        mediumMeals = 1
        largeMeals = 0
    End Sub

    Private Sub mealLarge_Click(sender As Object, e As EventArgs) Handles mealLarge.Click
        smallMeals = 0
        mediumMeals = 0
        largeMeals = 1
    End Sub

    Private Sub noMeal_Click(sender As Object, e As EventArgs) Handles noMeal.Click
        smallMeals = 0
        mediumMeals = 0
        largeMeals = 0
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrder.SelectedIndexChanged

    End Sub

    Private Sub sumbitOrder_Click(sender As Object, e As EventArgs) Handles sumbitOrder.Click
        Dim fileReader As String
        IO.File.WriteAllLines("C:\Users\dshin\Downloads\orderSystem.txt", lstOrder.Items.Cast(Of String).ToArray)
        fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\dshin\Downloads\orderSystem.txt")
        Dim excelApplication As New Excel.Application
        Dim excelWorkbook As Excel.Workbook

        excelWorkbook = excelApplication.Workbooks.Open("C:\Users\dshin\Downloads\stockManagementFile.xlsm")
        excelWorkbook.Save()
        excelWorkbook.Close()

        Try
        Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Dim attach As New Attachment("C:\Users\dshin\Downloads\testStockManagementLevel.pdf")
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("testforsystem5470@outlook.com", "Blackpool123b")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp-mail.outlook.com"
            Smtp_Server.DeliveryMethod = SmtpDeliveryMethod.Network

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("testforcomputer123@outlook.com")
            e_mail.To.Add("ds214195@blackpoolsixth.ac.uk")
            e_mail.Subject = "Stock Level"
            e_mail.IsBodyHtml = False
            ' e_mail.Attachments.Add(attach)
            e_mail.Body = "Thank you for Ordering!" & vbNewLine & vbNewLine & fileReader & vbNewLine & vbNewLine & "Your Total is: "
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sent")

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
End Class