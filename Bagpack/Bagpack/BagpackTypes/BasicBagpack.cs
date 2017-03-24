using System;

namespace Bagpack.BagpackTypes
{
    class BasicBagpack : AbstractBagpack
    {
        public override string AddItem(string Item)
        {
            ItemList.Add(Item);
            return ("Success");
        }

        public override string RemoveItem(string Item)
        {
            if (ItemList.Contains(Item))
            {
                ItemList.Remove(Item);
                return ("Success");
            }
            else
            {
                return ("Item ot found in your bagpack");
            }
        }
    }
}
