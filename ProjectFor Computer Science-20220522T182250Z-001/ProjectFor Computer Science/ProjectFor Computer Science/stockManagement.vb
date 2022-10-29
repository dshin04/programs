Public Class Form1
    'Main Usuable Variables
    Dim fileAllRead As String

    'Food items
    Dim regmeat As Integer
    Dim quartermeat As Integer
    Dim promomeat As Integer
    Dim nuggets As Integer
    Dim selects As Integer
    Dim legends As Integer
    Dim mayochicken As Integer
    Dim sandwiches As Integer
    Dim applepies As Integer
    Dim veggies As Integer
    Dim promochicken As Integer
    Dim cheesebites As Integer
    Dim filet As Integer
    Dim fishfingers As Integer
    Dim fries As Integer
    Dim plantpatties As Integer

    'Dry stock and mixes
    Dim productboxes As Integer
    Dim shareboxes As Integer
    Dim wrappers As Integer
    Dim trayliners As Integer
    Dim mixes As Integer

    'Buns and Tortillas
    Dim regbuns As Integer
    Dim bigmacbuns As Integer
    Dim quarterbuns As Integer
    Dim tortilla As Integer
    Dim meatbunspromo As Integer
    Dim chickenbunspromo As Integer
    Dim legendbuns As Integer

    Private Sub regmeatminus_Click(sender As Object, e As EventArgs) Handles regmeatminus.Click
        regmeat = regmeat - 1
        regmeatquantity.Text = regmeat
        If regmeat <= 0 Then
            regmeat = 0
            regmeatquantity.Text = regmeat
        End If
    End Sub

    Private Sub regmeatplus_Click(sender As Object, e As EventArgs) Handles regmeatplus.Click
        regmeat = regmeat + 1
        regmeatquantity.Text = regmeat
    End Sub

    Private Sub quartermeatminus_Click(sender As Object, e As EventArgs) Handles quartermeatminus.Click
        quartermeat = quartermeat - 1
        quartermeatquantity.Text = quartermeat
        If quartermeat <= 0 Then
            quartermeat = 0
            quartermeatquantity.Text = quartermeat
        End If
    End Sub

    Private Sub quartermeatplus_Click(sender As Object, e As EventArgs) Handles quartermeatplus.Click
        quartermeat = quartermeat + 1
        quartermeatquantity.Text = quartermeat
    End Sub

    Private Sub promotionalmeatminus_Click(sender As Object, e As EventArgs) Handles promotionalmeatminus.Click
        promomeat = promomeat - 1
        promotionalmeatquantity.Text = promomeat
        If promomeat <= 0 Then
            promomeat = 0
            promotionalmeatquantity.Text = promomeat
        End If
    End Sub

    Private Sub promotionalmeatplus_Click(sender As Object, e As EventArgs) Handles promotionalmeatplus.Click
        promomeat = promomeat + 1
        promotionalmeatquantity.Text = promomeat
    End Sub

    Private Sub nuggetsminus_Click(sender As Object, e As EventArgs) Handles nuggetsminus.Click
        nuggets = nuggets - 1
        nuggetsquantity.Text = nuggets
        If nuggets <= 0 Then
            nuggets = 0
            nuggetsquantity.Text = nuggets
        End If
    End Sub

    Private Sub nuggetsplus_Click(sender As Object, e As EventArgs) Handles nuggetsplus.Click
        nuggets = nuggets + 1
        nuggetsquantity.Text = nuggets
    End Sub

    Private Sub selectsminus_Click(sender As Object, e As EventArgs) Handles selectsminus.Click
        selects = selects - 1
        selectsquantity.Text = selects
        If selects <= 0 Then
            selects = 0
            selectsquantity.Text = selects
        End If
    End Sub

    Private Sub selectsplus_Click(sender As Object, e As EventArgs) Handles selectsplus.Click
        selects = selects + 1
        selectsquantity.Text = selects
    End Sub

    Private Sub legendsminus_Click(sender As Object, e As EventArgs) Handles legendsminus.Click
        legends = legends - 1
        legendsquantity.Text = legends
        If legends <= 0 Then
            legends = 0
            legendsquantity.Text = legends
        End If
    End Sub

    Private Sub legendsplus_Click(sender As Object, e As EventArgs) Handles legendsplus.Click
        legends = legends + 1
        legendsquantity.Text = legends
    End Sub

    Private Sub mayochickenminus_Click(sender As Object, e As EventArgs) Handles mayochickenminus.Click
        mayochicken = mayochicken - 1
        mayochickenquantity.Text = mayochicken
        If mayochicken <= 0 Then
            mayochicken = 0
            mayochickenquantity.Text = mayochicken

        End If
    End Sub

    Private Sub mayochickenplus_Click(sender As Object, e As EventArgs) Handles mayochickenplus.Click
        mayochicken = mayochicken + 1
        mayochickenquantity.Text = mayochicken
    End Sub
    Private Sub sandwichesminus_Click(sender As Object, e As EventArgs) Handles sandwichesminus.Click
        sandwiches = sandwiches - 1
        sandwichesquantity.Text = sandwiches
        If sandwiches <= 0 Then
            sandwiches = 0
            sandwichesquantity.Text = sandwiches

        End If
    End Sub

    Private Sub sandwichesplus_Click(sender As Object, e As EventArgs) Handles sandwichesplus.Click
        sandwiches = sandwiches + 1
        sandwichesquantity.Text = sandwiches
    End Sub
    Private Sub applepiesminus_Click(sender As Object, e As EventArgs) Handles applepiesminus.Click
        applepies = applepies - 1
        applepiesquantity.Text = applepies
        If applepies <= 0 Then
            applepies = 0
            applepiesquantity.Text = applepies

        End If
    End Sub

    Private Sub applepiesplus_Click(sender As Object, e As EventArgs) Handles applepiesplus.Click
        applepies = applepies + 1
        applepiesquantity.Text = applepies
    End Sub
    Private Sub veggiesminus_Click(sender As Object, e As EventArgs) Handles veggiesminus.Click
        veggies = veggies - 1
        veggiesquantity.Text = veggies
        If veggies <= 0 Then
            veggies = 0
            veggiesquantity.Text = veggies

        End If
    End Sub

    Private Sub veggiesplus_Click(sender As Object, e As EventArgs) Handles veggiesplus.Click
        veggies = veggies + 1
        veggiesquantity.Text = veggies
    End Sub
    Private Sub promochickenminus_Click(sender As Object, e As EventArgs) Handles promochickenminus.Click
        promochicken = promochicken - 1
        promochickenquantity.Text = promochicken
        If promochicken <= 0 Then
            promochicken = 0
            promochickenquantity.Text = promochicken

        End If
    End Sub

    Private Sub promochickenplus_Click(sender As Object, e As EventArgs) Handles promochickenplus.Click
        promochicken = promochicken + 1
        promochickenquantity.Text = promochicken
    End Sub

    Private Sub cheesebitesminus_Click(sender As Object, e As EventArgs) Handles cheesebitesminus.Click
        cheesebites = cheesebites - 1
        cheesebitesquantity.Text = cheesebites
        If cheesebites <= 0 Then
            cheesebites = 0
            cheesebitesquantity.Text = cheesebites

        End If
    End Sub

    Private Sub cheesebitesplus_Click(sender As Object, e As EventArgs) Handles cheesebitesplus.Click
        cheesebites = cheesebites + 1
        cheesebitesquantity.Text = cheesebites
    End Sub

    Private Sub filetminus_Click(sender As Object, e As EventArgs) Handles filetminus.Click
        filet = filet - 1
        filetquantity.Text = filet
        If filet <= 0 Then
            filet = 0
            filetquantity.Text = filet

        End If
    End Sub

    Private Sub filetplus_Click(sender As Object, e As EventArgs) Handles filetplus.Click
        filet = filet + 1
        filetquantity.Text = filet
    End Sub

    Private Sub fishfingersminus_Click(sender As Object, e As EventArgs) Handles fishfingersminus.Click
        fishfingers = fishfingers - 1
        fishfingersquantity.Text = fishfingers
        If fishfingers <= 0 Then
            fishfingers = 0
            fishfingersquantity.Text = fishfingers

        End If
    End Sub

    Private Sub fishfingersplus_Click(sender As Object, e As EventArgs) Handles fishfingersplus.Click
        fishfingers = fishfingers + 1
        fishfingersquantity.Text = fishfingers
    End Sub
    Private Sub friesminus_Click(sender As Object, e As EventArgs) Handles friesminus.Click
        fries = fries - 1
        friesquantity.Text = fries
        If fries <= 0 Then
            fries = 0
            friesquantity.Text = fries

        End If
    End Sub

    Private Sub friesplus_Click(sender As Object, e As EventArgs) Handles friesplus.Click
        fries = fries + 1
        friesquantity.Text = fries
    End Sub

    Private Sub plantpattiesminus_Click(sender As Object, e As EventArgs) Handles plantpattiesminus.Click
        plantpatties = plantpatties - 1
        plantpattiesquantity.Text = plantpatties
        If plantpatties <= 0 Then
            plantpatties = 0
            plantpattiesquantity.Text = plantpatties

        End If
    End Sub

    Private Sub plantpattiesplus_Click(sender As Object, e As EventArgs) Handles plantpattiesplus.Click
        plantpatties = plantpatties + 1
        plantpattiesquantity.Text = plantpatties
    End Sub

    Private Sub productboxesminus_Click(sender As Object, e As EventArgs) Handles productboxesminus.Click
        productboxes = productboxes - 1
        productboxesquantity.Text = productboxes
        If productboxes <= 0 Then
            productboxes = 0
            productboxesquantity.Text = productboxes

        End If
    End Sub

    Private Sub productboxesplus_Click(sender As Object, e As EventArgs) Handles productboxesplus.Click
        productboxes = productboxes + 1
        productboxesquantity.Text = productboxes
    End Sub

    Private Sub shareboxesminus_Click(sender As Object, e As EventArgs) Handles shareboxesminus.Click
        shareboxes = shareboxes - 1
        shareboxesquantity.Text = shareboxes
        If shareboxes <= 0 Then
            shareboxes = 0
            shareboxesquantity.Text = shareboxes

        End If
    End Sub

    Private Sub shareboxesplus_Click(sender As Object, e As EventArgs) Handles shareboxesplus.Click
        shareboxes = shareboxes + 1
        shareboxesquantity.Text = shareboxes
    End Sub

    Private Sub wrappersminus_Click(sender As Object, e As EventArgs) Handles wrappersminus.Click
        wrappers = wrappers - 1
        wrappersquantity.Text = wrappers
        If wrappers <= 0 Then
            wrappers = 0
            wrappersquantity.Text = wrappers

        End If
    End Sub

    Private Sub wrappersplus_Click(sender As Object, e As EventArgs) Handles wrappersplus.Click
        wrappers = wrappers + 1
        wrappersquantity.Text = wrappers
    End Sub

    Private Sub traylinersminus_Click(sender As Object, e As EventArgs) Handles traylinersminus.Click
        trayliners = trayliners - 1
        traylinersquantity.Text = trayliners
        If trayliners <= 0 Then
            trayliners = 0
            traylinersquantity.Text = trayliners

        End If
    End Sub

    Private Sub traylinersplus_Click(sender As Object, e As EventArgs) Handles traylinersplus.Click
        trayliners = trayliners + 1
        traylinersquantity.Text = trayliners
    End Sub

    Private Sub mixesminus_Click(sender As Object, e As EventArgs) Handles mixesminus.Click
        mixes = mixes - 1
        mixesquantity.Text = mixes
        If mixes <= 0 Then
            mixes = 0
            mixesquantity.Text = mixes

        End If
    End Sub

    Private Sub mixesplus_Click(sender As Object, e As EventArgs) Handles mixesplus.Click
        mixes = mixes + 1
        mixesquantity.Text = mixes
    End Sub

    Private Sub regbunsminus_Click(sender As Object, e As EventArgs) Handles regbunsminus.Click
        regbuns = regbuns - 1
        regbunsquantity.Text = regbuns
        If regbuns <= 0 Then
            regbuns = 0
            regbunsquantity.Text = regbuns

        End If
    End Sub

    Private Sub regbunsplus_Click(sender As Object, e As EventArgs) Handles regbunsplus.Click
        regbuns = regbuns + 1
        regbunsquantity.Text = regbuns
    End Sub

    Private Sub bigmacbunsminus_Click(sender As Object, e As EventArgs) Handles bigmacbunsminus.Click
        bigmacbuns = bigmacbuns - 1
        bigmacbunsquantity.Text = bigmacbuns
        If bigmacbuns <= 0 Then
            bigmacbuns = 0
            bigmacbunsquantity.Text = bigmacbuns

        End If
    End Sub

    Private Sub bigmacbunsplus_Click(sender As Object, e As EventArgs) Handles bigmacbunsplus.Click
        bigmacbuns = bigmacbuns + 1
        bigmacbunsquantity.Text = bigmacbuns
    End Sub

    Private Sub quarterbunsminus_Click(sender As Object, e As EventArgs) Handles quarterbunsminus.Click
        quarterbuns = quarterbuns - 1
        quarterbunsquantity.Text = quarterbuns
        If quarterbuns <= 0 Then
            quarterbuns = 0
            quarterbunsquantity.Text = quarterbuns

        End If
    End Sub

    Private Sub quarterbunsplus_Click(sender As Object, e As EventArgs) Handles quarterbunsplus.Click
        quarterbuns = quarterbuns + 1
        quarterbunsquantity.Text = quarterbuns
    End Sub

    Private Sub tortillaminus_Click(sender As Object, e As EventArgs) Handles tortillaminus.Click
        tortilla = tortilla - 1
        tortillaquantity.Text = tortilla
        If tortilla <= 0 Then
            tortilla = 0
            tortillaquantity.Text = tortilla

        End If
    End Sub

    Private Sub tortillaplus_Click(sender As Object, e As EventArgs) Handles tortillaplus.Click
        tortilla = tortilla + 1
        tortillaquantity.Text = tortilla
    End Sub

    Private Sub meatbunspromominus_Click(sender As Object, e As EventArgs) Handles meatbunspromominus.Click
        meatbunspromo = meatbunspromo - 1
        meatbunspromoquantity.Text = meatbunspromo
        If meatbunspromo <= 0 Then
            meatbunspromo = 0
            meatbunspromoquantity.Text = meatbunspromo

        End If
    End Sub

    Private Sub meatbunspromoplus_Click(sender As Object, e As EventArgs) Handles meatbunspromoplus.Click
        meatbunspromo = meatbunspromo + 1
        meatbunspromoquantity.Text = meatbunspromo
    End Sub
    Private Sub chickenbunspromominus_Click(sender As Object, e As EventArgs) Handles chickenbunspromominus.Click
        chickenbunspromo = chickenbunspromo - 1
        chickenbunspromoquantity.Text = chickenbunspromo
        If chickenbunspromo <= 0 Then
            chickenbunspromo = 0
            chickenbunspromoquantity.Text = chickenbunspromo

        End If
    End Sub

    Private Sub chickenbunspromoplus_Click(sender As Object, e As EventArgs) Handles chickenbunspromoplus.Click
        chickenbunspromo = chickenbunspromo + 1
        chickenbunspromoquantity.Text = chickenbunspromo
    End Sub

    Private Sub legendbunsminus_Click(sender As Object, e As EventArgs) Handles legendbunsminus.Click
        legendbuns = legendbuns - 1
        legendbunsquantity.Text = legendbuns
        If legendbuns <= 0 Then
            legendbuns = 0
            legendbunsquantity.Text = legendbuns

        End If
    End Sub

    Private Sub legendbunsplus_Click(sender As Object, e As EventArgs) Handles legendbunsplus.Click
        legendbuns = legendbuns + 1
        legendbunsquantity.Text = legendbuns
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fileAllRead = My.Computer.FileSystem.ReadAllText("C:\Users\dshin\Downloads\stockManagementSave.csv")
        Dim seperateStock() As String
        seperateStock = fileAllRead.Split(",")
        'Assigning the variable quantities to the split integers of the file
        regmeat = seperateStock(0)
        quartermeat = seperateStock(1)
        promomeat = seperateStock(2)
        nuggets = seperateStock(3)
        selects = seperateStock(4)
        legends = seperateStock(5)
        mayochicken = seperateStock(6)
        sandwiches = seperateStock(7)
        applepies = seperateStock(8)
        veggies = seperateStock(9)
        promochicken = seperateStock(10)
        cheesebites = seperateStock(11)
        filet = seperateStock(12)
        fishfingers = seperateStock(13)
        fries = seperateStock(14)
        plantpatties = seperateStock(15)
        productboxes = seperateStock(16)
        shareboxes = seperateStock(17)
        wrappers = seperateStock(18)
        trayliners = seperateStock(19)
        mixes = seperateStock(20)
        regbuns = seperateStock(21)
        bigmacbuns = seperateStock(22)
        quarterbuns = seperateStock(23)
        tortilla = seperateStock(24)
        meatbunspromo = seperateStock(25)
        chickenbunspromo = seperateStock(26)
        legendbuns = seperateStock(27)

        'assigning the new integers to the quantity text
        regmeatquantity.Text = regmeat
        quartermeatquantity.Text = quartermeat
        promotionalmeatquantity.Text = promomeat
        nuggetsquantity.Text = nuggets
        selectsquantity.Text = selects
        legendsquantity.Text = legends
        mayochickenquantity.Text = mayochicken
        sandwichesquantity.Text = sandwiches
        applepiesquantity.Text = applepies
        veggiesquantity.Text = veggies
        promochickenquantity.Text = promochicken
        cheesebitesquantity.Text = cheesebites
        filetquantity.Text = filet
        fishfingersquantity.Text = fishfingers
        friesquantity.Text = fries
        plantpattiesquantity.Text = plantpatties
        productboxesquantity.Text = productboxes
        shareboxesquantity.Text = shareboxes
        wrappersquantity.Text = wrappers
        traylinersquantity.Text = trayliners
        mixesquantity.Text = mixes
        regbunsquantity.Text = regbuns
        bigmacbunsquantity.Text = bigmacbuns
        quarterbunsquantity.Text = quarterbuns
        tortillaquantity.Text = tortilla
        meatbunspromoquantity.Text = meatbunspromo
        chickenbunspromoquantity.Text = chickenbunspromo
        legendbunsquantity.Text = legendbuns
    End Sub

    Private Sub saveStock_Click(sender As Object, e As EventArgs) Handles saveStock.Click
        My.Computer.FileSystem.WriteAllText("C:\Users\dshin\Downloads\stockManagementSave.csv",
regmeat & "," & quartermeat & "," & promomeat & "," & nuggets & "," & selects & "," & legends & "," & mayochicken & "," & sandwiches & "," & applepies & "," & veggies & "," & promochicken & "," & cheesebites & "," & filet & "," & fishfingers & "," & fries & "," & plantpatties & "," & productboxes & "," & shareboxes & "," & wrappers & "," & trayliners & "," & mixes & "," & regbuns & "," & bigmacbuns & "," & quarterbuns & "," & tortilla & "," & meatbunspromo & "," & chickenbunspromo & "," & legendbuns, False)
        MsgBox("Stock Level Saved!")
    End Sub
End Class
