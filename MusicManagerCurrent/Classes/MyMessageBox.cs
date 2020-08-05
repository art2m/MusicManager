// BookListCurrent
//
// MyMessageBox.cs
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

namespace BookListCurrent.Classes
{
    using System;
    using System.Windows.Forms;
    using JetBrains.Annotations;

    /// <summary>
    ///     This Class Contains Code for diffrent types of
    ///     <see cref="Message" />Boxes.
    /// </summary>
    public class MyMessageBox
    {
        public MyMessageBox()
        {
        }

        /// <summary>
        ///     Gets or sets the <see cref="Msg" /> Gets or sets the
        ///     <see cref="Msg" /> The error message to be displayed..
        /// </summary>
        [NotNull]
        public string Msg { get; set; } = string.Empty;


        /// <summary>
        ///     Gets or sets the <see cref="NameOfClass" /> Gets or sets the
        ///     <see cref="NameOfClass" /> Contains the name of the class where the
        ///     message box was called from..
        /// </summary>
        [NotNull]
        public string NameOfClass { get; set; } = string.Empty;

        /// <summary>
        ///     Gets or sets the <see cref="NameOfMethod" /> Gets or sets the
        ///     <see cref="NameOfMethod" /> Contains the name of the method where the
        ///     message box is called from..
        /// </summary>
        [NotNull]
        public string NameOfMethod { get; set; } = string.Empty;


        /// <summary>
        /// Display error message box with passed in values.
        /// </summary>
        /// <param name="msg">What is to be displayed.</param>
        /// <param name="methodName">The name of the method where the error is generated from.</param>
        /// <returns> True if message box displayed Successfully else false.</returns>
        public bool ShowErrorMessageBox([NotNull] string msg, [NotNull] string methodName)
        {
            msg = msg.Trim();
            methodName = methodName.Trim();

            if (string.IsNullOrEmpty(msg)) return false;
            if (string.IsNullOrEmpty(methodName)) return false;

            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodName, messageBoxButtons, MessageBoxIcon.Error);
            return true;
        }

