namespace RangedMaskSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeSpanEdit1 = new DevExpress.XtraEditors.TimeSpanEdit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // timeSpanEdit1
            // 
            this.timeSpanEdit1.EditValue = System.TimeSpan.Parse("00:00:00");
            this.timeSpanEdit1.Location = new System.Drawing.Point(51, 134);
            this.timeSpanEdit1.Name = "timeSpanEdit1";
            this.timeSpanEdit1.Properties.BeepOnError = false;
            this.timeSpanEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeSpanEdit1.Properties.MaskSettings.Set("mask", "hh1");
            this.timeSpanEdit1.Properties.MaskSettings.Set("inputMode", DevExpress.Data.Mask.TimeSpanMaskInputMode.Restricted);
            this.timeSpanEdit1.Properties.MaskSettings.Set("allowNegativeValues", false);
            this.timeSpanEdit1.Properties.MaskSettings.Set("spinWithCarry", true);
            this.timeSpanEdit1.Properties.MaskSettings.Set("useAdvancingCaret", true);
            this.timeSpanEdit1.Properties.UseMaskAsDisplayFormat = true;
            this.timeSpanEdit1.Size = new System.Drawing.Size(230, 20);
            this.timeSpanEdit1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 334);
            this.Controls.Add(this.timeSpanEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TimeSpanEdit timeSpanEdit1;
    }
}

