/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Media
{
    public partial class GetPlaylistTrack_Request
    {
    }
}

************************************************/

/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Media
{
    public partial class GetPlaylistTrack_Result
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Entity.MainDb.Media
{

    /// <summary>
    /// This class represents the request parameters of this StoredProcedure
    /// </summary>
    public partial class GetPlaylistTrack_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? PlaylistId { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public int? TrackId { get; set; } 
        #endregion
    }

    /// <summary>
    /// This class represents the result of this StoredProcedure
    /// </summary>
    public partial class GetPlaylistTrack_Result
    {
        #region Simple Properties
        public int PlaylistId { get; set; } 
        public int TrackId { get; set; } 
        #endregion
    }
}
