// MusicManagerCurrent
// 
// DisplayFileBrowser.cs
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
using System.Windows.Forms;
using MusicManagerCurrent.ClassesProperties;
using MusicManagerCurrent.Collections;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     This class is used to display the directory browser so as the user can
    ///     select what directory his music is located in. It then checks to see if
    ///     it is a valid directory and if the music directory selected has music
    ///     files in it.
    /// </summary>
    public static class DisplayFileBrowser
    {
        /// <summary>
        ///     Check for # sign to see if this is a valid genre directory.
        /// </summary>
        /// <param name="genreName"></param>
        /// <returns>true if valid genre directory else false.</returns>
        private static bool CheckForValidGenreName(string genreName)
        {
            // read first line in file should be the pound sign if not exit not a
            // valid genre default list backup.
            if (string.Compare(genreName, "#", StringComparison.CurrentCultureIgnoreCase) == 0) return true;
            MyMessages.ErrorMessage = "This is not a valid genre default backup list." + " Exiting operation.";
            MyMessages.ShowInformationMessage(MyMessages.ErrorMessage, MyMessages.NameOfClass);
            return false;

            // All OK
        }

        /// <summary>
        ///     Display FileBrowser to select where to save backup copy of genre
        ///     default list.
        /// </summary>
        /// <returns></returns>
        public static string SaveGenreDefaultListBackup()
        {
            string retVal;

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        var count = GenreDefaultListCollection.ItemCount();

                        for (var i = 0; i < count; i++)
                        {
                            // if first line of file write pound sign then add
                            // first item in collection.
                            if (i == 0) sw.WriteLine("#");
                            sw.WriteLine(GenreDefaultListCollection.GetItemAt(i));
                        }
                    }

                    retVal = sfd.FileName;
                }
                else
                {
                    retVal = string.Empty;
                }
            }

            return retVal;
        }

        /// <summary>
        ///     Get the path to save the play list to.
        /// </summary>
        /// <returns>Path to save the play list at.</returns>
        public static string SavePlayList()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            using (var sfd = new SaveFileDialog
            {
                Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            })
            {
                return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : string.Empty;
            }
        }

        /// <summary>
        ///     Display the file browser so user may select an album directory to
        ///     change delimiters or case.
        /// </summary>
        /// <returns>The path string to the directory selected by the user.</returns>
        public static string SelectAlbumDirectory()
        {
            using (var fdb = new FolderBrowserDialog())
            {
                fdb.Description = "Select album directory to make changes to. ";
                fdb.RootFolder = Environment.SpecialFolder.MyComputer;

                var retVal = fdb.ShowDialog();

                return retVal == DialogResult.OK ? fdb.SelectedPath : string.Empty;
            }
        }

        /// <summary>
        ///     Select the directory to save the play list in.
        /// </summary>
        /// <returns>Path to the play list directory.</returns>
        public static string SelectDirectorySavePlaylist()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            using (var fdb = new FolderBrowserDialog())
            {
                // Set the help text description for the FolderBrowserDialog.
                fdb.Description = "Select the directory to save play list in.";

                // Do not allow the user to create new files via the FolderBrowserDialog.
                fdb.ShowNewFolderButton = false;

                // Default to the My Music folder.
                fdb.RootFolder = Environment.SpecialFolder.MyDocuments;

                var retVal = fdb.ShowDialog();

                return retVal == DialogResult.OK ? fdb.SelectedPath : string.Empty;
            }
        }

        /// <summary>
        ///     Select play list to display.
        /// </summary>
        /// <returns>Path to the play list to be displayed.</returns>
        public static string SelectPlayList()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.SpecialFolder.MyMusic.ToString();
                ofd.Filter = ".mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : string.Empty;
            }
        }

        /// <summary>
        ///     Selects the Directory where the play-list is saved. This will enable
        ///     you to manipulate all play-lists in this directory. Operations on
        ///     multiple play-list such as combining them.
        /// </summary>
        /// <returns>Path to the play list directory.</returns>
        public static string SelectPlaylistDirectory()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            using (var fdb = new FolderBrowserDialog())
            {
                // Set the help text description for the FolderBrowserDialog.
                fdb.Description = "Select play list directory or documents directory.";

                // Do not allow the user to create new files via the FolderBrowserDialog.
                fdb.ShowNewFolderButton = false;

                // Default to the My Music folder.
                fdb.RootFolder = Environment.SpecialFolder.MyDocuments;

                var retVal = fdb.ShowDialog();

                return retVal == DialogResult.OK ? fdb.SelectedPath : string.Empty;
            }
        }

        /// <summary>
        ///     Selects the song file path to be returned.
        /// </summary>
        /// <returns>The song file path.</returns>
        public static string SelectSongFile()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.SpecialFolder.MyMusic.ToString();
                ofd.Filter = ".mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : string.Empty;
            }
        }

        /// <summary>
        ///     Display file browser dialog so user can Selects the top-level music
        ///     directory. Then verify that the user has selected a directory
        ///     containing .mp3 files.
        /// </summary>
        /// <returns>Path to the users music directory</returns>
        public static string SelectToplevelMusicDirectory()
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                using (var fdb = new FolderBrowserDialog())
                {
                    // Set the help text description for the FolderBrowserDialog.
                    fdb.Description = "Select your top level music directory.";

                    // Do not allow the user to create new files via the FolderBrowserDialog.
                    fdb.ShowNewFolderButton = false;

                    // Default to the My Documents folder.
                    fdb.RootFolder = Environment.SpecialFolder.MyComputer;

                    var retVal = fdb.ShowDialog();

                    if (retVal != DialogResult.OK) return string.Empty;
                    UserEnviormentInfoProperties.UserMusicDirectoryPath = fdb.SelectedPath;
                    return fdb.SelectedPath;
                }
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while selecting Music directory. ";
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return string.Empty;
            }
        }

        /// <summary>
        ///     Select the users home directory. This is users directory.
        /// </summary>
        /// <returns>Path to the users home directory. users directory</returns>
        public static string SelectUserHomeDirectory()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            using (var fdb = new FolderBrowserDialog())
            {
                // Set the help text description for the FolderBrowserDialog.
                fdb.Description = "Select your home directory or documents directory.";

                // Do not allow the user to create new files via the FolderBrowserDialog.
                fdb.ShowNewFolderButton = false;

                // Default to the My Music folder.
                fdb.RootFolder = Environment.SpecialFolder.MyComputer;

                var retVal = fdb.ShowDialog();

                if (retVal == DialogResult.OK)
                {
                    UserEnviormentInfoProperties.UserHomeDirectoryPath = fdb.SelectedPath;
                    return fdb.SelectedPath;
                }

                return string.Empty;
            }
        }

        /// <summary>
        ///     If the user has made a back up file then they can restore it from here.
        /// </summary>
        public static void RestoreGenreDefaultListFromBackup()
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                var validate = false;

                GenreDefaultListCollection.ClearCollection();

                using (var ofd = new OpenFileDialog())
                {
                    ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    ofd.FilterIndex = 2;
                    ofd.RestoreDirectory = true;
                    ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    if (ofd.ShowDialog() == DialogResult.OK)
                        using (var sr = new StreamReader(ofd.FileName))
                        {
                            string genreName;
                            while ((genreName = sr.ReadLine()) != null)
                                if (!validate)
                                {
                                    validate = CheckForValidGenreName(genreName);
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(genreName))
                                        GenreDefaultListCollection.AddItem(genreName);
                                }
                        }
                }

                if (GenreDefaultListCollection.ItemCount() <= 0) return;

                MyMessages.QuestionMessage = "This will overwrite your current genre default list."
                                             + " Do you wish to continue.";
                var result = MyMessages.ShowQuestionMessage(MyMessages.QuestionMessage, MyMessages.NameOfClass);
                if (result == DialogResult.Yes) GenreFileReadWrite.WriteGenreTemplateList();
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Not a valid path. Exiting operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Not a valid path. Exiting operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
            }
        }
    }
}