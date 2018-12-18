using System;
using System.Text;
using System.Collections;

namespace RecordCollection
{
    public class Album : IEnumerable, IComparable
    {
        public int Id { get; set; }
        public int BandId { get; set; }
        public int FormatId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }        
        public DateTime ReleaseDate { get; set; }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public int CompareTo(Object obj)
        {
            Album album = (Album)obj;
            return this.Title.CompareTo(album.Title);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Id.ToString());
            sb.Append(",");
            sb.Append(Title);
            sb.Append(",");
            sb.Append(ReleaseDate);
            sb.Append(",");
            sb.Append(Genre);
            return sb.ToString();
        }
    }
}