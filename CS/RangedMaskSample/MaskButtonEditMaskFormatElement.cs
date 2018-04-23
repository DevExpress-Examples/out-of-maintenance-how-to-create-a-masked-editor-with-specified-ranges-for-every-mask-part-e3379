using System;
using DevExpress.Data.Mask;
using System.Globalization;

namespace RangedMaskSample
{
    class MaskButtonEditMaskFormatElement : DateTimeNumericRangeFormatElementEditable
    {
        private int aIndex;
        private int initvalue;
        private MaskButtonEdit aEdit;

        public MaskButtonEditMaskFormatElement(string mask, DateTimeFormatInfo datetimeFormatInfo, int PartNumber, MaskButtonEdit aedit)
            : base(mask, datetimeFormatInfo, DateTimePart.Time)
        {
            aIndex = PartNumber;
            aEdit = aedit;
        }

        public override DateTimeElementEditor CreateElementEditor(DateTime editedDateTime)
        {
            MaskElement aElement = aEdit.Properties.MaskElements[aIndex];
            EditElement editElement = aElement.EditCollection.Find(aEdit);
            if (editElement != null)
                initvalue = editElement.EditValue;
            else
                initvalue = 0;
            return new DateTimeNumericRangeElementEditor(initvalue, aElement.MinValue, aElement.MaxValue, 1, Math.Max(aElement.MinValue.ToString().Length, aElement.MaxValue.ToString().Length));
        }

        public override DateTime ApplyElement(int result, DateTime editedDateTime)
        {
            MaskElement aElement = aEdit.Properties.MaskElements[aIndex];
            EditElement editElement = aElement.EditCollection.Find(aEdit);
            if (editElement != null)
                editElement.EditValue = result;
            return new DateTime(editedDateTime.Ticks + 1);
        }

        public override string Format(DateTime formattedDateTime)
        {
            MaskElement aElement = aEdit.Properties.MaskElements[aIndex];
            EditElement editElement = aElement.EditCollection.Find(aEdit);
            if (editElement != null)
                return editElement.EditValue.ToString();
            initvalue = 0;
            return initvalue.ToString();
        }
    }
}
