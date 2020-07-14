/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Accounting
{
    public partial class InsertInvoiceLine_Request
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Entity.MainDb.Accounting
{

    /// <summary>
    /// This class represents the request parameters of this StoredProcedure
    /// </summary>
    public partial class InsertInvoiceLine_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? InvoiceId { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public int? TrackId { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public decimal? UnitPrice { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public int? Quantity { get; set; } 
        /// <summary>
        /// Direction InOut
        /// </summary>
        public int? InvoiceLineId { get; set; } 
        #endregion
    }
}
