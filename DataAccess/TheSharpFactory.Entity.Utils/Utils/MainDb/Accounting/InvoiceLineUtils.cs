/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.Utils.MainDb.Accounting
{
    public static partial class InvoiceLineUtils
    {
    }
}

************************************************/

using TheSharpFactory.Entity.MainDb.Accounting;
using TheSharpFactory.Query;

namespace TheSharpFactory.Entity.Utils.MainDb.Accounting
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine.
    /// </summary>
    public static partial class InvoiceLineUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(InvoiceLine one, InvoiceLine two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.InvoiceLineId != two.InvoiceLineId)
                return true;
            if(one.InvoiceId != two.InvoiceId)
                return true;
            if(one.TrackId != two.TrackId)
                return true;
            if(one.UnitPrice != two.UnitPrice)
                return true;
            if(one.Quantity != two.Quantity)
                return true;
            #endregion
            return false;
        }
        /// <summary>
        /// Merge all values from one Entity into another one.
        /// </summary>
        /// <param name="source">Source Entity. Will be copied to the target.</param>
        /// <param name="target">Target Entity. Will receive the values from the source.</param>
        /// <returns>void.</returns>
        public static void Merge(InvoiceLine source, InvoiceLine target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.InvoiceLineId = source.InvoiceLineId;
            target.InvoiceId = source.InvoiceId;
            target.TrackId = source.TrackId;
            target.UnitPrice = source.UnitPrice;
            target.Quantity = source.Quantity;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of InvoiceLineProperty</returns>
        public static QueryFilters<InvoiceLineProperty> GetChanges(InvoiceLine original, InvoiceLine changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<InvoiceLineProperty>(5);
            #region Detect Changes
            if(original.InvoiceLineId != changed.InvoiceLineId)
                changes.Add(QueryFilter.New(InvoiceLineProperty.InvoiceLineId, FilterConditions.Equals, changed.InvoiceLineId));
            if(original.InvoiceId != changed.InvoiceId)
                changes.Add(QueryFilter.New(InvoiceLineProperty.InvoiceId, FilterConditions.Equals, changed.InvoiceId));
            if(original.TrackId != changed.TrackId)
                changes.Add(QueryFilter.New(InvoiceLineProperty.TrackId, FilterConditions.Equals, changed.TrackId));
            if(original.UnitPrice != changed.UnitPrice)
                changes.Add(QueryFilter.New(InvoiceLineProperty.UnitPrice, FilterConditions.Equals, changed.UnitPrice));
            if(original.Quantity != changed.Quantity)
                changes.Add(QueryFilter.New(InvoiceLineProperty.Quantity, FilterConditions.Equals, changed.Quantity));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
