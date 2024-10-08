﻿Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates

Public Class ConexaoComOBancoDeDados
    Public Property ConnectionString As String
    Private connection As SqlConnection


    Public Sub ConectarComBanco(username As String, password As String)

        Dim serverName As String = "192.168.10.14"
        Dim databaseName As String = "MASERP_HML"

        ConnectionString = $"Server={serverName};Database={databaseName};User Id={username}; Password={password};"
        connection = New SqlConnection(ConnectionString)

        connection.Open()

    End Sub

    Public Function CriarConexao() As SqlConnection

        Return New SqlConnection(ConnectionString)

    End Function
    Public Function ObterUsuarioId(login As String) As Integer
        Dim query As String = "SELECT usu_usuario_IN FROM usuario_T WHERE usu_login_VC = @login"
        Using connection = CriarConexao()
            connection.Open()
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@login", login)
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function ExecutarSelect(commandType As CommandType,
                                   nomeStoredProcedureSql As String,
                                   parametros As List(Of SqlParameter)) As Object

        Try
            Using sqlConnection As SqlConnection = CriarConexao()
                sqlConnection.Open()

                Using sqlCommand As SqlCommand = sqlConnection.CreateCommand()

                    sqlCommand.CommandType = commandType
                    sqlCommand.CommandText = nomeStoredProcedureSql
                    sqlCommand.CommandTimeout = 5000


                    For Each sqlParameter As SqlParameter In parametros
                        sqlCommand.Parameters.Add(sqlParameter)
                    Next


                    Return sqlCommand.ExecuteScalar()

                End Using
            End Using

        Catch ex As Exception

            Throw New Exception("Erro ao exucutar a stored produre: " & ex.Message, ex)

        End Try

    End Function


    Public Function ExecutarConsulta(commandType As CommandType,
                                     nomeStoredProcedureSql As String,
                                     parametros As List(Of SqlParameter)) As DataTable

        Dim dataTable As New DataTable()

        Try
            Using sqlConnection As SqlConnection = CriarConexao()
                sqlConnection.Open()

                Using sqlCommand As SqlCommand = sqlConnection.CreateCommand()

                    sqlCommand.CommandType = commandType
                    sqlCommand.CommandText = nomeStoredProcedureSql
                    sqlCommand.CommandTimeout = 5000


                    For Each sqlParameter As SqlParameter In parametros

                        sqlCommand.Parameters.Add(sqlParameter)

                    Next

                    Using sqlDataAdapter As New SqlDataAdapter(sqlCommand)

                        sqlDataAdapter.Fill(dataTable)

                    End Using
                End Using
            End Using



        Catch ex As Exception

            Throw New Exception("Erro ao exucutar a stored produre: " & ex.Message, ex)

        End Try

        Return dataTable

    End Function
End Class