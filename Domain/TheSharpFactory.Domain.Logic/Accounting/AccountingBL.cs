#region Usings
using TheSharpFactory.Repository.Container.Interfaces;
#endregion


namespace TheSharpFactory.Domain
{
    /// <summary>
    /// <para>Represents the logic for the Accounting functional area</para>
    /// <para>This is a partial class broken into Create.cs, Retrieve.cs, Update.cs, Delete.cs.</para>
    /// </summary>
    public partial class AccountingBL : BLBase, IAccountingBL
    {
        public AccountingBL(IRepositoryContainer repository) : base(repository)
        {
        }

        /*
         *  This is a partial class.  
         *  This file contains constructors and common functions.
         *  The other files are Create.cs, Retrieve.cs, Update.cs, Delete.cs
         *
         */
    }
}
