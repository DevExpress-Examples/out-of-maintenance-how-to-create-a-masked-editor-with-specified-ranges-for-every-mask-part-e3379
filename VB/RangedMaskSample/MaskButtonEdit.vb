Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.Data.Mask
Imports System.Globalization

Namespace RangedMaskSample

	Public Class MaskButtonEdit
		Inherits ButtonEdit
		 Shared Sub New()
			RepositoryItemMaskButtonEdit.Register()
		 End Sub
		 Public Sub New()
			MaskElementsRepository.MaskButtonEditList.Add(Me)
		 End Sub

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMaskButtonEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMaskButtonEdit)
			End Get
		End Property

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMaskButtonEdit.EditorName
			End Get
		End Property

		Public Sub CallLayoutChanged()
			Me.LayoutChanged()
		End Sub

		Protected Overrides Function CreateMaskManager(ByVal mask As MaskProperties) As MaskManager
			Dim patchedMask As New MaskButtonEditMaskProperties(Me)
			patchedMask.Assign(mask)
			patchedMask.EditMask = Properties.Mask.EditMask

			Return patchedMask.CreatePatchedMaskManager()
		End Function
	End Class
End Namespace