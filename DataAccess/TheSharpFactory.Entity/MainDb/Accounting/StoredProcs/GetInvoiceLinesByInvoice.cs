/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Accounting
{
    public partial class GetInvoiceLinesByInvoice_Request
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

namespace TheSharpFactory.Entity.MainDb.Accounting
{
    public partial class GetInvoiceLinesByInvoice_Result
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
    public partial class GetInvoiceLinesByInvoice_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? InvoiceId { get; set; } 
        #endregion
    }

    /// <summary>
    /// This class represents the result of this StoredProcedure
    /// </summary>
    public partial class GetInvoiceLinesByInvoice_Result
    {
        #region Simple Properties
        public int InvoiceLineId { get; set; } 
        public int InvoiceId { get; set; } 
        public int TrackId { get; set; } 
        public decimal UnitPrice { get; set; } 
        public int Quantity { get; set; } 
        #endregion
    }
}
