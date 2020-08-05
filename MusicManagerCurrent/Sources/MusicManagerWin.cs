// MusicManagerCurrent
//
// MusicManagerWin.cs
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
using System.Windows.Forms;
using MusicManagerCurrent.Classes;
using JetBrains.Annotations;

namespace MusicManagerCurrent.Sources
{
    /// <summary>
    /// Main window of program. Select operation to perform on the music.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MusicManagerWin : Form
    {
        /// <summary>Initializes a new instance of the 
        /// <see cref="MusicManagerWin" /> class.</summary>
        public MusicManagerWin()
        {
            InitializeComponent();
            GetUserName();
            GetMusicDirectoryPath();
            GetUserHomePath();
        }

        /// <summary>
        /// Get the users home directory path.
        /// </summary>
        private void GetUserHomePath()
        {
            
            txtHome.Text = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }

        /// <summary>
        /// Get the users music directory path.
        /// </summary>
        private void GetMusicDirectoryPath()
        {
            var userInfo = new UserInformation();
            var validate = new ValidationClass();

            var dirPath = userInfo.LocateDefaultMusicDirectory();

            if (validate.ValidateStringHasLength(dirPath))
            {
                txtMusic.Text = dirPath;
            }

            dirPath = userInfo.FindMusicDirectoryBrowser();
        }

        /// <summary>
        /// Get the users name.
        /// </summary>
        private void GetUserName()
        {
            txtName.Text = Environment.UserName;
        }


        /// <summary>
        ///     Quit the application.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        private void OnQuit_Clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Display the add new genre directory form.
        /// </summary>
        /// <param name="sender">The Source of the event</param>
        /// <param name="e">Instance containing the event data.</param>
        private void OnGenreAddDirectory_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Display the Edit genre directory form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        private void OnGenreEditDirectory(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Display the remove genre directory form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        private void OnGenreRemoveDirectory(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [load genre music menu clicked].
        /// Display form for user to select what kind of genre music to load.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoadGenreMusicMenu_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when /[load music menu clicked].
        /// Load all music contained in the music directory.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoadMusicMenu_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [edit path music menu clicked].
        /// Edit the music directory path.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnEditPathMusicMenu_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}