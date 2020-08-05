// MusicManagerCurrent
// 
// ArtistDirectoryDictionaryCollection.cs
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

namespace MusicManagerCurrent.Collections
{
    /// <summary>
    ///     Holds key artist directory name. Holds value artist directory path.
    /// </summary>
    public static class ArtistDirectoryDictionaryCollection
    {
        /// <summary>
        ///     The genre directory list.
        /// </summary>
        private static readonly Dictionary<string, string> ArtistList = new Dictionary<string, string>();

        /// <summary>
        ///     Adds artist name to the collection.
        /// </summary>
        /// <returns>True if item was added else false</returns>
        /// <param name="keyItem">The index key for the collection item.</param>
        /// <param name="valueItem">The name of the album directory.</param>
        public static bool AddItem(string keyItem, string valueItem)
        {
            if (!ContainsKey(keyItem)) return false;
            ArtistList.Add(keyItem, valueItem);
            return true;
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
        /// <returns>True if key was found else false.</returns>
        /// <param name="keyItem">Index of the item.</param>
        public static bool ContainsKey(string keyItem)
        {
            return ArtistList.ContainsKey(keyItem);
        }

        /// <summary>
        ///     Items the count.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemCount()
        {
            return ArtistList.Count;
        }

        /// <summary>
        ///     Remove artist directory name from the collection.
        /// </summary>
        /// <returns>True if item removed else false.</returns>
        /// <param name="keyItem">The index of the item to be removed.</param>
        public static bool RemoveKeyItem(string keyItem)
        {
            return ContainsKey(keyItem) && ArtistList.Remove(keyItem);
        }

        /// <summary>
        ///     Gets the artist path at the specified key.
        /// </summary>
        /// <returns>The artist path.</returns>
        /// <param name="keyItem">Key item.</param>
        public static string ReturnItemValueAtKey(string keyItem)
        {
            var keyValue = string.Empty;

            if (ContainsKey(keyItem)) ArtistList.TryGetValue(keyItem, out keyValue);

            return keyValue;
        }
    }
}