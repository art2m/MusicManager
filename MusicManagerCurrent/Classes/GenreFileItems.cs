#region Copyright

// GenreFileItems.cs
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
using System.Reflection;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Genre file items. Holds properties to be used with creating and using the
    ///     GenreUserList.txt and the GenreTemplatesList.txt
    /// </summary>
    public static class GenreFileItems
    {
        #region Fields

        /// <summary>
        ///     The genre template list. The List of containing possible genre
        ///     directories that could be created.
        /// </summary>
        private const string GenreTemplateList = "Genre-Template-List";

        /// <summary>
        ///     The genre users list. The list which contains all various-genre
        ///     directories in the users music directory.
        /// </summary>
        private const string GenreUsersList = "Genre-Users-List";

        private const string LocalDirectory = "/.local/share";

        /// <summary>
        ///     The music manager directory. The directory which will contain the
        ///     Genre lists below. This directory is located in /.local.share
        /// </summary>
        private const string MusicManagerDirectory = nameof(MusicManager);

        #endregion Fields

        #region Methods Public

        /// <summary>
        ///     Check if genre name is contained in the genre template
        /// </summary>
        /// <param name="genreType"></param>
        /// <returns></returns>
        public static bool CheckGenreContainedInGenreTemplate(string genreType)
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) MyMessages.NameOfClass = declaringType.Name;

            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!GenreFileReadWrite.ReadGenreTemplateList())
            {
                const string msg = "Encountered error while reading genre template list. Operation canceled.";
                MyMessages.ShowErrorMessageBox(msg, MyMessages.NameOfClass, MyMessages.NameOfMethod);
                return false;
            }

            var count = GenreDirectoryNamesUsersCollection.ItemCount();

            for (var i = 0; i < count; i++)
            {
                var item = GenreDirectoryNamesUsersCollection.GetItemAt(i);
                var substring = genreType;

                var index = item.IndexOf(substring, StringComparison.CurrentCultureIgnoreCase);

                if (index <= -1) continue;

                break;
            }
            return true;
        }

        /// <summary>
        ///     Contains the name of the directory where the list of user genre music
        ///     types are stored.
        /// </summary>
        /// <returns></returns>
        public static string GetApplicationDirectory()
        {
            return MusicManagerDirectory;
        }

        /// <summary>
        ///     Files the name of genre template list.
        /// </summary>
        /// <returns>The name of genre template list.</returns>
        public static string GetFileNameOfGenreTemplateList()
        {
            return GenreTemplateList;
        }

        /// <summary>
        ///     Files the name of genre user list.
        /// </summary>
        /// <returns>The name of genre user list.</returns>
        public static string GetFileNameOfGenreUserList()
        {
            return GenreUsersList;
        }

        /// <summary>
        ///     Genres the user template list directory name.
        /// </summary>
        /// <returns>The user template list directory.</returns>
        public static string GetGenreUserTemplateListDirectory()
        {
            return MusicManagerDirectory;
        }

        /// <summary>
        ///     Gets the local directory path.
        /// </summary>
        /// <returns>The local directory path.</returns>
        public static string GetLocalDirectoryPath()
        {
            return LocalDirectory;
        }

        #endregion Methods Public
    }
}