Imports System.Data.OleDb
Public Class ParkingPermits
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenDBConnection()

        Dim initialQuery As String = "Select Top(1) P.ParkingPermitID, U.FName, U.LName, U.address, p.plateInfo
                                      From parkingPermits P
                                      Join Users U
                                      On P.UserID = U.UserID; "

        databaseCommand.CommandText = initialQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        permitTB.Text = CStr(results.Item("ParkingPermitID"))
        fNameTB.Text = CStr(results.Item("FName"))
        lNameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("Address"))
        lPlateTB.Text = CStr(results.Item("plateInfo"))

        results.Close()

    End Sub

    Private Sub nextBTN_Click(sender As Object, e As EventArgs) Handles nextBTN.Click

        Dim parkingPermitNumber As Integer = CInt(permitTB.Text) + 1
        Dim maxParkingPermitId As Integer
        Dim findMaxParkingPermitId As String =
            "select MAX(ParkingPermitID) as maxParkingPermitId From parkingPermits"

        databaseCommand.CommandText = findMaxParkingPermitId
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxParkingPermitId = CInt(results.Item("maxParkingPermitId"))
        results.Close()

        If (parkingPermitNumber > maxParkingPermitId) Then
            MsgBox("There are no more parking permits to read")
            Exit Sub
        End If

        Dim nextQuery As String = "Select P.ParkingPermitID, U.FName, U.LName, U.Address, P.plateInfo" &
                                   " From parkingPermits P Join Users U On P.UserID = U.UserID Where ParkingPermitID = " &
                                   parkingPermitNumber



        databaseCommand.CommandText = nextQuery

        results = databaseCommand.ExecuteReader()

        results.Read()
        permitTB.Text = CStr(results.Item("ParkingPermitID"))
        fNameTB.Text = CStr(results.Item("FName"))
        lNameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("Address"))
        lPlateTB.Text = CStr(results.Item("plateInfo"))

        results.Close()

    End Sub

    Private Sub prevBTN_Click(sender As Object, e As EventArgs) Handles prevBTN.Click

        Dim parkingPermitNumber As Integer = CInt(permitTB.Text)

        Dim prevQuery As String = "Select P.ParkingPermitID, U.FName, U.LName, U.Address, P.plateInfo" &
                                   " From parkingPermits P Join Users U On P.UserID = U.UserID Where ParkingPermitID = " &
                                   parkingPermitNumber - 1

        If parkingPermitNumber <= 1 Then
            MsgBox("There are no more parking permits to read")
            Exit Sub
        End If


        databaseCommand.CommandText = prevQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        permitTB.Text = CStr(results.Item("parkingPermitID"))
        fNameTB.Text = CStr(results.Item("FName"))
        lNameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("address"))
        lPlateTB.Text = CStr(results.Item("plateInfo"))

        results.Close()
    End Sub

    Private Sub searchBTN_Click(sender As Object, e As EventArgs) Handles searchBTN.Click

        Dim parkingPermitNumber As Integer = CInt(permitTB.Text)

        Dim searchQuery As String = "Select P.ParkingPermitID, U.FName, U.LName, U.Address, P.plateInfo" &
                                   " From parkingPermits P Join Users U On P.UserID = U.UserID Where ParkingPermitID = " &
                                   parkingPermitNumber



        databaseCommand.CommandText = searchQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        permitTB.Text = CStr(results.Item("parkingPermitID"))
        fNameTB.Text = CStr(results.Item("FName"))
        lNameTB.Text = CStr(results.Item("LName"))
        addressTB.Text = CStr(results.Item("address"))
        lPlateTB.Text = CStr(results.Item("plateInfo"))

        results.Close()

    End Sub

    Private Sub updateBTN_Click(sender As Object, e As EventArgs) Handles updateBTN.Click
        Dim maxPermitId = 0
        Dim insertParkingPermit As String = ""

        Dim findMaxPermitId As String =
            "select MAX(parkingPermitID) as maxPermitId From parkingPermits"

        databaseCommand.CommandText = findMaxPermitId
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxPermitId = CInt(results.Item("maxPermitId")) + 1
        results.Close()



        insertParkingPermit = "insert into parkingPermits(ParkingPermitID, UserID, BeachName, plateInfo)" &
            " values( '" & maxPermitId & "','" & userIDTB.Text & "','" & beachNameCB.Text & "','" & plateTB.Text & "')"

        'MsgBox(insertParkingPermit)
        databaseCommand.CommandText = insertParkingPermit

        Dim rowsModified As Integer = databaseCommand.ExecuteNonQuery

        If (rowsModified > 0) Then
            MsgBox("Permit added successfully")
        Else
            MsgBox("Failed adding permit")
        End If


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub menuBTN_Click(sender As Object, e As EventArgs) Handles menuBTN.Click
        Me.Hide()
        MainMenu.Show()
        databaseConnection.Close()
    End Sub
End Class
