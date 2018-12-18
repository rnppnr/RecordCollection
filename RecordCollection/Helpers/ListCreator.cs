using System;
using System.Collections.Generic;

namespace RecordCollection.Helpers
{
    static class ListCreator
    {

        // These would really come from a database

        public static List<AlbumFormat> CreateFormats()
        {
            List<AlbumFormat> formatList = new List<AlbumFormat>() {
                new AlbumFormat() {Id=1, MediaFormat="CD" },
                new AlbumFormat() {Id=2, MediaFormat="Digital" },
                new AlbumFormat() {Id=3, MediaFormat="Vinyl" }
            };
            return formatList;
        }

        public static List<Band> CreateBands()
        {
            // There are way too many but ...
            List<Band> bands = new List<Band>{
                new Band() { Id=1, Name="The Beatles" },
                new Band() { Id=2, Name="Eric Clapton" },
                new Band() { Id=3, Name="Jimi Hendrix Experience" },
                new Band() { Id=5, Name="Pink Floyd" }
            };
            return bands;
        }

        public static List<Artist> CreateArtists()
        {            
            List<Artist> artistList = new List<Artist>() {
                new Artist() {Id=1,    Forename="Paul",    Surname="McCartney",    DOB=new DateTime(1942, 6,  18)},
                new Artist() {Id=2,    Forename="John",    Surname="Lennon",       DOB=new DateTime(1940, 10,  9)},
                new Artist() {Id=3,    Forename="George",  Surname="Harrison",     DOB=new DateTime(1943, 2,  25)},
                new Artist() {Id=4,    Forename="Ringo",   Surname="Starr",        DOB=new DateTime(1940, 7,   7)},
                new Artist() {Id=5,    Forename="Dave",    Surname="Gilmore",      DOB=new DateTime(1946, 3,   6)},
                new Artist() {Id=6,    Forename="Richard", Surname="Wright",       DOB=new DateTime(1943, 7,  28)},
                new Artist() {Id=7,    Forename="Roger",   Surname="Waters",       DOB=new DateTime(1943, 9,   5)},
                new Artist() {Id=8,    Forename="Nick",    Surname="Mason",        DOB=new DateTime(1944, 1,  27)},
                new Artist() {Id=9,    Forename="Jimi",    Surname="Hendrix",      DOB=new DateTime(1942, 11, 27)},
                new Artist() {Id=10,   Forename="Eric",    Surname="Clapton",      DOB=new DateTime(1945, 3,  30)}
            };
            return artistList;
        }

        public static List<BandMember> CreateBandMembers()
        {
            List<BandMember> bandMemberList = new List<BandMember>(){
                new BandMember() { Id=1, BandId=1, ArtistId=1 },
                new BandMember() { Id=2, BandId=1, ArtistId=2 },
                new BandMember() { Id=3, BandId=1, ArtistId=3 },
                new BandMember() { Id=4, BandId=1, ArtistId=4 },
                new BandMember() { Id=5, BandId=5, ArtistId=5 },
                new BandMember() { Id=6, BandId=5, ArtistId=6 },
                new BandMember() { Id=7, BandId=5, ArtistId=7 },
                new BandMember() { Id=8, BandId=5, ArtistId=8 }
            };
            return bandMemberList;
        }

        public static List<Album> CreateAlbums()
        {
            List<Album> albumList = new List<Album>() {
                //new Album() {Id=, ArtistId=, FormatId=, Title="", Genre="", ReleaseDate=new DateTime() }
                new Album() {Id=1, BandId=1, FormatId=1, Title="Please Please Me",    Genre="Pop",                ReleaseDate=new DateTime(1963, 3, 22) },
                new Album() {Id=2, BandId=3, FormatId=1, Title="Are You Experienced", Genre="Psychedelic Rock",   ReleaseDate=new DateTime(1967, 5, 12) },                
                new Album() {Id=3, BandId=2, FormatId=1, Title="461 Ocean Boulevard", Genre="Blues Rock",         ReleaseDate=new DateTime(1974, 7, 01) }
            };
            return albumList;
        }

