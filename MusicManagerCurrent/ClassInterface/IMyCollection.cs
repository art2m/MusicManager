// MusicManagerCurrent
// 
// IMyCollection.cs
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

namespace BookListCurrent.ClassInterface
{
    /// <summary>
    ///     Defines the <see cref="IMyCollection" />.
    /// </summary>
    public interface IMyCollection
    {
        /// <summary>
        ///     The AddItem.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        bool AddItem(string value);

        /// <summary>
        ///     Fill collection from an array
        /// </summary>
        /// <param name="fileArray"></param>
        /// <returns>True if array filled else false.</returns>
        bool AddArray(string[] fileArray);

        /// <summary>
        ///     The ClearCollection.
        /// </summary>
        void ClearCollection();

        /// <summary>
        ///     The ContainsItem.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        bool ContainsItem(string value);

        /// <summary>
        ///     Get All Items
        /// </summary>
        /// <returns>List containing all items.</returns>
        List<string> GetAllItems();

        /// <summary>
        ///     The GetItemAt.
        /// </summary>
        /// <param name="index">The index<see cref="int" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        string GetItemAt(int index);

        /// <summary>
        ///     The GetItemIndex.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="int" />.</returns>
        int GetItemIndex(string value);

        /// <summary>
        ///     The ItemsCount.
        /// </summary>
        /// <returns>The <see cref="int" />.</returns>
        int ItemsCount();

        /// <summary>
        ///     The RemoveItem.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        bool RemoveItem(string value);

        /// <summary>
        ///     The RemoveItemAt.
        /// </summary>
        /// <param name="index">The index<see cref="int" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        bool RemoveItemAt(int index);

        /// <summary>
        ///     The SortCollection.
        /// </summary>
        void SortCollection();
    }
}