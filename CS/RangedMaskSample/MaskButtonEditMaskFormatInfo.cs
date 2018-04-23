using System;
using DevExpress.Data.Mask;
using System.Globalization;

namespace RangedMaskSample
{
    public class MaskButtonEditMaskFormatInfo : DateTimeMaskFormatInfo
    {
        public MaskButtonEditMaskFormatInfo(string mask, DateTimeFormatInfo dateTimeFormatInfo, MaskButtonEdit aedit)
            : base(mask, dateTimeFormatInfo)
        {
            for (int i = 0; i < Count; i++)
            {
                if ((innerList[i] is DateTimeMaskFormatElementLiteral) && (i < Count - 1) && (innerList[i + 1] is DateTimeMaskFormatElementLiteral))
                {
                    string aMaskSymbol = ((DateTimeMaskFormatElementLiteral)innerList[i]).Literal +
                        ((DateTimeMaskFormatElementLiteral)innerList[i + 1]).Literal;
                    MaskElement aElement = MaskElementsRepository.MaskCollection.Find(aMaskSymbol);
                    if (aElement != null)
                    {
                        innerList[i] = new MaskButtonEditMaskFormatElement(aMaskSymbol, dateTimeFormatInfo, aedit.Properties.MaskElements.IndexOf(aElement), aedit);
                        innerList.RemoveAt(i + 1);
                    }
                }
            }
        }
    }
}
