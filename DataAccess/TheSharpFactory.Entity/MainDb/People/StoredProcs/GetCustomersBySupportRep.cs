/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.People
{
    public partial class GetCustomersBySupportRep_Request
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

namespace TheSharpFactory.Entity.MainDb.People
{
    public partial class GetCustomersBySupportRep_Result
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
    public partial class GetCustomersBySupportRep_Request
    {
        #region Parameters
        /// <summary>
        /// Direction In
        /// </summary>
        public int? SupportRepId { get; set; } 
        #endregion
    }

    /// <summary>
    /// This class represents the result of this StoredProcedure
    /// </summary>
    public partial class GetCustomersBySupportRep_Result
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
    }
}
