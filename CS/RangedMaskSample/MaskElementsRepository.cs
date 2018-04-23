using System;
using System.Collections.Generic;

namespace RangedMaskSample
{
    public static class MaskElementsRepository
    {
        private static MaskElementCollection aCollection;
        private static List<MaskButtonEdit> aEditList;

        static MaskElementsRepository()
        {
            aCollection = new MaskElementCollection();
            aEditList = new List<MaskButtonEdit>();
        }

        public static MaskElementCollection MaskCollection
        {
            get
            {
                return aCollection;
            }
        }

        public static List<MaskButtonEdit> MaskButtonEditList
        {
            get
            {
                return aEditList;
            }
        }

        public static int Add(MaskElement aElement)
        {
            return aCollection.Add(aElement);
        }
    }
}
