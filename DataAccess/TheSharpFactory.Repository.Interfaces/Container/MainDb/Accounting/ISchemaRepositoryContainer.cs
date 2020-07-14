/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Container.Interfaces.MainDb.Accounting
{
    public partial interface ISchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Repository.Interfaces.MainDb.Accounting;

namespace TheSharpFactory.Repository.Container.Interfaces.MainDb.Accounting
{

    /// <summary>
    /// This interface represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial interface ISchemaRepositoryContainer
    {
        #region Entity Repositories
        IInvoiceRepository Invoice { get; set; }
        IInvoiceLineRepository InvoiceLine { get; set; }
        #endregion
        #region Store Procedure Repository
        IStoredProcRepository StoredProcs { get; set; }
        #endregion
    }
}
