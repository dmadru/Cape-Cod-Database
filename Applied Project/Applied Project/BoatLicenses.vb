Imports System.Data.OleDb
Public Class BoatLicenses
    Private Sub BoatRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenDBConnection()

        Dim initialQuery As String = "Select Top(1) L.BoatLicenseID, U.FName, U.LName, U.address, L.BeachName
                                      From BoatLicenses L
                                      Join Users U
                                      On L.UserID = U.UserID; "

        databaseCommand.CommandText = initialQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        licenseTB.Text = CStr(results.Item("BoatLicenseID"))
        fnameTB.Text = CStr(results.Item("FName"))
        lnameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("Address"))
        beachTB.Text = CStr(results.Item("BeachName"))

        results.Close()
    End Sub

    Private Sub nextBTN_Click(sender As Object, e As EventArgs) Handles nextBTN.Click
        Dim BoatLicenseNumber As Integer = CInt(licenseTB.Text) + 1
        Dim maxBoatLicenseId As Integer
        Dim findMaxRegistrationId As String =
            "select MAX(BoatLicenseID) as maxBoatLicenseId From BoatLicenses"

        databaseCommand.CommandText = findMaxRegistrationId
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxBoatLicenseId = CInt(results.Item("maxBoatLicenseId"))
        results.Close()

        If (BoatLicenseNumber > maxBoatLicenseId) Then
            MsgBox("There are no more boat licenses to read")
            Exit Sub
        End If

        Dim nextQuery As String = "Select L.BoatLicenseID, U.FName, U.LName, U.Address, L.BeachName
                                   From BoatLicenses L
                                   Join Users U
                                   On L.UserID = U.UserID
                                   Where BoatLicenseID = " & BoatLicenseNumber & ";"

        databaseCommand.CommandText = nextQuery

        results = databaseCommand.ExecuteReader()

        results.Read()
        licenseTB.Text = CStr(results.Item("BoatLicenseID"))
        fnameTB.Text = CStr(results.Item("FName"))
        lnameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("Address"))
        beachTB.Text = CStr(results.Item("BeachName"))

        results.Close()
    End Sub

    Private Sub prevBTN_Click(sender As Object, e As EventArgs) Handles prevBTN.Click
        Dim BoatLicenseID As Integer = CInt(licenseTB.Text)

        Dim prevQuery As String = "Select L.BoatLicenseID, U.FName, U.LName, U.Address, L.BeachName
                                   From BoatLicenses L
                                   Join Users U
                                   On L.UserID = U.UserID
                                   Where BoatLicenseID = " & BoatLicenseID - 1 & ";"

        If BoatLicenseID <= 1 Then
            MsgBox("There are no more boat licenses to read")
            Exit Sub
        End If


        databaseCommand.CommandText = prevQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        licenseTB.Text = CStr(results.Item("BoatLicenseID"))
        fnameTB.Text = CStr(results.Item("FName"))
        lnameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("Address"))
        beachTB.Text = CStr(results.Item("BeachName"))

        results.Close()
    End Sub

    Private Sub searchBTN_Click(sender As Object, e As EventArgs) Handles searchBTN.Click
        Dim BoatLicenseID As Integer = CInt(licenseTB.Text)

        Dim searchQuery As String = "Select L.BoatLicenseID, U.FName, U.LName, U.Address, L.BeachName
                                   From BoatLicenses L
                                   Join Users U
                                   On L.UserID = U.UserID
                                   Where BoatLicenseID = " & BoatLicenseID & ";"



        databaseCommand.CommandText = searchQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        licenseTB.Text = CStr(results.Item("BoatLicenseID"))
        fnameTB.Text = CStr(results.Item("FName"))
        lnameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("Address"))
        beachTB.Text = CStr(results.Item("BeachName"))

        results.Close()
    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click


        Dim registrationID = -1
        Dim findRegID As String = '
            "Select RegistrationNumber as regID From BoatRegistrations Where UserID = '" & UserIDTB.Text & "' and BoatID = '" & boatIDTB2.Text & "'"
        databaseCommand.CommandText = findRegID
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()
        results.Read()
        If results.HasRows Then
            registrationID = CInt(results.Item("regID"))
        End If
        results.Close()

        If registrationID < 0 Then
            MsgBox("The Boat is not registered")
        Else

            Dim maxBoatLicenseId = 0
            Dim insertBoatLicense As String = ""

            Dim findMaxBoatLicenseId As String =
                "select MAX(BoatLicenseID) as maxBoatLicenseId From BoatLicenses"



            databaseCommand.CommandText = findMaxBoatLicenseId
            Dim results1 As OleDbDataReader = databaseCommand.ExecuteReader()

            results1.Read()
            maxBoatLicenseId = CInt(results1.Item("maxBoatLicenseID")) + 1
            results1.Close()



            insertBoatLicense = "insert into BoatLicenses(BoatLicenseID, UserID, BeachName, BoatID)" &
                " values( '" & maxBoatLicenseId & "','" & UserIDTB.Text + "','" & beachNameCB.Text & "','" & boatIDTB2.Text & "')"

            'MsgBox(insertBoatLicense)
            databaseCommand.CommandText = insertBoatLicense

            Dim rowsModified As Integer = databaseCommand.ExecuteNonQuery

            If (rowsModified > 0) Then
                MsgBox("License added successfully")
            Else
                MsgBox("Failed adding license")
            End If

        End If
    End Sub

    Private Sub UserIDTB_TextChanged(sender As Object, e As EventArgs) Handles UserIDTB.TextChanged

    End Sub

    Private Sub menuBTN_Click(sender As Object, e As EventArgs) Handles menuBTN.Click
        Me.Hide()
        MainMenu.Show()
        databaseConnection.Close()
    End Sub
End Class