        /// <summary>
        ///     Display error message box with message, class name and method name.
        /// </summary>
        /// <param name="msg">The error message to be displayed.</param>
        /// <param name="className">The class name.</param>
        /// <param name="methodName">The method name.</param>
        /// <returns> True if message box is successfully displayed else false.</returns>
        public bool ShowErrorMessageBox([NotNull] string msg, [NotNull] string className, [NotNull] string methodName)
        {
            msg = msg.Trim();
            className = className.Trim();
            methodName = methodName.Trim();

            if (string.IsNullOrEmpty(msg)) return false;
            if (string.IsNullOrEmpty(className)) return false;
            if (string.IsNullOrEmpty(methodName)) return false;


            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, messageBoxButtons, MessageBoxIcon.Error);
            return true;
        }

        /// <summary>
        ///     Display error message box with class name, method name and message.
        /// </summary>
        /// <returns> True if message box is successfully displayed else false.</returns>
        public bool ShowErrorMessageBox()
        {
            this.Msg = this.Msg.Trim();
            this.NameOfClass = this.NameOfClass.Trim();
            this.NameOfMethod = this.NameOfMethod.Trim();

            if (string.IsNullOrEmpty(this.Msg)) return false;
            if (string.IsNullOrEmpty(NameOfClass)) return false;
            if (string.IsNullOrEmpty(NameOfMethod)) return false;

            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            var location = string.Concat(this.NameOfClass, ": ");
            location = string.Concat(location, this.NameOfMethod);
            MessageBox.Show(this.Msg, location, messageBoxButtons, MessageBoxIcon.Warning);
            return true;
        }

        /// <summary>
        ///     Shows the information message.
        /// </summary>
        /// <param name="msg">The Information message to be displayed.</param>
        /// <param name="methodName">The name of the method.</param>
        /// <returns> True if message box is successfully displayed else false.</returns>
        public bool ShowInformationMessageBpx([NotNull] string msg, [NotNull] string methodName)
        {
            msg = msg.Trim();
            methodName = methodName.Trim();

            if (string.IsNullOrEmpty(msg)) return false;
            if (string.IsNullOrEmpty(methodName)) return false;

            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodName, messageBoxButtons, MessageBoxIcon.Information);
            return true;
        }

        /// <summary>
        ///     Shows the information message box.
        /// </summary>
        /// <param name="msg">The Information message to be displayed.</param>
        /// <param name="className">The name of the class.</param>
        /// <param name="methodName">The name of the method.</param>
        /// <returns> True if message box is successfully displayed else false.</returns>
        public bool ShowInformationMessageBox([NotNull] string msg, [NotNull] string className,
            [NotNull] string methodName)
        {
            msg = msg.Trim();
            className = className.Trim();
            methodName = methodName.Trim();

            if (string.IsNullOrEmpty(msg)) return false;
            if (string.IsNullOrEmpty(className)) return false;

            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, messageBoxButtons, MessageBoxIcon.Information);
            return true;
        }

        /// <summary>
        ///     Display information message box with method name and message.
        /// </summary>
        /// <returns> True if message box successfully displayed else false.</returns>
        public bool ShowInformationMessageBox()
        {
            this.Msg = this.Msg.Trim();
            this.NameOfClass = this.NameOfClass.Trim();
            this.NameOfMethod = this.NameOfMethod.Trim();

            if (string.IsNullOrEmpty(this.Msg)) return false;
            if (string.IsNullOrEmpty(this.NameOfClass)) return false;
            if (string.IsNullOrEmpty(this.NameOfMethod)) return false;

            var location = string.Concat(this.NameOfClass, ":  ");
            location = string.Concat(location, this.NameOfMethod);

            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            MessageBox.Show(this.Msg, location, messageBoxButtons, MessageBoxIcon.Warning);
            return true;
        }

        /// <summary>
        ///     Shows the question message.
        /// </summary>
        /// <param name="msg">The question message to be displayed.</param>
        /// <param name="methodName">The name of the method.</param>
        /// <returns>
        ///     yes or no answer to the question. Abort if values passe in are null or empty strings.
        /// </returns>
        public DialogResult ShowQuestionMessageBox([NotNull] string msg, [NotNull] string methodName)
        {
            msg = msg.Trim();
            methodName = methodName.Trim();

            if (string.IsNullOrEmpty(msg)) return DialogResult.Abort;
            if (string.IsNullOrEmpty(methodName)) return DialogResult.Abort;

            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            return MessageBox.Show(msg, methodName, messageBoxButtons, MessageBoxIcon.Question);
        }

        /// <summary>
        ///     Display question message box with method name and message.
        /// </summary>
        /// <returns>
        ///     Return yes or no answer to the question. Abort if values are empty;
        /// </returns>
        public DialogResult ShowQuestionMessageBox()
        {
            this.Msg = this.Msg.Trim();
            this.NameOfClass = this.NameOfClass.Trim();
            this.NameOfMethod = this.NameOfMethod.Trim();

            if (string.IsNullOrEmpty(this.Msg)) return DialogResult.Abort;
            if (string.IsNullOrEmpty(this.NameOfClass)) return DialogResult.Abort;
            if (string.IsNullOrEmpty(this.NameOfMethod)) return DialogResult.Abort;

            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            return MessageBox.Show(this.Msg, this.NameOfMethod, messageBoxButtons, MessageBoxIcon.Question);
        }

        /// <summary>
        ///     Shows the warning message.
        /// </summary>
        /// <param name="msg">The warning message to be displayed.</param>
        /// <param name="methodName">The name of the method.</param>
        /// <returns> True if message box is successfully displayed else false.</returns>
        public bool ShowWarningMessageBox([NotNull] string msg, [NotNull] string methodName)
        {
            msg = msg.Trim();
            methodName = methodName.Trim();

            if (string.IsNullOrEmpty(msg)) return false;
            if (string.IsNullOrEmpty(methodName)) return false;

            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            MessageBox.Show(msg, methodName, messageBoxButtons, MessageBoxIcon.Warning);
            return true;
        }

        /// <summary>
        ///     Shows the warning message box.
        /// </summary>
        /// <param name="msg">The warning message to be displayed.</param>
        /// <param name="className">Name of the class.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <returns> True if message box is successfully displayed else false.</returns>
        public bool ShowWarningMessageBox(string msg, string className, string methodName)
        {
            msg = msg.Trim();
            className = className.Trim();
            methodName = methodName.Trim();

            if (string.IsNullOrEmpty(msg)) return false;
            if (string.IsNullOrEmpty(className)) return false;
            if (string.IsNullOrEmpty(methodName)) return false;

            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            var location = string.Concat(className, ":  ");
            location = string.Concat(location, methodName);
            MessageBox.Show(msg, location, messageBoxButtons, MessageBoxIcon.Warning);
            return true;
        }

        /// <summary>
        ///     Display warning message box with method name and message.
        /// </summary>
        /// <returns> True if message box is successfully displayed else false.</returns>
        public bool ShowWarningMessageBox()
        {
            this.Msg = this.Msg.Trim();
            this.NameOfClass = this.NameOfClass.Trim();
            this.NameOfMethod = this.NameOfMethod.Trim();

            if (string.IsNullOrEmpty(this.Msg)) return false;
            if (string.IsNullOrWhiteSpace(NameOfClass)) return false;
            if (string.IsNullOrEmpty(NameOfMethod)) return false;

            const MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;
            MessageBox.Show(this.Msg, this.NameOfMethod, messageBoxButtons, MessageBoxIcon.Warning);
            return true;
        }
    }
}