/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Media
{
    public partial class Playlist
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Entity.MainDb.Media
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class Playlist
    {
        #region Simple Properties
        public int PlaylistId { get; set; } 
        public string Name { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property PlaylistId on Entity PlaylistTrack
        /// </summary>
        public List<TheSharpFactory.Entity.MainDb.Media.PlaylistTrack> PlaylistTracks { get; set; }
        #endregion
    }
}
