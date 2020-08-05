namespace MusicManagerCurrent.Sources
{
    partial class MusicManagerWin
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
            this.btnClose = new MusicManagerCurrent.Classes.MyButton();
            this.lblName = new System.Windows.Forms.Label();
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtMusic = new System.Windows.Forms.TextBox();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuMainWin = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenreAddDir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenreEditDir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveDir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegenerateList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAddArtistDir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveArtistDir = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadGenreMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPath = new System.Windows.Forms.ToolStripMenuItem();
            this.palthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeCase = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceDirDElimiter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReplaceFileDelimiter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExistingPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchAlbums = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchArtist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchSong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCountryHits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRockTopHits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLocateHome = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLocateMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.songTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSongTag = new System.Windows.Forms.ToolStripMenuItem();
            this.tblPanel.SuspendLayout();
            this.menuMainWin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(618, 500);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnQuit_Clicked);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Khaki;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(194, 55);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "User Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblPanel
            // 
            this.tblPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.tblPanel.ColumnCount = 2;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel.Controls.Add(this.txtMusic, 1, 2);
            this.tblPanel.Controls.Add(this.txtHome, 1, 1);
            this.tblPanel.Controls.Add(this.lblName, 0, 0);
            this.tblPanel.Controls.Add(this.lblHome, 0, 1);
            this.tblPanel.Controls.Add(this.lblMusic, 0, 2);
            this.tblPanel.Controls.Add(this.txtName, 1, 0);
            this.tblPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblPanel.Location = new System.Drawing.Point(14, 192);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.RowCount = 3;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblPanel.Size = new System.Drawing.Size(753, 184);
            this.tblPanel.TabIndex = 3;
            // 
            // txtMusic
            // 
            this.txtMusic.Location = new System.Drawing.Point(203, 123);
            this.txtMusic.Multiline = true;
            this.txtMusic.Name = "txtMusic";
            this.txtMusic.Size = new System.Drawing.Size(547, 55);
            this.txtMusic.TabIndex = 7;
            // 
            // txtHome
            // 
            this.txtHome.Location = new System.Drawing.Point(203, 63);
            this.txtHome.Multiline = true;
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(547, 54);
            this.txtHome.TabIndex = 6;
            // 
            // lblHome
            // 
            this.lblHome.BackColor = System.Drawing.Color.Khaki;
            this.lblHome.Location = new System.Drawing.Point(3, 60);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(194, 55);
            this.lblHome.TabIndex = 3;
            this.lblHome.Text = "Home Path";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMusic
            // 
            this.lblMusic.BackColor = System.Drawing.Color.Khaki;
            this.lblMusic.Location = new System.Drawing.Point(3, 120);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(194, 55);
            this.lblMusic.TabIndex = 4;
            this.lblMusic.Text = "Music Path";
            this.lblMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 3);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(547, 54);
            this.txtName.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Khaki;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(14, 73);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(753, 34);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Testing";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuMainWin
            // 
            this.menuMainWin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMainWin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.genreToolStripMenuItem,
            this.musicToolStripMenuItem,
            this.palthToolStripMenuItem,
            this.mnuNewPlaylist,
            this.mnuSearchAlbums,
            this.mnuLocateHome,
            this.songTagToolStripMenuItem});
            this.menuMainWin.Location = new System.Drawing.Point(0, 0);
            this.menuMainWin.Name = "menuMainWin";
            this.menuMainWin.Size = new System.Drawing.Size(780, 28);
            this.menuMainWin.TabIndex = 5;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuQuit
            // 
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(180, 24);
            this.mnuQuit.Text = "Quit";
            this.mnuQuit.Click += new System.EventHandler(this.OnQuit_Clicked);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenreAddDir,
            this.mnuGenreEditDir,
            this.mnuRemoveDir,
            this.toolStripSeparator1,
            this.mnuEditList,
            this.mnuRegenerateList,
            this.toolStripSeparator2,
            this.mnuAddArtistDir,
            this.mnuRemoveArtistDir});
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.genreToolStripMenuItem.Text = "&Genre";
            // 
            // mnuGenreAddDir
            // 
            this.mnuGenreAddDir.Name = "mnuGenreAddDir";
            this.mnuGenreAddDir.Size = new System.Drawing.Size(236, 24);
            this.mnuGenreAddDir.Text = "Add Directory";
            this.mnuGenreAddDir.Click += new System.EventHandler(this.OnGenreAddDirectory_Clicked);
            // 
            // mnuGenreEditDir
            // 
            this.mnuGenreEditDir.Name = "mnuGenreEditDir";
            this.mnuGenreEditDir.Size = new System.Drawing.Size(236, 24);
            this.mnuGenreEditDir.Text = "Edit Directory";
            this.mnuGenreEditDir.Click += new System.EventHandler(this.OnGenreEditDirectory);
            // 
            // mnuRemoveDir
            // 
            this.mnuRemoveDir.Name = "mnuRemoveDir";
            this.mnuRemoveDir.Size = new System.Drawing.Size(236, 24);
            this.mnuRemoveDir.Text = "Remove Directory";
            this.mnuRemoveDir.Click += new System.EventHandler(this.OnGenreRemoveDirectory);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // mnuEditList
            // 
            this.mnuEditList.Name = "mnuEditList";
            this.mnuEditList.Size = new System.Drawing.Size(236, 24);
            this.mnuEditList.Text = "Add Edit Default List";
            // 
            // mnuRegenerateList
            // 
            this.mnuRegenerateList.Name = "mnuRegenerateList";
            this.mnuRegenerateList.Size = new System.Drawing.Size(236, 24);
            this.mnuRegenerateList.Text = "Regenerate Default List";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // mnuAddArtistDir
            // 
            this.mnuAddArtistDir.Name = "mnuAddArtistDir";
            this.mnuAddArtistDir.Size = new System.Drawing.Size(236, 24);
            this.mnuAddArtistDir.Text = "Add Artist Directory";
            // 
            // mnuRemoveArtistDir
            // 
            this.mnuRemoveArtistDir.Name = "mnuRemoveArtistDir";
            this.mnuRemoveArtistDir.Size = new System.Drawing.Size(236, 24);
            this.mnuRemoveArtistDir.Text = "Remove Artist Directory";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadGenreMusic,
            this.mnuLoadMusic,
            this.mnuEditPath});
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.musicToolStripMenuItem.Text = "&Music";
            // 
            // mnuLoadGenreMusic
            // 
            this.mnuLoadGenreMusic.Name = "mnuLoadGenreMusic";
            this.mnuLoadGenreMusic.Size = new System.Drawing.Size(196, 24);
            this.mnuLoadGenreMusic.Text = "Load Genre Music";
            this.mnuLoadGenreMusic.Click += new System.EventHandler(this.OnLoadGenreMusicMenu_Clicked);
            // 
            // mnuLoadMusic
            // 
            this.mnuLoadMusic.Name = "mnuLoadMusic";
            this.mnuLoadMusic.Size = new System.Drawing.Size(196, 24);
            this.mnuLoadMusic.Text = "Load Music";
            this.mnuLoadMusic.Click += new System.EventHandler(this.OnLoadMusicMenu_Clicked);
            // 
            // mnuEditPath
            // 
            this.mnuEditPath.Name = "mnuEditPath";
            this.mnuEditPath.Size = new System.Drawing.Size(196, 24);
            this.mnuEditPath.Text = "Edit Path";
            this.mnuEditPath.Click += new System.EventHandler(this.OnEditPathMusicMenu_Clicked);
            // 
            // palthToolStripMenuItem
            // 
            this.palthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangeCase,
            this.ReplaceDirDElimiter,
            this.mnuReplaceFileDelimiter});
            this.palthToolStripMenuItem.Name = "palthToolStripMenuItem";
            this.palthToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.palthToolStripMenuItem.Text = "&Palth";
            // 
            // mnuChangeCase
            // 
            this.mnuChangeCase.Name = "mnuChangeCase";
            this.mnuChangeCase.Size = new System.Drawing.Size(262, 24);
            this.mnuChangeCase.Text = "Change Case";
            // 
            // ReplaceDirDElimiter
            // 
            this.ReplaceDirDElimiter.Name = "ReplaceDirDElimiter";
            this.ReplaceDirDElimiter.Size = new System.Drawing.Size(262, 24);
            this.ReplaceDirDElimiter.Text = "Replace Directory Delimiter";
            // 
            // mnuReplaceFileDelimiter
            // 
            this.mnuReplaceFileDelimiter.Name = "mnuReplaceFileDelimiter";
            this.mnuReplaceFileDelimiter.Size = new System.Drawing.Size(262, 24);
            this.mnuReplaceFileDelimiter.Text = "Replace File Delimiter";
            // 
            // mnuNewPlaylist
            // 
            this.mnuNewPlaylist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlaylistToolStripMenuItem,
            this.mnuExistingPlaylist});
            this.mnuNewPlaylist.Name = "mnuNewPlaylist";
            this.mnuNewPlaylist.Size = new System.Drawing.Size(76, 24);
            this.mnuNewPlaylist.Text = "Play-&List";
            // 
            // newPlaylistToolStripMenuItem
            // 
            this.newPlaylistToolStripMenuItem.Name = "newPlaylistToolStripMenuItem";
            this.newPlaylistToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
            this.newPlaylistToolStripMenuItem.Text = "New Playlist";
            // 
            // mnuExistingPlaylist
            // 
            this.mnuExistingPlaylist.Name = "mnuExistingPlaylist";
            this.mnuExistingPlaylist.Size = new System.Drawing.Size(219, 24);
            this.mnuExistingPlaylist.Text = "Open Existing Playlist";
            // 
            // mnuSearchAlbums
            // 
            this.mnuSearchAlbums.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumToolStripMenuItem,
            this.mnuSearchArtist,
            this.mnuSearchSong,
            this.toolStripSeparator3,
            this.mnuCountryHits,
            this.mnuRockTopHits});
            this.mnuSearchAlbums.Name = "mnuSearchAlbums";
            this.mnuSearchAlbums.Size = new System.Drawing.Size(65, 24);
            this.mnuSearchAlbums.Text = "&Search";
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.albumToolStripMenuItem.Text = "Album";
            // 
            // mnuSearchArtist
            // 
            this.mnuSearchArtist.Name = "mnuSearchArtist";
            this.mnuSearchArtist.Size = new System.Drawing.Size(188, 24);
            this.mnuSearchArtist.Text = "Artist";
            // 
            // mnuSearchSong
            // 
            this.mnuSearchSong.Name = "mnuSearchSong";
            this.mnuSearchSong.Size = new System.Drawing.Size(188, 24);
            this.mnuSearchSong.Text = "Song";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // mnuCountryHits
            // 
            this.mnuCountryHits.Name = "mnuCountryHits";
            this.mnuCountryHits.Size = new System.Drawing.Size(188, 24);
            this.mnuCountryHits.Text = "Country Top Hits";
            // 
            // mnuRockTopHits
            // 
            this.mnuRockTopHits.Name = "mnuRockTopHits";
            this.mnuRockTopHits.Size = new System.Drawing.Size(188, 24);
            this.mnuRockTopHits.Text = "Rock Top Hits";
            // 
            // mnuLocateHome
            // 
            this.mnuLocateHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.mnuLocateMusic});
            this.mnuLocateHome.Name = "mnuLocateHome";
            this.mnuLocateHome.Size = new System.Drawing.Size(105, 24);
            this.mnuLocateHome.Text = "Set-L&ocation";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // mnuLocateMusic
            // 
            this.mnuLocateMusic.Name = "mnuLocateMusic";
            this.mnuLocateMusic.Size = new System.Drawing.Size(180, 24);
            this.mnuLocateMusic.Text = "Music";
            // 
            // songTagToolStripMenuItem
            // 
            this.songTagToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSongTag});
            this.songTagToolStripMenuItem.Name = "songTagToolStripMenuItem";
            this.songTagToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.songTagToolStripMenuItem.Text = "Song-&Tags";
            // 
            // mnuSongTag
            // 
            this.mnuSongTag.Name = "mnuSongTag";
            this.mnuSongTag.Size = new System.Drawing.Size(251, 24);
            this.mnuSongTag.Text = "Edit Song Tag Information";
            // 
            // MusicManagerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.tblPanel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuMainWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuMainWin;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MusicManagerWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Manager Window";
            this.tblPanel.ResumeLayout(false);
            this.tblPanel.PerformLayout();
            this.menuMainWin.ResumeLayout(false);
            this.menuMainWin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem mnuAddArtistDir;
        private System.Windows.Forms.ToolStripMenuItem mnuEditList;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchArtist;
        private MusicManagerCurrent.Classes.MyButton btnClose;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeCase;
        private System.Windows.Forms.ToolStripMenuItem mnuCountryHits;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPath;
        private System.Windows.Forms.ToolStripMenuItem mnuSongTag;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadGenreMusic;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadMusic;
        private System.Windows.Forms.MenuStrip menuMainWin;
        private System.Windows.Forms.ToolStripMenuItem mnuGenreAddDir;
        private System.Windows.Forms.ToolStripMenuItem mnuGenreEditDir;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveDir;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLocateMusic;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExistingPlaylist;
        private System.Windows.Forms.ToolStripMenuItem palthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewPlaylist;
        private System.Windows.Forms.ToolStripMenuItem mnuRegenerateList;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveArtistDir;
        private System.Windows.Forms.ToolStripMenuItem ReplaceDirDElimiter;
        private System.Windows.Forms.ToolStripMenuItem mnuReplaceFileDelimiter;
        private System.Windows.Forms.ToolStripMenuItem mnuRockTopHits;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchAlbums;
        private System.Windows.Forms.ToolStripMenuItem mnuLocateHome;
        private System.Windows.Forms.ToolStripMenuItem songTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchSong;
        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.TextBox txtMusic;
        private System.Windows.Forms.TextBox txtName;

        #endregion
    }
}