#region Usings
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.People;
#endregion


namespace TheSharpFactory.Domain
{
    public partial class PeopleBL
    {
        /*
         *  This is a partial class.  
         *  This file contains Retrieve functions.     
         *
         */

        #region Public Methods
        public List<Customer> GetAllCustomers()
        {
            return GetAllCustomersHelper();
        }
        public List<Employee> GetAllEmployees()
        {
            return GetAllEmployeesHelper();
        }

        #endregion


        #region Private Helpers
        private List<Customer> GetAllCustomersHelper()
        {
            return Repository.MainDb.People.Customer.ToList();
        }
        private List<Employee> GetAllEmployeesHelper()
        {
            return Repository.MainDb.People.Employee.ToList();
        }
        #endregion
    }
}
