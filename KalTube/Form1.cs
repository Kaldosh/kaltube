using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.GData;
using Google.GData.Client;
using Google.GData.YouTube;
using Google.YouTube;

namespace KalTube
{
    /// <summary>
    /// originally created because the built-in subscriptions list on 10th november 2012 wouldn't go back far enough, AND had videos missing.
    /// 10/11/12
    /// (built in the week that followed; and worked on since)
    /// </summary>
    public partial class Form1 : Form
    {
        //feature ideas:
        /*
         * unsub
         * unadd
         * auto-add (&filter manual list) - with duration limits to auto
         * watch now
         * shuffle (lightly; in almost the same order, but not consecutive)
         * warn on adding long
        */


        /// <summary>
        /// if this is throwing errors; you need a settings.txt which contains a developer key. youtube can work without one, but quota/speed limits are lower. lookup the google api on getting your own developer key. (you just have to click a button, then copy the gibberish letters)
        /// </summary>
        string g_devkey = MySettings["devkey"];
        string g_userLookAt;
        string g_userLoginAs;

        string findString = null;
        eFindType findType;
        enum eFindType
        {
            ByTitle = 1
        }


        public static int maxImageCount = 1999;


        //for debugging
        public static object spare1;
        public static object spare2;

        public static string backupsPath = @"backups\";

        private static Dictionary<string, string> cachedSettings = null;
        public static Dictionary<string, string> MySettings
        {
            get
            {
                if (cachedSettings == null) cachedSettings = LoadSettings();
                return cachedSettings;
            }
        }

        protected static Dictionary<string, string> LoadSettings()
        {
            var ret = new Dictionary<string, string>();
            using (var sr = new System.IO.StreamReader("settings.txt"))
            {
                string thisLine;
                while ((thisLine = sr.ReadLine()) != null)
                {
                    var thisKey = thisLine.Substring(0, thisLine.IndexOf("="));
                    var thisVal = thisLine.Substring(thisLine.IndexOf("=") + 1);
                    ret.Add(thisKey, thisVal);
                }
            }
            return ret;
        }

        Google.YouTube.YouTubeRequestSettings g_settings = null;
        Google.YouTube.YouTubeRequest g_reqMakerSelf = null;

        Google.YouTube.Playlist g_Playlist { get; set; }
        /// <summary>
        /// it will only load this many per sub; so you can't go infinitely far back; but this optimizes loading times (it will only stop loading once it finds this many; it won't ignore vids it gets for free)
        /// </summary>
        protected int limit_vids = 25;
        protected int limit_subs = -1;


        /// <summary>lock object for adding subscriptions</summary>
        private object reqlock = new object();
        protected Queue<YTAction> actions = new Queue<YTAction>();
        //public struct YTAction { public Video QueueVideo;}
        public struct YTAction { public string VideoId; public KTVideo ktvid;}

        public System.Threading.Thread BGWorker = null;

        public int PendingCount = 0;
        public int TotalActions = 0;

        public DateTime SDate = new DateTime(2012, 11, 10);

        public bool OfflineMode = false;

        private int flashctr = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get list of subscriptions
            //for each subscription, get list of recent videos, within date range, piled into central list
            //sort central list by date
            //display thumbnail, title, description; tickbox
            //button for add all ticked items to watch later; and record to disk


            //query watched-ness?
            //query watch list to prevent duplicates?

            //get subs
            //get video feed
            //get thumbs
            //add to watch later (needs dev key; and probably user/password)

            //list has image, tickbox

            //button for get
            //button for add

        }

        private void btnGetVids_Click(object sender, EventArgs e)
        {
            DoBtnGetVids();
        }

        private void DoBtnGetVids()
        {
            EnableButtons(false);
            var cacheVids = GetVids();
            MessageBox.Show(string.Format("Saved {0} videos to cache.", cacheVids.Count));
            EnableButtons(true);
        }

        private List<KTVideo> GetVids()
        {
            var subslist = GetSubsList();

            var cacheVids = new List<KTVideo>();
            int ctr = 0;
            pbMain.Maximum = subslist.Count;
            pbMain.Value = 0;
            foreach (var sub in subslist)
            {
                pbMain.Value = ctr++;
                Application.DoEvents();
                var username = sub;
                var vids = g_reqMakerSelf.GetVideoFeed(username);
                vids.AutoPaging = true;
                //vids.Maximum = limit_vids;
                foreach (var vid in vids.Entries)
                {
                    var newVid = new KTVideo(vid);
                    cacheVids.Add(newVid);
                    if (newVid.Published < SDate)
                    {
                        vids.AutoPaging = false;
                        //gone back far enough. stop requesting more
                    }
                }
                pbMain.Value = ctr;
            }

            SaveVids(cacheVids);
            return cacheVids;
        }


