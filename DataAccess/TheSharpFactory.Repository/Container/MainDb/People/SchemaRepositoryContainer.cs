/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Container.MainDb.People
{
    public partial class SchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Repository.MainDb.People;
using TheSharpFactory.Repository.Interfaces.MainDb.People;
using TheSharpFactory.Repository.Container.Interfaces.MainDb.People;

namespace TheSharpFactory.Repository.Container.MainDb.People
{

    /// <summary>
    /// This class represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial class SchemaRepositoryContainer:ISchemaRepositoryContainer
    {
        #region Entity Repositories
        public ICustomerRepository Customer { get; set; }
        public IEmployeeRepository Employee { get; set; }
        #endregion
        #region Store Procedure Repository
        public IStoredProcRepository StoredProcs { get; set; }
        #endregion
        public SchemaRepositoryContainer()
        {
            #region Entity Repositories
            Customer = new CustomerRepository();
            Employee = new EmployeeRepository();
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
