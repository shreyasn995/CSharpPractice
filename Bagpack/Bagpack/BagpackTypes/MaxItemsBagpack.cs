using System;

namespace Bagpack.BagpackTypes
{
    class MaxItemsBagpack : AbstractBagpack
    {
        private int maxItemsNumber = 5;

        public MaxItemsBagpack()
        {
            Console.WriteLine("Your bagpack holds a maximum of " + maxItemsNumber + " items. Press any key to continue: ");
            Console.ReadKey();
        }
        public override string AddItem(string Item)
        {
            if (ItemList.Count < maxItemsNumber)
            {
                ItemList.Add(Item);
                return ("Success");
            }
            else
            {
                return ("Your bagpack holds a maximum of " + maxItemsNumber + " items. You have reached the limit.");
            }
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
