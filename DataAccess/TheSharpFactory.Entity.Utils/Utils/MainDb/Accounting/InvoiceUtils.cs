/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.Utils.MainDb.Accounting
{
    public static partial class InvoiceUtils
    {
    }
}

************************************************/

using TheSharpFactory.Entity.MainDb.Accounting;
using TheSharpFactory.Query;

namespace TheSharpFactory.Entity.Utils.MainDb.Accounting
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Entity.MainDb.Accounting.Invoice.
    /// </summary>
    public static partial class InvoiceUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Invoice one, Invoice two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.InvoiceId != two.InvoiceId)
                return true;
            if(one.CustomerId != two.CustomerId)
                return true;
            if(one.InvoiceDate != two.InvoiceDate)
                return true;
            if(string.CompareOrdinal(one.BillingAddress, two.BillingAddress) != 0)
                return true;
            if(string.CompareOrdinal(one.BillingCity, two.BillingCity) != 0)
                return true;
            if(string.CompareOrdinal(one.BillingState, two.BillingState) != 0)
                return true;
            if(string.CompareOrdinal(one.BillingCountry, two.BillingCountry) != 0)
                return true;
            if(string.CompareOrdinal(one.BillingPostalCode, two.BillingPostalCode) != 0)
                return true;
            if(one.Total != two.Total)
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
        public static void Merge(Invoice source, Invoice target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.InvoiceId = source.InvoiceId;
            target.CustomerId = source.CustomerId;
            target.InvoiceDate = source.InvoiceDate;
            target.BillingAddress = source.BillingAddress;
            target.BillingCity = source.BillingCity;
            target.BillingState = source.BillingState;
            target.BillingCountry = source.BillingCountry;
            target.BillingPostalCode = source.BillingPostalCode;
            target.Total = source.Total;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of InvoiceProperty</returns>
        public static QueryFilters<InvoiceProperty> GetChanges(Invoice original, Invoice changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<InvoiceProperty>(9);
            #region Detect Changes
            if(original.InvoiceId != changed.InvoiceId)
                changes.Add(QueryFilter.New(InvoiceProperty.InvoiceId, FilterConditions.Equals, changed.InvoiceId));
            if(original.CustomerId != changed.CustomerId)
                changes.Add(QueryFilter.New(InvoiceProperty.CustomerId, FilterConditions.Equals, changed.CustomerId));
            if(original.InvoiceDate != changed.InvoiceDate)
                changes.Add(QueryFilter.New(InvoiceProperty.InvoiceDate, FilterConditions.Equals, changed.InvoiceDate));
            if(string.CompareOrdinal(original.BillingAddress, changed.BillingAddress) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.BillingAddress, FilterConditions.Equals, changed.BillingAddress));
            if(string.CompareOrdinal(original.BillingCity, changed.BillingCity) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.BillingCity, FilterConditions.Equals, changed.BillingCity));
            if(string.CompareOrdinal(original.BillingState, changed.BillingState) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.BillingState, FilterConditions.Equals, changed.BillingState));
            if(string.CompareOrdinal(original.BillingCountry, changed.BillingCountry) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.BillingCountry, FilterConditions.Equals, changed.BillingCountry));
            if(string.CompareOrdinal(original.BillingPostalCode, changed.BillingPostalCode) != 0)
                changes.Add(QueryFilter.New(InvoiceProperty.BillingPostalCode, FilterConditions.Equals, changed.BillingPostalCode));
            if(original.Total != changed.Total)
                changes.Add(QueryFilter.New(InvoiceProperty.Total, FilterConditions.Equals, changed.Total));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
