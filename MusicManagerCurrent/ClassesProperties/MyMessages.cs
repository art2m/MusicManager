// BookListCurrent
// 
// MyMessages.cs
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

namespace MusicManagerCurrent.ClassesProperties
{
    /// <summary>
    /// Constant messages used through out the program.
    /// </summary>
    public class MyMessages
    {
        /// <summary>
        /// Message for the index is less than zero.
        /// </summary>
        /// <value>
        /// Message for index less then 0;
        /// </value>
        public string MessageIndexLessThanZero => "The index is can not be less than zero.";

        /// <summary>
        /// Gets the Message index grater than collection count.
        /// </summary>
        /// <value>
        /// The Message index grater than collection count.
        /// </value>
        public string MessageIndexGraterThanCollectionCount =>
            "The index can not be greater or equal to the number of items contained in the collection.";

        /// <summary>
        ///     If File name check finds invalid character contained in the string
        ///     
        /// </summary>
        public string MessageInvalidFileNameCharFound => "There is an invalid character in the file name.";

        /// <summary>
        ///     If Path check finds invalid characters contained in path string use
        ///     this message.
        /// </summary>
        public string MessageInvalidPathCharFound => "The path name contains invalid characters. Exiting operation:";

        /// <summary>
        ///     If the Book Title being <see langword="checked" /> is all ready
        ///     formatted. 
        /// </summary>
        public string MessageBookTitleIsAllReadyFormatted => "This book title is all ready formatted.";

        /// <summary>
        ///     If the book title is not formatted.
        /// </summary>
        public string MessageBookTitleIsNotFormatted => "This book title is not formatted";

        /// <summary>
        ///     If the book series contains '()' around the series name then the
        ///     book is all ready formatted. 
        /// </summary>
        public string MessageBookSeriesIsAllReadyFormatted => "This book info is all ready formatted.";

        /// <summary>
        ///     If the directory does not exist. 
        /// </summary>
        public string MessageDirectoryDoesNotExist => "This Directory path does not exist:  ";

        /// <summary>
        ///     If the file does not exist. 
        /// </summary>
        public string MessageFileDoesNotExist => "This file does not exist. ";

        /// <summary>
        ///     If the string is empty. 
        /// </summary>
        public string MessageStringIsEmpty => "This can not be an empty string.";

        /// <summary>
        ///     If string contains any thing but valid letters. 
        /// </summary>
        public string MessageCharacterNotValidLetter => "Fond character that is not a valid letter.";

        /// <summary>
        ///     Failed to successfully save changes.
        /// </summary>
        public string MessageSaveChangesFailed => "Changes save operation failed.";

        /// <summary>
        ///     Changes saved successfully.
        /// </summary>
        public string MessageSaveChangesSucceeded => "Changes have been saved.";

        /// <summary>
        ///     String <see langword="checked" /> is a <see langword="null" /> string.
        ///     
        /// </summary>
        public string MessageStringIsNullString => "The string is not valid. It is a null string.";

        /// <summary>
        ///     If the string contains more then one word. 
        /// </summary>
        public string MessageContainsMoreThanOneWord =>
            "This string contains more than one word. must contain only one word.";

        /// <summary>
        ///     Attempted to create one of the required directories and failed.
        /// </summary>
        public string MessageDirFailedCreate => "Unable to create this required directory. ";

        /// <summary>
        ///     Attempted to create one of the required files and failed.
        /// </summary>
        public string MessageFileFailedCreate => "Unable to create this required file.";

        /// <summary>
        /// Gets the message required directory files missing.
        /// </summary>
        /// <value>
        /// The message required directory files missing.
        /// </value>
        public string MessageRequiredDirFilesMissing => "Exiting program! Required directories and files missing.";

        /// <summary>
        ///     If the book title matches the series name Not allowed. Use this
        ///     message.
        /// </summary>
        public string MessageTheTitleNameMatchesSeriesName =>
            "The title of the book can not be the same as the series name.";

        /// <summary>
        ///     If the title name matches the volume name or number. Not allowed.
        ///     
        /// </summary>
        public string MessageTheTitleNameMatchesTheVolumeNameNumber =>
            "The title cannot match the volume number text.";

        /// <summary>
        ///     If one of the required directories does not exist. 
        /// </summary>
        public string MessageThisIsARequiredDirectory =>
            "This directory is one that is required for the program. Should I create it?";

        /// <summary>
        ///     If cannot create authors file name. 
        /// </summary>
        public string MessageUnableToCreateAuthorFileName => "Unable to create the authors file name.";

        /// <summary>
        ///     If the AppDat directory can not be found. 
        /// </summary>
        public string MessageUnableToFindTheAppDataDirectory =>
            "Unable to find the Application Data directory unable to continue.";

        /// <summary>
        ///     Gets the TipTextData.
        /// </summary>
        public string TipTextData { get; } = "Select Title name then select series name then volume number.";

        /// <summary>
        ///     Gets the TipButtonFirst.
        /// </summary>
        public string TipButtonFirst { get; } = "Move to first book record.";

        /// <summary>
        ///     Gets the TipButtonNext.
        /// </summary>
        public string TipButtonNext { get; } = "Move to next book record.";

        /// <summary>
        ///     Gets the TipButtonPrevious.
        /// </summary>
        public string TipButtonPrevious { get; } = "Move to previous book record.";

        /// <summary>
        ///     Gets the TipButtonLast.
        /// </summary>
        public string TipButtonLast { get; } = "Move to last book record.";

        /// <summary>
        ///     Gets the TipButtonReplace.
        /// </summary>
        public string TipButtonReplace { get; } = "Format the book title, series and book title.";

        /// <summary>
        ///     Gets the TipButtonSave.
        /// </summary>
        public string TipButtonSave { get; } = "Select to save all formatted book data";

        /// <summary>
        ///     Gets the TipButtonSeries.
        /// </summary>
        public string TipButtonSeries { get; } = "Get the user selected series name.";

        /// <summary>
        ///     Gets the TipButtonTitle.
        /// </summary>
        public string TipButtonTitle { get; } = "Get the user selected title name.";

        /// <summary>
        ///     Gets the TipButtonVolume.
        /// </summary>
        public string TipButtonVolume { get; } = "Get the user selected volume number.";

        /// <summary>
        ///     Gets the TipTextSeries.
        /// </summary>
        public string TipTextSeries { get; } = "Book series name is displayed here after selecting.";

        /// <summary>
        ///     Gets the TipTextTitle.
        /// </summary>
        public string TipTextTitle { get; } = "The book title name is displayed here after selecting.";

        /// <summary>
        ///     Gets the TipTextVolume.
        /// </summary>
        public string TipTextVolume { get; } = "The book volume is displayed here after selecting.";

        public string TipAutoFormat { get; } = "Try to auto format book Information.";

        /// <summary>
        ///     Gets the TipLabelInfo.
        /// </summary>
        public string TipLabelInfo { get; } = "Authors Name  ";

        /// <summary>
        ///     Gets the TipNotSameTitleSeriesVolume.
        /// </summary>
        public string TipNotSameTitleSeriesVolume { get; } = "The book title and/or book series must not " +
                                                             "be the same as book volume. ";

        /// <summary>
        ///     Gets the TipTitleSeriesNotSame.
        /// </summary>
        public string TipTitleSeriesNotSame { get; } = "The title of the book and the book series " +
                                                       "must not be the same. ";

        /// <summary>
        ///     Gets the TipLabelPosition.
        /// </summary>
        public string TipLabelPosition { get; } = "Record position ";
    }
}