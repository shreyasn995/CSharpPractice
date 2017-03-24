using System.Collections.Generic;

namespace Bagpack.BagpackTypes
{
    abstract class AbstractBagpack
    {
        public List<string> itemList  { protected set; get; }

        public AbstractBagpack()
        {
            itemList = new List<string>();
        }

        public abstract string AddItem(string Item);
        public abstract string RemoveItem(string Item);

        public override string ToString()
        {
            string items = "";

            foreach (var item in itemList)
            {
                items += item.ToString() + "\n";
            }

            return items;
        }
    }
}