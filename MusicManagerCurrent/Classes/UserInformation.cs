#region Copyright

// UserInformation.cs
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
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Holds the home path and name, music directory name and path and user name.
    /// </summary>
    public static class UserInformation
    {
        #region Methods Public

        /// <summary>
        ///     Display dialog browser for user to locate top level music directory.
        /// </summary>
        /// <returns></returns>
        public static void FindMusicDirectoryBrowser()
        {
            var musicDirectory = DisplayFileBrowser.SelectToplevelMusicDirectory();

            if (string.IsNullOrEmpty(musicDirectory))
            {
                MyMessages.InformationMessage = "You need to set your music directory.";
                MyMessages.ShowInformationMessageBox();
            }
            else
            {
                var retVal = ValidateOperations.ValidateMusicDirectory(musicDirectory);

                if (retVal)
                {
                    SongRecordProperties.MusicDirectoryPath = UserEnviormentInfoProperties.UserMusicDirectoryPath;
                    SongRecordProperties.MusicDirectoryName =
                        new DirectoryInfo(UserEnviormentInfoProperties.UserMusicDirectoryPath).Name;
                }
                else
                {
                    MyMessages.ErrorMessage = "Found no music files in this directory. Use browser"
                                              + Environment.NewLine + "to select your music directory.";
                    MyMessages.ShowErrorMessageBox();
                }
            }
        }

        /// <summary>
        ///     Finds the user default home directory.
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if user default home directory was found, <c>false</c> otherwise.
        /// </returns>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static bool FindUserHomeDirectory()
        {
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null) MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                UserEnviormentInfoProperties.UserHomeDirectoryPath =
                    Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                var directoryPath = UserEnviormentInfoProperties.UserHomeDirectoryPath;

                if (string.IsNullOrEmpty(directoryPath)
                    || !Directory.Exists(directoryPath)) throw new DirectoryNotFoundException();

                return true;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate your home directory. "
                                          + "You will need to click on Set location menu and select home to set this.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);

                return false;
            }
        }

        /// <summary>
        ///     Display file browser for user to find home directory.
        /// </summary>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static void FindUserHomeDirectoryBrowser()
        {
            try
            {
                var home = DisplayFileBrowser.SelectUserHomeDirectory();

                if (string.IsNullOrEmpty(home)
                    || !Directory.Exists(home)) throw new DirectoryNotFoundException();

                UserEnviormentInfoProperties.UserHomeDirectoryPath = home;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Unable to locate your home directory. "
                                          + "You will need to click on Set location menu and select home to set this.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
            }
        }

        /// <summary>
        ///     Finds the name of the user.
        /// </summary>
        /// <returns><c>true</c>, if user name was found, <c>false</c> otherwise.</returns>
        public static bool FindUserName()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) MyMessages.NameOfClass = declaringType.Name;

            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            UserEnviormentInfoProperties.UserName = Environment.UserName;

            return string.IsNullOrEmpty(UserEnviormentInfoProperties.UserName);
        }

        /// <summary>
        ///     Find users default music directory.
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if user top-level music directory was found,
        ///     <c>false</c> otherwise.
        /// </returns>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static bool FindUserToplevelMusicDirectory()
        {
            try
            {
                var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
                if (declaringType != null) MyMessages.NameOfClass = declaringType.Name;

                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

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
                MyMessages.ErrorMessage = "Unable to locate your home directory. "
                                          + "You will need to click on Set location menu and select home to set this.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     See if users top-level music directory is the default. if not then
        ///     move on to other ways.
        /// </summary>
        public static bool LocateUserToplevelMusicDirectory()
        {
            //var retVal = true;

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) MyMessages.NameOfClass = declaringType.Name;

            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var sb = new StringBuilder();

            sb.Append("Is your music located in the default Music directory. Such as: /home/user/Music");
            MyMessages.QuestionMessage = sb.ToString();

            var ans = MyMessages.ShowQuestionMessageBox();

            if (DialogResult.Yes == ans)
                if (!FindUserToplevelMusicDirectory())
                {
                    MyMessages.ErrorMessage = "Found no music files in this directory. Use browser"
                                              + Environment.NewLine + "to select your music directory.";
                    MyMessages.ShowErrorMessageBox();
                    return false;
                }


            if (!ValidateOperations.ValidateMusicDirectory(UserEnviormentInfoProperties.UserMusicDirectoryPath))
                return false;


            SongRecordProperties.MusicDirectoryPath = UserEnviormentInfoProperties.UserMusicDirectoryPath;
            SongRecordProperties.MusicDirectoryName =
                new DirectoryInfo(UserEnviormentInfoProperties.UserMusicDirectoryPath).Name;

            return true;
        }

        #endregion Methods Public
    }
}