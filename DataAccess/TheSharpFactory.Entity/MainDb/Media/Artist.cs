/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Media
{
    public partial class Artist
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
    public partial class Artist
    {
        #region Simple Properties
        public int ArtistId { get; set; } 
        public string Name { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property ArtistId on Entity Album
        /// </summary>
        public List<TheSharpFactory.Entity.MainDb.Media.Album> Albums { get; set; }
        #endregion
    }
}
