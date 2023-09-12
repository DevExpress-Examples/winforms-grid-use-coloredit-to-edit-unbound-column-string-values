Namespace ColorEditExample

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.repositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
            Me.repositoryItemColorEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPopupContainerEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemColorEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Location = New System.Drawing.Point(13, 13)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPopupContainerEdit1, Me.repositoryItemColorEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(259, 237)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            AddHandler Me.gridView1.CustomUnboundColumnData, New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(AddressOf Me.gridView1_CustomUnboundColumnData)
            ' 
            ' repositoryItemPopupContainerEdit1
            ' 
            Me.repositoryItemPopupContainerEdit1.AutoHeight = False
            Me.repositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1"
            ' 
            ' repositoryItemColorEdit1
            ' 
            Me.repositoryItemColorEdit1.AutoHeight = False
            Me.repositoryItemColorEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemColorEdit1.Name = "repositoryItemColorEdit1"
            ' 
            ' gridControl2
            ' 
            Me.gridControl2.Location = New System.Drawing.Point(279, 13)
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.Size = New System.Drawing.Size(264, 237)
            Me.gridControl2.TabIndex = 1
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            ' 
            ' gridView2
            ' 
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.Name = "gridView2"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(550, 262)
            Me.Controls.Add(Me.gridControl2)
            Me.Controls.Add(Me.gridControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPopupContainerEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemColorEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private repositoryItemColorEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit

        Private repositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit

        Private gridControl2 As DevExpress.XtraGrid.GridControl

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    End Class
End Namespace
