// BookListCurrent
// 
// ControlsValues.cs
// 
// art2m
// 
// art2m
// 
// 07    16   2020
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

namespace BookListCurrent.ClassesProperties
{
    /// <summary>
    ///     Default property values for controls. Location and Size.
    /// </summary>
    public static class ControlsValues
    {
        private const int BtnHorizontalPos = (PnlWidth - BtnWidth) / 2;
        private const int MiddleButtonTopPos = BtnHeight + 60;
        private const int PnlHeight = 260;
        private const int BtnHeight = 45;
        private const int BtnMoveHeight = 30;
        private const int BtnMoveWidth = 92;
        private const int BtnWidth = 150;
        private const int LastButtonTopPos = 2 * BtnHeight + 90;
        private const int PnlEditPosX = 2 * PnlSpace + PnlWidth;
        private const int PnlSpace = 20;
        private const int PnlTopPos = 100;
        private const int PnlWidth = 175;
        private const int TopButtonSpace = 30;
        private const int WinHeight = 600;
        private const int WinWidth = 800;

        /// <summary>
        ///     Height of all buttons.
        /// </summary>
        public static int MyButtonHeight => BtnHeight;

        /// <summary>
        ///     Center the button in the panel.
        /// </summary>
        public static int MyButtonHorizontalPos => BtnHorizontalPos;

        /// <summary>
        ///     Set the size of all movement buttons. Such as move first button.
        /// </summary>
        public static int MyButtonsMoveHeight => BtnMoveHeight;

        /// <summary>
        ///     Set the size of all movement buttons. Such as move first button.
        /// </summary>
        public static int MyButtonMoveWidth => BtnMoveWidth;

        /// <summary>
        ///     Width of all buttons.
        /// </summary>
        public static int MyButtonWidth => BtnWidth;

        /// <summary>
        ///     The location of the bottom button top. Used on Book List Main Win
        ///     Controls.
        /// </summary>
        public static int MyLastButtonTopPos => LastButtonTopPos;

        /// <summary>
        ///     The location of middle button top. Used on Book List Main Win
        ///     Controls.
        /// </summary>
        public static int MyMiddleButtonTopPos => MiddleButtonTopPos;

        /// <summary>
        ///     The height of the panels. Used on Book List Main Win Controls.
        /// </summary>
        public static int MyPanelHeight => PnlHeight;

        /// <summary>
        ///     Location of Edit Panel. Used on Book List Main Win Controls.
        /// </summary>
        public static int MyEditPanelPosX => PnlEditPosX;

        /// <summary>
        ///     Space between the panels. Used on Book List Main Win Controls.
        /// </summary>
        public static int MyPanelSpace => PnlSpace;

        /// <summary>
        ///     The width of the panel. Used on Book List Main Win Controls.
        /// </summary>
        public static int MyPanelWidth => PnlWidth;

        /// <summary>
        ///     The Location of the top of the panel in the window. Used on Book
        ///     List Main Win Controls.
        /// </summary>
        public static int MyPanelTopPos => PnlTopPos;

        /// <summary>
        ///     The amount of space between the top of the panel and the top of the
        ///     first button.
        /// </summary>
        public static int MyTopButtonSpace => TopButtonSpace;

        /// <summary>
        ///     Sets the default window height.
        /// </summary>
        public static int MyWindowHeight => WinHeight;

        /// <summary>
        ///     Sets the default window width.
        /// </summary>
        public static int MyWindowWidth => WinWidth;
    }
}