        public static List<Track> CreateTracks()
        {
            List<Track> trackList = new List<Track>()
            {

                new Track() { Id=1,  BandId=1, AlbumId=1, PlayOrder=1,  Length="2:55", Title="I Saw Her Standing There",      },
                new Track() { Id=2,  BandId=1, AlbumId=1, PlayOrder=2,  Length="1:49", Title="Misery",                        },
                new Track() { Id=3,  BandId=1, AlbumId=1, PlayOrder=3,  Length="2:55", Title="Anna (Go To Him)",              },
                new Track() { Id=4,  BandId=1, AlbumId=1, PlayOrder=4,  Length="2:23", Title="Chains",                        },
                new Track() { Id=5,  BandId=1, AlbumId=1, PlayOrder=5,  Length="2:24", Title="Boys",                          },
                new Track() { Id=6,  BandId=1, AlbumId=1, PlayOrder=6,  Length="2:24", Title="Ask Me Why",                    },
                new Track() { Id=7,  BandId=1, AlbumId=1, PlayOrder=7,  Length="1:59", Title="Please Please Me",              },
                new Track() { Id=8,  BandId=1, AlbumId=1, PlayOrder=8,  Length="2:21", Title="Love Me Do",                    },
                new Track() { Id=9,  BandId=1, AlbumId=1, PlayOrder=9,  Length="2:04", Title="P.S. I Love You",               },
                new Track() { Id=10, BandId=1, AlbumId=1, PlayOrder=10, Length="2:40", Title="Baby It's You",                 },
                new Track() { Id=11, BandId=1, AlbumId=1, PlayOrder=11, Length="1:56", Title="Do You Want to Know a Secret",  },
                new Track() { Id=12, BandId=1, AlbumId=1, PlayOrder=12, Length="2:03", Title="A Taste of Honey",              },
                new Track() { Id=13, BandId=1, AlbumId=1, PlayOrder=13, Length="1:51", Title="There's a Place",               },
                new Track() { Id=14, BandId=1, AlbumId=1, PlayOrder=14, Length="2:32", Title="Twist and Shout",               },

                new Track() { Id=15, BandId=3, AlbumId=2, PlayOrder=1,  Length="3:22", Title="Foxy Lady",                     },
                new Track() { Id=16, BandId=3, AlbumId=2, PlayOrder=2,  Length="3:46", Title="Manic Depression",              },
                new Track() { Id=17, BandId=3, AlbumId=2, PlayOrder=3,  Length="3:44", Title="Red House",                     },
                new Track() { Id=18, BandId=3, AlbumId=2, PlayOrder=4,  Length="2:35", Title="Can You See Me",                },
                new Track() { Id=19, BandId=3, AlbumId=2, PlayOrder=5,  Length="3:17", Title="Love or Confusion",             },
                new Track() { Id=20, BandId=3, AlbumId=2, PlayOrder=6,  Length="3:58", Title="I Don't Live Today",            },
                new Track() { Id=21, BandId=3, AlbumId=2, PlayOrder=7,  Length="3:14", Title="May This Be Love",              },
                new Track() { Id=22, BandId=3, AlbumId=2, PlayOrder=8,  Length="2:47", Title="Fire",                          },
                new Track() { Id=23, BandId=3, AlbumId=2, PlayOrder=9,  Length="6:50", Title="Third Stone from the Sun",      },
                new Track() { Id=24, BandId=3, AlbumId=2, PlayOrder=10, Length="2:53", Title="Remember",                      },
                new Track() { Id=25, BandId=3, AlbumId=2, PlayOrder=11, Length="4:17", Title="Are You Experienced?",          },

                new Track() { Id=26, BandId=2, AlbumId=3, PlayOrder=1,  Length="4:55", Title="Motherless Children",           },
                new Track() { Id=27, BandId=2, AlbumId=3, PlayOrder=2,  Length="2:51", Title="Give Me Strength",              },
                new Track() { Id=28, BandId=2, AlbumId=3, PlayOrder=3,  Length="3:31", Title="Willie and the Hand Jive",      },
                new Track() { Id=29, BandId=2, AlbumId=3, PlayOrder=4,  Length="3:50", Title="Get Ready",                     },
                new Track() { Id=30, BandId=2, AlbumId=3, PlayOrder=5,  Length="4:30", Title="I Shot the Sheriff",            },
                new Track() { Id=31, BandId=2, AlbumId=3, PlayOrder=6,  Length="4:10", Title="I Can't Hold Out",              },
                new Track() { Id=32, BandId=2, AlbumId=3, PlayOrder=7,  Length="3:25", Title="Please Be with Me",             },
                new Track() { Id=33, BandId=2, AlbumId=3, PlayOrder=8,  Length="4:47", Title="Let It Grow",                   },
                new Track() { Id=34, BandId=2, AlbumId=3, PlayOrder=9,  Length="3:14", Title="Steady Rollin' Man",            },
                new Track() { Id=35, BandId=2, AlbumId=3, PlayOrder=10, Length="4:05", Title="Mainline Florida",              }

            };
            return trackList;
        }

    }
}
