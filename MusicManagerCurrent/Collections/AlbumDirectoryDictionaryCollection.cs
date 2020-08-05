#region Copyright

// AlbumDirectoryDictionaryCollection.cs
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
    /// Holds key album directory name. Holds value album directory path.
    /// </summary>
    public static class AlbumDirectoryDictionaryCollection
    {
        #region Fields

        /// <summary>
        /// Holds the names of the album directories.
        /// </summary>
        private static readonly Dictionary<string, string> AlbumList = new Dictionary<string, string>();

        #endregion Fields

        #region Method Public

        /// <summary>
        /// Adds artist name to collection.
        /// </summary>
        /// <returns>True if item was added else false.</returns>
        /// <param name="keyItem">The index key for the collection item.</param>
        /// <param name="valueItem">The name of the album directory.</param>
        public static bool AddItem(string keyItem, string valueItem)
        {
            if (!AlbumDirectoryDictionaryCollection.ContainsKey(keyItem)) return false;
            AlbumList.Add(keyItem, valueItem);
            return true;
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
        /// <returns>True if key was found else false.</returns>
        /// <param name="keyItem">Index of the item.</param>
        public static bool ContainsKey(string keyItem)
        {
            return AlbumList.ContainsKey(keyItem);
        }

        /// <summary>
        /// Items the count.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemCount()
        {
            return AlbumList.Count;
        }

        /// <summary>
        /// Remove album directory name from the collection.
        /// </summary>
        /// <param name="keyItem">The index of the item to be removed.</param>
        /// <returns>True if item removed else false.</returns>
        public static bool RemoveKeyItem(string keyItem)
        {
            return ContainsKey(keyItem) && AlbumList.Remove(keyItem);
        }

        /// <summary>
        /// Gets the album path at the specified key;
        /// </summary>
        /// <returns>The album path.</returns>
        /// <param name="keyItem">Key item.</param>
        public static string ReturnItemValueAtKey(string keyItem)
        {
            var keyValue = string.Empty;

            if (ContainsKey(keyItem))
            {
                AlbumList.TryGetValue(keyItem, out keyValue);
            }

            return keyValue;
        }

        #endregion Method Public
    }
}