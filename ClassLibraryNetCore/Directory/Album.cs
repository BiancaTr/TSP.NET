using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    public class Album
    {

        public int AlbumId { get; set; }
        public ICollection<AlbumArtist> AlbumArtist { get; set; }
        public string AlbumName { get; set; }

        protected Album()
        {
        }
    }
}