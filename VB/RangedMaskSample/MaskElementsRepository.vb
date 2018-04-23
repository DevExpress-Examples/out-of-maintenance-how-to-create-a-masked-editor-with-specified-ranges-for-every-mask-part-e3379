Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Namespace RangedMaskSample
	Public NotInheritable Class MaskElementsRepository
		Private Shared aCollection As MaskElementCollection
		Private Shared aEditList As List(Of MaskButtonEdit)

		Private Sub New()
		End Sub
		Shared Sub New()
			aCollection = New MaskElementCollection()
			aEditList = New List(Of MaskButtonEdit)()
		End Sub

		Public Shared ReadOnly Property MaskCollection() As MaskElementCollection
			Get
				Return aCollection
			End Get
		End Property

		Public Shared ReadOnly Property MaskButtonEditList() As List(Of MaskButtonEdit)
			Get
				Return aEditList
			End Get
		End Property

		Public Shared Function Add(ByVal aElement As MaskElement) As Integer
			Return aCollection.Add(aElement)
		End Function
	End Class
End Namespace
