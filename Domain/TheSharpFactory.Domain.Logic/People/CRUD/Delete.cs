#region Usings
#endregion


namespace TheSharpFactory.Domain
{
    public partial class PeopleBL
    {
        /*
         *  This is a partial class.  
         *  This file contains Delete functions.     
         *
         */
        #region Public Methods
        public bool DeleteCustomer(int customerId)
        {
            return DeleteCustomerHelper(customerId);
        }

        public bool DeleteEmployee(int employeeId)
        {
            return DeleteEmployeeHelper(employeeId);
        }
        #endregion


        #region Private Helpers
        private bool DeleteCustomerHelper(int customerId)
        {
            Repository.MainDb.People.Customer.DeleteByPK(customerId);

            return true;
        }
        private bool DeleteEmployeeHelper(int employeeId)
        {
            Repository.MainDb.People.Employee.DeleteByPK(employeeId);

            return true;
        }
        #endregion
    }
}
