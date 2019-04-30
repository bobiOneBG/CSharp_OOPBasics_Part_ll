using System.Collections.Generic;

namespace _09_CollectionHierarchy
{
    public class MyList : ICollection, IMyList, IAdable, IRemoveable
    {       

        public MyList()
        {
            this.Collection = new List<string>();
        }

        public int Used => this.Collection.Count;

        public List<string> Collection { get; private set; }

        public int Add(string str)
        {
            this.Collection.Insert(0, str);

            return this.Collection.IndexOf(str);
        }

        public string Remove()
        {
            var str = this.Collection[this.Used-1];
            this.Collection.RemoveAt(this.Used- 1);
            
            return str;
        }
    }
}
