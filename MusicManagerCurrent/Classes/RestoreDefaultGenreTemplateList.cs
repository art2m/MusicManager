// RestoreDefaultGenreTemplateList.cs // Author: art2m <art2m@live.com> //
// Copyright (c) 2016 art2m // This program is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version. // This program is distributed
// in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the
// implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See
// the GNU General Public License for more details. // You should have received a
// copy of the GNU General Public License along with this program. If not, see <http://www.gnu.org/licenses/>.

using System.Reflection;

namespace MusicManagerCurrent.Classes
{
    /// <summary>
    ///     Restore default genre template list. Add the original genre template list
    ///     to the GenreListCollection so as it can be used to recreate the
    ///     GenreTemplateList text file.
    /// </summary>
    public static class RestoreDefaultGenreTemplateList
    {
        #region Methods Public

        /// <summary>
        ///     Fills the genre template list collection with default genre directories.
        /// </summary>
        public static void FillGenreTemplateListCollection()
        {
            MyMessages.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            GenreDefaultListCollection.ClearCollection();
            GenreDefaultListCollection.AddItem("#");
            GenreDefaultListCollection.AddItem(Bigbands);
            GenreDefaultListCollection.AddItem(Bluegrass);
            GenreDefaultListCollection.AddItem(Blues);
            GenreDefaultListCollection.AddItem(Cajun);
            GenreDefaultListCollection.AddItem(Calypso);
            GenreDefaultListCollection.AddItem(Caribbean);
            GenreDefaultListCollection.AddItem(Celtic);
            GenreDefaultListCollection.AddItem(Children);
            GenreDefaultListCollection.AddItem(Classical);
            GenreDefaultListCollection.AddItem(Country);
            GenreDefaultListCollection.AddItem(Dance);
            GenreDefaultListCollection.AddItem(EasyListening);
            GenreDefaultListCollection.AddItem(Finnish);
            GenreDefaultListCollection.AddItem(HipHop);
            GenreDefaultListCollection.AddItem(Holiday);
            GenreDefaultListCollection.AddItem(Insperational);
            GenreDefaultListCollection.AddItem(Instrumental);
            GenreDefaultListCollection.AddItem(Irish);
            GenreDefaultListCollection.AddItem(Japan);
            GenreDefaultListCollection.AddItem(Jazz);
            GenreDefaultListCollection.AddItem(Latin);
            GenreDefaultListCollection.AddItem(NewAge);
            GenreDefaultListCollection.AddItem(Opera);
            GenreDefaultListCollection.AddItem(Polka);
            GenreDefaultListCollection.AddItem(Pop);
            GenreDefaultListCollection.AddItem(Rap);
            GenreDefaultListCollection.AddItem(RB);
            GenreDefaultListCollection.AddItem(Reggae);
            GenreDefaultListCollection.AddItem(Rock);
            GenreDefaultListCollection.AddItem(Soul);
            GenreDefaultListCollection.AddItem(SoundTrack);
            GenreDefaultListCollection.AddItem(SouthAmerica);
            GenreDefaultListCollection.AddItem(Vocals);
            GenreDefaultListCollection.AddItem(WorkOut);
        }

        #endregion Methods Public

        #region Fields

        /// <summary>
        /// Needs to be first item in the file when restoring new file.
        /// Validates that this is the file needed.
        /// </summary>
        private const string FileHeader = "#";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Bigbands = "Various-Bigbands";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Bluegrass = "Various-Bluegrass";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Blues = "Various-Blues";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Cajun = "Various-Cajun";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Calypso = "Various-Calypso";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Caribbean = "Various-Caribbean";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Celtic = "Various-Celtic";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Children = "Various-Children-Music";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Classical = "Various-Classical";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Country = "Various-Country";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Dance = "Various-Dance";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string EasyListening = "Various-Easy-Listening";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Finnish = "Various-Finnish";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string HipHop = "Various-Hip-Hop";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Holiday = "Various-Holiday";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Insperational = "Various-Inspirational";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Instrumental = "Various-Instrumental";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Irish = "Various-Irish";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Japan = "Various-Japan";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Jazz = "Various-Jazz";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Latin = "Various-Latin";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string NewAge = "Various-New-Age";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Opera = "Various-Opera";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Polka = "Various-Polka";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Pop = "Various-Pop";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Rap = "Various-Rap";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string RB = "Various-R&B";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Reggae = "Various-Reggae";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Rock = "Various-Rock";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Soul = "Various-Soul";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string SoundTrack = "Various-Soundtrack";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string SouthAmerica = "Various-South-America";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string Vocals = "Various-Vocals";

        /// <summary>
        ///     Possible genre directory name.
        /// </summary>
        private const string WorkOut = "Various-Workout";

        #endregion Fields
    }
}