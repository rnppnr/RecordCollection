using System;
using System.Collections;

namespace RecordCollection
{
    public class Band : IComparable
    {
        public int Id { get; set;  }
        public string Name { get; set; }

        public int CompareTo(Object obj)
        {
            Band band = (Band)obj;
            return this.Name.CompareTo(band.Name);
        }

    }

}
