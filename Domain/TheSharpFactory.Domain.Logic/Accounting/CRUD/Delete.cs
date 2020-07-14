#region Usings
#endregion


namespace TheSharpFactory.Domain
{
    public partial class AccountingBL
    {
        /*
         *  This is a partial class.  
         *  This file contains Delete functions.     
         *
         */
        #region Public Methods
        public bool DeleteInvoice(int invoiceId)
        {
            return DeleteInvoiceHelper(invoiceId);
        }

        public bool DeleteInvoiceLine(int invoiceLineId)
        {
            return DeleteInvoiceLineHelper(invoiceLineId);
        }
        #endregion


        #region Private Helpers
        private bool DeleteInvoiceHelper(int invoiceId)
        {
            Repository.MainDb.Accounting.Invoice.DeleteByPK(invoiceId);

            return true;
        }
        private bool DeleteInvoiceLineHelper(int invoiceLineId)
        {
            Repository.MainDb.Accounting.InvoiceLine.DeleteByPK(invoiceLineId);

            return true;
        }
        #endregion

    }
}
