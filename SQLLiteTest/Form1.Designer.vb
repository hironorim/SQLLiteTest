<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreateTable = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblContent = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.grdMemo = New System.Windows.Forms.DataGridView()
        Me.btnGetAll = New System.Windows.Forms.Button()
        CType(Me.grdMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateTable
        '
        Me.btnCreateTable.Location = New System.Drawing.Point(23, 26)
        Me.btnCreateTable.Name = "btnCreateTable"
        Me.btnCreateTable.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateTable.TabIndex = 0
        Me.btnCreateTable.Text = "テーブル作成"
        Me.btnCreateTable.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(23, 79)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTitle.Size = New System.Drawing.Size(40, 12)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "タイトル"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(69, 79)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(197, 19)
        Me.txtTitle.TabIndex = 2
        '
        'lblContent
        '
        Me.lblContent.AutoSize = True
        Me.lblContent.Location = New System.Drawing.Point(23, 118)
        Me.lblContent.Name = "lblContent"
        Me.lblContent.Size = New System.Drawing.Size(29, 12)
        Me.lblContent.TabIndex = 3
        Me.lblContent.Text = "内容"
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(69, 110)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(197, 139)
        Me.txtContent.TabIndex = 4
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(105, 25)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 5
        Me.btnInsert.Text = "挿入"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'grdMemo
        '
        Me.grdMemo.AllowUserToAddRows = False
        Me.grdMemo.AllowUserToDeleteRows = False
        Me.grdMemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMemo.Location = New System.Drawing.Point(13, 272)
        Me.grdMemo.Name = "grdMemo"
        Me.grdMemo.ReadOnly = True
        Me.grdMemo.RowTemplate.Height = 21
        Me.grdMemo.Size = New System.Drawing.Size(240, 150)
        Me.grdMemo.TabIndex = 6
        '
        'btnGetAll
        '
        Me.btnGetAll.Location = New System.Drawing.Point(187, 26)
        Me.btnGetAll.Name = "btnGetAll"
        Me.btnGetAll.Size = New System.Drawing.Size(75, 23)
        Me.btnGetAll.TabIndex = 7
        Me.btnGetAll.Text = "全取得"
        Me.btnGetAll.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 444)
        Me.Controls.Add(Me.btnGetAll)
        Me.Controls.Add(Me.grdMemo)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.lblContent)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCreateTable)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdMemo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateTable As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblContent As Label
    Friend WithEvents txtContent As TextBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents grdMemo As DataGridView
    Friend WithEvents btnGetAll As Button
End Class
