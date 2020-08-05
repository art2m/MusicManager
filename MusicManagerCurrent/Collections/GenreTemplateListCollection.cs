// GenreNamesList.cs
//
// Author: art2m <art2m@live.com>
//
// Copyright (c) 2016 art2m
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

using System;
using System.Collections.Generic;
using System.Reflection;

namespace MusicManagerCurrent.Collections
{
    /// <summary>
    /// Genre template list collection.
    /// </summary>
    public static class GenreTemplateListCollection
    {
        #region GLOBAL VARIABLES

        /// <summary>
        /// The genre list.
        /// </summary>
        private static readonly List<string> GenreList = new List<string>();

        #endregion GLOBAL VARIABLES

        #region Methods Public

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <returns><c>true</c>, if item was added, <c>false</c> otherwise.</returns>
        /// <param name="genreName">Genre name.</param>
        public static bool AddItem(string genreName)
        {
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                    MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (!ContainsItem(genreName))
                {
                    GenreList.Add(genreName);
                }
                else
                {
                   return false;
                }

                return true;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding new song path to this collection: ";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding new song path to this collection: ";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            GenreList.Clear();
        }

        
        /// <summary>
        /// Gets all items.
        /// </summary>
        /// <returns>The all items.</returns>
        public static string[] GetAllItems()
        {
            string[] genreNames = null;
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                    MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                var intCount = GenreList.Count;

                // No genre Folders Found
                if ((intCount - 1) < 1)
                {
                    return new string[0];
                }

                genreNames = new string[intCount];
                for (var i = 0; i < intCount; i++)
                {
                    genreNames[i] = GenreList[i];
                }

                // All OK.
                return genreNames;
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while getting list from collection.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return genreNames;
            }
            catch (InvalidOperationException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while getting list from collection.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return genreNames;
            }
        }

        /// <summary>
        /// Gets the item at index.
        /// </summary>
        /// <returns>The <see cref="System.String"/>.</returns>
        /// <param name="index">Index of item to get.</param>
        public static string GetItemAt(int index)
        {
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                    MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                return GenreList[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Index invalid unable to locate genre directory name.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Invalid operation unable to return genre directory name.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the index of the item.
        /// </summary>
        /// <returns>The item index.</returns>
        /// <param name="genreName">Genre name.</param>
        public static int GetItemIndex(string genreName)
        {
            var intIndex = -1;
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                    MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                intIndex = GenreList.IndexOf(genreName);

                // All OK
                return intIndex;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error getting Index of this item.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return intIndex;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error getting Index of this item.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return intIndex;
            }
        }

        /// <summary>
        /// Inserts the item at position and item.
        /// </summary>
        /// <returns>The <see cref="System.Boolean"/>.</returns>
        /// <param name="pos">Position.</param>
        /// <param name="item">Item to be inserted.</param>
        public static bool InsertItemAt(int pos, string item)
        {
            var bolRetVal = false;
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                    MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                GenreList.Insert(pos, item);
                return bolRetVal = true;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding new genre directory to this collection.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, item);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding new genre directory to this collection.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, item);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        /// <summary>
        /// Count of items.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemCount() => GenreList.Count;

        /// <summary>
        /// Removes the item.
        /// </summary>
        /// <returns><c>true</c>, if item was removed, <c>false</c> otherwise.</returns>
        /// <param name="genreName">Genre name.</param>
        public static bool RemoveItem(string genreName)
        {
            var bolRetVal = false;
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                    MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                GenreList.Remove(genreName);
                return bolRetVal = true;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while removing this item.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while removing this item.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        /// <summary>
        /// Removes the item at index.
        /// </summary>
        /// <returns>The <see cref="System.Boolean"/>.</returns>
        /// <param name="index">Index of item to remove.</param>
        public static bool RemoveItemAt(int index)
        {
            var bolRetVal = false;
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                    MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                GenreList.RemoveAt(index);
                return bolRetVal = true;
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Encountered error removing item at Index: ";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, index.ToString());
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error removing item at Index: ";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, index.ToString());
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
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                    MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                GenreList.Sort();
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

        #endregion Method Public

        #region Method Private

        /// <summary>
        /// Contains the item.
        /// </summary>
        /// <returns><c>true</c>, if item was contained, <c>false</c> otherwise.</returns>
        /// <param name="genreName">Genre name.</param>
        private static bool ContainsItem(string genreName)
        {
            
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null)
                    MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                return GenreList.Contains(genreName);
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Genre Directory Name is invalid and will not be added to the list.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return false;
            }

            #endregion Method Private
        }

    }
}