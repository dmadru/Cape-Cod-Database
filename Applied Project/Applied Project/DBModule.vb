Imports System.Data.OleDb

Public Module DBModule

    Dim connectionString As String =
        "provider=SQLOLEDB;Data Source=DESKTOP-6HKFJ9O;Initial Catalog=Cape Cod;Integrated Security=SSPI"

    Public databaseConnection As OleDbConnection =
       New OleDbConnection(connectionString)
    Public databaseCommand As OleDbCommand = New OleDbCommand()


    Public Sub OpenDBConnection()

        Try
            databaseConnection.Open()
            databaseCommand.Connection = databaseConnection

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If (databaseConnection.State = ConnectionState.Open) Then
            MsgBox("Successfully Connected")
        End If

    End Sub

    Public Sub CloseDBConnection()
        Try
            databaseConnection.Close()
        Catch ex As Exception
            MsgBox("Error closing databse")
        End Try
    End Sub

End Module
