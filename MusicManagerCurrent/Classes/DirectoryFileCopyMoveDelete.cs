// MusicManagerCurrent
// 
// DirectoryFileCopyMoveDelete.cs
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

using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MusicManagerCurrent.ClassesProperties;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Save, create, move, copy files and directories. File directory manipulation.
    /// </summary>
    public class DirectoryFileCopyMoveDelete
    {
        /// <summary>
        ///     Initializes
        /// </summary>
        public DirectoryFileCopyMoveDelete()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) MyMessages.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     Copy file from source to destination.
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="destPath"></param>
        /// <returns>True if file copied else false.</returns>
        public static bool CopyFileFromTo(string sourcePath, string destPath)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                File.Copy(sourcePath, destPath);

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have the necessary permission level  for this operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Either the file source or the destination file path is null.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Either the file source or the destination file path is invalid.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "Either the file source or destination file path is to long.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "The source file was not found at this path. " + sourcePath;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while copying source file to destination.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "This file copy encountered an error. Operation aborted.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Creates the new directory.
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if new directory was created, <c>false</c> otherwise.
        /// </returns>
        /// <param name="newDirPath">New directory path.</param>
        public static bool CreateNewDirectory(string newDirPath)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (!Directory.Exists(newDirPath)) return false;

                Directory.CreateDirectory(newDirPath);

                // All OK
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have the necessary permission level  for this operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The new directory path is missing.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The new directory path is invalid.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "The new directory path is to long.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while creating the new directory. Aborting operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "This Directory copy encountered an error. Operation aborted.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Creates the new file.
        /// </summary>
        /// <returns><c>true</c>, if new file was created, <c>false</c> otherwise.</returns>
        /// <param name="filePath">File path.</param>
        /// <exception cref="FileNotFoundException">
        ///     Unable to locate source file.
        /// </exception>
        public static bool CreateNewFile(string filePath)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (string.IsNullOrEmpty(filePath)) throw new FileNotFoundException();

                if (File.Exists(filePath))
                {
                    MyMessages.QuestionMessage = "A file with this name already exists: "
                                                 + " Are you sure you wish to overwrite it. " + filePath;

                    var result = MyMessages.ShowQuestionMessageBox();

                    if (result != DialogResult.Yes) return false;
                }

                File.Create(filePath);

                // All OK
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have the necessary permission level  for this operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The new file path is missing.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The new file path is invalid.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "The new file path is to long.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "The source file was not found at this path: " + filePath;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while creating the new file. Aborting operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "This file copy encountered an error. Operation aborted.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Deletes the directory.
        /// </summary>
        /// <param name="dirPath">Dir path.</param>
        /// <exception cref="DirectoryNotFoundException">
        ///     Unable to locate this directory.
        /// </exception>
        public static bool DeleteDirectory(string dirPath)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (!Directory.Exists(dirPath)) throw new DirectoryNotFoundException();

                const bool deleteFilesRecursively = true;
                Directory.Delete(dirPath, deleteFilesRecursively);

                // All OK
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have the necessary permission level  for this operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The directory path is missing.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The directory path is invalid.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "The directory path is to long.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Found no directory at this path: " + dirPath;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while deleting the directory. Aborting operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "This delete directory encountered an error. Operation aborted.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Deletes the file.
        /// </summary>
        /// <returns><c>true</c>, if file was deleted, <c>false</c> otherwise.</returns>
        /// <param name="filePath">File path.</param>
        /// <exception cref="ArgumentNullException">
        ///     The directory path is null.
        /// </exception>
        public static bool DeleteFile(string filePath)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException();

                if (File.Exists(filePath))
                {
                    MyMessages.QuestionMessage = "A file with this name already exists: "
                                                 + " Are you sure you wish to delete it. " + filePath;

                    var result = MyMessages.ShowQuestionMessageBox();

                    if (result != DialogResult.Yes) return false;
                }

                if (File.Exists(filePath))
                {
                    MyMessages.QuestionMessage = "A file with this name already exists: "
                                                 + " Are you sure you wish to delete it. " + filePath;

                    var result = MyMessages.ShowQuestionMessageBox();

                    if (result != DialogResult.Yes) return false;
                }

                File.Delete(filePath);

                // All OK
                MyMessages.InformationMessage = "This file has been deleted successfully";
                MyMessages.ShowInformationMessageBox();

                // All OK
                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have the necessary permission level  for this operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "Either the file source or the destination file path is null.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "Either the file source or the destination file path is invalid.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "Either the file source or destination file path is to long.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "The source file was not found at this path. " + filePath;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while copying source file to destination.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "This file copy encountered an error. Operation aborted.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Moves the directory.
        /// </summary>
        /// <returns><c>true</c>, if directory was moved, <c>false</c> otherwise.</returns>
        /// <param name="sourceDir">Source directory to move.</param>
        /// <param name="destDir">Destination directory.</param>
        /// <exception cref="ArgumentNullException">The file path is null.</exception>
        /// <exception cref="DirectoryNotFoundException">
        ///     The file path is invalid.
        /// </exception>
        /// <exception cref="IOException">
        ///     Source or destination directory path null.
        /// </exception>
        public static bool MoveDirectory(string sourceDir, string destDir)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (string.IsNullOrEmpty(sourceDir)) throw new ArgumentNullException();

                if (!Directory.Exists(sourceDir)) throw new DirectoryNotFoundException();
                if (string.IsNullOrEmpty(destDir)) throw new ArgumentNullException();

                if (Directory.Exists(destDir))
                {
                    MyMessages.QuestionMessage = "A destination directory with this name all ready exists: " + destDir
                                                                                                             + " Do you wish to delete it?";

                    var result = MyMessages.ShowQuestionMessageBox();

                    if (result == DialogResult.Yes)
                        if (!DeleteDirectory(destDir))
                            throw new IOException();
                }

                Directory.Move(sourceDir, destDir);

                return !Directory.Exists(destDir);
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have the necessary permission level  for this operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The source directory path or destination directory path is missing.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);

                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The source directory path or destination directory path is invalid.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "The source directory path or destination directory path is to long.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessages.ErrorMessage = "Found no directory at this path: " + sourceDir;
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "Encountered error while deleting the directory. Aborting operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "Encountered an error. Operation aborted.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }

        /// <summary>
        ///     Moves the file.
        /// </summary>
        /// <returns><c>true</c>, if file was moved, <c>false</c> otherwise.</returns>
        /// <param name="sourceFile">Source file.</param>
        /// <param name="destFile">Destination file.</param>
        /// <exception cref="FileNotFoundException">
        ///     Unable to locate this source file or destination file.
        /// </exception>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException">
        ///     Either the source file path or the destination file path is null.
        /// </exception>
        public static bool MoveFile(string sourceFile, string destFile)
        {
            try
            {
                MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (string.IsNullOrEmpty(sourceFile)) throw new ArgumentNullException();

                if (!File.Exists(sourceFile)) throw new FileNotFoundException();

                if (string.IsNullOrEmpty(destFile)
                    || File.Exists(destFile)) throw new ArgumentException();

                if (File.Exists(destFile))
                {
                    MyMessages.QuestionMessage = "A file with this name already exists: "
                                                 + " Are you sure you wish to overwrite it. " + destFile;

                    var result = MyMessages.ShowQuestionMessageBox();

                    if (result != DialogResult.Yes) return false;
                }

                File.Move(sourceFile, destFile);

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessages.ErrorMessage = "You do not have the necessary permission level  for this operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessages.ErrorMessage = "The source file path or destination file path is missing.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessages.ErrorMessage = "The source file path or destination file path is not valid.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessages.ErrorMessage = "Either the file source or destination file path is to long.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessages.ErrorMessage = "The source file path or destination file path is not valid.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (IOException ex)
            {
                MyMessages.ErrorMessage = "The file path is not correctly formed. Aborting. operation.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
            catch (NotSupportedException ex)
            {
                MyMessages.ErrorMessage = "This file move encountered an error. Operation aborted.";
                MyMessages.BuildErrorString(
                    MyMessages.NameOfClass, MyMessages.NameOfMethod, MyMessages.ErrorMessage, ex.Message);
                return false;
            }
        }
    }
}