/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Accounting
{
    public partial class InvoiceLine
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Entity.MainDb.Accounting
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class InvoiceLine
    {
        #region Simple Properties
        public int InvoiceLineId { get; set; } 
        public int InvoiceId { get; set; } 
        public int TrackId { get; set; } 
        public decimal UnitPrice { get; set; } 
        public int Quantity { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property InvoiceId on this entity
        /// </summary>
        public TheSharpFactory.Entity.MainDb.Accounting.Invoice Invoice { get; set; }
        /// <summary>
        /// Related to property TrackId on this entity
        /// </summary>
        public TheSharpFactory.Entity.MainDb.Media.Track Track { get; set; }
        #endregion
    }
}
