Imports Microsoft.VisualBasic
Imports System

Namespace RangedMaskSample
	Public Class EditElement
		Private ownerEdit_Renamed As MaskButtonEdit
		Private editValue_Renamed As Integer

		Public Sub New(ByVal owneredit As MaskButtonEdit, ByVal initialValue As Integer)
			Me.ownerEdit_Renamed = owneredit
			editValue_Renamed = initialValue
		End Sub

		Public Property EditValue() As Integer
			Get
				Return editValue_Renamed
			End Get
			Set(ByVal value As Integer)
				If editValue_Renamed = value Then
					Return
				End If
				editValue_Renamed = value
			End Set
		End Property

		Public ReadOnly Property OwnerEdit() As MaskButtonEdit
			Get
				Return ownerEdit_Renamed
			End Get
		End Property
	End Class
End Namespace
