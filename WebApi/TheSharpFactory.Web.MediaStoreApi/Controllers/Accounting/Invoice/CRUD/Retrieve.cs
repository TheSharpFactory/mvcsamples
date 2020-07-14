#region Usings
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.Accounting;
#endregion

namespace TheSharpFactory.Web.Api.Controllers
{
    public partial class InvoiceController
    {
        /*
         *  This is a partial class.  
         *  This file contains Retrieve functions using GET.        
         *
         */

        /// <summary>
        /// Get All Invoices
        /// </summary>
        /// <remarks>
        /// #Example#
        /// Use POST: api/Accounting/Invoice
        /// </remarks>             
        /// <response code="200">List of Invoices.</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<Invoice>), 200)]
        public IActionResult GetAll()
        {
            return new ObjectResult(_bl.Accounting.GetAllInvoices());
        }
    }
}
