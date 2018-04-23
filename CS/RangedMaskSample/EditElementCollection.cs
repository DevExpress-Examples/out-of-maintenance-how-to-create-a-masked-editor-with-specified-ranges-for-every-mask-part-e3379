using System;
using System.Collections;

namespace RangedMaskSample
{
    public class EditElementCollection : CollectionBase
    {
        public EditElementCollection()
        {

        }
        public EditElementCollection(int capacity)
            : base(capacity)
        {

        }

        public virtual void AddRange(EditElement[] elements)
        {
            foreach (EditElement element in elements)
            {
                List.Add(element);
            }
        }

        public virtual int Add(EditElement element)
        {
            int res = IndexOf(element);
            if (res == -1) res = List.Add(element);
            return res;
        }

        public int IndexOf(EditElement element)
        {
            return List.IndexOf(element);
        }

        public EditElement this[int index]
        {
            get
            {
                return ((EditElement)List[index]);
            }
            set
            {
                List[index] = value;
            }
        }

        public void Insert(int index, EditElement value)
        {
            List.Insert(index, value);
        }

        public void Remove(MaskButtonEdit aEdit)
        {
            EditElement aElement = Find(aEdit);
            if (aElement != null)
                List.Remove(aElement);
        }

        public bool Contains(MaskButtonEdit aEdit)
        {
            return Find(aEdit) != null;
        }

        public EditElement Find(MaskButtonEdit aEdit)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].OwnerEdit == aEdit)
                {
                    return this[i];
                }
            }
            return null;
        }
    }
}
