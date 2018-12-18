﻿using System;
using System.Collections;

namespace RecordCollection
{
    public class Track : IEnumerable, IComparable
    {
        public int Id { get; set; }
        public int BandId { get; set; }
        public int AlbumId { get; set; }
        public int PlayOrder { get; set; }
        public string Title { get; set; }
        public string Length { get; set; }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public int CompareTo(Object obj)
        {
            Track track = (Track)obj;
            return this.Title.CompareTo(track.Title);
        }

    }
}