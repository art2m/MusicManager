#region Copyright

// ChangeCase.cs
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

namespace MusicManager.Classes.Collections
{
    /// <summary>
    /// Holds Songs by artist directory, album directory, genre directory or all
    /// songs in music directory.
    /// </summary>
    public static class SongsCollection
    {
        #region Fields

        /// <summary>
        /// The songs list.
        /// </summary>
        private static readonly List<string> SongsList = new List<string>();

        #endregion Fields

        #region Method Public

        /// <summary>
        /// Add song path to the collection.
        /// </summary>
        /// <param name="songPath">Location of file in music directory.</param>
        public static void AddItem(string songPath)
        {
            if (!ContainsItem(songPath)) SongsList.Add(songPath);
        }

        /// <summary>
        /// Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            SongsList.Clear();
        }

        /// <summary>
        /// Check if song path is contained in the collection.
        /// </summary>
        /// <returns>True if song path is found else false.</returns>
        /// <param name="songPath">Location of the song file.</param>
        public static bool ContainsItem(string songPath)
        {
            return SongsList.Contains(songPath);
        }

        /// <summary>
        /// Gets all items contained in the collection.
        /// </summary>
        /// <returns>All items in collection.</returns>
        public static string[] GetAllItems()
        {
            var sngPaths = new string[0];

            var cnt = SongsList.Count;

            // No genre Folders Found
            if (cnt - 1 < 1)
            {
                return sngPaths;
            }

            sngPaths = new string[cnt];
            for (var i = 0; i < cnt; i++) sngPaths[i] = SongsList[i];

            // All OK.
            return sngPaths;
        }

        /// <summary>
        /// Gets the item at index.
        /// </summary>
        /// <returns>Song file path.</returns>
        /// <param name="index">Index of item to get from collection.</param>
        public static string GetItemAt(int index)
        {
            return SongsList[index];
        }

        /// <summary>
        /// Gets the index of the item.
        /// </summary>
        /// <returns>The item index.</returns>
        /// <param name="sngPath">The song file path.</param>
        public static int GetItemIndex(string sngPath)
        {
            return SongsList.IndexOf(sngPath);
        }

        /// <summary>
        /// The number of items in the collection.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemCount()
        {
            return SongsList.Count;
        }

        /// <summary>
        /// Removes song file path from the collection.
        /// </summary>
        /// <returns>True if item removed else false.</returns>
        /// <param name="songPath">Song path.</param>
        public static bool RemoveItem(string songPath)
        {
            return SongsList.Remove(songPath);
        }

        /// <summary>
        /// Removes the item at the specific index.
        /// </summary>
        /// <returns>True if item is removed from the collection else false.</returns>
        /// <param name="index">Index of item to be remove.</param>
        public static bool RemoveItemAt(int index)
        {
            var songPath = GetItemAt(index);
            SongsList.RemoveAt(index);

            if (!ContainsItem(songPath)) return true;
            MyMessages.ErrorMessage = "Failed to remove " + songPath;
            MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            return false;
        }

        /// <summary>
        /// Sorts the collection.
        /// </summary>
        /// <returns>
        /// <c>true</c>, if collection was sorted, <c>false</c> otherwise.
        /// </returns>
        public static void SortCollection()
        {
            SongsList.Sort();
        }

        #endregion Method Public
    }
}
