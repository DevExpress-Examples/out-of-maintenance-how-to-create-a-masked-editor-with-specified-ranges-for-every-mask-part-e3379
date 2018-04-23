Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports RangedMaskSample

Namespace RangedMaskSample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			MaskElementsRepository.MaskCollection.Add(New MaskElement("a1", 0, 10))
			MaskElementsRepository.MaskCollection.Add(New MaskElement("c3", 15, 125))
		End Sub
	End Class
End Namespace