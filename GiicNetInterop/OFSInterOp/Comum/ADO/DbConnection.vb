Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Namespace ADO
    Public Class DbConnection

        'Private myAdapter As SqlDataAdapter
        'Private cnn1 As SqlConnection
        Private cnn1 As ADODB.Connection
        Private Servidor As String
        Private BD As String
        Private Username As String
        Private PassBD As String
        Private cnStr As String
        Public Sub New()
            'myAdapter = New SqlDataAdapter()
            cnn1 = New ADODB.Connection()
            Servidor = "SERVER\SQL2008DEV"
            BD = "DataGiicNet"
            Username = "sa"
            PassBD = "sa"
            CnStr = "Provider=SQLOLEDB;Data Source=" & Servidor & ";Initial Catalog=" & _
        BD & ";User ID=" & Username & ";Password=" & PassBD

            cnn1.ConnectionString = CnStr
            cnn1.Open()
            cnn1.Execute("SET DATEFORMAT DMY")
            cnn1.CommandTimeout = 360
            cnn1.Open()
        End Sub

        Public Function OpenConnection() As ADODB.Connection
            If (cnn1.State = ConnectionState.Closed Or cnn1.State = ConnectionState.Broken) Then
                cnn1.Open()
            End If
            Return cnn1
        End Function

        Public Function Execute(query As String) As Boolean

            Try
                cnn1.Execute(query)
                Return True
            Catch sqlError As Exception
                'Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: " + sqlError.StackTrace.ToString())
                'Throw sqlError
                Return False
            End Try
        End Function
    End Class

    End Namespace
