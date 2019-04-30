namespace _09_CollectionHierarchy
{
    using System.Collections.Generic;

    public class AddCollection : ICollection, IAdable
    {
        public AddCollection()
        {
            this.Collection = new List<string>();
        }

        public List<string> Collection { get; private set; }

        public int Add(string str)
        {
            this.Collection.Add(str);

            return this.Collection.IndexOf(str);
        }
    }
}
