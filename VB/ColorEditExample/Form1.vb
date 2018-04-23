Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports System.Text.RegularExpressions

Namespace ColorEditExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim dt As DataTable = FillDataTable()
			gridControl1.DataSource = dt
			gridControl2.DataSource = dt
			gridView1.Columns("ColorString").Visible = False

			Dim unboundColumn As GridColumn = gridView1.Columns.AddField("Color")
			unboundColumn.VisibleIndex = gridView1.Columns.Count
			unboundColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object
			Dim ce As New RepositoryItemColorEdit()
			ce.ShowCustomColors = False
			unboundColumn.ColumnEdit = ce
		End Sub

		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			Dim view As GridView = TryCast(sender, GridView)
			Dim dv As DataView = TryCast(view.DataSource, DataView)
			If e.IsGetData Then
				e.Value = GetColorFromString(dv(e.ListSourceRowIndex)("ColorString").ToString())
			Else
				dv(e.ListSourceRowIndex)("ColorString") = (CType(e.Value, Color)).Name
			End If
		End Sub

		Private Function GetColorFromString(ByVal colorString As String) As Color
			Dim color As Color = Color.Empty
			Dim converter As New ColorConverter()
			Try
				color = CType(converter.ConvertFromString(colorString), Color)
			Catch
			End Try
			Return color
		End Function

		Private Function FillDataTable() As DataTable
			Dim _dataTable As New DataTable()
			Dim col As DataColumn
			Dim row As DataRow

			col = New DataColumn("ID", System.Type.GetType("System.Int32"))
			_dataTable.Columns.Add(col)
			col = New DataColumn("ColorString", System.Type.GetType("System.String"))
			_dataTable.Columns.Add(col)

			row = _dataTable.NewRow()
			row("ID") = "1"
			row("ColorString") = "Red"
			_dataTable.Rows.Add(row)
			row = _dataTable.NewRow()
			row("ID") = "2"
			row("ColorString") = "Green"
			_dataTable.Rows.Add(row)
			row = _dataTable.NewRow()
			row("ID") = "3"
			row("ColorString") = "Blue"
			_dataTable.Rows.Add(row)

			Return _dataTable
		End Function
	End Class
End Namespace
