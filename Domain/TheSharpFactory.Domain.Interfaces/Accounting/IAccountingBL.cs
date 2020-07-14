#region Usings
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.Accounting;
#endregion


namespace TheSharpFactory.Domain
{
    /// <summary>
    /// <para>Represents the logic for the Accounting functional area</para>
    /// <para>This is a partial class broken into Create.cs, Retrieve.cs, Update.cs, Delete.cs.</para>
    /// </summary>
    public interface IAccountingBL
    {                             
        #region Create
        Invoice CreateInvoice(Invoice entitiy);
        InvoiceLine CreateInvoiceLine(InvoiceLine entitiy);
        #endregion

        #region Retrieve
        List<InvoiceLine> GetAllInvoiceLines();
        List<Invoice> GetAllInvoices();
        #endregion

        #region Update
        Invoice UpdateInvoice(Invoice entitiy);
        InvoiceLine UpdateInvoiceLine(InvoiceLine entitiy);
        #endregion

        #region Delete
        bool DeleteInvoice(int invoiceId);
        bool DeleteInvoiceLine(int invoiceLineId);
        #endregion
    }
}
