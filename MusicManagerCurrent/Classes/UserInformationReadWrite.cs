﻿// MusicManagerCurrent
// 
// UserInformationReadWrite.cs
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
using BookListCurrent.Classes;
using MusicManagerCurrent.ClassesProperties;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Read and write user information to file.
    /// </summary>
    internal static class UserInformationReadWrite
    {
        /// <summary>
        ///     If file exists read user music directory path from file.
        /// </summary>
        /// <returns>true if path is read else false.</returns>
        public static bool ReadMusicPathFile()
        {
            const string musicManger = nameof(MusicManagerCurrent);

            var pathInfo = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathInfo = Path.Combine(pathInfo, musicManger);
            pathInfo = Path.Combine(pathInfo, "MusicInformation.txt");

            var length = new FileInfo(pathInfo).Length;

            // No file to read so exit.
            if (!File.Exists(pathInfo)
                || length == 0) return false;

            var validate = new ValidationClass();
            var msgBox = new MyMessageBox();

            // Read the file and display it line by line.
            using (var sr = new StreamReader(pathInfo))
            {
                string musicPath;
                while ((musicPath = sr.ReadLine()) != null)
                    if (Directory.Exists(musicPath))
                        if (validate.ValidateDirectoryExists(musicPath))
                        {
                            UserEnviormentInfoProperties.UserMusicDirectoryPath = musicPath;
                            SongRecordProperties.MusicDirectoryPath = musicPath;
                            SongRecordProperties.MusicDirectoryName =
                                new DirectoryInfo(UserEnviormentInfoProperties.UserMusicDirectoryPath).Name;
                        }
                        else
                        {
                            msgBox.Msg = "Found no music files in this directory. Use browser"
                                                      + Environment.NewLine + "to select your music directory.";
                            msgBox.ShowErrorMessageBox();
                            return false;
                        }
                    else return false;
            }

            return true;
        }

        /// <summary>
        ///     Write the user information found to file.
        /// </summary>
        /// <returns></returns>
        public static bool WriteUserInformationToFile()
        {
            var msgBox = new MyMessageBox();

            msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                const string musicManager = nameof(MusicManagerCurrent);

                var pathInfo = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                pathInfo = Path.Combine(pathInfo, musicManager);
                pathInfo = Path.Combine(pathInfo, "MusicInformation.txt");

                // No music path so noting to write.
                if (string.IsNullOrEmpty(UserEnviormentInfoProperties.UserMusicDirectoryPath)) return false;

                using (var sw = new StreamWriter(pathInfo))
                {
                    sw.WriteLine(UserEnviormentInfoProperties.UserMusicDirectoryPath);
                    return true;
                }
            }
            catch (AccessViolationException ex)
            {
                msgBox.Msg = "You do not have access permission for this file:";
                msgBox.ShowErrorMessageBox();
                return false;
            }
            catch (IOException ex)
            {
                msgBox.Msg = "Encountered error while writing Music settings file.";
                msgBox.ShowErrorMessageBox();
                return false;
            }
        }
    }
}