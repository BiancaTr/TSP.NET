using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    public class Artist
    {

        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<AlbumArtist> AlbumArtists { get; set; }

        public Artist()
        {
        }
    }
}