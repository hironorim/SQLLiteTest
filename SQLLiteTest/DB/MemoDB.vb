Namespace SQLLiteTest

    Partial Public Class DB

        Public Function GetMemoByID(ByVal id As Object) As Memo
            Return GetByID(Of Memo)(id)
        End Function

        Public Function GetAllMemo() As List(Of Memo)
            Return GetAll(Of Memo)()
        End Function

        Public Sub InsertMemo(ByVal entity As Memo)
            Insert(Of Memo)(entity)
        End Sub

        Public Sub UpdateMemo(ByVal entity As Memo)
            Update(Of Memo)(entity)
        End Sub

        Public Sub DeleteMemo(ByVal entity As Memo)
            Delete(Of Memo)(entity)
        End Sub

        Public Sub DeleteAll()
            DeleteAll(Of Memo)()
        End Sub

        Public Sub CreateTable()
            Dim sql As String = "CREATE TABLE Memos(
                                   Id INTEGER PRIMARY KEY AUTOINCREMENT    NOT NULL,
                                   Title          TEXT    NOT NULL,
                                   Content        TEXT    NOT NULL
                                );"
            Execute(sql)
        End Sub

    End Class

End Namespace
