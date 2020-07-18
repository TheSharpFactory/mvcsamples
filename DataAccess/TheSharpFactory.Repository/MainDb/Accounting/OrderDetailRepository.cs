/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Accounting
{
    public partial class OrderDetailRepository
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

namespace TheSharpFactory.Repository.MainDb.Accounting
{

    /// <summary>
    /// This class represents the Repository for: OrderDetail.
    /// </summary>
    public partial class OrderDetailRepository:WritableRepositoryBase<OrderDetail, OrderDetailProperty>, IOrderDetailRepository
    {
        #region Constructors
        public OrderDetailRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_Accounting_OrderDetail;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK_OrderDetail) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<OrderDetailProperty>(2){ SortFilter.New(OrderDetailProperty.Id), SortFilter.New(OrderDetailProperty.SubId),};
            #endregion
        }
        #endregion
        #region Unique Key Sorting
        //this is the UK(UK_OrderDetail_Name) sorting.
        private static readonly SortFilters<OrderDetailProperty> _sortBy_UK_OrderDetail_Name = new SortFilters<OrderDetailProperty>(1){ SortFilter.New(OrderDetailProperty.Name),};
        #endregion
        #region ById
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Identity.
        /// </summary>
        /// <param name="id">The identity of this Entity.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        public OrderDetail ById(int id)
        {
            var where = new QueryFilters<OrderDetailProperty>(1){QueryFilter.New(OrderDetailProperty.Id, FilterConditions.Equals, id ), };
            return SelectSingle(where, DefaultSort);
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Primary Key.
        /// </summary>
        /// <param name="id">Primary Key Field.</param>
        /// <param name="subid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        public OrderDetail ByPK(int id, string subid)
        {
            var where = new QueryFilters<OrderDetailProperty>(2){QueryFilter.New(OrderDetailProperty.Id, FilterConditions.Equals, id ), QueryFilter.New(OrderDetailProperty.SubId, FilterConditions.Equals, subid ), };
            return SelectSingle(where, DefaultSort);
        }
        #endregion
        #region ByUK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Unique Key named UK_OrderDetail_Name.
        /// </summary>
        /// <param name="name">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        public OrderDetail ByUK(string name)
        {
            //this method uses the UniqueKey UK_OrderDetail_Name
            var where = new QueryFilters<OrderDetailProperty>(1){QueryFilter.New(OrderDetailProperty.Name, FilterConditions.Equals, name ), };
            return SelectSingle(where, _sortBy_UK_OrderDetail_Name);
        }
        #endregion
        #region DeleteById
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Identity.
        /// </summary>
        /// <param name="id">The identity of this Entity.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteById(int id)
        {
            var where = new QueryFilters<OrderDetailProperty>(1){QueryFilter.New(OrderDetailProperty.Id, FilterConditions.Equals, id), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Primary Key.
        /// </summary>
        /// <param name="id">Primary Key Field.</param>
        /// <param name="subid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int id, string subid)
        {
            var where = new QueryFilters<OrderDetailProperty>(2){QueryFilter.New(OrderDetailProperty.Id, FilterConditions.Equals, id), QueryFilter.New(OrderDetailProperty.SubId, FilterConditions.Equals, subid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region DeleteByUK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Unique Key named UK_OrderDetail_Name
        /// </summary>
        /// <param name="name">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByUK(string name)
        {
            //this method uses the UniqueKey UK_OrderDetail_Name
            var where = new QueryFilters<OrderDetailProperty>(1){QueryFilter.New(OrderDetailProperty.Name, FilterConditions.Equals, name), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<OrderDetailProperty> ComposeKeys(OrderDetail orderdetail)
        {
            return new QueryFilters<OrderDetailProperty>{ QueryFilter.New(OrderDetailProperty.Id, FilterConditions.Equals, orderdetail.Id), QueryFilter.New(OrderDetailProperty.SubId, FilterConditions.Equals, orderdetail.SubId) };
        }
        protected override QueryFilters<OrderDetailProperty> GetChanges(OrderDetail original, OrderDetail changed)
        {
            return OrderDetailUtils.GetChanges(original, changed);
        }
        protected override void Merge(OrderDetail source, OrderDetail target)
        {
            OrderDetailUtils.Merge(source, target);
        }
        protected override QueryFilters<OrderDetailProperty> ComposeInsertPredicate(OrderDetail orderdetail)
        {
            return new QueryFilters<OrderDetailProperty>{ QueryFilter.New(OrderDetailProperty.SubId, FilterConditions.Equals, orderdetail.SubId), QueryFilter.New(OrderDetailProperty.Name, FilterConditions.Equals, orderdetail.Name) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 3);
        }
        private static OrderDetail MaterializeSingleEntity(SqlDataReader r)
        {
            return new OrderDetail
            {
                Id = r.GetInt32(0),
                SubId = r.GetString(1),
                Name = r.GetString(2),
            };
        }
        #endregion
    }
}
