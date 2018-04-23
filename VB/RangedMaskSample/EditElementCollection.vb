Imports Microsoft.VisualBasic
Imports System
Imports System.Collections

Namespace RangedMaskSample
	Public Class EditElementCollection
		Inherits CollectionBase
		Public Sub New()

		End Sub
		Public Sub New(ByVal capacity As Integer)
			MyBase.New(capacity)

		End Sub

		Public Overridable Sub AddRange(ByVal elements() As EditElement)
			For Each element As EditElement In elements
				List.Add(element)
			Next element
		End Sub

		Public Overridable Function Add(ByVal element As EditElement) As Integer
			Dim res As Integer = IndexOf(element)
			If res = -1 Then
				res = List.Add(element)
			End If
			Return res
		End Function

		Public Function IndexOf(ByVal element As EditElement) As Integer
			Return List.IndexOf(element)
		End Function

		Default Public Property Item(ByVal index As Integer) As EditElement
			Get
				Return (CType(List(index), EditElement))
			End Get
			Set(ByVal value As EditElement)
				List(index) = value
			End Set
		End Property

		Public Sub Insert(ByVal index As Integer, ByVal value As EditElement)
			List.Insert(index, value)
		End Sub

		Public Sub Remove(ByVal aEdit As MaskButtonEdit)
			Dim aElement As EditElement = Find(aEdit)
			If aElement IsNot Nothing Then
				List.Remove(aElement)
			End If
		End Sub

		Public Function Contains(ByVal aEdit As MaskButtonEdit) As Boolean
			Return Find(aEdit) IsNot Nothing
		End Function

		Public Function Find(ByVal aEdit As MaskButtonEdit) As EditElement
			For i As Integer = 0 To Count - 1
				If Me(i).OwnerEdit Is aEdit Then
					Return Me(i)
				End If
			Next i
			Return Nothing
		End Function
	End Class
End Namespace
