Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Diagnostics

Namespace GridControlDescendant
	Public Class MyGridViewInfo
		Inherits GridViewInfo
		Public Sub New(ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
			MyBase.New(gridView)
		End Sub

		Protected Overrides Function GetRowMixAppearances(ByVal cellInfo As GridCellInfo, ByVal state As GridRowCellState, ByVal bi As GridRowInfo, ByVal column As DevExpress.Utils.AppearanceObjectEx, ByVal focusedCell As DevExpress.Utils.AppearanceObject, ByVal conditionCell As DevExpress.Utils.AppearanceObjectEx) As DevExpress.Utils.AppearanceObject()
			Dim apps() As DevExpress.Utils.AppearanceObject = MyBase.GetRowMixAppearances(cellInfo, state, bi, column, focusedCell, conditionCell)

			If (state And GridRowCellState.Selected) <> 0 Then
				apps.SetValue(PaintAppearance.SelectedRow, 0)
			End If

			Return apps
		End Function
	End Class
End Namespace
