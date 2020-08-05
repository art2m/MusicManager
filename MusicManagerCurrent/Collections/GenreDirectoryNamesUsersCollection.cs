// MusicManagerCurrent
// 
// GenreDirectoryNamesUsersCollection.cs
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

// Copyright (c) 2016 art2m Author: art2m <art2m@live.com>
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

using System.Collections.Generic;
using MusicManagerCurrent.Classes;
using MusicManagerCurrent.ClassesProperties;

namespace MusicManagerCurrent.Collections
{
    /// <summary>
    ///     Genre directory names users collection.
    /// </summary>
    public static class GenreDirectoryNamesUsersCollection
    {
        /// <summary>
        ///     The genre list.
        /// </summary>
        private static readonly List<string> GenreList = new List<string>();

        /// <summary>
        ///     Adds the Genre directory names to the collection.
        /// </summary>
        public static void AddItem(string genreName)
        {
            if (!ContainsItem(genreName)) GenreList.Add(genreName);
        }

        /// <summary>
        ///     Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            GenreList.Clear();
        }

        /// <summary>
        ///     Gets all items contained in the collection.
        /// </summary>
        /// <returns>All items in collection</returns>
        public static string[] GetAllItems()
        {
            var origPath = new string[0];

            var cnt = GenreList.Count;

            // No genre Folders Found
            if (cnt - 1 < 1) return origPath;

            origPath = new string[cnt];
            for (var i = 0; i < cnt; i++) origPath[i] = GenreList[i];

            // All OK.
            return origPath;
        }

        /// <summary>
        ///     Gets the item at the index.
        /// </summary>
        /// <returns>Genre directory name.</returns>
        /// <param name="index">Index of item to get from the collection.</param>
        public static string GetItemAt(int index)
        {
            return GenreList[index];
        }

        /// <summary>
        ///     Gets the index of the item.
        /// </summary>
        /// <returns>The name of the genre directory.</returns>
        /// <param name="genreName">The genre directory name.</param>
        public static int GetItemIndex(string genreName)
        {
            return GenreList.IndexOf(genreName);
        }

        /// <summary>
        ///     The number of items in the collection.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemCount()
        {
            return GenreList.Count;
        }

        /// <summary>
        ///     Remove genre name from the collection.
        /// </summary>
        /// <returns>True if artist name removed.</returns>
        /// <param name="genreName">The name of the genre directory to remove.</param>
        public static bool RemoveItem(string genreName)
        {
            return GenreList.Remove(genreName);
        }

        /// <summary>
        ///     Removes item at the specified index.
        /// </summary>
        /// <returns>True if item is removed from the collection else false.</returns>
        /// <param name="index">Index-of the item to be remove.</param>
        public static bool RemoveItemAt(int index)
        {
            var genreName = GetItemAt(index);

            GenreList.RemoveAt(index);

            if (!ContainsItem(genreName)) return true;
            MyMessages.ErrorMessage = "Failed to remove " + genreName;
            MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            return false;
        }

        /// <summary>
        ///     Sort collection.
        /// </summary>
        public static void SortCollection()
        {
            GenreList.Sort();
        }

        /// <summary>
        ///     Check if genre name is contained in the collection.
        /// </summary>
        /// <returns>True if genre directory name is found else false.</returns>
        /// <param name="genreName">Genre name.</param>
        private static bool ContainsItem(string genreName)
        {
            return GenreList.Contains(genreName);
        }
    }
}