// MusicManagerCurrent
// 
// OriginalDirectoryFilePathsCollection.cs
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

using System;
using System.Collections.Generic;
using System.Reflection;
using MusicManagerCurrent.Classes;
using MusicManagerCurrent.ClassesProperties;

namespace MusicManagerCurrent.Collections
{
    /// <summary>
    ///     Collection holds the original directory file path. Enables finding the directory which will be replaced with
    ///     the new directory.
    /// </summary>
    public static class OriginalDirectoryFilePathsCollection
    {
        /// <summary>
        ///     List array to hold all the songs contained in Vocal music collection.
        /// </summary>
        private static readonly List<string> fileDirName = new List<string>();

        /// <summary>
        ///     Adds the item.
        /// </summary>
        /// <param name="originalPath">Original path.</param>
        public static void AddItem(string originalPath)
        {
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                fileDirName.Add(originalPath);
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding path to this collection: " + originalPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding path to this collection: " + originalPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage,
                    ex.Message);
            }
        }

        /// <summary>
        ///     public static void ClearCollection() Clears the array.
        /// </summary>
        public static void ClearCollection()
        {
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                fileDirName.Clear();
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while clearing the collection.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
            }
        }

        /// <summary>
        ///     Contains the item.
        /// </summary>
        /// <returns><c>true</c>, if item was contained, <c>false</c> otherwise.</returns>
        /// <param name="originalPath">Original path.</param>
        public static bool ContainsItem(string originalPath)
        {
            var retVal = false;

            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                retVal = fileDirName.Contains(originalPath);

                // All OK
                retVal = true;
                return retVal;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while checking for this item: " + originalPath;

                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while checking for this item: " + originalPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        /// <summary>
        ///     Gets all items.
        /// </summary>
        /// <returns>The all items.</returns>
        public static string[] GetAllItems()
        {
            string[] origPath = null;

            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                var cnt = fileDirName.Count;

                // No genre Folders Found
                if (cnt - 1 < 1) return origPath;

                origPath = new string[cnt];

                for (var i = 0; i < cnt; i++) origPath[i] = fileDirName[i];

                // All OK.
                return origPath;
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while getting list from collection.";

                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return origPath;
            }
            catch (InvalidOperationException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while getting list from collection.";

                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return origPath;
            }
        }

        /// <summary>
        ///     Gets the item at index.
        /// </summary>
        /// <returns>The <see cref="System.String" />.</returns>
        /// <param name="index">Index.</param>
        public static string GetItemAt(int index)
        {
            string retVal = null;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                retVal = fileDirName[index];
                return retVal;
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while returning song path.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        /// <summary>
        ///     Get original path index.
        /// </summary>
        /// <param name="origPath"></param>
        /// <returns>Index of original path.</returns>
        public static int GetItemIndex(string origPath)
        {
            var retVal = -1;

            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                retVal = fileDirName.IndexOf(origPath);

                // All OK
                return retVal;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error getting index of this item: " + origPath;

                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error getting index of this item: " + origPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        /// <summary>
        ///     Items the count.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemsCount()
        {
            var cnt = 0;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                cnt = fileDirName.Count;

                // All OK
                return cnt;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while getting count of items contained in the collection.";

                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return cnt;
            }
        }

        /// <summary>
        ///     Removes the item.
        /// </summary>
        /// <returns><c>true</c>, if item was removed, <c>false</c> otherwise.</returns>
        /// <param name="origPath">Original path.</param>
        public static bool RemoveItem(string origPath)
        {
            var retVal = false;

            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                fileDirName.Remove(origPath);

                // All OK
                retVal = true;
                return retVal;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while removing this item: " + origPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while removing this item: " + origPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        /// <summary>
        ///     Removes the item at index.
        /// </summary>
        /// <returns>The <see cref="System.Boolean" />.</returns>
        /// <param name="index">Index.</param>
        public static bool RemoveItemAt(int index)
        {
            var retVal = false;

            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                fileDirName.RemoveAt(index);

                // All OK
                retVal = true;
                return retVal;
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Encountered error removing item at index: " + index;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error removing item at index: " + index;

                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        /// <summary>
        ///     Sorts the collection.
        /// </summary>
        public static void SortCollection()
        {
            fileDirName.Sort();
        }
    }
}