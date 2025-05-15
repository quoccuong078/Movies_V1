using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies_V1.Models
{
    public class Episode
    {
        public string Title { get; set; }
        public string ThumbnailUrl { get; set; }
        public string WatchUrl { get; set; }
        public int EpisodeNumber { get; set; }
        public string LinkEmbed { get; set; }
    }
}