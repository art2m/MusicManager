#region Copyright

// ValidateOperations.cs
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

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     public class ValidateOperations Validate user music directory.
    /// </summary>
    public static class ValidateOperations
    {
        #region Method Public

        /// <summary>
        ///     Validates the destination file exists.
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if destination file exists was validated, <c>false</c> otherwise.
        /// </returns>
        /// <param name="filePath">File path.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool ValidateDestinationFileExists(string filePath)
        {
            var sb = new StringBuilder();

            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null) MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException();

                if (File.Exists(filePath))
                {
                    sb.Append("A file with the destination name all ready exists.");
                    sb.Append(filePath);
                    sb.Append("Do you wish to delete this existing file.");
                    MyMessages.QuestionMessage = sb.ToString();
                    var rspAns = MyMessages.ShowQuestionMessageBox();

                    if (rspAns == DialogResult.No)
                    {
                        MyMessages.InformationMessage = "Canceling this operation. The file will not be saved.";
                        MyMessages.ShowInformationMessageBox();
                        return false;
                    }
                    File.Delete(filePath);
                }
                return true;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Source file path is null.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Source file path is not valid.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate this file.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Validates the music directory.
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if music directory was validated, <c>false</c> otherwise.
        /// </returns>
        /// <param name="directoryPath">Directory path.</param>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static bool ValidateMusicDirectory(string directoryPath)
        {
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null) MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (string.IsNullOrEmpty(directoryPath)
                    || !Directory.Exists(directoryPath)) throw new DirectoryNotFoundException();
                var songFiles = Directory.EnumerateFiles(directoryPath, "*.mp3", SearchOption.AllDirectories);

                var count = songFiles.Count();

                return count > 0;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Source file path is null.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Source file path is not valid.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate this directory: " + directoryPath;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        /// make sure the Genre name is proceeded with various-GenreName.
        /// </summary>
        /// <returns>True if OK else false.</returns>
        public static bool ValidateFormatGenreDirectoryName(string genreDirName)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            const string various = "Various";

            Debug.Assert(
                genreDirName != string.Empty || genreDirName != null, "Genre direcory name is " + "empty or null");

            if (string.IsNullOrEmpty(genreDirName)) return false;

            if (genreDirName.IndexOf("-", StringComparison.Ordinal) <= 0) return false;

            var words = genreDirName.Split('-');

            return string.Equals(words[0], various, StringComparison.CurrentCulture);
        }

        #endregion Method Public
    }
}
