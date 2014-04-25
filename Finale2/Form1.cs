
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finale
{
    public partial class Form1 : Form
    {
        private static Operations mHandle;
        public System.Data.DataTable searchResults = new DataTable();

        /**
         * Constructor for the form
         */
        public Form1()
        {
            InitializeComponent();

            mHandle = new Operations();

            #region Display All Songs

            viewSongsGrid.ReadOnly = true;
            viewSongsGrid.DataSource = mHandle.viewSongs();

            #endregion

            #region Search

            SearchGrid.ReadOnly = true;
            SearchGrid.DataSource = searchResults;




            #endregion
        }

        /**
         * Method invoked by the user clicking the remove song button
         *
         * @param object sender
         * @param EventArgs e
         */
        private void submitRemoveSong_Click(object sender, EventArgs e)
        {
            #region Remove Song

            if (removeSongName.Text.ToString() == "")
            {
                MessageBox.Show("Error: You must enter a song name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mHandle.removeSong(removeSongName.Text.ToString());

                MessageBox.Show("The song " + removeSongName.Text.ToString() + " has been successfully removed.", "Song Removed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            #endregion

            #region Update Display All Songs

            viewSongsGrid.ReadOnly = true;
            viewSongsGrid.DataSource = mHandle.viewSongs();

            #endregion
        }


        /*private void searchButton_Click(object sender, EventArgs e)
        {

           
        }*/

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            var tempSong = new Song();

            #region Populate tempSong w/ Text Box Info
            if (songSearchTextBox.Text != "")
            {
                tempSong.Title.Value = songSearchTextBox.Text;
            }

            if (artistSearchTextBox.Text != "")
            {
                tempSong.Artist.Value = artistSearchTextBox.Text;
            }

            if (albumSearchTextBox.Text != "")
            {
                tempSong.Album.Value = albumSearchTextBox.Text;
            }
            #endregion

            searchResults = mHandle.searchSongs(tempSong);
            SearchGrid.DataSource = searchResults;
        }

		private void submitAddSong_Click(object sender, EventArgs e)
		{
            string songName = addSongName.Text.ToString();
            string songAlbum = addSongAlbum.Text.ToString();
            string songArtist = addSongArtist.Text.ToString();
            string songComposer = addSongComposer.Text.ToString();
            string songYear = addSongYear.Text.ToString();
            string songGenre = addSongGenre.Text.ToString();

            string message = mHandle.addSong(songName, songAlbum, songArtist,
                                             songComposer, songYear, songGenre);

            songName = "'" + addSongName.Text.ToString() + "'";

            if (message == "success")
            {
                SQLConnection mDB = new SQLConnection();

                string getID = "SELECT MAX(ID) AS ID FROM Song";
                //MessageBox.Show(getID);
                System.Data.DataTable newSongID = mDB.execute("getID", getID); //song ID
                int dumb = (int)newSongID.Rows[0]["ID"] + 1;

                string getAlbumID = "SELECT Album.ID AS ID FROM Album WHERE Album.Name = '" + songAlbum + "'";
                //MessageBox.Show(getAlbumID);
                System.Data.DataTable newSongAlbumID = mDB.execute("getAlbumID", getAlbumID); //album ID

                string getArtistID = "SELECT Artist.ArtistID AS ArtistID FROM Artist WHERE Artist.Name = '" + songArtist + "'";
                //MessageBox.Show(getArtistID);
                System.Data.DataTable newSongArtistID = mDB.execute("getArtistID", getArtistID); //artist ID

                string getComposerID = "SELECT Composer.ID AS ID FROM Composer WHERE Composer.Name = '" + songComposer + "'";
                //MessageBox.Show(getComposerID);
                System.Data.DataTable newSongComposerID = mDB.execute("getComposerID", getComposerID); //composer ID

                string getGenreID = "SELECT Genre.ID AS ID FROM Genre WHERE Genre.Name = '" + songGenre + "'";
                //MessageBox.Show(getGenreID);
                System.Data.DataTable newSongGenreID = mDB.execute("getGenreID", getGenreID); //genre ID

                string songValues = dumb + ", " + songName + ", " + newSongArtistID.Rows[0]["ArtistID"].ToString() + ", " + newSongComposerID.Rows[0]["ID"].ToString() + ", " + newSongGenreID.Rows[0]["ID"].ToString() + ", " + songYear;
                //MessageBox.Show(songValues);
                AddOperation songAddition = new AddOperation();

                string albumSongValues = newSongAlbumID.Rows[0]["ID"].ToString() + ", " + dumb;

                songAddition.addAttributeToTable("Song", songValues);
                songAddition.addAttributeToTable("AlbumSong", albumSongValues);

                MessageBox.Show("The song " + addSongName.Text.ToString() + " was added.", "Added: " + addSongName.Text.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
			else
			{
				MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void submitUpdateSong_Click(object sender, EventArgs e)
        {
            string songID, songName, songArtist, songComposer, songGenre, songYear; //, songPrice;

            songID = songAddID.Text.ToString();
            songName = addSongName.Text.ToString();
            songArtist = addSongArtist.Text.ToString();
            songComposer = addSongComposer.Text.ToString();
            songGenre = addSongGenre.Text.ToString();
            songYear = addSongYear.Text.ToString();
            //songPrice = addSongPrice.Text.ToString();

            if (songID == "" || songName == "" || songArtist == "" || songComposer == "" || songGenre == "" ||
                songYear == "") // || songPrice == "")
            {
                MessageBox.Show("No empty fields allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            string sqlSetStatement = "ID=" + songID + "," +
                                     "Name=" + songName + "," +
                                     "ArtistID=" + songArtist + "," +
                                     "ComposerID=" + songComposer + "," +
                                     "GenreID=" + songGenre + "," +
                                     "Year=" + songYear; // + "," +
                                     //"PriceID=" + songPrice;

            Operations operations = new Operations();

            operations.updateSong(songAddID.Text.ToString(), sqlSetStatement);
        }

        private void tabAdd_Click(object sender, EventArgs e)
        {

        }

        private void addSongID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
