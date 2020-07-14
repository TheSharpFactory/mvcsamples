/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Entity.Utils.MainDb.People
{
    public static partial class EmployeeUtils
    {
    }
}

************************************************/

using TheSharpFactory.Entity.MainDb.People;
using TheSharpFactory.Query;

namespace TheSharpFactory.Entity.Utils.MainDb.People
{

    /// <summary>
    /// This class is a utility class for a TheSharpFactory.Entity.MainDb.People.Employee.
    /// </summary>
    public static partial class EmployeeUtils
    {
        /// <summary>
        /// Compare 2 Entities for changes. NavProperties are NOT taken into account. For NavProperties use the corresponding utils for those Entities
        /// </summary>
        /// <param name="one">Entity One.</param>
        /// <param name="two">Entity Two.</param>
        /// <returns>True if there is changes. False if no changes found.</returns>
        public static bool HasChanges(Employee one, Employee two)
        {
            // this method returns true if differences are found between the 2 entities.
            #region Detect Changes
            if(one.EmployeeId != two.EmployeeId)
                return true;
            if(string.CompareOrdinal(one.LastName, two.LastName) != 0)
                return true;
            if(string.CompareOrdinal(one.FirstName, two.FirstName) != 0)
                return true;
            if(string.CompareOrdinal(one.Title, two.Title) != 0)
                return true;
            if(one.ReportsTo != two.ReportsTo)
                return true;
            if(one.BirthDate != two.BirthDate)
                return true;
            if(one.HireDate != two.HireDate)
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
            #endregion
            return false;
        }
        /// <summary>
        /// Merge all values from one Entity into another one.
        /// </summary>
        /// <param name="source">Source Entity. Will be copied to the target.</param>
        /// <param name="target">Target Entity. Will receive the values from the source.</param>
        /// <returns>void.</returns>
        public static void Merge(Employee source, Employee target)
        {
            // this method merges 2 Entities.
            #region Merge Values
            target.EmployeeId = source.EmployeeId;
            target.LastName = source.LastName;
            target.FirstName = source.FirstName;
            target.Title = source.Title;
            target.ReportsTo = source.ReportsTo;
            target.BirthDate = source.BirthDate;
            target.HireDate = source.HireDate;
            target.Address = source.Address;
            target.City = source.City;
            target.State = source.State;
            target.Country = source.Country;
            target.PostalCode = source.PostalCode;
            target.Phone = source.Phone;
            target.Fax = source.Fax;
            target.Email = source.Email;
            #endregion
        }
        /// <summary>
        /// Get a list of QueryFilter that represent changed fields.
        /// </summary>
        /// <param name="original">Original Entity. The unchanged entity.</param>
        /// <param name="changed">Changed Entity. The entity holding the changed fields.</param>
        /// <returns>QueryFilters of EmployeeProperty</returns>
        public static QueryFilters<EmployeeProperty> GetChanges(Employee original, Employee changed)
        {
            // this method returns a list of changes.
            var changes = new QueryFilters<EmployeeProperty>(15);
            #region Detect Changes
            if(original.EmployeeId != changed.EmployeeId)
                changes.Add(QueryFilter.New(EmployeeProperty.EmployeeId, FilterConditions.Equals, changed.EmployeeId));
            if(string.CompareOrdinal(original.LastName, changed.LastName) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.LastName, FilterConditions.Equals, changed.LastName));
            if(string.CompareOrdinal(original.FirstName, changed.FirstName) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.FirstName, FilterConditions.Equals, changed.FirstName));
            if(string.CompareOrdinal(original.Title, changed.Title) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.Title, FilterConditions.Equals, changed.Title));
            if(original.ReportsTo != changed.ReportsTo)
                changes.Add(QueryFilter.New(EmployeeProperty.ReportsTo, FilterConditions.Equals, changed.ReportsTo));
            if(original.BirthDate != changed.BirthDate)
                changes.Add(QueryFilter.New(EmployeeProperty.BirthDate, FilterConditions.Equals, changed.BirthDate));
            if(original.HireDate != changed.HireDate)
                changes.Add(QueryFilter.New(EmployeeProperty.HireDate, FilterConditions.Equals, changed.HireDate));
            if(string.CompareOrdinal(original.Address, changed.Address) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.Address, FilterConditions.Equals, changed.Address));
            if(string.CompareOrdinal(original.City, changed.City) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.City, FilterConditions.Equals, changed.City));
            if(string.CompareOrdinal(original.State, changed.State) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.State, FilterConditions.Equals, changed.State));
            if(string.CompareOrdinal(original.Country, changed.Country) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.Country, FilterConditions.Equals, changed.Country));
            if(string.CompareOrdinal(original.PostalCode, changed.PostalCode) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.PostalCode, FilterConditions.Equals, changed.PostalCode));
            if(string.CompareOrdinal(original.Phone, changed.Phone) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.Phone, FilterConditions.Equals, changed.Phone));
            if(string.CompareOrdinal(original.Fax, changed.Fax) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.Fax, FilterConditions.Equals, changed.Fax));
            if(string.CompareOrdinal(original.Email, changed.Email) != 0)
                changes.Add(QueryFilter.New(EmployeeProperty.Email, FilterConditions.Equals, changed.Email));
            #endregion
            return changes.Count > 0 ? changes : null;
        }
    }
}
