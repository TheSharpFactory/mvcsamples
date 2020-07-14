/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Interfaces.MainDb.People
{
    public partial interface IStoredProcRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.People;
using TheSharpFactory.Query;

namespace TheSharpFactory.Repository.Interfaces.MainDb.People
{

    /// <summary>
    /// This interface represents the Repository for all Stored Procedures under the People schema.
    /// </summary>
    public partial interface IStoredProcRepository
    {
        /// <summary>
        /// Executes Stored Procedure named CheckCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckCustomer_Result</returns>
        StoredProcResult<CheckCustomer_Result> CheckCustomer(CheckCustomer_Request request);
        /// <summary>
        /// Executes Stored Procedure named CheckEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckEmployee_Result</returns>
        StoredProcResult<CheckEmployee_Result> CheckEmployee(CheckEmployee_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeleteCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeleteCustomer(DeleteCustomer_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeleteEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeleteEmployee(DeleteEmployee_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetAllCustomers.
        /// </summary>
        /// <returns>StoredProcResult of GetAllCustomers_Result</returns>
        StoredProcResult<GetAllCustomers_Result> GetAllCustomers();
        /// <summary>
        /// Executes Stored Procedure named GetAllEmployees.
        /// </summary>
        /// <returns>StoredProcResult of GetAllEmployees_Result</returns>
        StoredProcResult<GetAllEmployees_Result> GetAllEmployees();
        /// <summary>
        /// Executes Stored Procedure named GetCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetCustomer_Result</returns>
        StoredProcResult<GetCustomer_Result> GetCustomer(GetCustomer_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetCustomersBySupportRep.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetCustomersBySupportRep_Result</returns>
        StoredProcResult<GetCustomersBySupportRep_Result> GetCustomersBySupportRep(GetCustomersBySupportRep_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetEmployee_Result</returns>
        StoredProcResult<GetEmployee_Result> GetEmployee(GetEmployee_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetEmployeeReportsTo.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetEmployeeReportsTo_Result</returns>
        StoredProcResult<GetEmployeeReportsTo_Result> GetEmployeeReportsTo(GetEmployeeReportsTo_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetEmployeesByReportsTo.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetEmployeesByReportsTo_Result</returns>
        StoredProcResult<GetEmployeesByReportsTo_Result> GetEmployeesByReportsTo(GetEmployeesByReportsTo_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertCustomer(InsertCustomer_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertEmployee(InsertEmployee_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdateCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdateCustomer(UpdateCustomer_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdateEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdateEmployee(UpdateEmployee_Request request);
    }
}
