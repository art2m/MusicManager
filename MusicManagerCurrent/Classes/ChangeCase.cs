#region copyright

// Copyright (c) 2016 art2m Author: art2m <art2m@live.com>
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

#endregion copyright

using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    /// Change the case of genre, artist, album directory names and song title.
    /// </summary>
    public class ChangeCase
    {
        #region METHODS PUBLIC

        /// <summary>
        /// Change Directory name to all lower case characters.
        /// </summary>
        /// <param name="dirName"></param>
        /// <returns>New lower case directory path.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public string DirectoryMakeLowerCaseName(string dirName)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (string.IsNullOrEmpty(dirName))
                {
                    throw new ArgumentNullException();
                }

                dirName = dirName.Trim();

                var newDirName = dirName.ToLowerInvariant();

                var comp = string.Compare(dirName, newDirName, StringComparison.CurrentCultureIgnoreCase);

                return newDirName;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The directory path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The directory path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// Create Make Proper name from current directory name.
        /// </summary>
        /// <returns>
        /// <c>true</c>, if make proper case name was directory, <c>false</c> otherwise.
        /// </returns>
        /// <param name="dirName">Directory path.</param>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public string DirectoryMakeProperCaseName(string dirName)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                dirName = dirName.Trim();

                if (string.IsNullOrEmpty(dirName))
                {
                    throw new ArgumentNullException();
                }

                string newDirPath;
                var parentDirName = new DirectoryInfo(dirName).Parent.FullName;
                var origDirName = new DirectoryInfo(dirName).Name;
                var newDirName = string.Empty;

                var myTI = new CultureInfo("en-US", false).TextInfo;

                var newLowerCase = myTI.ToLower(origDirName);

                newDirName = myTI.ToTitleCase(newLowerCase);

                var comp = string.Compare(origDirName, newDirName, StringComparison.CurrentCultureIgnoreCase);
                if (comp == 0)
                {
                    OriginalDirectoryFilePathsCollection.AddItem(dirName);
                    OriginalDirectoryFileNamesCollection.AddItem(origDirName);

                    newDirPath = Path.Combine(parentDirName, newDirName);
                    SongRecordProperties.NewDirectoryPath = newDirPath;
                    NewDirectoryFilePathsCollection.AddItem(newDirPath);
                    NewDirectoryFileNameCollection.AddItem(newDirName);
                }
                else
                {
                    newDirPath = string.Empty;
                }

                return newDirPath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The directory path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The directory path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "The directory path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// Make directory name upper case.
        /// </summary>
        /// <returns>
        /// <c>true</c>, if make upper case name was directory, <c>false</c> otherwise.
        /// </returns>
        /// <param name="dirName">Directory path.</param>
        /// <exception cref="DirectoryNotFoundException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public string DirectoryMakeUpperCaseName(string dirName)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                dirName = dirName.Trim();

                if (string.IsNullOrEmpty(dirName))
                {
                    throw new ArgumentNullException();
                }

                var parentDirName = new DirectoryInfo(dirName).Parent.FullName;
                var origDirName = new DirectoryInfo(dirName).Name;
                var newDirName = origDirName.ToUpperInvariant();

                var comp = string.Compare(origDirName, newDirName, StringComparison.CurrentCultureIgnoreCase);

                return newDirName;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The directory path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The directory path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "The directory path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// Files the name of the name make lower case.
        /// </summary>
        /// <param name="songTitle">File path.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public string FileMakeLowerCaseName(string songTitle)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                songTitle = songTitle.Trim();

                if (string.IsNullOrEmpty(songTitle))
                {
                    throw new ArgumentNullException();
                }

                var newSongTitle = songTitle.ToLowerInvariant();

                return newSongTitle;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The file path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The file path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// Files the name of the name make proper case.
        /// </summary>
        /// <param name="songTitle">File path.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public string FileMakeProperCaseName(string songTitle)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            songTitle = songTitle.Trim();

            if (string.IsNullOrEmpty(songTitle))
            {
                throw new ArgumentNullException();
            }

            var arrayTitle = songTitle.Split(' ');

            var sb = new StringBuilder();

            var newSongTitle = string.Empty;
            var builder = new StringBuilder();
            builder.Append(newSongTitle);

            foreach (string word in arrayTitle)
            {
                var wordSpace = word + " ";

                var wordCount = 0;

                foreach (char chrLetter in wordSpace)
                {
                    if (wordCount == 0 && char.IsLetter(chrLetter))
                    {
                        sb.Append(chrLetter.ToString().ToUpper());
                    }
                    else if (char.IsWhiteSpace(chrLetter))
                    {
                        sb.Append(" ");
                    }
                    else
                    {
                        sb.Append(chrLetter.ToString().ToLower());
                    }
                    wordCount++;
                }
                builder.Append(sb + string.Empty);
                sb.Clear();
            }
            newSongTitle = builder.ToString();

            return newSongTitle;
        }

        /// <summary>
        /// File Make upper case Name.
        /// </summary>
        /// <param name="songTitle">File path.</param>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public string FileMakeUpperCaseName(string songTitle)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                songTitle = songTitle.Trim();

                if (string.IsNullOrEmpty(songTitle))
                {
                    throw new ArgumentNullException();
                }

                var parentDirPath = new FileInfo(songTitle).DirectoryName;
                var origFileName = Path.GetFileName(songTitle);
                var newFileName = origFileName.ToUpperInvariant();
                string newDirPath;

                var comp = string.Compare(origFileName, newFileName, StringComparison.CurrentCultureIgnoreCase);

                if (comp == 0)
                {
                    OriginalDirectoryFilePathsCollection.AddItem(songTitle);
                    OriginalDirectoryFileNamesCollection.AddItem(origFileName);

                    newDirPath = Path.Combine(parentDirPath, newFileName);
                    NewDirectoryFilePathsCollection.AddItem(newDirPath);
                    NewDirectoryFileNameCollection.AddItem(newFileName);
                }
                else
                {
                    newDirPath = string.Empty;
                }
                return newDirPath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The file path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The file path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "The file path is not valid.";
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return string.Empty;
            }
        }

        #endregion METHODS PUBLIC
    }
}