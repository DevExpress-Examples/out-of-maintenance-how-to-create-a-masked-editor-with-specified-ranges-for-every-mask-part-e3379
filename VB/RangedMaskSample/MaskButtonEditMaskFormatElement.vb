Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.Mask
Imports System.Globalization

Namespace RangedMaskSample
	Friend Class MaskButtonEditMaskFormatElement
		Inherits DateTimeNumericRangeFormatElementEditable
		Private aIndex As Integer
		Private initvalue As Integer
		Private aEdit As MaskButtonEdit

		Public Sub New(ByVal mask As String, ByVal datetimeFormatInfo As DateTimeFormatInfo, ByVal PartNumber As Integer, ByVal aedit As MaskButtonEdit)
			MyBase.New(mask, datetimeFormatInfo, DateTimePart.Time)
			aIndex = PartNumber
			Me.aEdit = aedit
		End Sub

		Public Overrides Function CreateElementEditor(ByVal editedDateTime As DateTime) As DateTimeElementEditor
			Dim aElement As MaskElement = aEdit.Properties.MaskElements(aIndex)
			Dim editElement As EditElement = aElement.EditCollection.Find(aEdit)
			If editElement IsNot Nothing Then
				initvalue = editElement.EditValue
			Else
				initvalue = 0
			End If
			Return New DateTimeNumericRangeElementEditor(initvalue, aElement.MinValue, aElement.MaxValue, 1, Math.Max(aElement.MinValue.ToString().Length, aElement.MaxValue.ToString().Length))
		End Function

		Public Overrides Function ApplyElement(ByVal result As Integer, ByVal editedDateTime As DateTime) As DateTime
			Dim aElement As MaskElement = aEdit.Properties.MaskElements(aIndex)
			Dim editElement As EditElement = aElement.EditCollection.Find(aEdit)
			If editElement IsNot Nothing Then
				editElement.EditValue = result
			End If
			Return New DateTime(editedDateTime.Ticks + 1)
		End Function

		Public Overrides Function Format(ByVal formattedDateTime As DateTime) As String
			Dim aElement As MaskElement = aEdit.Properties.MaskElements(aIndex)
			Dim editElement As EditElement = aElement.EditCollection.Find(aEdit)
			If editElement IsNot Nothing Then
				Return editElement.EditValue.ToString()
			End If
			initvalue = 0
			Return initvalue.ToString()
		End Function
	End Class
End Namespace
