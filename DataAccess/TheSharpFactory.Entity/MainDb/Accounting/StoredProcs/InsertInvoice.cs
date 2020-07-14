/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Accounting
{
    public partial class InsertInvoice_Request
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
    public partial class InsertInvoice_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? CustomerId { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public DateTime? InvoiceDate { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string BillingAddress { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string BillingCity { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string BillingState { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string BillingCountry { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string BillingPostalCode { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public decimal? Total { get; set; } 
        /// <summary>
        /// Direction InOut
        /// </summary>
        public int? InvoiceId { get; set; } 
        #endregion
    }
}
