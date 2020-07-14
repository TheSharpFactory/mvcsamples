/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Accounting
{
    public partial class InvoiceLineRepository
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
    /// This class represents the Repository for: InvoiceLine.
    /// </summary>
    public partial class InvoiceLineRepository:WritableRepositoryBase<InvoiceLine, InvoiceLineProperty, InvoiceLineNavProperty>, IInvoiceLineRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<InvoiceLineNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<InvoiceLineNavProperty, NavPropertyInfo>(2){ { InvoiceLineNavProperty.Invoice, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Accounting_Invoice, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Accounting.InvoiceLineProperty.InvoiceId, OtherPropId = (int)MainDbE.Accounting.InvoiceProperty.InvoiceId, },} } }, { InvoiceLineNavProperty.Track, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_Track, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Accounting.InvoiceLineProperty.TrackId, OtherPropId = (int)MainDbE.Media.TrackProperty.TrackId, },} } },};
        #endregion
        #region Constructors
        public InvoiceLineRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_Accounting_InvoiceLine;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__InvoiceL__0D760AD91DE57479) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<InvoiceLineProperty>(1){ SortFilter.New(InvoiceLineProperty.InvoiceLineId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine from the database by Primary Key.
        /// </summary>
        /// <param name="invoicelineid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine</returns>
        public InvoiceLine ByPK(int invoicelineid)
        {
            var where = new QueryFilters<InvoiceLineProperty>(1){QueryFilter.New(InvoiceLineProperty.InvoiceLineId, FilterConditions.Equals, invoicelineid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="invoicelineid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine</returns>
        public InvoiceLine ByPK(int invoicelineid, NavProps<InvoiceLineNavProperty> navprops)
        {
            var where = new QueryFilters<InvoiceLineProperty>(1){QueryFilter.New(InvoiceLineProperty.InvoiceLineId, FilterConditions.Equals, invoicelineid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine from the database by Primary Key.
        /// </summary>
        /// <param name="invoicelineid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int invoicelineid)
        {
            var where = new QueryFilters<InvoiceLineProperty>(1){QueryFilter.New(InvoiceLineProperty.InvoiceLineId, FilterConditions.Equals, invoicelineid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<InvoiceLineProperty> ComposeKeys(InvoiceLine invoiceline)
        {
            return new QueryFilters<InvoiceLineProperty>{ QueryFilter.New(InvoiceLineProperty.InvoiceLineId, FilterConditions.Equals, invoiceline.InvoiceLineId) };
        }
        protected override QueryFilters<InvoiceLineProperty> GetChanges(InvoiceLine original, InvoiceLine changed)
        {
            return InvoiceLineUtils.GetChanges(original, changed);
        }
        protected override void Merge(InvoiceLine source, InvoiceLine target)
        {
            InvoiceLineUtils.Merge(source, target);
        }
        protected override QueryFilters<InvoiceLineProperty> ComposeInsertPredicate(InvoiceLine invoiceline)
        {
            return new QueryFilters<InvoiceLineProperty>{ QueryFilter.New(InvoiceLineProperty.InvoiceId, FilterConditions.Equals, invoiceline.InvoiceId), QueryFilter.New(InvoiceLineProperty.TrackId, FilterConditions.Equals, invoiceline.TrackId), QueryFilter.New(InvoiceLineProperty.UnitPrice, FilterConditions.Equals, invoiceline.UnitPrice), QueryFilter.New(InvoiceLineProperty.Quantity, FilterConditions.Equals, invoiceline.Quantity) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 5);
        }
        private static InvoiceLine MaterializeSingleEntity(SqlDataReader r)
        {
            return new InvoiceLine
            {
                InvoiceLineId = r.GetInt32(0),
                InvoiceId = r.GetInt32(1),
                TrackId = r.GetInt32(2),
                UnitPrice = r.GetDecimal(3),
                Quantity = r.GetInt32(4),
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
                var np = (InvoiceLineNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case InvoiceLineNavProperty.Invoice:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Accounting.InvoiceRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case InvoiceLineNavProperty.Track:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.TrackRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (InvoiceLineNavProperty)p.Value;
                switch(np)
                {
                    case InvoiceLineNavProperty.Invoice:
                        result.Add(TheSharpFactory.Repository.MainDb.Accounting.InvoiceRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Accounting.InvoiceRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case InvoiceLineNavProperty.Track:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.TrackRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.TrackRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<InvoiceLine> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        internal static int PopulateNavProperties(List<InvoiceLine> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (InvoiceLineNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case InvoiceLineNavProperty.Invoice:
                    #region Invoice
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Accounting.Invoice>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.Accounting.Invoice>();
                            foreach(var p in list)
                                navByKey.Add(p.InvoiceId, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.InvoiceId))
                                    c.Invoice = navByKey[c.InvoiceId];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Accounting.InvoiceRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case InvoiceLineNavProperty.Track:
                    #region Track
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.Track>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.Media.Track>();
                            foreach(var p in list)
                                navByKey.Add(p.TrackId, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.TrackId))
                                    c.Track = navByKey[c.TrackId];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.TrackRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
