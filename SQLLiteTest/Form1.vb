Imports SQLLiteTest.SQLLiteTest

Public Class Form1
    Private Sub btnCreateTable_Click(sender As Object, e As EventArgs) Handles btnCreateTable.Click
        Dim db As New DB()
        db.CreateTable()
    End Sub

    Private Sub btnGetAll_Click(sender As Object, e As EventArgs) Handles btnGetAll.Click
        Dim db As New DB()
        Dim memoList As List(Of Memo) = db.GetAllMemo()
        Me.grdMemo.DataSource = memoList
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim memo As New Memo()
        memo.Title = Me.txtTitle.Text
        memo.Content = Me.txtContent.Text

        Dim db As New DB()
        db.InsertMemo(memo)
    End Sub

End Class
