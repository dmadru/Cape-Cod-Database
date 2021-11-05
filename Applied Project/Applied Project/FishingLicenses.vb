Imports System.Data.OleDb
Public Class FishingLicenses
    Private Sub FishingLicenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenDBConnection()
        Dim initialQuery As String = "Select Top(1) F.FishingLicenseID, U.FName, U.LName, U.address, f.BeachName
                                      From FishingLicenses F
                                      Join Users U
                                      On F.UserID = U.UserID; "

        databaseCommand.CommandText = initialQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        licenseNumberTB.Text = CStr(results.Item("FishingLicenseID"))
        fnameTB.Text = CStr(results.Item("FName"))
        lnameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("Address"))
        beachTB.Text = CStr(results.Item("BeachName"))

        results.Close()
    End Sub

    Private Sub nextBTN_Click(sender As Object, e As EventArgs) Handles nextBTN.Click
        Dim FishingLicenseID As Integer = CInt(licenseNumberTB.Text) + 1
        Dim maxFishingLicenseId As Integer
        Dim findMaxLicenseId As String =
            "select MAX(FishingLicenseID) as maxFishingLicenseId From FishingLicenses"

        databaseCommand.CommandText = findMaxLicenseId
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxFishingLicenseId = CInt(results.Item("maxFishingLicenseId"))
        results.Close()

        If (FishingLicenseID > maxFishingLicenseId) Then
            MsgBox("There are no more fishing licenses to read")
            Exit Sub
        End If

        Dim nextQuery As String = "Select F.FishingLicenseID, U.FName, U.LName, U.address, f.BeachName
                                   From FishingLicenses F
                                   Join Users U
                                   On F.UserID = U.UserID
                                   Where FishingLicenseID = " & FishingLicenseID & ";"



        databaseCommand.CommandText = nextQuery

        results = databaseCommand.ExecuteReader()

        results.Read()
        licenseNumberTB.Text = CStr(results.Item("FishingLicenseID"))
        fnameTB.Text = CStr(results.Item("FName"))
        lnameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("Address"))
        beachTB.Text = CStr(results.Item("BeachName"))

        results.Close()
    End Sub

    Private Sub prevBTN_Click(sender As Object, e As EventArgs) Handles prevBTN.Click
        Dim FishingLicenseID As Integer = CInt(licenseNumberTB.Text)

        Dim prevQuery As String = "Select F.FishingLicenseID, U.FName, U.LName, U.address, f.BeachName
                                   From FishingLicenses F
                                   Join Users U
                                   On F.UserID = U.UserID
                                   Where FishingLicenseID = " & FishingLicenseID - 1 & ";"

        If FishingLicenseID <= 1 Then
            MsgBox("There are no more fishing licenses to read")
            Exit Sub
        End If


        databaseCommand.CommandText = prevQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        licenseNumberTB.Text = CStr(results.Item("FishingLicenseID"))
        fnameTB.Text = CStr(results.Item("FName"))
        lnameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("Address"))
        beachTB.Text = CStr(results.Item("BeachName"))

        results.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles searchBTN.Click
        Dim FishingLicenseID As Integer = CInt(licenseNumberTB.Text)

        Dim searchQuery As String = "Select F.FishingLicenseID, U.FName, U.LName, U.address, f.BeachName
                                   From FishingLicenses F
                                   Join Users U
                                   On F.UserID = U.UserID
                                   Where FishingLicenseID = " & FishingLicenseID & ";"



        databaseCommand.CommandText = searchQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        licenseNumberTB.Text = CStr(results.Item("FishingLicenseID"))
        fnameTB.Text = CStr(results.Item("FName"))
        lnameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("Address"))
        beachTB.Text = CStr(results.Item("BeachName"))

        results.Close()
    End Sub

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        Dim maxFishingLicenseId = 0
        Dim insertFishingLicense As String = ""

        Dim findMaxFishingLicenseId As String =
            "select MAX(FishingLicenseID) as maxFishingLicenseId From FishingLicenses"

        databaseCommand.CommandText = findMaxFishingLicenseId
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxFishingLicenseId = CInt(results.Item("maxFishingLicenseId")) + 1
        results.Close()



        insertFishingLicense = "insert into FishingLicenses(FishingLicenseID, UserID, BeachName)" &
            " values( '" & maxFishingLicenseId & "','" & UserIDTB.Text + "','" & beachCB.Text & "')"

        'MsgBox(insertFishingLicense)
        databaseCommand.CommandText = insertFishingLicense

        Dim rowsModified As Integer = databaseCommand.ExecuteNonQuery

        If (rowsModified > 0) Then
            MsgBox("License added successfully")
        Else
            MsgBox("Failed adding license")
        End If

    End Sub

    Private Sub menuBTN_Click(sender As Object, e As EventArgs) Handles menuBTN.Click
        Me.Hide()
        MainMenu.Show()
        databaseConnection.Close()
    End Sub
End Class