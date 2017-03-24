using System;

namespace Bagpack.BagpackTypes
{
    class MaxWeightBagpack : AbstractBagpack
    {
        private int maxWeight = 25;
        private int currentWeight;

        public MaxWeightBagpack()
        {
            ItemListMessage();
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }

        public override string AddItem(string Item)
        {
            ItemWeights itemWeight;

            if (Enum.TryParse<ItemWeights>(Item, out itemWeight) && (currentWeight + (int) itemWeight) <= maxWeight)
            {
                itemList.Add(Item);
                currentWeight += (int) itemWeight;
                return ("Success");
            }
            else
            {
                Console.WriteLine("Invalid item, or bagpack too heavy.");
                ItemListMessage();
                return ("Current bagpack weight: " + currentWeight);
            }
        }

        public override string RemoveItem(string Item)
        {
            if (itemList.Contains(Item))
            {
                ItemWeights itemWeight;

                itemList.Remove(Item);
                Enum.TryParse<ItemWeights>(Item, out itemWeight);
                currentWeight -= (int) itemWeight;

                return ("Success");
            }
            else
            {
                return ("Item not found in your bagpack");
            }
        }

        private void ItemListMessage()
        {
            Console.WriteLine("Your bagpack holds a maximum weight of " + maxWeight + ". The items you can add and their corresponding weights are: ");
            foreach (ItemWeights item in Enum.GetValues(typeof(ItemWeights)))
            {
                Console.WriteLine(item + " weight " + (int) item);
            }
        }
    }
}
