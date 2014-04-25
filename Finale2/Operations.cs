
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finale
{
	class Operations
	{
		private SQLConnection mDB;

		/**
		 * Constructor for the operations manager
		 */
		public Operations()
		{
			// connect to the database
			mDB = new SQLConnection();
        }

		/**
		 * Display all songs in the database
		 * 
		 * @return DataTable
		 */
		public System.Data.DataTable viewSongs()
        {
			// query for feteching all songs
			string query = "SELECT Song.Name AS Song, Album.Name AS Album, Artist.Name AS Artist, Composer.Name AS Composer, Genre.Name AS Genre, Song.Year AS Year " +
						   "FROM Song " +
						   "INNER JOIN AlbumSong ON AlbumSong.SongID = Song.ID " +
						   "INNER JOIN Album ON Album.ID = AlbumSong.AlbumID " +
						   "INNER JOIN Artist ON Artist.ArtistID = Song.ArtistID " +
						   "INNER JOIN Composer ON Composer.ID = Song.ComposerID " +
						   "INNER JOIN Genre ON Genre.ID = Song.GenreID " +
						   "ORDER BY artist ASC";

			return mDB.execute("Song", query);
        }

        public System.Data.DataTable searchSongs(Song tempSong)
        {
            // backend code for searching songs goes here
            int counter = 0;

            #region Create Query
            string query = "USE [Champlain Music Store] SELECT [Song].[Name] AS Song, [Album].[Name] AS Album, [Artist].[Name] AS Artist, [Composer].[Name] AS Composer, [Genre].[Name] AS Genre, [Song].[Year] AS Year" + " FROM [Song]" +
                " INNER JOIN [AlbumSong] ON [AlbumSong].[SongID] = [Song].[ID]" +
                " INNER JOIN [Album] ON [Album].[ID] = [AlbumSong].[AlbumID]" +
                " INNER JOIN [Artist] ON [Artist].[ArtistID] = [Song].[ArtistID]" +
                " INNER JOIN [Composer] ON [Composer].[ID] = [Song].[ComposerID]" +
                " INNER JOIN [Genre] ON [Genre].[ID] = [Song].[GenreID]"
                + " WHERE";


            if (tempSong.Title.IsDirty)
            {
                query += (" Song.Name LIKE '%" + tempSong.Title.Value + "%'");
                counter++;
            }
            if (tempSong.Artist.IsDirty)
            {
                if (counter > 0)
                    query += " AND";
                query += (" Artist.Name LIKE '%" + tempSong.Artist.Value + "%'");
                counter++;
            }
            if (tempSong.Album.IsDirty)
            {
                if (counter > 0)
                    query += " AND";
                query += (" Album.Name LIKE '%" + tempSong.Album.Value + "%'");
            }
            #endregion


            #region Fill DataTable From Query

            System.Data.DataTable table = mDB.execute("searchResult", query);

            #endregion


            return table;
        }

		public string addSong(string song, string album, string artist, string composer, string year, string genre)
		{
			if (song == "" || album == "" || artist == "" || composer == "" || year == "" || genre == "")
				return "You must fill out every field!";

			string temp;
			string getLastSongID = "SELECT MAX(Song.ID) AS lastSongID FROM Song";

			System.Data.DataTable lastSongID = mDB.execute("lastSongID", getLastSongID);

			int nextSongID = Convert.ToInt32(lastSongID.Rows[0]["lastSongID"].ToString()) + 1;
/*
			string addSong = "BEGIN TRY " +
							 "BEGIN TRANSACTION ";

*/
			// check if song already exists
			temp = song.Replace("'", "''");
			string songExists = "SELECT Song.ID FROM Song WHERE Song.Name LIKE '" + temp + "'";

			System.Data.DataTable songID = mDB.execute("songExists", songExists);

			if (songID.Rows.Count > 0)
			{
				return "That song already exists!";
			}

			// check if album exists
			temp = album.Replace("'", "''");
			string albumExists = "SELECT Album.ID FROM Album WHERE Album.Name LIKE '" + temp + "'";

			System.Data.DataTable albumID = mDB.execute("albumExists", albumExists);

			if (albumID.Rows.Count == 0)
			{
                return "The Album does not exist!";
			}

			// check if artist exists
			temp = artist.Replace("'", "''");
			string artistExists = "SELECT Artist.ArtistID FROM Artist WHERE Artist.Name LIKE '" + temp + "'";

			System.Data.DataTable artistID = mDB.execute("artistExists", artistExists);

			if (artistID.Rows.Count == 0)
			{
                return "The Artist does not exist!";
			}

			// check if composer exists
			temp = composer.Replace("'", "''");
			string composerExists = "SELECT Composer.ID FROM Composer WHERE Composer.Name LIKE '" + temp + "'";

			System.Data.DataTable composerID = mDB.execute("composerExists", composerExists);

			if (composerID.Rows.Count == 0)
			{
                return "The Composer does not exist!";
			}

			// check if genre exists
			temp = genre.Replace("'", "''");
			string genreExists = "SELECT Genre.ID FROM Genre WHERE Genre.Name LIKE '" + temp + "'";

			System.Data.DataTable genreID = mDB.execute("genreExists", genreExists);

			if (genreID.Rows.Count == 0)
			{
                return "The Genre does not exist you pleb.";
			}
            
			return "success";
		}

		/**
		 * Remove a song from the database
		 * 
		 * @param string songName
		 */
		public void removeSong(string songName)
		{
			// escape single quotes
			string temp = songName.Replace("'", "''");

			// query for fetching a song's id
			string getSongId = "SELECT Song.ID " +
							   "FROM Song " +
							   "WHERE Song.Name LIKE '" + temp + "'";

			System.Data.DataTable songID = mDB.execute("Song", getSongId);

			// query for removing a song
			string removeSong = "BEGIN TRY " +
								"BEGIN TRANSACTION " +

								"DELETE FROM AlbumSong " +
								"WHERE AlbumSong.SongID = " + songID.Rows[0]["ID"] + " " +

								"DELETE FROM Song " +
								"WHERE Song.ID = " + songID.Rows[0]["ID"] + " " +

								"COMMIT " +
								"END TRY " +
								"BEGIN CATCH " +
								"IF @@TRANCOUNT > 0 " +
								"ROLLBACK " +
								"END CATCH";

			System.Data.DataTable result = mDB.execute("null", removeSong);
		}

        public void updateSong(string songId, string sqlSetStatement)
        {
            Search search = new Search();
            UpdateOperation uop = new UpdateOperation();

            if (search.isSongIdExist(songId))
            {
                //uop.updateAttributeInTableWithoutTransaction("Song", "ID", songId, sqlSetStatement);
                uop.updateAttributeInTableComplexWithRollback("Song", "ID", songId, sqlSetStatement);

                System.Windows.Forms.MessageBox.Show("Song updated.", "Updated", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No song with ID: " + songId + " was found.", "No update", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
    }
}
