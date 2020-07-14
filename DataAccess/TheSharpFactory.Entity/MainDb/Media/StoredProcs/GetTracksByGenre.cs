/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Media
{
    public partial class GetTracksByGenre_Request
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
    public partial class GetTracksByGenre_Result
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
    public partial class GetTracksByGenre_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? GenreId { get; set; } 
        #endregion
    }

    /// <summary>
    /// This class represents the result of this StoredProcedure
    /// </summary>
    public partial class GetTracksByGenre_Result
    {
        #region Simple Properties
        public int TrackId { get; set; } 
        public string Name { get; set; } 
        public int? AlbumId { get; set; } 
        public int MediaTypeId { get; set; } 
        public int? GenreId { get; set; } 
        public string Composer { get; set; } 
        public int Milliseconds { get; set; } 
        public int? Bytes { get; set; } 
        public decimal UnitPrice { get; set; } 
        #endregion
    }
}
