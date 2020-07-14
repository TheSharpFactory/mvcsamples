#region Usings
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.Accounting;
#endregion


namespace TheSharpFactory.Domain
{
    public partial class AccountingBL 
    {
       /*
        *  This is a partial class.  
        *  This file contains Retrieve functions.     
        *
        */
        #region Public Methods
        public List<Invoice> GetAllInvoices() 
        {
            return GetAllInvoicesHelper();
        }
        public List<InvoiceLine> GetAllInvoiceLines()
        {
            return GetAllInvoiceLinesHelper();
        }

        #endregion


        #region Private Helpers
        private List<Invoice> GetAllInvoicesHelper()
        {
            return Repository.MainDb.Accounting.Invoice.ToList();
        }
        private List<InvoiceLine> GetAllInvoiceLinesHelper()
        {
            return Repository.MainDb.Accounting.InvoiceLine.ToList();
        }
        #endregion
    }
}
