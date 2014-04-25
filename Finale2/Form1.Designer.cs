namespace Finale
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
            this.navMenu = new System.Windows.Forms.TabControl();
            this.tabView = new System.Windows.Forms.TabPage();
            this.viewSongsGrid = new System.Windows.Forms.DataGridView();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.albumSearchTextBox = new System.Windows.Forms.TextBox();
            this.artistSearchTextBox = new System.Windows.Forms.TextBox();
            this.songSearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchGrid = new System.Windows.Forms.DataGridView();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.songAddID = new System.Windows.Forms.TextBox();
            this.submitUpdateSong = new System.Windows.Forms.Button();
            this.submitAddSong = new System.Windows.Forms.Button();
            this.addSongGenre = new System.Windows.Forms.TextBox();
            this.addSongYear = new System.Windows.Forms.TextBox();
            this.addSongComposer = new System.Windows.Forms.TextBox();
            this.addSongArtist = new System.Windows.Forms.TextBox();
            this.addSongAlbum = new System.Windows.Forms.TextBox();
            this.addSongName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabRemove = new System.Windows.Forms.TabPage();
            this.submitRemoveSong = new System.Windows.Forms.Button();
            this.removeSongName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navMenu.SuspendLayout();
            this.tabView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSongsGrid)).BeginInit();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).BeginInit();
            this.tabAdd.SuspendLayout();
            this.tabRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenu
            // 
            this.navMenu.Controls.Add(this.tabView);
            this.navMenu.Controls.Add(this.tabSearch);
            this.navMenu.Controls.Add(this.tabAdd);
            this.navMenu.Controls.Add(this.tabRemove);
            this.navMenu.Location = new System.Drawing.Point(13, 13);
            this.navMenu.Name = "navMenu";
            this.navMenu.SelectedIndex = 0;
            this.navMenu.Size = new System.Drawing.Size(1267, 619);
            this.navMenu.TabIndex = 0;
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.viewSongsGrid);
            this.tabView.Location = new System.Drawing.Point(4, 22);
            this.tabView.Name = "tabView";
            this.tabView.Padding = new System.Windows.Forms.Padding(3);
            this.tabView.Size = new System.Drawing.Size(1259, 593);
            this.tabView.TabIndex = 0;
            this.tabView.Text = "View Songs";
            this.tabView.UseVisualStyleBackColor = true;
            // 
            // viewSongsGrid
            // 
            this.viewSongsGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.viewSongsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSongsGrid.Location = new System.Drawing.Point(7, 7);
            this.viewSongsGrid.Name = "viewSongsGrid";
            this.viewSongsGrid.Size = new System.Drawing.Size(1246, 580);
            this.viewSongsGrid.TabIndex = 0;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.label4);
            this.tabSearch.Controls.Add(this.label3);
            this.tabSearch.Controls.Add(this.label2);
            this.tabSearch.Controls.Add(this.searchButton);
            this.tabSearch.Controls.Add(this.albumSearchTextBox);
            this.tabSearch.Controls.Add(this.artistSearchTextBox);
            this.tabSearch.Controls.Add(this.songSearchTextBox);
            this.tabSearch.Controls.Add(this.SearchGrid);
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1259, 593);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.Text = "Search Songs";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Song";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(229, 143);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // albumSearchTextBox
            // 
            this.albumSearchTextBox.Location = new System.Drawing.Point(127, 106);
            this.albumSearchTextBox.Name = "albumSearchTextBox";
            this.albumSearchTextBox.Size = new System.Drawing.Size(186, 20);
            this.albumSearchTextBox.TabIndex = 3;
            // 
            // artistSearchTextBox
            // 
            this.artistSearchTextBox.Location = new System.Drawing.Point(127, 59);
            this.artistSearchTextBox.Name = "artistSearchTextBox";
            this.artistSearchTextBox.Size = new System.Drawing.Size(186, 20);
            this.artistSearchTextBox.TabIndex = 2;
            // 
            // songSearchTextBox
            // 
            this.songSearchTextBox.Location = new System.Drawing.Point(127, 13);
            this.songSearchTextBox.Name = "songSearchTextBox";
            this.songSearchTextBox.Size = new System.Drawing.Size(186, 20);
            this.songSearchTextBox.TabIndex = 1;
            // 
            // SearchGrid
            // 
            this.SearchGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.SearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchGrid.Location = new System.Drawing.Point(337, 13);
            this.SearchGrid.Name = "SearchGrid";
            this.SearchGrid.Size = new System.Drawing.Size(916, 574);
            this.SearchGrid.TabIndex = 0;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.label11);
            this.tabAdd.Controls.Add(this.songAddID);
            this.tabAdd.Controls.Add(this.submitUpdateSong);
            this.tabAdd.Controls.Add(this.submitAddSong);
            this.tabAdd.Controls.Add(this.addSongGenre);
            this.tabAdd.Controls.Add(this.addSongYear);
            this.tabAdd.Controls.Add(this.addSongComposer);
            this.tabAdd.Controls.Add(this.addSongArtist);
            this.tabAdd.Controls.Add(this.addSongAlbum);
            this.tabAdd.Controls.Add(this.addSongName);
            this.tabAdd.Controls.Add(this.label10);
            this.tabAdd.Controls.Add(this.label9);
            this.tabAdd.Controls.Add(this.label8);
            this.tabAdd.Controls.Add(this.label7);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(1259, 593);
            this.tabAdd.TabIndex = 2;
            this.tabAdd.Text = "Add/Update Song";
            this.tabAdd.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "ID";
            // 
            // songAddID
            // 
            this.songAddID.Location = new System.Drawing.Point(65, 208);
            this.songAddID.Name = "songAddID";
            this.songAddID.Size = new System.Drawing.Size(100, 20);
            this.songAddID.TabIndex = 14;
            this.songAddID.TextChanged += new System.EventHandler(this.addSongID_TextChanged);
            // 
            // submitUpdateSong
            // 
            this.submitUpdateSong.Location = new System.Drawing.Point(16, 234);
            this.submitUpdateSong.Name = "submitUpdateSong";
            this.submitUpdateSong.Size = new System.Drawing.Size(75, 23);
            this.submitUpdateSong.TabIndex = 13;
            this.submitUpdateSong.Text = "Update Song";
            this.submitUpdateSong.UseVisualStyleBackColor = true;
            this.submitUpdateSong.Click += new System.EventHandler(this.submitUpdateSong_Click);
            // 
            // submitAddSong
            // 
            this.submitAddSong.Location = new System.Drawing.Point(16, 179);
            this.submitAddSong.Name = "submitAddSong";
            this.submitAddSong.Size = new System.Drawing.Size(75, 23);
            this.submitAddSong.TabIndex = 12;
            this.submitAddSong.Text = "Add Song";
            this.submitAddSong.UseVisualStyleBackColor = true;
            this.submitAddSong.Click += new System.EventHandler(this.submitAddSong_Click);
            // 
            // addSongGenre
            // 
            this.addSongGenre.Location = new System.Drawing.Point(65, 142);
            this.addSongGenre.Name = "addSongGenre";
            this.addSongGenre.Size = new System.Drawing.Size(100, 20);
            this.addSongGenre.TabIndex = 11;
            // 
            // addSongYear
            // 
            this.addSongYear.Location = new System.Drawing.Point(65, 115);
            this.addSongYear.Name = "addSongYear";
            this.addSongYear.Size = new System.Drawing.Size(100, 20);
            this.addSongYear.TabIndex = 10;
            // 
            // addSongComposer
            // 
            this.addSongComposer.Location = new System.Drawing.Point(65, 88);
            this.addSongComposer.Name = "addSongComposer";
            this.addSongComposer.Size = new System.Drawing.Size(100, 20);
            this.addSongComposer.TabIndex = 9;
            // 
            // addSongArtist
            // 
            this.addSongArtist.Location = new System.Drawing.Point(65, 61);
            this.addSongArtist.Name = "addSongArtist";
            this.addSongArtist.Size = new System.Drawing.Size(100, 20);
            this.addSongArtist.TabIndex = 8;
            // 
            // addSongAlbum
            // 
            this.addSongAlbum.Location = new System.Drawing.Point(65, 34);
            this.addSongAlbum.Name = "addSongAlbum";
            this.addSongAlbum.Size = new System.Drawing.Size(100, 20);
            this.addSongAlbum.TabIndex = 7;
            // 
            // addSongName
            // 
            this.addSongName.Location = new System.Drawing.Point(65, 7);
            this.addSongName.Name = "addSongName";
            this.addSongName.Size = new System.Drawing.Size(100, 20);
            this.addSongName.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Year";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Composer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Artist";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Album";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // tabRemove
            // 
            this.tabRemove.Controls.Add(this.submitRemoveSong);
            this.tabRemove.Controls.Add(this.removeSongName);
            this.tabRemove.Controls.Add(this.label1);
            this.tabRemove.Location = new System.Drawing.Point(4, 22);
            this.tabRemove.Name = "tabRemove";
            this.tabRemove.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemove.Size = new System.Drawing.Size(1259, 593);
            this.tabRemove.TabIndex = 3;
            this.tabRemove.Text = "Remove Song";
            this.tabRemove.UseVisualStyleBackColor = true;
            // 
            // submitRemoveSong
            // 
            this.submitRemoveSong.Location = new System.Drawing.Point(42, 47);
            this.submitRemoveSong.Name = "submitRemoveSong";
            this.submitRemoveSong.Size = new System.Drawing.Size(75, 23);
            this.submitRemoveSong.TabIndex = 2;
            this.submitRemoveSong.Text = "Remove";
            this.submitRemoveSong.UseVisualStyleBackColor = true;
            this.submitRemoveSong.Click += new System.EventHandler(this.submitRemoveSong_Click);
            // 
            // removeSongName
            // 
            this.removeSongName.Location = new System.Drawing.Point(77, 7);
            this.removeSongName.Name = "removeSongName";
            this.removeSongName.Size = new System.Drawing.Size(100, 20);
            this.removeSongName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Song Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 644);
            this.Controls.Add(this.navMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navMenu.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewSongsGrid)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchGrid)).EndInit();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabRemove.ResumeLayout(false);
            this.tabRemove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navMenu;
        private System.Windows.Forms.TabPage tabView;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TabPage tabRemove;
        private System.Windows.Forms.DataGridView viewSongsGrid;
        private System.Windows.Forms.Button submitRemoveSong;
        private System.Windows.Forms.TextBox removeSongName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox albumSearchTextBox;
        private System.Windows.Forms.TextBox artistSearchTextBox;
        private System.Windows.Forms.TextBox songSearchTextBox;
        private System.Windows.Forms.DataGridView SearchGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addSongComposer;
        private System.Windows.Forms.TextBox addSongArtist;
        private System.Windows.Forms.TextBox addSongAlbum;
        private System.Windows.Forms.TextBox addSongName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button submitUpdateSong;
        private System.Windows.Forms.Button submitAddSong;
        private System.Windows.Forms.TextBox addSongGenre;
        private System.Windows.Forms.TextBox addSongYear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox songAddID;
    }
}

