Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq

Namespace GridControlDescendant
	<System.ComponentModel.DesignerCategory("")> _
	Public Class MyGridView
		Inherits DevExpress.XtraGrid.Views.Grid.GridView
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
			MyBase.New(grid)
			' put your initialization code here
		End Sub
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property


	End Class
End Namespace
