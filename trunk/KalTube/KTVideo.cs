using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KalTube
{
    [Serializable()]
    public class KTVideo
    {
        public string ThumbUrl { get; set; }
        public DateTime Published { get; set; }
        public float DurationSecs { get; set; }
        public TimeSpan Duration { get { return TimeSpan.FromSeconds(DurationSecs); } }
        public string Author { get; set; }
        public string Uploader { get; set; }
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string WatchPage { get; set; }

        public KTVideo() { }

        public KTVideo(Google.YouTube.Video vid)
        {
            var thumbs = vid.Thumbnails.ToDictionary(x => x.Attributes["name"]);
            ThumbUrl = thumbs["mqdefault"].Url;
            
            Published = vid.AtomEntry.Published;
            DurationSecs = float.Parse(vid.Media.Duration.Seconds);

            Author = vid.Author;
            Uploader = vid.Uploader;
            Title = vid.Title;
            Description = vid.Description;

            VideoId = vid.VideoId;

            WatchPage = vid.WatchPage.ToString();
        }
    }
}
