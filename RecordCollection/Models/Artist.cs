using System;
using System.Text;
using System.Collections;

namespace RecordCollection
{
    class Artist : IEnumerable, IComparable
    {
        public int Id { get; set; }
        public DateTime DOB { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Fullname { get { return Forename + " " + Surname;} }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Forename);
            sb.Append(" ");
            sb.Append(this.Surname);
            sb.Append(" - ");
            sb.Append(this.DOB.ToShortDateString());
            return sb.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public int CompareTo(Object obj)
        {
            Artist artist = (Artist)obj;
            if (this.Surname != artist.Surname)
                return this.Forename.CompareTo(artist.Forename);
            else
                return this.Surname.CompareTo(artist.Surname);            
        }

    }
}
