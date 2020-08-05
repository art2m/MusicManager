#region Copyright

// MyMessages.cs
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

using System.Text;
using System.Windows.Forms;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     class MyMessages Display appropriate message box for message to be displayed.
    /// </summary>
    public static class MyMessages
    {
        #region Properties Public

        /// <summary>
        ///     Gets or sets the error message.
        /// </summary>
        /// <value>The error message.</value>
        public static string ErrorMessage { get; set; }

        /// <summary>
        ///     Gets or sets the information message.
        /// </summary>
        /// <value>The information message.</value>
        public static string InformationMessage { get; set; }

        /// <summary>
        ///     Gets or sets the name of class.
        /// </summary>
        /// <value>The name of class.</value>
        public static string NameOfClass { get; set; }

        /// <summary>
        ///     Gets or sets the name of method.
        /// </summary>
        /// <value>The name of method.</value>
        public static string NameOfMethod { get; set; }

        /// <summary>
        ///     Gets or sets the question message.
        /// </summary>
        /// <value>The question message.</value>
        public static string QuestionMessage { get; set; }

        /// <summary>
        ///     Holds warning messages
        /// </summary>
        public static string WarningMessage { get; set; }

        #endregion Properties Public

        #region Methods Public

        /// <summary>
        ///     Builds the error string.
        /// </summary>
        /// <param name="className">Class name.</param>
        /// <param name="methodName">Method name.</param>
        /// <param name="errorMsg">Error message.</param>
        /// <param name="exceptionMessage">Exception message.</param>
        public static void BuildErrorString(
            string className, string methodName, string errorMsg, string exceptionMessage)
        {
            var sb = new StringBuilder(className);
            sb.AppendLine(methodName);
            sb.AppendLine(errorMsg);
            sb.AppendLine(exceptionMessage);
            ShowErrorMessage(sb.ToString(), NameOfClass);
        }

        /// <summary>
        ///     Shows the error message.
        /// </summary>
        /// <param name="msg">The Message.</param>
        /// <param name="methodName"></param>
        public static void ShowErrorMessage(string msg, string methodName)
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodName, msgboxButtons, MessageBoxIcon.Error);
        }

        /// <summary>
        ///     Display error message box with message, class name and method name.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        public static void ShowErrorMessageBox(string msg, string className, string methodName)
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, msgboxButtons, MessageBoxIcon.Error);
        }

        /// <summary>
        ///     Display error message box with method name and message.
        /// </summary>
        public static void ShowErrorMessageBox()
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(ErrorMessage, NameOfMethod, msgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///     Shows the information message.
        /// </summary>
        /// <param name="msg">The Message.</param>
        /// <param name="methodName">Class name.</param>
        public static void ShowInformationMessage(string msg, string methodName)
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodName, msgboxButtons, MessageBoxIcon.Information);
        }

        /// <summary>
        ///     Display Information message box with message, class name and method name.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        public static void ShowInformationMessageBox(string msg, string className, string methodName)
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, msgboxButtons, MessageBoxIcon.Information);
        }

        /// <summary>
        ///     Display information message box with method name and message.
        /// </summary>
        public static void ShowInformationMessageBox()
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(InformationMessage, NameOfMethod, msgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///     Shows the question message.
        /// </summary>
        /// <returns>The question message.</returns>
        /// <param name="msg">The Message.</param>
        /// <param name="className">Class name.</param>
        public static DialogResult ShowQuestionMessage(string msg, string className)
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.YesNo;
            var resultRetVal = MessageBox.Show(msg, className, msgboxButtons, MessageBoxIcon.Question);

            return resultRetVal;
        }

        /// <summary>
        ///     Display question message box with method name and message.
        /// </summary>
        /// <returns>Return yes or no.</returns>
        public static DialogResult ShowQuestionMessageBox()
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.YesNo;
            var resultRetVal = MessageBox.Show(QuestionMessage, NameOfMethod, msgboxButtons, MessageBoxIcon.Question);

            return resultRetVal;
        }

        /// <summary>
        ///     Shows the warning message.
        /// </summary>
        /// <param name="msg">The Message.</param>
        /// <param name="className">Class name.</param>
        public static void ShowWarningMessage(string msg, string className)
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, className, msgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///     Display warning message box with message, class name and method name.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        public static void ShowWarningMessageBox(string msg, string className, string methodName)
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, msgboxButtons, MessageBoxIcon.Warning);
        }

        /// <summary>
        ///     Display warning message box with method name and message.
        /// </summary>
        public static void ShowWarningMessageBox()
        {
            const MessageBoxButtons msgboxButtons = MessageBoxButtons.OK;
            MessageBox.Show(WarningMessage, NameOfMethod, msgboxButtons, MessageBoxIcon.Warning);
        }

        #endregion Methods public
    }
}