/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Media
{
    public partial class Genre
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
    public partial class Genre
    {
        #region Simple Properties
        public int GenreId { get; set; } 
        public string Name { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property GenreId on Entity Track
        /// </summary>
        public List<TheSharpFactory.Entity.MainDb.Media.Track> Tracks { get; set; }
        #endregion
    }
}
