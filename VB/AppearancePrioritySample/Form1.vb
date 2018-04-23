Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.Drawing

Namespace GridControlDescendant
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			myGridView1.ShowFindPanel()
			myGridControl1.DataSource = Data.CreateData(10)

			Dim state As GridRowCellState = GridRowCellState.Even Or GridRowCellState.FocusedAndGridFocused
			Dim newState As GridRowCellState = state And GridRowCellState.FocusedCell
			newState = state And GridRowCellState.Even

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim condition1 As New StyleFormatCondition()
			condition1.Appearance.BackColor = Color.Navy
			condition1.Appearance.Options.UseBackColor = True
			condition1.Condition = FormatConditionEnum.Expression
			condition1.ApplyToRow = False
			condition1.Expression = "[Value1] > 2"
			condition1.Column = gridColumn3
			myGridView1.FormatConditions.Add(condition1)
		End Sub
	End Class
End Namespace
