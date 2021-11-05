Imports System.Data.OleDb
Public Class Users
    Private Sub addUserBTN_Click(sender As Object, e As EventArgs) Handles addUserBTN.Click
        Dim maxUserID = 0
        Dim insertUser As String = ""

        Dim findMaxUserID As String =
            "Select MAX(UserID) as maxUserID from Users"

        databaseCommand.CommandText = findMaxUserID
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxUserID = CInt(results.Item("maxUserId")) + 1
        results.Close()

        insertUser = "insert into Users(UserID, Fname, Lname, Address, Phone" &
            " values( '" & maxUserID & "','" & fNameTB.Text & "','" & lNameTB.Text & "','" & addressTB.Text & "','" &
            phoneTB.Text & "')"

        databaseCommand.CommandText = insertUser

        Dim rowsModified As Integer = databaseCommand.ExecuteNonQuery

        If (rowsModified > 0) Then
            MsgBox("User added successfully")
        Else
            MsgBox("Failed adding user")
        End If


    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenDBConnection()

        Dim initialQuery As String = "Select Top(1) UserID, FName, LName, address, phone
                                      From Users; "

        databaseCommand.CommandText = initialQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        userIDTB1.Text = CStr(results.Item("UserID"))
        fnameTB1.Text = CStr(results.Item("FName"))
        lNameTB1.Text = CStr(results.Item("LName"))
        addressTB1.Text = CStr(results.Item("address"))
        phoneTB1.Text = CStr(results.Item("Phone"))

        results.Close()
    End Sub

    Private Sub menuBTN_Click(sender As Object, e As EventArgs) Handles menuBTN.Click
        Me.Hide()
        MainMenu.Show()
        databaseConnection.Close()
    End Sub

    Private Sub prevBTN_Click(sender As Object, e As EventArgs) Handles prevBTN.Click
        Dim UserID As Integer = CInt(userIDTB1.Text)

        Dim prevQuery As String = "Select UserID, FName, LName, address, phone" &
                                   " From Users Where UserID = " &
                                   UserID - 1

        If UserID <= 1 Then
            MsgBox("There are no more users to read")
            Exit Sub
        End If


        databaseCommand.CommandText = prevQuery

        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        userIDTB1.Text = CStr(results.Item("UserID"))
        fnameTB1.Text = CStr(results.Item("FName"))
        lnameTB1.Text = CStr(results.Item("LName"))
        addressTB1.Text = CStr(results.Item("address"))
        phoneTB1.Text = CStr(results.Item("Phone"))

        results.Close()
    End Sub

    Private Sub nextBTN_Click(sender As Object, e As EventArgs) Handles nextBTN.Click
        Dim UserID As Integer = CInt(userIDTB1.Text) + 1
        Dim maxUserID As Integer
        Dim findMaxUserID As String =
            "select MAX(UserID) as maxUserId From Users"

        databaseCommand.CommandText = findMaxUserID
        Dim results As OleDbDataReader = databaseCommand.ExecuteReader()

        results.Read()
        maxUserID = CInt(results.Item("maxUserId"))
        results.Close()

        If (UserID > maxUserID) Then
            MsgBox("There are no more users to read")
            Exit Sub
        End If

        Dim nextQuery As String = "Select UserID, FName, LName, address, phone" &
                                   " From Users Where UserID = " &
                                   UserID



        databaseCommand.CommandText = nextQuery

        results = databaseCommand.ExecuteReader()

        results.Read()
        userIDTB1.Text = CStr(results.Item("UserID"))
        fnameTB1.Text = CStr(results.Item("FName"))
        lnameTB1.Text = CStr(results.Item("LName"))
        addressTB1.Text = CStr(results.Item("address"))
        phoneTB1.Text = CStr(results.Item("Phone"))

        results.Close()
    End Sub
End Class