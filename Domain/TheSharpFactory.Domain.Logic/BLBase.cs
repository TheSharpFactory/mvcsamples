#region Usings
using TheSharpFactory.Repository.Container.Interfaces;
#endregion


namespace TheSharpFactory.Domain
{
    public abstract class BLBase
    {
        protected IRepositoryContainer Repository { get; }
        public BLBase(IRepositoryContainer repository)
        {
            Repository = repository;
        }
    }
}
