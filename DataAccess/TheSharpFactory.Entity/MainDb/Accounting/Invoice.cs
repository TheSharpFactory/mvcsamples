/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Accounting
{
    public partial class Invoice
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
    public partial class Invoice
    {
        #region Simple Properties
        public int InvoiceId { get; set; } 
        public int CustomerId { get; set; } 
        public DateTime InvoiceDate { get; set; } 
        public string BillingAddress { get; set; } 
        public string BillingCity { get; set; } 
        public string BillingState { get; set; } 
        public string BillingCountry { get; set; } 
        public string BillingPostalCode { get; set; } 
        public decimal Total { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property CustomerId on this entity
        /// </summary>
        public TheSharpFactory.Entity.MainDb.People.Customer Customer { get; set; }
        /// <summary>
        /// Related to property InvoiceId on Entity InvoiceLine
        /// </summary>
        public List<TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine> InvoiceLines { get; set; }
        #endregion
    }
}
