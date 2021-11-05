Imports System.Data.OleDb
Public Class Boat_Info
    Private Sub Boat_Managment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OpenDBConnection()

        Dim initialQuery As String = "Select Top(1) BoatID, Make, Model, Year, Color
                                      From  BoatInfo; "

        databaseCommand.CommandText = initialQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        boatIDTB.Text = CStr(results.Item("BoatID"))
        makeTB.Text = CStr(results.Item("Make"))
        ModelTB.Text = CStr(results.Item("Model"))
        yearTB.Text = CStr(results.Item("Year"))
        colorTB.Text = CStr(results.Item("Color"))

        results.Close()
    End Sub

    Private Sub nextBTN_Click(sender As Object, e As EventArgs) Handles nextBTN.Click
        Dim nextBoatID As Integer = CInt(boatIDTB.Text) + 1
        Dim maxBoatID As Integer
        Dim findMaxBoatID As String =
            "select MAX(BoatID) as maxBoatID From BoatInfo"

        databaseCommand.CommandText = findMaxBoatID
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxBoatID = CInt(results.Item("maxBoatID"))
        results.Close()

        If (nextBoatID > maxBoatID) Then
            MsgBox("There is no more boat info to read")
            Exit Sub
        End If

        Dim nextQuery As String = "Select BoatID, Make, Model, Year, Color" &
                                   " From BoatInfo Where BoatID = " & nextBoatID




        databaseCommand.CommandText = nextQuery

        results = databaseCommand.ExecuteReader()

        results.Read()
        boatIDTB.Text = CStr(results.Item("BoatID"))
        makeTB.Text = CStr(results.Item("Make"))
        ModelTB.Text = CStr(results.Item("Model"))
        yearTB.Text = CStr(results.Item("Year"))
        colorTB.Text = CStr(results.Item("Color"))

        results.Close()
    End Sub

    Private Sub prevBTN_Click(sender As Object, e As EventArgs) Handles prevBTN.Click
        Dim boatID As Integer = CInt(boatIDTB.Text)

        Dim prevQuery As String = "Select BoatID,  Make, Model, Year, Color" &
                                   " From boatInfo Where boatID = " &
                                   boatID - 1

        If boatID <= 1 Then
            MsgBox("There is no more boat info to read")
            Exit Sub
        End If


        databaseCommand.CommandText = prevQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        boatIDTB.Text = CStr(results.Item("BoatID"))
        makeTB.Text = CStr(results.Item("Make"))
        ModelTB.Text = CStr(results.Item("Model"))
        yearTB.Text = CStr(results.Item("Year"))
        colorTB.Text = CStr(results.Item("Color"))

        results.Close()
    End Sub

    Private Sub addboatBTN_Click(sender As Object, e As EventArgs) Handles addboatBTN.Click
        Dim maxBoatId = 0
        Dim insertBoatInfo As String = ""

        Dim findMaxBoatId As String =
            "select MAX(boatID) as maxBoatID From boatInfo"

        databaseCommand.CommandText = findMaxBoatId
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxBoatId = CInt(results.Item("maxBoatID")) + 1
        results.Close()



        insertBoatInfo = "insert into boatInfo( BoatID, Make, Model, Year, Color)" &
            " values( '" & maxBoatId & "','" & makeTB2.Text + "','" & modelTB2.Text & "','" & yearTB2.Text & "','" &
            colorTB2.Text & "')"

        'MsgBox(insertBoatInfo)
        databaseCommand.CommandText = insertBoatInfo

        Dim rowsModified As Integer = databaseCommand.ExecuteNonQuery

        If (rowsModified > 0) Then
            MsgBox("Boat added successfully")
        Else
            MsgBox("Failed adding boat")
        End If
    End Sub

    Private Sub menuBTN_Click(sender As Object, e As EventArgs) Handles menuBTN.Click
        Me.Hide()
        MainMenu.Show()
        databaseConnection.Close()
    End Sub
End Class