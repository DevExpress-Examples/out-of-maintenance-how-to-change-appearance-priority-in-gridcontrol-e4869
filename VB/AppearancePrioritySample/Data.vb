Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace GridControlDescendant
	Public Class Data
		Public Shared Function CreateData(ByVal count As Integer) As List(Of Data)
			Dim l As New List(Of Data)()
			For i As Integer = 0 To count - 1
				l.Add(New Data With {.ID = i, .Value = "Value_" & i, .Value1 = count - i, .Value2 = "Value2_" & i})
			Next i
			Return l
		End Function
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateValue As String
		Public Property Value() As String
			Get
				Return privateValue
			End Get
			Set(ByVal value As String)
				privateValue = value
			End Set
		End Property
		Private privateValue1 As Integer
		Public Property Value1() As Integer
			Get
				Return privateValue1
			End Get
			Set(ByVal value As Integer)
				privateValue1 = value
			End Set
		End Property
		Private privateValue2 As String
		Public Property Value2() As String
			Get
				Return privateValue2
			End Get
			Set(ByVal value As String)
				privateValue2 = value
			End Set
		End Property
	End Class
End Namespace
