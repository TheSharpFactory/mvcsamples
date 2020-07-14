#region Usings
using TheSharpFactory.Entity.MainDb.People;
#endregion


namespace TheSharpFactory.Domain
{
    public partial class PeopleBL
    {
        /*
         *  This is a partial class.  
         *  This file contains Create functions.     
         *
         */
        #region Public Methods
        public Customer CreateCustomer(Customer entitiy)
        {
            return CreateCustomerHelper(entitiy);
        }

        public Employee CreateEmployee(Employee entitiy)
        {
            return CreateEmployeeHelper(entitiy);
        }
        #endregion


        #region Private Helpers
        private Customer CreateCustomerHelper(Customer entitiy)
        {
            Repository.MainDb.People.Customer.Create(entitiy);

            return Repository.MainDb.People.Customer.ByPK(entitiy.CustomerId);
        }
        private Employee CreateEmployeeHelper(Employee entitiy)
        {
            Repository.MainDb.People.Employee.Create(entitiy);

            return Repository.MainDb.People.Employee.ByPK(entitiy.EmployeeId);
        }
        #endregion
    }
}
