/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.People
{
    public partial class CustomerRepository
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
    /// This class represents the Repository for: Customer.
    /// </summary>
    public partial class CustomerRepository:WritableRepositoryBase<Customer, CustomerProperty, CustomerNavProperty>, ICustomerRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<CustomerNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<CustomerNavProperty, NavPropertyInfo>(2){ { CustomerNavProperty.Invoices, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Accounting_Invoice, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.People.CustomerProperty.CustomerId, OtherPropId = (int)MainDbE.Accounting.InvoiceProperty.CustomerId, },} } }, { CustomerNavProperty.Employee, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_People_Employee, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.People.CustomerProperty.SupportRepId, OtherPropId = (int)MainDbE.People.EmployeeProperty.EmployeeId, },} } },};
        #endregion
        #region Constructors
        public CustomerRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_People_Customer;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__Customer__A4AE64D8164452B1) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<CustomerProperty>(1){ SortFilter.New(CustomerProperty.CustomerId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.People.Customer from the database by Primary Key.
        /// </summary>
        /// <param name="customerid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Customer</returns>
        public Customer ByPK(int customerid)
        {
            var where = new QueryFilters<CustomerProperty>(1){QueryFilter.New(CustomerProperty.CustomerId, FilterConditions.Equals, customerid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.People.Customer from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="customerid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Customer</returns>
        public Customer ByPK(int customerid, NavProps<CustomerNavProperty> navprops)
        {
            var where = new QueryFilters<CustomerProperty>(1){QueryFilter.New(CustomerProperty.CustomerId, FilterConditions.Equals, customerid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.People.Customer from the database by Primary Key.
        /// </summary>
        /// <param name="customerid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int customerid)
        {
            var where = new QueryFilters<CustomerProperty>(1){QueryFilter.New(CustomerProperty.CustomerId, FilterConditions.Equals, customerid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<CustomerProperty> ComposeKeys(Customer customer)
        {
            return new QueryFilters<CustomerProperty>{ QueryFilter.New(CustomerProperty.CustomerId, FilterConditions.Equals, customer.CustomerId) };
        }
        protected override QueryFilters<CustomerProperty> GetChanges(Customer original, Customer changed)
        {
            return CustomerUtils.GetChanges(original, changed);
        }
        protected override void Merge(Customer source, Customer target)
        {
            CustomerUtils.Merge(source, target);
        }
        protected override QueryFilters<CustomerProperty> ComposeInsertPredicate(Customer customer)
        {
            return new QueryFilters<CustomerProperty>{ QueryFilter.New(CustomerProperty.FirstName, FilterConditions.Equals, customer.FirstName), QueryFilter.New(CustomerProperty.LastName, FilterConditions.Equals, customer.LastName), QueryFilter.New(CustomerProperty.Company, FilterConditions.Equals, customer.Company), QueryFilter.New(CustomerProperty.Address, FilterConditions.Equals, customer.Address), QueryFilter.New(CustomerProperty.City, FilterConditions.Equals, customer.City), QueryFilter.New(CustomerProperty.State, FilterConditions.Equals, customer.State), QueryFilter.New(CustomerProperty.Country, FilterConditions.Equals, customer.Country), QueryFilter.New(CustomerProperty.PostalCode, FilterConditions.Equals, customer.PostalCode), QueryFilter.New(CustomerProperty.Phone, FilterConditions.Equals, customer.Phone), QueryFilter.New(CustomerProperty.Fax, FilterConditions.Equals, customer.Fax), QueryFilter.New(CustomerProperty.Email, FilterConditions.Equals, customer.Email), QueryFilter.New(CustomerProperty.SupportRepId, FilterConditions.Equals, customer.SupportRepId) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 13);
        }
        private static Customer MaterializeSingleEntity(SqlDataReader r)
        {
            return new Customer
            {
                CustomerId = r.GetInt32(0),
                FirstName = r.GetString(1),
                LastName = r.GetString(2),
                Company = r.GetValue(3) as string,
                Address = r.GetValue(4) as string,
                City = r.GetValue(5) as string,
                State = r.GetValue(6) as string,
                Country = r.GetValue(7) as string,
                PostalCode = r.GetValue(8) as string,
                Phone = r.GetValue(9) as string,
                Fax = r.GetValue(10) as string,
                Email = r.GetString(11),
                SupportRepId = r.GetValue(12) as int?,
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
                var np = (CustomerNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case CustomerNavProperty.Invoices:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Accounting.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case CustomerNavProperty.Employee:
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
                var np = (CustomerNavProperty)p.Value;
                switch(np)
                {
                    case CustomerNavProperty.Invoices:
                        result.Add(TheSharpFactory.Repository.MainDb.Accounting.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Accounting.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case CustomerNavProperty.Employee:
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
        protected override void BuildObjectGraph(List<Customer> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Customer> ComposeDictionaryByPK(List<Customer> entities, MultiKeyDictionary<int, Customer> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Customer>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.CustomerId, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Customer> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Customer>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (CustomerNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case CustomerNavProperty.Invoices:
                    #region Invoices
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Accounting.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.CustomerId];
                                p.Invoices = AddEntityToList<TheSharpFactory.Entity.MainDb.Accounting.Invoice>(p.Invoices, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Accounting.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case CustomerNavProperty.Employee:
                    #region Employee
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.People.Employee>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.People.Employee>();
                            foreach(var p in list)
                                navByKey.Add(p.EmployeeId, p);
                            foreach(var c in entities)
                            {
                                if(!c.SupportRepId.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.SupportRepId.Value))
                                    c.Employee = navByKey[c.SupportRepId.Value];
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
