/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Container.MainDb
{
    public partial class ModelRepositoryContainer
    {
    }
}

************************************************/

using IMainDb = TheSharpFactory.Repository.Container.Interfaces.MainDb;

namespace TheSharpFactory.Repository.Container.MainDb
{

    /// <summary>
    /// This class represents the Repository Container for a specific Model.
    /// </summary>
    public partial class ModelRepositoryContainer:IMainDb.IModelRepositoryContainer
    {
        public IMainDb.Accounting.ISchemaRepositoryContainer Accounting { get; set; }
        public IMainDb.Media.ISchemaRepositoryContainer Media { get; set; }
        public IMainDb.People.ISchemaRepositoryContainer People { get; set; }
        public ModelRepositoryContainer()
        {
            Accounting = new Accounting.SchemaRepositoryContainer();
            Media = new Media.SchemaRepositoryContainer();
            People = new People.SchemaRepositoryContainer();
            // If not implemented this method is removed during compilation
            LoadCustomContainers();
        }
        // Implement this method in a partial class to load custom containers
        partial void LoadCustomContainers();
    }
}
