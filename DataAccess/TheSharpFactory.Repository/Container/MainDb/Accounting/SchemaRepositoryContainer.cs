/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Container.MainDb.Accounting
{
    public partial class SchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Repository.MainDb.Accounting;
using TheSharpFactory.Repository.Interfaces.MainDb.Accounting;
using TheSharpFactory.Repository.Container.Interfaces.MainDb.Accounting;

namespace TheSharpFactory.Repository.Container.MainDb.Accounting
{

    /// <summary>
    /// This class represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial class SchemaRepositoryContainer:ISchemaRepositoryContainer
    {
        #region Entity Repositories
        public IInvoiceRepository Invoice { get; set; }
        public IInvoiceLineRepository InvoiceLine { get; set; }
        #endregion
        #region Store Procedure Repository
        public IStoredProcRepository StoredProcs { get; set; }
        #endregion
        public SchemaRepositoryContainer()
        {
            #region Entity Repositories
            Invoice = new InvoiceRepository();
            InvoiceLine = new InvoiceLineRepository();
            #endregion
            #region Store Procedure Repository
            StoredProcs = new StoredProcRepository();
            #endregion
            // If not implemented this method is removed during compilation
            LoadCustomRepositories();
        }
        // Implement this method in a partial class to load custom repositories
        partial void LoadCustomRepositories();
    }
}
