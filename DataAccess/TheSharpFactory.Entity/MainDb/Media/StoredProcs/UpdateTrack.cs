/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Media
{
    public partial class UpdateTrack_Request
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
    public partial class UpdateTrack_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? TrackId { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string Name { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public int? AlbumId { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public int? MediaTypeId { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public int? GenreId { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string Composer { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public int? Milliseconds { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public int? Bytes { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public decimal? UnitPrice { get; set; } 
        #endregion
    }
}
