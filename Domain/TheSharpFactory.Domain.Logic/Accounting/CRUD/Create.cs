#region Usings
using TheSharpFactory.Entity.MainDb.Accounting;
#endregion


namespace TheSharpFactory.Domain
{
    public partial class AccountingBL
    {
        /*
         *  This is a partial class.  
         *  This file contains Create functions.     
         *
         */
        #region Public Methods
        public Invoice CreateInvoice(Invoice entitiy)
        {
            return CreateInvoiceHelper(entitiy);
        }

        public InvoiceLine CreateInvoiceLine(InvoiceLine entitiy)
        {
            return CreateInvoiceLineHelper(entitiy);
        }
        #endregion


        #region Private Helpers
        private Invoice CreateInvoiceHelper(Invoice entitiy)
        {
            Repository.MainDb.Accounting.Invoice.Create(entitiy);

            return Repository.MainDb.Accounting.Invoice.ByPK(entitiy.InvoiceId);
        }
        private InvoiceLine CreateInvoiceLineHelper(InvoiceLine entitiy)
        {
            Repository.MainDb.Accounting.InvoiceLine.Create(entitiy);

            return Repository.MainDb.Accounting.InvoiceLine.ByPK(entitiy.InvoiceLineId);
        }
        #endregion
    }
}
