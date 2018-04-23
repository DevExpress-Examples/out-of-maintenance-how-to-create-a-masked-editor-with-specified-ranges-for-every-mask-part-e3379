Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports System.Globalization
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Mask

Namespace RangedMaskSample
	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemMaskButtonEdit
		Inherits RepositoryItemButtonEdit
		Friend Const EditorName As String = "MaskButtonEdit"
		Private editMask_Renamed As String

		Shared Sub New()
			Register()
		End Sub

		Public Sub New()
		End Sub

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, _
                         GetType(MaskButtonEdit), GetType(RepositoryItemMaskButtonEdit), _
                         GetType(ButtonEditViewInfo), New ButtonEditPainter(), True))
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property

		Public ReadOnly Property MaskElements() As MaskElementCollection
			Get
				For Each aElement As MaskElement In MaskElementsRepository.MaskCollection
					If Me.OwnerEdit Is Nothing Then
						Continue For
					End If
					If aElement.EditCollection.Find(CType(Me.OwnerEdit, MaskButtonEdit)) Is Nothing Then
						aElement.EditCollection.Add(New EditElement(CType(Me.OwnerEdit, MaskButtonEdit), aElement.MinValue))
					End If
				Next aElement
				Return MaskElementsRepository.MaskCollection
			End Get
		End Property

		Public Overrides Function GetDisplayText(ByVal format As FormatInfo, ByVal editValue As Object) As String
			If TypeOf editValue Is DateTime Then
				Dim aWorkString As String = (CDate(editValue)).ToString(Mask.EditMask)
				For Each aElement As MaskElement In MaskElements
					If aWorkString.Contains(aElement.MaskSymbol) Then
						aWorkString = aWorkString.Replace(aElement.MaskSymbol, aElement.EditCollection.Find(CType(Me.OwnerEdit, MaskButtonEdit)).EditValue.ToString())
					End If
				Next aElement
				Return aWorkString
			End If

			If (editValue Is Nothing) OrElse (editValue.ToString() = String.Empty) Then
				Return String.Empty
			End If

			Return MyBase.GetDisplayText(format, editValue)
		End Function

		<Browsable(False)> _
		Public Overrides ReadOnly Property EditFormat() As FormatInfo
			Get
				Return MyBase.EditFormat
			End Get
		End Property
		<Browsable(False)> _
		Public Overrides ReadOnly Property DisplayFormat() As FormatInfo
			Get
				Return MyBase.DisplayFormat
			End Get
		End Property
		<Browsable(False)> _
		Public Overrides ReadOnly Property Mask() As MaskProperties
			Get
				Return MyBase.Mask
			End Get
		End Property
		<Browsable(True)> _
		Public Overridable Property EditMask() As String
			Get
				Return editMask_Renamed
			End Get
			Set(ByVal value As String)
				If editMask_Renamed = value Then
					Return
				End If
				editMask_Renamed = value
				UpdateFormats(False)
			End Set
		End Property

		Public Overridable Sub UpdateFormats(ByVal aHardUpdate As Boolean)
			If aHardUpdate Then
				EditFormat.FormatString = String.Empty
				DisplayFormat.FormatString = String.Empty
				Mask.EditMask = String.Empty
			End If
			EditFormat.FormatString = EditMask
			DisplayFormat.FormatString = EditMask
			Mask.MaskType = MaskType.DateTime
			Mask.EditMask = EditMask
		End Sub
	End Class
End Namespace