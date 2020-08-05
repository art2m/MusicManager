// MusicManagerCurrent
// 
// GenreDirectoriesCollection.cs
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
    ///     This collection holds genre directory paths.
    /// </summary>
    public class GenreDirectoriesCollection
    {
        /// <summary>
        ///     List array to hold all the genre directory paths.
        /// </summary>
        private static readonly List<string> GenreList = new List<string>();

        /// <summary>
        ///     Add genre name to collection.
        /// </summary>
        /// <param name="genrePath">Genre directory path.</param>
        public static void AddItem(string genrePath)
        {
            if (!ContainsItem(genrePath)) GenreList.Add(genrePath);
        }

        /// <summary>
        ///     Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            GenreList.Clear();
        }

        /// <summary>
        ///     Check if genre name is contained in the collection.
        /// </summary>
        /// <param name="genrePath">Genre directory path.</param>
        /// <returns>True if Genre directory path is found else false.</returns>
        public static bool ContainsItem(string genrePath)
        {
            return GenreList.Contains(genrePath);
        }

        /// <summary>
        ///     Gets all items contained in the collection.
        /// </summary>
        /// <returns>All items in collection.</returns>
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
        ///     Gets the index of the item.
        /// </summary>
        /// <returns>The index of the item.</returns>
        /// <param name="index">Index of item to get from the collection.</param>
        public static string GetItemAt(int index)
        {
            return GenreList[index];
        }

        /// <summary>
        ///     Get the index of genre name.
        /// </summary>
        /// <param name="genrePath">The path to the genre dirctory.</param>
        /// <returns>return index.</returns>
        public static int GetItemIndex(string genrePath)
        {
            return GenreList.IndexOf(genrePath);
        }

        /// <summary>
        ///     The number of items in the collection.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemsCount()
        {
            return GenreList.Count;
        }

        /// <summary>
        ///     Remove genre path from the collection.
        /// </summary>
        /// <param name="genrePath">The genre directory path.</param>
        /// <returns>true if genre path removed else false.</returns>
        public static bool RemoveItem(string genrePath)
        {
            return GenreList.Remove(genrePath);
        }

        /// <summary>
        ///     Removes the item at specified index.
        /// </summary>
        /// <returns>True if item is removed from the collection else false.</returns>
        /// <param name="index">Index.</param>
        public static bool RemoveItemAt(int index)
        {
            var genrePath = GetItemAt(index);
            GenreList.RemoveAt(index);

            if (!ContainsItem(genrePath)) return true;
            MyMessages.ErrorMessage = "Failed to remove " + genrePath;
            MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            return false;
        }

        /// <summary>
        ///     Sorts the collection.
        /// </summary>
        public static void SortCollection()
        {
            GenreList.Sort();
        }
    }
}