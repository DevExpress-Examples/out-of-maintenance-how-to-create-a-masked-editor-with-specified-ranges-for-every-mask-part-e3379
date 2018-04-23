Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.Data.Mask
Imports System.Globalization

Namespace RangedMaskSample
	Friend Class MaskButtonEditMaskProperties
		Inherits TimeEditMaskProperties
		Private ReadOnly aEdit As MaskButtonEdit

		Public Sub New(ByVal aedit As MaskButtonEdit)
			MyBase.New()
			Me.aEdit = aedit
		End Sub

		Public Overridable Function CreatePatchedMaskManager() As MaskManager
			Dim managerCultureInfo As CultureInfo = Me.Culture
			If managerCultureInfo Is Nothing Then
				managerCultureInfo = CultureInfo.CurrentCulture
			End If

			Dim editMask As String = Me.EditMask
			If editMask Is Nothing Then
				editMask = String.Empty
			End If

			Return New MaskButtonEditMaskManager(editMask, False, managerCultureInfo, True, aEdit)
		End Function
	End Class
End Namespace
