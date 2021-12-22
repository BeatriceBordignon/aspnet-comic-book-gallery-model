﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel.Models
{
    public class ComicBook 
    {
        public ComicBook()
        {
            Artist = new List<Artist>();
        }
        public int Id { get; set; }
        public int SeriesId { get; set; } //foreign key
        public Series Series { get; set; } //navigation property
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public decimal? AverageRating { get; set; }

        public ICollection<Artist> Artist { get; set; }
        public string DisplayText
        {
            get
            {
                return $"{Series.Title} #{IssueNumber}";
            }
        }
    }
}
