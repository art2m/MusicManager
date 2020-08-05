// BookListCurrent
//
// DirectoryFileClass.cs
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

using System;
using System.IO;
using System.Reflection;
using BookListCurrent.Classes;
using JetBrains.Annotations;
using MusicManagerCurrent.ClassesProperties;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Class that contains code to create directories and files.
    /// </summary>
    public class DirectoryFileClass
    {
        private readonly MyMessageBox _msgBox = new MyMessageBox();
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        ///     Initializes members of the <see cref="DirectoryFileClass" /> class.
        /// </summary>
        public DirectoryFileClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) this._msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     Combine directory and file name. Check if file exists if not create
        ///     it.
        /// </summary>
        /// <param name="dirPath">The dirPath <see cref="string" /> .</param>
        /// <param name="fileName">The fileName <see cref="string" /> .</param>
        /// <param name="msg"> True if you want to display message not found else false to skip.</param>
        /// <returns>
        ///     The <see cref="string" /> .
        /// </returns>
        public string CombineDirectoryPathFileNameCheckCreateFile([NotNull] string dirPath, string fileName, bool msg)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._validate.ValidateStringIsNotNull(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringIsNotNull(fileName)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(fileName)) return string.Empty;

            if (!this._validate.ValidateDirectoryExists(dirPath)) return string.Empty;

            var filePath = this.CombineDirectoryPathWithFileName(dirPath, fileName);

            if (this._validate.ValidateFileExists(filePath, false)) return filePath;

            File.Create(filePath).Dispose();

            return File.Exists(filePath) ? filePath : string.Empty;
        }


        /// <summary>
        ///     Combine directory name and file name.
        /// </summary>
        /// <param name="dirPath">The dirPath <see cref="string" /> .</param>
        /// <param name="fileName">The fileName <see cref="string" /> .</param>
        /// <returns>
        ///     The <see cref="string" /> .
        /// </returns>
        public string CombineDirectoryPathWithFileName([NotNull] string dirPath, [NotNull] string fileName)
        {
            if (!this._validate.ValidateStringIsNotNull(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringIsNotNull(fileName)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(fileName)) return string.Empty;
            if (!this._validate.ValidateDirectoryExists(dirPath)) return string.Empty;

            var filePath = Path.Combine(dirPath, fileName);

            return filePath;
        }

        /// <summary>
        ///     Combine two strings to get complete path to directory
        /// </summary>
        /// <param name="dirPath"><see cref="Directory" /> name or path.</param>
        /// <param name="dirName">
        ///     <see cref="Directory" /> name, path or file name.
        /// </param>
        /// <returns>
        ///     <see cref="Path" /> string to directories else empty string.
        /// </returns>
        public string CombineExistingDirectoryPathWithDirectoryName([NotNull] string dirPath, string dirName)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._validate.ValidateStringIsNotNull(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringIsNotNull(dirName)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(dirName)) return string.Empty;
            if (!this._validate.ValidateDirectoryExists(dirPath)) return string.Empty;

            var makePath = Path.Combine(dirPath, dirName);

            return makePath;
        }

        /// <summary>
        ///     Create new directory.
        /// </summary>
        /// <param name="dirNewPath"></param>
        /// <returns>
        /// </returns>
        public bool CreateNewDirectoryReturnPath(string dirNewPath)
        {
            if (!this._validate.ValidateStringIsNotNull(dirNewPath)) return false;
            if (!this._validate.ValidateStringHasLength(dirNewPath)) return false;

            if (Directory.Exists(dirNewPath)) return true;

            _ = Directory.CreateDirectory(dirNewPath);

            return this._validate.ValidateDirectoryExists(dirNewPath);
        }

        /// <summary>
        ///     The GetPathToSpecialDirectoryAppDataLocal.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" /> .
        /// </returns>
        // ReSharper disable once MemberCanBeMadeStatic.Global
        public bool GetPathToSpecialDirectoryAppDataLocal()
        {
            var validate = new ValidationClass();
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            if (!validate.ValidateStringIsNotNull(dirPath))
            {
                return false;
            }

            UserEnviormentInfoProperties.GetApplicationDataPath = dirPath;

            return true;
        }

        /// <summary>
        ///     The CreateNewFile.
        /// </summary>
        /// <param name="filePath">The filePath <see cref="string" /> .</param>
        /// <returns>
        ///     The <see cref="bool" /> .
        /// </returns>
        public bool CreateNewFile(string filePath)
        {
            if (!this._validate.ValidateStringIsNotNull(filePath)) return false;
            if (!this._validate.ValidateStringHasLength(filePath)) return false;
            if (File.Exists(filePath)) return true;

            _ = File.Create(filePath);

            if (!File.Exists(filePath)) return false;

            //BookListPaths.PathOfCurrentWorkingFile = filePath;

            return true;
        }
    }
}