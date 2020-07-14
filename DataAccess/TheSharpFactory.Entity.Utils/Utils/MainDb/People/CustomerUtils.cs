/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.Utils.MainDb.People
{
    public static partial class CustomerUtils
    {
    }
}

************************************************/

using TheSharpFactory.Entity.MainDb.People;
using TheSharpFactory.Query;

namespace TheSharpFactory.Entity.Utils.MainDb.People
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Entity.MainDb.People.Customer.
    /// </summary>
    public static partial class CustomerUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Customer one, Customer two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.CustomerId != two.CustomerId)
                return true;
            if(string.CompareOrdinal(one.FirstName, two.FirstName) != 0)
                return true;
            if(string.CompareOrdinal(one.LastName, two.LastName) != 0)
                return true;
            if(string.CompareOrdinal(one.Company, two.Company) != 0)
                return true;
            if(string.CompareOrdinal(one.Address, two.Address) != 0)
                return true;
            if(string.CompareOrdinal(one.City, two.City) != 0)
                return true;
            if(string.CompareOrdinal(one.State, two.State) != 0)
                return true;
            if(string.CompareOrdinal(one.Country, two.Country) != 0)
                return true;
            if(string.CompareOrdinal(one.PostalCode, two.PostalCode) != 0)
                return true;
            if(string.CompareOrdinal(one.Phone, two.Phone) != 0)
                return true;
            if(string.CompareOrdinal(one.Fax, two.Fax) != 0)
                return true;
            if(string.CompareOrdinal(one.Email, two.Email) != 0)
                return true;
            if(one.SupportRepId != two.SupportRepId)
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
        public static void Merge(Customer source, Customer target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.CustomerId = source.CustomerId;
            target.FirstName = source.FirstName;
            target.LastName = source.LastName;
            target.Company = source.Company;
            target.Address = source.Address;
            target.City = source.City;
            target.State = source.State;
            target.Country = source.Country;
            target.PostalCode = source.PostalCode;
            target.Phone = source.Phone;
            target.Fax = source.Fax;
            target.Email = source.Email;
            target.SupportRepId = source.SupportRepId;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of CustomerProperty</returns>
        public static QueryFilters<CustomerProperty> GetChanges(Customer original, Customer changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<CustomerProperty>(13);
            #region Detect Changes
            if(original.CustomerId != changed.CustomerId)
                changes.Add(QueryFilter.New(CustomerProperty.CustomerId, FilterConditions.Equals, changed.CustomerId));
            if(string.CompareOrdinal(original.FirstName, changed.FirstName) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.FirstName, FilterConditions.Equals, changed.FirstName));
            if(string.CompareOrdinal(original.LastName, changed.LastName) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.LastName, FilterConditions.Equals, changed.LastName));
            if(string.CompareOrdinal(original.Company, changed.Company) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.Company, FilterConditions.Equals, changed.Company));
            if(string.CompareOrdinal(original.Address, changed.Address) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.Address, FilterConditions.Equals, changed.Address));
            if(string.CompareOrdinal(original.City, changed.City) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.City, FilterConditions.Equals, changed.City));
            if(string.CompareOrdinal(original.State, changed.State) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.State, FilterConditions.Equals, changed.State));
            if(string.CompareOrdinal(original.Country, changed.Country) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.Country, FilterConditions.Equals, changed.Country));
            if(string.CompareOrdinal(original.PostalCode, changed.PostalCode) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.PostalCode, FilterConditions.Equals, changed.PostalCode));
            if(string.CompareOrdinal(original.Phone, changed.Phone) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.Phone, FilterConditions.Equals, changed.Phone));
            if(string.CompareOrdinal(original.Fax, changed.Fax) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.Fax, FilterConditions.Equals, changed.Fax));
            if(string.CompareOrdinal(original.Email, changed.Email) != 0)
                changes.Add(QueryFilter.New(CustomerProperty.Email, FilterConditions.Equals, changed.Email));
            if(original.SupportRepId != changed.SupportRepId)
                changes.Add(QueryFilter.New(CustomerProperty.SupportRepId, FilterConditions.Equals, changed.SupportRepId));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
