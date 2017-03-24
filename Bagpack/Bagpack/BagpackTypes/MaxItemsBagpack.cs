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
            if (itemList.Count < maxItemsNumber)
            {
                itemList.Add(Item);
                return ("Success");
            }
            else
            {
                return ("Your bagpack holds a maximum of " + maxItemsNumber + " items. You have reached the limit.");
            }
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
                return ("Item not found in your bagpack");
            }
        }
    }
}
