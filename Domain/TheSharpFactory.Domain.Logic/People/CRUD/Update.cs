#region Usings
using TheSharpFactory.Entity.MainDb.People;
#endregion


namespace TheSharpFactory.Domain
{
    public partial class PeopleBL
    {
        /*
         *  This is a partial class.  
         *  This file contains Update functions.     
         *
         */

        #region Public Methods
        public Customer UpdateCustomer(Customer entitiy)
        {
            return UpdateCustomerHelper(entitiy);
        }

        public Employee UpdateEmployee(Employee entitiy)
        {
            return UpdateEmployeeHelper(entitiy);
        }
        #endregion


        #region Private Helpers
        private Customer UpdateCustomerHelper(Customer entitiy)
        {
            Repository.MainDb.People.Customer.Update(entitiy);

            return Repository.MainDb.People.Customer.ByPK(entitiy.CustomerId);
        }
        private Employee UpdateEmployeeHelper(Employee entitiy)
        {
            Repository.MainDb.People.Employee.Update(entitiy);

            return Repository.MainDb.People.Employee.ByPK(entitiy.EmployeeId);
        }
        #endregion
    }
}
