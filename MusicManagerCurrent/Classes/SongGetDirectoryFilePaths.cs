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

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    /// public class SongFilePaths Loop all Genre Song file paths.
    /// </summary>
    public class SongGetDirectoryFilePaths
    {
        #region Methods Public

        /// <summary>
        /// Check for album subdirectories in the artist directories. If there
        /// are none then this is not a artist directory but a multi artist album.
        /// </summary>
        /// <param name="artistDirPath"></param>
        /// <returns>
        /// 0 = error, 1 = album is in artist position, 2 album is contained in
        /// artist directory.
        /// </returns>
        public static int CheckForAlbumDirectories(string artistDirPath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            // 0 = error, 1 = album is in artist position, 2 album is contained
            // in artist directory.

            if (string.IsNullOrEmpty(artistDirPath)
                || !Directory.Exists(artistDirPath))
            {
                MyMessages.ErrorMessage = "The artist directory path is invalid.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }
            var albums = new List<string>();

            Debug.Assert(artistDirPath != null, "artistDirPath != null");
            var albumPaths = new List<string>(
                Directory.EnumerateDirectories(artistDirPath, "*", SearchOption.TopDirectoryOnly));

            return albumPaths.Count > 0 ? 2 : 1;
        }

        /// <summary>
        /// Fills the collection with songs.
        /// </summary>
        /// <param name="files">array of song paths.</param>
        public static void FillCollectionWithSongs(List<string> files)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            foreach (var songPath in files)
            {
                SongsCollection.AddItem(songPath);
            }
        }

        /// <summary>
        /// Check to make sure there are song files located in the directory or
        /// subdirectory of the dirPath.
        /// </summary>
        /// <param name="dirPath"></param>
        /// <returns>True if song files are found else false.</returns>
        public bool CheckForSongFiles(string dirPath)
        {
            if (string.IsNullOrEmpty(dirPath)
                || !Directory.Exists(dirPath))
            {
                MyMessages.ErrorMessage = "This directory path is invalid.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }

            Debug.Assert(dirPath != null, "dirPath != null");
            var files = new List<string>(Directory.GetFiles(dirPath, "*.mp3", SearchOption.AllDirectories));

            return files.Count > 0;
        }

        /// <summary>
        /// Get all albums contained in a artist directory path and return list.
        /// </summary>
        /// <param name="artistDirPath"></param>
        /// <returns>List of album directories.</returns>
        public List<string> GetAlbumDirectories(string artistDirPath)
        {
            var albums = new List<string>();

            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(artistDirPath)
                || !Directory.Exists(artistDirPath))
            {
                MyMessages.ErrorMessage = "The artist directory path is invalid.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }

            Debug.Assert(artistDirPath != null, "artistDirPath != null");
            var albumPaths = new List<string>(
                Directory.EnumerateDirectories(artistDirPath, "*", SearchOption.TopDirectoryOnly));

            foreach (var albumPath in albumPaths)
            {
                var itemPath = PathOperations.ReverseString(albumPath);

                var albumName = PathOperations.GetNameBeforeFirstSeparator(itemPath);

                albumName = PathOperations.ReverseString(albumName);

                albums.Add(albumPath);
            }

            return albums;
        }

        /// <summary>
        /// Get all Genre directories from music directory. 
        /// Add all Genre directories found to genreDirectoriesCollection. 
        /// </summary>
        public void GetAllGenreDirectories(string musicDirPath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(musicDirPath))
            {
                MyMessages.ErrorMessage = "Not a valid path to music directory.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }

            Debug.Assert(musicDirPath != null, "musicDirPath != null");
            var geneDirectories = new List<string>(
                Directory.EnumerateDirectories(musicDirPath, "*", SearchOption.TopDirectoryOnly));
            
            GenreDirectoryNamesUsersCollection.ClearCollection();
            
            if (geneDirectories.Count <= 0) return;
            foreach (var genrePath in geneDirectories)
            {
                GenreDirectoriesCollection.AddItem(genrePath);
                
                var itemPath = PathOperations.ReverseString(genrePath);

                var genreName = PathOperations.GetNameBeforeFirstSeparator(itemPath);

                genreName = PathOperations.ReverseString(genreName);

                // check and make sure this is a valid genre directory name. There could be other directory
                // types. 
                if (ValidateOperations.ValidateFormatGenreDirectoryName(genreName))
                {
                    GenreDirectoryNamesUsersCollection.AddItem(genreName);
                    GenreFileReadWrite.WriteGenreUsersList();
                }
                
                
            }
        }

        /// <summary>
        /// Get the albums contained in an artist directory.
        /// </summary>
        /// <param name="artistDirPath">The path to the artist directory</param>
        public void GetAllAlbumDirectories(string artistDirPath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(artistDirPath)
                || !Directory.Exists(artistDirPath))
            {
                MyMessages.ErrorMessage = "The artist directory path is invalid.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }

            Debug.Assert(artistDirPath != null, "artistDirPath != null");
            var albumPaths = new List<string>(
                Directory.EnumerateDirectories(artistDirPath, "*", SearchOption.TopDirectoryOnly));

            foreach (var albumPath in albumPaths)
            {
                var itemPath = PathOperations.ReverseString(albumPath);

                var albumName = PathOperations.GetNameBeforeFirstSeparator(itemPath);

                albumName = PathOperations.ReverseString(albumName);

                AlbumNamesCollection.AddItem(albumName);
                AlbumDirectoryDictionaryCollection.AddItem(albumName, albumPath);
            }
        }

        /// <summary>
        /// Get all songs contained in the album. Return a list with all songs.
        /// </summary>
        /// <param name="albumPath">Path to album.</param>
        /// <returns></returns>
        public List<string> GetAllAlbumSongs(string albumPath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(albumPath)
                || !Directory.Exists(albumPath))
            {
                MyMessages.ErrorMessage = "The album directory path is invalid.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }

            Debug.Assert(albumPath != null, "albumPath != null");
            var files = new List<string>(Directory.GetFiles(albumPath, "*.mp3", SearchOption.AllDirectories));
            return files;
        }

        /// <summary>
        /// Retrieve all artist directories in users music collection.
        /// </summary>
        /// <param name="genreDirPath">Path to the genre directory.</param>
        public void GetAllArtistDirectories(string genreDirPath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(genreDirPath)
                || !Directory.Exists(genreDirPath))
            {
                MyMessages.ErrorMessage = "The genre directory path is invalid.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }

            // TODO: finish getting all artist directories.

            Debug.Assert(genreDirPath != null, "genreDirPath != null");

            var artistPaths = new List<string>(
                Directory.EnumerateDirectories(genreDirPath, "*", SearchOption.TopDirectoryOnly));

            foreach (var artistPath in artistPaths)
            {
                var itemPath = PathOperations.ReverseString(artistPath);

                var artistName = PathOperations.GetNameBeforeFirstSeparator(itemPath);

                artistName = PathOperations.ReverseString(artistName);

                ArtistNamesCollection.AddItem(artistName);
                ArtistDirectoryDictionaryCollection.AddItem(artistName, artistPath);
            }
        }

        /// <summary>
        /// Loads the songs.
        /// </summary>
        /// <returns>True if collection fills OK else false.</returns>
        /// <param name="directoryPath">Top directory path.</param>
        public void GetAllSongs(string directoryPath)
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(directoryPath)
                || !Directory.Exists(directoryPath))
            {
                MyMessages.ErrorMessage = "The directory path is invalid.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }

            Debug.Assert(directoryPath != null, "directoryPath != null");
            var files = new List<string>(Directory.GetFiles(directoryPath, "*.mp3", SearchOption.AllDirectories));

            FillCollectionWithSongs(files);
        }

        /// <summary>
        /// Get All artist directories for this genre music return them in a list collection.
        /// </summary>
        /// <param name="genreDirPath"></param>
        /// <returns></returns>
        public List<string> GetArtistDirectories(string genreDirPath)
        {
            var artists = new List<string>();

            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(genreDirPath)
                || !Directory.Exists(genreDirPath))
            {
                MyMessages.ErrorMessage = "The artist directory path is invalid.";
                MyMessages.ShowErrorMessage(MyMessages.ErrorMessage, MyMessages.NameOfMethod);
            }

            Debug.Assert(genreDirPath != null, "genreDirPath != null");
            var artistPaths = new List<string>(
                Directory.EnumerateDirectories(genreDirPath, "*", SearchOption.TopDirectoryOnly));

            foreach (var artistPath in artistPaths)
            {
                var itemPath = PathOperations.ReverseString(artistPath);

                var artistName = PathOperations.GetNameBeforeFirstSeparator(itemPath);

                artistName = PathOperations.ReverseString(artistName);

                artists.Add(artistPath);
            }

            return artists;
        }

        #endregion Methods Public
    }
}
