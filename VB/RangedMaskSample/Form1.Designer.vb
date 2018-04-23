Imports Microsoft.VisualBasic
Imports System
Namespace RangedMaskSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.repositoryItemMaskButtonEdit1 = New RangedMaskSample.RepositoryItemMaskButtonEdit()
			Me.maskButtonEdit2 = New RangedMaskSample.MaskButtonEdit()
			Me.maskButtonEdit1 = New RangedMaskSample.MaskButtonEdit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMaskButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.maskButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.maskButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Location = New System.Drawing.Point(13, 67)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.SelectedObject = Me.repositoryItemMaskButtonEdit1
			Me.propertyGridControl1.Size = New System.Drawing.Size(400, 255)
			Me.propertyGridControl1.TabIndex = 2
			' 
			' repositoryItemMaskButtonEdit1
			' 
			Me.repositoryItemMaskButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemMaskButtonEdit1.DisplayFormat.FormatString = "dd/mm/yyyy a1 b2 a4"
			Me.repositoryItemMaskButtonEdit1.EditFormat.FormatString = "dd/mm/yyyy a1 b2 a4"
			Me.repositoryItemMaskButtonEdit1.EditMask = "dd/mm/yyyy a1 b2 a4"
			Me.repositoryItemMaskButtonEdit1.Mask.EditMask = "dd/mm/yyyy a1 b2 a4"
			Me.repositoryItemMaskButtonEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
			Me.repositoryItemMaskButtonEdit1.Name = "repositoryItemMaskButtonEdit1"
			' 
			' maskButtonEdit2
			' 
			Me.maskButtonEdit2.EditValue = ""
			Me.maskButtonEdit2.Location = New System.Drawing.Point(13, 40)
			Me.maskButtonEdit2.Name = "maskButtonEdit2"
			Me.maskButtonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.maskButtonEdit2.Properties.DisplayFormat.FormatString = "b2 a1 c3"
			Me.maskButtonEdit2.Properties.EditFormat.FormatString = "b2 a1 c3"
			Me.maskButtonEdit2.Properties.EditMask = "b2 a1 c3"
			Me.maskButtonEdit2.Properties.Mask.EditMask = "b2 a1 c3"
			Me.maskButtonEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
			Me.maskButtonEdit2.Size = New System.Drawing.Size(254, 20)
			Me.maskButtonEdit2.TabIndex = 1
			' 
			' maskButtonEdit1
			' 
			Me.maskButtonEdit1.EditValue = ""
			Me.maskButtonEdit1.Location = New System.Drawing.Point(13, 13)
			Me.maskButtonEdit1.Name = "maskButtonEdit1"
			Me.maskButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.maskButtonEdit1.Properties.DisplayFormat.FormatString = "dd/mm/yyyy a1 b2 a4"
			Me.maskButtonEdit1.Properties.EditFormat.FormatString = "dd/mm/yyyy a1 b2 a4"
			Me.maskButtonEdit1.Properties.EditMask = "dd/mm/yyyy a1 b2 a4"
			Me.maskButtonEdit1.Properties.Mask.EditMask = "dd/mm/yyyy a1 b2 a4"
			Me.maskButtonEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
			Me.maskButtonEdit1.Size = New System.Drawing.Size(254, 20)
			Me.maskButtonEdit1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(436, 334)
			Me.Controls.Add(Me.propertyGridControl1)
			Me.Controls.Add(Me.maskButtonEdit2)
			Me.Controls.Add(Me.maskButtonEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMaskButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.maskButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.maskButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private maskButtonEdit1 As RangedMaskSample.MaskButtonEdit
		Private maskButtonEdit2 As RangedMaskSample.MaskButtonEdit
		Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private repositoryItemMaskButtonEdit1 As RangedMaskSample.RepositoryItemMaskButtonEdit
	End Class
End Namespace

