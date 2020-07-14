/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.People
{
    public partial class UpdateCustomer_Request
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Entity.MainDb.People
{

    /// <summary>
    /// This class represents the request parameters of this StoredProcedure
    /// </summary>
    public partial class UpdateCustomer_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? CustomerId { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string FirstName { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string LastName { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string Company { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string Address { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string City { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string State { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string Country { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string PostalCode { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string Phone { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string Fax { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public string Email { get; set; } 
        /// <summary>
        /// Direction In
        /// </summary>
        public int? SupportRepId { get; set; } 
        #endregion
    }
}
