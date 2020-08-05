#region Copyright

// AlbumNamesCollection.cs
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

using System.Collections.Generic;

namespace MusicManagerCurrent.Collections
{
    /// <summary>
    /// Collection of album directory names. Used for creating new path or
    /// renaming directories.
    /// </summary>
    public static class AlbumNamesCollection
    {
        #region Fields

        /// <summary>
        /// List array to hold all the songs contained in Vocal music collection.
        /// </summary>
        private static readonly List<string> AlbumList = new List<string>();

        #endregion Fields

        #region Method Public

        /// <summary>
        /// Add album name to collection.
        /// </summary>
        /// <param name="albumName">Album directory name.</param>
        public static void AddItem(string albumName)
        {
            if (!ContainsItem(albumName)) AlbumList.Add(albumName);
        }

        /// <summary>
        /// Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            AlbumList.Clear();
        }

        /// <summary>
        /// Check if album name is contained in the collection.
        /// </summary>
        /// <param name="albumName">Album directory name.</param>
        /// <returns>True if album directory name is found else false.</returns>
        public static bool ContainsItem(string albumName)
        {
            return AlbumList.Contains(albumName);
        }

        /// <summary>
        /// Gets all items contained in the collection.
        /// </summary>
        /// <returns>All items in collection.</returns>
        public static string[] GetAllItems()
        {
            var origPath = new string[0];

            var cnt = AlbumList.Count;

            // No genre Folders Found
            if ((cnt - 1) < 1) return origPath;

            origPath = new string[cnt];

            for (var i = 0; i < cnt; i++) origPath[i] = AlbumList[i];

            // All OK.
            return origPath;
        }

        /// <summary>
        /// Gets the index of the item.
        /// </summary>
        /// <returns>The index of the item.</returns>
        /// <param name="index">Index of item to get from the collection.</param>
        public static string GetItemAt(int index)
        {
            return AlbumList[index];
        }

        /// <summary>
        /// Get the index of album name.
        /// </summary>
        /// <param name="albumName">
        /// The name of the album to find the collection index.
        /// </param>
        /// <returns>return index.</returns>
        public static int GetItemIndex(string albumName)
        {
            return AlbumList.IndexOf(albumName);
        }

        /// <summary>
        /// The number of items in the collection.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemsCount()
        {
            return AlbumList.Count;
        }

        /// <summary>
        /// Remove album name from the collection.
        /// </summary>
        /// <param name="albumName">The name of the album directory to remove.</param>
        /// <returns>true if album name removed else false.</returns>
        public static bool RemoveItem(string albumName)
        {
            return AlbumList.Remove(albumName);
        }

        /// <summary>
        /// Removes the item at specified index.
        /// </summary>
        /// <returns>True if item is removed from the collection else false.</returns>
        /// <param name="index">Index.</param>
        public static bool RemoveItemAt(int index)
        {
            var albumName = GetItemAt(index);
            AlbumList.RemoveAt(index);

            if (!ContainsItem(albumName)) return true;
            MyMessages.ErrorMessage = "Failed to remove " + albumName;
            MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            return false;
        }

        /// <summary>
        /// Sorts the collection.
        /// </summary>
        public static void SortCollection()
        {
            AlbumList.Sort();
        }

        #endregion Method Public
    }
}
