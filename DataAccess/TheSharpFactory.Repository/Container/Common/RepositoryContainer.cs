/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Container
{
    public partial class RepositoryContainer
    {
    }
}

************************************************/

using IContainer = TheSharpFactory.Repository.Container.Interfaces;

namespace TheSharpFactory.Repository.Container
{

    /// <summary>
    /// This class contains all Repository Containers for all Models.
    /// </summary>
    public partial class RepositoryContainer:IContainer.IRepositoryContainer
    {
        public IContainer.MainDb.IModelRepositoryContainer  MainDb { get; set; }
        public RepositoryContainer()
        {
            MainDb = new MainDb.ModelRepositoryContainer();
            // If not implemented this method is removed during compilation
            LoadCustomContainers();
        }
        // Implement this method in a partial class to load custom containers
        partial void LoadCustomContainers();
    }
}
