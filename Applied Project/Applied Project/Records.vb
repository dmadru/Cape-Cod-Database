Imports System.Data.OleDb

Public Class Records
    Private Sub Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles parkingBTN.Click
        RecordView.ClearSelection()
        Dim connection As New OleDbConnection("provider=SQLOLEDB;Data Source=DESKTOP-6HKFJ9O;Initial Catalog=Cape Cod;Integrated Security=SSPI")

        Dim table As New DataTable()
        Dim adapter As New OleDbDataAdapter("Select P.ParkingPermitID, U.FName, U.LName, U.address, p.plateInfo
                                      From parkingPermits P
                                      Join Users U
                                      On P.UserID = U.UserID;", connection)

        adapter.Fill(table)

        RecordView.DataSource = table

    End Sub

    Private Sub BoatregBTN_Click(sender As Object, e As EventArgs) Handles BoatregBTN.Click
        RecordView.ClearSelection()
        Dim connection As New OleDbConnection("provider=SQLOLEDB;Data Source=DESKTOP-6HKFJ9O;Initial Catalog=Cape Cod;Integrated Security=SSPI")

        Dim table As New DataTable()
        Dim adapter As New OleDbDataAdapter("Select B.RegistrationNumber, BoatID, U.FName, U.LName, U.address
                                      From BoatRegistrations B
                                      Join Users U
                                      On B.UserID = U.UserID;", connection)

        adapter.Fill(table)

        RecordView.DataSource = table
    End Sub

    Private Sub boatLicensesBTN_Click(sender As Object, e As EventArgs) Handles boatLicensesBTN.Click
        RecordView.ClearSelection()
        Dim connection As New OleDbConnection("provider=SQLOLEDB;Data Source=DESKTOP-6HKFJ9O;Initial Catalog=Cape Cod;Integrated Security=SSPI")

        Dim table As New DataTable()
        Dim adapter As New OleDbDataAdapter("Select B.BoatLicenseID, B.BoatID, U.UserID, B.BeachName, U.FName, U.LName, U.address 
                                      From BoatLicenses B
                                      Join Users U
                                      On B.UserID = U.UserID;", connection)

        adapter.Fill(table)

        RecordView.DataSource = table
    End Sub

    Private Sub boatinfoBTN_Click(sender As Object, e As EventArgs) Handles boatinfoBTN.Click
        RecordView.ClearSelection()
        Dim connection As New OleDbConnection("provider=SQLOLEDB;Data Source=DESKTOP-6HKFJ9O;Initial Catalog=Cape Cod;Integrated Security=SSPI")

        Dim table As New DataTable()
        Dim adapter As New OleDbDataAdapter("Select B.BoatID, B.Make, B.Model, B.Year, B.Color, U.FName, U.LName, U.address 
                                      From BoatInfo B
                                      Join BoatRegistrations R
                                      On R.BoatID = B.BoatID
                                      Join Users U
                                      On R.UserID = U.UserID;", connection)

        adapter.Fill(table)

        RecordView.DataSource = table
    End Sub

    Private Sub fishingBTN_Click(sender As Object, e As EventArgs) Handles fishingBTN.Click
        Dim connection As New OleDbConnection("provider=SQLOLEDB;Data Source=DESKTOP-6HKFJ9O;Initial Catalog=Cape Cod;Integrated Security=SSPI")

        Dim table As New DataTable()
        Dim adapter As New OleDbDataAdapter("Select F.FishingLicenseID, F.BeachName, U.FName, U.LName, U.address 
                                      From FishingLicenses F
                                      Join Users U
                                      On F.UserID = U.UserID;", connection)

        adapter.Fill(table)

        RecordView.DataSource = table
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles resBTN.Click
        RecordView.ClearSelection()
        Dim connection As New OleDbConnection("provider=SQLOLEDB;Data Source=DESKTOP-6HKFJ9O;Initial Catalog=Cape Cod;Integrated Security=SSPI")

        Dim table As New DataTable()
        Dim adapter As New OleDbDataAdapter("Select UserID, FName, LName, address, Phone
                                      From Users;", connection)

        adapter.Fill(table)

        RecordView.DataSource = table
    End Sub

    Private Sub menuBTN_Click(sender As Object, e As EventArgs) Handles menuBTN.Click
        Me.Hide()
        MainMenu.Show()
        databaseConnection.Close()
    End Sub
End Class