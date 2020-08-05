// BookListCurrent
//
// ValidationClass.cs
//
// art2m
//
// art2m
//
// 07    20   2020
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

using System.IO;
using System.Reflection;
using BookListCurrent.Classes;
using JetBrains.Annotations;
using MusicManagerCurrent.ClassesProperties;


namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Validates data.
    /// </summary>
    public class ValidationClass
    {
        private readonly MyMessageBox _msgBox = new MyMessageBox();

        private readonly MyMessages _myMsg = new MyMessages();

        /// <summary>
        ///     Initializes members of the <see cref="ValidationClass" /> class.
        /// </summary>
        public ValidationClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;
        }

        public bool IndexGreaterThanZeroLessThenCollectionCount(int index, int count)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (index < 0)
            {
                this._msgBox.Msg = this._myMsg.MessageIndexLessThanZero;
                this._msgBox.ShowErrorMessageBox();
                return false;
            }

            if (index < count) return true;

            this._msgBox.Msg = this._myMsg.MessageIndexGraterThanCollectionCount;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }


        /// <summary>
        ///     Validate if book is formatted all ready. So user can pick another
        ///     book to be formatted.
        /// </summary>
        /// <param name="bookInfo">
        ///     The string containing book title to be formatted.
        /// </param>
        /// <returns>
        ///     True if book is formatted else false.
        /// </returns>
        public bool ValidateBookNotSeriesIsFormatted(string bookInfo)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(bookInfo)) return false;
            if (!this.ValidateStringHasLength(bookInfo)) return false;

            // if formatted will contain '[*]';
            if (bookInfo.Contains("[*]"))
            {
                this._msgBox.Msg = this._myMsg.MessageBookTitleIsAllReadyFormatted;
                this._msgBox.ShowInformationMessageBox();
                return true;
            }

            this._msgBox.Msg = this._myMsg.MessageBookTitleIsNotFormatted;
            this._msgBox.ShowInformationMessageBox();
            return false;
        }

        /// <summary>
        ///     Check for parentheses around the book series name. If found the book
        ///     is formatted correctly.
        /// </summary>
        /// <param name="bookInfo">
        ///     Contains the series name to check for formatted.
        /// </param>
        /// <returns>
        ///     True if formatted else false.
        /// </returns>
        public bool ValidateBookSeriesIsFormatted(string bookInfo)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(bookInfo)) return false;
            if (!this.ValidateStringHasLength(bookInfo)) return false;

            // if string contains '()' around the series name then it has all ready been formatted.
            if (bookInfo.Contains("(") && bookInfo.Contains(")"))
            {
                this._msgBox.Msg = this._myMsg.MessageBookSeriesIsAllReadyFormatted;
                this._msgBox.ShowInformationMessageBox();
                return true;
            }

            this._msgBox.Msg = this._myMsg.MessageBookTitleIsNotFormatted;
            this._msgBox.ShowInformationMessageBox();
            return false;
        }

        /// <summary>
        ///     Validate that <paramref name="dirPath" /> contains a valid directory
        ///     path.
        /// </summary>
        /// <param name="dirPath">The directory path.</param>
        /// <returns>
        ///     If directory exists then <see langword="true" /> else false.
        /// </returns>
        public bool ValidateDirectoryExists([NotNull] string dirPath)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(dirPath)) return false;
            if (!this.ValidateStringHasLength(dirPath)) return false;

            if (Directory.Exists(dirPath)) return true;

            this._msgBox.Msg = this._myMsg.MessageDirectoryDoesNotExist + dirPath;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        ///     Validates the file exists.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="msg">If true and file does not exist return message and false.
        ///  Else return just false and no message.</param>
        /// <returns>
        ///     True if exists else false.
        /// </returns>
        public bool ValidateFileExists(string filePath, bool msg)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(filePath)) return false;
            if (!this.ValidateStringHasLength(filePath)) return false;

            if (File.Exists(filePath)) return true;
            // used to decide if to return message below or not.
            if (!msg) return false;


            this._msgBox.Msg = this._myMsg.MessageFileDoesNotExist + filePath;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        ///     Validates the string has length not an empty string.
        /// </summary>
        /// <param name="value">The string to be checked..</param>
        /// <returns>
        ///     If string has length <see langword="true" /> else false.
        /// </returns>
        public bool ValidateStringHasLength(string value)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(value)) return false;

            value = value.Trim();

            if (value.Length != 0) return true;

            this._msgBox.Msg = this._myMsg.MessageStringIsEmpty;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        ///     Validates the string is not null.
        /// </summary>
        /// <param name="value">
        ///     The string to be <see langword="checked" /> for
        ///     <see langword="null" /> value.
        /// </param>
        /// <returns>
        ///     True if not <see langword="null" /> else false.
        /// </returns>
        public bool ValidateStringIsNotNull(string value)
        {
            if (value != null) return true;

            this._msgBox.Msg = this._myMsg.MessageStringIsNullString;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        /// Check that value is not null and has value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns> true if not null and not empty string else false.</returns>
        public bool ValidateStringNotNullHasLength([NotNull] string value)
        {
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if ((this.ValidateStringIsNotNull(value)) && (this.ValidateStringHasLength(value))) return true;
            return false;
        }
    }
}