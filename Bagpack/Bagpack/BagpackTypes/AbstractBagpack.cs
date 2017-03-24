using System.Collections.Generic;

namespace Bagpack.BagpackTypes
{
    abstract class AbstractBagpack
    {
        public List<string> ItemList  { protected set; get; }

        public AbstractBagpack()
        {
            ItemList = new List<string>();
        }

        public abstract string AddItem(string Item);
        public abstract string RemoveItem(string Item);
    }
}