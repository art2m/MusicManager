// MusicDirectoryLoops.cs // Author: art2m <art2m@live.com> // Copyright (c) 2016
// art2m // This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by the Free
// Software Foundation, either version 3 of the License, or (at your option) any
// later version. // This program is distributed in the hope that it will be
// useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General
// Public License for more details. // You should have received a copy of the GNU
// General Public License along with this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;
using System.Reflection;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    /// Music directory loops. This class contains all music directory and file
    /// loops. There are list directories or files loops, search directories or
    /// file loops.
    /// </summary>
    public class MusicDirectoryLoops
    {
        
        //TODO - Possibly may not need to use this class so check for removal often.
        #region Fields

        private bool loadAllSongs = false;
        private bool loadGenreWorkingDirectory = false;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initialize
        /// </summary>
        public MusicDirectoryLoops()
        {
            MyMessages.NameOfClass = MethodBase.GetCurrentMethod().DeclaringType.Name;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Get all song paths from user top level music directory.
        /// </summary>
        public void GetAllSongPaths()
        {
            var topDirectoryPath = UserEnviormentInfoProperties.UserMusicDirectoryPath;
            LoadAllSongsLoop(topDirectoryPath);
        }

        /// <summary>
        /// Loads all songs loop. This loop will step threw the top level music
        /// directory and all sub directories looking for any .mp3 song files. It
        /// then calls
        /// </summary>
        /// <returns>
        /// <c>true</c>, if all songs loop was loaded, <c>false</c> otherwise.
        /// </returns>
        /// <param name="topDirectoryPath">Top directory path.</param>
        public bool LoadAllSongsLoop(string topDirectoryPath)
        {
            var retVal = false;
            var directoryPathNotFound = string.Empty;

            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;
                loadAllSongs = true;
                loadGenreWorkingDirectory = false;

                // Check for files in the top directory path.
                retVal = CheckDirectoryForFiles(topDirectoryPath);

                // Check for mp3 files in sub directories.
                foreach (string directoryPath in Directory.GetDirectories(topDirectoryPath))
                {
                    retVal = CheckDirectoryForFiles(directoryPath);

                    if (!retVal)
                    {
                        LoadAllSongsLoop(directoryPath);
                    }
                }

                return retVal;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "This directory path is incorrect. No directory was found.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, directoryPathNotFound);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "This directory path is Invalid due to its length.";

                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (IOException ex)
            {
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                     ex.Message);
                return retVal;
            }
        }

        /// <summary>
        /// Load all songs found in this genre directory.
        /// </summary>
        /// <param name="genreDirectoryPath"></param>
        /// <returns></returns>
        public bool LoadGenreWorkingDirectorySongFiles(string genreDirectoryPath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            loadAllSongs = false;
            loadGenreWorkingDirectory = true;

            // Check for song files in the top directory.
            var retVal = CheckDirectoryForFiles(genreDirectoryPath);

            foreach (string genreDirectory in Directory.GetDirectories(genreDirectoryPath))
            {
                retVal = CheckDirectoryForFiles(genreDirectory);

                if (!retVal)
                {
                    LoadGenreWorkingDirectorySongFiles(genreDirectory);
                }
            }

            // All OK
            retVal = true;
            return retVal;
        }

        /// <summary>
        /// Start searching for genre directory songs.
        /// </summary>
        public void StartGenreWorkingDirectorySongFilesLoop()
        {
           //TODO remove comment lines.  var retVal = LoadAllSongsLoop(PlaylistInfoProperties.WorkingPlaylistSourcePath);

            if (retVal)
            {
                // test
            }
            else
            {
                // test
            }
        }

        /// <summary>
        /// Checks the directory for files.
        /// </summary>
        /// <returns>
        /// <c>true</c>, if directory for files was checked, <c>false</c> otherwise.
        /// </returns>
        /// <param name="directoryPath">Directory path.</param>
        private bool CheckDirectoryForFiles(string directoryPath)
        {
            var retVal = false;
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                var getPaths = Directory.GetFiles(directoryPath);

                var pathLength = getPaths.Length;

                if (pathLength > 0)
                {
                    retVal = FillCollectionWithSongs(getPaths);
                }

                // Return false no files found;
                return retVal;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "This directory path is Invalid due to its length.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, directoryPath);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "This directory path is incorrect. No directory was found.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, directoryPath);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have authorization to access this directory.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, directoryPath);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        /// <summary>
        /// Fills the collection with songs. Add all of the songs found in the
        /// users music collection to SongsCollection class.
        /// </summary>
        /// <returns>
        /// <c>true</c>, if collection with songs was filled, <c>false</c> otherwise.
        /// </returns>
        /// <param name="songPaths">Song paths.</param>
        private bool FillCollectionWithSongs(string[] songPaths)
        {
            var retVal = false;
            var songPathNotFound = string.Empty;
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                foreach (string songPath in songPaths)
                {
                    songPathNotFound = songPath;
                    var compMp3 = -1;
                    var fifo = new FileInfo(songPath);

                    compMp3 = string.Compare(fifo.Extension, ".mp3", StringComparison.OrdinalIgnoreCase);

                    // If .mp3 music file add it to the collection.
                    if (compMp3 == 0)
                    {
                        if (!File.Exists(songPath))
                        {
                            MyMessages.ErrorMessage = "Invalid file path. This will not be added to the collection.";
                            MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                            MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, songPath);
                            MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfClass);
                        }

                        if (loadAllSongs)
                        {
                            SongsCollection.AddItem(songPath);
                        }
                    }
                    else if (loadGenreWorkingDirectory)
                    {
                        SongsCollection.AddItem(songPath);
                        SongsCollection.AddItem(songPath);
                    }
                }

                // All OK
                retVal = true;
                return retVal;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have authorization to access this directory.";
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, Environment.NewLine);
                MyMessages.ErrorMessage = string.Concat(MyMessages.ErrorMessage, songPathNotFound);
                MyMessages.BuildErrorString(MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage,
                    ex.Message);
                return retVal;
            }
        }

        #endregion Methods
    }
}
