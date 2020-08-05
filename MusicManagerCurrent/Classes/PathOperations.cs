// MusicManagerCurrent
// 
// PathOperations.cs
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
using System.IO;
using System.Text;
using MusicManagerCurrent.ClassesProperties;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Path operations.
    /// </summary>
    public class PathOperations
    {
        /// <summary>
        ///     used to get first directory name after string reversal.
        /// </summary>
        /// <param name="itemPath"></param>
        /// <returns>first directory name in reverse.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string GetNameBeforeFirstSeparator(string itemPath)
        {
            if (string.IsNullOrEmpty(itemPath))
            {
                MyMessages.ErrorMessage = "The path string is null or empty.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
                return string.Empty;
            }

            var index = itemPath.IndexOf(Path.DirectorySeparatorChar);
            var sb = new StringBuilder();

            for (var i = 0; i < index; i++) sb.Append(itemPath[i]);

            return sb.ToString();
        }

        /// <summary>
        ///     Reverse the string order used for finding the last directory name.
        /// </summary>
        /// <param name="itemPath"></param>
        /// <returns>The reverse of the string passed into it.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string ReverseString(string itemPath)
        {
            if (string.IsNullOrEmpty(itemPath))
            {
                MyMessages.ErrorMessage = "The path string is null or empty.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
                return string.Empty;
            }

            var charArray = itemPath.ToCharArray();

            Array.Reverse(charArray);

            var newRevString = new string(charArray);

            return newRevString;
        }

        /// <summary>
        ///     Splits the original song path by getting parent.
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if original song path by getting parent was split,
        ///     <c>false</c> otherwise.
        /// </returns>
        /// <param name="songPath">Song path.</param>
        /// <exception cref="FileNotFoundException"></exception>
        public int SplitOriginalSongPathByGettingParent(string songPath)
        {
            var val = 0;

            SongRecordProperties.SongFilePath = string.Empty;

            if (string.IsNullOrEmpty(songPath)
                || !File.Exists(songPath))
            {
                MyMessages.ErrorMessage = "The path string is null, empty or invalid file path.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
                return -1;
            }

            SongRecordProperties.SongTitle = Path.GetFileNameWithoutExtension(songPath);
            SongRecordProperties.SongFilePath = songPath;
            SongRecordProperties.SongExtension = Path.GetExtension(songPath);

            var directoryInfo = new FileInfo(songPath).Directory;
            if (directoryInfo != null)
            {
                SongRecordProperties.AlbumDirectoryName = directoryInfo.Name;

                SongRecordProperties.AlbumDirectoryPath = directoryInfo.FullName;
            }

            SongRecordProperties.RootPathDrive = Path.GetPathRoot(songPath);

            var directoryPath = new FileInfo(songPath).DirectoryName;

            if (string.IsNullOrEmpty(directoryPath)) return -1;

            var dirInfo = new DirectoryInfo(SongRecordProperties.AlbumDirectoryPath);

            if (dirInfo.Parent == null) return val;
            SongRecordProperties.ArtistDirectoryName = dirInfo.Parent.Name;

            SongRecordProperties.ArtistDirectoryPath = dirInfo.Parent.FullName;

            val = SongGetDirectoryFilePaths.CheckForAlbumDirectories(SongRecordProperties.ArtistDirectoryPath);

            if (val == 1)
            {
                SongRecordProperties.ArtistDirectoryName = string.Empty;
                SongRecordProperties.ArtistDirectoryPath = string.Empty;

                SongRecordProperties.GenreDirectoryName = dirInfo.Parent.Name;
                SongRecordProperties.GenreDirectoryPath = dirInfo.Parent.FullName;

                var parent = new DirectoryInfo(directoryPath).Parent;
                if (parent != null)
                {
                    directoryPath = parent.FullName;

                    dirInfo = new DirectoryInfo(directoryPath);
                    if (dirInfo.Parent != null) SongRecordProperties.MusicDirectoryName = dirInfo.Parent.Name;
                }
            }
            else if (val == 2)
            {
                SongRecordProperties.ArtistDirectoryPath = dirInfo.Parent.FullName;

                var info = new DirectoryInfo(directoryPath).Parent;
                if (info != null)
                {
                    directoryPath = info.FullName;

                    dirInfo = new DirectoryInfo(directoryPath);

                    if (dirInfo.Parent != null)
                    {
                        SongRecordProperties.GenreDirectoryName = dirInfo.Parent.Name;
                        SongRecordProperties.GenreDirectoryPath = dirInfo.Parent.FullName;
                        directoryPath = info.FullName;

                        dirInfo = new DirectoryInfo(directoryPath);
                        if (dirInfo.Parent != null)
                        {
                            SongRecordProperties.MusicDirectoryName = dirInfo.Parent.Name;
                            SongRecordProperties.MusicDirectoryPath = dirInfo.Parent.FullName;
                        }
                    }
                }
            }

            return val;
        }

        /// <summary>
        ///     Compares the name of the genre name to current directory. Check to
        ///     see if the current directory matches the genre directory name. Some
        ///     multiple artist Cd's do not have artist directory. Compare to keep
        ///     from using genre name as artist name.
        /// </summary>
        /// <returns>True if valid artist directory name else false.</returns>
        /// <param name="directoryName">Directory name.</param>
        private bool CompareGenreNameToCurrentDirectoryName(string directoryName)
        {
            if (string.IsNullOrEmpty(directoryName))
            {
                MyMessages.ErrorMessage = "The directory name is null, or empty";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }

            var cnt = GenreDirectoryNamesUsersCollection.ItemCount();

            for (var i = 0; i < cnt; i++)
            {
                var comp = string.Compare(
                    GenreDirectoryNamesUsersCollection.GetItemAt(i), directoryName,
                    StringComparison.CurrentCultureIgnoreCase);

                if (comp == 0) return true;
            }

            return false;
        }
    }
}