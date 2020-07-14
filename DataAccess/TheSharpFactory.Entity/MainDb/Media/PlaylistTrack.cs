/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Media
{
    public partial class PlaylistTrack
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
    public partial class PlaylistTrack
    {
        #region Simple Properties
        public int PlaylistId { get; set; } 
        public int TrackId { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property PlaylistId on this entity
        /// </summary>
        public TheSharpFactory.Entity.MainDb.Media.Playlist Playlist { get; set; }
        /// <summary>
        /// Related to property TrackId on this entity
        /// </summary>
        public TheSharpFactory.Entity.MainDb.Media.Track Track { get; set; }
        #endregion
    }
}