        public void SaveVids(List<KTVideo> cacheVids)
        {
            var vidfile = new System.IO.FileInfo("vidcache-" + g_userLookAt + ".xml");
            if (!vidfile.Directory.Exists) vidfile.Directory.Create();
            var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<KTVideo>));
            using (var vidstream = vidfile.Create())
            {
                ser.Serialize(vidstream, cacheVids);
            }
            makeBackup(vidfile);
        }

        private static void makeBackup(System.IO.FileInfo pfile)
        {
            if (System.IO.Directory.Exists(backupsPath) == false) System.IO.Directory.CreateDirectory(backupsPath);
            pfile.CopyTo(backupsPath + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + pfile.Name);
        }

        public List<KTVideo> LoadVidCache()
        {
            var vidfile = new System.IO.FileInfo("vidcache-" + g_userLookAt + ".xml");
            if (!vidfile.Directory.Exists) vidfile.Directory.Create();
            var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<KTVideo>));
            using (var vidstream = vidfile.OpenText())
            {
                return (List<KTVideo>)ser.Deserialize(vidstream);
            }
        }


        private void ShowVids(List<KTVideo> cacheVids)
        {
            var wc = new System.Net.WebClient();

            pbMain.Maximum = cacheVids.Count;
            lstMain.Items.Clear();
            var lastUpdate = DateTime.UtcNow;

            foreach (var vid in cacheVids)
            {
                var instant = DateTime.UtcNow;
                if (instant.AddSeconds(-1) > lastUpdate)
                {
                    Application.DoEvents();
                    lastUpdate = instant;
                }
                pbMain.Value = lstMain.Items.Count;


                int imgidx = -1;
                imgidx = AddImg(wc, vid.ThumbUrl, vid.VideoId);

                var ago = (DateTime.Now - vid.Published).TotalDays;

                var durstring = vid.Duration.TotalHours < 1 ? vid.Duration.ToString("mm\\:ss") : vid.Duration.ToString("hh\\:mm\\:ss");
                string durwarn = "";
                if (vid.Duration.TotalMinutes < 3) durwarn = " - (s)";
                else if (vid.Duration.TotalMinutes > 12.8) durwarn = " - (l)";

                var subitms = new string[] { vid.Published.ToString("yyyy-MM-dd HH:mm:ss"), vid.Author + "\r\n" + durstring + durwarn + "\r\n" + vid.Title, vid.Description, string.Format("{0:yyyy-MM-dd}\r\n{0:HH:mm:ss}\r\n({1:0.0}d ago)", vid.Published, ago) };
                var newitm = new ListViewItem(subitms, imgidx);

                newitm.Tag = vid;
                lstMain.Items.Add(newitm);

            }

            pbMain.Value = 0;


        }



        private List<string> GetSubsList()
        {
            var subcache = new System.IO.FileInfo("subcache-" + g_userLookAt + ".txt");
            if (!subcache.Directory.Exists) subcache.Directory.Create();
            if (subcache.Exists && subcache.LastWriteTime.AddHours(1) > DateTime.Now && subcache.LastWriteTime <= DateTime.Now)
            {
                return GetCachedSubsList(subcache);
            }
            else
            {
                return GetFreshSubsList(subcache);
            }
        }

        private List<string> GetCachedSubsList(System.IO.FileInfo cachefile)
        {
            var subs = new List<string>();
            using (var sr = cachefile.OpenText())
            {
                string thisline;
                while ((thisline = sr.ReadLine()) != null)
                {
                    subs.Add(thisline);
                }

            }
            return subs;
        }

        private List<string> GetFreshSubsList(System.IO.FileInfo cachefile)
        {
            var reqsubs = g_reqMakerSelf.GetSubscriptionsFeed(g_userLookAt);
            reqsubs.AutoPaging = true;
            reqsubs.Maximum = limit_subs;
            var subslist = new List<string>();
            pbMain.Value = 0;
            pbMain.Maximum = reqsubs.TotalResults;
            Application.DoEvents();
            foreach (var itm in reqsubs.Entries)
            {
                subslist.Add(itm.UserName);
                pbMain.Value++;
                Application.DoEvents();
            }
            var oldsubs = new Dictionary<string, bool>();
            if (cachefile.Exists)
            {
                using (var sr = cachefile.OpenText())
                {
                    while (!sr.EndOfStream)
                        oldsubs.Add(sr.ReadLine(), false);
                }
            }
            using (var sw = cachefile.CreateText())
            {
                foreach (var itm in subslist)
                {
                    sw.WriteLine(itm);
                }
            }
            makeBackup(cachefile);
            var comparisonResult = compareSubList(oldsubs, subslist);
            if (!string.IsNullOrEmpty(comparisonResult))
            {
                var result = MessageBox.Show("Your subscriptions list has changed. Copy this to clipboard?\r\nWith the new list:\r\n" + comparisonResult, "Comparison differs - Sub list changed", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                    Clipboard.SetText(comparisonResult);
            }
            return subslist;
        }

        private string compareSubList(Dictionary<string, bool> oldsubs, List<string> subslist)
        {
            var missing = new List<string>();
            var extras = new List<string>();
            foreach (var itm in subslist)
            {
                if (oldsubs.ContainsKey(itm))
                {
                    oldsubs[itm] = true;
                }
                else
                {
                    extras.Add(itm);
                }
            }
            foreach (var itm in oldsubs)
            {
                if (itm.Value == false)
                    missing.Add(itm.Key);
            }

            var sb = new System.Text.StringBuilder();
            if (missing != null && missing.Count > 0)
            {
                foreach (var itm in missing)
                {
                    sb.AppendLine("Missing: " + itm);
                }
            }
            if (extras != null && extras.Count > 0)
            {
                foreach (var itm in extras)
                {
                    sb.AppendLine("Extra: " + itm);
                }
            }
            return sb.ToString();
        }

        private int AddImg(System.Net.WebClient wc, string thumburl, string videoId)
        {
            string ext = ".jpg";
            var dot = thumburl.LastIndexOf(".");
            if (dot >= 0) ext = thumburl.Substring(dot);
            var thumbname = "thumbcache/thumb-" + videoId + ext;
            var thumbfile = new System.IO.FileInfo(thumbname);
            if (!thumbfile.Directory.Exists) thumbfile.Directory.Create();
            if (!thumbfile.Exists)
                wc.DownloadFile(thumburl, thumbname);
            var bmp = new Bitmap(thumbname);
            lock (lstMain.SmallImageList)
            {
                lstMain.SmallImageList.Images.Add(bmp);
                return lstMain.SmallImageList.Images.Count - 1;
            }
        }

        /// <summary>
        /// may be done async. ensures the video will be added to the playlist; or throws if one is not yet selected
        /// </summary>
        private void QueueVideo(KTVideo vid)
        {
            if (g_Playlist == null) throw new ApplicationException("No playlist selected.");
            lock (actions)
            {
                Logger.RecordEnqueue(vid);
                actions.Enqueue(new YTAction() { VideoId = vid.VideoId, ktvid = vid });
                TotalActions++;
            }

            if (BGWorker == null)
            {
                BGWorker = new System.Threading.Thread(BGWork);
                BGWorker.IsBackground = true;
                BGWorker.Start();
            }


        }
        void BGWork()
        {

            while (true)
            {
                if (!OfflineMode)
                {
                    YTAction? itm;
                    int cnt = 0;
                    lock (actions)
                    {
                        if (actions.Count > 0)
                        {
                            itm = actions.Dequeue();
                            cnt = actions.Count;
                        }
                        else
                        {
                            itm = null;
                        }
                    }
                    if (itm != null)
                    {

                        //an item in the queue! add it (and immediately look for more)
                        try
                        {
                            lock (reqlock)
                            {
                                var plm = new Google.YouTube.PlayListMember();
                                plm.VideoId = itm.Value.VideoId;
                                var addedmem = g_reqMakerSelf.AddToPlaylist(g_Playlist, plm);
                                PendingCount = cnt;
                            }
                        }
                        catch (Exception ex)
                        {
                            var msg = "Unable to add to playlist with GDataRequestException.\r\n"
                                        + "Press Abort to switch to offline mode (and requeue)\r\n"
                                        + "Press Retry to put this back onto the add queue (and stay online)\r\n"
                                        + "Press Ignore to forget about adding this one\r\n"
                                        + "Error was: " + ex.GetType().ToString() + ":" + ex.Message + "\r\n";
                            if (ex is GDataRequestException) msg += "\r\n" + ((GDataRequestException)ex).ResponseString;
                            var result = MessageBox.Show(msg, "Error adding to playlist", MessageBoxButtons.AbortRetryIgnore);
                            switch (result)
                            {
                                case System.Windows.Forms.DialogResult.Abort:
                                    OfflineMode = true;
                                    QueueVideo(itm.Value.ktvid);
                                    break;
                                case System.Windows.Forms.DialogResult.Retry:
                                    QueueVideo(itm.Value.ktvid);
                                    break;
                                case System.Windows.Forms.DialogResult.Ignore:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        //queue is empty; give it a moment before looking for more
                        PendingCount = cnt;
                        System.Threading.Thread.Sleep(200);
                    }
                }
                else
                {
                    System.Threading.Thread.Sleep(200);
                }
                System.Threading.Thread.Sleep(500);
            }
        }

        void SetActions()
        {
            lock (actions)
            {
                lblActions.Text = string.Format("q:{0};p:{1};t:{2}", actions.Count, PendingCount, TotalActions);
            }
        }

        private void lstMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstMain_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lstMain.FocusedItem != null)
            {
                int idx0 = lstMain.FocusedItem.Index - 1;
                int idx1 = lstMain.FocusedItem.Index;
                if (idx0 < 0) idx0 = 0;

                lstMain.EnsureVisible(idx0);
                lstMain.EnsureVisible(idx1);

            }
        }

        private void lstMain_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (e.NewValue == CheckState.Checked)
                {
                    var vid = (KTVideo)lstMain.Items[e.Index].Tag;
                    var warnmsg = string.Format("Long video {0:hh\\:mm\\:ss}. Add anyway?", vid.Duration);
                    //this is 7.3 minutes to avoid fear of the 10:01 duration ... nobody cares about the 7:18 video
                    if (vid.Duration.TotalMinutes < 7.3
                        || MessageBox.Show(warnmsg, "Long Video", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.OK)
                    {
                        QueueVideo(vid);
                    }
                    else
                    {
                        e.NewValue = e.CurrentValue;
                    }
                }
                else
                {
                    //TODO: figure out how to remove an item from a playlist
                    throw new NotImplementedException("Removal not yet implemented");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ticking a video will add it to a playlist. Login and select a playlist first. Unable to add - Error message:" + ex.Message);
                e.NewValue = e.CurrentValue;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void ShowLogin()
        {
            var login = new frmLogin();
            var result = login.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                g_userLoginAs = g_userLookAt = login.Username;
                var pwd = login.Password;
                g_settings = new Google.YouTube.YouTubeRequestSettings("KalTube", g_devkey, g_userLoginAs, pwd);
                g_reqMakerSelf = new Google.YouTube.YouTubeRequest(g_settings);
                dtpStart.Value = DateTime.Today.AddMonths(-1);
            }
            else if (result == System.Windows.Forms.DialogResult.Ignore)
            {
                g_userLoginAs = null;
                g_userLookAt = login.Username;
                g_settings = new Google.YouTube.YouTubeRequestSettings("KalTube", g_devkey);
                g_reqMakerSelf = new Google.YouTube.YouTubeRequest(g_settings);
                dtpStart.Value = DateTime.Today.AddMonths(-1);

            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void ChoosePlaylist()
        {
            //HACK: assumes valid pre-reqs
            var plc = new frmPlaylist(g_userLookAt, g_reqMakerSelf);
            var result = plc.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK && plc.ChosenPlaylist != null)
            {
                g_Playlist = plc.ChosenPlaylist;
            }
        }

        private void btnChoosePlaylist_Click(object sender, EventArgs e)
        {
            ChoosePlaylist();
        }

        private void btnGetSubs_Click(object sender, EventArgs e)
        {
            DoBtnGetSubs();
        }

        private void DoBtnGetSubs()
        {
            EnableButtons(false);
            var sublist = GetSubs();
            MessageBox.Show(string.Format("Done. Cached {0} subscriptions.", sublist.Count));
            EnableButtons(true);
        }

        private List<string> GetSubs()
        {
            var subcache = new System.IO.FileInfo("subcache-" + g_userLookAt + ".txt");
            if (!subcache.Directory.Exists) subcache.Directory.Create();
            var sublist = GetFreshSubsList(subcache);
            return sublist;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetActions();
            lblPbMain.Text = pbMain.Value.ToString() + "/" + pbMain.Maximum.ToString();
            //only invoke the change if it's changed
            if (chkOffline.Checked != OfflineMode) chkOffline.Checked = OfflineMode;

        }

        private void btnShowvids_Click(object sender, EventArgs e)
        {
            DoBtnShowVids();
        }

        private void DoBtnShowVids()
        {
            EnableButtons(false);
            LoadFilterAndShowVids();
            EnableButtons(true);
        }

        private void LoadFilterAndShowVids()
        {
            var cacheVids = LoadVidCache();
            var trimCache = new List<KTVideo>();
            if (SDate == DateTime.MinValue) SDate = new DateTime(2013, 02, 23);//the day i was up to when i wrote this section.. I'll never need before that anyway.
            foreach (var itm in cacheVids)
            {
                if (itm.Published > SDate) trimCache.Add(itm);
            }

            //the imagelist breaks when adding the 3000th image; so limit to 2999 (showing only the oldest)
            var sIdx = trimCache.Count <= maxImageCount ? 0 : trimCache.Count - maxImageCount;
            var cnt = trimCache.Count <= maxImageCount ? trimCache.Count : maxImageCount;
            var trimCache2 = trimCache.OrderByDescending(x => x.Published).ToList().GetRange(sIdx, cnt);

            ShowVids(trimCache2);
        }

        private void EnableButtons(bool v)
        {
            mnuIndividualSteps.Enabled = v;
            //= btnAllInOne.Enabled = btnGetSubs.Enabled = btnGetVids.Enabled = btnShowvids.Enabled = btnChoosePlaylist.Enabled


        }


        private void calSDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            SDate = e.Start;
        }

        private void mnuOpenInBrowser_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstMain.SelectedItems.Count; i++)
            {
                var itm = lstMain.SelectedItems[i];
                var vid = (KTVideo)itm.Tag;
                var proc = System.Diagnostics.Process.Start(vid.WatchPage);
            }
        }

        private void openInFirefoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstMain.SelectedItems.Count; i++)
            {
                var itm = lstMain.SelectedItems[i];
                var vid = (KTVideo)itm.Tag;
                var proc = System.Diagnostics.Process.Start
                    (System.Environment.GetFolderPath
                    (Environment.SpecialFolder.ProgramFilesX86) + @"\Mozilla Firefox\firefox.exe"
                    , "\"" + vid.WatchPage + "\"");
            }
        }

        private void mnuAddToPlaylist_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstMain.SelectedItems.Count; i++)
            {
                var itm = lstMain.SelectedItems[i];
                if (!itm.Checked)
                {
                    itm.Checked = true;
                }
                else
                {
                    var vid = (KTVideo)lstMain.Items[itm.Index].Tag;
                    QueueVideo(vid);
                }
            }
        }

        private void mnuRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstMain.SelectedItems.Count; i++)
            {
                var itm = lstMain.SelectedItems[i];
                itm.Checked = false;
            }

        }

        private void btnAllInOne_Click(object sender, EventArgs e)
        {
            DoAllInOne();



        }

        private void DoAllInOne()
        {

            lblCurrent.Text = "Loading playlists list";
            Application.DoEvents();
            var plc = new frmPlaylist(g_userLoginAs, g_reqMakerSelf);
            plc.Show(this);
            while (plc.Loaded == false) { Application.DoEvents(); }

            lblCurrent.Text = "Getting subscriptions list";
            Application.DoEvents();
            GetSubs();

            lblCurrent.Text = "Getting videos list from subs";
            Application.DoEvents();
            GetVids();

            lblCurrent.Text = "Loading vid images";
            Application.DoEvents();
            LoadFilterAndShowVids();

            lblCurrent.Text = "Waiting for playlist selection";
            Application.DoEvents();
            while (plc.DialogResult == System.Windows.Forms.DialogResult.None) { Application.DoEvents(); }

            lblCurrent.Text = "Done";
            Application.DoEvents();


            if (plc.DialogResult == System.Windows.Forms.DialogResult.OK && plc.ChosenPlaylist != null)
            {
                g_Playlist = plc.ChosenPlaylist;
                MessageBox.Show("Done. Tick vids to add them to playlist."
                    + (lstMain.Items.Count >= maxImageCount
                    ?"\r\nList at maximum " + maxImageCount.ToString() + " videos. Showing only oldest. Select a closer end date, or get fewer subs. to see more recent videos"
                    :""));
            }
            else
            {
                MessageBox.Show("Vids loaded. You'll need to choose a playlist to be able to add them");
            }
        }

        private void btnAutoAdd_Click(object sender, EventArgs e)
        {
            //TODO: criteria for:
            //auto adding to playlist, like a BoxxyBabee video; (also have time range)
            //auto deleting from selections, like a 2 hour nasa video
            MessageBox.Show("TODO: criteria for:\r\nauto adding to playlist, like a BoxxyBabee video; (also have time range)\r\nauto deleting from selections, like a 2 hour nasa video; and points based on how often a video is uploaded; with add/ignore history contributing to customized feed");

            //try
            //{
            //    string inp = frmInputBox.InputBox("Scroll to date range:\r\n(dd/mm/yyyy)", "");
            //    DateTime when;
            //    if (!DateTime.TryParse(inp, out when))
            //    {
            //        throw new ApplicationException("Invalid date");
            //    }
            //    else
            //    {
            //        sDate = when;
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            SDate = dtpStart.Value;
        }

        private void chkOffline_CheckedChanged(object sender, EventArgs e)
        {
            OfflineMode = chkOffline.Checked;
        }



        private void btnReAddAll_Click(object sender, EventArgs e)
        {
            DoReAddAll();
        }

        private void DoReAddAll()
        {
            for (int i = lstMain.Items.Count - 1; i >= 0; i--)
            {
                var itm = lstMain.Items[i];
                if (itm.Checked)
                {
                    var vid = (KTVideo)itm.Tag;
                    QueueVideo(vid);
                }
            }
        }


        private void mnuGetSubs_Click(object sender, EventArgs e)
        {
            DoBtnGetSubs();
        }

        private void mnuGetVidsFromSubs_Click(object sender, EventArgs e)
        {
            DoBtnGetVids();
        }

        private void mnuShowVids_Click(object sender, EventArgs e)
        {
            DoBtnShowVids();
        }

        private void mnuChoosePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void mnuFindByTitle_Click(object sender, EventArgs e)
        {
            FindByTitle();
        }

        private void FindByTitle()
        {
            findType = eFindType.ByTitle;
            findString = frmInputBox.InputBox("Search Text", findString);
            FindNext();
        }

        private void mnuFindNext_Click(object sender, EventArgs e)
        {
            if (findString == null) FindByTitle();
            FindNext();
        }
        void FindNext()
        {
            if (lstMain.Items.Count == 0) return;
            int startIdx = 0;
            if (lstMain.FocusedItem != null) startIdx = lstMain.FocusedItem.Index;
            var numItms = lstMain.Items.Count;
            var foundidx = -1;
            //lstMain.FocusedItem = lstMain.FindItemWithText(findString, false, (lstMain.FocusedItem.Index + 1) % lstMain.Items.Count);

            for (int i = (startIdx + 1) % numItms; i != startIdx; i = (i + 1) % numItms)
            {
                var vid = (KTVideo)lstMain.Items[i].Tag;
                if (vid.Title.ToLowerInvariant().Contains(findString.ToLowerInvariant()))
                {
                    foundidx = i;
                    break;
                }
            }
            if (foundidx == -1)
                MessageBox.Show("Not found");
            else
            {
                lstMain.FocusedItem = lstMain.Items[foundidx];
                for (int i = 0; i < numItms; i++)
                {
                    lstMain.Items[i].Selected = (i == foundidx);
                }
                //lstMain.EnsureVisible(lstMain.FocusedItem.Index);
            }
        }

        private void choosePlaylistToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChoosePlaylist();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void allinoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoAllInOne();
        }

        private void showPlaylistInBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: also add this to right click on playlists list
            System.Diagnostics.Process.Start(g_Playlist.PlaylistsEntry.AlternateUri.ToString());
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: sort based on checked = desc; indeterminate = asc; unchecked = no sort, or on another field

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            DoAllInOne();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program will search all your (or someone else's) subscriptions, "
                + "and put all their videos onscreen to browse through.\r\n"
                + "First, set a date limit, then click start, choose a playlist, wait for it to all load, then tick boxes on whichever videos you want to add to the playlist; then you go watch the playlist on YouTube as normal.");
        }

        private void changeLookAtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = frmInputBox.InputBox("Enter the USERNAME (not the display name) of the user to look at - it should work if you go to youtube.com/user/xxxxxx\r\nnote: this won't change who you're logged in as, just who'se subscriptions you're pulling from. \r\nWARNING: this isn't tested", "xxxxxx");
            if (result != null && result != "") g_userLookAt = result;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
        }



    }
}
/*
todo: status bar ideas:
current playlist
current login, lookat
actions/progreess, etc (up top),
sort, find for, etc
other state
num subs
num vids so far
open in firefox button
TODO: right click vid to show thumbnail large, etc

*/