using System;
using DevExpress.XtraEditors.Mask;
using DevExpress.Data.Mask;
using System.Globalization;

namespace RangedMaskSample
{
    class MaskButtonEditMaskProperties : TimeEditMaskProperties
    {
        private readonly MaskButtonEdit aEdit;

        public MaskButtonEditMaskProperties(MaskButtonEdit aedit)
            : base()
        {
            aEdit = aedit;
        }

        public virtual MaskManager CreatePatchedMaskManager()
        {
            CultureInfo managerCultureInfo = this.Culture;
            if (managerCultureInfo == null)
                managerCultureInfo = CultureInfo.CurrentCulture;

            string editMask = this.EditMask;
            if (editMask == null)
                editMask = string.Empty;

            return new MaskButtonEditMaskManager(editMask, false, managerCultureInfo, true, aEdit);
        }
    }
}
