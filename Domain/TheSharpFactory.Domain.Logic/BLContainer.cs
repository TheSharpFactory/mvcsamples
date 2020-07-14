#region Usings
using TheSharpFactory.Repository.Container.Interfaces;
#endregion


namespace TheSharpFactory.Domain
{
    /// <summary>
    /// <para>This type acts as container for the Domain Logic classes.</para>
    /// <para>Each Domain Logic class is represented by a property.</para>
    /// </summary>
    public class BLContainer : IBLContainer
    {
        public IAccountingBL Accounting { get; }
        public IMediaBL Media { get; }
        public IPeopleBL People { get; }

        public BLContainer(IRepositoryContainer repository) 
        {
            Accounting = new AccountingBL(repository);
            Media = new MediaBL(repository);
            People = new PeopleBL(repository);
        }
    }
}
