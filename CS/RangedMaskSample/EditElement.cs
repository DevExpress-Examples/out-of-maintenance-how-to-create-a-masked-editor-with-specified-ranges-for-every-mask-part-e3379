using System;

namespace RangedMaskSample
{
    public class EditElement
    {
        private MaskButtonEdit ownerEdit;
        private int editValue;

        public EditElement(MaskButtonEdit owneredit, int initialValue)
        {
            ownerEdit = owneredit;
            editValue = initialValue;
        }

        public int EditValue
        {
            get
            {
                return editValue;
            }
            set
            {
                if (editValue == value)
                    return;
                editValue = value;
            }
        }

        public MaskButtonEdit OwnerEdit
        {
            get
            {
                return ownerEdit;
            }
        }
    }
}
