using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.Data.Mask;
using System.Globalization;

namespace RangedMaskSample
{

    public class MaskButtonEdit : ButtonEdit
    {
         static MaskButtonEdit()
        {             
            RepositoryItemMaskButtonEdit.Register();
        }
         public MaskButtonEdit()
        {
            MaskElementsRepository.MaskButtonEditList.Add(this);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
         public new RepositoryItemMaskButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemMaskButtonEdit; }
        }

        public override string EditorTypeName
        {
            get { return RepositoryItemMaskButtonEdit.EditorName; }
        }

        public void CallLayoutChanged()
        {
            this.LayoutChanged();
        }

        protected override MaskManager CreateMaskManager(MaskProperties mask)
        {
            MaskButtonEditMaskProperties patchedMask = new MaskButtonEditMaskProperties(this);
            patchedMask.Assign(mask);
            patchedMask.EditMask = Properties.Mask.EditMask;

            return patchedMask.CreatePatchedMaskManager();
        }
    }
}