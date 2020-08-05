// clsSongsPathList.cs // Author: art2m <art2m@live.com> // Copyright (c) 2012 art2m // This program is free
// software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published
// by the Free Software Foundation, either version 3 of the License, or (at your option) any later version. // This
// program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied
// warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more
// details. // You should have received a copy of the GNU General Public License along with this program. If not,
// see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Reflection;

namespace MusicManagerCurrent.Collections
{
    /// <summary>
    /// Original song paths collection.
    /// </summary>
    public static class OriginalSongPathsCollection
    {
        #region GLOBAL VARIABLES

        /// <summary>
        /// The song paths.
        /// </summary>
        private static readonly List<string> songPaths = new List<string>();

        #endregion GLOBAL VARIABLES

        #region METHODS PUBLIC

        /// <summary>
        /// Adds the new item.
        /// </summary>
        /// <returns><c>true</c>, if new item was added, <c>false</c> otherwise.</returns>
        /// <param name="songPath">String path.</param>
        public static bool AddNewItem(string songPath)
        {
            var bolRetVal = false;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                songPaths.Add(songPath);

                // All OK
                bolRetVal = true;
                return bolRetVal;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding new song path to this collection: " + songPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding new song path to this collection: " + songPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        /// <summary>
        /// Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                songPaths.Clear();
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while clearing the collection.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
            }
        }

        /// <summary>
        /// Contains the item.
        /// </summary>
        /// <returns><c>true</c>, if item was contained, <c>false</c> otherwise.</returns>
        /// <param name="songPath">String path.</param>
        public static bool ContainsItem(string songPath)
        {
            var bolRetVal = false;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                bolRetVal = songPaths.Contains(songPath);

                // All OK
                bolRetVal = true;
                return bolRetVal;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while checking for this item: " + songPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while checking for this item: " + songPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <returns>The all items.</returns>
        public static string[] GetAllItems()
        {
            string[] origPaths = null;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                var intCnt = songPaths.Count;

                // No genre Folders Found
                if ((intCnt - 1) < 1)
                {
                    return origPaths;
                }

                origPaths = new string[songPaths.Count];
                for (int i = 0; i < intCnt; i++)
                {
                    origPaths[i] = songPaths[i];
                }

                // All OK.
                return origPaths;
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while getting list from collection.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return origPaths;
            }
            catch (InvalidOperationException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while getting list from collection.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return origPaths;
            }
        }

        /// <summary>
        /// Gets the item at index.
        /// </summary>
        /// <returns>The <see cref="T:System.String"/>.</returns>
        /// <param name="index">Index of item to get.</param>
        public static string GetItemAt(int index)
        {
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                return songPaths[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while returning song path.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Gets the index of the item.
        /// </summary>
        /// <returns>The item index.</returns>
        /// <param name="songPath">String path.</param>
        public static int GetItemIndex(string songPath)
        {
            var intRetVal = 0;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                intRetVal = songPaths.IndexOf(songPath);

                // All OK
                return intRetVal;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error getting Index of this item: " + songPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return intRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error getting Index of this item: " + songPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return intRetVal;
            }
        }

        /// <summary>
        /// Itemses the count.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemCount()
        {
            var intCnt = 0;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                intCnt = songPaths.Count;

                // All OK
                return intCnt;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while getting count of items contained in the collection.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return intCnt;
            }
        }

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <returns><c>true</c>, if item was removed, <c>false</c> otherwise.</returns>
        /// <param name="songPath">String path.</param>
        public static bool RemoveItem(string songPath)
        {
            var bolRetVal = false;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                songPaths.Remove(songPath);

                // All OK
                bolRetVal = true;
                return bolRetVal;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while removing this item: " + songPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while removing this item: " + songPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        /// <summary>
        /// Removes the item at intIndex.
        /// </summary>
        /// <returns>The <see cref="T:System.Boolean"/>.</returns>
        /// <param name="intIndex">Int index.</param>
        public static bool RemoveItemAt(int intIndex)
        {
            var bolRetVal = false;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                songPaths.RemoveAt(intIndex);

                // All OK
                bolRetVal = true;
                return bolRetVal;
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Encountered error removing item at Index: " + intIndex;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error removing item at Index: " + intIndex;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        /// <summary>
        /// Sorts the collection.
        /// </summary>
        /// <returns><c>true</c>, if collection was sorted, <c>false</c> otherwise.</returns>
        public static bool SortCollection()
        {
            var bolRetVal = false;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                songPaths.Sort();
                return bolRetVal = true;
            }
            catch (InvalidOperationException ex)
            {
                MyMessages.ErrorMessage = "Unable to sort collection.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        #endregion METHODS PUBLIC
    }
}