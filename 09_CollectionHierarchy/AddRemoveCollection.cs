using System.Collections.Generic;

namespace _09_CollectionHierarchy
{
    public class AddRemoveCollection : ICollection, IAdable, IRemoveable
    {
        public AddRemoveCollection()
        {
            this.Collection = new List<string>();
        }

        public List<string> Collection { get; private set; }

        public int Add(string str)
        {
            this.Collection.Insert(0, str);

            return this.Collection.IndexOf(str);
        }

        public string Remove()
        {
            var str = this.Collection[0];
            this.Collection.RemoveAt(0);

            return str;
        }
    }
}
