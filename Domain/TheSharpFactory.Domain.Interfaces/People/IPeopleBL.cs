#region Usings
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.People;
#endregion


namespace TheSharpFactory.Domain
{
    /// <summary>
    /// <para>Represents the logic for the People functional area.</para>
    /// <para>This is a partial class broken into Create.cs, Retrieve.cs, Update.cs, Delete.cs.</para>
    /// </summary>
    public interface IPeopleBL
    {                          
        #region Create
        Customer CreateCustomer(Customer entitiy);
        Employee CreateEmployee(Employee entitiy);
        #endregion

        #region Retrieve
        List<Customer> GetAllCustomers();
        List<Employee> GetAllEmployees();
        #endregion

        #region Update
        Customer UpdateCustomer(Customer entitiy);
        Employee UpdateEmployee(Employee entitiy);
        #endregion

        #region Delete
        bool DeleteCustomer(int customerId);
        bool DeleteEmployee(int employeeId);
        #endregion
    }
}
