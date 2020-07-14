#region Usings
using TheSharpFactory.Entity.MainDb.Accounting;
#endregion


namespace TheSharpFactory.Domain
{
    public partial class AccountingBL
    {
       /*
        *  This is a partial class.  
        *  This file contains Update functions.     
        *
        */

        #region Public Methods
        public Invoice UpdateInvoice(Invoice entitiy)
        {
            return UpdateInvoiceHelper(entitiy);
        }

        public InvoiceLine UpdateInvoiceLine(InvoiceLine entitiy)
        {
            return UpdateInvoiceLineHelper(entitiy);
        }
        #endregion


        #region Private Helpers
        private Invoice UpdateInvoiceHelper(Invoice entitiy)
        {
            Repository.MainDb.Accounting.Invoice.Update(entitiy);

            return Repository.MainDb.Accounting.Invoice.ByPK(entitiy.InvoiceId);
        }
        private InvoiceLine UpdateInvoiceLineHelper(InvoiceLine entitiy)
        {
            Repository.MainDb.Accounting.InvoiceLine.Update(entitiy);

            return Repository.MainDb.Accounting.InvoiceLine.ByPK(entitiy.InvoiceLineId);
        }
        #endregion
    }
}
