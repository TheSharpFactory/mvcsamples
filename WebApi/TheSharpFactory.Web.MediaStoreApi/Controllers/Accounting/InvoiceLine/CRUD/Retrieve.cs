#region Usings
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.Accounting;
#endregion

namespace TheSharpFactory.Web.Api.Controllers
{
    public partial class InvoiceLineController
    {
        /*
         *  This is a partial class.  
         *  This file contains Retrieve functions using GET.        
         *
         */

        /// <summary>
        /// Get All InvoiceLines
        /// </summary>
        /// <remarks>
        /// #Example#
        /// Use POST: api/Accounting/InvoiceLine
        /// </remarks>             
        /// <response code="200">List of InvoiceLines.</response>
        [HttpGet]
        [ProducesResponseType(typeof(List<InvoiceLine>), 200)]
        public IActionResult GetAll()
        {
            return new ObjectResult(_bl.Accounting.GetAllInvoiceLines());
        }
    }
}
