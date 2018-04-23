using System;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using System.Globalization;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;

namespace RangedMaskSample
{
    [UserRepositoryItem("Register")]
    public class RepositoryItemMaskButtonEdit : RepositoryItemButtonEdit
    {
        internal const string EditorName = "MaskButtonEdit";
        private string editMask;

        static RepositoryItemMaskButtonEdit()
        {
            Register();
        }

        public RepositoryItemMaskButtonEdit()
        {                        
        }

        public static void Register()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MaskButtonEdit),
                typeof(RepositoryItemMaskButtonEdit), typeof(ButtonEditViewInfo),
                    new ButtonEditPainter(), true, null));
        }

        public override string EditorTypeName
        {
            get { return EditorName; }
        }

        public MaskElementCollection MaskElements
        {
            get
            {
                foreach (MaskElement aElement in MaskElementsRepository.MaskCollection)
                {
                    if (this.OwnerEdit == null)
                        continue;
                    if (aElement.EditCollection.Find((MaskButtonEdit)this.OwnerEdit) == null)
                        aElement.EditCollection.Add(new EditElement((MaskButtonEdit)this.OwnerEdit, aElement.MinValue));
                }
                return MaskElementsRepository.MaskCollection;
            }
        }

        public override string GetDisplayText(FormatInfo format, object editValue)
        {
            if (editValue is DateTime)
            {
                string aWorkString = ((DateTime)editValue).ToString(Mask.EditMask);
                foreach (MaskElement aElement in MaskElements)
                {
                    if (aWorkString.Contains(aElement.MaskSymbol))
                    {
                        aWorkString = aWorkString.Replace(aElement.MaskSymbol, aElement.EditCollection.Find((MaskButtonEdit)this.OwnerEdit).EditValue.ToString());
                    }
                }
                return aWorkString;
            }

            if ((editValue == null) || (editValue.ToString() == string.Empty))
                return string.Empty;

            return base.GetDisplayText(format, editValue);
        }

        [Browsable(false)]
        public override FormatInfo EditFormat
        {
            get
            {
                return base.EditFormat;
            }
        }
        [Browsable(false)]
        public override FormatInfo DisplayFormat
        {
            get
            {
                return base.DisplayFormat;
            }
        }
        [Browsable(false)]
        public override MaskProperties Mask
        {
            get
            {
                return base.Mask;
            }
        }
        [Browsable(true)]
        public virtual string EditMask
        {
            get
            {
                return editMask;
            }
            set
            {
                if (editMask == value)
                    return;
                editMask = value;
                UpdateFormats(false);
            }
        }

        public virtual void UpdateFormats(bool aHardUpdate)
        {
            if (aHardUpdate)
            {
                EditFormat.FormatString = string.Empty;
                DisplayFormat.FormatString = string.Empty;
                Mask.EditMask = string.Empty;            
            }
            EditFormat.FormatString = EditMask;
            DisplayFormat.FormatString = EditMask;
            Mask.MaskType = MaskType.DateTime;
            Mask.EditMask = EditMask;            
        }
    }
}