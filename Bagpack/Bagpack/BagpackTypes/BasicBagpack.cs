using System;

namespace Bagpack.BagpackTypes
{
    class BasicBagpack : AbstractBagpack
    {
        public override string AddItem(string Item)
        {
            itemList.Add(Item);
            return ("Success");
        }

        public override string RemoveItem(string Item)
        {
            if (itemList.Contains(Item))
            {
                itemList.Remove(Item);
                return ("Success");
            }
            else
            {
                return ("Item ot found in your bagpack");
            }
        }
    }
}
