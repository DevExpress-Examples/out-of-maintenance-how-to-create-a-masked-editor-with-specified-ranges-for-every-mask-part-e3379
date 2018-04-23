Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel

Namespace RangedMaskSample
	Public Class MaskElementCollection
		Inherits CollectionBase
		Private Sub UpdateEditors()
			For Each aEdit As MaskButtonEdit In MaskElementsRepository.MaskButtonEditList
				aEdit.Properties.UpdateFormats(True)
			Next aEdit
		End Sub

		Public Overrides Function ToString() As String
			If Count = 0 Then
				Return "None"
			End If
			Return String.Format("Count {0}", Count)
		End Function

		Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
			If ((CType(value, MaskElement)).MaskSymbol <> String.Empty) Then
				UpdateEditors()
			End If
		End Sub

		Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
			UpdateEditors()
		End Sub

		Protected Overrides Sub OnSetComplete(ByVal index As Integer, ByVal oldValue As Object, ByVal newValue As Object)

		End Sub

		Public Sub New()

		End Sub
		Public Sub New(ByVal capacity As Integer)
			MyBase.New(capacity)

		End Sub

		Public Overridable Sub AddRange(ByVal elements() As MaskElement)
			For Each element As MaskElement In elements
				List.Add(element)
			Next element
		End Sub

		Public Overridable Function Add(ByVal element As MaskElement) As Integer
			Dim res As Integer = IndexOf(element)
			If res = -1 Then
				res = List.Add(element)
			End If
			Return res
		End Function

		Public Function IndexOf(ByVal element As MaskElement) As Integer
			Return List.IndexOf(element)
		End Function

		Default Public Property Item(ByVal index As Integer) As MaskElement
			Get
				Return (CType(List(index), MaskElement))
			End Get
			Set(ByVal value As MaskElement)
				List(index) = value
			End Set
		End Property

		Public Sub Insert(ByVal index As Integer, ByVal value As MaskElement)
			List.Insert(index, value)
		End Sub

		Public Sub Remove(ByVal value As MaskElement)
			List.Remove(value)
		End Sub

		Public Function Contains(ByVal value As MaskElement) As Boolean
			Return (List.Contains(value))
		End Function

		Public Function Find(ByVal aMask As String) As MaskElement
			For i As Integer = 0 To Count - 1
				If Me(i).MaskSymbol = aMask Then
					Return Me(i)
				End If
			Next i
			Return Nothing
		End Function
	End Class
End Namespace
