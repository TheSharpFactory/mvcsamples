/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Accounting
{
    public partial class DeleteInvoiceLine_Request
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
    public partial class DeleteInvoiceLine_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? InvoiceLineId { get; set; } 
        #endregion
    }
}
