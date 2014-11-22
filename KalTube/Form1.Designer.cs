namespace KalTube
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstMain = new System.Windows.Forms.ListView();
            this.colImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuListMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddToPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOpenInBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.openInFirefoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAutoAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkOffline = new System.Windows.Forms.CheckBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.chkGoSlow = new System.Windows.Forms.CheckBox();
            this.mnuMain = new System.Windows.Forms.ToolStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allInOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIndividualSteps = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGetSubs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGetVidsFromSubs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowVids = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChoosePlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNowTickThemBelowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindByTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.automationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoaddBestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readdListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSlowlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLookAtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choosePlaylistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPlaylistInBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMain = new System.Windows.Forms.ToolStripProgressBar();
            this.lblActions = new System.Windows.Forms.ToolStripLabel();
            this.lblPbMain = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCurrent = new System.Windows.Forms.ToolStripLabel();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.showThumbnailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMain
            // 
            this.lstMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMain.CheckBoxes = true;
            this.lstMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colImage,
            this.colTitle,
            this.colDescription,
            this.colDate});
            this.lstMain.ContextMenuStrip = this.mnuListMain;
            this.lstMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMain.FullRowSelect = true;
            this.lstMain.LargeImageList = this.imageList1;
            this.lstMain.Location = new System.Drawing.Point(0, 54);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(808, 131);
            this.lstMain.SmallImageList = this.imageList1;
            this.lstMain.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstMain.TabIndex = 1000;
            this.lstMain.UseCompatibleStateImageBehavior = false;
            this.lstMain.View = System.Windows.Forms.View.Details;
            this.lstMain.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstMain_ItemCheck);
            this.lstMain.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstMain_ItemSelectionChanged);
            this.lstMain.SelectedIndexChanged += new System.EventHandler(this.lstMain_SelectedIndexChanged);
            // 
            // colImage
            // 
            this.colImage.Text = "Image";
            this.colImage.Width = 261;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Uploader&Title";
            this.colTitle.Width = 204;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 585;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 150;
            // 
            // mnuListMain
            // 
            this.mnuListMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddToPlaylist,
            this.toolStripSeparator1,
            this.mnuOpenInBrowser,
            this.openInFirefoxToolStripMenuItem,
            this.mnuRemove,
            this.showThumbnailToolStripMenuItem});
            this.mnuListMain.Name = "mnuListMain";
            this.mnuListMain.Size = new System.Drawing.Size(187, 142);
            this.mnuListMain.Opening += new System.ComponentModel.CancelEventHandler(this.mnuListMain_Opening);
            // 
            // mnuAddToPlaylist
            // 
            this.mnuAddToPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnuAddToPlaylist.Name = "mnuAddToPlaylist";
            this.mnuAddToPlaylist.Size = new System.Drawing.Size(186, 22);
            this.mnuAddToPlaylist.Text = "Add to playlist";
            this.mnuAddToPlaylist.Click += new System.EventHandler(this.mnuAddToPlaylist_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuOpenInBrowser
            // 
            this.mnuOpenInBrowser.Name = "mnuOpenInBrowser";
            this.mnuOpenInBrowser.Size = new System.Drawing.Size(186, 22);
            this.mnuOpenInBrowser.Text = "Open in browser";
            this.mnuOpenInBrowser.Click += new System.EventHandler(this.mnuOpenInBrowser_Click);
            // 
            // openInFirefoxToolStripMenuItem
            // 
            this.openInFirefoxToolStripMenuItem.Name = "openInFirefoxToolStripMenuItem";
            this.openInFirefoxToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openInFirefoxToolStripMenuItem.Text = "Open in Firefo&x";
            this.openInFirefoxToolStripMenuItem.Click += new System.EventHandler(this.openInFirefoxToolStripMenuItem_Click);
            // 
            // mnuRemove
            // 
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(186, 22);
            this.mnuRemove.Text = "Remove from playlist";
            this.mnuRemove.Click += new System.EventHandler(this.mnuRemove_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(256, 144);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAutoAdd
            // 
            this.btnAutoAdd.Location = new System.Drawing.Point(353, 26);
            this.btnAutoAdd.Name = "btnAutoAdd";
            this.btnAutoAdd.Size = new System.Drawing.Size(10, 25);
            this.btnAutoAdd.TabIndex = 1011;
            this.btnAutoAdd.Text = "AutoAdd";
            this.toolTip1.SetToolTip(this.btnAutoAdd, "Automatically add all videos according to rules; remove them (and bad rules) from" +
                    " this list; and scroll down to starting point");
            this.btnAutoAdd.UseVisualStyleBackColor = true;
            this.btnAutoAdd.Click += new System.EventHandler(this.btnAutoAdd_Click);
            // 
            // chkOffline
            // 
            this.chkOffline.AutoSize = true;
            this.chkOffline.Location = new System.Drawing.Point(0, 28);
            this.chkOffline.Name = "chkOffline";
            this.chkOffline.Size = new System.Drawing.Size(86, 17);
            this.chkOffline.TabIndex = 1013;
            this.chkOffline.Text = "Offline Mode";
            this.toolTip1.SetToolTip(this.chkOffline, "When checked, the videos are just stored in memory and not added to the playlist " +
                    "until unchecked");
            this.chkOffline.UseVisualStyleBackColor = true;
            this.chkOffline.CheckedChanged += new System.EventHandler(this.chkOffline_CheckedChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(147, 27);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 1012;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // chkGoSlow
            // 
            this.chkGoSlow.AutoSize = true;
            this.chkGoSlow.Location = new System.Drawing.Point(92, 28);
            this.chkGoSlow.Name = "chkGoSlow";
            this.chkGoSlow.Size = new System.Drawing.Size(49, 17);
            this.chkGoSlow.TabIndex = 1015;
            this.chkGoSlow.Text = "Slow";
            this.chkGoSlow.UseVisualStyleBackColor = true;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.pbMain,
            this.lblActions,
            this.lblPbMain,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.lblCurrent});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuMain.Size = new System.Drawing.Size(808, 25);
            this.mnuMain.TabIndex = 1019;
            this.mnuMain.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allInOneToolStripMenuItem,
            this.mnuIndividualSteps,
            this.toolStripMenuItem1,
            this.sortToolStripMenuItem,
            this.findToolStripMenuItem,
            this.automationToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // allInOneToolStripMenuItem
            // 
            this.allInOneToolStripMenuItem.Name = "allInOneToolStripMenuItem";
            this.allInOneToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.allInOneToolStripMenuItem.Text = "All-in-one";
            this.allInOneToolStripMenuItem.Click += new System.EventHandler(this.allinoneToolStripMenuItem_Click);
            // 
            // mnuIndividualSteps
            // 
            this.mnuIndividualSteps.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGetSubs,
            this.mnuGetVidsFromSubs,
            this.mnuShowVids,
            this.mnuChoosePlaylist,
            this.mnuNowTickThemBelowToolStripMenuItem});
            this.mnuIndividualSteps.Name = "mnuIndividualSteps";
            this.mnuIndividualSteps.Size = new System.Drawing.Size(156, 22);
            this.mnuIndividualSteps.Text = "Individual steps";
            // 
            // mnuGetSubs
            // 
            this.mnuGetSubs.Name = "mnuGetSubs";
            this.mnuGetSubs.Size = new System.Drawing.Size(233, 22);
            this.mnuGetSubs.Text = "&1. Get Subs List into cache";
            this.mnuGetSubs.Click += new System.EventHandler(this.mnuGetSubs_Click);
            // 
            // mnuGetVidsFromSubs
            // 
            this.mnuGetVidsFromSubs.Name = "mnuGetVidsFromSubs";
            this.mnuGetVidsFromSubs.Size = new System.Drawing.Size(233, 22);
            this.mnuGetVidsFromSubs.Text = "&2. Get Vids from cached subs";
            this.mnuGetVidsFromSubs.Click += new System.EventHandler(this.mnuGetVidsFromSubs_Click);
            // 
            // mnuShowVids
            // 
            this.mnuShowVids.Name = "mnuShowVids";
            this.mnuShowVids.Size = new System.Drawing.Size(233, 22);
            this.mnuShowVids.Text = "&3. Show Vids and load thumbs";
            this.mnuShowVids.Click += new System.EventHandler(this.mnuShowVids_Click);
            // 
            // mnuChoosePlaylist
            // 
            this.mnuChoosePlaylist.Name = "mnuChoosePlaylist";
            this.mnuChoosePlaylist.Size = new System.Drawing.Size(233, 22);
            this.mnuChoosePlaylist.Text = "&4. Choose Playlist to add to";
            this.mnuChoosePlaylist.Click += new System.EventHandler(this.mnuChoosePlaylist_Click);
            // 
            // mnuNowTickThemBelowToolStripMenuItem
            // 
            this.mnuNowTickThemBelowToolStripMenuItem.Enabled = false;
            this.mnuNowTickThemBelowToolStripMenuItem.Name = "mnuNowTickThemBelowToolStripMenuItem";
            this.mnuNowTickThemBelowToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.mnuNowTickThemBelowToolStripMenuItem.Text = "&5. Now go tick them below";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.Enabled = false;
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dateToolStripMenuItem.Text = "Date Published";
            this.dateToolStripMenuItem.Click += new System.EventHandler(this.dateToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindByTitle,
            this.mnuFindNext});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // mnuFindByTitle
            // 
            this.mnuFindByTitle.Name = "mnuFindByTitle";
            this.mnuFindByTitle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFindByTitle.Size = new System.Drawing.Size(179, 22);
            this.mnuFindByTitle.Text = "Find By &Title";
            this.mnuFindByTitle.Click += new System.EventHandler(this.mnuFindByTitle_Click);
            // 
            // mnuFindNext
            // 
            this.mnuFindNext.Name = "mnuFindNext";
            this.mnuFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuFindNext.Size = new System.Drawing.Size(179, 22);
            this.mnuFindNext.Text = "Find Next";
            this.mnuFindNext.Click += new System.EventHandler(this.mnuFindNext_Click);
            // 
            // automationToolStripMenuItem
            // 
            this.automationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoaddBestToolStripMenuItem,
            this.readdListToolStripMenuItem});
            this.automationToolStripMenuItem.Name = "automationToolStripMenuItem";
            this.automationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.automationToolStripMenuItem.Text = "Automation";
            // 
            // autoaddBestToolStripMenuItem
            // 
            this.autoaddBestToolStripMenuItem.Enabled = false;
            this.autoaddBestToolStripMenuItem.Name = "autoaddBestToolStripMenuItem";
            this.autoaddBestToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.autoaddBestToolStripMenuItem.Text = "Auto-add best";
            // 
            // readdListToolStripMenuItem
            // 
            this.readdListToolStripMenuItem.Name = "readdListToolStripMenuItem";
            this.readdListToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.readdListToolStripMenuItem.Text = "Re-add checked items to playlist";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateLimitToolStripMenuItem,
            this.addSlowlyToolStripMenuItem,
            this.offlineModeToolStripMenuItem,
            this.changeLookAtToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // dateLimitToolStripMenuItem
            // 
            this.dateLimitToolStripMenuItem.Name = "dateLimitToolStripMenuItem";
            this.dateLimitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dateLimitToolStripMenuItem.Text = "Date limit...";
            // 
            // addSlowlyToolStripMenuItem
            // 
            this.addSlowlyToolStripMenuItem.Enabled = false;
            this.addSlowlyToolStripMenuItem.Name = "addSlowlyToolStripMenuItem";
            this.addSlowlyToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addSlowlyToolStripMenuItem.Text = "Add slowly ";
            // 
            // offlineModeToolStripMenuItem
            // 
            this.offlineModeToolStripMenuItem.Name = "offlineModeToolStripMenuItem";
            this.offlineModeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.offlineModeToolStripMenuItem.Text = "Offline Mode";
            // 
            // changeLookAtToolStripMenuItem
            // 
            this.changeLookAtToolStripMenuItem.Name = "changeLookAtToolStripMenuItem";
            this.changeLookAtToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.changeLookAtToolStripMenuItem.Text = "Change look at...";
            this.changeLookAtToolStripMenuItem.Click += new System.EventHandler(this.changeLookAtToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choosePlaylistToolStripMenuItem1,
            this.loginToolStripMenuItem,
            this.showPlaylistInBrowserToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // choosePlaylistToolStripMenuItem1
            // 
            this.choosePlaylistToolStripMenuItem1.Name = "choosePlaylistToolStripMenuItem1";
            this.choosePlaylistToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.choosePlaylistToolStripMenuItem1.Text = "Choose Playlist";
            this.choosePlaylistToolStripMenuItem1.Click += new System.EventHandler(this.choosePlaylistToolStripMenuItem1_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.loginToolStripMenuItem.Text = "Login / Change user";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // showPlaylistInBrowserToolStripMenuItem
            // 
            this.showPlaylistInBrowserToolStripMenuItem.Name = "showPlaylistInBrowserToolStripMenuItem";
            this.showPlaylistInBrowserToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.showPlaylistInBrowserToolStripMenuItem.Text = "Show playlist in browser";
            this.showPlaylistInBrowserToolStripMenuItem.Click += new System.EventHandler(this.showPlaylistInBrowserToolStripMenuItem_Click);
            // 
            // pbMain
            // 
            this.pbMain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(75, 22);
            // 
            // lblActions
            // 
            this.lblActions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(60, 22);
            this.lblActions.Text = "lblActions";
            // 
            // lblPbMain
            // 
            this.lblPbMain.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPbMain.Name = "lblPbMain";
            this.lblPbMain.Size = new System.Drawing.Size(61, 22);
            this.lblPbMain.Text = "lblPbMain";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lblCurrent
            // 
            this.lblCurrent.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(60, 22);
            this.lblCurrent.Text = "lblCurrent";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(369, 28);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(169, 23);
            this.btnGo.TabIndex = 1020;
            this.btnGo.Text = "CLICK HERE TO START";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(633, 28);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(163, 23);
            this.btnHelp.TabIndex = 1021;
            this.btnHelp.Text = "CLICK HERE FOR HELP";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // showThumbnailToolStripMenuItem
            // 
            this.showThumbnailToolStripMenuItem.Name = "showThumbnailToolStripMenuItem";
            this.showThumbnailToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showThumbnailToolStripMenuItem.Text = "Show Thumbnail";
            this.showThumbnailToolStripMenuItem.Click += new System.EventHandler(this.showThumbnailToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 197);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.chkGoSlow);
            this.Controls.Add(this.chkOffline);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnAutoAdd);
            this.Controls.Add(this.lstMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.mnuListMain.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstMain;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader colImage;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip mnuListMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAddToPlaylist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenInBrowser;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
        private System.Windows.Forms.Button btnAutoAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.CheckBox chkOffline;
        private System.Windows.Forms.CheckBox chkGoSlow;
        private System.Windows.Forms.ToolStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allInOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSlowlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offlineModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choosePlaylistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuIndividualSteps;
        private System.Windows.Forms.ToolStripMenuItem mnuGetSubs;
        private System.Windows.Forms.ToolStripMenuItem mnuGetVidsFromSubs;
        private System.Windows.Forms.ToolStripMenuItem mnuShowVids;
        private System.Windows.Forms.ToolStripMenuItem mnuChoosePlaylist;
        private System.Windows.Forms.ToolStripMenuItem mnuNowTickThemBelowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFindByTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuFindNext;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripProgressBar pbMain;
        private System.Windows.Forms.ToolStripLabel lblPbMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblActions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lblCurrent;
        private System.Windows.Forms.ToolStripMenuItem showPlaylistInBrowserToolStripMenuItem;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ToolStripMenuItem changeLookAtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoaddBestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readdListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInFirefoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showThumbnailToolStripMenuItem;
    }
}

