using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KalTube
{
    public partial class frmPlaylist : Form
    {
        public string Username { get; protected set; }
        public Google.YouTube.YouTubeRequest ReqMaker { get; protected set; }

        public bool Loaded { get; protected set; }

        public frmPlaylist(string username, Google.YouTube.YouTubeRequest reqMaker)
        {
            //HACK: assumes valid pre-reqs
            InitializeComponent();
            Username = username;
            ReqMaker = reqMaker;
        }

        public Google.YouTube.Playlist ChosenPlaylist { get; protected set; }

        private void frmPlaylist_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("create new playlist?", "create?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                PromptAddNewPlaylist(false);
            }

            var gpf = ReqMaker.GetPlaylistsFeed(Username);
            gpf.AutoPaging = true;
            foreach (var pl in gpf.Entries)
            {
                
                var newitem = new ListViewItem(pl.Title);
                newitem.Tag = pl;
                lstPlaylists.Items.Add(newitem);
            }
            Loaded = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            UseSelection();
        }

        private void UseSelection()
        {
            if (lstPlaylists.SelectedIndex == -1 || ChosenPlaylist == null)
            {
                MessageBox.Show("please select a playlist");
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void lstPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlaylists.SelectedItem != null)
            {
                ChosenPlaylist = ((Google.YouTube.Playlist)((ListViewItem)lstPlaylists.SelectedItem).Tag);
            }
            else
            {
                ChosenPlaylist = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void lstPlaylists_DoubleClick(object sender, EventArgs e)
        {
            UseSelection();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            PromptAddNewPlaylist(true);
        }

        private void PromptAddNewPlaylist(bool fakeAddItem)
        {
            
            string defname = "";
            if ((this.Owner as Form1) != null)
            {
                var sdate = ((Form1)this.Owner).SDate;
                defname = string.Format("kt{0:yyyy-MM-dd} - KalTube", sdate);
            }
            var plname = frmInputBox.InputBox("New playlist name", defname);
            if (plname != null)
            {
                var pl = new Google.YouTube.Playlist();
                pl.Title = plname;
                pl.Summary = "Playlist created using KalTube on " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss K") + @" - See code.google.com/p/kaltube/";
                var createdPlaylist = ReqMaker.Insert(
                  new Uri("http://gdata.youtube.com/feeds/api/users/default/playlists"), pl);

                if (fakeAddItem)
                {
                    var newitem = new ListViewItem(pl.Title);
                    newitem.Tag = pl;
                    lstPlaylists.Items.Insert(0, newitem);
                    lstPlaylists.SelectedIndex = 0;
                    lstPlaylists_SelectedIndexChanged(null,null);
                    MessageBox.Show("TODO: this add/load/select doesn't really work; you may want to quit and reload the playlists list");
                }
            }
        }

    }
}
