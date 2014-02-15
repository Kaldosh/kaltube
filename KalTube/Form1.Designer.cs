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
            this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGetVids = new System.Windows.Forms.Button();
            this.btnChoosePlaylist = new System.Windows.Forms.Button();
            this.btnGetSubs = new System.Windows.Forms.Button();
            this.lblActions = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnShowvids = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.lblPbMain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllInOne = new System.Windows.Forms.Button();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnAutoAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkOffline = new System.Windows.Forms.CheckBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.tmrFlash = new System.Windows.Forms.Timer(this.components);
            this.btnReAddAll = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnStopFlashing = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allinoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.getSubsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getVidsFromSubsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVidsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choosePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tickThemBelowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSlowlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoaddBestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readdListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choosePlaylistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lstMain.Location = new System.Drawing.Point(0, 72);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(1276, 321);
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
            this.mnuRemove});
            this.mnuListMain.Name = "mnuListMain";
            this.mnuListMain.Size = new System.Drawing.Size(187, 76);
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
            // btnGetVids
            // 
            this.btnGetVids.Location = new System.Drawing.Point(0, 43);
            this.btnGetVids.Name = "btnGetVids";
            this.btnGetVids.Size = new System.Drawing.Size(75, 23);
            this.btnGetVids.TabIndex = 1001;
            this.btnGetVids.Text = "2. Get Vids";
            this.btnGetVids.UseVisualStyleBackColor = true;
            this.btnGetVids.Click += new System.EventHandler(this.btnGetVids_Click);
            // 
            // btnChoosePlaylist
            // 
            this.btnChoosePlaylist.Location = new System.Drawing.Point(81, 43);
            this.btnChoosePlaylist.Name = "btnChoosePlaylist";
            this.btnChoosePlaylist.Size = new System.Drawing.Size(100, 23);
            this.btnChoosePlaylist.TabIndex = 1002;
            this.btnChoosePlaylist.Text = "4. Choose Playlist";
            this.btnChoosePlaylist.UseVisualStyleBackColor = true;
            this.btnChoosePlaylist.Click += new System.EventHandler(this.btnChoosePlaylist_Click);
            // 
            // btnGetSubs
            // 
            this.btnGetSubs.Location = new System.Drawing.Point(0, 27);
            this.btnGetSubs.Name = "btnGetSubs";
            this.btnGetSubs.Size = new System.Drawing.Size(75, 23);
            this.btnGetSubs.TabIndex = 1003;
            this.btnGetSubs.Text = "1. Get Subs";
            this.btnGetSubs.UseVisualStyleBackColor = true;
            this.btnGetSubs.Click += new System.EventHandler(this.btnGetSubs_Click);
            // 
            // lblActions
            // 
            this.lblActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActions.Location = new System.Drawing.Point(1107, 40);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(159, 23);
            this.lblActions.TabIndex = 1004;
            this.lblActions.Text = "0 Actions";
            this.lblActions.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnShowvids
            // 
            this.btnShowvids.Location = new System.Drawing.Point(81, 27);
            this.btnShowvids.Name = "btnShowvids";
            this.btnShowvids.Size = new System.Drawing.Size(100, 23);
            this.btnShowvids.TabIndex = 1005;
            this.btnShowvids.Text = "3. Show Vids";
            this.btnShowvids.UseVisualStyleBackColor = true;
            this.btnShowvids.Click += new System.EventHandler(this.btnShowvids_Click);
            // 
            // pbMain
            // 
            this.pbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMain.Location = new System.Drawing.Point(878, 41);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(223, 25);
            this.pbMain.TabIndex = 1006;
            // 
            // lblPbMain
            // 
            this.lblPbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPbMain.Location = new System.Drawing.Point(743, 31);
            this.lblPbMain.Name = "lblPbMain";
            this.lblPbMain.Size = new System.Drawing.Size(85, 16);
            this.lblPbMain.TabIndex = 1007;
            this.lblPbMain.Text = "lblPbMain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1008;
            this.label1.Text = "5. Tick boxes below";
            // 
            // btnAllInOne
            // 
            this.btnAllInOne.Location = new System.Drawing.Point(190, 43);
            this.btnAllInOne.Name = "btnAllInOne";
            this.btnAllInOne.Size = new System.Drawing.Size(99, 23);
            this.btnAllInOne.TabIndex = 1009;
            this.btnAllInOne.Text = "All In One 1-4";
            this.btnAllInOne.UseVisualStyleBackColor = true;
            this.btnAllInOne.Click += new System.EventHandler(this.btnAllInOne_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrent.Location = new System.Drawing.Point(643, 47);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(185, 18);
            this.lblCurrent.TabIndex = 1010;
            this.lblCurrent.Text = "lblCurrent";
            // 
            // btnAutoAdd
            // 
            this.btnAutoAdd.Location = new System.Drawing.Point(570, 31);
            this.btnAutoAdd.Name = "btnAutoAdd";
            this.btnAutoAdd.Size = new System.Drawing.Size(75, 39);
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
            this.chkOffline.Location = new System.Drawing.Point(478, 53);
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
            this.dtpStart.Location = new System.Drawing.Point(364, 27);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 1012;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // tmrFlash
            // 
            this.tmrFlash.Enabled = true;
            this.tmrFlash.Tick += new System.EventHandler(this.tmrFlash_Tick);
            // 
            // btnReAddAll
            // 
            this.btnReAddAll.Location = new System.Drawing.Point(295, 27);
            this.btnReAddAll.Name = "btnReAddAll";
            this.btnReAddAll.Size = new System.Drawing.Size(75, 23);
            this.btnReAddAll.TabIndex = 1014;
            this.btnReAddAll.Text = "Re-Add all";
            this.btnReAddAll.UseVisualStyleBackColor = true;
            this.btnReAddAll.Click += new System.EventHandler(this.btnReAddAll_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(383, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 1015;
            this.checkBox1.Text = "Slow - TODO";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnStopFlashing
            // 
            this.btnStopFlashing.Location = new System.Drawing.Point(276, 43);
            this.btnStopFlashing.Name = "btnStopFlashing";
            this.btnStopFlashing.Size = new System.Drawing.Size(13, 23);
            this.btnStopFlashing.TabIndex = 1016;
            this.btnStopFlashing.Text = "stop flashing";
            this.btnStopFlashing.UseVisualStyleBackColor = true;
            this.btnStopFlashing.Click += new System.EventHandler(this.btnStopFlashing_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.automationToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1276, 24);
            this.mnuMain.TabIndex = 1019;
            this.mnuMain.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allinoneToolStripMenuItem,
            this.toolStripMenuItem1,
            this.getSubsToolStripMenuItem,
            this.getVidsFromSubsToolStripMenuItem,
            this.showVidsToolStripMenuItem,
            this.choosePlaylistToolStripMenuItem,
            this.tickThemBelowToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // allinoneToolStripMenuItem
            // 
            this.allinoneToolStripMenuItem.Name = "allinoneToolStripMenuItem";
            this.allinoneToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.allinoneToolStripMenuItem.Text = "All-in-one";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // getSubsToolStripMenuItem
            // 
            this.getSubsToolStripMenuItem.Name = "getSubsToolStripMenuItem";
            this.getSubsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.getSubsToolStripMenuItem.Text = "&1. Get Subs List";
            // 
            // getVidsFromSubsToolStripMenuItem
            // 
            this.getVidsFromSubsToolStripMenuItem.Name = "getVidsFromSubsToolStripMenuItem";
            this.getVidsFromSubsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.getVidsFromSubsToolStripMenuItem.Text = "&2. Get Vids from subs";
            // 
            // showVidsToolStripMenuItem
            // 
            this.showVidsToolStripMenuItem.Name = "showVidsToolStripMenuItem";
            this.showVidsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.showVidsToolStripMenuItem.Text = "&3. Show Vids";
            // 
            // choosePlaylistToolStripMenuItem
            // 
            this.choosePlaylistToolStripMenuItem.Name = "choosePlaylistToolStripMenuItem";
            this.choosePlaylistToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.choosePlaylistToolStripMenuItem.Text = "&4. Choose Playlist";
            // 
            // tickThemBelowToolStripMenuItem
            // 
            this.tickThemBelowToolStripMenuItem.Enabled = false;
            this.tickThemBelowToolStripMenuItem.Name = "tickThemBelowToolStripMenuItem";
            this.tickThemBelowToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tickThemBelowToolStripMenuItem.Text = "&5. Tick them below";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateLimitToolStripMenuItem,
            this.addSlowlyToolStripMenuItem,
            this.offlineModeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // dateLimitToolStripMenuItem
            // 
            this.dateLimitToolStripMenuItem.Name = "dateLimitToolStripMenuItem";
            this.dateLimitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dateLimitToolStripMenuItem.Text = "Date limit";
            // 
            // addSlowlyToolStripMenuItem
            // 
            this.addSlowlyToolStripMenuItem.Name = "addSlowlyToolStripMenuItem";
            this.addSlowlyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addSlowlyToolStripMenuItem.Text = "Add slowly ";
            // 
            // offlineModeToolStripMenuItem
            // 
            this.offlineModeToolStripMenuItem.Name = "offlineModeToolStripMenuItem";
            this.offlineModeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.offlineModeToolStripMenuItem.Text = "Offline Mode";
            // 
            // automationToolStripMenuItem
            // 
            this.automationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoaddBestToolStripMenuItem,
            this.readdListToolStripMenuItem});
            this.automationToolStripMenuItem.Name = "automationToolStripMenuItem";
            this.automationToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.automationToolStripMenuItem.Text = "Automation";
            // 
            // autoaddBestToolStripMenuItem
            // 
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
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choosePlaylistToolStripMenuItem1,
            this.loginToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // choosePlaylistToolStripMenuItem1
            // 
            this.choosePlaylistToolStripMenuItem1.Name = "choosePlaylistToolStripMenuItem1";
            this.choosePlaylistToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.choosePlaylistToolStripMenuItem1.Text = "Choose Playlist";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 405);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.btnGetSubs);
            this.Controls.Add(this.btnStopFlashing);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnReAddAll);
            this.Controls.Add(this.chkOffline);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnAutoAdd);
            this.Controls.Add(this.btnAllInOne);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPbMain);
            this.Controls.Add(this.btnShowvids);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.lstMain);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.btnGetVids);
            this.Controls.Add(this.btnChoosePlaylist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mnuListMain.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstMain;
        private System.Windows.Forms.Button btnGetVids;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader colImage;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.Button btnChoosePlaylist;
        private System.Windows.Forms.Button btnGetSubs;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnShowvids;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.Label lblPbMain;
        private System.Windows.Forms.ContextMenuStrip mnuListMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAddToPlaylist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenInBrowser;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllInOne;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnAutoAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.CheckBox chkOffline;
        private System.Windows.Forms.Timer tmrFlash;
        private System.Windows.Forms.Button btnReAddAll;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnStopFlashing;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allinoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getSubsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getVidsFromSubsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVidsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choosePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tickThemBelowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSlowlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offlineModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoaddBestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readdListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choosePlaylistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}

