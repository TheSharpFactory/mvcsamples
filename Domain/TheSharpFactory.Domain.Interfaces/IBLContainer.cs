#region Usings
#endregion

namespace TheSharpFactory.Domain
{
    /// <summary>
    /// <para>This type acts as container for the Domain Logic classes.</para>
    /// <para>Each Domain Logic class is represented by a property.</para>
    /// </summary>
    public interface IBLContainer
    {
        IAccountingBL Accounting { get; }
        IMediaBL Media { get; }
        IPeopleBL People { get; }
    }
}
