// BookListCurrent
//
// LocationAppDataDirectoryPath.cs
//
// art2m
//
// art2m
//
// 07    20   2020
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

using BookListCurrent.Classes;
using MusicManagerCurrent.ClassesProperties;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Gets the path to the
    ///     Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
    ///     directory.
    /// </summary>
    public class GetApplicationDataPath
    {
        /// <summary>
        /// The Message box object declearation.
        /// </summary>
        private readonly MyMessageBox _msgBox = new MyMessageBox();

        /// <summary>
        /// My Message box object decleration.
        /// </summary>
        private readonly MyMessages _myMsg = new MyMessages();

        /// <summary>
        ///     <para>
        ///         Get the path to LocalAppData Directory. Fill
        ///         BookListPaths.PathAppDataDirectory With the Path to the directory.
        ///     </para>
        ///     <para>
        ///         If unable to locate the directory then
        ///         etDefaultDirectoriesAndFilesExist to false. This Path must be found
        ///         as all other directories for the program are contained in this
        ///         directory.
        ///     </para>
        /// </summary>
        public bool GetAppDataDirectoryPath()
        {
            var validate = new ValidationClass();

            var cls  = new DirectoryFileClass();
            // Saves the AppData directory path to BookListPaths.PathAppDataDirectory

            cls.GetPathToSpecialDirectoryAppDataLocal();

            var dirExists = validate.ValidateDirectoryExists(UserEnviormentInfoProperties.GetApplicationDataPath);

            if (dirExists) return true;

            this._msgBox.Msg = this._myMsg.MessageUnableToFindTheAppDataDirectory;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }
    }
}