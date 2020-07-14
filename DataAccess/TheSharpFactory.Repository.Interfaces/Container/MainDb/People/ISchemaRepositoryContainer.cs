/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Container.Interfaces.MainDb.People
{
    public partial interface ISchemaRepositoryContainer
    {
    }
}

************************************************/

using TheSharpFactory.Repository.Interfaces.MainDb.People;

namespace TheSharpFactory.Repository.Container.Interfaces.MainDb.People
{

    /// <summary>
    /// This interface represents the Repository Container for a specific Schema within the Model.
    /// </summary>
    public partial interface ISchemaRepositoryContainer
    {
        #region Entity Repositories
        ICustomerRepository Customer { get; set; }
        IEmployeeRepository Employee { get; set; }
        #endregion
        #region Store Procedure Repository
        IStoredProcRepository StoredProcs { get; set; }
        #endregion
    }
}
