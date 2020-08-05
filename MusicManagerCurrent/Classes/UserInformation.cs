// MusicManagerCurrent
// 
// UserInformation.cs
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
using System.Text;
using System.Windows.Forms;
using BookListCurrent.Classes;
using MusicManagerCurrent.ClassesProperties;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Holds the home path and name, music directory name and path and user
    ///     name.
    /// </summary>
    public class UserInformation
    {
        /// <summary>
        /// The message box object decleration.
        /// </summary>
        private readonly MyMessageBox _msgBox = new MyMessageBox();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInformation"/> class.
        /// </summary>
        public UserInformation()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     Locates the default music directory.
        /// </summary>
        /// <returns>
        ///     path string to default windows directory else empty string.
        /// </returns>
        public string LocateDefaultMusicDirectory()
        {
            var retVal = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            var validate = new ValidationClass();

            if (!validate.ValidateDirectoryExists(retVal)) retVal = string.Empty;

            SongRecordProperties.MusicDirectoryPath = retVal;
            SongRecordProperties.MusicDirectoryName =
                new DirectoryInfo(UserEnviormentInfoProperties.UserMusicDirectoryPath).Name;

            return retVal;
        }


        /// <summary>
        ///     Display dialog browser for user to locate top level music directory.
        /// </summary>
        /// <returns>
        /// </returns>
        public string FindMusicDirectoryBrowser()
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var musicDirectory = DisplayFileBrowser.SelectToplevelMusicDirectory();
            var validate = new ValidationClass();


            if (!validate.ValidateStringIsNotNull(musicDirectory))
            {
                _msgBox.Msg = "You need to set your music directory.";
                _msgBox.ShowInformationMessageBox();

                return string.Empty;
            }

            var retVal = validate.ValidateDirectoryExists(musicDirectory);

            if (retVal)
            {
                SongRecordProperties.MusicDirectoryPath = UserEnviormentInfoProperties.UserMusicDirectoryPath;
                SongRecordProperties.MusicDirectoryName =
                    new DirectoryInfo(UserEnviormentInfoProperties.UserMusicDirectoryPath).Name;

                return musicDirectory;
            }

            _msgBox.Msg = "Found no music files in this directory. Use browser"
                          + Environment.NewLine + "to select your music directory.";
            _msgBox.ShowErrorMessageBox();
            return string.Empty;
        }

        /// <summary>
        ///     Finds the user default home directory.
        /// </summary>
        /// <exception cref="DirectoryNotFoundException" />
        /// <returns>
        ///     <c>true</c> , if user default home directory was found, <c>false</c>
        ///     otherwise.
        /// </returns>
        public bool FindUserHomeDirectory()
        {
            try
            {
                _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                UserEnviormentInfoProperties.UserHomeDirectoryPath =
                    Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                var directoryPath = UserEnviormentInfoProperties.UserHomeDirectoryPath;

                if (string.IsNullOrEmpty(directoryPath)
                    || !Directory.Exists(directoryPath)) throw new DirectoryNotFoundException();

                return true;
            }
            catch (DirectoryNotFoundException ex)
            {
                _msgBox.Msg = "Unable to locate your home directory. "
                              + "You will need to click on Set location menu and select home to set this.";
                _msgBox.ShowErrorMessageBox();

                return false;
            }
        }

        /// <summary>
        ///     Display file browser for user to find home directory.
        /// </summary>
        /// <exception cref="DirectoryNotFoundException" />
        public void FindUserHomeDirectoryBrowser()
        {
            var validate = new ValidationClass();

            var home = DisplayFileBrowser.SelectUserHomeDirectory();

            if (!validate.ValidateStringIsNotNull(home) || !validate.ValidateStringHasLength(home))
            {
                _msgBox.Msg = "Unable to locate your home directory. "
                              + "You will need to click on Set location menu and select home to set this.";
                _msgBox.ShowErrorMessageBox();
            }


            UserEnviormentInfoProperties.UserHomeDirectoryPath = home;
        }

        /// <summary>
        ///     Finds the name of the user.
        /// </summary>
        /// <returns>
        ///     <c>true</c> , if user name was found, <c>false</c> otherwise.
        /// </returns>
        public bool FindUserName()
        {

            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            UserEnviormentInfoProperties.UserName = Environment.UserName;

            var validate = new ValidationClass();

            return validate.ValidateStringIsNotNull(UserEnviormentInfoProperties.UserName);
        }

        /// <summary>
        ///     Find users default music directory.
        /// </summary>
        /// <exception cref="DirectoryNotFoundException" />
        /// <returns>
        ///     <c>true</c> , if user top-level music directory was found,
        ///     <c>false</c> otherwise.
        /// </returns>
        public bool FindUserTopLevelMusicDirectory()
        {
            try
            {
                _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                UserEnviormentInfoProperties.UserMusicDirectoryPath =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

                if (string.IsNullOrEmpty(UserEnviormentInfoProperties.UserMusicDirectoryPath)) return false;


                if (!Directory.Exists(UserEnviormentInfoProperties.UserHomeDirectoryPath))
                    throw new DirectoryNotFoundException();

                SongRecordProperties.MusicDirectoryPath = UserEnviormentInfoProperties.UserMusicDirectoryPath;

                // Get top level music directory name used to compare to Artist,
                // album and genre directories. To be sure that we are not just
                // getting top level music directory.
                SongRecordProperties.MusicDirectoryName =
                    new DirectoryInfo(SongRecordProperties.MusicDirectoryPath).Name;

                return true;
            }
            catch (DirectoryNotFoundException ex)
            {
                _msgBox.Msg = "Unable to locate your home directory. "
                                          + "You will need to click on Set location menu and select home to set this.";
                _msgBox.ShowErrorMessageBox();
                return false;
            }
        }
    }
}