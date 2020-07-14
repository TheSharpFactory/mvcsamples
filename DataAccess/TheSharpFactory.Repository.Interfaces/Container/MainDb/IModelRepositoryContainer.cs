/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Container.Interfaces.MainDb
{
    public partial interface IModelRepositoryContainer
    {
    }
}

************************************************/


namespace TheSharpFactory.Repository.Container.Interfaces.MainDb
{

    /// <summary>
    /// This interface represents the Repository Container for a specific Model.
    /// </summary>
    public partial interface IModelRepositoryContainer
    {
        Accounting.ISchemaRepositoryContainer Accounting { get; set; }
        Media.ISchemaRepositoryContainer Media { get; set; }
        People.ISchemaRepositoryContainer People { get; set; }
    }
}
