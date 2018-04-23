using System;
using System.Collections;
using System.ComponentModel;

namespace RangedMaskSample
{
    public class MaskElementCollection : CollectionBase
    {        
        private void UpdateEditors()
        {
            foreach (MaskButtonEdit aEdit in MaskElementsRepository.MaskButtonEditList)
            {                
                aEdit.Properties.UpdateFormats(true);
            }
        }

        public override string ToString()
        {
            if (Count == 0) return "None";
            return string.Format("Count {0}", Count);
        }

        protected override void OnInsertComplete(int index, object value)
        {
            if ((((MaskElement)value).MaskSymbol != string.Empty))
                UpdateEditors();
        }

        protected override void OnRemoveComplete(int index, object value)
        {
            UpdateEditors();
        }

        protected override void OnSetComplete(int index, object oldValue, object newValue)
        {

        }

        public MaskElementCollection()
        {

        }
        public MaskElementCollection(int capacity)
            : base(capacity)
        {

        }

        public virtual void AddRange(MaskElement[] elements)
        {
            foreach (MaskElement element in elements)
            {
                List.Add(element);                
            }
        }

        public virtual int Add(MaskElement element)
        {
            int res = IndexOf(element);
            if (res == -1) res = List.Add(element);
            return res;            
        }

        public int IndexOf(MaskElement element)
        {
            return List.IndexOf(element);
        }

        public MaskElement this[int index]
        {
            get
            {
                return ((MaskElement)List[index]);
            }
            set
            {
                List[index] = value;
            }
        }

        public void Insert(int index, MaskElement value)
        {
            List.Insert(index, value);
        }

        public void Remove(MaskElement value)
        {
            List.Remove(value);
        }

        public bool Contains(MaskElement value)
        {
            return (List.Contains(value));
        }

        public MaskElement Find(string aMask)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].MaskSymbol == aMask)
                {
                    return this[i];
                }
            }
            return null;
        }
    }
}
