using System;
using RecordCollection.Helpers;
using System.Collections.Generic;

namespace RecordCollection
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Band> bandList = ListCreator.CreateBands();
            List<Artist> artistList = ListCreator.CreateArtists();
            List<BandMember> bandMemberList = ListCreator.CreateBandMembers();
            List<AlbumFormat> formatList = ListCreator.CreateFormats();
            List<Album> albumList = ListCreator.CreateAlbums();
            List<Track> trackList = ListCreator.CreateTracks();

            Queries.AllBands(bandList);
            Queries.AllArtists(artistList);
            Queries.AllBandsAndTheirArtists(bandList, bandMemberList, artistList);
            Queries.AlbumsForArtist(bandList, albumList);
            Queries.AlbumsWithLetterE(albumList);
            Queries.ArtistsBornBetween(artistList);
            Queries.AllAlbumsAndTracks(bandList, albumList, trackList, formatList);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
    }
}
