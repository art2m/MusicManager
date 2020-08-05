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

using System;
using System.Collections.Generic;
using System.Reflection;
using MusicManagerCurrent.ClassesProperties;

namespace MusicManagerCurrent.Classes
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
        /// <returns><c>true</c>, if item was added, <c>false</c> otherwise.</returns>
        /// <param name="genreName">Genre name.</param>
        public static bool AddItem(string genreName)
        {
            var bolRetVal = false;
            try
            {
                if (!ContainsItem(genreName)) GenreList.Add(genreName);

                return bolRetVal = true;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Genre Directory Name is invalid and will not be added to the list.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding new genre directory  to this collection.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        /// <summary>
        ///     Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            try
            {
                GenreList.Clear();
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while clearing the collection.";
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
            }
        }

        /// <summary>
        ///     Contains the item.
        /// </summary>
        /// <returns><c>true</c>, if item was contained, <c>false</c> otherwise.</returns>
        /// <param name="genreName">Genre name.</param>
        public static bool ContainsItem(string genreName)
        {
            MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var bolRetVal = GenreList.Contains(genreName);
            return bolRetVal;
        }

        /// <summary>
        ///     Gets all items from collection.
        /// </summary>
        /// <returns>The all items.</returns>
        public static string[] GetAllItems()
        {
            string[] genreNames = null;
            try
            {
                var intCount = GenreList.Count;

                // No genre Folders Found
                if (intCount - 1 < 1) return genreNames;

                genreNames = new string[intCount];
                for (var i = 0; i < intCount; i++) genreNames[i] = GenreList[i];

                // All ok.
                return genreNames;
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while getting list from collection.";
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage, ex.Message);
                return genreNames;
            }
            catch (InvalidOperationException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while getting list from collection.";
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage, ex.Message);
                return genreNames;
            }
        }

        /// <summary>
        ///     Gets the item at the index.
        /// </summary>
        /// <returns>The <see cref="System.String" />.</returns>
        /// <param name="index">Index of item to get.</param>
        public static string GetItemAt(int index)
        {
            try
            {
                return GenreList[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Index invalid unable to locate genre directory name.";
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage, ex.Message);
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Invalid operation unable to return genre directory name.";
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod,
                    MyMessages.ErrorMessage, ex.Message);
                return string.Empty;
            }
        }

        /// <summary>
        ///     Gets the index of the item.
        /// </summary>
        /// <returns>The item index.</returns>
        /// <param name="genreName">Genre name.</param>
        public static int GetItemIndex(string genreName)
        {
            var intIndex = -1;
            try
            {
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                intIndex = GenreList.IndexOf(genreName);
                return intIndex;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error getting Index of this item.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return intIndex;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error getting Index of this item.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return intIndex;
            }
        }

        /// <summary>
        ///     Inserts the item at position and item.
        /// </summary>
        /// <returns>The <see cref="System.Boolean" />.</returns>
        /// <param name="pos">Position to inset the item at.</param>
        /// <param name="item">Insert the item at this index.</param>
        public static bool InsertItemAt(int pos, string item)
        {
            var bolRetVal = false;
            try
            {
                GenreList.Insert(pos, item);
                return bolRetVal = true;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding new genre directory to this collection.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, item);
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while adding new genre directory to this collection.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, item);
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        /// <summary>
        ///     Items the count.
        /// </summary>
        /// <returns>The count.</returns>
        public static int ItemCount()
        {
            MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            return GenreList.Count;
        }

        /// <summary>
        ///     Removes the item.
        /// </summary>
        /// <returns><c>true</c>, if item was removed, <c>false</c> otherwise.</returns>
        /// <param name="genreName">Genre name.</param>
        public static bool RemoveItem(string genreName)
        {
            var bolRetVal = false;
            try
            {
                GenreList.Remove(genreName);
                return bolRetVal = true;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while removing this item.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while removing this item.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, genreName);
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        /// <summary>
        ///     Removes the item at index.
        /// </summary>
        /// <returns>The <see cref="System.Boolean" />.</returns>
        /// <param name="index">Index-of the item to remove.</param>
        public static bool RemoveItemAt(int index)
        {
            var bolRetVal = false;
            try
            {
                if (index < 0) return bolRetVal = true;

                GenreList.RemoveAt(index);
                return bolRetVal = true;
            }
            catch (IndexOutOfRangeException ex)
            {
                MyMessages.ErrorMessage = "Encountered error removing item at Index: ";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, index.ToString());
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
            catch (NullReferenceException ex)
            {
                MyMessages.ErrorMessage = "Encountered error removing item at Index: ";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, index.ToString());
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }

        /// <summary>
        ///     Sorts the collection.
        /// </summary>
        /// <returns><c>true</c>, if collection was sorted, <c>false</c> otherwise.</returns>
        public static bool SortCollection()
        {
            var bolRetVal = false;
            try
            {
                GenreList.Sort();
                return bolRetVal = true;
            }
            catch (InvalidOperationException ex)
            {
                MyMessages.ErrorMessage = "Unable to sort collection.";
                MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return bolRetVal;
            }
        }
    }
}