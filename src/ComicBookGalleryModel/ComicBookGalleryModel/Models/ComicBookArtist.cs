using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel.Models
{
    public class ComicBookArtist
    {
        public int Id { get; set; }
        public int ComicBookId { get; set; } //foreign key property to the ComicBook we're adding artist to

        public int ArtistId { get; set; } //foreign key property to the Artist that weìre adding to the ComicBook
        public int RoleId { get; set; } //foreign key property to the role that the artist had for this ComicBook
        
        //navigation properties
        public ComicBook ComicBook { get; set; }
        public Artist Artist { get; set; }
        public Role Role { get; set; }
    }
}
