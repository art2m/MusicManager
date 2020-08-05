// MusicManagerCurrent
// 
// GenreFileReadWrite.cs
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
using System.Reflection;
using MusicManagerCurrent.ClassesProperties;
using MusicManagerCurrent.Collections;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Read write genre file.
    /// </summary>
    public static class GenreFileReadWrite
    {
        /// <summary>
        ///     Creates the new genre user list. If there is not GenreUserList. Then
        ///     create one.
        /// </summary>
        private static void CreateNewGenreUserList()
        {
            var directoryName = GenreFileItems.GetGenreUserTemplateListDirectory();
            var userListName = GenreFileItems.GetFileNameOfGenreUserList();

            var genreDirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            genreDirPath = Path.Combine(genreDirPath, directoryName);

            var dirCreate = new DirectoryFileCopyMoveDelete();

            if (!Directory.Exists(genreDirPath)) DirectoryFileCopyMoveDelete.CreateNewDirectory(genreDirPath);

            var genreFilePath = Path.Combine(genreDirPath, userListName);

            if (!File.Exists(genreFilePath)) DirectoryFileCopyMoveDelete.CreateNewFile(genreDirPath);
        }

        /// <summary>
        ///     Reads the genre template list. Used to read in the list of genre
        ///     directories the user has and to create, change and add to the genre
        ///     directories list. The list is found at: /home/user-name/.local/share/MusicManager/Genre-Template-List
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if genre template list was read, <c>false</c> otherwise.
        /// </returns>
        public static bool ReadGenreTemplateList()
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                var directoryName = GenreFileItems.GetGenreUserTemplateListDirectory();
                var templateListName = GenreFileItems.GetFileNameOfGenreTemplateList();

                var genreFilePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                genreFilePath = Path.Combine(genreFilePath, directoryName);
                genreFilePath = Path.Combine(genreFilePath, templateListName);

                // Read the file and display it line by line.
                using (var genreSr = new StreamReader(genreFilePath))
                {
                    string genreName;
                    while ((genreName = genreSr.ReadLine()) != null)
                        if (!string.IsNullOrEmpty(genreName))
                            GenreDefaultListCollection.AddItem(genreName);

                    GenreDefaultListCollection.SortCollection();

                    // All OK
                    return true;
                }
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate this file. Possibly it has not been created yet.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Reads the genre users list. Fill the
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool ReadGenreUsersList(string filePath)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (!File.Exists(filePath))
                {
                    CreateNewGenreUserList();
                    return false;
                }

                // Read the file and display it line by line.
                using (var sr = new StreamReader(filePath))
                {
                    string genreName;
                    while ((genreName = sr.ReadLine()) != null)
                    {
                        GenreDirectoryNamesUsersCollection.AddItem(genreName);
                        GenreDirectoryNamesUsersCollection.SortCollection();
                    }
                }

                // All OK
                return true;
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate this file. Possibly it has not been created yet.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Writes the genre template list.
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if genre template list was write, <c>false</c> otherwise.
        /// </returns>
        public static bool WriteGenreTemplateList()
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                var directoryName = GenreFileItems.GetGenreUserTemplateListDirectory();
                var templateListName = GenreFileItems.GetFileNameOfGenreTemplateList();

                // var genreFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var genreFilePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                genreFilePath = Path.Combine(genreFilePath, directoryName);
                genreFilePath = Path.Combine(genreFilePath, templateListName);

                var count = GenreDefaultListCollection.ItemCount();

                using (var sw = new StreamWriter(genreFilePath))
                {
                    for (var i = 0; i < count; i++)
                    {
                        var genreName = GenreDefaultListCollection.GetItemAt(i);
                        sw.WriteLine(genreName);
                    }
                }

                return true;
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to find file.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while writing to file. Operation canceled.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Writes the genre directories contained in the users music directory
        ///     tree to File. These are the genre directories the user actually has.
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if genre users list was written, <c>false</c> otherwise.
        /// </returns>
        public static bool WriteGenreUsersList()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var directoryName = GenreFileItems.GetApplicationDirectory();
            var userListName = GenreFileItems.GetFileNameOfGenreUserList();

            var genreFilePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            genreFilePath = Path.Combine(genreFilePath, directoryName);
            genreFilePath = Path.Combine(genreFilePath, userListName);

            var count = GenreDirectoryNamesUsersCollection.ItemCount();

            if (File.Exists(genreFilePath))
                if (count < 1)
                {
                    MyMessages.InformationMessage = "There are no genre directories to save to file."
                                                    + Environment.NewLine + "Exiting operation.";
                    MyMessages.ShowInformationMessageBox();
                    return false;
                }

            using (var genreStreamWriter = new StreamWriter(genreFilePath))
            {
                for (var i = 0; i < count; i++)
                {
                    var genreName = GenreDirectoryNamesUsersCollection.GetItemAt(i);
                    genreStreamWriter.WriteLine(genreName);
                }

                if (!File.Exists(genreFilePath)
                    || new FileInfo(genreFilePath).Length == 0) return true;
                MyMessages.InformationMessage = "users genre list has been created and saved.";
                MyMessages.ShowInformationMessage(MyMessages.InformationMessage, MyMessages.NameOfMethod);
            }

            return true;
        }
    }
}