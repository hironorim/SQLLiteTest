Imports System.Data.SQLite
Imports Dapper
Imports Dapper.Contrib.Extensions

Namespace SQLLiteTest
    Public Class DB
        Private Function GetConnection() As IDbConnection
            Dim config As New SQLiteConnectionStringBuilder()
            config.DataSource = "db.db"
            Return New SQLiteConnection(config.ToString())
        End Function

        Private Function GetByQuery(Of T As Class)(ByVal sql As String) As List(Of T)
            Using connection As IDbConnection = GetConnection()
                connection.Open()
                Return connection.Query(Of T)(sql)
            End Using
        End Function

        Private Function GetByID(Of T As Class)(ByVal id As Object) As T
            Using connection As IDbConnection = GetConnection()
                connection.Open()
                Return connection.Get(Of T)(id)
            End Using
        End Function

        Private Function GetAll(Of T As Class)() As List(Of T)
            Using connection As IDbConnection = GetConnection()
                connection.Open()
                Return connection.GetAll(Of T)()
            End Using
        End Function

        Private Sub Insert(Of T As Class)(ByVal entity As T)
            Using connection As IDbConnection = GetConnection()
                connection.Open()
                connection.Insert(Of T)(entity)
            End Using
        End Sub

        Private Sub Update(Of T As Class)(ByVal entity As T)
            Using connection As IDbConnection = GetConnection()
                connection.Open()
                connection.Update(Of T)(entity)
            End Using
        End Sub

        Private Sub Delete(Of T As Class)(ByVal entity As T)
            Using connection As IDbConnection = GetConnection()
                connection.Open()
                connection.Delete(Of T)(entity)
            End Using
        End Sub

        Private Sub DeleteAll(Of T As Class)()
            Using connection As IDbConnection = GetConnection()
                connection.Open()
                connection.DeleteAll(Of T)()
            End Using
        End Sub

        Private Sub Execute(ByVal sql As String)
            Using connection As IDbConnection = GetConnection()
                connection.Open()
                connection.Query(sql)
            End Using
        End Sub

    End Class
End Namespace
