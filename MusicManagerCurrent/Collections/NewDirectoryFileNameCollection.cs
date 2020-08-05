#region copyright

// Copyright (c) 2016 art2m Author: art2m <art2m@live.com>
//
// This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any
// later version.
//
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the
// implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
// more details.
//
// You should have received a copy of the GNU General Public License along with this program. If not, see <http://www.gnu.org/licenses/>.

#endregion copyright

using System;
using System.Collections.Generic;
using System.Reflection;

namespace MusicManagerCurrent.Collections
{
    /// <summary>
    /// Holds the new directory names user has created.
    /// </summary>
    public static class NewDirectoryFileNameCollection
    {
        #region GLOBAL VARIABLES

        /// <summary>
        /// List array to hold all the songs contained in Vocal music collection.
        /// </summary>
        private static readonly List<string> fileDirName = new List<string>();

        #endregion GLOBAL VARIABLES

        #region METHODS PUBLIC

        /// <summary>
        /// Add the new path.
        /// </summary>
        /// <param name="newPath"></param>
        public static void AddItem(string newPath)
        {
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                fileDirName.Add(newPath);
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding path to this collection: " + newPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding path to this collection: " + newPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage,
                    ex.Message);
            }
        }

        /// <summary>
        /// public static void ClearCollection() Clears the array.
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
        /// Check if item contained in the collection.
        /// </summary>
        /// <param name="newPath"></param>
        /// <returns>True if found else false.</returns>
        public static bool ContainsItem(string newPath)
        {
            var retVal = false;

            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                retVal = fileDirName.Contains(newPath);

                // All OK
                retVal = true;
                return retVal;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while checking for this item: " + newPath;

                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while checking for this item: " + newPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        /// <summary>
        /// Gets all items.
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
                if ((cnt - 1) < 1)
                {
                    return origPath;
                }

                origPath = new string[cnt];

                for (int i = 0; i < cnt; i++)
                {
                    origPath[i] = fileDirName[i];
                }

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
        /// Gets the item at index.
        /// </summary>
        /// <returns>The <see cref="System.String"/>.</returns>
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
        /// Get new path index.
        /// </summary>
        /// <param name="newPath"></param>
        /// <returns>Returns the index of new path.</returns>
        public static int GetItemIndex(string newPath)
        {
            var retVal = -1;

            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                retVal = fileDirName.IndexOf(newPath);

                // All OK
                return retVal;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error getting index of this item: " + newPath;

                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error getting index of this item: " + newPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        /// <summary>
        /// Items the count.
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
        /// Remove new path.
        /// </summary>
        /// <param name="newPath"></param>
        /// <returns>True if new path removed else false.</returns>
        public static bool RemoveItem(string newPath)
        {
            var retVal = false;

            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                fileDirName.Remove(newPath);

                // All OK
                retVal = true;
                return retVal;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while removing this item: " + newPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while removing this item: " + newPath;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        /// <summary>
        /// Removes the item at index.
        /// </summary>
        /// <returns>The <see cref="System.Boolean"/>.</returns>
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
                MyMessages.ErrorMessage = "Encountered error removing item at index: " + index.ToString();
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error removing item at index: " + index.ToString();

                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        #endregion METHODS PUBLIC
    }
}