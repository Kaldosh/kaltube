using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KalTube
{
    class Logger
    {
        public static void Log(string message)
        {
            var logdir = new System.IO.DirectoryInfo(@"logs");
            if (!logdir.Exists) logdir.Create();
            System.IO.File.AppendAllText(string.Format(@"logs\KTLog{0:yyyy-MM-dd}.txt", DateTime.Now), string.Format("{0:yyyy-MM-dd HH:mm:ss} - {1}", DateTime.Now, message) + "\r\n");
        }
        public static void RecordEnqueue(KTVideo vid, Google.YouTube.Playlist playlist)
       {
            Log("enqueue:(" + vid.VideoId + ") " + vid.Author + " : " + vid.Title);

            System.IO.File.AppendAllText(string.Format(@"logs\Enqueues{0:yyyy-MM-dd}.txt", DateTime.Now)
                , string.Format("{0:yyyy-MM-dd HH:mm:ss} - Enqueue:VideoID=\"{1}\";WatchPage=\"{2}\";ThumbUrl=\"{3}\";Author=\"{4}\";Title=\"{5}\";Playlist=\"{6}\";Description=\"{7}\";\r\n\r\n"
                , DateTime.Now
                , vid.VideoId , vid.WatchPage, vid.ThumbUrl, vid.Author ,vid.Title, playlist.Title 
                , vid.Description));
        }
    }
}
