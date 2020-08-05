// MusicManagerCurrent
// 
// ArtistNamesCollection.cs
// 
// Arthur Melanson
// 
// art2m
// 
// 08    04   2020
// 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>

using System.Collections.Generic;
using MusicManagerCurrent.Classes;
using MusicManagerCurrent.ClassesProperties;

namespace MusicManagerCurrent.Collections
{
    /// <summary>
    ///     Collection of artist directory names. Used for creating new path or
    ///     renaming directories.
    /// </summary>
    public static class ArtistNamesCollection
    {
        /// <summary>
        ///     Holds the names of artist directories
        /// </summary>
        private static readonly List<string> ArtistList = new List<string>();

        /// <summary>
        ///     Add artist name to collection.
        /// </summary>
        /// <param name="artistName">Artist directory name.</param>
        public static void AddItem(string artistName)
        {
            if (!ContainsItem(artistName)) ArtistList.Add(artistName);
        }

        /// <summary>
        ///     Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            ArtistList.Clear();
        }

        /// <summary>
        ///     Check if artist name is contained in the collection.
        /// </summary>
        /// <param name="artistName">artist directory name.</param>
        /// <returns>True if artist directory name is found else false.</returns>
        public static bool ContainsItem(string artistName)
        {
            return ArtistList.Contains(artistName);
        }

        /// <summary>
        ///     Gets all items contained in the collection.
        /// </summary>
        /// <returns>All items in collection.</returns>
        public static string[] GetAllItems()
        {
            var origPath = new string[0];

            var cnt = ArtistList.Count;

            // No artist Folders Found
            if (cnt - 1 < 1) return origPath;

            origPath = new string[cnt];
            for (var i = 0; i < cnt; i++) origPath[i] = ArtistList[i];

            // All OK.
            return origPath;
        }

        /// <summary>
        ///     Gets the item at index.
        /// </summary>
        /// <returns>Artist Directory name.</returns>
        /// <param name="index">Index of item to get from collection..</param>
        public static string GetItemAt(int index)
        {
            return ArtistList[index];
        }

        /// <summary>
        ///     Gets the index of the item.
        /// </summary>
        /// <param name="artistName">
        ///     The name of artist to find the collection index.
        /// </param>
        /// <returns>The index of the item.</returns>
        public static int GetItemIndex(string artistName)
        {
            return ArtistList.IndexOf(artistName);
        }

        /// <summary>
        ///     The number of items in collection.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemsCount()
        {
            return ArtistList.Count;
        }

        /// <summary>
        ///     Remove artist name from the collection.
        /// </summary>
        /// <param name="artistName">The name of the artist directory to remove.</param>
        /// <returns>True if artist name removed else false.</returns>
        public static bool RemoveItem(string artistName)
        {
            return ArtistList.Remove(artistName);
        }

        /// <summary>
        ///     Removes the item at specified index.
        /// </summary>
        /// <returns>True if item is removed from the collection else false.</returns>
        /// <param name="index">Index of the item to be removed.</param>
        public static bool RemoveItemAt(int index)
        {
            var artistName = GetItemAt(index);

            ArtistList.RemoveAt(index);

            if (!ContainsItem(artistName)) return true;
            MyMessages.ErrorMessage = "Failed to remove " + artistName;
            MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            return false;
        }

        /// <summary>
        ///     Sorts the collection.
        /// </summary>
        public static void SortCollection()
        {
            ArtistList.Sort();
        }
    }
}