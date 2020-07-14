/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Container.Interfaces
{
    public partial interface IRepositoryContainer
    {
    }
}

************************************************/


namespace TheSharpFactory.Repository.Container.Interfaces
{

    /// <summary>
    /// This interface represents the Repository Container.
    /// </summary>
    public partial interface IRepositoryContainer
    {
        MainDb.IModelRepositoryContainer MainDb { get; set; }
    }
}
