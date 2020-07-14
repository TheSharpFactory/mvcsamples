/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.MainDb.People
{
    public partial class Employee
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
    public partial class Employee
    {
        #region Simple Properties
        public int EmployeeId { get; set; } 
        public string LastName { get; set; } 
        public string FirstName { get; set; } 
        public string Title { get; set; } 
        public int? ReportsTo { get; set; } 
        public DateTime? BirthDate { get; set; } 
        public DateTime? HireDate { get; set; } 
        public string Address { get; set; } 
        public string City { get; set; } 
        public string State { get; set; } 
        public string Country { get; set; } 
        public string PostalCode { get; set; } 
        public string Phone { get; set; } 
        public string Fax { get; set; } 
        public string Email { get; set; } 
        #endregion

        #region Navigation Properties
        /// <summary>
        /// Related to property SupportRepId on Entity Customer
        /// </summary>
        public List<TheSharpFactory.Entity.MainDb.People.Customer> Customers { get; set; }
        /// <summary>
        /// Related to property ReportsTo on this entity
        /// </summary>
        public TheSharpFactory.Entity.MainDb.People.Employee Employee1 { get; set; }
        #endregion
    }
}
