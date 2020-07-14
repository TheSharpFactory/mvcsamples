#region Usings
using TheSharpFactory.Repository.Container.Interfaces;
#endregion


namespace TheSharpFactory.Domain
{
    /// <summary>
    /// <para>Represents the logic for the Media functional area</para>
    /// <para>This is a partial class broken into Create.cs, Retrieve.cs, Update.cs, Delete.cs.</para>
    /// </summary>
    public partial class MediaBL : BLBase, IMediaBL
    {
        public MediaBL(IRepositoryContainer repository) : base(repository)
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
