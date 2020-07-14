/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.People
{
    public partial class Customer
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Entity.MainDb.People
{

    /// <summary>
    /// This class is a DTO. Can be transferred between the participants of the Data Exchange
    /// </summary>
    public partial class Customer
    {
        #region Simple Properties
        public int CustomerId { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Company { get; set; } 
        public string Address { get; set; } 
        public string City { get; set; } 
        public string State { get; set; } 
        public string Country { get; set; } 
        public string PostalCode { get; set; } 
        public string Phone { get; set; } 
        public string Fax { get; set; } 
        public string Email { get; set; } 
        public int? SupportRepId { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property CustomerId on Entity Invoice
        /// </summary>
        public List<TheSharpFactory.Entity.MainDb.Accounting.Invoice> Invoices { get; set; }
        /// <summary>
        /// Related to property SupportRepId on this entity
        /// </summary>
        public TheSharpFactory.Entity.MainDb.People.Employee Employee { get; set; }
        #endregion
    }
}
