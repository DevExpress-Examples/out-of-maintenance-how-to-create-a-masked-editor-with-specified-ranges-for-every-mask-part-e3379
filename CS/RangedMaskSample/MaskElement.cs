using System;
using System.ComponentModel;
using System.Collections;

namespace RangedMaskSample
{
    public class MaskElement
    {
        private string maskSymbol;
        private int minValue;
        private int maxValue;
        private EditElementCollection aEditCollection;

        public MaskElement()
        {
            maskSymbol = string.Empty;
            minValue = 0;
            maxValue = 0;
            aEditCollection = new EditElementCollection();
        }

        public MaskElement(string masksymbol, int minvalue, int maxvalue)
        {
            maskSymbol = masksymbol;
            minValue = minvalue;
            maxValue = maxvalue;
            aEditCollection = new EditElementCollection();
        }

        public override string ToString()
        {
            return string.Format("Element {0}", maskSymbol);
        }

        public string MaskSymbol
        {
            get
            {
                return maskSymbol;
            }
            set
            {
                if (maskSymbol == value)
                    return;
                maskSymbol = value;
            }
        }

        public int MinValue
        {
            get
            {
                return minValue;
            }
            set
            {
                if (minValue == value)
                    return;
                minValue = value;
            }
        }

        public int MaxValue
        {
            get
            {
                return maxValue;
            }
            set
            {
                if (maxValue == value)
                    return;
                maxValue = value;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public EditElementCollection EditCollection
        {
            get
            {
                return aEditCollection;
            }
        }
    }
}