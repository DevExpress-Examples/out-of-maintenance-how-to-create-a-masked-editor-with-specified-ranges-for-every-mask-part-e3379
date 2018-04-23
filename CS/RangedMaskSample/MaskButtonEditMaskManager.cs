using System;
using DevExpress.Data.Mask;
using System.Globalization;

namespace RangedMaskSample
{
    class MaskButtonEditMaskManager : DateTimeMaskManagerCore
    {
        public MaskButtonEditMaskManager(string mask, bool isOperatorMask, CultureInfo culture, bool allowNull, MaskButtonEdit aedit)
            : base(mask, isOperatorMask, culture, allowNull)
        {
            fFormatInfo = new MaskButtonEditMaskFormatInfo(mask, this.fInitialDateTimeFormatInfo, aedit);
        }

        public override void SetInitialEditText(string initialEditText)
        {
            KillCurrentElementEditor();
            DateTime? initialEditValue = null;

            if (!string.IsNullOrEmpty(initialEditText))
                try
                {
                    initialEditValue = Convert.ToDateTime(initialEditText);
                }
                catch
                {
                    initialEditValue = DateTime.Now;
                }

            SetInitialEditValue(initialEditValue);
        }
    }
}
