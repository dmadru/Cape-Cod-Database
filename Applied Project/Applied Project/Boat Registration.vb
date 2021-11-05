Imports System.Data.OleDb
Public Class Boat_Registration
    Private Sub Boat_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenDBConnection()

        Dim boatRegQuery As String = "Select Top(1) RegistrationNumber, UserID, BoatID
                                      From  BoatRegistrations; "

        databaseCommand.CommandText = boatRegQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        regIDTB.Text = CStr(results.Item("RegistrationNumber"))
        userIDTB.Text = CStr(results.Item("UserID"))
        boatIDTB.Text = CStr(results.Item("BoatID"))

        results.Close()


    End Sub

    Private Sub nextBTN_Click(sender As Object, e As EventArgs) Handles nextBTN.Click
        Dim nextRegID As Integer = CInt(regIDTB.Text) + 1
        Dim maxRegID As Integer
        Dim findMaxBoatReg As String =
            "select MAX(RegistrationNumber) as maxRegID From BoatRegistrations"

        databaseCommand.CommandText = findMaxBoatReg
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxRegID = CInt(results.Item("maxRegID"))
        results.Close()

        If (nextRegID > maxRegID) Then
            MsgBox("There are no more boat registrations to read")
            Exit Sub
        End If

        Dim nextQuery As String = "Select RegistrationNumber, UserID, BoatID
                                      From  BoatRegistrations Where RegistrationNumber = " & nextRegID




        databaseCommand.CommandText = nextQuery

        results = databaseCommand.ExecuteReader()

        results.Read()
        regIDTB.Text = CStr(results.Item("RegistrationNumber"))
        userIDTB.Text = CStr(results.Item("UserID"))
        boatIDTB.Text = CStr(results.Item("BoatID"))


        results.Close()
    End Sub

    Private Sub prevBTN_Click(sender As Object, e As EventArgs) Handles prevBTN.Click
        Dim RegID As Integer = CInt(regIDTB.Text)

        Dim prevQuery As String = "Select RegistrationNumber, UserID, BoatID
                                      From  BoatRegistrations Where RegistrationNumber = " & RegID - 1

        If RegID <= 1 Then
            MsgBox("There are no more boat registrations to read")
            Exit Sub
        End If


        databaseCommand.CommandText = prevQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        regIDTB.Text = CStr(results.Item("RegistrationNumber"))
        userIDTB.Text = CStr(results.Item("UserID"))
        boatIDTB.Text = CStr(results.Item("BoatID"))


        results.Close()
    End Sub

    Private Sub addregBTN_Click(sender As Object, e As EventArgs) Handles addregBTN.Click
        Dim maxRegId = 0
        Dim insertRegistration As String = ""

        Dim findMaxRegId As String =
            "select MAX(RegistrationNumber) as maxRegID From boatRegistrations"

        databaseCommand.CommandText = findMaxRegId
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxRegId = CInt(results.Item("maxRegID")) + 1
        results.Close()



        insertRegistration = "insert into boatRegistrations( RegistrationNumber, UserID, BoatID)" &
            " values( '" & maxRegId & "','" & userIDTB2.Text & "','" & boatIDTB2.Text & "')"

        'MsgBox(insertRegistration)
        databaseCommand.CommandText = insertRegistration

        Dim rowsModified As Integer = databaseCommand.ExecuteNonQuery
        If (rowsModified > 0) Then
            MsgBox("Permit added successfully")
        Else
            MsgBox("Failed adding permit")
        End If
    End Sub

    Private Sub menuBTN_Click(sender As Object, e As EventArgs) Handles menuBTN.Click
        Me.Hide()
        MainMenu.Show()
        databaseConnection.Close()
    End Sub
End Class