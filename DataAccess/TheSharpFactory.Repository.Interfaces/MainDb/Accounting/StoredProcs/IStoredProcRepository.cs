/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Interfaces.MainDb.Accounting
{
    public partial interface IStoredProcRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.Accounting;
using TheSharpFactory.Query;

namespace TheSharpFactory.Repository.Interfaces.MainDb.Accounting
{

    /// <summary>
    /// This interface represents the Repository for all Stored Procedures under the Accounting schema.
    /// </summary>
    public partial interface IStoredProcRepository
    {
        /// <summary>
        /// Executes Stored Procedure named CheckInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckInvoice_Result</returns>
        StoredProcResult<CheckInvoice_Result> CheckInvoice(CheckInvoice_Request request);
        /// <summary>
        /// Executes Stored Procedure named CheckInvoiceLine.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckInvoiceLine_Result</returns>
        StoredProcResult<CheckInvoiceLine_Result> CheckInvoiceLine(CheckInvoiceLine_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeleteInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeleteInvoice(DeleteInvoice_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeleteInvoiceLine.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeleteInvoiceLine(DeleteInvoiceLine_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetAllInvoiceLines.
        /// </summary>
        /// <returns>StoredProcResult of GetAllInvoiceLines_Result</returns>
        StoredProcResult<GetAllInvoiceLines_Result> GetAllInvoiceLines();
        /// <summary>
        /// Executes Stored Procedure named GetAllInvoices.
        /// </summary>
        /// <returns>StoredProcResult of GetAllInvoices_Result</returns>
        StoredProcResult<GetAllInvoices_Result> GetAllInvoices();
        /// <summary>
        /// Executes Stored Procedure named GetInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoice_Result</returns>
        StoredProcResult<GetInvoice_Result> GetInvoice(GetInvoice_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetInvoiceLine.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoiceLine_Result</returns>
        StoredProcResult<GetInvoiceLine_Result> GetInvoiceLine(GetInvoiceLine_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetInvoiceLinesByInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoiceLinesByInvoice_Result</returns>
        StoredProcResult<GetInvoiceLinesByInvoice_Result> GetInvoiceLinesByInvoice(GetInvoiceLinesByInvoice_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetInvoiceLinesByTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoiceLinesByTrack_Result</returns>
        StoredProcResult<GetInvoiceLinesByTrack_Result> GetInvoiceLinesByTrack(GetInvoiceLinesByTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetInvoicesByCustomer.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoicesByCustomer_Result</returns>
        StoredProcResult<GetInvoicesByCustomer_Result> GetInvoicesByCustomer(GetInvoicesByCustomer_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetInvoicesByEmployee.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetInvoicesByEmployee_Result</returns>
        StoredProcResult<GetInvoicesByEmployee_Result> GetInvoicesByEmployee(GetInvoicesByEmployee_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertInvoice(InsertInvoice_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertInvoiceLine.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertInvoiceLine(InsertInvoiceLine_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdateInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdateInvoice(UpdateInvoice_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdateInvoiceLine.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdateInvoiceLine(UpdateInvoiceLine_Request request);
    }
}
