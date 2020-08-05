// MusicManagerCurrent
// 
// UserEnviormentInfoProperties.cs
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

namespace MusicManagerCurrent.ClassesProperties
{
    /// <summary>
    ///     public static class UserEnviormentInfo User environment info. This class stores all of the users Environment
    ///     data such as: User Name, User Home Path, User Music Directory. It also has a Method to get the user
    ///     Environment information.
    /// </summary>
    public static class UserEnviormentInfoProperties
    {
        /// <summary>
        /// Gets or sets the get application data path.
        /// </summary>
        /// <value>
        /// The get application data path.
        /// </value>
       public static string GetApplicationDataPath { get; set; }
        /// <summary>
        ///     Gets or sets the get music genre directory.
        /// </summary>
        /// <value>The get music genre directory.</value>
        public static string GetMusicGenreDirectory { get; set; }

        /// <summary>
        ///     Gets or sets the path to executable.
        /// </summary>
        /// <value>The path to executable.</value>
        public static string PathToExecutable { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this top level music directory found.
        /// </summary>
        /// <value><c>true</c> if top-level music directory found; otherwise, <c>false</c>.</value>
        public static bool ToplevelMusicDirectoryFound { get; set; }

        /// <summary>
        ///     Gets or sets the user home directory path.
        /// </summary>
        /// <value>The user home directory path.</value>
        public static string UserHomeDirectoryPath { get; set; }

        /// <summary>
        ///     Gets or sets the user music directory path.
        /// </summary>
        /// <value>The user music directory path.</value>
        public static string UserMusicDirectoryPath { get; set; }

        /// <summary>
        ///     Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public static string UserName { get; set; }

        /// <summary>
        ///     Gets or sets the user other music directory path. This is a path to USB or other drive. A path to a
        ///     music directory instead of the default music directory.
        /// </summary>
        /// <value>The user other music directory path.</value>
        public static string UserOtherMusicDirectoryPath { get; set; }
    }
}