/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Media
{
    public partial class Track
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
    public partial class Track
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

        #region Navigation Properties
        /// <summary>
        /// Related to property TrackId on Entity InvoiceLine
        /// </summary>
        public List<TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine> InvoiceLines { get; set; }
        /// <summary>
        /// Related to property TrackId on Entity PlaylistTrack
        /// </summary>
        public List<TheSharpFactory.Entity.MainDb.Media.PlaylistTrack> PlaylistTracks { get; set; }
        /// <summary>
        /// Related to property AlbumId on this entity
        /// </summary>
        public TheSharpFactory.Entity.MainDb.Media.Album Album { get; set; }
        /// <summary>
        /// Related to property GenreId on this entity
        /// </summary>
        public TheSharpFactory.Entity.MainDb.Media.Genre Genre { get; set; }
        /// <summary>
        /// Related to property MediaTypeId on this entity
        /// </summary>
        public TheSharpFactory.Entity.MainDb.Media.MediaType MediaType { get; set; }
        #endregion
    }
}
