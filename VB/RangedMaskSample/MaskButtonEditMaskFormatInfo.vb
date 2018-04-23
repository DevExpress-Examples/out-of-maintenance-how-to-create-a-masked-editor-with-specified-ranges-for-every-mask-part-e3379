Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Data.Mask
Imports System.Globalization

Namespace RangedMaskSample
	Public Class MaskButtonEditMaskFormatInfo
		Inherits DateTimeMaskFormatInfo
		Public Sub New(ByVal mask As String, ByVal dateTimeFormatInfo As DateTimeFormatInfo, ByVal aedit As MaskButtonEdit)
			MyBase.New(mask, dateTimeFormatInfo)
			For i As Integer = 0 To Count - 1
                If (i < Count - 1) AndAlso (TypeOf innerList(i) Is DateTimeMaskFormatElementLiteral) AndAlso (TypeOf innerList(i + 1) Is DateTimeMaskFormatElementLiteral) Then
                    Dim aMaskSymbol As String = (CType(innerList(i), DateTimeMaskFormatElementLiteral)).Literal + (CType(innerList(i + 1), DateTimeMaskFormatElementLiteral)).Literal
                    Dim aElement As MaskElement = MaskElementsRepository.MaskCollection.Find(aMaskSymbol)
                    If aElement IsNot Nothing Then
                        innerList(i) = New MaskButtonEditMaskFormatElement(aMaskSymbol, dateTimeFormatInfo, aedit.Properties.MaskElements.IndexOf(aElement), aedit)
                        innerList.RemoveAt(i + 1)
                    End If
                End If
			Next i
		End Sub
	End Class
End Namespace
