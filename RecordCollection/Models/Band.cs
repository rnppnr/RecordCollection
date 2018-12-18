using System;
using System.Collections;

namespace RecordCollection
{
    public class Band : IEnumerable, IComparable
    {
        public int Id { get; set;  }
        public string Name { get; set; }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public int CompareTo(Object obj)
        {
            Band band = (Band)obj;
            return this.Name.CompareTo(band.Name);
        }

    }

}
