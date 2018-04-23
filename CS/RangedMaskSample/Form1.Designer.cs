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
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.repositoryItemMaskButtonEdit1 = new RangedMaskSample.RepositoryItemMaskButtonEdit();
            this.maskButtonEdit2 = new RangedMaskSample.MaskButtonEdit();
            this.maskButtonEdit1 = new RangedMaskSample.MaskButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMaskButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskButtonEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskButtonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Location = new System.Drawing.Point(13, 67);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.SelectedObject = this.repositoryItemMaskButtonEdit1;
            this.propertyGridControl1.Size = new System.Drawing.Size(400, 255);
            this.propertyGridControl1.TabIndex = 2;
            // 
            // repositoryItemMaskButtonEdit1
            // 
            this.repositoryItemMaskButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemMaskButtonEdit1.DisplayFormat.FormatString = "dd/mm/yyyy a1 b2 a4";
            this.repositoryItemMaskButtonEdit1.EditFormat.FormatString = "dd/mm/yyyy a1 b2 a4";
            this.repositoryItemMaskButtonEdit1.EditMask = "dd/mm/yyyy a1 b2 a4";
            this.repositoryItemMaskButtonEdit1.Mask.EditMask = "dd/mm/yyyy a1 b2 a4";
            this.repositoryItemMaskButtonEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.repositoryItemMaskButtonEdit1.Name = "repositoryItemMaskButtonEdit1";
            // 
            // maskButtonEdit2
            // 
            this.maskButtonEdit2.EditValue = "";
            this.maskButtonEdit2.Location = new System.Drawing.Point(13, 40);
            this.maskButtonEdit2.Name = "maskButtonEdit2";
            this.maskButtonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.maskButtonEdit2.Properties.DisplayFormat.FormatString = "b2 a1 c3";
            this.maskButtonEdit2.Properties.EditFormat.FormatString = "b2 a1 c3";
            this.maskButtonEdit2.Properties.EditMask = "b2 a1 c3";
            this.maskButtonEdit2.Properties.Mask.EditMask = "b2 a1 c3";
            this.maskButtonEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.maskButtonEdit2.Size = new System.Drawing.Size(254, 20);
            this.maskButtonEdit2.TabIndex = 1;
            // 
            // maskButtonEdit1
            // 
            this.maskButtonEdit1.EditValue = "";
            this.maskButtonEdit1.Location = new System.Drawing.Point(13, 13);
            this.maskButtonEdit1.Name = "maskButtonEdit1";
            this.maskButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.maskButtonEdit1.Properties.DisplayFormat.FormatString = "dd/mm/yyyy a1 b2 a4";
            this.maskButtonEdit1.Properties.EditFormat.FormatString = "dd/mm/yyyy a1 b2 a4";
            this.maskButtonEdit1.Properties.EditMask = "dd/mm/yyyy a1 b2 a4";
            this.maskButtonEdit1.Properties.Mask.EditMask = "dd/mm/yyyy a1 b2 a4";
            this.maskButtonEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.maskButtonEdit1.Size = new System.Drawing.Size(254, 20);
            this.maskButtonEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 334);
            this.Controls.Add(this.propertyGridControl1);
            this.Controls.Add(this.maskButtonEdit2);
            this.Controls.Add(this.maskButtonEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMaskButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskButtonEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskButtonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RangedMaskSample.MaskButtonEdit maskButtonEdit1;
        private RangedMaskSample.MaskButtonEdit maskButtonEdit2;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private RangedMaskSample.RepositoryItemMaskButtonEdit repositoryItemMaskButtonEdit1;
    }
}

