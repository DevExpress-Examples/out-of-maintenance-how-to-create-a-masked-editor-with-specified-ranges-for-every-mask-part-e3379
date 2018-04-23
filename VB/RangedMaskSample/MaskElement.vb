Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections

Namespace RangedMaskSample
	Public Class MaskElement
		Private maskSymbol_Renamed As String
		Private minValue_Renamed As Integer
		Private maxValue_Renamed As Integer
		Private aEditCollection As EditElementCollection

		Public Sub New()
			maskSymbol_Renamed = String.Empty
			minValue_Renamed = 0
			maxValue_Renamed = 0
			aEditCollection = New EditElementCollection()
		End Sub

		Public Sub New(ByVal masksymbol As String, ByVal minvalue As Integer, ByVal maxvalue As Integer)
			Me.maskSymbol_Renamed = masksymbol
			Me.minValue_Renamed = minvalue
			Me.maxValue_Renamed = maxvalue
			aEditCollection = New EditElementCollection()
		End Sub

		Public Overrides Function ToString() As String
			Return String.Format("Element {0}", maskSymbol_Renamed)
		End Function

		Public Property MaskSymbol() As String
			Get
				Return maskSymbol_Renamed
			End Get
			Set(ByVal value As String)
				If maskSymbol_Renamed = value Then
					Return
				End If
				maskSymbol_Renamed = value
			End Set
		End Property

		Public Property MinValue() As Integer
			Get
				Return minValue_Renamed
			End Get
			Set(ByVal value As Integer)
				If minValue_Renamed = value Then
					Return
				End If
				minValue_Renamed = value
			End Set
		End Property

		Public Property MaxValue() As Integer
			Get
				Return maxValue_Renamed
			End Get
			Set(ByVal value As Integer)
				If maxValue_Renamed = value Then
					Return
				End If
				maxValue_Renamed = value
			End Set
		End Property

		<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
		Public ReadOnly Property EditCollection() As EditElementCollection
			Get
				Return aEditCollection
			End Get
		End Property
	End Class
End Namespace