/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.People
{
    public partial class StoredProcRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Entity.MainDb.People;
using TheSharpFactory.Repository.Interfaces.MainDb.People;
using TheSharpFactory.Repository.Common;
using TheSharpFactory.Query;

namespace TheSharpFactory.Repository.MainDb.People
{

    /// <summary>
    /// This class represents the Repository for all Stored Procedures under the People schema.
    /// </summary>
    public partial class StoredProcRepository:StoredProcedureRepositoryBase, IStoredProcRepository
    {
        #region Constructors
        public StoredProcRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
        }
        #endregion
        /// <summary>
        /// Executes Stored Procedure named CheckCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckCustomer_Result</returns>
        public StoredProcResult<CheckCustomer_Result> CheckCustomer(CheckCustomer_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckCustomer_RequestProperty>{ QueryFilter.New(CheckCustomer_RequestProperty.CustomerId, FilterConditions.Equals, request.CustomerId) };
            #endregion
            var result = new List<CheckCustomer_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckCustomer_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_CheckCustomer, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckCustomer_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named CheckEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckEmployee_Result</returns>
        public StoredProcResult<CheckEmployee_Result> CheckEmployee(CheckEmployee_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckEmployee_RequestProperty>{ QueryFilter.New(CheckEmployee_RequestProperty.EmployeeId, FilterConditions.Equals, request.EmployeeId) };
            #endregion
            var result = new List<CheckEmployee_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckEmployee_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_CheckEmployee, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckEmployee_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named DeleteCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeleteCustomer(DeleteCustomer_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeleteCustomer_RequestProperty>{ QueryFilter.New(DeleteCustomer_RequestProperty.CustomerId, FilterConditions.Equals, request.CustomerId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_DeleteCustomer, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named DeleteEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeleteEmployee(DeleteEmployee_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeleteEmployee_RequestProperty>{ QueryFilter.New(DeleteEmployee_RequestProperty.EmployeeId, FilterConditions.Equals, request.EmployeeId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_DeleteEmployee, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllCustomers.
        /// </summary>
        /// <returns>StoredProcResult of GetAllCustomers_Result</returns>
        public StoredProcResult<GetAllCustomers_Result> GetAllCustomers()
        {
            var result = new List<GetAllCustomers_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllCustomers_Result
                    {
                        CustomerId = r.GetInt32(0),
                        FirstName = r.GetString(1),
                        LastName = r.GetString(2),
                        Company = r.GetValue(3) as string,
                        Address = r.GetValue(4) as string,
                        City = r.GetValue(5) as string,
                        State = r.GetValue(6) as string,
                        Country = r.GetValue(7) as string,
                        PostalCode = r.GetValue(8) as string,
                        Phone = r.GetValue(9) as string,
                        Fax = r.GetValue(10) as string,
                        Email = r.GetString(11),
                        SupportRepId = r.GetValue(12) as int?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_GetAllCustomers, null, materialize);
            var procResult = new StoredProcResult<GetAllCustomers_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllEmployees.
        /// </summary>
        /// <returns>StoredProcResult of GetAllEmployees_Result</returns>
        public StoredProcResult<GetAllEmployees_Result> GetAllEmployees()
        {
            var result = new List<GetAllEmployees_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllEmployees_Result
                    {
                        EmployeeId = r.GetInt32(0),
                        LastName = r.GetString(1),
                        FirstName = r.GetString(2),
                        Title = r.GetValue(3) as string,
                        ReportsTo = r.GetValue(4) as int?,
                        BirthDate = r.GetValue(5) as DateTime?,
                        HireDate = r.GetValue(6) as DateTime?,
                        Address = r.GetValue(7) as string,
                        City = r.GetValue(8) as string,
                        State = r.GetValue(9) as string,
                        Country = r.GetValue(10) as string,
                        PostalCode = r.GetValue(11) as string,
                        Phone = r.GetValue(12) as string,
                        Fax = r.GetValue(13) as string,
                        Email = r.GetValue(14) as string,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_GetAllEmployees, null, materialize);
            var procResult = new StoredProcResult<GetAllEmployees_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetCustomer_Result</returns>
        public StoredProcResult<GetCustomer_Result> GetCustomer(GetCustomer_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetCustomer_RequestProperty>{ QueryFilter.New(GetCustomer_RequestProperty.CustomerId, FilterConditions.Equals, request.CustomerId) };
            #endregion
            var result = new List<GetCustomer_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetCustomer_Result
                    {
                        CustomerId = r.GetInt32(0),
                        FirstName = r.GetString(1),
                        LastName = r.GetString(2),
                        Company = r.GetValue(3) as string,
                        Address = r.GetValue(4) as string,
                        City = r.GetValue(5) as string,
                        State = r.GetValue(6) as string,
                        Country = r.GetValue(7) as string,
                        PostalCode = r.GetValue(8) as string,
                        Phone = r.GetValue(9) as string,
                        Fax = r.GetValue(10) as string,
                        Email = r.GetString(11),
                        SupportRepId = r.GetValue(12) as int?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_GetCustomer, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetCustomer_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetCustomersBySupportRep.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetCustomersBySupportRep_Result</returns>
        public StoredProcResult<GetCustomersBySupportRep_Result> GetCustomersBySupportRep(GetCustomersBySupportRep_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetCustomersBySupportRep_RequestProperty>{ QueryFilter.New(GetCustomersBySupportRep_RequestProperty.SupportRepId, FilterConditions.Equals, request.SupportRepId) };
            #endregion
            var result = new List<GetCustomersBySupportRep_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetCustomersBySupportRep_Result
                    {
                        CustomerId = r.GetInt32(0),
                        FirstName = r.GetString(1),
                        LastName = r.GetString(2),
                        Company = r.GetValue(3) as string,
                        Address = r.GetValue(4) as string,
                        City = r.GetValue(5) as string,
                        State = r.GetValue(6) as string,
                        Country = r.GetValue(7) as string,
                        PostalCode = r.GetValue(8) as string,
                        Phone = r.GetValue(9) as string,
                        Fax = r.GetValue(10) as string,
                        Email = r.GetString(11),
                        SupportRepId = r.GetValue(12) as int?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_GetCustomersBySupportRep, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetCustomersBySupportRep_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetEmployee_Result</returns>
        public StoredProcResult<GetEmployee_Result> GetEmployee(GetEmployee_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetEmployee_RequestProperty>{ QueryFilter.New(GetEmployee_RequestProperty.EmployeeId, FilterConditions.Equals, request.EmployeeId) };
            #endregion
            var result = new List<GetEmployee_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetEmployee_Result
                    {
                        EmployeeId = r.GetInt32(0),
                        LastName = r.GetString(1),
                        FirstName = r.GetString(2),
                        Title = r.GetValue(3) as string,
                        ReportsTo = r.GetValue(4) as int?,
                        BirthDate = r.GetValue(5) as DateTime?,
                        HireDate = r.GetValue(6) as DateTime?,
                        Address = r.GetValue(7) as string,
                        City = r.GetValue(8) as string,
                        State = r.GetValue(9) as string,
                        Country = r.GetValue(10) as string,
                        PostalCode = r.GetValue(11) as string,
                        Phone = r.GetValue(12) as string,
                        Fax = r.GetValue(13) as string,
                        Email = r.GetValue(14) as string,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_GetEmployee, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetEmployee_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetEmployeeReportsTo.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetEmployeeReportsTo_Result</returns>
        public StoredProcResult<GetEmployeeReportsTo_Result> GetEmployeeReportsTo(GetEmployeeReportsTo_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetEmployeeReportsTo_RequestProperty>{ QueryFilter.New(GetEmployeeReportsTo_RequestProperty.EmployeeId, FilterConditions.Equals, request.EmployeeId) };
            #endregion
            var result = new List<GetEmployeeReportsTo_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetEmployeeReportsTo_Result
                    {
                        EmployeeId = r.GetInt32(0),
                        LastName = r.GetString(1),
                        FirstName = r.GetString(2),
                        Title = r.GetValue(3) as string,
                        ReportsTo = r.GetValue(4) as int?,
                        BirthDate = r.GetValue(5) as DateTime?,
                        HireDate = r.GetValue(6) as DateTime?,
                        Address = r.GetValue(7) as string,
                        City = r.GetValue(8) as string,
                        State = r.GetValue(9) as string,
                        Country = r.GetValue(10) as string,
                        PostalCode = r.GetValue(11) as string,
                        Phone = r.GetValue(12) as string,
                        Fax = r.GetValue(13) as string,
                        Email = r.GetValue(14) as string,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_GetEmployeeReportsTo, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetEmployeeReportsTo_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetEmployeesByReportsTo.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetEmployeesByReportsTo_Result</returns>
        public StoredProcResult<GetEmployeesByReportsTo_Result> GetEmployeesByReportsTo(GetEmployeesByReportsTo_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetEmployeesByReportsTo_RequestProperty>{ QueryFilter.New(GetEmployeesByReportsTo_RequestProperty.EmployeeId, FilterConditions.Equals, request.EmployeeId) };
            #endregion
            var result = new List<GetEmployeesByReportsTo_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetEmployeesByReportsTo_Result
                    {
                        EmployeeId = r.GetInt32(0),
                        LastName = r.GetString(1),
                        FirstName = r.GetString(2),
                        Title = r.GetValue(3) as string,
                        ReportsTo = r.GetValue(4) as int?,
                        BirthDate = r.GetValue(5) as DateTime?,
                        HireDate = r.GetValue(6) as DateTime?,
                        Address = r.GetValue(7) as string,
                        City = r.GetValue(8) as string,
                        State = r.GetValue(9) as string,
                        Country = r.GetValue(10) as string,
                        PostalCode = r.GetValue(11) as string,
                        Phone = r.GetValue(12) as string,
                        Fax = r.GetValue(13) as string,
                        Email = r.GetValue(14) as string,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_GetEmployeesByReportsTo, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetEmployeesByReportsTo_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named InsertCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertCustomer(InsertCustomer_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertCustomer_RequestProperty>{ QueryFilter.New(InsertCustomer_RequestProperty.FirstName, FilterConditions.Equals, request.FirstName), QueryFilter.New(InsertCustomer_RequestProperty.LastName, FilterConditions.Equals, request.LastName), QueryFilter.New(InsertCustomer_RequestProperty.Company, FilterConditions.Equals, request.Company), QueryFilter.New(InsertCustomer_RequestProperty.Address, FilterConditions.Equals, request.Address), QueryFilter.New(InsertCustomer_RequestProperty.City, FilterConditions.Equals, request.City), QueryFilter.New(InsertCustomer_RequestProperty.State, FilterConditions.Equals, request.State), QueryFilter.New(InsertCustomer_RequestProperty.Country, FilterConditions.Equals, request.Country), QueryFilter.New(InsertCustomer_RequestProperty.PostalCode, FilterConditions.Equals, request.PostalCode), QueryFilter.New(InsertCustomer_RequestProperty.Phone, FilterConditions.Equals, request.Phone), QueryFilter.New(InsertCustomer_RequestProperty.Fax, FilterConditions.Equals, request.Fax), QueryFilter.New(InsertCustomer_RequestProperty.Email, FilterConditions.Equals, request.Email), QueryFilter.New(InsertCustomer_RequestProperty.SupportRepId, FilterConditions.Equals, request.SupportRepId), QueryFilter.New(InsertCustomer_RequestProperty.CustomerId, FilterConditions.Equals, request.CustomerId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_InsertCustomer, parameters.IFilters, null);
            #region Assign Ouput Values
            request.CustomerId = procReturnVals[(int)InsertCustomer_RequestProperty.CustomerId] as int?;
            #endregion
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named InsertEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertEmployee(InsertEmployee_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertEmployee_RequestProperty>{ QueryFilter.New(InsertEmployee_RequestProperty.LastName, FilterConditions.Equals, request.LastName), QueryFilter.New(InsertEmployee_RequestProperty.FirstName, FilterConditions.Equals, request.FirstName), QueryFilter.New(InsertEmployee_RequestProperty.Title, FilterConditions.Equals, request.Title), QueryFilter.New(InsertEmployee_RequestProperty.ReportsTo, FilterConditions.Equals, request.ReportsTo), QueryFilter.New(InsertEmployee_RequestProperty.BirthDate, FilterConditions.Equals, request.BirthDate), QueryFilter.New(InsertEmployee_RequestProperty.HireDate, FilterConditions.Equals, request.HireDate), QueryFilter.New(InsertEmployee_RequestProperty.Address, FilterConditions.Equals, request.Address), QueryFilter.New(InsertEmployee_RequestProperty.City, FilterConditions.Equals, request.City), QueryFilter.New(InsertEmployee_RequestProperty.State, FilterConditions.Equals, request.State), QueryFilter.New(InsertEmployee_RequestProperty.Country, FilterConditions.Equals, request.Country), QueryFilter.New(InsertEmployee_RequestProperty.PostalCode, FilterConditions.Equals, request.PostalCode), QueryFilter.New(InsertEmployee_RequestProperty.Phone, FilterConditions.Equals, request.Phone), QueryFilter.New(InsertEmployee_RequestProperty.Fax, FilterConditions.Equals, request.Fax), QueryFilter.New(InsertEmployee_RequestProperty.Email, FilterConditions.Equals, request.Email), QueryFilter.New(InsertEmployee_RequestProperty.EmployeeId, FilterConditions.Equals, request.EmployeeId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_InsertEmployee, parameters.IFilters, null);
            #region Assign Ouput Values
            request.EmployeeId = procReturnVals[(int)InsertEmployee_RequestProperty.EmployeeId] as int?;
            #endregion
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdateCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdateCustomer(UpdateCustomer_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdateCustomer_RequestProperty>{ QueryFilter.New(UpdateCustomer_RequestProperty.CustomerId, FilterConditions.Equals, request.CustomerId), QueryFilter.New(UpdateCustomer_RequestProperty.FirstName, FilterConditions.Equals, request.FirstName), QueryFilter.New(UpdateCustomer_RequestProperty.LastName, FilterConditions.Equals, request.LastName), QueryFilter.New(UpdateCustomer_RequestProperty.Company, FilterConditions.Equals, request.Company), QueryFilter.New(UpdateCustomer_RequestProperty.Address, FilterConditions.Equals, request.Address), QueryFilter.New(UpdateCustomer_RequestProperty.City, FilterConditions.Equals, request.City), QueryFilter.New(UpdateCustomer_RequestProperty.State, FilterConditions.Equals, request.State), QueryFilter.New(UpdateCustomer_RequestProperty.Country, FilterConditions.Equals, request.Country), QueryFilter.New(UpdateCustomer_RequestProperty.PostalCode, FilterConditions.Equals, request.PostalCode), QueryFilter.New(UpdateCustomer_RequestProperty.Phone, FilterConditions.Equals, request.Phone), QueryFilter.New(UpdateCustomer_RequestProperty.Fax, FilterConditions.Equals, request.Fax), QueryFilter.New(UpdateCustomer_RequestProperty.Email, FilterConditions.Equals, request.Email), QueryFilter.New(UpdateCustomer_RequestProperty.SupportRepId, FilterConditions.Equals, request.SupportRepId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_UpdateCustomer, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdateEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdateEmployee(UpdateEmployee_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdateEmployee_RequestProperty>{ QueryFilter.New(UpdateEmployee_RequestProperty.EmployeeId, FilterConditions.Equals, request.EmployeeId), QueryFilter.New(UpdateEmployee_RequestProperty.LastName, FilterConditions.Equals, request.LastName), QueryFilter.New(UpdateEmployee_RequestProperty.FirstName, FilterConditions.Equals, request.FirstName), QueryFilter.New(UpdateEmployee_RequestProperty.Title, FilterConditions.Equals, request.Title), QueryFilter.New(UpdateEmployee_RequestProperty.ReportsTo, FilterConditions.Equals, request.ReportsTo), QueryFilter.New(UpdateEmployee_RequestProperty.BirthDate, FilterConditions.Equals, request.BirthDate), QueryFilter.New(UpdateEmployee_RequestProperty.HireDate, FilterConditions.Equals, request.HireDate), QueryFilter.New(UpdateEmployee_RequestProperty.Address, FilterConditions.Equals, request.Address), QueryFilter.New(UpdateEmployee_RequestProperty.City, FilterConditions.Equals, request.City), QueryFilter.New(UpdateEmployee_RequestProperty.State, FilterConditions.Equals, request.State), QueryFilter.New(UpdateEmployee_RequestProperty.Country, FilterConditions.Equals, request.Country), QueryFilter.New(UpdateEmployee_RequestProperty.PostalCode, FilterConditions.Equals, request.PostalCode), QueryFilter.New(UpdateEmployee_RequestProperty.Phone, FilterConditions.Equals, request.Phone), QueryFilter.New(UpdateEmployee_RequestProperty.Fax, FilterConditions.Equals, request.Fax), QueryFilter.New(UpdateEmployee_RequestProperty.Email, FilterConditions.Equals, request.Email) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_People_UpdateEmployee, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
    }
}
