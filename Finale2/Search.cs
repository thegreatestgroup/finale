
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Finale
{
    class Search
    {
        public System.Data.DataTable SearchFor(Song tempSong)
        {
            //
            return new DataTable(); 
        }

        public bool isSongIdExist(string songId)
        {
            string query = "SELECT *" +
                          " FROM Song WHERE" +
                          " Song.ID LIKE " + songId + ";";

            System.Data.DataTable table;

            SQLConnection sqlConnection = new SQLConnection();
            table = sqlConnection.execute("SearchResults", query);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isSongExist(string songName)
        {
            string query = "SELECT Song.ID" +
                          " FROM Song WHERE" +
                          " Song.Name LIKE " + songName + ";";

            System.Data.DataTable table;

            SQLConnection sqlConnection = new SQLConnection();
            table = sqlConnection.execute("SearchResults", query);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isAlbumIdExist(string albumId)
        {
            string query = "SELECT Album.ID" +
                          " FROM Album WHERE" +
                          " Album.ID LIKE " + albumId + ";";

            System.Data.DataTable table;

            SQLConnection sqlConnection = new SQLConnection();
            table = sqlConnection.execute("SearchResults", query);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isAlbumExist(string albumName)
        {
            string query = "SELECT Album.ID" +
                          " FROM Album WHERE" +
                          " Album.Name LIKE " + albumName + ";";

            System.Data.DataTable table;

            SQLConnection sqlConnection = new SQLConnection();
            table = sqlConnection.execute("SearchResults", query);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isComposerIdExist(string composerId)
        {
            string query = "SELECT Composer.ID" +
                          " FROM Composer WHERE" +
                          " Composer.ID LIKE " + composerId + ";";

            System.Data.DataTable table;

            SQLConnection sqlConnection = new SQLConnection();
            table = sqlConnection.execute("SearchResults", query);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isComposerExist(string composerName)
        {
            string query = "SELECT Composer.ID" +
                          " FROM Composer WHERE" +
                          " Composer.Name LIKE " + composerName + ";";

            System.Data.DataTable table;

            SQLConnection sqlConnection = new SQLConnection();
            table = sqlConnection.execute("SearchResults", query);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isGenreIdExist(string genreId)
        {
            string query = "SELECT Genre.ID" +
                          " FROM Genre WHERE" +
                          " Genre.ID LIKE " + genreId + ";";

            System.Data.DataTable table;

            SQLConnection sqlConnection = new SQLConnection();
            table = sqlConnection.execute("SearchResults", query);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isGenreExist(string genreType)
        {
            string query = "SELECT Genre.ID" +
                          " FROM Genre WHERE" +
                          " Genre.Type LIKE " + genreType + ";"; // Genre.Type ? 

            System.Data.DataTable table;

            SQLConnection sqlConnection = new SQLConnection();
            table = sqlConnection.execute("SearchResults", query);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isPriceIdExist(string priceValueId)
        {
            string query = "SELECT PriceValue.ID" +
                          " FROM PriceValue WHERE" +
                          " PriceValue.ID LIKE " + priceValueId + ";";

            System.Data.DataTable table;

            SQLConnection sqlConnection = new SQLConnection();
            table = sqlConnection.execute("SearchResults", query);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isPriceExist(string price)
        {
            string query = "SELECT PriceValue.ID" +
                          " FROM PriceValue WHERE" +
                          " PriceValue.Price LIKE " + price + ";";

            System.Data.DataTable table;

            SQLConnection sqlConnection = new SQLConnection();
            table = sqlConnection.execute("SearchResults", query);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
