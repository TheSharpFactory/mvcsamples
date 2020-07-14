/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Accounting
{
    public partial class InvoiceRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Repository.Common;
using TheSharpFactory.Repository.Interfaces.MainDb.Accounting;
using TheSharpFactory.Query;
using TheSharpFactory.Entity.MainDb.Accounting;
using TheSharpFactory.Entity.Utils.MainDb.Accounting;
using MainDbE = TheSharpFactory.Entity.MainDb;

namespace TheSharpFactory.Repository.MainDb.Accounting
{

    /// <summary>
    /// This class represents the Repository for: Invoice.
    /// </summary>
    public partial class InvoiceRepository:WritableRepositoryBase<Invoice, InvoiceProperty, InvoiceNavProperty>, IInvoiceRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<InvoiceNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<InvoiceNavProperty, NavPropertyInfo>(2){ { InvoiceNavProperty.Customer, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_People_Customer, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Accounting.InvoiceProperty.CustomerId, OtherPropId = (int)MainDbE.People.CustomerProperty.CustomerId, },} } }, { InvoiceNavProperty.InvoiceLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Accounting_InvoiceLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Accounting.InvoiceProperty.InvoiceId, OtherPropId = (int)MainDbE.Accounting.InvoiceLineProperty.InvoiceId, },} } },};
        #endregion
        #region Constructors
        public InvoiceRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_Accounting_Invoice;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__Invoice__D796AAB51A14E395) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<InvoiceProperty>(1){ SortFilter.New(InvoiceProperty.InvoiceId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Accounting.Invoice from the database by Primary Key.
        /// </summary>
        /// <param name="invoiceid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.Invoice</returns>
        public Invoice ByPK(int invoiceid)
        {
            var where = new QueryFilters<InvoiceProperty>(1){QueryFilter.New(InvoiceProperty.InvoiceId, FilterConditions.Equals, invoiceid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Accounting.Invoice from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="invoiceid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.Invoice</returns>
        public Invoice ByPK(int invoiceid, NavProps<InvoiceNavProperty> navprops)
        {
            var where = new QueryFilters<InvoiceProperty>(1){QueryFilter.New(InvoiceProperty.InvoiceId, FilterConditions.Equals, invoiceid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Accounting.Invoice from the database by Primary Key.
        /// </summary>
        /// <param name="invoiceid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int invoiceid)
        {
            var where = new QueryFilters<InvoiceProperty>(1){QueryFilter.New(InvoiceProperty.InvoiceId, FilterConditions.Equals, invoiceid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<InvoiceProperty> ComposeKeys(Invoice invoice)
        {
            return new QueryFilters<InvoiceProperty>{ QueryFilter.New(InvoiceProperty.InvoiceId, FilterConditions.Equals, invoice.InvoiceId) };
        }
        protected override QueryFilters<InvoiceProperty> GetChanges(Invoice original, Invoice changed)
        {
            return InvoiceUtils.GetChanges(original, changed);
        }
        protected override void Merge(Invoice source, Invoice target)
        {
            InvoiceUtils.Merge(source, target);
        }
        protected override QueryFilters<InvoiceProperty> ComposeInsertPredicate(Invoice invoice)
        {
            return new QueryFilters<InvoiceProperty>{ QueryFilter.New(InvoiceProperty.CustomerId, FilterConditions.Equals, invoice.CustomerId), QueryFilter.New(InvoiceProperty.InvoiceDate, FilterConditions.Equals, invoice.InvoiceDate), QueryFilter.New(InvoiceProperty.BillingAddress, FilterConditions.Equals, invoice.BillingAddress), QueryFilter.New(InvoiceProperty.BillingCity, FilterConditions.Equals, invoice.BillingCity), QueryFilter.New(InvoiceProperty.BillingState, FilterConditions.Equals, invoice.BillingState), QueryFilter.New(InvoiceProperty.BillingCountry, FilterConditions.Equals, invoice.BillingCountry), QueryFilter.New(InvoiceProperty.BillingPostalCode, FilterConditions.Equals, invoice.BillingPostalCode), QueryFilter.New(InvoiceProperty.Total, FilterConditions.Equals, invoice.Total) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 9);
        }
        private static Invoice MaterializeSingleEntity(SqlDataReader r)
        {
            return new Invoice
            {
                InvoiceId = r.GetInt32(0),
                CustomerId = r.GetInt32(1),
                InvoiceDate = r.GetDateTime(2),
                BillingAddress = r.GetValue(3) as string,
                BillingCity = r.GetValue(4) as string,
                BillingState = r.GetValue(5) as string,
                BillingCountry = r.GetValue(6) as string,
                BillingPostalCode = r.GetValue(7) as string,
                Total = r.GetDecimal(8),
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
                var np = (InvoiceNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case InvoiceNavProperty.Customer:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.People.CustomerRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceNavProperty.InvoiceLines:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Accounting.InvoiceLineRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (InvoiceNavProperty)p.Value;
                switch(np)
                {
                    case InvoiceNavProperty.Customer:
                        result.Add(TheSharpFactory.Repository.MainDb.People.CustomerRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.People.CustomerRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceNavProperty.InvoiceLines:
                        result.Add(TheSharpFactory.Repository.MainDb.Accounting.InvoiceLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Accounting.InvoiceLineRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<Invoice> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Invoice> ComposeDictionaryByPK(List<Invoice> entities, MultiKeyDictionary<int, Invoice> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Invoice>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.InvoiceId, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Invoice> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Invoice>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (InvoiceNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case InvoiceNavProperty.Customer:
                    #region Customer
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.People.Customer>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.People.Customer>();
                            foreach(var p in list)
                                navByKey.Add(p.CustomerId, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.CustomerId))
                                    c.Customer = navByKey[c.CustomerId];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.People.CustomerRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceNavProperty.InvoiceLines:
                    #region InvoiceLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.InvoiceId];
                                p.InvoiceLines = AddEntityToList<TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine>(p.InvoiceLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Accounting.InvoiceLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
