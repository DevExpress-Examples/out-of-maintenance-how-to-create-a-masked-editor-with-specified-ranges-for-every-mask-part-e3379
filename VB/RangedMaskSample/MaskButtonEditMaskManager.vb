Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.Mask
Imports System.Globalization

Namespace RangedMaskSample
	Friend Class MaskButtonEditMaskManager
		Inherits DateTimeMaskManager
		Public Sub New(ByVal mask As String, ByVal isOperatorMask As Boolean, ByVal culture As CultureInfo, ByVal allowNull As Boolean, ByVal aedit As MaskButtonEdit)
			MyBase.New(mask, isOperatorMask, culture, allowNull)
			fFormatInfo = New MaskButtonEditMaskFormatInfo(mask, Me.fInitialDateTimeFormatInfo, aedit)
		End Sub

		Public Overrides Sub SetInitialEditText(ByVal initialEditText As String)
			KillCurrentElementEditor()
			Dim initialEditValue As Nullable(Of DateTime) = Nothing

			If (Not String.IsNullOrEmpty(initialEditText)) Then
				Try
					initialEditValue = Convert.ToDateTime(initialEditText)
				Catch
					initialEditValue = DateTime.Now
				End Try
			End If

			SetInitialEditValue(initialEditValue)
		End Sub
	End Class
End Namespace
