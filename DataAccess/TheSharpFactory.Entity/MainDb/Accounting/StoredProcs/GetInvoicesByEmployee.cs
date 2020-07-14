/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.Accounting
{
    public partial class GetInvoicesByEmployee_Request
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
    public partial class GetInvoicesByEmployee_Result
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
    public partial class GetInvoicesByEmployee_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? EmployeeId { get; set; } 
        #endregion
    }

    /// <summary>
    /// This class represents the result of this StoredProcedure
    /// </summary>
    public partial class GetInvoicesByEmployee_Result
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
    }
}
