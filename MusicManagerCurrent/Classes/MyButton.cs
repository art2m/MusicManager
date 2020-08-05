// MusicManagerCurrent
// 
// MyButton.cs
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

using System.Drawing;
using System.Windows.Forms;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Button class.
    /// </summary>
    internal sealed class MyButton : Button
    {
        /// <summary>Initializes a new instance of the <see cref="MyButton" /> class.</summary>
        public MyButton()
        {
            BackColor = Color.LightSteelBlue;

            Font = new Font(SystemFonts.DialogFont.FontFamily, 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        }

        /// <summary>Gets or sets the background color of the control.</summary>
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        /// <summary>Gets the default size of the control.</summary>
        protected override Size DefaultSize => new Size(150, 45);
    }
}