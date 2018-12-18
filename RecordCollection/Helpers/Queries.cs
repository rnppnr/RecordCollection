using System;
using System.Linq;
using System.Text;
using RecordCollection;
using System.Collections.Generic;

namespace RecordCollection.Helpers
{
    static class Queries
    {

        public static void AllBands(List<Band> bandList)
        {
            Console.WriteLine();
            Console.WriteLine("Press return to see all bands");
            Console.ReadLine();

            // SELECT name FROM band ORDER BY name
            var bands = bandList.OrderBy(u => u.Name);
            foreach (var item in bands)
                Console.WriteLine(item.Name);

        }

        public static void AllArtists(List<Artist> artistList)
        {
            Console.WriteLine();
            Console.WriteLine("Press return to see all artists");
            Console.ReadLine();

            // SELECT * FROM artist ORDER BY surname
            var artists = artistList.OrderBy(u => u.Surname);
            foreach (var item in artists)
                //Console.WriteLine(item.Fullname + " born " + item.DOB.ToLongDateString());
                Console.WriteLine(item.ToString());

        }

        public static void AlbumsWithLetterE(List<Album> albumList)
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to see all albums that have the letter i|I");
            Console.ReadLine();

            // SELECT title FROM album WHERE title LIKE '%i%' OR title LIKE '%I%' ORDER BY title
            var albums = albumList.OrderBy(u => u.Title).Where(u => (u.Title.Contains("I") || u.Title.Contains("i")));
            foreach (var item in albums)
                Console.WriteLine(item.Title);

        }

        public static void ArtistsBornBetween(List<Artist> artistList)
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to see artists born between 1940 and 1945 ");
            Console.ReadLine();

            // SELECT dob, fullname FROM artist WHERE YEAR(birthday) >= 1940 AND YEAR(birthday) <= 1945 ORDER BY dob
            var artistsByAge = artistList.OrderBy(u => u.DOB).Where(u => u.DOB.Year >= 1940 && u.DOB.Year <= 1945);
            foreach (var item in artistsByAge)
                Console.WriteLine(item.DOB.ToLongDateString() + " - " + item.Fullname);
        }

        public static void AlbumsForArtist(List<Band> bandList, List<Album> albumList)
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to see all artists/bands and their albums");
            Console.ReadLine();

            // SELECT band.Name, album.Title FROM band JOIN album ON band.Id = album.BandId
            var results = bandList
                .Join
                (
                    albumList,
                    a => a.Id,
                    b => b.BandId,
                    ( a, b ) => new { a, b }
                );
            foreach (var item in results)
                Console.WriteLine(item.a.Name + " - " + item.b.Title);
        }

        public static void AllBandsAndTheirArtists(List<Band> bandList, List<BandMember> bandMemberList, List<Artist> artistList)
        {
            Console.WriteLine();
            Console.WriteLine("Press return to see all bands and their artists");
            Console.ReadLine();

            var bandArtistList = bandList
                .Join
                (
                    bandMemberList,
                    a => a.Id,
                    b => b.BandId,
                    (a, b) => new { a, b }
                )
                .Join
                (
                    artistList,
                    c => c.b.ArtistId,
                    d => d.Id,
                    (cb, d) => new { cb, d }
                )
                .Select(r => new
                {
                    BandName = r.cb.a.Name,
                    ArtistName = r.d.Fullname
                });

            foreach (var item in bandArtistList)
                Console.WriteLine(item.BandName + " - " + item.ArtistName);

        }

        public static void AllAlbumsAndTracks( List<Band> bandList, List<Album> albumList, List<Track> trackList, List<AlbumFormat> formatList  )
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to see all albums with their tracklisting");
            Console.ReadLine();

            var results = bandList
                .Join
                (
                    albumList,
                    a => a.Id,
                    b => b.BandId,
                    (a, b) => new { Band = a, Album = b }
                )
                .Join
                (
                    trackList,
                    c => c.Album.Id,
                    d => d.AlbumId,
                    (ab, d) => new { ArtistAlbum = ab, Track = d }
                )
                .Join
                (
                    formatList,
                    b => b.ArtistAlbum.Album.FormatId,
                    e => e.Id,
                    (aat, e) => new { ArtistAlbumTrack = aat, Format = e }
                )
                .Select(f => new
                {   
                    // Some of these could be simplified but for clarity ...
                    Format = f.Format.MediaFormat,
                    Name = f.ArtistAlbumTrack.ArtistAlbum.Band.Name,
                    Title = f.ArtistAlbumTrack.ArtistAlbum.Album.Title,
                    TrackNumber = f.ArtistAlbumTrack.Track.PlayOrder,
                    Track = f.ArtistAlbumTrack.Track.Title,
                    Length = f.ArtistAlbumTrack.Track.Length
                });


            foreach (var item in results)
            {
                Console.WriteLine
                    (
                        item.Format + " - " +
                        item.Name + " - " +
                        item.Title + " - " +
                        item.TrackNumber.ToString("00") + " - " +
                        item.Track + " - " +
                        item.Length
                    );
            }

        }

    }
}
