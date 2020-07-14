/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.People
{
    public partial class EmployeeRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Repository.Common;
using TheSharpFactory.Repository.Interfaces.MainDb.People;
using TheSharpFactory.Query;
using TheSharpFactory.Entity.MainDb.People;
using TheSharpFactory.Entity.Utils.MainDb.People;
using MainDbE = TheSharpFactory.Entity.MainDb;

namespace TheSharpFactory.Repository.MainDb.People
{

    /// <summary>
    /// This class represents the Repository for: Employee.
    /// </summary>
    public partial class EmployeeRepository:WritableRepositoryBase<Employee, EmployeeProperty, EmployeeNavProperty>, IEmployeeRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<EmployeeNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<EmployeeNavProperty, NavPropertyInfo>(2){ { EmployeeNavProperty.Customers, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_People_Customer, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.People.EmployeeProperty.EmployeeId, OtherPropId = (int)MainDbE.People.CustomerProperty.SupportRepId, },} } }, { EmployeeNavProperty.Employee1, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_People_Employee, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.People.EmployeeProperty.ReportsTo, OtherPropId = (int)MainDbE.People.EmployeeProperty.EmployeeId, },} } },};
        #endregion
        #region Constructors
        public EmployeeRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_People_Employee;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__Employee__7AD04F111273C1CD) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<EmployeeProperty>(1){ SortFilter.New(EmployeeProperty.EmployeeId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.People.Employee from the database by Primary Key.
        /// </summary>
        /// <param name="employeeid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        public Employee ByPK(int employeeid)
        {
            var where = new QueryFilters<EmployeeProperty>(1){QueryFilter.New(EmployeeProperty.EmployeeId, FilterConditions.Equals, employeeid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.People.Employee from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="employeeid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        public Employee ByPK(int employeeid, NavProps<EmployeeNavProperty> navprops)
        {
            var where = new QueryFilters<EmployeeProperty>(1){QueryFilter.New(EmployeeProperty.EmployeeId, FilterConditions.Equals, employeeid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.People.Employee from the database by Primary Key.
        /// </summary>
        /// <param name="employeeid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int employeeid)
        {
            var where = new QueryFilters<EmployeeProperty>(1){QueryFilter.New(EmployeeProperty.EmployeeId, FilterConditions.Equals, employeeid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<EmployeeProperty> ComposeKeys(Employee employee)
        {
            return new QueryFilters<EmployeeProperty>{ QueryFilter.New(EmployeeProperty.EmployeeId, FilterConditions.Equals, employee.EmployeeId) };
        }
        protected override QueryFilters<EmployeeProperty> GetChanges(Employee original, Employee changed)
        {
            return EmployeeUtils.GetChanges(original, changed);
        }
        protected override void Merge(Employee source, Employee target)
        {
            EmployeeUtils.Merge(source, target);
        }
        protected override QueryFilters<EmployeeProperty> ComposeInsertPredicate(Employee employee)
        {
            return new QueryFilters<EmployeeProperty>{ QueryFilter.New(EmployeeProperty.LastName, FilterConditions.Equals, employee.LastName), QueryFilter.New(EmployeeProperty.FirstName, FilterConditions.Equals, employee.FirstName), QueryFilter.New(EmployeeProperty.Title, FilterConditions.Equals, employee.Title), QueryFilter.New(EmployeeProperty.ReportsTo, FilterConditions.Equals, employee.ReportsTo), QueryFilter.New(EmployeeProperty.BirthDate, FilterConditions.Equals, employee.BirthDate), QueryFilter.New(EmployeeProperty.HireDate, FilterConditions.Equals, employee.HireDate), QueryFilter.New(EmployeeProperty.Address, FilterConditions.Equals, employee.Address), QueryFilter.New(EmployeeProperty.City, FilterConditions.Equals, employee.City), QueryFilter.New(EmployeeProperty.State, FilterConditions.Equals, employee.State), QueryFilter.New(EmployeeProperty.Country, FilterConditions.Equals, employee.Country), QueryFilter.New(EmployeeProperty.PostalCode, FilterConditions.Equals, employee.PostalCode), QueryFilter.New(EmployeeProperty.Phone, FilterConditions.Equals, employee.Phone), QueryFilter.New(EmployeeProperty.Fax, FilterConditions.Equals, employee.Fax), QueryFilter.New(EmployeeProperty.Email, FilterConditions.Equals, employee.Email) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 15);
        }
        private static Employee MaterializeSingleEntity(SqlDataReader r)
        {
            return new Employee
            {
                EmployeeId = r.GetInt32(0),
                LastName = r.GetString(1),
                FirstName = r.GetString(2),
                Title = r.GetValue(3) as string,
                ReportsTo = r.GetValue(4) as int?,
                BirthDate = r.GetValue(5) as DateTime?,
                HireDate = r.GetValue(6) as DateTime?,
                Address = r.GetValue(7) as string,
                City = r.GetValue(8) as string,
                State = r.GetValue(9) as string,
                Country = r.GetValue(10) as string,
                PostalCode = r.GetValue(11) as string,
                Phone = r.GetValue(12) as string,
                Fax = r.GetValue(13) as string,
                Email = r.GetValue(14) as string,
            };
        }
        /// <summary>
        /// Composes the Navigation Property tree sent to the Database class.
        /// </summary>
        /// <returns>
        /// List of NavPropertyInfo
        /// </returns>
        protected override List<NavPropertyInfo> BuildNavPropInfoTree(NavProps navprops) 
        {
            return BuildNavPropInfos(navprops);
        }
        /// <summary>
        /// Composes the Navigation Property tree sent to the Database class
        /// </summary>
        /// <returns>
        /// List of NavPropertyInfo
        /// </returns>
        internal static List<NavPropertyInfo> BuildNavPropInfos(NavProps navprops) 
        {
            if(!(navprops?.Count > 0))
                    return null;
            var result = new List<NavPropertyInfo>(navprops.Count);
            foreach(var p in navprops)
            {
                var np = (EmployeeNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case EmployeeNavProperty.Customers:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.People.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case EmployeeNavProperty.Employee1:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.People.EmployeeRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return result;
        }
        /// <summary>
        /// Composes the Navigation Property tree materializers.
        /// </summary>
        /// <returns>
        /// List of Func of SqlDataReader, object
        /// </returns>
        protected override List<Func<SqlDataReader, object>> GetNavPropMaterializers(NavProps navprops) 
        {
            return ComposeNavPropMaterializers(navprops);
        }
        internal static List<Func<SqlDataReader, object>> ComposeNavPropMaterializers(NavProps navprops) 
        {
            if(!(navprops?.Count > 0))
                return new List<Func<SqlDataReader, object>>(0);
            var result = new List<Func<SqlDataReader, object>>(navprops.TotalCount);
            foreach(var p in navprops)
            {
                var np = (EmployeeNavProperty)p.Value;
                switch(np)
                {
                    case EmployeeNavProperty.Customers:
                        result.Add(TheSharpFactory.Repository.MainDb.People.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.People.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case EmployeeNavProperty.Employee1:
                        result.Add(TheSharpFactory.Repository.MainDb.People.EmployeeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.People.EmployeeRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return result;
        }
        /// <summary>
        /// Populates the object graph with the materialized results.
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        protected override void BuildObjectGraph(List<Employee> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Employee> ComposeDictionaryByPK(List<Employee> entities, MultiKeyDictionary<int, Employee> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Employee>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.EmployeeId, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Employee> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Employee>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (EmployeeNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case EmployeeNavProperty.Customers:
                    #region Customers
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.People.Customer>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.SupportRepId.Value];
                                p.Customers = AddEntityToList<TheSharpFactory.Entity.MainDb.People.Customer>(p.Customers, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.People.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case EmployeeNavProperty.Employee1:
                    #region Employee1
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.People.Employee>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.People.Employee>();
                            foreach(var p in list)
                                navByKey.Add(p.EmployeeId, p);
                            foreach(var c in entities)
                            {
                                if(!c.ReportsTo.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.ReportsTo.Value))
                                    c.Employee1 = navByKey[c.ReportsTo.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.People.EmployeeRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return resultsetindex;
        }
        #endregion
    }
}
