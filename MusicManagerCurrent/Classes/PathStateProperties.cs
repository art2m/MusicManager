#region Copyright

// PathStateProperties.cs
//
// Author: art2m <art2m@live.com>
//
// Copyright (c) 2011 art2m
//
// This program is free software: you can redistribute it and/or modify it under
// the terms of the GNU General Public License as published by the Free Software
// Foundation, either version 3 of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT
// ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
// FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// this program. If not, see <http://www.gnu.org/licenses/>.

#endregion Copyright

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    /// Path state operations. Holds the state of adding, editing, canceling, deleting, updating; Holds the state of
    /// </summary>
    public static class PathStateProperties
    {
        #region PROPERTIES PUBLIC

        /// <summary>
        /// Gets or sets a value indicating whether adding new item operation.
        /// </summary>
        public static bool AddingNewItemOperation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether album name has changed.
        /// </summary>
        public static bool AlbumNameChanged { get; set; }

        /// <summary>
        /// Gets or sets the new album name.
        /// </summary>
        public static string AlbumNameNew { get; set; }

        /// <summary>
        /// Gets or sets the original album name.
        /// </summary>
        public static string AlbumNameOriginal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether artist name has changed.
        /// </summary>
        public static bool ArtistNameChanged { get; set; }

        /// <summary>
        /// Gets or sets the new artist name.
        /// </summary>
        public static string ArtistNameNew { get; set; }

        /// <summary>
        /// Gets or sets the artist original name.
        /// </summary>
        public static string ArtistNameOriginal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether canceling operation or not.
        /// </summary>
        public static bool CancelingOperation { get; set; }

        /// <summary>
        /// Gets or sets the collection total record count.
        /// </summary>
        public static int CurrentCollectionTotalRecordCount { get; set; }

        /// <summary>
        /// Gets or sets the current index number.
        /// </summary>
        public static int CurrentIndex { get; set; }

        /// <summary>
        /// Gets or sets the current working directory.
        /// </summary>
        public static string CurrentWorkingMusicPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether deleting operation or not.
        /// </summary>
        public static bool DeletingItemOperation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether editing album name or not.
        /// </summary>
        public static bool EditingAlbumName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether editing artist name or not.
        /// </summary>
        public static bool EditingArtistName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether editing genre name or not.
        /// </summary>
        public static bool EditingGenreName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether editing item operation or not.
        /// </summary>
        public static bool EditingItemOperation { get; set; }

        /// <summary>
        /// Get or sets a value indicating whether editing song title or not.
        /// </summary>
        public static bool EditingSongTitle { get; set; }

        /// <summary>
        /// Gets or sets the new genre name.
        /// </summary>
        public static string GenreNameNew { get; set; }

        /// <summary>
        /// Gets or sets the original genre name.
        /// </summary>
        public static string GenreNameOriginal { get; set; }

        /// <summary>
        /// Gets or sets the index of the selected tree view item.
        /// </summary>
        public static int IndexOfSelectedTreeViewItem { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether list view has been created.
        /// </summary>
        public static bool ListviewHasBeenCreated { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether saving data or not.
        /// </summary>
        public static bool SavingDataOperation { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether selecting all albums or not.
        /// </summary>
        public static bool selectAllAbums { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether selecting multiple albums or not.
        /// </summary>
        public static bool selectMultipleAlbums { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether selecting one album only or not.
        /// </summary>
        public static bool selectOneAlbum { get; set; }

        /// <summary>
        /// Gets or sets new song path name.
        /// </summary>
        public static string SongPathNew { get; set; }

        /// <summary>
        /// Gets or sets the song path original name.
        /// </summary>
        public static string SongPathOriginal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the song title has changed or not.
        /// </summary>
        public static bool SongTitleChanged { get; set; }

        /// <summary>
        /// Gets or sets the new song title.
        /// </summary>
        public static string SongTitleNew { get; set; }

        /// <summary>
        /// Gets or sets the original song title.
        /// </summary>
        public static string SongTitleOriginal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether updating item operation or not.
        /// </summary>
        public static bool UpdatingItemOperation { get; set; }

        #endregion PROPERTIES PUBLIC
    }
}
