/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Accounting
{
    public partial class StoredProcRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Entity.MainDb.Accounting;
using TheSharpFactory.Repository.Interfaces.MainDb.Accounting;
using TheSharpFactory.Repository.Common;
using TheSharpFactory.Query;

namespace TheSharpFactory.Repository.MainDb.Accounting
{

    /// <summary>
    /// This class represents the Repository for all Stored Procedures under the Accounting schema.
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
        /// Executes Stored Procedure named CheckInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckInvoice_Result</returns>
        public StoredProcResult<CheckInvoice_Result> CheckInvoice(CheckInvoice_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckInvoice_RequestProperty>{ QueryFilter.New(CheckInvoice_RequestProperty.InvoiceId, FilterConditions.Equals, request.InvoiceId) };
            #endregion
            var result = new List<CheckInvoice_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckInvoice_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_CheckInvoice, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckInvoice_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named CheckInvoiceLine.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckInvoiceLine_Result</returns>
        public StoredProcResult<CheckInvoiceLine_Result> CheckInvoiceLine(CheckInvoiceLine_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<CheckInvoiceLine_RequestProperty>{ QueryFilter.New(CheckInvoiceLine_RequestProperty.InvoiceLineId, FilterConditions.Equals, request.InvoiceLineId) };
            #endregion
            var result = new List<CheckInvoiceLine_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new CheckInvoiceLine_Result
                    {
                        BlankName_0 = r.GetValue(0) as bool?,
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_CheckInvoiceLine, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<CheckInvoiceLine_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named DeleteInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeleteInvoice(DeleteInvoice_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeleteInvoice_RequestProperty>{ QueryFilter.New(DeleteInvoice_RequestProperty.InvoiceId, FilterConditions.Equals, request.InvoiceId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_DeleteInvoice, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named DeleteInvoiceLine.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int DeleteInvoiceLine(DeleteInvoiceLine_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<DeleteInvoiceLine_RequestProperty>{ QueryFilter.New(DeleteInvoiceLine_RequestProperty.InvoiceLineId, FilterConditions.Equals, request.InvoiceLineId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_DeleteInvoiceLine, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllInvoiceLines.
        /// </summary>
        /// <returns>StoredProcResult of GetAllInvoiceLines_Result</returns>
        public StoredProcResult<GetAllInvoiceLines_Result> GetAllInvoiceLines()
        {
            var result = new List<GetAllInvoiceLines_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllInvoiceLines_Result
                    {
                        InvoiceLineId = r.GetInt32(0),
                        InvoiceId = r.GetInt32(1),
                        TrackId = r.GetInt32(2),
                        UnitPrice = r.GetDecimal(3),
                        Quantity = r.GetInt32(4),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_GetAllInvoiceLines, null, materialize);
            var procResult = new StoredProcResult<GetAllInvoiceLines_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetAllInvoices.
        /// </summary>
        /// <returns>StoredProcResult of GetAllInvoices_Result</returns>
        public StoredProcResult<GetAllInvoices_Result> GetAllInvoices()
        {
            var result = new List<GetAllInvoices_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetAllInvoices_Result
                    {
                        InvoiceId = r.GetInt32(0),
                        CustomerId = r.GetInt32(1),
                        InvoiceDate = r.GetDateTime(2),
                        BillingAddress = r.GetValue(3) as string,
                        BillingCity = r.GetValue(4) as string,
                        BillingState = r.GetValue(5) as string,
                        BillingCountry = r.GetValue(6) as string,
                        BillingPostalCode = r.GetValue(7) as string,
                        Total = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_GetAllInvoices, null, materialize);
            var procResult = new StoredProcResult<GetAllInvoices_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoice_Result</returns>
        public StoredProcResult<GetInvoice_Result> GetInvoice(GetInvoice_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetInvoice_RequestProperty>{ QueryFilter.New(GetInvoice_RequestProperty.InvoiceId, FilterConditions.Equals, request.InvoiceId) };
            #endregion
            var result = new List<GetInvoice_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetInvoice_Result
                    {
                        InvoiceId = r.GetInt32(0),
                        CustomerId = r.GetInt32(1),
                        InvoiceDate = r.GetDateTime(2),
                        BillingAddress = r.GetValue(3) as string,
                        BillingCity = r.GetValue(4) as string,
                        BillingState = r.GetValue(5) as string,
                        BillingCountry = r.GetValue(6) as string,
                        BillingPostalCode = r.GetValue(7) as string,
                        Total = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_GetInvoice, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetInvoice_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetInvoiceLine.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoiceLine_Result</returns>
        public StoredProcResult<GetInvoiceLine_Result> GetInvoiceLine(GetInvoiceLine_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetInvoiceLine_RequestProperty>{ QueryFilter.New(GetInvoiceLine_RequestProperty.InvoiceLineId, FilterConditions.Equals, request.InvoiceLineId) };
            #endregion
            var result = new List<GetInvoiceLine_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetInvoiceLine_Result
                    {
                        InvoiceLineId = r.GetInt32(0),
                        InvoiceId = r.GetInt32(1),
                        TrackId = r.GetInt32(2),
                        UnitPrice = r.GetDecimal(3),
                        Quantity = r.GetInt32(4),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_GetInvoiceLine, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetInvoiceLine_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetInvoiceLinesByInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoiceLinesByInvoice_Result</returns>
        public StoredProcResult<GetInvoiceLinesByInvoice_Result> GetInvoiceLinesByInvoice(GetInvoiceLinesByInvoice_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetInvoiceLinesByInvoice_RequestProperty>{ QueryFilter.New(GetInvoiceLinesByInvoice_RequestProperty.InvoiceId, FilterConditions.Equals, request.InvoiceId) };
            #endregion
            var result = new List<GetInvoiceLinesByInvoice_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetInvoiceLinesByInvoice_Result
                    {
                        InvoiceLineId = r.GetInt32(0),
                        InvoiceId = r.GetInt32(1),
                        TrackId = r.GetInt32(2),
                        UnitPrice = r.GetDecimal(3),
                        Quantity = r.GetInt32(4),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_GetInvoiceLinesByInvoice, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetInvoiceLinesByInvoice_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetInvoiceLinesByTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoiceLinesByTrack_Result</returns>
        public StoredProcResult<GetInvoiceLinesByTrack_Result> GetInvoiceLinesByTrack(GetInvoiceLinesByTrack_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetInvoiceLinesByTrack_RequestProperty>{ QueryFilter.New(GetInvoiceLinesByTrack_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId) };
            #endregion
            var result = new List<GetInvoiceLinesByTrack_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetInvoiceLinesByTrack_Result
                    {
                        InvoiceLineId = r.GetInt32(0),
                        InvoiceId = r.GetInt32(1),
                        TrackId = r.GetInt32(2),
                        UnitPrice = r.GetDecimal(3),
                        Quantity = r.GetInt32(4),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_GetInvoiceLinesByTrack, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetInvoiceLinesByTrack_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetInvoicesByCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoicesByCustomer_Result</returns>
        public StoredProcResult<GetInvoicesByCustomer_Result> GetInvoicesByCustomer(GetInvoicesByCustomer_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetInvoicesByCustomer_RequestProperty>{ QueryFilter.New(GetInvoicesByCustomer_RequestProperty.CustomerId, FilterConditions.Equals, request.CustomerId) };
            #endregion
            var result = new List<GetInvoicesByCustomer_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetInvoicesByCustomer_Result
                    {
                        InvoiceId = r.GetInt32(0),
                        CustomerId = r.GetInt32(1),
                        InvoiceDate = r.GetDateTime(2),
                        BillingAddress = r.GetValue(3) as string,
                        BillingCity = r.GetValue(4) as string,
                        BillingState = r.GetValue(5) as string,
                        BillingCountry = r.GetValue(6) as string,
                        BillingPostalCode = r.GetValue(7) as string,
                        Total = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_GetInvoicesByCustomer, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetInvoicesByCustomer_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named GetInvoicesByEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoicesByEmployee_Result</returns>
        public StoredProcResult<GetInvoicesByEmployee_Result> GetInvoicesByEmployee(GetInvoicesByEmployee_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<GetInvoicesByEmployee_RequestProperty>{ QueryFilter.New(GetInvoicesByEmployee_RequestProperty.EmployeeId, FilterConditions.Equals, request.EmployeeId) };
            #endregion
            var result = new List<GetInvoicesByEmployee_Result>(10000);//warmup the list to try to get a headstart by avoiding auto grow happenning too soon.
            void materialize (SqlDataReader r)
            {
                #region Materializer
                while(r.Read())
                {
                    result.Add(new GetInvoicesByEmployee_Result
                    {
                        InvoiceId = r.GetInt32(0),
                        CustomerId = r.GetInt32(1),
                        InvoiceDate = r.GetDateTime(2),
                        BillingAddress = r.GetValue(3) as string,
                        BillingCity = r.GetValue(4) as string,
                        BillingState = r.GetValue(5) as string,
                        BillingCountry = r.GetValue(6) as string,
                        BillingPostalCode = r.GetValue(7) as string,
                        Total = r.GetDecimal(8),
                    });
                }
                #endregion
            }
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_GetInvoicesByEmployee, parameters.IFilters, materialize);
            var procResult = new StoredProcResult<GetInvoicesByEmployee_Result>
            {
                ReturnValue = (int)procReturnVals[ReturnParamId],
                Result = result.Count > 0 ? result : null
            };
            return procResult;
        }
        /// <summary>
        /// Executes Stored Procedure named InsertInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertInvoice(InsertInvoice_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertInvoice_RequestProperty>{ QueryFilter.New(InsertInvoice_RequestProperty.CustomerId, FilterConditions.Equals, request.CustomerId), QueryFilter.New(InsertInvoice_RequestProperty.InvoiceDate, FilterConditions.Equals, request.InvoiceDate), QueryFilter.New(InsertInvoice_RequestProperty.BillingAddress, FilterConditions.Equals, request.BillingAddress), QueryFilter.New(InsertInvoice_RequestProperty.BillingCity, FilterConditions.Equals, request.BillingCity), QueryFilter.New(InsertInvoice_RequestProperty.BillingState, FilterConditions.Equals, request.BillingState), QueryFilter.New(InsertInvoice_RequestProperty.BillingCountry, FilterConditions.Equals, request.BillingCountry), QueryFilter.New(InsertInvoice_RequestProperty.BillingPostalCode, FilterConditions.Equals, request.BillingPostalCode), QueryFilter.New(InsertInvoice_RequestProperty.Total, FilterConditions.Equals, request.Total), QueryFilter.New(InsertInvoice_RequestProperty.InvoiceId, FilterConditions.Equals, request.InvoiceId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_InsertInvoice, parameters.IFilters, null);
            #region Assign Ouput Values
            request.InvoiceId = procReturnVals[(int)InsertInvoice_RequestProperty.InvoiceId] as int?;
            #endregion
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named InsertInvoiceLine.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int InsertInvoiceLine(InsertInvoiceLine_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<InsertInvoiceLine_RequestProperty>{ QueryFilter.New(InsertInvoiceLine_RequestProperty.InvoiceId, FilterConditions.Equals, request.InvoiceId), QueryFilter.New(InsertInvoiceLine_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId), QueryFilter.New(InsertInvoiceLine_RequestProperty.UnitPrice, FilterConditions.Equals, request.UnitPrice), QueryFilter.New(InsertInvoiceLine_RequestProperty.Quantity, FilterConditions.Equals, request.Quantity), QueryFilter.New(InsertInvoiceLine_RequestProperty.InvoiceLineId, FilterConditions.Equals, request.InvoiceLineId) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_InsertInvoiceLine, parameters.IFilters, null);
            #region Assign Ouput Values
            request.InvoiceLineId = procReturnVals[(int)InsertInvoiceLine_RequestProperty.InvoiceLineId] as int?;
            #endregion
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdateInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdateInvoice(UpdateInvoice_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdateInvoice_RequestProperty>{ QueryFilter.New(UpdateInvoice_RequestProperty.InvoiceId, FilterConditions.Equals, request.InvoiceId), QueryFilter.New(UpdateInvoice_RequestProperty.CustomerId, FilterConditions.Equals, request.CustomerId), QueryFilter.New(UpdateInvoice_RequestProperty.InvoiceDate, FilterConditions.Equals, request.InvoiceDate), QueryFilter.New(UpdateInvoice_RequestProperty.BillingAddress, FilterConditions.Equals, request.BillingAddress), QueryFilter.New(UpdateInvoice_RequestProperty.BillingCity, FilterConditions.Equals, request.BillingCity), QueryFilter.New(UpdateInvoice_RequestProperty.BillingState, FilterConditions.Equals, request.BillingState), QueryFilter.New(UpdateInvoice_RequestProperty.BillingCountry, FilterConditions.Equals, request.BillingCountry), QueryFilter.New(UpdateInvoice_RequestProperty.BillingPostalCode, FilterConditions.Equals, request.BillingPostalCode), QueryFilter.New(UpdateInvoice_RequestProperty.Total, FilterConditions.Equals, request.Total) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_UpdateInvoice, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
        /// <summary>
        /// Executes Stored Procedure named UpdateInvoiceLine.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        public int UpdateInvoiceLine(UpdateInvoiceLine_Request request)
        {
            #region Parameters
            var parameters = new QueryFilters<UpdateInvoiceLine_RequestProperty>{ QueryFilter.New(UpdateInvoiceLine_RequestProperty.InvoiceLineId, FilterConditions.Equals, request.InvoiceLineId), QueryFilter.New(UpdateInvoiceLine_RequestProperty.InvoiceId, FilterConditions.Equals, request.InvoiceId), QueryFilter.New(UpdateInvoiceLine_RequestProperty.TrackId, FilterConditions.Equals, request.TrackId), QueryFilter.New(UpdateInvoiceLine_RequestProperty.UnitPrice, FilterConditions.Equals, request.UnitPrice), QueryFilter.New(UpdateInvoiceLine_RequestProperty.Quantity, FilterConditions.Equals, request.Quantity) };
            #endregion
            var procReturnVals = StoredProcedure(RepoLookup.StoredProcId.MainDb_Accounting_UpdateInvoiceLine, parameters.IFilters, null);
            return (int)procReturnVals[ReturnParamId];
        }
    }
}
