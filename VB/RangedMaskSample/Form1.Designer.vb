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
			Me.timeSpanEdit1 = New DevExpress.XtraEditors.TimeSpanEdit()
			CType(Me.timeSpanEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' timeSpanEdit1
			' 
			Me.timeSpanEdit1.EditValue = System.TimeSpan.Parse("00:00:00")
			Me.timeSpanEdit1.Location = New System.Drawing.Point(51, 134)
			Me.timeSpanEdit1.Name = "timeSpanEdit1"
			Me.timeSpanEdit1.Properties.BeepOnError = False
			Me.timeSpanEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.timeSpanEdit1.Properties.MaskSettings.Set("mask", "hh1")
			Me.timeSpanEdit1.Properties.MaskSettings.Set("inputMode", DevExpress.Data.Mask.TimeSpanMaskInputMode.Restricted)
			Me.timeSpanEdit1.Properties.MaskSettings.Set("allowNegativeValues", False)
			Me.timeSpanEdit1.Properties.MaskSettings.Set("spinWithCarry", True)
			Me.timeSpanEdit1.Properties.MaskSettings.Set("useAdvancingCaret", True)
			Me.timeSpanEdit1.Properties.UseMaskAsDisplayFormat = True
			Me.timeSpanEdit1.Size = New System.Drawing.Size(230, 20)
			Me.timeSpanEdit1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(436, 334)
			Me.Controls.Add(Me.timeSpanEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.timeSpanEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private timeSpanEdit1 As DevExpress.XtraEditors.TimeSpanEdit
	End Class
End Namespace

